namespace CazareCamine_WindowsForm
{
    partial class Form3
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
            this.textNume = new System.Windows.Forms.TextBox();
            this.textPrenume = new System.Windows.Forms.TextBox();
            this.lbl3Nume = new System.Windows.Forms.Label();
            this.lbl3Prenume = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textNrMatricol = new System.Windows.Forms.TextBox();
            this.lblNrMatricol = new System.Windows.Forms.Label();
            this.buttonSearchMatricol = new System.Windows.Forms.Button();
            this.searchTypePanel = new System.Windows.Forms.Panel();
            this.radioNume = new System.Windows.Forms.RadioButton();
            this.radioMatricol = new System.Windows.Forms.RadioButton();
            this.searchTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNume
            // 
            this.textNume.Location = new System.Drawing.Point(175, 72);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(160, 22);
            this.textNume.TabIndex = 0;
            // 
            // textPrenume
            // 
            this.textPrenume.Location = new System.Drawing.Point(175, 142);
            this.textPrenume.Name = "textPrenume";
            this.textPrenume.Size = new System.Drawing.Size(160, 22);
            this.textPrenume.TabIndex = 1;
            // 
            // lbl3Nume
            // 
            this.lbl3Nume.AutoSize = true;
            this.lbl3Nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl3Nume.Location = new System.Drawing.Point(75, 72);
            this.lbl3Nume.Name = "lbl3Nume";
            this.lbl3Nume.Size = new System.Drawing.Size(70, 25);
            this.lbl3Nume.TabIndex = 2;
            this.lbl3Nume.Text = "Nume:";
            // 
            // lbl3Prenume
            // 
            this.lbl3Prenume.AutoSize = true;
            this.lbl3Prenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl3Prenume.Location = new System.Drawing.Point(75, 142);
            this.lbl3Prenume.Name = "lbl3Prenume";
            this.lbl3Prenume.Size = new System.Drawing.Size(97, 25);
            this.lbl3Prenume.TabIndex = 3;
            this.lbl3Prenume.Text = "Prenume:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(193, 182);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(117, 57);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Cauta dupa Nume";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textNrMatricol
            // 
            this.textNrMatricol.Location = new System.Drawing.Point(463, 72);
            this.textNrMatricol.Name = "textNrMatricol";
            this.textNrMatricol.Size = new System.Drawing.Size(160, 22);
            this.textNrMatricol.TabIndex = 5;
            // 
            // lblNrMatricol
            // 
            this.lblNrMatricol.AutoSize = true;
            this.lblNrMatricol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNrMatricol.Location = new System.Drawing.Point(348, 72);
            this.lblNrMatricol.Name = "lblNrMatricol";
            this.lblNrMatricol.Size = new System.Drawing.Size(112, 25);
            this.lblNrMatricol.TabIndex = 6;
            this.lblNrMatricol.Text = "Nr Matricol:";
            // 
            // buttonSearchMatricol
            // 
            this.buttonSearchMatricol.Location = new System.Drawing.Point(463, 110);
            this.buttonSearchMatricol.Name = "buttonSearchMatricol";
            this.buttonSearchMatricol.Size = new System.Drawing.Size(117, 57);
            this.buttonSearchMatricol.TabIndex = 7;
            this.buttonSearchMatricol.Text = "Cauta dupa Matricol";
            this.buttonSearchMatricol.UseVisualStyleBackColor = true;
            this.buttonSearchMatricol.Click += new System.EventHandler(this.buttonSearchMatricol_Click);
            // 
            // searchTypePanel
            // 
            this.searchTypePanel.Controls.Add(this.radioMatricol);
            this.searchTypePanel.Controls.Add(this.radioNume);
            this.searchTypePanel.Location = new System.Drawing.Point(80, 12);
            this.searchTypePanel.Name = "searchTypePanel";
            this.searchTypePanel.Size = new System.Drawing.Size(543, 42);
            this.searchTypePanel.TabIndex = 8;
            // 
            // radioNume
            // 
            this.radioNume.AutoSize = true;
            this.radioNume.Checked = true;
            this.radioNume.Location = new System.Drawing.Point(95, 12);
            this.radioNume.Name = "radioNume";
            this.radioNume.Size = new System.Drawing.Size(195, 20);
            this.radioNume.TabIndex = 0;
            this.radioNume.TabStop = true;
            this.radioNume.Text = "Cauta dupa Nume/Prenume";
            this.radioNume.UseVisualStyleBackColor = true;
            this.radioNume.CheckedChanged += new System.EventHandler(this.radioNume_CheckedChanged);
            // 
            // radioMatricol
            // 
            this.radioMatricol.AutoSize = true;
            this.radioMatricol.Location = new System.Drawing.Point(315, 12);
            this.radioMatricol.Name = "radioMatricol";
            this.radioMatricol.Size = new System.Drawing.Size(149, 20);
            this.radioMatricol.TabIndex = 1;
            this.radioMatricol.Text = "Cauta dupa Matricol";
            this.radioMatricol.UseVisualStyleBackColor = true;
            this.radioMatricol.CheckedChanged += new System.EventHandler(this.radioMatricol_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchTypePanel);
            this.Controls.Add(this.buttonSearchMatricol);
            this.Controls.Add(this.lblNrMatricol);
            this.Controls.Add(this.textNrMatricol);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.lbl3Prenume);
            this.Controls.Add(this.lbl3Nume);
            this.Controls.Add(this.textPrenume);
            this.Controls.Add(this.textNume);
            this.Name = "Form3";
            this.Text = "Cautare studenti";
            this.searchTypePanel.ResumeLayout(false);
            this.searchTypePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNume;
        private System.Windows.Forms.TextBox textPrenume;
        private System.Windows.Forms.Label lbl3Nume;
        private System.Windows.Forms.Label lbl3Prenume;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textNrMatricol;
        private System.Windows.Forms.Label lblNrMatricol;
        private System.Windows.Forms.Button buttonSearchMatricol;
        private System.Windows.Forms.Panel searchTypePanel;
        private System.Windows.Forms.RadioButton radioMatricol;
        private System.Windows.Forms.RadioButton radioNume;
    }
}