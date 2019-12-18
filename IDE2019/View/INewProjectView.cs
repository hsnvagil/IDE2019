using IDE2019.Models;
using System;

namespace IDE2019.Views
{
    public interface INewProjectView : IView
    {
        event EventHandler<EventArgs> OpenFolderEvent;
        event EventHandler<AddProjectEventArgs> AddProjectEvent;

        void SetPathFolder(string path);
    }
    public class AddProjectEventArgs : EventArgs
    {
        public Project project { get; set; }
    }
}
