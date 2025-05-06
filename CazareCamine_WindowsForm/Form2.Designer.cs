namespace CazareCamine_WindowsForm
{
    partial class Form2
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
            this.gridStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // gridStudent
            // 
            this.gridStudent.AllowUserToOrderColumns = true;
            this.gridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudent.Location = new System.Drawing.Point(3, 12);
            this.gridStudent.Name = "gridStudent";
            this.gridStudent.RowHeadersWidth = 51;
            this.gridStudent.RowTemplate.Height = 24;
            this.gridStudent.Size = new System.Drawing.Size(858, 438);
            this.gridStudent.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1076, 450);
            this.Controls.Add(this.gridStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Studenți";
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            // Update button styles

        }

        #endregion

        private System.Windows.Forms.DataGridView gridStudent;
    }
}