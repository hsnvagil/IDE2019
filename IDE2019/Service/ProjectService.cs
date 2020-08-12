using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using FastColoredTextBoxNS;
using IDE2019.Model;

namespace IDE2019.Service {
    public class ProjectService : IProjectService {
        public void ProjectSerialization(Project project) {
            var xmlFile = project.Path + @"\" + project.Name + ".mysln";

            var xmlWriter = new XmlTextWriter(xmlFile, null);

            MessageBox.Show(xmlFile);
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
        }

        public void CreatingProjectFolder(Project project) {
            var pp = project.Path + @"\" + project.Name;
            Directory.CreateDirectory(pp);

            using (Stream fs = new FileStream(pp + @"\" + project.CsFile[0].Name, FileMode.Create,
                                              FileAccess.ReadWrite)) {
                using (var sw = new StreamWriter(fs)) {
                    sw.Write(project.CsFile[0].Text);
                }
            }
        }

        public string GetPathFolder() {
            using (var folderBrowserDialog1 = new FolderBrowserDialog()) {
                folderBrowserDialog1.SelectedPath = @"C:\\";

                return folderBrowserDialog1.ShowDialog() == DialogResult.OK ? folderBrowserDialog1.SelectedPath : null;
            }
        }

        public TabPage AddPage(Cs cS) {
            var tabPage = new TabPage(cS.Name);
            var textBox = new FastColoredTextBox {Dock = DockStyle.Fill, Language = Language.CSharp, Text = cS.Text};
            tabPage.Controls.Add(textBox);
            return tabPage;
        }

        public void SaveFile(Cs cS) {
            using (Stream fs = new FileStream(cS.Path, FileMode.Truncate, FileAccess.ReadWrite)) {
                using (var sw = new StreamWriter(fs)) {
                    sw.Write(cS.Text);
                }
            }
        }

        public void Run(Project cS) {
            var results = Build(cS);

            if (results.Errors.Count > 0)
                foreach (CompilerError item in results.Errors)
                    MessageBox.Show(item.ErrorText + item.Line);
            else
                Process.Start(@"..\..\my.exe");
        }

        public CompilerResults Build(Project cS) {
            var code = CodeDomProvider.CreateProvider("CSharp");
            var param = new CompilerParameters {
                GenerateExecutable = true,
                GenerateInMemory = false,
                OutputAssembly = @"..\..\my.exe",
                TreatWarningsAsErrors = false
            };


            var fileNames = new string[cS.CsFile.Count];
            var fileNames2 = new string[cS.CsFile.Count];


            var tempProj = new Project {Name = cS.Name, CsFile = new List<Cs>()};
            foreach (var item in cS.CsFile) tempProj.CsFile.Add(item);

            Directory.CreateDirectory(tempProj.Name);

            foreach (var item in tempProj.CsFile)
                using (Stream fs =
                    new FileStream(tempProj.Name + @"\" + item.Name, FileMode.Create, FileAccess.ReadWrite)) {
                    using (var sw = new StreamWriter(fs)) {
                        sw.Write(item.Text);
                    }
                }


            var k = 0;
            foreach (var item in tempProj.CsFile) fileNames[k++] = tempProj.Name + @"\" + item.Name;

            var results = code.CompileAssemblyFromFile(param, fileNames);
            foreach (var item in tempProj.CsFile.Where(item => File.Exists(tempProj.Name + @"\" + item.Name)))
                File.Delete(tempProj.Name + @"\" + item.Name);
            Directory.Delete(tempProj.Name);
            return results;
        }

        public Cs CreateCs() {
            var cS = new Cs();
            using (var openFileDialog = new OpenFileDialog()) {
                var saveFileDialog1 = new SaveFileDialog {
                    Filter = "cs files (*.cs)|*.cs", FilterIndex = 1, RestoreDirectory = true, AddExtension = true
                };
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                    Stream fs;
                    if ((fs = saveFileDialog1.OpenFile()) != null) {
                        cS.Path = saveFileDialog1.FileName;
                        cS.Name = Path.GetFileName(saveFileDialog1.FileName);
                        cS.Text = "using System;\n\nclass " + cS.Name.Substring(0, cS.Name.Length - 3) + "{\n\n \n}";
                        MessageBox.Show(Path.GetFileName(saveFileDialog1.FileName));


                        fs.Close();
                    }
                } else {
                    return null;
                }
            }

            return cS;
        }

        public Project OpenProject(string path) {
            var project = new Project {Path = Path.GetDirectoryName(path)};

            using (var reader = XmlReader.Create(path)) {
                while (reader.Read())
                    if (reader.IsStartElement()) {
                        var filename = reader.Name;
                        switch (filename) {
                            case "project":
                                project.Name = reader.GetAttribute("name");
                                break;
                            case "csfile":
                                var cS = new Cs
                                    {Name = reader.GetAttribute("name"), Path = reader.GetAttribute("path")};
                                project.CsFile.Add(cS);
                                break;
                        }
                    }
            }

            foreach (var item in project.CsFile)
                using (Stream fs = new FileStream(item.Path, FileMode.Open, FileAccess.ReadWrite)) {
                    using (var sr = new StreamReader(fs)) {
                        item.Text = sr.ReadToEnd();
                    }
                }


            return project;
        }

        public Cs OpenFile(string path) {
            var cS = new Cs();
            using (Stream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite)) {
                using (var sr = new StreamReader(fs)) {
                    cS.Name = Path.GetFileName(path);
                    cS.Path = path;
                    cS.Text = sr.ReadToEnd();
                    return cS;
                }
            }
        }

        public Project RemoveFile(Project project, Cs cS) {
            project.CsFile.Remove(cS);
            File.Delete(cS.Path);
            return project;
        }
    }
}