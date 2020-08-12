using System;
using IDE2019.Model;

namespace IDE2019.View {
    public interface INewProjectView : IView {
        event EventHandler<EventArgs> OpenFolderEvent;
        event EventHandler<AddProjectEventArgs> AddProjectEvent;

        void SetPathFolder(string path);
    }

    public class AddProjectEventArgs : EventArgs {
        public Project Project { get; set; }
    }
}