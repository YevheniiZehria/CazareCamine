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
            this.radioMatricol = new System.Windows.Forms.RadioButton();
            this.radioNume = new System.Windows.Forms.RadioButton();
            this.facultyFilterGroup = new System.Windows.Forms.GroupBox();
            this.checkC4 = new System.Windows.Forms.CheckBox();
            this.checkC3 = new System.Windows.Forms.CheckBox();
            this.checkC2 = new System.Windows.Forms.CheckBox();
            this.checkC1 = new System.Windows.Forms.CheckBox();
            this.checkC5 = new System.Windows.Forms.CheckBox();
            this.checkC6 = new System.Windows.Forms.CheckBox();
            this.checkC7 = new System.Windows.Forms.CheckBox();
            this.searchTypePanel.SuspendLayout();
            this.facultyFilterGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNume
            // 
            this.textNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textNume.Location = new System.Drawing.Point(175, 72);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(200, 26);
            this.textNume.TabIndex = 0;
            // 
            // textPrenume
            // 
            this.textPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textPrenume.Location = new System.Drawing.Point(175, 142);
            this.textPrenume.Name = "textPrenume";
            this.textPrenume.Size = new System.Drawing.Size(200, 26);
            this.textPrenume.TabIndex = 1;
            // 
            // lbl3Nume
            // 
            this.lbl3Nume.AutoSize = true;
            this.lbl3Nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl3Nume.Location = new System.Drawing.Point(82, 72);
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
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(175, 182);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(200, 40);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Cauta dupa Nume";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textNrMatricol
            // 
            this.textNrMatricol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textNrMatricol.Location = new System.Drawing.Point(503, 71);
            this.textNrMatricol.Name = "textNrMatricol";
            this.textNrMatricol.Size = new System.Drawing.Size(200, 26);
            this.textNrMatricol.TabIndex = 5;
            // 
            // lblNrMatricol
            // 
            this.lblNrMatricol.AutoSize = true;
            this.lblNrMatricol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNrMatricol.Location = new System.Drawing.Point(390, 72);
            this.lblNrMatricol.Name = "lblNrMatricol";
            this.lblNrMatricol.Size = new System.Drawing.Size(111, 25);
            this.lblNrMatricol.TabIndex = 6;
            this.lblNrMatricol.Text = "Nr Matricol:";
            // 
            // buttonSearchMatricol
            // 
            this.buttonSearchMatricol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSearchMatricol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchMatricol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSearchMatricol.ForeColor = System.Drawing.Color.White;
            this.buttonSearchMatricol.Location = new System.Drawing.Point(503, 142);
            this.buttonSearchMatricol.Name = "buttonSearchMatricol";
            this.buttonSearchMatricol.Size = new System.Drawing.Size(200, 40);
            this.buttonSearchMatricol.TabIndex = 7;
            this.buttonSearchMatricol.Text = "Cauta dupa Matricol";
            this.buttonSearchMatricol.UseVisualStyleBackColor = false;
            this.buttonSearchMatricol.Click += new System.EventHandler(this.buttonSearchMatricol_Click);
            // 
            // searchTypePanel
            // 
            this.searchTypePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.searchTypePanel.Controls.Add(this.radioMatricol);
            this.searchTypePanel.Controls.Add(this.radioNume);
            this.searchTypePanel.Location = new System.Drawing.Point(80, 12);
            this.searchTypePanel.Name = "searchTypePanel";
            this.searchTypePanel.Size = new System.Drawing.Size(583, 42);
            this.searchTypePanel.TabIndex = 8;
            // 
            // radioMatricol
            // 
            this.radioMatricol.AutoSize = true;
            this.radioMatricol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioMatricol.Location = new System.Drawing.Point(315, 12);
            this.radioMatricol.Name = "radioMatricol";
            this.radioMatricol.Size = new System.Drawing.Size(180, 24);
            this.radioMatricol.TabIndex = 1;
            this.radioMatricol.Text = "Cauta dupa Matricol";
            this.radioMatricol.UseVisualStyleBackColor = true;
            this.radioMatricol.CheckedChanged += new System.EventHandler(this.radioMatricol_CheckedChanged);
            // 
            // radioNume
            // 
            this.radioNume.AutoSize = true;
            this.radioNume.Checked = true;
            this.radioNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioNume.Location = new System.Drawing.Point(40, 12);
            this.radioNume.Name = "radioNume";
            this.radioNume.Size = new System.Drawing.Size(236, 24);
            this.radioNume.TabIndex = 0;
            this.radioNume.TabStop = true;
            this.radioNume.Text = "Cauta dupa Nume/Prenume";
            this.radioNume.UseVisualStyleBackColor = true;
            this.radioNume.CheckedChanged += new System.EventHandler(this.radioNume_CheckedChanged);
            // 
            // facultyFilterGroup
            // 
            this.facultyFilterGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.facultyFilterGroup.Controls.Add(this.checkC7);
            this.facultyFilterGroup.Controls.Add(this.checkC6);
            this.facultyFilterGroup.Controls.Add(this.checkC5);
            this.facultyFilterGroup.Controls.Add(this.checkC4);
            this.facultyFilterGroup.Controls.Add(this.checkC3);
            this.facultyFilterGroup.Controls.Add(this.checkC2);
            this.facultyFilterGroup.Controls.Add(this.checkC1);
            this.facultyFilterGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.facultyFilterGroup.Location = new System.Drawing.Point(80, 260);
            this.facultyFilterGroup.Name = "facultyFilterGroup";
            this.facultyFilterGroup.Size = new System.Drawing.Size(682, 100);
            this.facultyFilterGroup.TabIndex = 9;
            this.facultyFilterGroup.TabStop = false;
            this.facultyFilterGroup.Text = "Filtrare dupa Camine";
            // 
            // checkC4
            // 
            this.checkC4.AutoSize = true;
            this.checkC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkC4.Location = new System.Drawing.Point(301, 30);
            this.checkC4.Name = "checkC4";
            this.checkC4.Size = new System.Drawing.Size(52, 24);
            this.checkC4.TabIndex = 3;
            this.checkC4.Text = "C4";
            this.checkC4.UseVisualStyleBackColor = true;
          
            // 
            // checkC3
            // 
            this.checkC3.AutoSize = true;
            this.checkC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkC3.Location = new System.Drawing.Point(207, 30);
            this.checkC3.Name = "checkC3";
            this.checkC3.Size = new System.Drawing.Size(52, 24);
            this.checkC3.TabIndex = 2;
            this.checkC3.Text = "C3";
            this.checkC3.UseVisualStyleBackColor = true;
          
            // checkC2
            // 
            this.checkC2.AutoSize = true;
            this.checkC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkC2.Location = new System.Drawing.Point(109, 30);
            this.checkC2.Name = "checkC2";
            this.checkC2.Size = new System.Drawing.Size(52, 24);
            this.checkC2.TabIndex = 1;
            this.checkC2.Text = "C2";
            this.checkC2.UseVisualStyleBackColor = true;
             
            // checkC1
            // 
            this.checkC1.AutoSize = true;
            this.checkC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkC1.Location = new System.Drawing.Point(20, 30);
            this.checkC1.Name = "checkC1";
            this.checkC1.Size = new System.Drawing.Size(52, 24);
            this.checkC1.TabIndex = 0;
            this.checkC1.Text = "C1\r\n";
            this.checkC1.UseVisualStyleBackColor = true;
            
            // checkC5
            // 
            this.checkC5.AutoSize = true;
            this.checkC5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkC5.Location = new System.Drawing.Point(407, 30);
            this.checkC5.Name = "checkC5";
            this.checkC5.Size = new System.Drawing.Size(52, 24);
            this.checkC5.TabIndex = 4;
            this.checkC5.Text = "C5";
            this.checkC5.UseVisualStyleBackColor = true;
            // 
            // checkC6
            // 
            this.checkC6.AutoSize = true;
            this.checkC6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkC6.Location = new System.Drawing.Point(502, 30);
            this.checkC6.Name = "checkC6";
            this.checkC6.Size = new System.Drawing.Size(52, 24);
            this.checkC6.TabIndex = 5;
            this.checkC6.Text = "C6";
            this.checkC6.UseVisualStyleBackColor = true;
            // 
            // checkC7
            // 
            this.checkC7.AutoSize = true;
            this.checkC7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkC7.Location = new System.Drawing.Point(599, 30);
            this.checkC7.Name = "checkC7";
            this.checkC7.Size = new System.Drawing.Size(52, 24);
            this.checkC7.TabIndex = 6;
            this.checkC7.Text = "C7";
            this.checkC7.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.facultyFilterGroup);
            this.Controls.Add(this.searchTypePanel);
            this.Controls.Add(this.buttonSearchMatricol);
            this.Controls.Add(this.lblNrMatricol);
            this.Controls.Add(this.textNrMatricol);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.lbl3Prenume);
            this.Controls.Add(this.lbl3Nume);
            this.Controls.Add(this.textPrenume);
            this.Controls.Add(this.textNume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cautare studenti";
            this.searchTypePanel.ResumeLayout(false);
            this.searchTypePanel.PerformLayout();
            this.facultyFilterGroup.ResumeLayout(false);
            this.facultyFilterGroup.PerformLayout();
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
        private System.Windows.Forms.GroupBox facultyFilterGroup;
        private System.Windows.Forms.CheckBox checkC4;
        private System.Windows.Forms.CheckBox checkC3;
        private System.Windows.Forms.CheckBox checkC2;
        private System.Windows.Forms.CheckBox checkC1;
        private System.Windows.Forms.CheckBox checkC5;
        private System.Windows.Forms.CheckBox checkC7;
        private System.Windows.Forms.CheckBox checkC6;
    }
}