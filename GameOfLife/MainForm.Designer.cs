
namespace GameOfLife
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStripFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripNewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripOpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFileMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripSaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFileMenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripImportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripExportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFileMenuSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripQuitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripOptionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripClearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripDisplayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripNeighborsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripGenerationStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStripLiveStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStripTotalStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripOptionsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPlayButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripPauseButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripNextButton = new System.Windows.Forms.ToolStripButton();
            this.graphicsPanel = new GameOfLife.GraphicsPanel();
            this.contextMenuDisplay = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuDisplayOptionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuDisplayClearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuDisplaySeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuDisplayEditColors = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuDisplayToggleHudMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuDisplayToggleGridMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hudPanel = new System.Windows.Forms.Panel();
            this.hudTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.hudScaleValueLabel = new System.Windows.Forms.Label();
            this.hudBorderValueLabel = new System.Windows.Forms.Label();
            this.hudSeedValueLabel = new System.Windows.Forms.Label();
            this.hudIntervalValueLabel = new System.Windows.Forms.Label();
            this.hudScaleNameLabel = new System.Windows.Forms.Label();
            this.hudBorderNameLabel = new System.Windows.Forms.Label();
            this.hudSeedNameLabel = new System.Windows.Forms.Label();
            this.hudIntervalNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.graphicsPanel.SuspendLayout();
            this.contextMenuDisplay.SuspendLayout();
            this.hudPanel.SuspendLayout();
            this.hudTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.statusStrip, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.toolStrip, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.graphicsPanel, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(944, 501);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFileMenu,
            this.menuStripToolsMenu,
            this.menuStripViewMenu,
            this.menuStripHelpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(944, 20);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuStripFileMenu
            // 
            this.menuStripFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripNewMenuItem,
            this.menuStripOpenMenuItem,
            this.menuStripFileMenuSeparator1,
            this.menuStripSaveMenuItem,
            this.menuStripSaveAsMenuItem,
            this.menuStripFileMenuSeparator2,
            this.menuStripImportMenuItem,
            this.menuStripExportMenuItem,
            this.menuStripFileMenuSeparator3,
            this.menuStripQuitMenuItem});
            this.menuStripFileMenu.ForeColor = System.Drawing.Color.Gray;
            this.menuStripFileMenu.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.menuStripFileMenu.Name = "menuStripFileMenu";
            this.menuStripFileMenu.Size = new System.Drawing.Size(45, 14);
            this.menuStripFileMenu.Text = "&File";
            // 
            // menuStripNewMenuItem
            // 
            this.menuStripNewMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.menuStripNewMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripNewMenuItem.Name = "menuStripNewMenuItem";
            this.menuStripNewMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuStripNewMenuItem.Size = new System.Drawing.Size(145, 22);
            this.menuStripNewMenuItem.Text = "&New";
            // 
            // menuStripOpenMenuItem
            // 
            this.menuStripOpenMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.menuStripOpenMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripOpenMenuItem.Name = "menuStripOpenMenuItem";
            this.menuStripOpenMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuStripOpenMenuItem.Size = new System.Drawing.Size(145, 22);
            this.menuStripOpenMenuItem.Text = "&Open";
            // 
            // menuStripFileMenuSeparator1
            // 
            this.menuStripFileMenuSeparator1.Name = "menuStripFileMenuSeparator1";
            this.menuStripFileMenuSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // menuStripSaveMenuItem
            // 
            this.menuStripSaveMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.menuStripSaveMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripSaveMenuItem.Name = "menuStripSaveMenuItem";
            this.menuStripSaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuStripSaveMenuItem.Size = new System.Drawing.Size(145, 22);
            this.menuStripSaveMenuItem.Text = "&Save";
            // 
            // menuStripSaveAsMenuItem
            // 
            this.menuStripSaveAsMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.menuStripSaveAsMenuItem.Name = "menuStripSaveAsMenuItem";
            this.menuStripSaveAsMenuItem.Size = new System.Drawing.Size(145, 22);
            this.menuStripSaveAsMenuItem.Text = "Save &As";
            // 
            // menuStripFileMenuSeparator2
            // 
            this.menuStripFileMenuSeparator2.Name = "menuStripFileMenuSeparator2";
            this.menuStripFileMenuSeparator2.Size = new System.Drawing.Size(142, 6);
            // 
            // menuStripImportMenuItem
            // 
            this.menuStripImportMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.menuStripImportMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripImportMenuItem.Name = "menuStripImportMenuItem";
            this.menuStripImportMenuItem.Size = new System.Drawing.Size(145, 22);
            this.menuStripImportMenuItem.Text = "&Import";
            // 
            // menuStripExportMenuItem
            // 
            this.menuStripExportMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.menuStripExportMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripExportMenuItem.Name = "menuStripExportMenuItem";
            this.menuStripExportMenuItem.Size = new System.Drawing.Size(145, 22);
            this.menuStripExportMenuItem.Text = "&Export";
            // 
            // menuStripFileMenuSeparator3
            // 
            this.menuStripFileMenuSeparator3.Name = "menuStripFileMenuSeparator3";
            this.menuStripFileMenuSeparator3.Size = new System.Drawing.Size(142, 6);
            // 
            // menuStripQuitMenuItem
            // 
            this.menuStripQuitMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.menuStripQuitMenuItem.Name = "menuStripQuitMenuItem";
            this.menuStripQuitMenuItem.Size = new System.Drawing.Size(145, 22);
            this.menuStripQuitMenuItem.Text = "&Quit";
            // 
            // menuStripToolsMenu
            // 
            this.menuStripToolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripOptionsMenuItem,
            this.menuStripClearMenuItem});
            this.menuStripToolsMenu.ForeColor = System.Drawing.Color.Gray;
            this.menuStripToolsMenu.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.menuStripToolsMenu.Name = "menuStripToolsMenu";
            this.menuStripToolsMenu.Size = new System.Drawing.Size(52, 14);
            this.menuStripToolsMenu.Text = "&Tools";
            // 
            // menuStripOptionsMenuItem
            // 
            this.menuStripOptionsMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.menuStripOptionsMenuItem.Name = "menuStripOptionsMenuItem";
            this.menuStripOptionsMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuStripOptionsMenuItem.Size = new System.Drawing.Size(152, 22);
            this.menuStripOptionsMenuItem.Text = "&Options";
            // 
            // menuStripClearMenuItem
            // 
            this.menuStripClearMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.menuStripClearMenuItem.Name = "menuStripClearMenuItem";
            this.menuStripClearMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuStripClearMenuItem.Size = new System.Drawing.Size(152, 22);
            this.menuStripClearMenuItem.Text = "&Clear";
            this.menuStripClearMenuItem.Click += new System.EventHandler(this.menuStripClearMenuItem_Click);
            // 
            // menuStripViewMenu
            // 
            this.menuStripViewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripDisplayMenuItem,
            this.menuStripNeighborsMenuItem});
            this.menuStripViewMenu.ForeColor = System.Drawing.Color.Gray;
            this.menuStripViewMenu.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.menuStripViewMenu.Name = "menuStripViewMenu";
            this.menuStripViewMenu.Size = new System.Drawing.Size(45, 14);
            this.menuStripViewMenu.Text = "&View";
            // 
            // menuStripDisplayMenuItem
            // 
            this.menuStripDisplayMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.menuStripDisplayMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripDisplayMenuItem.Name = "menuStripDisplayMenuItem";
            this.menuStripDisplayMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuStripDisplayMenuItem.Size = new System.Drawing.Size(201, 22);
            this.menuStripDisplayMenuItem.Text = "&Display";
            // 
            // menuStripNeighborsMenuItem
            // 
            this.menuStripNeighborsMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.menuStripNeighborsMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripNeighborsMenuItem.Name = "menuStripNeighborsMenuItem";
            this.menuStripNeighborsMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuStripNeighborsMenuItem.Size = new System.Drawing.Size(201, 22);
            this.menuStripNeighborsMenuItem.Text = "Toggle Neighbors";
            // 
            // menuStripHelpMenu
            // 
            this.menuStripHelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripAboutMenuItem});
            this.menuStripHelpMenu.ForeColor = System.Drawing.Color.Gray;
            this.menuStripHelpMenu.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.menuStripHelpMenu.Name = "menuStripHelpMenu";
            this.menuStripHelpMenu.Size = new System.Drawing.Size(45, 14);
            this.menuStripHelpMenu.Text = "&Help";
            // 
            // menuStripAboutMenuItem
            // 
            this.menuStripAboutMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.menuStripAboutMenuItem.Name = "menuStripAboutMenuItem";
            this.menuStripAboutMenuItem.Size = new System.Drawing.Size(105, 22);
            this.menuStripAboutMenuItem.Text = "&About";
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.statusStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripGenerationStatusLabel,
            this.statusStripSeparator1,
            this.statusStripLiveStatusLabel,
            this.statusStripSeparator2,
            this.statusStripTotalStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 481);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(944, 20);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusStripGenerationStatusLabel
            // 
            this.statusStripGenerationStatusLabel.ForeColor = System.Drawing.Color.Gray;
            this.statusStripGenerationStatusLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.statusStripGenerationStatusLabel.Name = "statusStripGenerationStatusLabel";
            this.statusStripGenerationStatusLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusStripGenerationStatusLabel.Size = new System.Drawing.Size(104, 18);
            this.statusStripGenerationStatusLabel.Text = "Generation: 0";
            // 
            // statusStripSeparator1
            // 
            this.statusStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.statusStripSeparator1.Name = "statusStripSeparator1";
            this.statusStripSeparator1.Size = new System.Drawing.Size(6, 16);
            // 
            // statusStripLiveStatusLabel
            // 
            this.statusStripLiveStatusLabel.ForeColor = System.Drawing.Color.Gray;
            this.statusStripLiveStatusLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.statusStripLiveStatusLabel.Name = "statusStripLiveStatusLabel";
            this.statusStripLiveStatusLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusStripLiveStatusLabel.Size = new System.Drawing.Size(62, 18);
            this.statusStripLiveStatusLabel.Text = "Live: 0";
            // 
            // statusStripSeparator2
            // 
            this.statusStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.statusStripSeparator2.Name = "statusStripSeparator2";
            this.statusStripSeparator2.Size = new System.Drawing.Size(6, 16);
            // 
            // statusStripTotalStatusLabel
            // 
            this.statusStripTotalStatusLabel.ForeColor = System.Drawing.Color.Gray;
            this.statusStripTotalStatusLabel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.statusStripTotalStatusLabel.Name = "statusStripTotalStatusLabel";
            this.statusStripTotalStatusLabel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusStripTotalStatusLabel.Size = new System.Drawing.Size(69, 18);
            this.statusStripTotalStatusLabel.Text = "Total: 0";
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.toolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOptionsButton,
            this.toolStripSeparator1,
            this.toolStripSaveButton,
            this.toolStripSeparator2,
            this.toolStripPlayButton,
            this.toolStripPauseButton,
            this.toolStripNextButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 20);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(944, 50);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripOptionsButton
            // 
            this.toolStripOptionsButton.AutoSize = false;
            this.toolStripOptionsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOptionsButton.Image = global::GameOfLife.Properties.Resources.Icon_Options_Cropped;
            this.toolStripOptionsButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripOptionsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOptionsButton.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.toolStripOptionsButton.Name = "toolStripOptionsButton";
            this.toolStripOptionsButton.Size = new System.Drawing.Size(36, 36);
            this.toolStripOptionsButton.Text = "Options";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripSaveButton
            // 
            this.toolStripSaveButton.AutoSize = false;
            this.toolStripSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveButton.Image = global::GameOfLife.Properties.Resources.Icon_Save_Cropped;
            this.toolStripSaveButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveButton.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.toolStripSaveButton.Name = "toolStripSaveButton";
            this.toolStripSaveButton.Size = new System.Drawing.Size(36, 36);
            this.toolStripSaveButton.Text = "Save";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripPlayButton
            // 
            this.toolStripPlayButton.AutoSize = false;
            this.toolStripPlayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPlayButton.Image = global::GameOfLife.Properties.Resources.Icon_Play_Cropped;
            this.toolStripPlayButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPlayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPlayButton.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.toolStripPlayButton.Name = "toolStripPlayButton";
            this.toolStripPlayButton.Size = new System.Drawing.Size(36, 36);
            this.toolStripPlayButton.Text = "Play";
            this.toolStripPlayButton.Click += new System.EventHandler(this.toolStripPlayButton_Click);
            // 
            // toolStripPauseButton
            // 
            this.toolStripPauseButton.AutoSize = false;
            this.toolStripPauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPauseButton.Image = global::GameOfLife.Properties.Resources.Icon_Pause_Cropped;
            this.toolStripPauseButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPauseButton.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.toolStripPauseButton.Name = "toolStripPauseButton";
            this.toolStripPauseButton.Size = new System.Drawing.Size(36, 36);
            this.toolStripPauseButton.Text = "Pause";
            this.toolStripPauseButton.Click += new System.EventHandler(this.toolStripPauseButton_Click);
            // 
            // toolStripNextButton
            // 
            this.toolStripNextButton.AutoSize = false;
            this.toolStripNextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNextButton.Image = global::GameOfLife.Properties.Resources.Icon_Next_Cropped;
            this.toolStripNextButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripNextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNextButton.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.toolStripNextButton.Name = "toolStripNextButton";
            this.toolStripNextButton.Size = new System.Drawing.Size(36, 36);
            this.toolStripNextButton.Text = "Next";
            this.toolStripNextButton.Click += new System.EventHandler(this.toolStripNextButton_Click);
            // 
            // graphicsPanel
            // 
            this.graphicsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.graphicsPanel.ContextMenuStrip = this.contextMenuDisplay;
            this.graphicsPanel.Controls.Add(this.hudPanel);
            this.graphicsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel.Location = new System.Drawing.Point(0, 70);
            this.graphicsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.graphicsPanel.Name = "graphicsPanel";
            this.graphicsPanel.Size = new System.Drawing.Size(944, 411);
            this.graphicsPanel.TabIndex = 3;
            this.graphicsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel_Paint);
            this.graphicsPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel_MouseClick);
            // 
            // contextMenuDisplay
            // 
            this.contextMenuDisplay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuDisplayOptionsMenuItem,
            this.contextMenuDisplayClearMenuItem,
            this.contextMenuDisplaySeparator1,
            this.contextMenuDisplayEditColors,
            this.contextMenuDisplayToggleHudMenuItem,
            this.contextMenuDisplayToggleGridMenuItem});
            this.contextMenuDisplay.Name = "contextMenuStrip";
            this.contextMenuDisplay.Size = new System.Drawing.Size(138, 120);
            // 
            // contextMenuDisplayOptionsMenuItem
            // 
            this.contextMenuDisplayOptionsMenuItem.Name = "contextMenuDisplayOptionsMenuItem";
            this.contextMenuDisplayOptionsMenuItem.Size = new System.Drawing.Size(137, 22);
            this.contextMenuDisplayOptionsMenuItem.Text = "Options";
            this.contextMenuDisplayOptionsMenuItem.Click += new System.EventHandler(this.contextMenuDisplayOptionsMenuItem_Click);
            // 
            // contextMenuDisplayClearMenuItem
            // 
            this.contextMenuDisplayClearMenuItem.Name = "contextMenuDisplayClearMenuItem";
            this.contextMenuDisplayClearMenuItem.Size = new System.Drawing.Size(137, 22);
            this.contextMenuDisplayClearMenuItem.Text = "Clear";
            this.contextMenuDisplayClearMenuItem.Click += new System.EventHandler(this.contextMenuDisplayClearMenuItem_Click);
            // 
            // contextMenuDisplaySeparator1
            // 
            this.contextMenuDisplaySeparator1.Name = "contextMenuDisplaySeparator1";
            this.contextMenuDisplaySeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // contextMenuDisplayEditColors
            // 
            this.contextMenuDisplayEditColors.Name = "contextMenuDisplayEditColors";
            this.contextMenuDisplayEditColors.Size = new System.Drawing.Size(137, 22);
            this.contextMenuDisplayEditColors.Text = "Edit Colors";
            this.contextMenuDisplayEditColors.Click += new System.EventHandler(this.contextMenuDisplayEditColors_Click);
            // 
            // contextMenuDisplayToggleHudMenuItem
            // 
            this.contextMenuDisplayToggleHudMenuItem.Name = "contextMenuDisplayToggleHudMenuItem";
            this.contextMenuDisplayToggleHudMenuItem.Size = new System.Drawing.Size(137, 22);
            this.contextMenuDisplayToggleHudMenuItem.Text = "Toggle HUD";
            // 
            // contextMenuDisplayToggleGridMenuItem
            // 
            this.contextMenuDisplayToggleGridMenuItem.Name = "contextMenuDisplayToggleGridMenuItem";
            this.contextMenuDisplayToggleGridMenuItem.Size = new System.Drawing.Size(137, 22);
            this.contextMenuDisplayToggleGridMenuItem.Text = "Toggle Grid";
            // 
            // hudPanel
            // 
            this.hudPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hudPanel.AutoSize = true;
            this.hudPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hudPanel.BackColor = System.Drawing.Color.Black;
            this.hudPanel.BackgroundImage = global::GameOfLife.Properties.Resources.HUD_Background;
            this.hudPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hudPanel.Controls.Add(this.hudTableLayout);
            this.hudPanel.Location = new System.Drawing.Point(0, 319);
            this.hudPanel.Margin = new System.Windows.Forms.Padding(0);
            this.hudPanel.Name = "hudPanel";
            this.hudPanel.Padding = new System.Windows.Forms.Padding(2);
            this.hudPanel.Size = new System.Drawing.Size(174, 92);
            this.hudPanel.TabIndex = 0;
            // 
            // hudTableLayout
            // 
            this.hudTableLayout.AutoSize = true;
            this.hudTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hudTableLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hudTableLayout.ColumnCount = 2;
            this.hudTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.hudTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.hudTableLayout.Controls.Add(this.hudScaleValueLabel, 1, 3);
            this.hudTableLayout.Controls.Add(this.hudBorderValueLabel, 1, 2);
            this.hudTableLayout.Controls.Add(this.hudSeedValueLabel, 1, 1);
            this.hudTableLayout.Controls.Add(this.hudIntervalValueLabel, 1, 0);
            this.hudTableLayout.Controls.Add(this.hudScaleNameLabel, 0, 3);
            this.hudTableLayout.Controls.Add(this.hudBorderNameLabel, 0, 2);
            this.hudTableLayout.Controls.Add(this.hudSeedNameLabel, 0, 1);
            this.hudTableLayout.Controls.Add(this.hudIntervalNameLabel, 0, 0);
            this.hudTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hudTableLayout.Location = new System.Drawing.Point(2, 2);
            this.hudTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.hudTableLayout.Name = "hudTableLayout";
            this.hudTableLayout.RowCount = 4;
            this.hudTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.hudTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.hudTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.hudTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.hudTableLayout.Size = new System.Drawing.Size(170, 88);
            this.hudTableLayout.TabIndex = 1;
            // 
            // hudScaleValueLabel
            // 
            this.hudScaleValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hudScaleValueLabel.AutoSize = true;
            this.hudScaleValueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hudScaleValueLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudScaleValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hudScaleValueLabel.Location = new System.Drawing.Point(90, 66);
            this.hudScaleValueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hudScaleValueLabel.Name = "hudScaleValueLabel";
            this.hudScaleValueLabel.Size = new System.Drawing.Size(80, 22);
            this.hudScaleValueLabel.TabIndex = 8;
            this.hudScaleValueLabel.Text = "64 x 32";
            // 
            // hudBorderValueLabel
            // 
            this.hudBorderValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hudBorderValueLabel.AutoSize = true;
            this.hudBorderValueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hudBorderValueLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudBorderValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hudBorderValueLabel.Location = new System.Drawing.Point(90, 44);
            this.hudBorderValueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hudBorderValueLabel.Name = "hudBorderValueLabel";
            this.hudBorderValueLabel.Size = new System.Drawing.Size(50, 22);
            this.hudBorderValueLabel.TabIndex = 7;
            this.hudBorderValueLabel.Text = "Wrap";
            // 
            // hudSeedValueLabel
            // 
            this.hudSeedValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hudSeedValueLabel.AutoSize = true;
            this.hudSeedValueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hudSeedValueLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudSeedValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hudSeedValueLabel.Location = new System.Drawing.Point(90, 22);
            this.hudSeedValueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hudSeedValueLabel.Name = "hudSeedValueLabel";
            this.hudSeedValueLabel.Size = new System.Drawing.Size(50, 22);
            this.hudSeedValueLabel.TabIndex = 6;
            this.hudSeedValueLabel.Text = "2000";
            // 
            // hudIntervalValueLabel
            // 
            this.hudIntervalValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hudIntervalValueLabel.AutoSize = true;
            this.hudIntervalValueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hudIntervalValueLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudIntervalValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hudIntervalValueLabel.Location = new System.Drawing.Point(90, 0);
            this.hudIntervalValueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hudIntervalValueLabel.Name = "hudIntervalValueLabel";
            this.hudIntervalValueLabel.Size = new System.Drawing.Size(30, 22);
            this.hudIntervalValueLabel.TabIndex = 5;
            this.hudIntervalValueLabel.Text = "20";
            // 
            // hudScaleNameLabel
            // 
            this.hudScaleNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hudScaleNameLabel.AutoSize = true;
            this.hudScaleNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hudScaleNameLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudScaleNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hudScaleNameLabel.Location = new System.Drawing.Point(0, 66);
            this.hudScaleNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hudScaleNameLabel.Name = "hudScaleNameLabel";
            this.hudScaleNameLabel.Size = new System.Drawing.Size(60, 22);
            this.hudScaleNameLabel.TabIndex = 5;
            this.hudScaleNameLabel.Text = "Scale";
            // 
            // hudBorderNameLabel
            // 
            this.hudBorderNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hudBorderNameLabel.AutoSize = true;
            this.hudBorderNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hudBorderNameLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudBorderNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hudBorderNameLabel.Location = new System.Drawing.Point(0, 44);
            this.hudBorderNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hudBorderNameLabel.Name = "hudBorderNameLabel";
            this.hudBorderNameLabel.Size = new System.Drawing.Size(70, 22);
            this.hudBorderNameLabel.TabIndex = 3;
            this.hudBorderNameLabel.Text = "Border";
            // 
            // hudSeedNameLabel
            // 
            this.hudSeedNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hudSeedNameLabel.AutoSize = true;
            this.hudSeedNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hudSeedNameLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudSeedNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hudSeedNameLabel.Location = new System.Drawing.Point(0, 22);
            this.hudSeedNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hudSeedNameLabel.Name = "hudSeedNameLabel";
            this.hudSeedNameLabel.Size = new System.Drawing.Size(50, 22);
            this.hudSeedNameLabel.TabIndex = 3;
            this.hudSeedNameLabel.Text = "Seed";
            // 
            // hudIntervalNameLabel
            // 
            this.hudIntervalNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hudIntervalNameLabel.AutoSize = true;
            this.hudIntervalNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hudIntervalNameLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudIntervalNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hudIntervalNameLabel.Location = new System.Drawing.Point(0, 0);
            this.hudIntervalNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.hudIntervalNameLabel.Name = "hudIntervalNameLabel";
            this.hudIntervalNameLabel.Size = new System.Drawing.Size(90, 22);
            this.hudIntervalNameLabel.TabIndex = 4;
            this.hudIntervalNameLabel.Text = "Interval";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Game of Life";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.tableLayoutPanel.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.graphicsPanel.ResumeLayout(false);
            this.graphicsPanel.PerformLayout();
            this.contextMenuDisplay.ResumeLayout(false);
            this.hudPanel.ResumeLayout(false);
            this.hudPanel.PerformLayout();
            this.hudTableLayout.ResumeLayout(false);
            this.hudTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuStripFileMenu;
        private System.Windows.Forms.ToolStripMenuItem menuStripNewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripOpenMenuItem;
        private System.Windows.Forms.ToolStripSeparator menuStripFileMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuStripSaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripSaveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator menuStripFileMenuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuStripImportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripExportMenuItem;
        private System.Windows.Forms.ToolStripSeparator menuStripFileMenuSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuStripQuitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripToolsMenu;
        private System.Windows.Forms.ToolStripMenuItem menuStripOptionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripClearMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripViewMenu;
        private System.Windows.Forms.ToolStripMenuItem menuStripDisplayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripNeighborsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripHelpMenu;
        private System.Windows.Forms.ToolStripMenuItem menuStripAboutMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripGenerationStatusLabel;
        private System.Windows.Forms.ToolStripSeparator statusStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLiveStatusLabel;
        private System.Windows.Forms.ToolStripSeparator statusStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel statusStripTotalStatusLabel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripOptionsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripSaveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripPlayButton;
        private System.Windows.Forms.ToolStripButton toolStripPauseButton;
        private System.Windows.Forms.ToolStripButton toolStripNextButton;
        private GraphicsPanel graphicsPanel;
        private System.Windows.Forms.Panel hudPanel;
        private System.Windows.Forms.TableLayoutPanel hudTableLayout;
        private System.Windows.Forms.Label hudScaleValueLabel;
        private System.Windows.Forms.Label hudBorderValueLabel;
        private System.Windows.Forms.Label hudSeedValueLabel;
        private System.Windows.Forms.Label hudIntervalValueLabel;
        private System.Windows.Forms.Label hudScaleNameLabel;
        private System.Windows.Forms.Label hudBorderNameLabel;
        private System.Windows.Forms.Label hudSeedNameLabel;
        private System.Windows.Forms.Label hudIntervalNameLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuDisplay;
        private System.Windows.Forms.ToolStripMenuItem contextMenuDisplayToggleHudMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextMenuDisplayToggleGridMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextMenuDisplayEditColors;
        private System.Windows.Forms.ToolStripMenuItem contextMenuDisplayOptionsMenuItem;
        private System.Windows.Forms.ToolStripSeparator contextMenuDisplaySeparator1;
        private System.Windows.Forms.ToolStripMenuItem contextMenuDisplayClearMenuItem;
    }
}

