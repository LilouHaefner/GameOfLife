
namespace GameOfLife
{
    partial class NewProjectForm
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
            this.randomButton = new System.Windows.Forms.Button();
            this.lexiconButton = new System.Windows.Forms.Button();
            this.blankButton = new System.Windows.Forms.Button();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.AutoSize = true;
            this.tableLayout.ColumnCount = 3;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayout.Controls.Add(this.randomButton, 0, 0);
            this.tableLayout.Controls.Add(this.lexiconButton, 1, 0);
            this.tableLayout.Controls.Add(this.blankButton, 0, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 1;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.Size = new System.Drawing.Size(800, 450);
            this.tableLayout.TabIndex = 8;
            // 
            // randomButton
            // 
            this.randomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.randomButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.randomButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.randomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomButton.ForeColor = System.Drawing.Color.Gray;
            this.randomButton.Location = new System.Drawing.Point(266, 0);
            this.randomButton.Margin = new System.Windows.Forms.Padding(0);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(266, 450);
            this.randomButton.TabIndex = 2;
            this.randomButton.TabStop = false;
            this.randomButton.Text = "Random";
            this.randomButton.UseVisualStyleBackColor = false;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // lexiconButton
            // 
            this.lexiconButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lexiconButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.lexiconButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lexiconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lexiconButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lexiconButton.ForeColor = System.Drawing.Color.Gray;
            this.lexiconButton.Location = new System.Drawing.Point(532, 0);
            this.lexiconButton.Margin = new System.Windows.Forms.Padding(0);
            this.lexiconButton.Name = "lexiconButton";
            this.lexiconButton.Size = new System.Drawing.Size(268, 450);
            this.lexiconButton.TabIndex = 1;
            this.lexiconButton.TabStop = false;
            this.lexiconButton.Text = "Lexicon";
            this.lexiconButton.UseVisualStyleBackColor = false;
            this.lexiconButton.Click += new System.EventHandler(this.templateButton_Click);
            // 
            // blankButton
            // 
            this.blankButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.blankButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.blankButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blankButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blankButton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blankButton.ForeColor = System.Drawing.Color.Gray;
            this.blankButton.Location = new System.Drawing.Point(0, 0);
            this.blankButton.Margin = new System.Windows.Forms.Padding(0);
            this.blankButton.Name = "blankButton";
            this.blankButton.Size = new System.Drawing.Size(266, 450);
            this.blankButton.TabIndex = 0;
            this.blankButton.TabStop = false;
            this.blankButton.Text = "Blank";
            this.blankButton.UseVisualStyleBackColor = false;
            this.blankButton.Click += new System.EventHandler(this.blankButton_Click);
            // 
            // NewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProjectForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Project";
            this.tableLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Button lexiconButton;
        private System.Windows.Forms.Button blankButton;
    }
}