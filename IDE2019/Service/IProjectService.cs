using IDE2019.Models;
using System.CodeDom.Compiler;
using System.Windows.Forms;

namespace IDE2019.Services
{
    interface IProjectService
    {
        string GetPathFolder();
        void CreatingProjectFolder(Project project);
        TabPage AddPage(CS cS);
        void Run(Project cS);
        CS CreateCS();
        Project OpenProject(string path);
        CS OpenFile(string path);
        void ProjectSerialization(Project project);
        void SaveFile(CS cS);
        CompilerResults Build(Project cS);
        Project RemoveFile(Project project, CS cS);

    }
}
