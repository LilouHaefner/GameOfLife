
namespace GameOfLife
{
    partial class OptionsForm
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
            this.dialogCancelButton = new System.Windows.Forms.Button();
            this.dialogConfirmButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.generalTab = new System.Windows.Forms.TabPage();
            this.generalTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.intervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.borderModeLabel = new System.Windows.Forms.Label();
            this.scaleTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.scaleXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.scaleSeparatorLabel = new System.Windows.Forms.Label();
            this.scaleYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.borderModeComboBox = new System.Windows.Forms.ComboBox();
            this.rulesTab = new System.Windows.Forms.TabPage();
            this.rulesTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.neighborRadiusLabel = new System.Windows.Forms.Label();
            this.neighborLiveLabel = new System.Windows.Forms.Label();
            this.neighborRangeTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.neighborLiveMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.neighborLiveSeparatorLabel = new System.Windows.Forms.Label();
            this.neighborLiveMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.neighborRadiusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.celBirthThresholdLabel = new System.Windows.Forms.Label();
            this.cellBirthThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.generationTab = new System.Windows.Forms.TabPage();
            this.generationTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.randomSeedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.randomThresholdLabel = new System.Windows.Forms.Label();
            this.randomSeedNewSeedButton = new System.Windows.Forms.Button();
            this.randomModeLabel = new System.Windows.Forms.Label();
            this.randomSeedLabel = new System.Windows.Forms.Label();
            this.randomMultiplierLabel = new System.Windows.Forms.Label();
            this.randomModeComboBox = new System.Windows.Forms.ComboBox();
            this.randomThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.randomMultiplierNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.randomizeButton = new System.Windows.Forms.Button();
            this.displayTab = new System.Windows.Forms.TabPage();
            this.displayTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.backgroundColorButton = new System.Windows.Forms.Button();
            this.showGridCheckbox = new System.Windows.Forms.CheckBox();
            this.showNeighborCountCheckbox = new System.Windows.Forms.CheckBox();
            this.showHudLabel = new System.Windows.Forms.Label();
            this.showNeighborCountLabel = new System.Windows.Forms.Label();
            this.showGridLabel = new System.Windows.Forms.Label();
            this.showHudCheckbox = new System.Windows.Forms.CheckBox();
            this.gridColorButton = new System.Windows.Forms.Button();
            this.cellColorLabel = new System.Windows.Forms.Label();
            this.cellColorButton = new System.Windows.Forms.Button();
            this.gridColorLabel = new System.Windows.Forms.Label();
            this.backgroundColorLabel = new System.Windows.Forms.Label();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuResetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuReloadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialogTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.eBorderModeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.generalTab.SuspendLayout();
            this.generalTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).BeginInit();
            this.scaleTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleYNumericUpDown)).BeginInit();
            this.rulesTab.SuspendLayout();
            this.rulesTableLayout.SuspendLayout();
            this.neighborRangeTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neighborLiveMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neighborLiveMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neighborRadiusNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellBirthThresholdNumericUpDown)).BeginInit();
            this.generationTab.SuspendLayout();
            this.generationTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randomSeedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomThresholdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomMultiplierNumericUpDown)).BeginInit();
            this.displayTab.SuspendLayout();
            this.displayTableLayout.SuspendLayout();
            this.tableLayout.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.dialogTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBorderModeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dialogCancelButton
            // 
            this.dialogCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dialogCancelButton.Location = new System.Drawing.Point(84, 3);
            this.dialogCancelButton.Name = "dialogCancelButton";
            this.dialogCancelButton.Size = new System.Drawing.Size(75, 23);
            this.dialogCancelButton.TabIndex = 1;
            this.dialogCancelButton.Text = "Cancel";
            this.dialogCancelButton.UseVisualStyleBackColor = true;
            // 
            // dialogConfirmButton
            // 
            this.dialogConfirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.dialogConfirmButton.Location = new System.Drawing.Point(3, 3);
            this.dialogConfirmButton.Name = "dialogConfirmButton";
            this.dialogConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.dialogConfirmButton.TabIndex = 0;
            this.dialogConfirmButton.Text = "Confirm";
            this.dialogConfirmButton.UseVisualStyleBackColor = true;
            this.dialogConfirmButton.Click += new System.EventHandler(this.dialogConfirmButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.generalTab);
            this.tabControl.Controls.Add(this.rulesTab);
            this.tabControl.Controls.Add(this.generationTab);
            this.tabControl.Controls.Add(this.displayTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(8, 8);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(496, 207);
            this.tabControl.TabIndex = 2;
            // 
            // generalTab
            // 
            this.generalTab.Controls.Add(this.generalTableLayout);
            this.generalTab.Location = new System.Drawing.Point(4, 22);
            this.generalTab.Margin = new System.Windows.Forms.Padding(0);
            this.generalTab.Name = "generalTab";
            this.generalTab.Size = new System.Drawing.Size(488, 181);
            this.generalTab.TabIndex = 0;
            this.generalTab.Text = "General";
            this.generalTab.UseVisualStyleBackColor = true;
            // 
            // generalTableLayout
            // 
            this.generalTableLayout.ColumnCount = 3;
            this.generalTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.generalTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.generalTableLayout.Controls.Add(this.intervalNumericUpDown, 1, 1);
            this.generalTableLayout.Controls.Add(this.scaleLabel, 0, 0);
            this.generalTableLayout.Controls.Add(this.intervalLabel, 0, 1);
            this.generalTableLayout.Controls.Add(this.borderModeLabel, 0, 2);
            this.generalTableLayout.Controls.Add(this.scaleTableLayout, 1, 0);
            this.generalTableLayout.Controls.Add(this.borderModeComboBox, 1, 2);
            this.generalTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalTableLayout.Location = new System.Drawing.Point(0, 0);
            this.generalTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.generalTableLayout.Name = "generalTableLayout";
            this.generalTableLayout.RowCount = 4;
            this.generalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generalTableLayout.Size = new System.Drawing.Size(488, 181);
            this.generalTableLayout.TabIndex = 3;
            // 
            // intervalNumericUpDown
            // 
            this.intervalNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.intervalNumericUpDown.Location = new System.Drawing.Point(248, 33);
            this.intervalNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.intervalNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.intervalNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intervalNumericUpDown.Name = "intervalNumericUpDown";
            this.intervalNumericUpDown.Size = new System.Drawing.Size(114, 20);
            this.intervalNumericUpDown.TabIndex = 10;
            this.intervalNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.intervalNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // scaleLabel
            // 
            this.scaleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Location = new System.Drawing.Point(4, 4);
            this.scaleLabel.Margin = new System.Windows.Forms.Padding(4);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Padding = new System.Windows.Forms.Padding(4);
            this.scaleLabel.Size = new System.Drawing.Size(236, 21);
            this.scaleLabel.TabIndex = 0;
            this.scaleLabel.Text = "Scale";
            this.scaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // intervalLabel
            // 
            this.intervalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(4, 33);
            this.intervalLabel.Margin = new System.Windows.Forms.Padding(4);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Padding = new System.Windows.Forms.Padding(4);
            this.intervalLabel.Size = new System.Drawing.Size(236, 21);
            this.intervalLabel.TabIndex = 1;
            this.intervalLabel.Text = "Interval";
            this.intervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // borderModeLabel
            // 
            this.borderModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.borderModeLabel.AutoSize = true;
            this.borderModeLabel.Location = new System.Drawing.Point(4, 62);
            this.borderModeLabel.Margin = new System.Windows.Forms.Padding(4);
            this.borderModeLabel.Name = "borderModeLabel";
            this.borderModeLabel.Padding = new System.Windows.Forms.Padding(4);
            this.borderModeLabel.Size = new System.Drawing.Size(236, 21);
            this.borderModeLabel.TabIndex = 2;
            this.borderModeLabel.Text = "Border Mode";
            this.borderModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scaleTableLayout
            // 
            this.scaleTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleTableLayout.ColumnCount = 3;
            this.scaleTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scaleTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.scaleTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.scaleTableLayout.Controls.Add(this.scaleXNumericUpDown, 0, 0);
            this.scaleTableLayout.Controls.Add(this.scaleSeparatorLabel, 1, 0);
            this.scaleTableLayout.Controls.Add(this.scaleYNumericUpDown, 2, 0);
            this.scaleTableLayout.Location = new System.Drawing.Point(248, 4);
            this.scaleTableLayout.Margin = new System.Windows.Forms.Padding(4);
            this.scaleTableLayout.Name = "scaleTableLayout";
            this.scaleTableLayout.RowCount = 1;
            this.scaleTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.scaleTableLayout.Size = new System.Drawing.Size(114, 20);
            this.scaleTableLayout.TabIndex = 9;
            // 
            // scaleXNumericUpDown
            // 
            this.scaleXNumericUpDown.AutoSize = true;
            this.scaleXNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scaleXNumericUpDown.Location = new System.Drawing.Point(0, 0);
            this.scaleXNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.scaleXNumericUpDown.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.scaleXNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scaleXNumericUpDown.Name = "scaleXNumericUpDown";
            this.scaleXNumericUpDown.Size = new System.Drawing.Size(47, 20);
            this.scaleXNumericUpDown.TabIndex = 9;
            this.scaleXNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.scaleXNumericUpDown.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // scaleSeparatorLabel
            // 
            this.scaleSeparatorLabel.AutoSize = true;
            this.scaleSeparatorLabel.Location = new System.Drawing.Point(49, 0);
            this.scaleSeparatorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scaleSeparatorLabel.Name = "scaleSeparatorLabel";
            this.scaleSeparatorLabel.Padding = new System.Windows.Forms.Padding(2);
            this.scaleSeparatorLabel.Size = new System.Drawing.Size(16, 17);
            this.scaleSeparatorLabel.TabIndex = 8;
            this.scaleSeparatorLabel.Text = "x";
            // 
            // scaleYNumericUpDown
            // 
            this.scaleYNumericUpDown.AutoSize = true;
            this.scaleYNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scaleYNumericUpDown.Location = new System.Drawing.Point(67, 0);
            this.scaleYNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.scaleYNumericUpDown.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.scaleYNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scaleYNumericUpDown.Name = "scaleYNumericUpDown";
            this.scaleYNumericUpDown.Size = new System.Drawing.Size(47, 20);
            this.scaleYNumericUpDown.TabIndex = 10;
            this.scaleYNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.scaleYNumericUpDown.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // borderModeComboBox
            // 
            this.borderModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.borderModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.borderModeComboBox.FormattingEnabled = true;
            this.borderModeComboBox.Items.AddRange(new object[] {
            "Clip",
            "Wrap"});
            this.borderModeComboBox.Location = new System.Drawing.Point(248, 62);
            this.borderModeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.borderModeComboBox.Name = "borderModeComboBox";
            this.borderModeComboBox.Size = new System.Drawing.Size(114, 21);
            this.borderModeComboBox.TabIndex = 11;
            // 
            // rulesTab
            // 
            this.rulesTab.Controls.Add(this.rulesTableLayout);
            this.rulesTab.Location = new System.Drawing.Point(4, 22);
            this.rulesTab.Margin = new System.Windows.Forms.Padding(0);
            this.rulesTab.Name = "rulesTab";
            this.rulesTab.Size = new System.Drawing.Size(488, 181);
            this.rulesTab.TabIndex = 1;
            this.rulesTab.Text = "Rules";
            this.rulesTab.UseVisualStyleBackColor = true;
            // 
            // rulesTableLayout
            // 
            this.rulesTableLayout.ColumnCount = 3;
            this.rulesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rulesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.rulesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.rulesTableLayout.Controls.Add(this.neighborRadiusLabel, 0, 0);
            this.rulesTableLayout.Controls.Add(this.neighborLiveLabel, 0, 1);
            this.rulesTableLayout.Controls.Add(this.neighborRangeTableLayout, 1, 1);
            this.rulesTableLayout.Controls.Add(this.neighborRadiusNumericUpDown, 1, 0);
            this.rulesTableLayout.Controls.Add(this.celBirthThresholdLabel, 0, 2);
            this.rulesTableLayout.Controls.Add(this.cellBirthThresholdNumericUpDown, 1, 2);
            this.rulesTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rulesTableLayout.Location = new System.Drawing.Point(0, 0);
            this.rulesTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.rulesTableLayout.Name = "rulesTableLayout";
            this.rulesTableLayout.RowCount = 4;
            this.rulesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rulesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rulesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rulesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rulesTableLayout.Size = new System.Drawing.Size(488, 181);
            this.rulesTableLayout.TabIndex = 5;
            // 
            // neighborRadiusLabel
            // 
            this.neighborRadiusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.neighborRadiusLabel.AutoSize = true;
            this.neighborRadiusLabel.Location = new System.Drawing.Point(4, 4);
            this.neighborRadiusLabel.Margin = new System.Windows.Forms.Padding(4);
            this.neighborRadiusLabel.Name = "neighborRadiusLabel";
            this.neighborRadiusLabel.Padding = new System.Windows.Forms.Padding(4);
            this.neighborRadiusLabel.Size = new System.Drawing.Size(236, 21);
            this.neighborRadiusLabel.TabIndex = 0;
            this.neighborRadiusLabel.Text = "Neighbor Radius";
            this.neighborRadiusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // neighborLiveLabel
            // 
            this.neighborLiveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.neighborLiveLabel.AutoSize = true;
            this.neighborLiveLabel.Location = new System.Drawing.Point(4, 33);
            this.neighborLiveLabel.Margin = new System.Windows.Forms.Padding(4);
            this.neighborLiveLabel.Name = "neighborLiveLabel";
            this.neighborLiveLabel.Padding = new System.Windows.Forms.Padding(4);
            this.neighborLiveLabel.Size = new System.Drawing.Size(236, 21);
            this.neighborLiveLabel.TabIndex = 1;
            this.neighborLiveLabel.Text = "Neighbor Live Range";
            this.neighborLiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // neighborRangeTableLayout
            // 
            this.neighborRangeTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.neighborRangeTableLayout.ColumnCount = 3;
            this.neighborRangeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.neighborRangeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.neighborRangeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.neighborRangeTableLayout.Controls.Add(this.neighborLiveMinNumericUpDown, 0, 0);
            this.neighborRangeTableLayout.Controls.Add(this.neighborLiveSeparatorLabel, 1, 0);
            this.neighborRangeTableLayout.Controls.Add(this.neighborLiveMaxNumericUpDown, 2, 0);
            this.neighborRangeTableLayout.Location = new System.Drawing.Point(248, 33);
            this.neighborRangeTableLayout.Margin = new System.Windows.Forms.Padding(4);
            this.neighborRangeTableLayout.Name = "neighborRangeTableLayout";
            this.neighborRangeTableLayout.RowCount = 1;
            this.neighborRangeTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.neighborRangeTableLayout.Size = new System.Drawing.Size(114, 20);
            this.neighborRangeTableLayout.TabIndex = 9;
            // 
            // neighborLiveMinNumericUpDown
            // 
            this.neighborLiveMinNumericUpDown.AutoSize = true;
            this.neighborLiveMinNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.neighborLiveMinNumericUpDown.Location = new System.Drawing.Point(0, 0);
            this.neighborLiveMinNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.neighborLiveMinNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.neighborLiveMinNumericUpDown.Name = "neighborLiveMinNumericUpDown";
            this.neighborLiveMinNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.neighborLiveMinNumericUpDown.TabIndex = 9;
            this.neighborLiveMinNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.neighborLiveMinNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // neighborLiveSeparatorLabel
            // 
            this.neighborLiveSeparatorLabel.AutoSize = true;
            this.neighborLiveSeparatorLabel.Location = new System.Drawing.Point(50, 0);
            this.neighborLiveSeparatorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.neighborLiveSeparatorLabel.Name = "neighborLiveSeparatorLabel";
            this.neighborLiveSeparatorLabel.Padding = new System.Windows.Forms.Padding(2);
            this.neighborLiveSeparatorLabel.Size = new System.Drawing.Size(14, 17);
            this.neighborLiveSeparatorLabel.TabIndex = 8;
            this.neighborLiveSeparatorLabel.Text = "-";
            // 
            // neighborLiveMaxNumericUpDown
            // 
            this.neighborLiveMaxNumericUpDown.AutoSize = true;
            this.neighborLiveMaxNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.neighborLiveMaxNumericUpDown.Location = new System.Drawing.Point(66, 0);
            this.neighborLiveMaxNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.neighborLiveMaxNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.neighborLiveMaxNumericUpDown.Name = "neighborLiveMaxNumericUpDown";
            this.neighborLiveMaxNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.neighborLiveMaxNumericUpDown.TabIndex = 10;
            this.neighborLiveMaxNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.neighborLiveMaxNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // neighborRadiusNumericUpDown
            // 
            this.neighborRadiusNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.neighborRadiusNumericUpDown.Location = new System.Drawing.Point(248, 4);
            this.neighborRadiusNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.neighborRadiusNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.neighborRadiusNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.neighborRadiusNumericUpDown.Name = "neighborRadiusNumericUpDown";
            this.neighborRadiusNumericUpDown.Size = new System.Drawing.Size(114, 20);
            this.neighborRadiusNumericUpDown.TabIndex = 12;
            this.neighborRadiusNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.neighborRadiusNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // celBirthThresholdLabel
            // 
            this.celBirthThresholdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.celBirthThresholdLabel.AutoSize = true;
            this.celBirthThresholdLabel.Location = new System.Drawing.Point(4, 62);
            this.celBirthThresholdLabel.Margin = new System.Windows.Forms.Padding(4);
            this.celBirthThresholdLabel.Name = "celBirthThresholdLabel";
            this.celBirthThresholdLabel.Padding = new System.Windows.Forms.Padding(4);
            this.celBirthThresholdLabel.Size = new System.Drawing.Size(236, 21);
            this.celBirthThresholdLabel.TabIndex = 14;
            this.celBirthThresholdLabel.Text = "Cell Birth Threshold";
            this.celBirthThresholdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cellBirthThresholdNumericUpDown
            // 
            this.cellBirthThresholdNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cellBirthThresholdNumericUpDown.Location = new System.Drawing.Point(248, 62);
            this.cellBirthThresholdNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.cellBirthThresholdNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.cellBirthThresholdNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cellBirthThresholdNumericUpDown.Name = "cellBirthThresholdNumericUpDown";
            this.cellBirthThresholdNumericUpDown.Size = new System.Drawing.Size(114, 20);
            this.cellBirthThresholdNumericUpDown.TabIndex = 15;
            this.cellBirthThresholdNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cellBirthThresholdNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // generationTab
            // 
            this.generationTab.Controls.Add(this.generationTableLayout);
            this.generationTab.Location = new System.Drawing.Point(4, 22);
            this.generationTab.Name = "generationTab";
            this.generationTab.Size = new System.Drawing.Size(488, 181);
            this.generationTab.TabIndex = 2;
            this.generationTab.Text = "Generation";
            this.generationTab.UseVisualStyleBackColor = true;
            // 
            // generationTableLayout
            // 
            this.generationTableLayout.ColumnCount = 3;
            this.generationTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generationTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.generationTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.generationTableLayout.Controls.Add(this.randomSeedNumericUpDown, 1, 1);
            this.generationTableLayout.Controls.Add(this.randomThresholdLabel, 0, 3);
            this.generationTableLayout.Controls.Add(this.randomSeedNewSeedButton, 2, 1);
            this.generationTableLayout.Controls.Add(this.randomModeLabel, 0, 0);
            this.generationTableLayout.Controls.Add(this.randomSeedLabel, 0, 1);
            this.generationTableLayout.Controls.Add(this.randomMultiplierLabel, 0, 4);
            this.generationTableLayout.Controls.Add(this.randomModeComboBox, 1, 0);
            this.generationTableLayout.Controls.Add(this.randomThresholdNumericUpDown, 1, 3);
            this.generationTableLayout.Controls.Add(this.randomMultiplierNumericUpDown, 1, 4);
            this.generationTableLayout.Controls.Add(this.randomizeButton, 1, 5);
            this.generationTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generationTableLayout.Location = new System.Drawing.Point(0, 0);
            this.generationTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.generationTableLayout.Name = "generationTableLayout";
            this.generationTableLayout.RowCount = 7;
            this.generationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generationTableLayout.Size = new System.Drawing.Size(488, 181);
            this.generationTableLayout.TabIndex = 6;
            // 
            // randomSeedNumericUpDown
            // 
            this.randomSeedNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.randomSeedNumericUpDown.Location = new System.Drawing.Point(248, 33);
            this.randomSeedNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.randomSeedNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.randomSeedNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.randomSeedNumericUpDown.Name = "randomSeedNumericUpDown";
            this.randomSeedNumericUpDown.Size = new System.Drawing.Size(114, 20);
            this.randomSeedNumericUpDown.TabIndex = 24;
            this.randomSeedNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.randomSeedNumericUpDown.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // randomThresholdLabel
            // 
            this.randomThresholdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.randomThresholdLabel.AutoSize = true;
            this.randomThresholdLabel.Location = new System.Drawing.Point(4, 62);
            this.randomThresholdLabel.Margin = new System.Windows.Forms.Padding(4);
            this.randomThresholdLabel.Name = "randomThresholdLabel";
            this.randomThresholdLabel.Padding = new System.Windows.Forms.Padding(4);
            this.randomThresholdLabel.Size = new System.Drawing.Size(236, 21);
            this.randomThresholdLabel.TabIndex = 19;
            this.randomThresholdLabel.Text = "Random Threshold";
            this.randomThresholdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // randomSeedNewSeedButton
            // 
            this.randomSeedNewSeedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.randomSeedNewSeedButton.Location = new System.Drawing.Point(370, 33);
            this.randomSeedNewSeedButton.Margin = new System.Windows.Forms.Padding(4);
            this.randomSeedNewSeedButton.Name = "randomSeedNewSeedButton";
            this.randomSeedNewSeedButton.Size = new System.Drawing.Size(114, 20);
            this.randomSeedNewSeedButton.TabIndex = 10;
            this.randomSeedNewSeedButton.Text = "New Seed";
            this.randomSeedNewSeedButton.UseVisualStyleBackColor = true;
            this.randomSeedNewSeedButton.Click += new System.EventHandler(this.randomSeedNewSeedButton_Click);
            // 
            // randomModeLabel
            // 
            this.randomModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.randomModeLabel.AutoSize = true;
            this.randomModeLabel.Location = new System.Drawing.Point(4, 4);
            this.randomModeLabel.Margin = new System.Windows.Forms.Padding(4);
            this.randomModeLabel.Name = "randomModeLabel";
            this.randomModeLabel.Padding = new System.Windows.Forms.Padding(4);
            this.randomModeLabel.Size = new System.Drawing.Size(236, 21);
            this.randomModeLabel.TabIndex = 1;
            this.randomModeLabel.Text = "Random Mode";
            this.randomModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // randomSeedLabel
            // 
            this.randomSeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.randomSeedLabel.AutoSize = true;
            this.randomSeedLabel.Location = new System.Drawing.Point(4, 33);
            this.randomSeedLabel.Margin = new System.Windows.Forms.Padding(4);
            this.randomSeedLabel.Name = "randomSeedLabel";
            this.randomSeedLabel.Padding = new System.Windows.Forms.Padding(4);
            this.randomSeedLabel.Size = new System.Drawing.Size(236, 21);
            this.randomSeedLabel.TabIndex = 14;
            this.randomSeedLabel.Text = "Random Seed";
            this.randomSeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // randomMultiplierLabel
            // 
            this.randomMultiplierLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.randomMultiplierLabel.AutoSize = true;
            this.randomMultiplierLabel.Location = new System.Drawing.Point(4, 91);
            this.randomMultiplierLabel.Margin = new System.Windows.Forms.Padding(4);
            this.randomMultiplierLabel.Name = "randomMultiplierLabel";
            this.randomMultiplierLabel.Padding = new System.Windows.Forms.Padding(4);
            this.randomMultiplierLabel.Size = new System.Drawing.Size(236, 21);
            this.randomMultiplierLabel.TabIndex = 20;
            this.randomMultiplierLabel.Text = "Random Multiplier";
            this.randomMultiplierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // randomModeComboBox
            // 
            this.randomModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.randomModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.randomModeComboBox.FormattingEnabled = true;
            this.randomModeComboBox.Items.AddRange(new object[] {
            "Clip",
            "Wrap"});
            this.randomModeComboBox.Location = new System.Drawing.Point(248, 4);
            this.randomModeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.randomModeComboBox.Name = "randomModeComboBox";
            this.randomModeComboBox.Size = new System.Drawing.Size(114, 21);
            this.randomModeComboBox.TabIndex = 17;
            this.randomModeComboBox.SelectedIndexChanged += new System.EventHandler(this.randomModeComboBox_SelectedIndexChanged);
            // 
            // randomThresholdNumericUpDown
            // 
            this.randomThresholdNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.randomThresholdNumericUpDown.DecimalPlaces = 2;
            this.randomThresholdNumericUpDown.Location = new System.Drawing.Point(248, 62);
            this.randomThresholdNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.randomThresholdNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.randomThresholdNumericUpDown.Name = "randomThresholdNumericUpDown";
            this.randomThresholdNumericUpDown.Size = new System.Drawing.Size(114, 20);
            this.randomThresholdNumericUpDown.TabIndex = 21;
            this.randomThresholdNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.randomThresholdNumericUpDown.Value = new decimal(new int[] {
            75,
            0,
            0,
            65536});
            // 
            // randomMultiplierNumericUpDown
            // 
            this.randomMultiplierNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.randomMultiplierNumericUpDown.DecimalPlaces = 2;
            this.randomMultiplierNumericUpDown.Location = new System.Drawing.Point(248, 91);
            this.randomMultiplierNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.randomMultiplierNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.randomMultiplierNumericUpDown.Name = "randomMultiplierNumericUpDown";
            this.randomMultiplierNumericUpDown.Size = new System.Drawing.Size(114, 20);
            this.randomMultiplierNumericUpDown.TabIndex = 22;
            this.randomMultiplierNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.randomMultiplierNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // randomizeButton
            // 
            this.randomizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.randomizeButton.Location = new System.Drawing.Point(248, 120);
            this.randomizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(114, 20);
            this.randomizeButton.TabIndex = 23;
            this.randomizeButton.Text = "Randomize";
            this.randomizeButton.UseVisualStyleBackColor = true;
            this.randomizeButton.Click += new System.EventHandler(this.randomizeButton_Click);
            // 
            // displayTab
            // 
            this.displayTab.Controls.Add(this.displayTableLayout);
            this.displayTab.Location = new System.Drawing.Point(4, 22);
            this.displayTab.Name = "displayTab";
            this.displayTab.Size = new System.Drawing.Size(488, 181);
            this.displayTab.TabIndex = 3;
            this.displayTab.Text = "Display";
            this.displayTab.UseVisualStyleBackColor = true;
            // 
            // displayTableLayout
            // 
            this.displayTableLayout.ColumnCount = 3;
            this.displayTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.displayTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.displayTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.displayTableLayout.Controls.Add(this.backgroundColorButton, 1, 5);
            this.displayTableLayout.Controls.Add(this.showGridCheckbox, 1, 2);
            this.displayTableLayout.Controls.Add(this.showNeighborCountCheckbox, 1, 1);
            this.displayTableLayout.Controls.Add(this.showHudLabel, 0, 0);
            this.displayTableLayout.Controls.Add(this.showNeighborCountLabel, 0, 1);
            this.displayTableLayout.Controls.Add(this.showGridLabel, 0, 2);
            this.displayTableLayout.Controls.Add(this.showHudCheckbox, 1, 0);
            this.displayTableLayout.Controls.Add(this.gridColorButton, 1, 4);
            this.displayTableLayout.Controls.Add(this.cellColorLabel, 0, 3);
            this.displayTableLayout.Controls.Add(this.cellColorButton, 1, 3);
            this.displayTableLayout.Controls.Add(this.gridColorLabel, 0, 4);
            this.displayTableLayout.Controls.Add(this.backgroundColorLabel, 0, 5);
            this.displayTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayTableLayout.Location = new System.Drawing.Point(0, 0);
            this.displayTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.displayTableLayout.Name = "displayTableLayout";
            this.displayTableLayout.Padding = new System.Windows.Forms.Padding(2);
            this.displayTableLayout.RowCount = 7;
            this.displayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.displayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.displayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.displayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.displayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.displayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.displayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.displayTableLayout.Size = new System.Drawing.Size(488, 181);
            this.displayTableLayout.TabIndex = 7;
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundColorButton.Location = new System.Drawing.Point(248, 151);
            this.backgroundColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(113, 20);
            this.backgroundColorButton.TabIndex = 28;
            this.backgroundColorButton.Text = "Edit";
            this.backgroundColorButton.UseVisualStyleBackColor = true;
            this.backgroundColorButton.Click += new System.EventHandler(this.backgroundColorButton_Click);
            // 
            // showGridCheckbox
            // 
            this.showGridCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showGridCheckbox.Checked = true;
            this.showGridCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showGridCheckbox.Location = new System.Drawing.Point(248, 64);
            this.showGridCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.showGridCheckbox.Name = "showGridCheckbox";
            this.showGridCheckbox.Size = new System.Drawing.Size(113, 20);
            this.showGridCheckbox.TabIndex = 24;
            this.showGridCheckbox.UseVisualStyleBackColor = true;
            // 
            // showNeighborCountCheckbox
            // 
            this.showNeighborCountCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showNeighborCountCheckbox.Checked = true;
            this.showNeighborCountCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showNeighborCountCheckbox.Location = new System.Drawing.Point(248, 35);
            this.showNeighborCountCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.showNeighborCountCheckbox.Name = "showNeighborCountCheckbox";
            this.showNeighborCountCheckbox.Size = new System.Drawing.Size(113, 20);
            this.showNeighborCountCheckbox.TabIndex = 23;
            this.showNeighborCountCheckbox.UseVisualStyleBackColor = true;
            // 
            // showHudLabel
            // 
            this.showHudLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showHudLabel.AutoSize = true;
            this.showHudLabel.Location = new System.Drawing.Point(6, 6);
            this.showHudLabel.Margin = new System.Windows.Forms.Padding(4);
            this.showHudLabel.Name = "showHudLabel";
            this.showHudLabel.Padding = new System.Windows.Forms.Padding(4);
            this.showHudLabel.Size = new System.Drawing.Size(234, 21);
            this.showHudLabel.TabIndex = 0;
            this.showHudLabel.Text = "Show HUD";
            // 
            // showNeighborCountLabel
            // 
            this.showNeighborCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showNeighborCountLabel.AutoSize = true;
            this.showNeighborCountLabel.Location = new System.Drawing.Point(6, 35);
            this.showNeighborCountLabel.Margin = new System.Windows.Forms.Padding(4);
            this.showNeighborCountLabel.Name = "showNeighborCountLabel";
            this.showNeighborCountLabel.Padding = new System.Windows.Forms.Padding(4);
            this.showNeighborCountLabel.Size = new System.Drawing.Size(234, 21);
            this.showNeighborCountLabel.TabIndex = 1;
            this.showNeighborCountLabel.Text = "Show Neighbor Count";
            // 
            // showGridLabel
            // 
            this.showGridLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showGridLabel.AutoSize = true;
            this.showGridLabel.Location = new System.Drawing.Point(6, 64);
            this.showGridLabel.Margin = new System.Windows.Forms.Padding(4);
            this.showGridLabel.Name = "showGridLabel";
            this.showGridLabel.Padding = new System.Windows.Forms.Padding(4);
            this.showGridLabel.Size = new System.Drawing.Size(234, 21);
            this.showGridLabel.TabIndex = 14;
            this.showGridLabel.Text = "Show Grid";
            // 
            // showHudCheckbox
            // 
            this.showHudCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showHudCheckbox.Checked = true;
            this.showHudCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showHudCheckbox.Location = new System.Drawing.Point(248, 6);
            this.showHudCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.showHudCheckbox.Name = "showHudCheckbox";
            this.showHudCheckbox.Size = new System.Drawing.Size(113, 20);
            this.showHudCheckbox.TabIndex = 16;
            this.showHudCheckbox.UseVisualStyleBackColor = true;
            // 
            // gridColorButton
            // 
            this.gridColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gridColorButton.Location = new System.Drawing.Point(248, 122);
            this.gridColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.gridColorButton.Name = "gridColorButton";
            this.gridColorButton.Size = new System.Drawing.Size(113, 20);
            this.gridColorButton.TabIndex = 25;
            this.gridColorButton.Text = "Edit";
            this.gridColorButton.UseVisualStyleBackColor = true;
            this.gridColorButton.Click += new System.EventHandler(this.gridColorButton_Click);
            // 
            // cellColorLabel
            // 
            this.cellColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cellColorLabel.AutoSize = true;
            this.cellColorLabel.Location = new System.Drawing.Point(6, 93);
            this.cellColorLabel.Margin = new System.Windows.Forms.Padding(4);
            this.cellColorLabel.Name = "cellColorLabel";
            this.cellColorLabel.Padding = new System.Windows.Forms.Padding(4);
            this.cellColorLabel.Size = new System.Drawing.Size(234, 21);
            this.cellColorLabel.TabIndex = 20;
            this.cellColorLabel.Text = "Cell Color";
            // 
            // cellColorButton
            // 
            this.cellColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cellColorButton.Location = new System.Drawing.Point(248, 93);
            this.cellColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.cellColorButton.Name = "cellColorButton";
            this.cellColorButton.Size = new System.Drawing.Size(113, 20);
            this.cellColorButton.TabIndex = 26;
            this.cellColorButton.Text = "Edit";
            this.cellColorButton.UseVisualStyleBackColor = true;
            this.cellColorButton.Click += new System.EventHandler(this.cellColorButton_Click);
            // 
            // gridColorLabel
            // 
            this.gridColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gridColorLabel.AutoSize = true;
            this.gridColorLabel.Location = new System.Drawing.Point(6, 122);
            this.gridColorLabel.Margin = new System.Windows.Forms.Padding(4);
            this.gridColorLabel.Name = "gridColorLabel";
            this.gridColorLabel.Padding = new System.Windows.Forms.Padding(4);
            this.gridColorLabel.Size = new System.Drawing.Size(234, 21);
            this.gridColorLabel.TabIndex = 19;
            this.gridColorLabel.Text = "Grid Color";
            // 
            // backgroundColorLabel
            // 
            this.backgroundColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundColorLabel.AutoSize = true;
            this.backgroundColorLabel.Location = new System.Drawing.Point(6, 151);
            this.backgroundColorLabel.Margin = new System.Windows.Forms.Padding(4);
            this.backgroundColorLabel.Name = "backgroundColorLabel";
            this.backgroundColorLabel.Padding = new System.Windows.Forms.Padding(4);
            this.backgroundColorLabel.Size = new System.Drawing.Size(234, 21);
            this.backgroundColorLabel.TabIndex = 27;
            this.backgroundColorLabel.Text = "Background Color";
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 1;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.ContextMenuStrip = this.contextMenu;
            this.tableLayout.Controls.Add(this.dialogTableLayout, 0, 1);
            this.tableLayout.Controls.Add(this.tabControl, 0, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.Size = new System.Drawing.Size(512, 258);
            this.tableLayout.TabIndex = 5;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuResetMenuItem,
            this.contextMenuReloadMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(111, 48);
            // 
            // contextMenuResetMenuItem
            // 
            this.contextMenuResetMenuItem.Name = "contextMenuResetMenuItem";
            this.contextMenuResetMenuItem.Size = new System.Drawing.Size(110, 22);
            this.contextMenuResetMenuItem.Text = "Reset";
            this.contextMenuResetMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // contextMenuReloadMenuItem
            // 
            this.contextMenuReloadMenuItem.Name = "contextMenuReloadMenuItem";
            this.contextMenuReloadMenuItem.Size = new System.Drawing.Size(110, 22);
            this.contextMenuReloadMenuItem.Text = "Reload";
            this.contextMenuReloadMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // dialogTableLayout
            // 
            this.dialogTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dialogTableLayout.AutoSize = true;
            this.dialogTableLayout.ColumnCount = 2;
            this.dialogTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dialogTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dialogTableLayout.Controls.Add(this.dialogCancelButton, 1, 0);
            this.dialogTableLayout.Controls.Add(this.dialogConfirmButton, 0, 0);
            this.dialogTableLayout.Location = new System.Drawing.Point(343, 222);
            this.dialogTableLayout.Name = "dialogTableLayout";
            this.dialogTableLayout.RowCount = 1;
            this.dialogTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dialogTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.dialogTableLayout.Size = new System.Drawing.Size(162, 29);
            this.dialogTableLayout.TabIndex = 6;
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.dialogConfirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.dialogCancelButton;
            this.ClientSize = new System.Drawing.Size(512, 258);
            this.Controls.Add(this.tableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.tabControl.ResumeLayout(false);
            this.generalTab.ResumeLayout(false);
            this.generalTableLayout.ResumeLayout(false);
            this.generalTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).EndInit();
            this.scaleTableLayout.ResumeLayout(false);
            this.scaleTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleYNumericUpDown)).EndInit();
            this.rulesTab.ResumeLayout(false);
            this.rulesTableLayout.ResumeLayout(false);
            this.rulesTableLayout.PerformLayout();
            this.neighborRangeTableLayout.ResumeLayout(false);
            this.neighborRangeTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neighborLiveMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neighborLiveMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neighborRadiusNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellBirthThresholdNumericUpDown)).EndInit();
            this.generationTab.ResumeLayout(false);
            this.generationTableLayout.ResumeLayout(false);
            this.generationTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randomSeedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomThresholdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomMultiplierNumericUpDown)).EndInit();
            this.displayTab.ResumeLayout(false);
            this.displayTableLayout.ResumeLayout(false);
            this.displayTableLayout.PerformLayout();
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.dialogTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eBorderModeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dialogCancelButton;
        private System.Windows.Forms.Button dialogConfirmButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage generalTab;
        private System.Windows.Forms.TableLayoutPanel generalTableLayout;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.TabPage rulesTab;
        private System.Windows.Forms.TabPage generationTab;
        private System.Windows.Forms.TabPage displayTab;
        private System.Windows.Forms.TableLayoutPanel scaleTableLayout;
        private System.Windows.Forms.NumericUpDown intervalNumericUpDown;
        private System.Windows.Forms.BindingSource eBorderModeBindingSource;
        private System.Windows.Forms.TableLayoutPanel rulesTableLayout;
        private System.Windows.Forms.Label neighborRadiusLabel;
        private System.Windows.Forms.Label neighborLiveLabel;
        private System.Windows.Forms.TableLayoutPanel neighborRangeTableLayout;
        private System.Windows.Forms.NumericUpDown neighborLiveMinNumericUpDown;
        private System.Windows.Forms.Label neighborLiveSeparatorLabel;
        private System.Windows.Forms.NumericUpDown neighborLiveMaxNumericUpDown;
        private System.Windows.Forms.NumericUpDown neighborRadiusNumericUpDown;
        private System.Windows.Forms.Label celBirthThresholdLabel;
        private System.Windows.Forms.NumericUpDown cellBirthThresholdNumericUpDown;
        private System.Windows.Forms.TableLayoutPanel generationTableLayout;
        private System.Windows.Forms.Label randomThresholdLabel;
        private System.Windows.Forms.ComboBox randomModeComboBox;
        private System.Windows.Forms.Label randomModeLabel;
        private System.Windows.Forms.Label randomSeedLabel;
        private System.Windows.Forms.Label randomMultiplierLabel;
        private System.Windows.Forms.NumericUpDown randomThresholdNumericUpDown;
        private System.Windows.Forms.NumericUpDown randomMultiplierNumericUpDown;
        private System.Windows.Forms.TableLayoutPanel displayTableLayout;
        private System.Windows.Forms.Label gridColorLabel;
        private System.Windows.Forms.Label showHudLabel;
        private System.Windows.Forms.Label showNeighborCountLabel;
        private System.Windows.Forms.Label showGridLabel;
        private System.Windows.Forms.Label cellColorLabel;
        private System.Windows.Forms.Button cellColorButton;
        private System.Windows.Forms.Button gridColorButton;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.TableLayoutPanel dialogTableLayout;
        private System.Windows.Forms.Label backgroundColorLabel;
        private System.Windows.Forms.Button backgroundColorButton;
        private System.Windows.Forms.Button randomizeButton;
        private System.Windows.Forms.NumericUpDown randomSeedNumericUpDown;
        private System.Windows.Forms.Label borderModeLabel;
        private System.Windows.Forms.NumericUpDown scaleXNumericUpDown;
        private System.Windows.Forms.Label scaleSeparatorLabel;
        private System.Windows.Forms.NumericUpDown scaleYNumericUpDown;
        private System.Windows.Forms.ComboBox borderModeComboBox;
        private System.Windows.Forms.Button randomSeedNewSeedButton;
        private System.Windows.Forms.CheckBox showGridCheckbox;
        private System.Windows.Forms.CheckBox showNeighborCountCheckbox;
        private System.Windows.Forms.CheckBox showHudCheckbox;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextMenuResetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextMenuReloadMenuItem;
    }
}