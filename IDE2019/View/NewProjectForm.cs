using System;
using System.Windows.Forms;
using IDE2019.Model;

namespace IDE2019.View {
    public partial class NewProjectForm : Form, INewProjectView {
        public NewProjectForm() {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> OpenFolderEvent;
        public event EventHandler<AddProjectEventArgs> AddProjectEvent;

        public void SetPathFolder(string path) {
            textBoxFolder.Text = path;
        }

        bool IView.ShowDialog() {
            return ShowDialog() == DialogResult.OK;
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            var Project = new Project {
                Name = textBoxName.Text,
                Path = textBoxFolder.Text
            };
            var cs = new Cs {Name = "Program.cs"};
            cs.Path = Project.Path + "\\" + Project.Name + "\\" + cs.Name;
            cs.Text =
                "using System;\n\nclass Program{\n\n  static void Main(){\n Console.WriteLine(\"Hello, world\");\n Console.Read();\n}\n}";

            Project.CsFile.Add(cs);
            AddProjectEvent?.Invoke(this, new AddProjectEventArgs {Project = Project});
        }

        private void textBoxName_TextChanged(object sender, EventArgs e) {
            if (textBoxName.Text != "" && textBoxFolder.Text != "") buttonOk.Enabled = true;
        }

        private void buttonFolder_Click(object sender, EventArgs e) {
            OpenFolderEvent?.Invoke(this, new EventArgs());
        }

        private void textBoxFolder_TextChanged(object sender, EventArgs e) {
            if (textBoxName.Text != "" && textBoxFolder.Text != "") buttonOk.Enabled = true;
        }
    }
}