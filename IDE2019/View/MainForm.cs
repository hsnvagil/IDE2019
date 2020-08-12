using System;
using System.CodeDom.Compiler;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using FastColoredTextBoxNS;
using IDE2019.Model;

namespace IDE2019.View {
    public partial class MainForm : Form, IMainForm {
        public event EventHandler<EventArgs> NewProjectEvent;
        public event EventHandler<ProjectEventArgs> AddPageEvent;
        public event EventHandler<ProjectEventArgs> RunEvent;
        public event EventHandler<ProjectEventArgs> BuildEvent;
        public event EventHandler<EventArgs> AddCsEvent;
        public event EventHandler<OpenFileEventArgs> OpenProjectEvent;
        public event EventHandler<OpenFileEventArgs> OpenFileEvent;
        public event EventHandler<SerializationEventArgs> SerializationEvent;
        public event EventHandler<ProjectEventArgs> SaveFileEvent;
        public event EventHandler<RemoveFileEventArgs> RemoveFileEvent;

        private TreeNode _cNode;

        private static void Start() {
            Application.Run(new StartForm());
        }

        public MainForm() {
            var t = new Thread(Start);
            t.Start();
            Thread.Sleep(5000);
            t.Abort();
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private Project _proj = new Project();

        public void AddCs(Cs cS) {
            if (cS != null) {
                _proj.CsFile.Add(cS);
                SerializationEvent?.Invoke(this, new SerializationEventArgs {Project = _proj});
                AddPageEvent?.Invoke(this, new ProjectEventArgs {Cs = _proj.CsFile[_proj.CsFile.Count - 1]});
                AddFileIs(_cNode, _proj.CsFile[_proj.CsFile.Count - 1]);
            }
        }

        private void AddFileIs(TreeNode node, Cs cS) {
            var prodNode = new TreeNode(cS.Name) {ContextMenuStrip = contextMenuStripEditCS};
            node.Nodes.Add(prodNode);
        }

        public void AddPage(TabPage tabPage) {
            tabPage.ContextMenuStrip = contextMenuStripEdit;
            tabControlCode.TabPages.Add(tabPage);
            tabControlCode.SelectedTab = tabPage;
        }

        public void SetErrors(CompilerResults result) {
            var k = 0;
            if (result.Errors != null) {
                listViewCompileInfo.Items.Clear();
                foreach (CompilerError error in result.Errors) {
                    tabControlBuildRun.SelectedIndex = 0;
                    listViewCompileInfo.Items.Add(new ListViewItem(new[] {
                        error.ErrorNumber, error.ErrorText, Convert.ToString(error.Line), error.FileName
                    }));
                    k++;
                }
            }

            if (result.Output != null) {
                richTextBox1.Text = "";
                foreach (var item in result.Output) richTextBox1.Text += item;
            }
        }

        public void SetProject(Project project) {
            _proj = project;

            var xmlFile = project.Path + @"\" + project.Name + @"\" + project.Name + ".mysln";
            var xmlWriter = new XmlTextWriter(xmlFile, null);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("project");
            xmlWriter.WriteAttributeString("name", project.Name);
            xmlWriter.WriteStartElement("outputfile");
            xmlWriter.WriteAttributeString("path", project.Name + ".exe");
            xmlWriter.WriteEndElement();

            foreach (var item in project.CsFile) {
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
            var node = ProjectExplorerTreeView.Nodes.Add(_proj.Name);
            node.ContextMenuStrip = contextMenuStripProject;
            _cNode = node;

            foreach (var item in _proj.CsFile) {
                AddFileIs(_cNode, item);
                AddPageEvent?.Invoke(this, new ProjectEventArgs {Cs = item});
            }
        }

        public void GetProject(Project project) {
            _proj = project;

            var xmlFile = project.Path + @"\" + project.Name + ".mysln";

            var xmlWriter = new XmlTextWriter(xmlFile, null);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("project");
            xmlWriter.WriteAttributeString("name", project.Name);
            xmlWriter.WriteStartElement("outputfile");
            xmlWriter.WriteAttributeString("path", project.Name + ".exe");
            xmlWriter.WriteEndElement();

            foreach (var item in project.CsFile) {
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
            var node = ProjectExplorerTreeView.Nodes.Add(_proj.Name);
            node.ContextMenuStrip = contextMenuStripProject;
            _cNode = node;

            foreach (var item in _proj.CsFile) {
                AddFileIs(_cNode, item);
                AddPageEvent?.Invoke(this, new ProjectEventArgs {Cs = item});
            }
        }

        bool IView.ShowDialog() {
            return ShowDialog() == DialogResult.OK;
        }


        #region OpenProject OpenFile

        private void OpenProject_ToolStripButton_Click(object sender, EventArgs e) {
            using (var openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = @"C:\Users\ACER\source\repos\IDE2019";
                openFileDialog.Filter = "All files (*.*)|*.*|mysln files (*.mysln)|*.mysln";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    var filePath = openFileDialog.FileName;
                    OpenProjectEvent?.Invoke(this, new OpenFileEventArgs {Path = filePath});
                }
            }
        }

        private void OpenFile_ToolStripButton_Click(object sender, EventArgs e) {
            using (var openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = @"C:\Users\ACER\source\repos\IDE2019";
                openFileDialog.Filter = "All files (*.*)|*.*|cs files (*.cs)|*.cs";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    var filePath = openFileDialog.FileName;
                    OpenFileEvent?.Invoke(this, new OpenFileEventArgs {Path = filePath});
                }
            }
        }

        #endregion

        #region NewProject NewFile

        private void NewProject_ToolStripButton_Click(object sender, EventArgs e) {
            NewProjectEvent?.Invoke(this, new EventArgs());
        }

        private void NewFile_ToolStripButton_Click(object sender, EventArgs e) {
            AddCsEvent?.Invoke(this, new EventArgs());
        }

        #endregion

        #region Save SaveAll

        private void Save_ToolStripButton_Click(object sender, EventArgs e) {
            for (var i = 0; i < tabControlCode.TabCount; i++) {
                if (!tabControlCode.TabPages[i].Focus()) continue;
                foreach (FastColoredTextBox item in tabControlCode.TabPages[i].Controls) {
                    if (!(item is FastColoredTextBox)) continue;
                    _proj.CsFile[i].Text = item.Text;
                    SaveFileEvent?.Invoke(this, new ProjectEventArgs {Cs = _proj.CsFile[i]});
                    break;
                }
            }
        }

        private void SaveAll_ToolStripButton_Click(object sender, EventArgs e) {
            for (var i = 0; i < tabControlCode.TabCount; i++)
                foreach (FastColoredTextBox item in tabControlCode.TabPages[i].Controls) {
                    if (!(item is FastColoredTextBox)) continue;
                    _proj.CsFile[i].Text = item.Text;
                    SaveFileEvent?.Invoke(this, new ProjectEventArgs {Cs = _proj.CsFile[i]});
                }
        }

        #endregion

        #region Cut Copy Paste

        private void Cut_ToolStripButton_Click(object sender, EventArgs e) {
            if (tabControlCode.TabCount > 0) {
                var textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;
                textBox.Cut();
                textBox.Focus();
            }
        }

        private void Copy_ToolStripButton_Click(object sender, EventArgs e) {
            if (tabControlCode.TabCount > 0) {
                var textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;
                textBox.Copy();
                textBox.Focus();
            }
        }

        private void Paste_ToolStripButton_Click(object sender, EventArgs e) {
            if (tabControlCode.TabCount > 0) {
                var textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;
                textBox.Paste();
                textBox.Focus();
            }
        }

        #endregion

        #region Build Run

        private void Run_ToolStripButton_Click(object sender, EventArgs e) {
            for (var z = 0; z < tabControlCode.TabCount; z++)
                foreach (var t in _proj.CsFile) {
                    if (t.Name != tabControlCode.TabPages[z].Text) continue;
                    foreach (FastColoredTextBox item in tabControlCode.TabPages[z].Controls) t.Text = item.Text;
                }

            RunEvent?.Invoke(this, new ProjectEventArgs {Project = _proj});
        }

        private void Build_ToolStripButton_Click(object sender, EventArgs e) {
            for (var i = 0; i < tabControlCode.TabCount; i++) {
                if (!tabControlCode.TabPages[i].Focus()) continue;
                foreach (FastColoredTextBox item in tabControlCode.TabPages[i].Controls)
                    if (item is FastColoredTextBox)
                        _proj.CsFile[i].Text = item.Text;
            }

            BuildEvent?.Invoke(this, new ProjectEventArgs {Project = _proj});
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e) {
            WindowState = FormWindowState.Maximized;
        }

        private void LineUp_ToolStripMenuItem_Click(object sender, EventArgs e) {
            var textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;

            textBox.MoveSelectedLinesUp();
        }

        private void LineDown_ToolStripMenuItem_Click(object sender, EventArgs e) {
            var textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;

            textBox.MoveSelectedLinesDown();
        }

        private void View_ErrorListMenuItem_Click(object sender, EventArgs e) {
            splitContainer1.Panel2Collapsed = !View_ErrorListMenuItem.Checked;
        }

        private void View_ProjectExplorerMenuItem_Click(object sender, EventArgs e) {
            splitContainer2.Panel1Collapsed = !View_ProjectExplorerMenuItem.Checked;
        }

        private void View_ToolStripMenuItem_Click(object sender, EventArgs e) {
            toolStrip1.Visible = View_ToolStripMenuItem.Checked;
        }

        private void View_FullScreenMenuItem_Click(object sender, EventArgs e) {
            if (View_FullScreenMenuItem.Checked) {
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.None;
                Bounds = Screen.PrimaryScreen.Bounds;
            } else {
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void WordWrap_ToolStripMenuItem_Click(object sender, EventArgs e) {
            var textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;

            if (!wordWrapToolStripMenuItem.Checked) {
                textBox.WordWrap = true;
                wordWrapToolStripMenuItem.Checked = true;
            } else {
                textBox.WordWrap = false;
                wordWrapToolStripMenuItem.Checked = false;
            }
        }

        private void LineNumbers_ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (tabControlCode.TabCount > 0) {
                var textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;

                if (!lineNumbersToolStripMenuItem.Checked) {
                    textBox.ShowLineNumbers = true;
                    lineNumbersToolStripMenuItem.Checked = true;
                } else {
                    textBox.ShowLineNumbers = false;
                    lineNumbersToolStripMenuItem.Checked = false;
                }
            }
        }

        private void Comment_ToolStripButton_Click(object sender, EventArgs e) {
            if (tabControlCode.TabCount > 0) {
                var textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;
                textBox.CommentSelected();
            }
        }

        private void Undo_ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (tabControlCode.TabCount > 0) {
                var textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;
                textBox.Undo();
            }
        }

        private void Redo_ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (tabControlCode.TabCount > 0) {
                var textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;
                textBox.Redo();
            }
        }

