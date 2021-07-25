
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
            this.scaleNameLabel = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.borderNameLabel = new System.Windows.Forms.Label();
            this.scaleTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.scaleXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.scaleSeparatorLabel = new System.Windows.Forms.Label();
            this.scaleYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.borderComboBox = new System.Windows.Forms.ComboBox();
            this.rulesTab = new System.Windows.Forms.TabPage();
            this.rulesTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.neighborRadiusNameLabel = new System.Windows.Forms.Label();
            this.neighborLiveRangeNameLabel = new System.Windows.Forms.Label();
            this.neighborRangeTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.neighborLiveMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.neighborLiveSeparatorLabel = new System.Windows.Forms.Label();
            this.neighborLiveMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.neighborRadiusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.celBirthThresholdNameLabel = new System.Windows.Forms.Label();
            this.cellBirthThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.generationTab = new System.Windows.Forms.TabPage();
            this.generationTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.randomThresholdNameLabel = new System.Windows.Forms.Label();
            this.randomSeedTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.randomSeedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.randomSeedNewSeedButton = new System.Windows.Forms.Button();
            this.randomModeNameLabel = new System.Windows.Forms.Label();
            this.randomSeedNameLabel = new System.Windows.Forms.Label();
            this.randomMultiplierNameLabel = new System.Windows.Forms.Label();
            this.randomModeComboBox = new System.Windows.Forms.ComboBox();
            this.randomThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.randomMultiplierNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.randomizeButton = new System.Windows.Forms.Button();
            this.displayTab = new System.Windows.Forms.TabPage();
            this.displayTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.showGridCheckbox = new System.Windows.Forms.CheckBox();
            this.showNeighborCountCheckbox = new System.Windows.Forms.CheckBox();
            this.gridColorNameLabel = new System.Windows.Forms.Label();
            this.showHudNameLabel = new System.Windows.Forms.Label();
            this.showNeighborCountNameLabel = new System.Windows.Forms.Label();
            this.showGridNameLabel = new System.Windows.Forms.Label();
            this.showHudCheckbox = new System.Windows.Forms.CheckBox();
            this.gridColorButton = new System.Windows.Forms.Button();
            this.cellColorNameLabel = new System.Windows.Forms.Label();
            this.cellColorButton = new System.Windows.Forms.Button();
            this.eBorderModeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cellColorDialog = new System.Windows.Forms.ColorDialog();
            this.gridColorDialog = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dialogTableLayout = new System.Windows.Forms.TableLayoutPanel();
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
            this.randomSeedTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randomSeedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomThresholdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomMultiplierNumericUpDown)).BeginInit();
            this.displayTab.SuspendLayout();
            this.displayTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBorderModeBindingSource)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.dialogTableLayout.SuspendLayout();
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
            this.tabControl.Size = new System.Drawing.Size(448, 180);
            this.tabControl.TabIndex = 2;
            // 
            // generalTab
            // 
            this.generalTab.Controls.Add(this.generalTableLayout);
            this.generalTab.Location = new System.Drawing.Point(4, 22);
            this.generalTab.Margin = new System.Windows.Forms.Padding(0);
            this.generalTab.Name = "generalTab";
            this.generalTab.Size = new System.Drawing.Size(440, 154);
            this.generalTab.TabIndex = 0;
            this.generalTab.Text = "General";
            this.generalTab.UseVisualStyleBackColor = true;
            // 
            // generalTableLayout
            // 
            this.generalTableLayout.ColumnCount = 2;
            this.generalTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalTableLayout.Controls.Add(this.intervalNumericUpDown, 1, 1);
            this.generalTableLayout.Controls.Add(this.scaleNameLabel, 0, 0);
            this.generalTableLayout.Controls.Add(this.intervalLabel, 0, 1);
            this.generalTableLayout.Controls.Add(this.borderNameLabel, 0, 2);
            this.generalTableLayout.Controls.Add(this.scaleTableLayout, 1, 0);
            this.generalTableLayout.Controls.Add(this.borderComboBox, 1, 2);
            this.generalTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalTableLayout.Location = new System.Drawing.Point(0, 0);
            this.generalTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.generalTableLayout.Name = "generalTableLayout";
            this.generalTableLayout.Padding = new System.Windows.Forms.Padding(2);
            this.generalTableLayout.RowCount = 4;
            this.generalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generalTableLayout.Size = new System.Drawing.Size(440, 154);
            this.generalTableLayout.TabIndex = 3;
            // 
            // intervalNumericUpDown
            // 
            this.intervalNumericUpDown.AutoSize = true;
            this.intervalNumericUpDown.Location = new System.Drawing.Point(220, 35);
            this.intervalNumericUpDown.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
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
            this.intervalNumericUpDown.Size = new System.Drawing.Size(41, 20);
            this.intervalNumericUpDown.TabIndex = 10;
            this.intervalNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // scaleNameLabel
            // 
            this.scaleNameLabel.AutoSize = true;
            this.scaleNameLabel.Location = new System.Drawing.Point(2, 2);
            this.scaleNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.scaleNameLabel.Name = "scaleNameLabel";
            this.scaleNameLabel.Padding = new System.Windows.Forms.Padding(8);
            this.scaleNameLabel.Size = new System.Drawing.Size(50, 29);
            this.scaleNameLabel.TabIndex = 0;
            this.scaleNameLabel.Text = "Scale";
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(2, 31);
            this.intervalLabel.Margin = new System.Windows.Forms.Padding(0);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Padding = new System.Windows.Forms.Padding(8);
            this.intervalLabel.Size = new System.Drawing.Size(58, 29);
            this.intervalLabel.TabIndex = 1;
            this.intervalLabel.Text = "Interval";
            // 
            // borderNameLabel
            // 
            this.borderNameLabel.AutoSize = true;
            this.borderNameLabel.Location = new System.Drawing.Point(2, 60);
            this.borderNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.borderNameLabel.Name = "borderNameLabel";
            this.borderNameLabel.Padding = new System.Windows.Forms.Padding(8);
            this.borderNameLabel.Size = new System.Drawing.Size(54, 29);
            this.borderNameLabel.TabIndex = 2;
            this.borderNameLabel.Text = "Border";
            // 
            // scaleTableLayout
            // 
            this.scaleTableLayout.AutoSize = true;
            this.scaleTableLayout.ColumnCount = 4;
            this.scaleTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.scaleTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.scaleTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.scaleTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.scaleTableLayout.Controls.Add(this.scaleXNumericUpDown, 0, 0);
            this.scaleTableLayout.Controls.Add(this.scaleSeparatorLabel, 2, 0);
            this.scaleTableLayout.Controls.Add(this.scaleYNumericUpDown, 3, 0);
            this.scaleTableLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.scaleTableLayout.Location = new System.Drawing.Point(220, 2);
            this.scaleTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.scaleTableLayout.Name = "scaleTableLayout";
            this.scaleTableLayout.RowCount = 1;
            this.scaleTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.scaleTableLayout.Size = new System.Drawing.Size(102, 29);
            this.scaleTableLayout.TabIndex = 9;
            // 
            // scaleXNumericUpDown
            // 
            this.scaleXNumericUpDown.AutoSize = true;
            this.scaleXNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scaleXNumericUpDown.Location = new System.Drawing.Point(0, 4);
            this.scaleXNumericUpDown.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.scaleXNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scaleXNumericUpDown.Name = "scaleXNumericUpDown";
            this.scaleXNumericUpDown.Size = new System.Drawing.Size(41, 20);
            this.scaleXNumericUpDown.TabIndex = 9;
            this.scaleXNumericUpDown.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // scaleSeparatorLabel
            // 
            this.scaleSeparatorLabel.AutoSize = true;
            this.scaleSeparatorLabel.Location = new System.Drawing.Point(41, 3);
            this.scaleSeparatorLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.scaleSeparatorLabel.Name = "scaleSeparatorLabel";
            this.scaleSeparatorLabel.Padding = new System.Windows.Forms.Padding(4);
            this.scaleSeparatorLabel.Size = new System.Drawing.Size(20, 21);
            this.scaleSeparatorLabel.TabIndex = 8;
            this.scaleSeparatorLabel.Text = "x";
            // 
            // scaleYNumericUpDown
            // 
            this.scaleYNumericUpDown.AutoSize = true;
            this.scaleYNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scaleYNumericUpDown.Location = new System.Drawing.Point(61, 4);
            this.scaleYNumericUpDown.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.scaleYNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scaleYNumericUpDown.Name = "scaleYNumericUpDown";
            this.scaleYNumericUpDown.Size = new System.Drawing.Size(41, 20);
            this.scaleYNumericUpDown.TabIndex = 10;
            this.scaleYNumericUpDown.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // borderComboBox
            // 
            this.borderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.borderComboBox.FormattingEnabled = true;
            this.borderComboBox.Items.AddRange(new object[] {
            "Clip",
            "Wrap"});
            this.borderComboBox.Location = new System.Drawing.Point(220, 64);
            this.borderComboBox.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.borderComboBox.Name = "borderComboBox";
            this.borderComboBox.Size = new System.Drawing.Size(121, 21);
            this.borderComboBox.TabIndex = 11;
            // 
            // rulesTab
            // 
            this.rulesTab.Controls.Add(this.rulesTableLayout);
            this.rulesTab.Location = new System.Drawing.Point(4, 22);
            this.rulesTab.Margin = new System.Windows.Forms.Padding(0);
            this.rulesTab.Name = "rulesTab";
            this.rulesTab.Size = new System.Drawing.Size(440, 154);
            this.rulesTab.TabIndex = 1;
            this.rulesTab.Text = "Rules";
            this.rulesTab.UseVisualStyleBackColor = true;
            // 
            // rulesTableLayout
            // 
            this.rulesTableLayout.ColumnCount = 2;
            this.rulesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rulesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rulesTableLayout.Controls.Add(this.neighborRadiusNameLabel, 0, 0);
            this.rulesTableLayout.Controls.Add(this.neighborLiveRangeNameLabel, 0, 1);
            this.rulesTableLayout.Controls.Add(this.neighborRangeTableLayout, 1, 1);
            this.rulesTableLayout.Controls.Add(this.neighborRadiusNumericUpDown, 1, 0);
            this.rulesTableLayout.Controls.Add(this.celBirthThresholdNameLabel, 0, 2);
            this.rulesTableLayout.Controls.Add(this.cellBirthThresholdNumericUpDown, 1, 2);
            this.rulesTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rulesTableLayout.Location = new System.Drawing.Point(0, 0);
            this.rulesTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.rulesTableLayout.Name = "rulesTableLayout";
            this.rulesTableLayout.Padding = new System.Windows.Forms.Padding(2);
            this.rulesTableLayout.RowCount = 4;
            this.rulesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rulesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rulesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rulesTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rulesTableLayout.Size = new System.Drawing.Size(440, 154);
            this.rulesTableLayout.TabIndex = 5;
            // 
            // neighborRadiusNameLabel
            // 
            this.neighborRadiusNameLabel.AutoSize = true;
            this.neighborRadiusNameLabel.Location = new System.Drawing.Point(2, 2);
            this.neighborRadiusNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.neighborRadiusNameLabel.Name = "neighborRadiusNameLabel";
            this.neighborRadiusNameLabel.Padding = new System.Windows.Forms.Padding(8);
            this.neighborRadiusNameLabel.Size = new System.Drawing.Size(102, 29);
            this.neighborRadiusNameLabel.TabIndex = 0;
            this.neighborRadiusNameLabel.Text = "Neighbor Radius";
            // 
            // neighborLiveRangeNameLabel
            // 
            this.neighborLiveRangeNameLabel.AutoSize = true;
            this.neighborLiveRangeNameLabel.Location = new System.Drawing.Point(2, 31);
            this.neighborLiveRangeNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.neighborLiveRangeNameLabel.Name = "neighborLiveRangeNameLabel";
            this.neighborLiveRangeNameLabel.Padding = new System.Windows.Forms.Padding(8);
            this.neighborLiveRangeNameLabel.Size = new System.Drawing.Size(124, 29);
            this.neighborLiveRangeNameLabel.TabIndex = 1;
            this.neighborLiveRangeNameLabel.Text = "Neighbor Live Range";
            // 
            // neighborRangeTableLayout
            // 
            this.neighborRangeTableLayout.AutoSize = true;
            this.neighborRangeTableLayout.ColumnCount = 4;
            this.neighborRangeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.neighborRangeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.neighborRangeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.neighborRangeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.neighborRangeTableLayout.Controls.Add(this.neighborLiveMinNumericUpDown, 0, 0);
            this.neighborRangeTableLayout.Controls.Add(this.neighborLiveSeparatorLabel, 2, 0);
            this.neighborRangeTableLayout.Controls.Add(this.neighborLiveMaxNumericUpDown, 3, 0);
            this.neighborRangeTableLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.neighborRangeTableLayout.Location = new System.Drawing.Point(220, 31);
            this.neighborRangeTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.neighborRangeTableLayout.Name = "neighborRangeTableLayout";
            this.neighborRangeTableLayout.RowCount = 1;
            this.neighborRangeTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.neighborRangeTableLayout.Size = new System.Drawing.Size(100, 29);
            this.neighborRangeTableLayout.TabIndex = 9;
            // 
            // neighborLiveMinNumericUpDown
            // 
            this.neighborLiveMinNumericUpDown.AutoSize = true;
            this.neighborLiveMinNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.neighborLiveMinNumericUpDown.Location = new System.Drawing.Point(0, 4);
            this.neighborLiveMinNumericUpDown.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.neighborLiveMinNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.neighborLiveMinNumericUpDown.Name = "neighborLiveMinNumericUpDown";
            this.neighborLiveMinNumericUpDown.Size = new System.Drawing.Size(41, 20);
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
            this.neighborLiveSeparatorLabel.Location = new System.Drawing.Point(41, 3);
            this.neighborLiveSeparatorLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.neighborLiveSeparatorLabel.Name = "neighborLiveSeparatorLabel";
            this.neighborLiveSeparatorLabel.Padding = new System.Windows.Forms.Padding(4);
            this.neighborLiveSeparatorLabel.Size = new System.Drawing.Size(18, 21);
            this.neighborLiveSeparatorLabel.TabIndex = 8;
            this.neighborLiveSeparatorLabel.Text = "-";
            // 
            // neighborLiveMaxNumericUpDown
            // 
            this.neighborLiveMaxNumericUpDown.AutoSize = true;
            this.neighborLiveMaxNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.neighborLiveMaxNumericUpDown.Location = new System.Drawing.Point(59, 4);
            this.neighborLiveMaxNumericUpDown.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.neighborLiveMaxNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.neighborLiveMaxNumericUpDown.Name = "neighborLiveMaxNumericUpDown";
            this.neighborLiveMaxNumericUpDown.Size = new System.Drawing.Size(41, 20);
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
            this.neighborRadiusNumericUpDown.AutoSize = true;
            this.neighborRadiusNumericUpDown.Location = new System.Drawing.Point(220, 6);
            this.neighborRadiusNumericUpDown.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
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
            this.neighborRadiusNumericUpDown.Size = new System.Drawing.Size(41, 20);
            this.neighborRadiusNumericUpDown.TabIndex = 12;
            this.neighborRadiusNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.neighborRadiusNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // celBirthThresholdNameLabel
            // 
            this.celBirthThresholdNameLabel.AutoSize = true;
            this.celBirthThresholdNameLabel.Location = new System.Drawing.Point(2, 60);
            this.celBirthThresholdNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.celBirthThresholdNameLabel.Name = "celBirthThresholdNameLabel";
            this.celBirthThresholdNameLabel.Padding = new System.Windows.Forms.Padding(8);
            this.celBirthThresholdNameLabel.Size = new System.Drawing.Size(114, 29);
            this.celBirthThresholdNameLabel.TabIndex = 14;
            this.celBirthThresholdNameLabel.Text = "Cell Birth Threshold";
            // 
            // cellBirthThresholdNumericUpDown
            // 
            this.cellBirthThresholdNumericUpDown.AutoSize = true;
            this.cellBirthThresholdNumericUpDown.Location = new System.Drawing.Point(220, 64);
            this.cellBirthThresholdNumericUpDown.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
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
            this.cellBirthThresholdNumericUpDown.Size = new System.Drawing.Size(41, 20);
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
            this.generationTab.Size = new System.Drawing.Size(440, 154);
            this.generationTab.TabIndex = 2;
            this.generationTab.Text = "Generation";
            this.generationTab.UseVisualStyleBackColor = true;
            // 
            // generationTableLayout
            // 
            this.generationTableLayout.ColumnCount = 2;
            this.generationTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generationTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generationTableLayout.Controls.Add(this.randomThresholdNameLabel, 0, 2);
            this.generationTableLayout.Controls.Add(this.randomSeedTableLayout, 1, 1);
            this.generationTableLayout.Controls.Add(this.randomModeNameLabel, 0, 0);
            this.generationTableLayout.Controls.Add(this.randomSeedNameLabel, 0, 1);
            this.generationTableLayout.Controls.Add(this.randomMultiplierNameLabel, 0, 3);
            this.generationTableLayout.Controls.Add(this.randomModeComboBox, 1, 0);
            this.generationTableLayout.Controls.Add(this.randomThresholdNumericUpDown, 1, 2);
            this.generationTableLayout.Controls.Add(this.randomMultiplierNumericUpDown, 1, 3);
            this.generationTableLayout.Controls.Add(this.randomizeButton, 1, 5);
            this.generationTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generationTableLayout.Location = new System.Drawing.Point(0, 0);
            this.generationTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.generationTableLayout.Name = "generationTableLayout";
            this.generationTableLayout.Padding = new System.Windows.Forms.Padding(2);
            this.generationTableLayout.RowCount = 6;
            this.generationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generationTableLayout.Size = new System.Drawing.Size(440, 154);
            this.generationTableLayout.TabIndex = 6;
            // 
            // randomThresholdNameLabel
            // 
            this.randomThresholdNameLabel.AutoSize = true;
            this.randomThresholdNameLabel.Location = new System.Drawing.Point(2, 60);
            this.randomThresholdNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.randomThresholdNameLabel.Name = "randomThresholdNameLabel";
            this.randomThresholdNameLabel.Padding = new System.Windows.Forms.Padding(8);
            this.randomThresholdNameLabel.Size = new System.Drawing.Size(113, 29);
            this.randomThresholdNameLabel.TabIndex = 19;
            this.randomThresholdNameLabel.Text = "Random Threshold";
            // 
            // randomSeedTableLayout
            // 
            this.randomSeedTableLayout.AutoSize = true;
            this.randomSeedTableLayout.ColumnCount = 2;
            this.randomSeedTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.randomSeedTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.randomSeedTableLayout.Controls.Add(this.randomSeedNumericUpDown, 0, 0);
            this.randomSeedTableLayout.Controls.Add(this.randomSeedNewSeedButton, 1, 0);
            this.randomSeedTableLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.randomSeedTableLayout.Location = new System.Drawing.Point(220, 31);
            this.randomSeedTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.randomSeedTableLayout.Name = "randomSeedTableLayout";
            this.randomSeedTableLayout.RowCount = 1;
            this.randomSeedTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.randomSeedTableLayout.Size = new System.Drawing.Size(140, 29);
            this.randomSeedTableLayout.TabIndex = 18;
            // 
            // randomSeedNumericUpDown
            // 
            this.randomSeedNumericUpDown.AutoSize = true;
            this.randomSeedNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.randomSeedNumericUpDown.Location = new System.Drawing.Point(0, 4);
            this.randomSeedNumericUpDown.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
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
            this.randomSeedNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.randomSeedNumericUpDown.TabIndex = 9;
            this.randomSeedNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.randomSeedNumericUpDown.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // randomSeedNewSeedButton
            // 
            this.randomSeedNewSeedButton.Location = new System.Drawing.Point(62, 3);
            this.randomSeedNewSeedButton.Name = "randomSeedNewSeedButton";
            this.randomSeedNewSeedButton.Size = new System.Drawing.Size(75, 23);
            this.randomSeedNewSeedButton.TabIndex = 10;
            this.randomSeedNewSeedButton.Text = "New Seed";
            this.randomSeedNewSeedButton.UseVisualStyleBackColor = true;
            this.randomSeedNewSeedButton.Click += new System.EventHandler(this.randomSeedNewSeedButton_Click);
            // 
            // randomModeNameLabel
            // 
            this.randomModeNameLabel.AutoSize = true;
            this.randomModeNameLabel.Location = new System.Drawing.Point(2, 2);
            this.randomModeNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.randomModeNameLabel.Name = "randomModeNameLabel";
            this.randomModeNameLabel.Padding = new System.Windows.Forms.Padding(8);
            this.randomModeNameLabel.Size = new System.Drawing.Size(93, 29);
            this.randomModeNameLabel.TabIndex = 1;
            this.randomModeNameLabel.Text = "Random Mode";
            // 
            // randomSeedNameLabel
            // 
            this.randomSeedNameLabel.AutoSize = true;
            this.randomSeedNameLabel.Location = new System.Drawing.Point(2, 31);
            this.randomSeedNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.randomSeedNameLabel.Name = "randomSeedNameLabel";
            this.randomSeedNameLabel.Padding = new System.Windows.Forms.Padding(8);
            this.randomSeedNameLabel.Size = new System.Drawing.Size(91, 29);
            this.randomSeedNameLabel.TabIndex = 14;
            this.randomSeedNameLabel.Text = "Random Seed";
            // 
            // randomMultiplierNameLabel
            // 
            this.randomMultiplierNameLabel.AutoSize = true;
            this.randomMultiplierNameLabel.Location = new System.Drawing.Point(2, 89);
            this.randomMultiplierNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.randomMultiplierNameLabel.Name = "randomMultiplierNameLabel";
            this.randomMultiplierNameLabel.Padding = new System.Windows.Forms.Padding(8);
            this.randomMultiplierNameLabel.Size = new System.Drawing.Size(107, 29);
            this.randomMultiplierNameLabel.TabIndex = 20;
            this.randomMultiplierNameLabel.Text = "Random Multiplier";
            // 
            // randomModeComboBox
            // 
            this.randomModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.randomModeComboBox.FormattingEnabled = true;
            this.randomModeComboBox.Items.AddRange(new object[] {
            "Clip",
            "Wrap"});
            this.randomModeComboBox.Location = new System.Drawing.Point(220, 6);
            this.randomModeComboBox.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.randomModeComboBox.Name = "randomModeComboBox";
            this.randomModeComboBox.Size = new System.Drawing.Size(121, 21);
            this.randomModeComboBox.TabIndex = 17;
            // 
            // randomThresholdNumericUpDown
            // 
            this.randomThresholdNumericUpDown.AutoSize = true;
            this.randomThresholdNumericUpDown.DecimalPlaces = 2;
            this.randomThresholdNumericUpDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.randomThresholdNumericUpDown.Location = new System.Drawing.Point(220, 64);
            this.randomThresholdNumericUpDown.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.randomThresholdNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.randomThresholdNumericUpDown.Name = "randomThresholdNumericUpDown";
            this.randomThresholdNumericUpDown.Size = new System.Drawing.Size(56, 20);
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
            this.randomMultiplierNumericUpDown.AutoSize = true;
            this.randomMultiplierNumericUpDown.DecimalPlaces = 2;
            this.randomMultiplierNumericUpDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.randomMultiplierNumericUpDown.Location = new System.Drawing.Point(220, 93);
            this.randomMultiplierNumericUpDown.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.randomMultiplierNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.randomMultiplierNumericUpDown.Name = "randomMultiplierNumericUpDown";
            this.randomMultiplierNumericUpDown.Size = new System.Drawing.Size(56, 20);
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
            this.randomizeButton.AutoSize = true;
            this.randomizeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.randomizeButton.Location = new System.Drawing.Point(220, 122);
            this.randomizeButton.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(75, 26);
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
            this.displayTab.Size = new System.Drawing.Size(440, 154);
            this.displayTab.TabIndex = 3;
            this.displayTab.Text = "Display";
            this.displayTab.UseVisualStyleBackColor = true;
            // 
            // displayTableLayout
            // 
            this.displayTableLayout.ColumnCount = 2;
            this.displayTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.displayTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.displayTableLayout.Controls.Add(this.showGridCheckbox, 1, 2);
            this.displayTableLayout.Controls.Add(this.showNeighborCountCheckbox, 1, 1);
            this.displayTableLayout.Controls.Add(this.gridColorNameLabel, 0, 4);
            this.displayTableLayout.Controls.Add(this.showHudNameLabel, 0, 0);
            this.displayTableLayout.Controls.Add(this.showNeighborCountNameLabel, 0, 1);
            this.displayTableLayout.Controls.Add(this.showGridNameLabel, 0, 2);
            this.displayTableLayout.Controls.Add(this.showHudCheckbox, 1, 0);
            this.displayTableLayout.Controls.Add(this.gridColorButton, 1, 4);
            this.displayTableLayout.Controls.Add(this.cellColorNameLabel, 0, 3);
            this.displayTableLayout.Controls.Add(this.cellColorButton, 1, 3);
            this.displayTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayTableLayout.Location = new System.Drawing.Point(0, 0);
            this.displayTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.displayTableLayout.Name = "displayTableLayout";
            this.displayTableLayout.Padding = new System.Windows.Forms.Padding(2);
            this.displayTableLayout.RowCount = 6;
            this.displayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.displayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.displayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.displayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.displayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.displayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.displayTableLayout.Size = new System.Drawing.Size(440, 154);
            this.displayTableLayout.TabIndex = 7;
            // 
            // showGridCheckbox
            // 
            this.showGridCheckbox.AutoSize = true;
            this.showGridCheckbox.Checked = true;
            this.showGridCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showGridCheckbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.showGridCheckbox.Location = new System.Drawing.Point(220, 64);
            this.showGridCheckbox.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.showGridCheckbox.Name = "showGridCheckbox";
            this.showGridCheckbox.Size = new System.Drawing.Size(15, 21);
            this.showGridCheckbox.TabIndex = 24;
            this.showGridCheckbox.UseVisualStyleBackColor = true;
            // 
            // showNeighborCountCheckbox
            // 
            this.showNeighborCountCheckbox.AutoSize = true;
            this.showNeighborCountCheckbox.Checked = true;
            this.showNeighborCountCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showNeighborCountCheckbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.showNeighborCountCheckbox.Location = new System.Drawing.Point(220, 35);
            this.showNeighborCountCheckbox.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.showNeighborCountCheckbox.Name = "showNeighborCountCheckbox";
            this.showNeighborCountCheckbox.Size = new System.Drawing.Size(15, 21);
            this.showNeighborCountCheckbox.TabIndex = 23;
            this.showNeighborCountCheckbox.UseVisualStyleBackColor = true;
            // 
            // gridColorNameLabel
            // 
            this.gridColorNameLabel.AutoSize = true;
            this.gridColorNameLabel.Location = new System.Drawing.Point(2, 118);
            this.gridColorNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.gridColorNameLabel.Name = "gridColorNameLabel";
            this.gridColorNameLabel.Padding = new System.Windows.Forms.Padding(8);
            this.gridColorNameLabel.Size = new System.Drawing.Size(69, 29);
            this.gridColorNameLabel.TabIndex = 19;
            this.gridColorNameLabel.Text = "Grid Color";
            // 
            // showHudNameLabel
            // 
            this.showHudNameLabel.AutoSize = true;
            this.showHudNameLabel.Location = new System.Drawing.Point(2, 2);
            this.showHudNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.showHudNameLabel.Name = "showHudNameLabel";
            this.showHudNameLabel.Padding = new System.Windows.Forms.Padding(8);
            this.showHudNameLabel.Size = new System.Drawing.Size(77, 29);
            this.showHudNameLabel.TabIndex = 0;
            this.showHudNameLabel.Text = "Show HUD";
            // 
            // showNeighborCountNameLabel
            // 
            this.showNeighborCountNameLabel.AutoSize = true;
            this.showNeighborCountNameLabel.Location = new System.Drawing.Point(2, 31);
            this.showNeighborCountNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.showNeighborCountNameLabel.Name = "showNeighborCountNameLabel";
            this.showNeighborCountNameLabel.Padding = new System.Windows.Forms.Padding(8);
            this.showNeighborCountNameLabel.Size = new System.Drawing.Size(127, 29);
            this.showNeighborCountNameLabel.TabIndex = 1;
            this.showNeighborCountNameLabel.Text = "Show Neighbor Count";
            // 
            // showGridNameLabel
            // 
            this.showGridNameLabel.AutoSize = true;
            this.showGridNameLabel.Location = new System.Drawing.Point(2, 60);
            this.showGridNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.showGridNameLabel.Name = "showGridNameLabel";
            this.showGridNameLabel.Padding = new System.Windows.Forms.Padding(8);
            this.showGridNameLabel.Size = new System.Drawing.Size(72, 29);
            this.showGridNameLabel.TabIndex = 14;
            this.showGridNameLabel.Text = "Show Grid";
            // 
            // showHudCheckbox
            // 
            this.showHudCheckbox.AutoSize = true;
            this.showHudCheckbox.Checked = true;
            this.showHudCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showHudCheckbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.showHudCheckbox.Location = new System.Drawing.Point(220, 6);
            this.showHudCheckbox.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.showHudCheckbox.Name = "showHudCheckbox";
            this.showHudCheckbox.Size = new System.Drawing.Size(15, 21);
            this.showHudCheckbox.TabIndex = 16;
            this.showHudCheckbox.UseVisualStyleBackColor = true;
            // 
            // gridColorButton
            // 
            this.gridColorButton.Location = new System.Drawing.Point(223, 121);
            this.gridColorButton.Name = "gridColorButton";
            this.gridColorButton.Size = new System.Drawing.Size(75, 23);
            this.gridColorButton.TabIndex = 25;
            this.gridColorButton.Text = "Edit";
            this.gridColorButton.UseVisualStyleBackColor = true;
            // 
            // cellColorNameLabel
            // 
            this.cellColorNameLabel.AutoSize = true;
            this.cellColorNameLabel.Location = new System.Drawing.Point(2, 89);
            this.cellColorNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.cellColorNameLabel.Name = "cellColorNameLabel";
            this.cellColorNameLabel.Padding = new System.Windows.Forms.Padding(8);
            this.cellColorNameLabel.Size = new System.Drawing.Size(67, 29);
            this.cellColorNameLabel.TabIndex = 20;
            this.cellColorNameLabel.Text = "Cell Color";
            // 
            // cellColorButton
            // 
            this.cellColorButton.Location = new System.Drawing.Point(223, 92);
            this.cellColorButton.Name = "cellColorButton";
            this.cellColorButton.Size = new System.Drawing.Size(75, 23);
            this.cellColorButton.TabIndex = 26;
            this.cellColorButton.Text = "Edit";
            this.cellColorButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.dialogTableLayout, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.tabControl, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(464, 231);
            this.tableLayoutPanel.TabIndex = 5;
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
            this.dialogTableLayout.Location = new System.Drawing.Point(295, 195);
            this.dialogTableLayout.Name = "dialogTableLayout";
            this.dialogTableLayout.RowCount = 1;
            this.dialogTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dialogTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dialogTableLayout.Size = new System.Drawing.Size(162, 29);
            this.dialogTableLayout.TabIndex = 6;
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.dialogConfirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.dialogCancelButton;
            this.ClientSize = new System.Drawing.Size(464, 231);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
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
            this.randomSeedTableLayout.ResumeLayout(false);
            this.randomSeedTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randomSeedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomThresholdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomMultiplierNumericUpDown)).EndInit();
            this.displayTab.ResumeLayout(false);
            this.displayTableLayout.ResumeLayout(false);
            this.displayTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBorderModeBindingSource)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.dialogTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dialogCancelButton;
        private System.Windows.Forms.Button dialogConfirmButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage generalTab;
        private System.Windows.Forms.TableLayoutPanel generalTableLayout;
        private System.Windows.Forms.Label scaleNameLabel;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.Label borderNameLabel;
        private System.Windows.Forms.TabPage rulesTab;
        private System.Windows.Forms.TabPage generationTab;
        private System.Windows.Forms.TabPage displayTab;
        private System.Windows.Forms.TableLayoutPanel scaleTableLayout;
        private System.Windows.Forms.NumericUpDown scaleXNumericUpDown;
        private System.Windows.Forms.Label scaleSeparatorLabel;
        private System.Windows.Forms.NumericUpDown scaleYNumericUpDown;
        private System.Windows.Forms.NumericUpDown intervalNumericUpDown;
        private System.Windows.Forms.ComboBox borderComboBox;
        private System.Windows.Forms.BindingSource eBorderModeBindingSource;
        private System.Windows.Forms.TableLayoutPanel rulesTableLayout;
        private System.Windows.Forms.Label neighborRadiusNameLabel;
        private System.Windows.Forms.Label neighborLiveRangeNameLabel;
        private System.Windows.Forms.TableLayoutPanel neighborRangeTableLayout;
        private System.Windows.Forms.NumericUpDown neighborLiveMinNumericUpDown;
        private System.Windows.Forms.Label neighborLiveSeparatorLabel;
        private System.Windows.Forms.NumericUpDown neighborLiveMaxNumericUpDown;
        private System.Windows.Forms.NumericUpDown neighborRadiusNumericUpDown;
        private System.Windows.Forms.Label celBirthThresholdNameLabel;
        private System.Windows.Forms.NumericUpDown cellBirthThresholdNumericUpDown;
        private System.Windows.Forms.TableLayoutPanel generationTableLayout;
        private System.Windows.Forms.Label randomThresholdNameLabel;
        private System.Windows.Forms.TableLayoutPanel randomSeedTableLayout;
        private System.Windows.Forms.NumericUpDown randomSeedNumericUpDown;
        private System.Windows.Forms.Button randomSeedNewSeedButton;
        private System.Windows.Forms.ComboBox randomModeComboBox;
        private System.Windows.Forms.Label randomModeNameLabel;
        private System.Windows.Forms.Label randomSeedNameLabel;
        private System.Windows.Forms.Label randomMultiplierNameLabel;
        private System.Windows.Forms.NumericUpDown randomThresholdNumericUpDown;
        private System.Windows.Forms.NumericUpDown randomMultiplierNumericUpDown;
        private System.Windows.Forms.TableLayoutPanel displayTableLayout;
        private System.Windows.Forms.Label gridColorNameLabel;
        private System.Windows.Forms.Label showHudNameLabel;
        private System.Windows.Forms.Label showNeighborCountNameLabel;
        private System.Windows.Forms.Label showGridNameLabel;
        private System.Windows.Forms.CheckBox showHudCheckbox;
        private System.Windows.Forms.Label cellColorNameLabel;
        private System.Windows.Forms.CheckBox showGridCheckbox;
        private System.Windows.Forms.CheckBox showNeighborCountCheckbox;
        private System.Windows.Forms.Button cellColorButton;
        private System.Windows.Forms.Button gridColorButton;
        private System.Windows.Forms.ColorDialog cellColorDialog;
        private System.Windows.Forms.ColorDialog gridColorDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel dialogTableLayout;
        private System.Windows.Forms.Button randomizeButton;
    }
}