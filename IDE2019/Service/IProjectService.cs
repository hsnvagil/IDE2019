using System.CodeDom.Compiler;
using System.Windows.Forms;
using IDE2019.Model;

namespace IDE2019.Service
{
    internal interface IProjectService
    {
        string GetPathFolder();
        void CreatingProjectFolder(Project project);
        TabPage AddPage(Cs cS);
        void Run(Project cS);
        Cs CreateCs();
        Project OpenProject(string path);
        Cs OpenFile(string path);
        void ProjectSerialization(Project project);
        void SaveFile(Cs cS);
        CompilerResults Build(Project cS);
        Project RemoveFile(Project project, Cs cS);
    }
}
