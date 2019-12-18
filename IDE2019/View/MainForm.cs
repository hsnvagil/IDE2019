using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using FastColoredTextBoxNS;
using IDE2019.Models;
using Microsoft.CSharp;

namespace IDE2019.Views
{
    public partial class MainForm : Form, IMainForm
    {

        public event EventHandler<EventArgs> NewProjectEvent;
        public event EventHandler<ProjectEventArgs> AddPageEvent;
        public event EventHandler<ProjectEventArgs> RunEvent;
        public event EventHandler<ProjectEventArgs> BuildEvent;
        public event EventHandler<EventArgs> AddCSEvent;
        public event EventHandler<OpenFileEventArgs> OpenProjectEvent;
        public event EventHandler<OpenFileEventArgs> OpenFileEvent;
        public event EventHandler<SerializationEventArgs> SerializationEvent; 
        public event EventHandler<ProjectEventArgs> SaveFileEvent;
        public event EventHandler<RemoveFileEventArgs> RemoveFileEvent;

        TreeNode CNode;
        public void Start()
        {
            Application.Run(new StartForm());
        }
        public MainForm()
        {
            Thread t = new Thread(new ThreadStart(Start));
            t.Start();
            Thread.Sleep(5000);
            t.Abort();
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private Project proj = new Project();

        public void AddCS(CS cS)
        {
            if (cS != null)
            {
                this.proj.csfile.Add(cS);
                SerializationEvent?.Invoke(this, new SerializationEventArgs() { project = this.proj });
                AddPageEvent?.Invoke(this, new ProjectEventArgs() { cS = this.proj.csfile[this.proj.csfile.Count - 1] });
                AddFileIs(CNode, this.proj.csfile[this.proj.csfile.Count - 1]);
            }
        }
        private void AddFileIs(TreeNode node, CS cS)
        {
            TreeNode prodNode = new TreeNode(cS.Name) { };
            prodNode.ContextMenuStrip = contextMenuStripEditCS;
            node.Nodes.Add(prodNode);
        }
        public void AddPage(TabPage tabPage)
        {
            tabPage.ContextMenuStrip = contextMenuStripEdit;
            tabControlCode.TabPages.Add(tabPage);
            tabControlCode.SelectedTab = tabPage;
        }
        public void SetErrors(CompilerResults result)
        {
            int k = 0;
            if (result.Errors != null)
            {
                listViewCompileInfo.Items.Clear();
                foreach (CompilerError error in result.Errors)
                {
                    tabControlBuildRun.SelectedIndex = 0;
                    listViewCompileInfo.Items.Add(new ListViewItem(new string[] { error.ErrorNumber, error.ErrorText, Convert.ToString(error.Line), error.FileName }));
                    k++;
                }
            }
            if (result.Output != null)
            {
                richTextBox1.Text = "";
                foreach (var item in result.Output)
                {
                    richTextBox1.Text += item;
                }
            }
        }
        public void SetProject(Project project)
        {
            this.proj = project;

            string xmlFile = project.Path + @"\" + project.Name + @"\" + project.Name + ".mysln";
            XmlTextWriter xmlWriter = new XmlTextWriter(xmlFile, null);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("project");
            xmlWriter.WriteAttributeString("name", project.Name);
            xmlWriter.WriteStartElement("outputfile");
            xmlWriter.WriteAttributeString("path", project.Name + ".exe");
            xmlWriter.WriteEndElement();

            foreach (var item in project.csfile)
            {
                xmlWriter.WriteStartElement("csfile");
                xmlWriter.WriteAttributeString("path", item.Path);
                xmlWriter.WriteAttributeString("name", item.Name);
                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();

            Build_ToolStripButton.Enabled = true;
            Run_ToolStripButton.Enabled = true;
            tabControlCode.Enabled = true;
            ProjectExplorerTreeView.Nodes.Clear();
            tabControlCode.TabPages.Clear();
            var Node = ProjectExplorerTreeView.Nodes.Add(this.proj.Name);
            Node.ContextMenuStrip = contextMenuStripProject;
            CNode = Node;

            foreach (var item in this.proj.csfile)
            {
                AddFileIs(CNode, item);
                AddPageEvent?.Invoke(this, new ProjectEventArgs() { cS = item as CS });
            }
        }
        public void GetProject(Project project)
        {

            this.proj = project;

            string xmlFile = project.Path + @"\" + project.Name + ".mysln";

            XmlTextWriter xmlWriter = new XmlTextWriter(xmlFile, null);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("project");
            xmlWriter.WriteAttributeString("name", project.Name);
            xmlWriter.WriteStartElement("outputfile");
            xmlWriter.WriteAttributeString("path", project.Name + ".exe");
            xmlWriter.WriteEndElement();

            foreach (var item in project.csfile)
            {
                xmlWriter.WriteStartElement("csfile");
                xmlWriter.WriteAttributeString("path", item.Path);
                xmlWriter.WriteAttributeString("name", item.Name);
                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();

            Build_ToolStripButton.Enabled = true;
            Run_ToolStripButton.Enabled = true;
            tabControlCode.Enabled = true;
            ProjectExplorerTreeView.Nodes.Clear();
            tabControlCode.TabPages.Clear();
            var Node = ProjectExplorerTreeView.Nodes.Add(this.proj.Name);
            Node.ContextMenuStrip = contextMenuStripProject;
            CNode = Node;

            foreach (var item in this.proj.csfile)
            {
                AddFileIs(CNode, item);
                AddPageEvent?.Invoke(this, new ProjectEventArgs() { cS = item as CS });
            }

        }
        bool IView.ShowDialog()
        {
            return this.ShowDialog() == DialogResult.OK;
        }


        #region OpenProject OpenFile
        private void OpenProject_ToolStripButton_Click(object sender, EventArgs e)
        {
            string filePath;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\ACER\source\repos\IDE2019";
                openFileDialog.Filter = "All files (*.*)|*.*|mysln files (*.mysln)|*.mysln";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    OpenProjectEvent?.Invoke(this, new OpenFileEventArgs() { path = filePath });
                }
            }
        }
        private void OpenFile_ToolStripButton_Click(object sender, EventArgs e)
        {
            string filePath;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\ACER\source\repos\IDE2019";
                openFileDialog.Filter = "All files (*.*)|*.*|cs files (*.cs)|*.cs";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    OpenFileEvent?.Invoke(this, new OpenFileEventArgs() { path = filePath });
                }
            }
        }
        #endregion

