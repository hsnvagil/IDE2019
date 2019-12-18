using IDE2019.Services;
using IDE2019.Views;
using System;

namespace IDE2019.Presenters
{
    class MainFormPresenter
    {
        private IMainForm mainForm;
        private IProjectService projectService;
        public IView View { get { return mainForm; } }

        public MainFormPresenter(IMainForm mainForm, IProjectService projectService)
        {
            this.mainForm = mainForm;
            this.projectService = projectService;

            EventSubscription();
        }
        private void EventSubscription()
        {
            mainForm.NewProjectEvent += NewProjectEvent;
            mainForm.AddPageEvent += AddPageEvent;
            mainForm.RunEvent += RunEvent;
            mainForm.OpenProjectEvent += OpenProjectEvent;
            mainForm.AddCSEvent += AddCSEvent;
            mainForm.SerializationEvent += SerealizationEvent;
            mainForm.OpenFileEvent += OpenFileEvent;
            mainForm.SaveFileEvent += SaveFileEvent;
            mainForm.BuildEvent += BuildEvent;
            mainForm.RemoveFileEvent += RemoveFileEvent;
        }
        private void RemoveFileEvent(object sender, RemoveFileEventArgs e)
        {
            var tmp = projectService.RemoveFile(e.project, e.cS);
            projectService.ProjectSerialization(tmp);
            mainForm.GetProject(tmp);

        }
        private void BuildEvent(object sender, ProjectEventArgs e)
        {
            mainForm.SetErrors(projectService.Build(e.project));
        }
        private void SaveFileEvent(object sender, ProjectEventArgs e)
        {
            projectService.SaveFile(e.cS);
        }
        private void OpenFileEvent(object sender, OpenFileEventArgs e)
        {
            mainForm.AddCS(projectService.OpenFile(e.path));
        }
        private void SerealizationEvent(object sender, SerializationEventArgs e)
        {
            projectService.ProjectSerialization(e.project);
        }
        private void OpenProjectEvent(object sender, OpenFileEventArgs e)
        {
            mainForm.GetProject(projectService.OpenProject(e.path));
        }
        private void AddCSEvent(object sender, EventArgs e)
        {

            mainForm.AddCS(projectService.CreateCS());
        }
        private void RunEvent(object sender, ProjectEventArgs e)
        {
            projectService.Run(e.project);
        }
        private void AddPageEvent(object sender, ProjectEventArgs e)
        {
            mainForm.AddPage(projectService.AddPage(e.cS));
        }
        private void NewProjectEvent(object sender, EventArgs e)
        {
            NewProjectPresenter newProject = IOC.Resolve<NewProjectPresenter>();
            if (newProject.View.ShowDialog())
            {
                mainForm.SetProject(newProject.project);
            }
        }
    }
}
