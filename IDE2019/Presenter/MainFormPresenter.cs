using System;
using IDE2019.Service;
using IDE2019.View;

namespace IDE2019.Presenter {
    internal class MainFormPresenter {
        private readonly IMainForm _mainForm;
        private readonly IProjectService _projectService;
        public IView View => _mainForm;

        public MainFormPresenter(IMainForm mainForm, IProjectService projectService) {
            _mainForm = mainForm;
            _projectService = projectService;
            EventSubscription();
        }

        private void EventSubscription() {
            _mainForm.NewProjectEvent += NewProjectEvent;
            _mainForm.AddPageEvent += AddPageEvent;
            _mainForm.RunEvent += RunEvent;
            _mainForm.OpenProjectEvent += OpenProjectEvent;
            _mainForm.AddCsEvent += AddCsEvent;
            _mainForm.SerializationEvent += SerializationEvent;
            _mainForm.OpenFileEvent += OpenFileEvent;
            _mainForm.SaveFileEvent += SaveFileEvent;
            _mainForm.BuildEvent += BuildEvent;
            _mainForm.RemoveFileEvent += RemoveFileEvent;
        }

        private void RemoveFileEvent(object sender, RemoveFileEventArgs e) {
            var tmp = _projectService.RemoveFile(e.Project, e.Cs);
            _projectService.ProjectSerialization(tmp);
            _mainForm.GetProject(tmp);
        }

        private void BuildEvent(object sender, ProjectEventArgs e) {
            _mainForm.SetErrors(_projectService.Build(e.Project));
        }

        private void SaveFileEvent(object sender, ProjectEventArgs e) {
            _projectService.SaveFile(e.Cs);
        }

        private void OpenFileEvent(object sender, OpenFileEventArgs e) {
            _mainForm.AddCs(_projectService.OpenFile(e.Path));
        }

        private void SerializationEvent(object sender, SerializationEventArgs e) {
            _projectService.ProjectSerialization(e.Project);
        }

        private void OpenProjectEvent(object sender, OpenFileEventArgs e) {
            _mainForm.GetProject(_projectService.OpenProject(e.Path));
        }

        private void AddCsEvent(object sender, EventArgs e) {
            _mainForm.AddCs(_projectService.CreateCs());
        }

        private void RunEvent(object sender, ProjectEventArgs e) {
            _projectService.Run(e.Project);
        }

        private void AddPageEvent(object sender, ProjectEventArgs e) {
            _mainForm.AddPage(_projectService.AddPage(e.Cs));
        }

        private void NewProjectEvent(object sender, EventArgs e) {
            var newProject = IOC.Resolve<NewProjectPresenter>();
            if (newProject.View.ShowDialog()) _mainForm.SetProject(newProject.Project);
        }
    }
}