        #region NewProject NewFile
        private void NewProject_ToolStripButton_Click(object sender, EventArgs e)
        {
            NewProjectEvent?.Invoke(this, new EventArgs());
        }
        private void NewFile_ToolStripButton_Click(object sender, EventArgs e)
        {
            AddCSEvent?.Invoke(this, new EventArgs());
        }
        #endregion

        #region Save SaveAll
        private void Save_ToolStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tabControlCode.TabCount; i++)
            {
                if (tabControlCode.TabPages[i].Focus())
                {
                    foreach (FastColoredTextBox item in tabControlCode.TabPages[i].Controls)
                    {
                        if (item is FastColoredTextBox)
                        {
                            this.proj.csfile[i].Text = item.Text;
                            SaveFileEvent?.Invoke(this, new ProjectEventArgs() { cS = this.proj.csfile[i] });
                            break;
                        }
                    }
                }
            }
        }
        private void SaveAll_ToolStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tabControlCode.TabCount; i++)
            {
                foreach (FastColoredTextBox item in tabControlCode.TabPages[i].Controls)
                {
                    if (item is FastColoredTextBox)
                    {
                        this.proj.csfile[i].Text = item.Text;
                        SaveFileEvent?.Invoke(this, new ProjectEventArgs() { cS = this.proj.csfile[i] });
                    }
                }
            }
        }
        #endregion

        #region Cut Copy Paste
        private void Cut_ToolStripButton_Click(object sender, EventArgs e)
        {
            if (tabControlCode.TabCount > 0)
            {
                FastColoredTextBox textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;
                textBox.Cut();
                textBox.Focus();
            }
        }
        private void Copy_ToolStripButton_Click(object sender, EventArgs e)
        {
            if (tabControlCode.TabCount > 0)
            {
                FastColoredTextBox textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;
                textBox.Copy();
                textBox.Focus();
            }
        }
        private void Paste_ToolStripButton_Click(object sender, EventArgs e)
        {
            if (tabControlCode.TabCount > 0)
            {
                FastColoredTextBox textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;
                textBox.Paste();
                textBox.Focus();
            }
        }
        #endregion

        #region Build Run
        private void Run_ToolStripButton_Click(object sender, EventArgs e)
        {
            for (int z = 0; z < tabControlCode.TabCount; z++)
            {
                for (int k = 0; k < proj.csfile.Count; k++)
                {
                    if (proj.csfile[k].Name == tabControlCode.TabPages[z].Text)
                    {
                        foreach (FastColoredTextBox item in tabControlCode.TabPages[z].Controls)
                        {
                            this.proj.csfile[k].Text = item.Text;
                        }
                    }
                }
            }
            RunEvent?.Invoke(this, new ProjectEventArgs() { project = this.proj });
        }
        private void Build_ToolStripButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tabControlCode.TabCount; i++)
            {
                if (tabControlCode.TabPages[i].Focus())
                {
                    foreach (FastColoredTextBox item in tabControlCode.TabPages[i].Controls)
                    {
                        if (item is FastColoredTextBox)
                        {
                            this.proj.csfile[i].Text = item.Text;
                        }
                    }
                }
            }
            BuildEvent?.Invoke(this, new ProjectEventArgs() { project = this.proj });
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void LineUp_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastColoredTextBox textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;

            textBox.MoveSelectedLinesUp();
        }
        private void LineDown_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastColoredTextBox textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;

            textBox.MoveSelectedLinesDown();
        }
        private void View_ErrorListMenuItem_Click(object sender, EventArgs e)
        {
            if (!View_ErrorListMenuItem.Checked)
                splitContainer1.Panel2Collapsed = true;
            else
                splitContainer1.Panel2Collapsed = false;
        }
        private void View_ProjectExplorerMenuItem_Click(object sender, EventArgs e)
        {
            if (!View_ProjectExplorerMenuItem.Checked)
                splitContainer2.Panel1Collapsed = true;
            else
                splitContainer2.Panel1Collapsed = false;
        }
        private void View_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!View_ToolStripMenuItem.Checked)
                toolStrip1.Visible = false;
            else
                toolStrip1.Visible = true;
        }
        private void View_FullScreenMenuItem_Click(object sender, EventArgs e)
        {
            if (View_FullScreenMenuItem.Checked == true)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }
        private void WordWrap_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FastColoredTextBox textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;

            if (!wordWrapToolStripMenuItem.Checked)
            {
                textBox.WordWrap = true;
                wordWrapToolStripMenuItem.Checked = true;
            }
            else
            {
                textBox.WordWrap = false;
                wordWrapToolStripMenuItem.Checked = false;
            }
        }
        private void LineNumbers_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControlCode.TabCount > 0)
            {
                FastColoredTextBox textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;

                if (!lineNumbersToolStripMenuItem.Checked)
                {
                    textBox.ShowLineNumbers = true;
                    lineNumbersToolStripMenuItem.Checked = true;
                }
                else
                {
                    textBox.ShowLineNumbers = false;
                    lineNumbersToolStripMenuItem.Checked = false;
                }
            }
        }
        private void Comment_ToolStripButton_Click(object sender, EventArgs e)
        {
            if (tabControlCode.TabCount > 0)
            {
                FastColoredTextBox textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;
                textBox.CommentSelected();
            }
        }
        private void Undo_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControlCode.TabCount > 0)
            {
                FastColoredTextBox textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;
                textBox.Undo();
            }
        }
        private void Redo_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControlCode.TabCount > 0)
            {
                FastColoredTextBox textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;
                textBox.Redo();
            }
        }
        private void Find_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControlCode.TabCount > 0)
            {
                FastColoredTextBox textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;
                textBox.ShowFindDialog();
            }
        }
        private void Replace_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControlCode.TabCount > 0)
            {
                FastColoredTextBox textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;
                textBox.ShowReplaceDialog();
            }
        }
        private void GoTo_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControlCode.TabCount > 0)
            {
                FastColoredTextBox textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;
                textBox.ShowGoToDialog();
            }
        }
        private void View_TabsAlignment_TopMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControlCode.TabCount > 0)
            {
                if (!View_TabsAlignment_TopMenuItem.Checked)
                {
                    tabControlCode.Alignment = TabAlignment.Top;
                    View_TabsAlignment_TopMenuItem.Checked = true;
                    View_TabsAlignment_BottomMenuItem.Checked = false;
                }
                else
                {
                    tabControlCode.Alignment = TabAlignment.Bottom;
                    View_TabsAlignment_TopMenuItem.Checked = false;
                    View_TabsAlignment_BottomMenuItem.Checked = true;
                }
            }
        }
        private void View_TabsAlignment_BottomMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControlCode.TabCount > 0)
            {
                if (!View_TabsAlignment_BottomMenuItem.Checked)
                {
                    tabControlCode.Alignment = TabAlignment.Bottom;
                    View_TabsAlignment_BottomMenuItem.Checked = true;
                    View_TabsAlignment_TopMenuItem.Checked = false;
                }
                else
                {
                    tabControlCode.Alignment = TabAlignment.Top;
                    View_TabsAlignment_BottomMenuItem.Checked = false;
                    View_TabsAlignment_TopMenuItem.Checked = true;
                }
            }
        }
        private void RemoveFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CNode.Nodes.Count; i++)
            {
                if (CNode.Nodes[i].IsSelected)
                {
                    RemoveFileEvent?.Invoke(this, new RemoveFileEventArgs() { project = this.proj, cS = this.proj.csfile[i] });
                }

            }
        }
        private void ClosePage_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlCode.TabPages.Remove(tabControlCode.SelectedTab);
        }
        private void CloseProject_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void ProjectExplorerTreeView_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < tabControlCode.TabCount; i++)
            {
                if(tabControlCode.TabPages[i].Text == ProjectExplorerTreeView.SelectedNode.Text)
                {
                    tabControlCode.SelectedIndex = i;
                }
            }

            bool c = false;
            for (int i = 0; i < tabControlCode.TabCount; i++)
            {
                if (tabControlCode.TabPages[i].Text == ProjectExplorerTreeView.SelectedNode.Text)
                {
                    c = true;
                }
            }

            if(c == false &&  ProjectExplorerTreeView.SelectedNode.Text != ProjectExplorerTreeView.TopNode.Text)
            {
                string path = proj.Path + @"\" + ProjectExplorerTreeView.SelectedNode.Text;
                string text;
                try
                {
                text = System.IO.File.ReadAllText(path);
                }
                catch
                {

                    path = proj.Path + @"\" + proj.Name + @"\" + ProjectExplorerTreeView.SelectedNode.Text;
                    text = System.IO.File.ReadAllText(path);
                }
                TabPage tabPage = new TabPage(ProjectExplorerTreeView.SelectedNode.Text);

                FastColoredTextBox textBox = new FastColoredTextBox();
                textBox.Dock = DockStyle.Fill;
                textBox.ContextMenuStrip = contextMenuStripEdit;
                textBox.Language = Language.CSharp;
                textBox.Text = text;

                tabPage.Controls.Add(textBox);
                tabControlCode.Controls.Add(tabPage);
            }
        }
        private void File_ExitMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to save files?", "IDE 2019", MessageBoxButtons.YesNoCancel);
            if(res == DialogResult.Yes)
            {
                SaveAll_ToolStripButton_Click(sender,e);
                this.Close();
            }
            else if(res == DialogResult.No)
            {
                this.Close();
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
                DialogResult res = MessageBox.Show("Do you want to save files?", "IDE 2019", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    SaveAll_ToolStripButton_Click(sender, e);
                    e.Cancel = false;
                }
                else if (res == DialogResult.No)
                {
                    e.Cancel = false;
                }
                else
                    e.Cancel = true;
        }
    }
}
