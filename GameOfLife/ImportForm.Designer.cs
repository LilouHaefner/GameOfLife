
namespace GameOfLife
{
    partial class ImportForm
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
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dialogCancelButton = new System.Windows.Forms.Button();
            this.dialogConfirmButton = new System.Windows.Forms.Button();
            this.dialogTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.optionsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.offsetLabel = new System.Windows.Forms.Label();
            this.offsetTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.offsetXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.offsetYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.importModeComboBox = new System.Windows.Forms.ComboBox();
            this.importModeLabel = new System.Windows.Forms.Label();
            this.offsetSeparatorLabel = new System.Windows.Forms.Label();
            this.tableLayout.SuspendLayout();
            this.dialogTableLayout.SuspendLayout();
            this.optionsTableLayout.SuspendLayout();
            this.offsetTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetYNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 1;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayout.Controls.Add(this.optionsTableLayout, 1, 0);
            this.tableLayout.Controls.Add(this.dialogTableLayout, 0, 1);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.Size = new System.Drawing.Size(332, 112);
            this.tableLayout.TabIndex = 0;
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
            this.dialogTableLayout.Location = new System.Drawing.Point(166, 79);
            this.dialogTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.dialogTableLayout.Name = "dialogTableLayout";
            this.dialogTableLayout.RowCount = 1;
            this.dialogTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dialogTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.dialogTableLayout.Size = new System.Drawing.Size(162, 29);
            this.dialogTableLayout.TabIndex = 7;
            // 
            // optionsTableLayout
            // 
            this.optionsTableLayout.AutoSize = true;
            this.optionsTableLayout.ColumnCount = 2;
            this.optionsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optionsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optionsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.optionsTableLayout.Controls.Add(this.importModeLabel, 0, 1);
            this.optionsTableLayout.Controls.Add(this.offsetTableLayout, 1, 0);
            this.optionsTableLayout.Controls.Add(this.importModeComboBox, 1, 1);
            this.optionsTableLayout.Controls.Add(this.offsetLabel, 0, 0);
            this.optionsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsTableLayout.Location = new System.Drawing.Point(4, 4);
            this.optionsTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.optionsTableLayout.Name = "optionsTableLayout";
            this.optionsTableLayout.RowCount = 3;
            this.optionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.optionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.optionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.optionsTableLayout.Size = new System.Drawing.Size(324, 75);
            this.optionsTableLayout.TabIndex = 8;
            // 
            // offsetLabel
            // 
            this.offsetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.offsetLabel.AutoSize = true;
            this.offsetLabel.Location = new System.Drawing.Point(4, 4);
            this.offsetLabel.Margin = new System.Windows.Forms.Padding(4);
            this.offsetLabel.Name = "offsetLabel";
            this.offsetLabel.Padding = new System.Windows.Forms.Padding(4);
            this.offsetLabel.Size = new System.Drawing.Size(154, 21);
            this.offsetLabel.TabIndex = 0;
            this.offsetLabel.Text = "Offset";
            this.offsetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // offsetTableLayout
            // 
            this.offsetTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.offsetTableLayout.ColumnCount = 3;
            this.offsetTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.offsetTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.offsetTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.offsetTableLayout.Controls.Add(this.offsetXNumericUpDown, 0, 0);
            this.offsetTableLayout.Controls.Add(this.offsetSeparatorLabel, 1, 0);
            this.offsetTableLayout.Controls.Add(this.offsetYNumericUpDown, 2, 0);
            this.offsetTableLayout.Location = new System.Drawing.Point(166, 4);
            this.offsetTableLayout.Margin = new System.Windows.Forms.Padding(4);
            this.offsetTableLayout.Name = "offsetTableLayout";
            this.offsetTableLayout.RowCount = 1;
            this.offsetTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.offsetTableLayout.Size = new System.Drawing.Size(154, 20);
            this.offsetTableLayout.TabIndex = 9;
            // 
            // offsetXNumericUpDown
            // 
            this.offsetXNumericUpDown.AutoSize = true;
            this.offsetXNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offsetXNumericUpDown.Location = new System.Drawing.Point(0, 0);
            this.offsetXNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.offsetXNumericUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.offsetXNumericUpDown.Name = "offsetXNumericUpDown";
            this.offsetXNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.offsetXNumericUpDown.TabIndex = 9;
            this.offsetXNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.offsetXNumericUpDown.ValueChanged += new System.EventHandler(this.offsetXNumericUpDown_ValueChanged);
            // 
            // offsetYNumericUpDown
            // 
            this.offsetYNumericUpDown.AutoSize = true;
            this.offsetYNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offsetYNumericUpDown.Location = new System.Drawing.Point(86, 0);
            this.offsetYNumericUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.offsetYNumericUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.offsetYNumericUpDown.Name = "offsetYNumericUpDown";
            this.offsetYNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.offsetYNumericUpDown.TabIndex = 10;
            this.offsetYNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.offsetYNumericUpDown.ValueChanged += new System.EventHandler(this.offsetYNumericUpDown_ValueChanged);
            // 
            // importModeComboBox
            // 
            this.importModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.importModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.importModeComboBox.FormattingEnabled = true;
            this.importModeComboBox.Items.AddRange(new object[] {
            "Clip",
            "Wrap"});
            this.importModeComboBox.Location = new System.Drawing.Point(166, 33);
            this.importModeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.importModeComboBox.Name = "importModeComboBox";
            this.importModeComboBox.Size = new System.Drawing.Size(154, 21);
            this.importModeComboBox.TabIndex = 11;
            this.importModeComboBox.SelectedIndexChanged += new System.EventHandler(this.importModeComboBox_SelectedIndexChanged);
            // 
            // importModeLabel
            // 
            this.importModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.importModeLabel.AutoSize = true;
            this.importModeLabel.Location = new System.Drawing.Point(4, 33);
            this.importModeLabel.Margin = new System.Windows.Forms.Padding(4);
            this.importModeLabel.Name = "importModeLabel";
            this.importModeLabel.Padding = new System.Windows.Forms.Padding(4);
            this.importModeLabel.Size = new System.Drawing.Size(154, 21);
            this.importModeLabel.TabIndex = 2;
            this.importModeLabel.Text = "Import Mode";
            this.importModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // offsetSeparatorLabel
            // 
            this.offsetSeparatorLabel.AutoSize = true;
            this.offsetSeparatorLabel.Location = new System.Drawing.Point(70, 0);
            this.offsetSeparatorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.offsetSeparatorLabel.Name = "offsetSeparatorLabel";
            this.offsetSeparatorLabel.Padding = new System.Windows.Forms.Padding(2);
            this.offsetSeparatorLabel.Size = new System.Drawing.Size(14, 17);
            this.offsetSeparatorLabel.TabIndex = 8;
            this.offsetSeparatorLabel.Text = " ";
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 112);
            this.Controls.Add(this.tableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import";
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.dialogTableLayout.ResumeLayout(false);
            this.optionsTableLayout.ResumeLayout(false);
            this.optionsTableLayout.PerformLayout();
            this.offsetTableLayout.ResumeLayout(false);
            this.offsetTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetYNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.TableLayoutPanel dialogTableLayout;
        private System.Windows.Forms.Button dialogCancelButton;
        private System.Windows.Forms.Button dialogConfirmButton;
        private System.Windows.Forms.TableLayoutPanel optionsTableLayout;
        private System.Windows.Forms.Label importModeLabel;
        private System.Windows.Forms.TableLayoutPanel offsetTableLayout;
        private System.Windows.Forms.NumericUpDown offsetXNumericUpDown;
        private System.Windows.Forms.Label offsetSeparatorLabel;
        private System.Windows.Forms.NumericUpDown offsetYNumericUpDown;
        private System.Windows.Forms.ComboBox importModeComboBox;
        private System.Windows.Forms.Label offsetLabel;
    }
}