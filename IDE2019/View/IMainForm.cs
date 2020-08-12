using System;
using System.CodeDom.Compiler;
using System.Windows.Forms;
using IDE2019.Model;

namespace IDE2019.View {
    public interface IMainForm : IView {
        event EventHandler<EventArgs> NewProjectEvent;
        event EventHandler<ProjectEventArgs> AddPageEvent;
        event EventHandler<ProjectEventArgs> RunEvent;
        event EventHandler<ProjectEventArgs> BuildEvent;
        event EventHandler<EventArgs> AddCsEvent;
        event EventHandler<OpenFileEventArgs> OpenProjectEvent;
        event EventHandler<OpenFileEventArgs> OpenFileEvent;
        event EventHandler<SerializationEventArgs> SerializationEvent;
        event EventHandler<ProjectEventArgs> SaveFileEvent;
        event EventHandler<RemoveFileEventArgs> RemoveFileEvent;

        void AddPage(TabPage tabPage);
        void SetProject(Project project);
        void GetProject(Project project);
        void AddCs(Cs cS);
        void SetErrors(CompilerResults errorCollection);
    }

    public class ProjectEventArgs : EventArgs {
        public Cs Cs { get; set; }
        public Project Project { get; set; }
    }

    public class RemoveFileEventArgs : EventArgs {
        public Project Project { get; set; } = new Project();
        public Cs Cs { get; set; }
    }

    public class OpenFileEventArgs : EventArgs {
        public string Path { get; set; }
    }

    public class SerializationEventArgs : EventArgs {
        public Project Project { get; set; } = new Project();
    }
}