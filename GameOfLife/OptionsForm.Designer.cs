
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.generalTab = new System.Windows.Forms.TabPage();
            this.generalTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.intervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.scaleNameLabel = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.borderNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.scaleXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.scaleSeparatorLabel = new System.Windows.Forms.Label();
            this.scaleYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.borderComboBox = new System.Windows.Forms.ComboBox();
            this.rulesTab = new System.Windows.Forms.TabPage();
            this.generationTab = new System.Windows.Forms.TabPage();
            this.displayTab = new System.Windows.Forms.TabPage();
            this.eBorderModeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rulesTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.tabControl.SuspendLayout();
            this.generalTab.SuspendLayout();
            this.generalTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleYNumericUpDown)).BeginInit();
            this.rulesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBorderModeBindingSource)).BeginInit();
            this.rulesTableLayout.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(856, 470);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmButton.Location = new System.Drawing.Point(772, 470);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.generalTab);
            this.tabControl.Controls.Add(this.rulesTab);
            this.tabControl.Controls.Add(this.generationTab);
            this.tabControl.Controls.Add(this.displayTab);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(920, 451);
            this.tabControl.TabIndex = 2;
            // 
            // generalTab
            // 
            this.generalTab.Controls.Add(this.generalTableLayout);
            this.generalTab.Location = new System.Drawing.Point(4, 22);
            this.generalTab.Margin = new System.Windows.Forms.Padding(0);
            this.generalTab.Name = "generalTab";
            this.generalTab.Size = new System.Drawing.Size(912, 425);
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
            this.generalTableLayout.Controls.Add(this.tableLayoutPanel1, 1, 0);
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
            this.generalTableLayout.Size = new System.Drawing.Size(912, 425);
            this.generalTableLayout.TabIndex = 3;
            // 
            // intervalNumericUpDown
            // 
            this.intervalNumericUpDown.AutoSize = true;
            this.intervalNumericUpDown.Location = new System.Drawing.Point(456, 35);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.scaleXNumericUpDown, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.scaleSeparatorLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.scaleYNumericUpDown, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(456, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(102, 29);
            this.tableLayoutPanel1.TabIndex = 9;
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
            this.borderComboBox.Location = new System.Drawing.Point(456, 64);
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
            this.rulesTab.Size = new System.Drawing.Size(912, 425);
            this.rulesTab.TabIndex = 1;
            this.rulesTab.Text = "Rules";
            this.rulesTab.UseVisualStyleBackColor = true;
            // 
            // generationTab
            // 
            this.generationTab.Location = new System.Drawing.Point(4, 22);
            this.generationTab.Name = "generationTab";
            this.generationTab.Size = new System.Drawing.Size(912, 425);
            this.generationTab.TabIndex = 2;
            this.generationTab.Text = "Generation";
            this.generationTab.UseVisualStyleBackColor = true;
            // 
            // displayTab
            // 
            this.displayTab.Location = new System.Drawing.Point(4, 22);
            this.displayTab.Name = "displayTab";
            this.displayTab.Size = new System.Drawing.Size(912, 425);
            this.displayTab.TabIndex = 3;
            this.displayTab.Text = "Display";
            this.displayTab.UseVisualStyleBackColor = true;
            // 
            // rulesTableLayout
            // 
            this.rulesTableLayout.ColumnCount = 2;
            this.rulesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rulesTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rulesTableLayout.Controls.Add(this.label1, 0, 0);
            this.rulesTableLayout.Controls.Add(this.label2, 0, 1);
            this.rulesTableLayout.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.rulesTableLayout.Controls.Add(this.numericUpDown1, 1, 0);
            this.rulesTableLayout.Controls.Add(this.label5, 0, 2);
            this.rulesTableLayout.Controls.Add(this.numericUpDown4, 1, 2);
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
            this.rulesTableLayout.Size = new System.Drawing.Size(912, 425);
            this.rulesTableLayout.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8);
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Neighbor Radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(8);
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Neighbor Range";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.numericUpDown2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDown3, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(456, 31);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(100, 29);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.AutoSize = true;
            this.numericUpDown2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown2.Location = new System.Drawing.Point(0, 4);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4);
            this.label4.Size = new System.Drawing.Size(18, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "-";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.AutoSize = true;
            this.numericUpDown3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown3.Location = new System.Drawing.Point(59, 4);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown3.TabIndex = 10;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = true;
            this.numericUpDown1.Location = new System.Drawing.Point(456, 6);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(8);
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Birth Threshold";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.AutoSize = true;
            this.numericUpDown4.Location = new System.Drawing.Point(456, 64);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown4.TabIndex = 15;
            this.numericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown4.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleYNumericUpDown)).EndInit();
            this.rulesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eBorderModeBindingSource)).EndInit();
            this.rulesTableLayout.ResumeLayout(false);
            this.rulesTableLayout.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage generalTab;
        private System.Windows.Forms.TableLayoutPanel generalTableLayout;
        private System.Windows.Forms.Label scaleNameLabel;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.Label borderNameLabel;
        private System.Windows.Forms.TabPage rulesTab;
        private System.Windows.Forms.TabPage generationTab;
        private System.Windows.Forms.TabPage displayTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown scaleXNumericUpDown;
        private System.Windows.Forms.Label scaleSeparatorLabel;
        private System.Windows.Forms.NumericUpDown scaleYNumericUpDown;
        private System.Windows.Forms.NumericUpDown intervalNumericUpDown;
        private System.Windows.Forms.ComboBox borderComboBox;
        private System.Windows.Forms.BindingSource eBorderModeBindingSource;
        private System.Windows.Forms.TableLayoutPanel rulesTableLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
    }
}