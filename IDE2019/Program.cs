using System;
using System.Windows.Forms;
using IDE2019.Presenter;
using IDE2019.Service;
using IDE2019.View;

namespace IDE2019
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IOC.Register<MainForm, IMainForm>();
            IOC.Register<NewProjectForm, INewProjectView>();
            IOC.Register<ProjectService, IProjectService>();
            IOC.Register<MainFormPresenter>();
            IOC.Register<NewProjectPresenter>();
            IOC.Build();

            var mainForm = IOC.Resolve<MainFormPresenter>();
            Application.Run((Form)mainForm.View);
        }
    }
}
