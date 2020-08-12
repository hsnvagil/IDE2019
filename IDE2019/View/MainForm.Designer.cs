namespace IDE2019.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ProjectExplorerTreeView = new System.Windows.Forms.TreeView();
            this.tabControlCode = new System.Windows.Forms.TabControl();
            this.tabControlBuildRun = new System.Windows.Forms.TabControl();
            this.ErrorsPage = new System.Windows.Forms.TabPage();
            this.listViewCompileInfo = new System.Windows.Forms.ListView();
            this.columnHeaderCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WarningsPage = new System.Windows.Forms.TabPage();
            this.listViewWarnings = new System.Windows.Forms.ListView();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Line = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.File = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OutputPage = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewProject_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OpenProject_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.NewFile_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OpenFile_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.Save_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveAll_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.Cut_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Copy_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Paste_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.Build_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Run_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.Comment_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.File_NewProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.File_OpenProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.File_NewFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.File_OpenFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.File_SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.File_SaveAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.File_ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_CutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_CopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_PasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.View_TabsAlignmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.View_TabsAlignment_TopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.View_TabsAlignment_BottomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.View_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.View_ProjectExplorerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.View_ErrorListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.lineNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.View_FullScreenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DebugMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Debug_BuildSolutionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Debug_RunMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripEditCS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripProject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.buildToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.closeProjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.lineUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.closePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControlBuildRun.SuspendLayout();
            this.ErrorsPage.SuspendLayout();
            this.WarningsPage.SuspendLayout();
            this.OutputPage.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStripEditCS.SuspendLayout();
            this.contextMenuStripProject.SuspendLayout();
            this.contextMenuStripEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlBuildRun);
            this.splitContainer1.Size = new System.Drawing.Size(800, 401);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 12;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ProjectExplorerTreeView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControlCode);
            this.splitContainer2.Size = new System.Drawing.Size(800, 289);
            this.splitContainer2.SplitterDistance = 154;
            this.splitContainer2.TabIndex = 5;
            // 
            // ProjectExplorerTreeView
            // 
            this.ProjectExplorerTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectExplorerTreeView.Location = new System.Drawing.Point(0, 0);
            this.ProjectExplorerTreeView.Name = "ProjectExplorerTreeView";
            this.ProjectExplorerTreeView.Size = new System.Drawing.Size(154, 289);
            this.ProjectExplorerTreeView.TabIndex = 5;
            this.ProjectExplorerTreeView.DoubleClick += new System.EventHandler(this.ProjectExplorerTreeView_DoubleClick);
            // 
            // tabControlCode
            // 
            this.tabControlCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCode.Enabled = false;
            this.tabControlCode.HotTrack = true;
            this.tabControlCode.Location = new System.Drawing.Point(0, 0);
            this.tabControlCode.Name = "tabControlCode";
            this.tabControlCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControlCode.SelectedIndex = 0;
            this.tabControlCode.Size = new System.Drawing.Size(642, 289);
            this.tabControlCode.TabIndex = 3;
            // 
            // tabControlBuildRun
            // 
            this.tabControlBuildRun.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlBuildRun.Controls.Add(this.ErrorsPage);
            this.tabControlBuildRun.Controls.Add(this.WarningsPage);
            this.tabControlBuildRun.Controls.Add(this.OutputPage);
            this.tabControlBuildRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlBuildRun.Location = new System.Drawing.Point(0, 0);
            this.tabControlBuildRun.Name = "tabControlBuildRun";
            this.tabControlBuildRun.SelectedIndex = 0;
            this.tabControlBuildRun.Size = new System.Drawing.Size(800, 108);
            this.tabControlBuildRun.TabIndex = 9;
            // 
            // ErrorsPage
            // 
            this.ErrorsPage.Controls.Add(this.listViewCompileInfo);
            this.ErrorsPage.Location = new System.Drawing.Point(4, 4);
            this.ErrorsPage.Name = "ErrorsPage";
            this.ErrorsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ErrorsPage.Size = new System.Drawing.Size(792, 82);
            this.ErrorsPage.TabIndex = 0;
            this.ErrorsPage.Text = "Errors";
            this.ErrorsPage.UseVisualStyleBackColor = true;
            // 
            // listViewCompileInfo
            // 
            this.listViewCompileInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCode,
            this.columnHeaderMessage,
            this.columnHeaderLine,
            this.columnHeaderFile});
            this.listViewCompileInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCompileInfo.GridLines = true;
            this.listViewCompileInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewCompileInfo.HideSelection = false;
            this.listViewCompileInfo.Location = new System.Drawing.Point(3, 3);
            this.listViewCompileInfo.Name = "listViewCompileInfo";
            this.listViewCompileInfo.Size = new System.Drawing.Size(786, 76);
            this.listViewCompileInfo.TabIndex = 1;
            this.listViewCompileInfo.UseCompatibleStateImageBehavior = false;
            this.listViewCompileInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCode
            // 
            this.columnHeaderCode.Tag = "";
            this.columnHeaderCode.Text = "Code";
            this.columnHeaderCode.Width = 89;
            // 
            // columnHeaderMessage
            // 
            this.columnHeaderMessage.Tag = "Message";
            this.columnHeaderMessage.Text = "Message";
            this.columnHeaderMessage.Width = 400;
            // 
            // columnHeaderLine
            // 
            this.columnHeaderLine.Text = "Line";
            this.columnHeaderLine.Width = 100;
            // 
            // columnHeaderFile
            // 
            this.columnHeaderFile.Text = "File";
            this.columnHeaderFile.Width = 200;
            // 
            // WarningsPage
            // 
            this.WarningsPage.Controls.Add(this.listViewWarnings);
            this.WarningsPage.Location = new System.Drawing.Point(4, 4);
            this.WarningsPage.Name = "WarningsPage";
            this.WarningsPage.Padding = new System.Windows.Forms.Padding(3);
            this.WarningsPage.Size = new System.Drawing.Size(792, 82);
            this.WarningsPage.TabIndex = 1;
            this.WarningsPage.Text = "Warnings";
            this.WarningsPage.UseVisualStyleBackColor = true;
            // 
            // listViewWarnings
            // 
            this.listViewWarnings.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewWarnings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.Message,
            this.Line,
            this.File});
            this.listViewWarnings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewWarnings.GridLines = true;
            this.listViewWarnings.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewWarnings.HideSelection = false;
            this.listViewWarnings.HoverSelection = true;
            this.listViewWarnings.Location = new System.Drawing.Point(3, 3);
            this.listViewWarnings.Name = "listViewWarnings";
            this.listViewWarnings.Size = new System.Drawing.Size(786, 76);
            this.listViewWarnings.TabIndex = 2;
            this.listViewWarnings.UseCompatibleStateImageBehavior = false;
            this.listViewWarnings.View = System.Windows.Forms.View.Details;
            // 
            // Code
            // 
            this.Code.Text = "Code";
            this.Code.Width = 114;
            // 
            // Message
            // 
            this.Message.Text = "Message";
            this.Message.Width = 387;
            // 
            // Line
            // 
            this.Line.Text = "Line";
            this.Line.Width = 287;
            // 
            // File
            // 
            this.File.Text = "File";
            this.File.Width = 102;
            // 
            // OutputPage
            // 
            this.OutputPage.Controls.Add(this.richTextBox1);
            this.OutputPage.Location = new System.Drawing.Point(4, 4);
            this.OutputPage.Name = "OutputPage";
            this.OutputPage.Padding = new System.Windows.Forms.Padding(3);
            this.OutputPage.Size = new System.Drawing.Size(792, 82);
            this.OutputPage.TabIndex = 2;
            this.OutputPage.Text = "Output";
            this.OutputPage.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(786, 76);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewProject_ToolStripButton,
            this.OpenProject_ToolStripButton,
            this.toolStripSeparator13,
            this.NewFile_ToolStripButton,
            this.OpenFile_ToolStripButton,
            this.toolStripSeparator14,
            this.Save_ToolStripButton,
            this.SaveAll_ToolStripButton,
            this.toolStripSeparator15,
            this.Cut_ToolStripButton,
            this.Copy_ToolStripButton,
            this.Paste_ToolStripButton,
            this.toolStripSeparator16,
            this.Build_ToolStripButton,
            this.Run_ToolStripButton,
            this.toolStripSeparator17,
            this.Comment_ToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewProject_ToolStripButton
            // 
            this.NewProject_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewProject_ToolStripButton.Image = global::IDE2019.Properties.Resources.NewWindow_6277;
            this.NewProject_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewProject_ToolStripButton.Name = "NewProject_ToolStripButton";
            this.NewProject_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.NewProject_ToolStripButton.Text = "New Project";
            this.NewProject_ToolStripButton.Click += new System.EventHandler(this.NewProject_ToolStripButton_Click);
            // 
            // OpenProject_ToolStripButton
            // 
            this.OpenProject_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenProject_ToolStripButton.Image = global::IDE2019.Properties.Resources.OpenFileDialog_692;
            this.OpenProject_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenProject_ToolStripButton.Name = "OpenProject_ToolStripButton";
            this.OpenProject_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.OpenProject_ToolStripButton.Text = "Open Project";
            this.OpenProject_ToolStripButton.Click += new System.EventHandler(this.OpenProject_ToolStripButton_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // NewFile_ToolStripButton
            // 
            this.NewFile_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewFile_ToolStripButton.Image = global::IDE2019.Properties.Resources.NewFile_6276;
            this.NewFile_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewFile_ToolStripButton.Name = "NewFile_ToolStripButton";
            this.NewFile_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.NewFile_ToolStripButton.Text = "New File";
            this.NewFile_ToolStripButton.Click += new System.EventHandler(this.NewFile_ToolStripButton_Click);
            // 
            // OpenFile_ToolStripButton
            // 
            this.OpenFile_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFile_ToolStripButton.Image = global::IDE2019.Properties.Resources.Open_6529;
            this.OpenFile_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFile_ToolStripButton.Name = "OpenFile_ToolStripButton";
            this.OpenFile_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.OpenFile_ToolStripButton.Text = "Open File";
            this.OpenFile_ToolStripButton.Click += new System.EventHandler(this.OpenFile_ToolStripButton_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // Save_ToolStripButton
            // 
            this.Save_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save_ToolStripButton.Image = global::IDE2019.Properties.Resources.Save_6530;
            this.Save_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_ToolStripButton.Name = "Save_ToolStripButton";
            this.Save_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Save_ToolStripButton.Text = "Save";
            this.Save_ToolStripButton.Click += new System.EventHandler(this.Save_ToolStripButton_Click);
            // 
            // SaveAll_ToolStripButton
            // 
            this.SaveAll_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAll_ToolStripButton.Image = global::IDE2019.Properties.Resources.Saveall_6518;
            this.SaveAll_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAll_ToolStripButton.Name = "SaveAll_ToolStripButton";
            this.SaveAll_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SaveAll_ToolStripButton.Text = "Save All";
            this.SaveAll_ToolStripButton.Click += new System.EventHandler(this.SaveAll_ToolStripButton_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // Cut_ToolStripButton
            // 
            this.Cut_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cut_ToolStripButton.Image = global::IDE2019.Properties.Resources.Cut_6523;
            this.Cut_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cut_ToolStripButton.Name = "Cut_ToolStripButton";
            this.Cut_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Cut_ToolStripButton.Text = "Cut";
            this.Cut_ToolStripButton.Click += new System.EventHandler(this.Cut_ToolStripButton_Click);
            // 
            // Copy_ToolStripButton
            // 
            this.Copy_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Copy_ToolStripButton.Image = global::IDE2019.Properties.Resources.Copy_6524;
            this.Copy_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Copy_ToolStripButton.Name = "Copy_ToolStripButton";
            this.Copy_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Copy_ToolStripButton.Text = "Copy";
            this.Copy_ToolStripButton.Click += new System.EventHandler(this.Copy_ToolStripButton_Click);
            // 
            // Paste_ToolStripButton
            // 
            this.Paste_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Paste_ToolStripButton.Image = global::IDE2019.Properties.Resources.Paste_6520;
            this.Paste_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Paste_ToolStripButton.Name = "Paste_ToolStripButton";
            this.Paste_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Paste_ToolStripButton.Text = "Paste";
            this.Paste_ToolStripButton.Click += new System.EventHandler(this.Paste_ToolStripButton_Click);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 25);
            // 
            // Build_ToolStripButton
            // 
            this.Build_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Build_ToolStripButton.Enabled = false;
            this.Build_ToolStripButton.Image = global::IDE2019.Properties.Resources.BuildSolution_104;
            this.Build_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Build_ToolStripButton.Name = "Build_ToolStripButton";
            this.Build_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Build_ToolStripButton.Text = "Build";
            this.Build_ToolStripButton.Click += new System.EventHandler(this.Build_ToolStripButton_Click);
            // 
            // Run_ToolStripButton
            // 
            this.Run_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Run_ToolStripButton.Enabled = false;
            this.Run_ToolStripButton.Image = global::IDE2019.Properties.Resources.arrow_run_16xLG;
            this.Run_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Run_ToolStripButton.Name = "Run_ToolStripButton";
            this.Run_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Run_ToolStripButton.Text = "Run";
            this.Run_ToolStripButton.Click += new System.EventHandler(this.Run_ToolStripButton_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(6, 25);
            // 
            // Comment_ToolStripButton
            // 
            this.Comment_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Comment_ToolStripButton.Image = global::IDE2019.Properties.Resources.CommentCode_16x;
            this.Comment_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Comment_ToolStripButton.Name = "Comment_ToolStripButton";
            this.Comment_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Comment_ToolStripButton.Text = "Comment";
            this.Comment_ToolStripButton.Click += new System.EventHandler(this.Comment_ToolStripButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.EditMenuItem,
            this.ViewMenuItem,
            this.DebugMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_NewProjectMenuItem,
            this.File_OpenProjectMenuItem,
            this.toolStripSeparator1,
            this.File_NewFileMenuItem,
            this.File_OpenFileMenuItem,
            this.toolStripSeparator2,
            this.File_SaveMenuItem,
            this.File_SaveAllMenuItem,
            this.toolStripSeparator3,
            this.File_ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "&File";
            // 
            // File_NewProjectMenuItem
            // 
            this.File_NewProjectMenuItem.Image = global::IDE2019.Properties.Resources.NewWindow_6277;
            this.File_NewProjectMenuItem.Name = "File_NewProjectMenuItem";
            this.File_NewProjectMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.File_NewProjectMenuItem.Size = new System.Drawing.Size(218, 22);
            this.File_NewProjectMenuItem.Text = "&New Project";
            this.File_NewProjectMenuItem.Click += new System.EventHandler(this.NewProject_ToolStripButton_Click);
            // 
            // File_OpenProjectMenuItem
            // 
            this.File_OpenProjectMenuItem.Image = global::IDE2019.Properties.Resources.OpenFileDialog_692;
            this.File_OpenProjectMenuItem.Name = "File_OpenProjectMenuItem";
            this.File_OpenProjectMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.File_OpenProjectMenuItem.Size = new System.Drawing.Size(218, 22);
            this.File_OpenProjectMenuItem.Text = "&Open Project";
            this.File_OpenProjectMenuItem.Click += new System.EventHandler(this.OpenProject_ToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // File_NewFileMenuItem
            // 
            this.File_NewFileMenuItem.Image = global::IDE2019.Properties.Resources.NewFile_6276;
            this.File_NewFileMenuItem.Name = "File_NewFileMenuItem";
            this.File_NewFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.File_NewFileMenuItem.Size = new System.Drawing.Size(218, 22);
            this.File_NewFileMenuItem.Text = "&New File";
            this.File_NewFileMenuItem.Click += new System.EventHandler(this.NewFile_ToolStripButton_Click);
            // 
            // File_OpenFileMenuItem
            // 
            this.File_OpenFileMenuItem.Image = global::IDE2019.Properties.Resources.Open_6529;
            this.File_OpenFileMenuItem.Name = "File_OpenFileMenuItem";
            this.File_OpenFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.File_OpenFileMenuItem.Size = new System.Drawing.Size(218, 22);
            this.File_OpenFileMenuItem.Text = "&Open File";
            this.File_OpenFileMenuItem.Click += new System.EventHandler(this.OpenFile_ToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(215, 6);
            // 
            // File_SaveMenuItem
            // 
            this.File_SaveMenuItem.Image = global::IDE2019.Properties.Resources.Save_6530;
            this.File_SaveMenuItem.Name = "File_SaveMenuItem";
            this.File_SaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.File_SaveMenuItem.Size = new System.Drawing.Size(218, 22);
            this.File_SaveMenuItem.Text = "&Save";
            this.File_SaveMenuItem.Click += new System.EventHandler(this.Save_ToolStripButton_Click);
            // 
            // File_SaveAllMenuItem
            // 
            this.File_SaveAllMenuItem.Image = global::IDE2019.Properties.Resources.Saveall_6518;
            this.File_SaveAllMenuItem.Name = "File_SaveAllMenuItem";
            this.File_SaveAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.File_SaveAllMenuItem.Size = new System.Drawing.Size(218, 22);
            this.File_SaveAllMenuItem.Text = "&Save All";
            this.File_SaveAllMenuItem.Click += new System.EventHandler(this.SaveAll_ToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(215, 6);
            // 
            // File_ExitMenuItem
            // 
            this.File_ExitMenuItem.Image = global::IDE2019.Properties.Resources.iconfinder_Close_1891023;
            this.File_ExitMenuItem.Name = "File_ExitMenuItem";
            this.File_ExitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.File_ExitMenuItem.Size = new System.Drawing.Size(218, 22);
            this.File_ExitMenuItem.Text = "&Exit";
            this.File_ExitMenuItem.Click += new System.EventHandler(this.File_ExitMenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit_CutMenuItem,
            this.Edit_CopyMenuItem,
            this.Edit_PasteMenuItem,
            this.toolStripSeparator4,
            this.undoToolStripMenuItem,
            this.redToolStripMenuItem,
            this.toolStripSeparator9,
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.toolStripSeparator5,
            this.goToToolStripMenuItem});
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditMenuItem.Text = "&Edit";
            // 
            // Edit_CutMenuItem
            // 
            this.Edit_CutMenuItem.Image = global::IDE2019.Properties.Resources.Cut_6523;
            this.Edit_CutMenuItem.Name = "Edit_CutMenuItem";
            this.Edit_CutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Edit_CutMenuItem.Size = new System.Drawing.Size(158, 22);
            this.Edit_CutMenuItem.Text = "&Cut";
            this.Edit_CutMenuItem.Click += new System.EventHandler(this.Cut_ToolStripButton_Click);
            // 
            // Edit_CopyMenuItem
            // 
            this.Edit_CopyMenuItem.Image = global::IDE2019.Properties.Resources.Copy_6524;
            this.Edit_CopyMenuItem.Name = "Edit_CopyMenuItem";
            this.Edit_CopyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Edit_CopyMenuItem.Size = new System.Drawing.Size(158, 22);
            this.Edit_CopyMenuItem.Text = "&Copy";
            this.Edit_CopyMenuItem.Click += new System.EventHandler(this.Copy_ToolStripButton_Click);
            // 
            // Edit_PasteMenuItem
            // 
            this.Edit_PasteMenuItem.Image = global::IDE2019.Properties.Resources.Paste_6520;
            this.Edit_PasteMenuItem.Name = "Edit_PasteMenuItem";
            this.Edit_PasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Edit_PasteMenuItem.Size = new System.Drawing.Size(158, 22);
            this.Edit_PasteMenuItem.Text = "&Paste";
            this.Edit_PasteMenuItem.Click += new System.EventHandler(this.Paste_ToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(155, 6);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::IDE2019.Properties.Resources.Undo_16x;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.Undo_ToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Image = global::IDE2019.Properties.Resources.Redo_16x;
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.redToolStripMenuItem.Text = "&Redo";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.Redo_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(155, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Image = global::IDE2019.Properties.Resources.find;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.findToolStripMenuItem.Text = "&Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.Find_ToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Image = global::IDE2019.Properties.Resources.replace;
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.replaceToolStripMenuItem.Text = "&Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.Replace_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.Image = global::IDE2019.Properties.Resources._goto;
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.goToToolStripMenuItem.Text = "&Go To";
            this.goToToolStripMenuItem.Click += new System.EventHandler(this.GoTo_ToolStripMenuItem_Click);
            // 
            // ViewMenuItem
            // 
            this.ViewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.View_TabsAlignmentMenuItem,
            this.View_ToolStripMenuItem,
            this.View_ProjectExplorerMenuItem,
            this.View_ErrorListMenuItem,
            this.toolStripSeparator12,
            this.lineNumbersToolStripMenuItem,
            this.toolStripSeparator11,
            this.View_FullScreenMenuItem});
            this.ViewMenuItem.Name = "ViewMenuItem";
            this.ViewMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ViewMenuItem.Text = "&View";
            // 
            // View_TabsAlignmentMenuItem
            // 
            this.View_TabsAlignmentMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.View_TabsAlignment_TopMenuItem,
            this.View_TabsAlignment_BottomMenuItem});
            this.View_TabsAlignmentMenuItem.Name = "View_TabsAlignmentMenuItem";
            this.View_TabsAlignmentMenuItem.Size = new System.Drawing.Size(157, 22);
            this.View_TabsAlignmentMenuItem.Text = "Tabs Alignment";
            // 
            // View_TabsAlignment_TopMenuItem
            // 
            this.View_TabsAlignment_TopMenuItem.Checked = true;
            this.View_TabsAlignment_TopMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.View_TabsAlignment_TopMenuItem.Name = "View_TabsAlignment_TopMenuItem";
            this.View_TabsAlignment_TopMenuItem.Size = new System.Drawing.Size(114, 22);
            this.View_TabsAlignment_TopMenuItem.Text = "Top";
            this.View_TabsAlignment_TopMenuItem.Click += new System.EventHandler(this.View_TabsAlignment_TopMenuItem_Click);
            // 
            // View_TabsAlignment_BottomMenuItem
            // 
            this.View_TabsAlignment_BottomMenuItem.Name = "View_TabsAlignment_BottomMenuItem";
            this.View_TabsAlignment_BottomMenuItem.Size = new System.Drawing.Size(114, 22);
            this.View_TabsAlignment_BottomMenuItem.Text = "Bottom";
            this.View_TabsAlignment_BottomMenuItem.Click += new System.EventHandler(this.View_TabsAlignment_BottomMenuItem_Click);
            // 
            // View_ToolStripMenuItem
            // 
            this.View_ToolStripMenuItem.Checked = true;
            this.View_ToolStripMenuItem.CheckOnClick = true;
            this.View_ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.View_ToolStripMenuItem.Name = "View_ToolStripMenuItem";
            this.View_ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.View_ToolStripMenuItem.Text = "Tool Strip";
            this.View_ToolStripMenuItem.Click += new System.EventHandler(this.View_ToolStripMenuItem_Click);
            // 
            // View_ProjectExplorerMenuItem
            // 
            this.View_ProjectExplorerMenuItem.Checked = true;
            this.View_ProjectExplorerMenuItem.CheckOnClick = true;
            this.View_ProjectExplorerMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.View_ProjectExplorerMenuItem.Name = "View_ProjectExplorerMenuItem";
            this.View_ProjectExplorerMenuItem.Size = new System.Drawing.Size(157, 22);
            this.View_ProjectExplorerMenuItem.Text = "Project Explorer";
            this.View_ProjectExplorerMenuItem.Click += new System.EventHandler(this.View_ProjectExplorerMenuItem_Click);
            // 
            // View_ErrorListMenuItem
            // 
            this.View_ErrorListMenuItem.Checked = true;
            this.View_ErrorListMenuItem.CheckOnClick = true;
            this.View_ErrorListMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.View_ErrorListMenuItem.Name = "View_ErrorListMenuItem";
            this.View_ErrorListMenuItem.Size = new System.Drawing.Size(157, 22);
            this.View_ErrorListMenuItem.Text = "Error List";
            this.View_ErrorListMenuItem.Click += new System.EventHandler(this.View_ErrorListMenuItem_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(154, 6);
            // 
            // lineNumbersToolStripMenuItem
            // 
            this.lineNumbersToolStripMenuItem.Checked = true;
            this.lineNumbersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lineNumbersToolStripMenuItem.Name = "lineNumbersToolStripMenuItem";
            this.lineNumbersToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.lineNumbersToolStripMenuItem.Text = "Line Numbers";
            this.lineNumbersToolStripMenuItem.Click += new System.EventHandler(this.LineNumbers_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(154, 6);
            // 
            // View_FullScreenMenuItem
            // 
            this.View_FullScreenMenuItem.CheckOnClick = true;
            this.View_FullScreenMenuItem.Name = "View_FullScreenMenuItem";
            this.View_FullScreenMenuItem.Size = new System.Drawing.Size(157, 22);
            this.View_FullScreenMenuItem.Text = "Full Screen";
            this.View_FullScreenMenuItem.Click += new System.EventHandler(this.View_FullScreenMenuItem_Click);
            // 
            // DebugMenuItem
            // 
            this.DebugMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Debug_BuildSolutionMenuItem,
            this.Debug_RunMenuItem});
            this.DebugMenuItem.Name = "DebugMenuItem";
            this.DebugMenuItem.Size = new System.Drawing.Size(54, 20);
            this.DebugMenuItem.Text = "&Debug";
            // 
            // Debug_BuildSolutionMenuItem
            // 
            this.Debug_BuildSolutionMenuItem.Image = global::IDE2019.Properties.Resources.BuildSolution_104;
            this.Debug_BuildSolutionMenuItem.Name = "Debug_BuildSolutionMenuItem";
            this.Debug_BuildSolutionMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.Debug_BuildSolutionMenuItem.Size = new System.Drawing.Size(167, 22);
            this.Debug_BuildSolutionMenuItem.Text = "&Build Solution";
            this.Debug_BuildSolutionMenuItem.Click += new System.EventHandler(this.Build_ToolStripButton_Click);
            // 
            // Debug_RunMenuItem
            // 
            this.Debug_RunMenuItem.Image = global::IDE2019.Properties.Resources.arrow_run_16xLG;
            this.Debug_RunMenuItem.Name = "Debug_RunMenuItem";
            this.Debug_RunMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.Debug_RunMenuItem.Size = new System.Drawing.Size(167, 22);
            this.Debug_RunMenuItem.Text = "&Run";
            this.Debug_RunMenuItem.Click += new System.EventHandler(this.Run_ToolStripButton_Click);
            // 
            // contextMenuStripEditCS
            // 
            this.contextMenuStripEditCS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFileToolStripMenuItem});
            this.contextMenuStripEditCS.Name = "contextMenuStrip1";
            this.contextMenuStripEditCS.Size = new System.Drawing.Size(139, 26);
            // 
            // removeFileToolStripMenuItem
            // 
            this.removeFileToolStripMenuItem.Image = global::IDE2019.Properties.Resources.iconfinder_file_delete_48762;
            this.removeFileToolStripMenuItem.Name = "removeFileToolStripMenuItem";
            this.removeFileToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.removeFileToolStripMenuItem.Text = "Remove File";
            this.removeFileToolStripMenuItem.Click += new System.EventHandler(this.RemoveFile_ToolStripMenuItem_Click);
            // 
            // contextMenuStripProject
            // 
            this.contextMenuStripProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewFileToolStripMenuItem,
            this.toolStripSeparator18,
            this.buildToolStripMenuItem1,
            this.runToolStripMenuItem1,
            this.toolStripSeparator19,
            this.closeProjectToolStripMenuItem1});
            this.contextMenuStripProject.Name = "contextMenuStripProject";
            this.contextMenuStripProject.Size = new System.Drawing.Size(145, 104);
            this.contextMenuStripProject.Text = "Project";
            // 
            // addNewFileToolStripMenuItem
            // 
            this.addNewFileToolStripMenuItem.Image = global::IDE2019.Properties.Resources.NewFile_6276;
            this.addNewFileToolStripMenuItem.Name = "addNewFileToolStripMenuItem";
            this.addNewFileToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addNewFileToolStripMenuItem.Text = "Add New File";
            this.addNewFileToolStripMenuItem.Click += new System.EventHandler(this.NewFile_ToolStripButton_Click);
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(141, 6);
            // 
            // buildToolStripMenuItem1
            // 
            this.buildToolStripMenuItem1.Image = global::IDE2019.Properties.Resources.BuildSolution_104;
            this.buildToolStripMenuItem1.Name = "buildToolStripMenuItem1";
            this.buildToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.buildToolStripMenuItem1.Text = "Build";
            this.buildToolStripMenuItem1.Click += new System.EventHandler(this.Build_ToolStripButton_Click);
            // 
            // runToolStripMenuItem1
            // 
            this.runToolStripMenuItem1.Image = global::IDE2019.Properties.Resources.arrow_run_16xLG;
            this.runToolStripMenuItem1.Name = "runToolStripMenuItem1";
            this.runToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.runToolStripMenuItem1.Text = "Run";
            this.runToolStripMenuItem1.Click += new System.EventHandler(this.Run_ToolStripButton_Click);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(141, 6);
            // 
            // closeProjectToolStripMenuItem1
            // 
            this.closeProjectToolStripMenuItem1.Image = global::IDE2019.Properties.Resources.iconfinder_Close_1891023;
            this.closeProjectToolStripMenuItem1.Name = "closeProjectToolStripMenuItem1";
            this.closeProjectToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.closeProjectToolStripMenuItem1.Text = "Close Project";
            this.closeProjectToolStripMenuItem1.Click += new System.EventHandler(this.CloseProject_ToolStripMenuItem1_Click);
            // 
            // contextMenuStripEdit
            // 
            this.contextMenuStripEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem1,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.toolStripSeparator6,
            this.lineUpToolStripMenuItem,
            this.lineDownToolStripMenuItem,
            this.toolStripSeparator7,
            this.wordWrapToolStripMenuItem,
            this.toolStripSeparator8,
            this.closePageToolStripMenuItem});
            this.contextMenuStripEdit.Name = "contextMenuStripEdir";
            this.contextMenuStripEdit.Size = new System.Drawing.Size(135, 176);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Image = global::IDE2019.Properties.Resources.Cut_6523;
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.cutToolStripMenuItem1.Text = "Cut";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.Cut_ToolStripButton_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Image = global::IDE2019.Properties.Resources.Copy_6524;
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.Copy_ToolStripButton_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Image = global::IDE2019.Properties.Resources.Paste_6520;
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.Paste_ToolStripButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(131, 6);
            // 
            // lineUpToolStripMenuItem
            // 
            this.lineUpToolStripMenuItem.Image = global::IDE2019.Properties.Resources.iconfinder_1___Up_1815558;
            this.lineUpToolStripMenuItem.Name = "lineUpToolStripMenuItem";
            this.lineUpToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.lineUpToolStripMenuItem.Text = "Line Up";
            this.lineUpToolStripMenuItem.Click += new System.EventHandler(this.LineUp_ToolStripMenuItem_Click);
            // 
            // lineDownToolStripMenuItem
            // 
            this.lineDownToolStripMenuItem.Image = global::IDE2019.Properties.Resources.iconfinder_2___Down_1815568;
            this.lineDownToolStripMenuItem.Name = "lineDownToolStripMenuItem";
            this.lineDownToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.lineDownToolStripMenuItem.Text = "Line Down";
            this.lineDownToolStripMenuItem.Click += new System.EventHandler(this.LineDown_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(131, 6);
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.wordWrapToolStripMenuItem.Text = "Word Wrap";
            this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.WordWrap_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(131, 6);
            // 
            // closePageToolStripMenuItem
            // 
            this.closePageToolStripMenuItem.Image = global::IDE2019.Properties.Resources.iconfinder_Close_Icon_1398919;
            this.closePageToolStripMenuItem.Name = "closePageToolStripMenuItem";
            this.closePageToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.closePageToolStripMenuItem.Text = "Close page";
            this.closePageToolStripMenuItem.Click += new System.EventHandler(this.ClosePage_ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "IDE 2019";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControlBuildRun.ResumeLayout(false);
            this.ErrorsPage.ResumeLayout(false);
            this.WarningsPage.ResumeLayout(false);
            this.OutputPage.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStripEditCS.ResumeLayout(false);
            this.contextMenuStripProject.ResumeLayout(false);
            this.contextMenuStripEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView ProjectExplorerTreeView;
        private System.Windows.Forms.TabControl tabControlBuildRun;
        private System.Windows.Forms.TabPage ErrorsPage;
        private System.Windows.Forms.ListView listViewCompileInfo;
        private System.Windows.Forms.ColumnHeader columnHeaderCode;
        private System.Windows.Forms.ColumnHeader columnHeaderMessage;
        private System.Windows.Forms.ColumnHeader columnHeaderLine;
        private System.Windows.Forms.ColumnHeader columnHeaderFile;
        private System.Windows.Forms.TabPage WarningsPage;
        private System.Windows.Forms.ListView listViewWarnings;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Message;
        private System.Windows.Forms.ColumnHeader Line;
        private System.Windows.Forms.ColumnHeader File;
        private System.Windows.Forms.TabPage OutputPage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewProject_ToolStripButton;
        private System.Windows.Forms.ToolStripButton OpenProject_ToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripButton NewFile_ToolStripButton;
        private System.Windows.Forms.ToolStripButton OpenFile_ToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton Save_ToolStripButton;
        private System.Windows.Forms.ToolStripButton SaveAll_ToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripButton Cut_ToolStripButton;
        private System.Windows.Forms.ToolStripButton Copy_ToolStripButton;
        private System.Windows.Forms.ToolStripButton Paste_ToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripButton Build_ToolStripButton;
        private System.Windows.Forms.ToolStripButton Run_ToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripButton Comment_ToolStripButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem File_NewProjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem File_OpenProjectMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem File_NewFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem File_OpenFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem File_SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem File_SaveAllMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem File_ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit_CutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit_CopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit_PasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem View_TabsAlignmentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem View_TabsAlignment_TopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem View_TabsAlignment_BottomMenuItem;
        private System.Windows.Forms.ToolStripMenuItem View_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem View_ProjectExplorerMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem View_ErrorListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DebugMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Debug_BuildSolutionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Debug_RunMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEditCS;
        private System.Windows.Forms.ToolStripMenuItem removeFileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProject;
        private System.Windows.Forms.ToolStripMenuItem addNewFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControlCode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEdit;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem lineUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem closePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem View_FullScreenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    }
}