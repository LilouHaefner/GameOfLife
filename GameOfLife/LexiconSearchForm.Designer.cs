
namespace GameOfLife
{
    partial class LexiconSearchForm
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
            this.optionsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.dialogTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dialogCancelButton = new System.Windows.Forms.Button();
            this.dialogConfirmButton = new System.Windows.Forms.Button();
            this.tableLayout.SuspendLayout();
            this.optionsTableLayout.SuspendLayout();
            this.dialogTableLayout.SuspendLayout();
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
            this.tableLayout.Size = new System.Drawing.Size(272, 69);
            this.tableLayout.TabIndex = 1;
            // 
            // optionsTableLayout
            // 
            this.optionsTableLayout.AutoSize = true;
            this.optionsTableLayout.ColumnCount = 1;
            this.optionsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.optionsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.optionsTableLayout.Controls.Add(this.searchTextBox, 0, 0);
            this.optionsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsTableLayout.Location = new System.Drawing.Point(4, 4);
            this.optionsTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.optionsTableLayout.Name = "optionsTableLayout";
            this.optionsTableLayout.RowCount = 2;
            this.optionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.optionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.optionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.optionsTableLayout.Size = new System.Drawing.Size(264, 32);
            this.optionsTableLayout.TabIndex = 8;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextBox.Location = new System.Drawing.Point(3, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(258, 20);
            this.searchTextBox.TabIndex = 0;
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
            this.dialogTableLayout.Location = new System.Drawing.Point(106, 36);
            this.dialogTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.dialogTableLayout.Name = "dialogTableLayout";
            this.dialogTableLayout.RowCount = 1;
            this.dialogTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dialogTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.dialogTableLayout.Size = new System.Drawing.Size(162, 29);
            this.dialogTableLayout.TabIndex = 7;
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
            // LexiconSearchForm
            // 
            this.AcceptButton = this.dialogConfirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.dialogCancelButton;
            this.ClientSize = new System.Drawing.Size(272, 69);
            this.Controls.Add(this.tableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LexiconSearchForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.optionsTableLayout.ResumeLayout(false);
            this.optionsTableLayout.PerformLayout();
            this.dialogTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.TableLayoutPanel optionsTableLayout;
        private System.Windows.Forms.TableLayoutPanel dialogTableLayout;
        private System.Windows.Forms.Button dialogCancelButton;
        private System.Windows.Forms.Button dialogConfirmButton;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}