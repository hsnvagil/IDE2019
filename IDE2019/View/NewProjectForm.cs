using System;
using System.Windows.Forms;
using IDE2019.Models;

namespace IDE2019.Views
{
    public partial class NewProjectForm : Form,INewProjectView
    {
        public NewProjectForm()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> OpenFolderEvent;
        public event EventHandler<AddProjectEventArgs> AddProjectEvent;

        public void SetPathFolder(string path)
        {
            textBoxFolder.Text = path;
        }

        bool IView.ShowDialog()
        {
            return this.ShowDialog() == DialogResult.OK;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

            Project Project = new Project()
            {
                Name = textBoxName.Text,
                Path = textBoxFolder.Text,

            };
            CS cS = new CS() { Name = "Program.cs" };
            cS.Path = Project.Path + "\\" + Project.Name + "\\" + cS.Name;
            cS.Text = "using System;\n\nclass Program{\n\n  static void Main(){\n Console.WriteLine(\"Hello, world\");\n Console.Read();\n}\n}";

            Project.csfile.Add(cS);
            AddProjectEvent?.Invoke(this, new AddProjectEventArgs() { project = Project });
        }

        private void groupBoxNewProject_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxFolder.Text != "")
            {
                buttonOk.Enabled = true;
            }
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            OpenFolderEvent?.Invoke(this, new EventArgs());
        }

        private void textBoxFolder_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxFolder.Text != "")
            {
                buttonOk.Enabled = true;
            }
        }
    }
}
