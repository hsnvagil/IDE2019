using IDE2019.Models;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IDE2019.Views
{
    public interface IMainForm : IView
    {
        event EventHandler<EventArgs> NewProjectEvent;
        event EventHandler<ProjectEventArgs> AddPageEvent;
        event EventHandler<ProjectEventArgs> RunEvent;
        event EventHandler<ProjectEventArgs> BuildEvent;
        event EventHandler<EventArgs> AddCSEvent;
        event EventHandler<OpenFileEventArgs> OpenProjectEvent;
        event EventHandler<OpenFileEventArgs> OpenFileEvent;
        event EventHandler<SerializationEventArgs> SerializationEvent;
        event EventHandler<ProjectEventArgs> SaveFileEvent;
        event EventHandler<RemoveFileEventArgs> RemoveFileEvent;

        void AddPage(TabPage tabPage);
        void SetProject(Project project);
        void GetProject(Project project);
        void AddCS(CS cS);
        void SetErrors(CompilerResults errorCollection);
    }
    public class ProjectEventArgs : EventArgs
    {
        public CS cS { get; set; }
        public Project project { get; set; }
    }
    public class RemoveFileEventArgs : EventArgs
    {
        public Project project { get; set; } = new Project();
        public CS cS { get; set; }
    }
    public class OpenFileEventArgs : EventArgs
    {
        public string path { get; set; }
    }
    public class SerializationEventArgs : EventArgs
    {
        public Project project { get; set; } = new Project();
    }
}