        private void Find_ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (tabControlCode.TabCount > 0) {
                var textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;
                textBox.ShowFindDialog();
            }
        }

        private void Replace_ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (tabControlCode.TabCount > 0) {
                var textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;
                textBox.ShowReplaceDialog();
            }
        }

        private void GoTo_ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (tabControlCode.TabCount > 0) {
                var textBox = tabControlCode.SelectedTab.Controls[0] as FastColoredTextBox;
                textBox.ShowGoToDialog();
            }
        }

        private void View_TabsAlignment_TopMenuItem_Click(object sender, EventArgs e) {
            if (tabControlCode.TabCount > 0) {
                if (!View_TabsAlignment_TopMenuItem.Checked) {
                    tabControlCode.Alignment = TabAlignment.Top;
                    View_TabsAlignment_TopMenuItem.Checked = true;
                    View_TabsAlignment_BottomMenuItem.Checked = false;
                } else {
                    tabControlCode.Alignment = TabAlignment.Bottom;
                    View_TabsAlignment_TopMenuItem.Checked = false;
                    View_TabsAlignment_BottomMenuItem.Checked = true;
                }
            }
        }

        private void View_TabsAlignment_BottomMenuItem_Click(object sender, EventArgs e) {
            if (tabControlCode.TabCount > 0) {
                if (!View_TabsAlignment_BottomMenuItem.Checked) {
                    tabControlCode.Alignment = TabAlignment.Bottom;
                    View_TabsAlignment_BottomMenuItem.Checked = true;
                    View_TabsAlignment_TopMenuItem.Checked = false;
                } else {
                    tabControlCode.Alignment = TabAlignment.Top;
                    View_TabsAlignment_BottomMenuItem.Checked = false;
                    View_TabsAlignment_TopMenuItem.Checked = true;
                }
            }
        }

        private void RemoveFile_ToolStripMenuItem_Click(object sender, EventArgs e) {
            for (var i = 0; i < _cNode.Nodes.Count; i++)
                if (_cNode.Nodes[i].IsSelected)
                    RemoveFileEvent?.Invoke(this, new RemoveFileEventArgs {Project = _proj, Cs = _proj.CsFile[i]});
        }

        private void ClosePage_ToolStripMenuItem_Click(object sender, EventArgs e) {
            tabControlCode.TabPages.Remove(tabControlCode.SelectedTab);
        }

        private void CloseProject_ToolStripMenuItem1_Click(object sender, EventArgs e) { }

        private void ProjectExplorerTreeView_DoubleClick(object sender, EventArgs e) {
            for (var i = 0; i < tabControlCode.TabCount; i++)
                if (tabControlCode.TabPages[i].Text == ProjectExplorerTreeView.SelectedNode.Text)
                    tabControlCode.SelectedIndex = i;

            var c = false;
            for (var i = 0; i < tabControlCode.TabCount; i++)
                if (tabControlCode.TabPages[i].Text == ProjectExplorerTreeView.SelectedNode.Text)
                    c = true;

            if (c == false && ProjectExplorerTreeView.SelectedNode.Text != ProjectExplorerTreeView.TopNode.Text) {
                var path = _proj.Path + @"\" + ProjectExplorerTreeView.SelectedNode.Text;
                string text;
                try {
                    text = System.IO.File.ReadAllText(path);
                } catch {
                    path = _proj.Path + @"\" + _proj.Name + @"\" + ProjectExplorerTreeView.SelectedNode.Text;
                    text = System.IO.File.ReadAllText(path);
                }

                var tabPage = new TabPage(ProjectExplorerTreeView.SelectedNode.Text);

                var textBox = new FastColoredTextBox {
                    Dock = DockStyle.Fill,
                    ContextMenuStrip = contextMenuStripEdit,
                    Language = Language.CSharp,
                    Text = text
                };

                tabPage.Controls.Add(textBox);
                tabControlCode.Controls.Add(tabPage);
            }
        }

        private void File_ExitMenuItem_Click(object sender, EventArgs e) {
            var res = MessageBox.Show("Do you want to save files?", "IDE 2019", MessageBoxButtons.YesNoCancel);
            switch (res) {
                case DialogResult.Yes:
                    SaveAll_ToolStripButton_Click(sender, e);
                    Close();
                    break;
                case DialogResult.No:
                    Close();
                    break;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            var res = MessageBox.Show("Do you want to save files?", "IDE 2019", MessageBoxButtons.YesNoCancel);
            switch (res) {
                case DialogResult.Yes:
                    SaveAll_ToolStripButton_Click(sender, e);
                    e.Cancel = false;
                    break;
                case DialogResult.No:
                    e.Cancel = false;
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }
    }
}