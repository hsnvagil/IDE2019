using FastColoredTextBoxNS;
using IDE2019.Models;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using IDE2019.Views;

namespace IDE2019.Services
{
    public class ProjectService : IProjectService
    {
        public void ProjectSerialization(Project project)
        {
            string xmlFile = project.Path + @"\" + project.Name + ".mysln";

            XmlTextWriter xmlWriter = new XmlTextWriter(xmlFile, null);

            MessageBox.Show(xmlFile);
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
        }
        public void CreatingProjectFolder(Project project)
        {
            string pp = project.Path + @"\" + project.Name;
            Directory.CreateDirectory(pp);

            using (Stream fs = new FileStream(pp + @"\" + project.csfile[0].Name, FileMode.Create, FileAccess.ReadWrite))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(project.csfile[0].Text);
                }
            }
        }
        public string GetPathFolder()
        {
            using (FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog())
            {
                folderBrowserDialog1.SelectedPath = @"C:\\";

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    return folderBrowserDialog1.SelectedPath;
                }
                return null;
            }
        }
        public TabPage AddPage(CS cS)
        {
            TabPage tabPage = new TabPage(cS.Name);
            FastColoredTextBox textBox = new FastColoredTextBox();
            textBox.Dock = DockStyle.Fill;

            textBox.Language = Language.CSharp;
            textBox.Text = cS.Text;

            tabPage.Controls.Add(textBox);

            return tabPage;
        }
        public void SaveFile(CS cS)
        {
            using (Stream fs = new FileStream(cS.Path, FileMode.Truncate, FileAccess.ReadWrite))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(cS.Text);
                }
            }
        }
        public void Run(Project cS)
        {
            CompilerResults results = Build(cS);

            if (results.Errors.Count > 0)
            {
                foreach (CompilerError item in results.Errors)
                {
                    MessageBox.Show(item.ErrorText + item.Line);
                }
            }
            else
            {
                Process.Start(@"..\..\my.exe");
            }

        }
        public CompilerResults Build(Project cS)
        {
            CodeDomProvider code = CodeDomProvider.CreateProvider("CSharp");
            CompilerParameters param = new CompilerParameters();

            param.GenerateExecutable = true;
            param.GenerateInMemory = false;
            param.OutputAssembly = @"..\..\my.exe";
            param.TreatWarningsAsErrors = false;


            string[] fileNames = new string[cS.csfile.Count];
            string[] fileNames2 = new string[cS.csfile.Count];


            Project tempProj = new Project();
            tempProj.Name = cS.Name;
            tempProj.csfile = new System.Collections.Generic.List<CS>();
            foreach (var item in cS.csfile)
            {
                tempProj.csfile.Add(item);
            }

            Directory.CreateDirectory(tempProj.Name);

            foreach (var item in tempProj.csfile)
            {
                using (Stream fs = new FileStream(tempProj.Name + @"\" + item.Name, FileMode.Create, FileAccess.ReadWrite))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write(item.Text);
                    }
                }
            }


            int k = 0;
            foreach (var item in tempProj.csfile)
            {
                fileNames[k++] = (tempProj.Name + @"\" + item.Name);
            }

            CompilerResults results = code.CompileAssemblyFromFile(param, fileNames);
            foreach (var item in tempProj.csfile)
            {
                if(File.Exists(tempProj.Name + @"\" +item.Name))
                    File.Delete(tempProj.Name + @"\" + item.Name);
            }
            Directory.Delete(tempProj.Name);
            return results;
            
        }
        public CS CreateCS()
        {
            CS cS = new CS();
            Stream fs;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "cs files (*.cs)|*.cs";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.AddExtension = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((fs = saveFileDialog1.OpenFile()) != null)
                    {
                        cS.Path = saveFileDialog1.FileName;
                        cS.Name = Path.GetFileName(saveFileDialog1.FileName);
                        cS.Text = "using System;\n\nclass " + cS.Name.Substring(0, cS.Name.Length - 3) + "{\n\n \n}";
                        MessageBox.Show(Path.GetFileName(saveFileDialog1.FileName));


                        fs.Close();
                    }
                }
                else
                {
                    return null;
                }
            }
            return cS;
        }
        public Project OpenProject(string path)
        {
            Project project = new Project();

            project.Path = Path.GetDirectoryName(path);
            string filename;
            using (XmlReader reader = XmlReader.Create(path))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        filename = reader.Name.ToString();
                        switch (filename)
                        {
                            case "project":
                                project.Name = reader.GetAttribute("name");
                                break;
                            case "csfile":
                                CS cS = new CS() { Name = reader.GetAttribute("name"), Path = reader.GetAttribute("path") };
                                project.csfile.Add(cS);
                                break;
                        }
                    }
                }
            }

            foreach (CS item in project.csfile)
            {
                using (Stream fs = new FileStream(item.Path, FileMode.Open, FileAccess.ReadWrite))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        item.Text = sr.ReadToEnd();
                    }

                }
            }


            return project;

        }
        public CS OpenFile(string path)
        {
            CS cS = new CS();
            using (Stream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    cS.Name = Path.GetFileName(path);
                    cS.Path = path;
                    cS.Text = sr.ReadToEnd();
                    return cS;
                }
            }
        }
        public Project RemoveFile(Project project, CS cS)
        {
            project.csfile.Remove(cS);
            File.Delete(cS.Path);
            return project;
        }      
    }
}
