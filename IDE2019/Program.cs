using IDE2019.Presenters;
using IDE2019.Services;
using IDE2019.Views;
using System;
using System.Windows.Forms;

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

            MainFormPresenter mainForm = IOC.Resolve<MainFormPresenter>();
            Application.Run((Form)mainForm.View);
        }
    }
}
