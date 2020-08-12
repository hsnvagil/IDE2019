using System;
using IDE2019.Model;
using IDE2019.Service;
using IDE2019.View;

namespace IDE2019.Presenter {
    internal class NewProjectPresenter {
        private readonly INewProjectView _newProjectView;
        private readonly IProjectService _projectService;
        public Project Project = new Project();

        public IView View => _newProjectView;

        public NewProjectPresenter(INewProjectView newProjectView, IProjectService projectService) {
            _newProjectView = newProjectView;
            _projectService = projectService;

            EventSubscription();
        }

        private void EventSubscription() {
            _newProjectView.OpenFolderEvent += NewProjectView_OpenFolderEvent;
            _newProjectView.AddProjectEvent += NewProjectView_AddProjectEvent;
        }

        private void NewProjectView_AddProjectEvent(object sender, AddProjectEventArgs e) {
            _projectService.CreatingProjectFolder(e.Project);
            Project = e.Project;
        }

        private void NewProjectView_OpenFolderEvent(object sender, EventArgs e) {
            _newProjectView.SetPathFolder(_projectService.GetPathFolder());
        }
    }
}