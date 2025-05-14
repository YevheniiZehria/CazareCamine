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
            this.panelEdit = new System.Windows.Forms.Panel();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.txtEditCamin = new System.Windows.Forms.ComboBox();
            this.txtEditMedia = new System.Windows.Forms.TextBox();
            this.txtEditFacultate = new System.Windows.Forms.TextBox();
            this.txtEditNrMatricol = new System.Windows.Forms.TextBox();
            this.txtEditNationalitate = new System.Windows.Forms.TextBox();
            this.txtEditData = new System.Windows.Forms.TextBox();
            this.txtEditPrenume = new System.Windows.Forms.TextBox();
            this.txtEditNume = new System.Windows.Forms.TextBox();
            this.lblEditCamin = new System.Windows.Forms.Label();
            this.lblEditMedia = new System.Windows.Forms.Label();
            this.lblEditFacultate = new System.Windows.Forms.Label();
            this.lblEditNrMatricol = new System.Windows.Forms.Label();
            this.lblEditNationalitate = new System.Windows.Forms.Label();
            this.lblEditData = new System.Windows.Forms.Label();
            this.lblEditPrenume = new System.Windows.Forms.Label();
            this.lblEditNume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridStudent
            // 
            this.gridStudent.AllowUserToOrderColumns = true;
            this.gridStudent.ColumnHeadersHeight = 29;
            this.gridStudent.Location = new System.Drawing.Point(1, 0);
            this.gridStudent.Name = "gridStudent";
            this.gridStudent.RowHeadersWidth = 51;
            this.gridStudent.RowTemplate.Height = 24;
            this.gridStudent.Size = new System.Drawing.Size(1063, 438);
            this.gridStudent.TabIndex = 0;
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.btnSalveaza);
            this.panelEdit.Controls.Add(this.txtEditCamin);
            this.panelEdit.Controls.Add(this.txtEditMedia);
            this.panelEdit.Controls.Add(this.txtEditFacultate);
            this.panelEdit.Controls.Add(this.txtEditNrMatricol);
            this.panelEdit.Controls.Add(this.txtEditNationalitate);
            this.panelEdit.Controls.Add(this.txtEditData);
            this.panelEdit.Controls.Add(this.txtEditPrenume);
            this.panelEdit.Controls.Add(this.txtEditNume);
            this.panelEdit.Controls.Add(this.lblEditCamin);
            this.panelEdit.Controls.Add(this.lblEditMedia);
            this.panelEdit.Controls.Add(this.lblEditFacultate);
            this.panelEdit.Controls.Add(this.lblEditNrMatricol);
            this.panelEdit.Controls.Add(this.lblEditNationalitate);
            this.panelEdit.Controls.Add(this.lblEditData);
            this.panelEdit.Controls.Add(this.lblEditPrenume);
            this.panelEdit.Controls.Add(this.lblEditNume);
            this.panelEdit.Location = new System.Drawing.Point(12, 450);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(1045, 300);
            this.panelEdit.TabIndex = 1;
            this.panelEdit.Visible = false;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSalveaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalveaza.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSalveaza.ForeColor = System.Drawing.Color.White;
            this.btnSalveaza.Location = new System.Drawing.Point(450, 250);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(150, 40);
            this.btnSalveaza.TabIndex = 8;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = false;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // txtEditCamin
            // 
            this.txtEditCamin.FormattingEnabled = true;
            this.txtEditCamin.Location = new System.Drawing.Point(100, 100);
            this.txtEditCamin.Name = "txtEditCamin";
            this.txtEditCamin.Size = new System.Drawing.Size(200, 24);
            this.txtEditCamin.TabIndex = 0;
            // 
            // txtEditMedia
            // 
            this.txtEditMedia.Location = new System.Drawing.Point(100, 150);
            this.txtEditMedia.Name = "txtEditMedia";
            this.txtEditMedia.Size = new System.Drawing.Size(200, 22);
            this.txtEditMedia.TabIndex = 1;
            // 
            // txtEditFacultate
            // 
            this.txtEditFacultate.Location = new System.Drawing.Point(100, 200);
            this.txtEditFacultate.Name = "txtEditFacultate";
            this.txtEditFacultate.Size = new System.Drawing.Size(200, 22);
            this.txtEditFacultate.TabIndex = 2;
            // 
            // txtEditNrMatricol
            // 
            this.txtEditNrMatricol.Location = new System.Drawing.Point(100, 250);
            this.txtEditNrMatricol.Name = "txtEditNrMatricol";
            this.txtEditNrMatricol.Size = new System.Drawing.Size(200, 22);
            this.txtEditNrMatricol.TabIndex = 3;
            // 
            // txtEditNationalitate
            // 
            this.txtEditNationalitate.Location = new System.Drawing.Point(100, 300);
            this.txtEditNationalitate.Name = "txtEditNationalitate";
            this.txtEditNationalitate.Size = new System.Drawing.Size(200, 22);
            this.txtEditNationalitate.TabIndex = 4;
            // 
            // txtEditData
            // 
            this.txtEditData.Location = new System.Drawing.Point(100, 350);
            this.txtEditData.Name = "txtEditData";
            this.txtEditData.Size = new System.Drawing.Size(200, 22);
            this.txtEditData.TabIndex = 5;
            // 
            // txtEditPrenume
            // 
            this.txtEditPrenume.Location = new System.Drawing.Point(100, 400);
            this.txtEditPrenume.Name = "txtEditPrenume";
            this.txtEditPrenume.Size = new System.Drawing.Size(200, 22);
            this.txtEditPrenume.TabIndex = 6;
            // 
            // txtEditNume
            // 
            this.txtEditNume.Location = new System.Drawing.Point(100, 450);
            this.txtEditNume.Name = "txtEditNume";
            this.txtEditNume.Size = new System.Drawing.Size(200, 22);
            this.txtEditNume.TabIndex = 7;
            // 
            // lblEditCamin
            // 
            this.lblEditCamin.AutoSize = true;
            this.lblEditCamin.Location = new System.Drawing.Point(100, 75);
            this.lblEditCamin.Name = "lblEditCamin";
            this.lblEditCamin.Size = new System.Drawing.Size(57, 17);
            this.lblEditCamin.TabIndex = 8;
            this.lblEditCamin.Text = "Camin:";
            // 
            // lblEditMedia
            // 
            this.lblEditMedia.AutoSize = true;
            this.lblEditMedia.Location = new System.Drawing.Point(100, 125);
            this.lblEditMedia.Name = "lblEditMedia";
            this.lblEditMedia.Size = new System.Drawing.Size(45, 17);
            this.lblEditMedia.TabIndex = 9;
            this.lblEditMedia.Text = "Media:";
            // 
            // lblEditFacultate
            // 
            this.lblEditFacultate.AutoSize = true;
            this.lblEditFacultate.Location = new System.Drawing.Point(100, 175);
            this.lblEditFacultate.Name = "lblEditFacultate";
            this.lblEditFacultate.Size = new System.Drawing.Size(69, 17);
            this.lblEditFacultate.TabIndex = 10;
            this.lblEditFacultate.Text = "Facultate:";
            // 
            // lblEditNrMatricol
            // 
            this.lblEditNrMatricol.AutoSize = true;
            this.lblEditNrMatricol.Location = new System.Drawing.Point(100, 225);
            this.lblEditNrMatricol.Name = "lblEditNrMatricol";
            this.lblEditNrMatricol.Size = new System.Drawing.Size(89, 17);
            this.lblEditNrMatricol.TabIndex = 11;
            this.lblEditNrMatricol.Text = "Nr. Matricol:";
            // 
            // lblEditNationalitate
            // 
            this.lblEditNationalitate.AutoSize = true;
            this.lblEditNationalitate.Location = new System.Drawing.Point(100, 275);
            this.lblEditNationalitate.Name = "lblEditNationalitate";
            this.lblEditNationalitate.Size = new System.Drawing.Size(109, 17);
            this.lblEditNationalitate.TabIndex = 12;
            this.lblEditNationalitate.Text = "Nationalitate:";
            // 
            // lblEditData
            // 
            this.lblEditData.AutoSize = true;
            this.lblEditData.Location = new System.Drawing.Point(100, 325);
            this.lblEditData.Name = "lblEditData";
            this.lblEditData.Size = new System.Drawing.Size(35, 17);
            this.lblEditData.TabIndex = 13;
            this.lblEditData.Text = "Data:";
            // 
            // lblEditPrenume
            // 
            this.lblEditPrenume.AutoSize = true;
            this.lblEditPrenume.Location = new System.Drawing.Point(100, 375);
            this.lblEditPrenume.Name = "lblEditPrenume";
            this.lblEditPrenume.Size = new System.Drawing.Size(69, 17);
            this.lblEditPrenume.TabIndex = 14;
            this.lblEditPrenume.Text = "Prenume:";
            // 
            // lblEditNume
            // 
            this.lblEditNume.AutoSize = true;
            this.lblEditNume.Location = new System.Drawing.Point(100, 425);
            this.lblEditNume.Name = "lblEditNume";
            this.lblEditNume.Size = new System.Drawing.Size(43, 17);
            this.lblEditNume.TabIndex = 15;
            this.lblEditNume.Text = "Nume:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 753);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.gridStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Studenți";
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridStudent;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.ComboBox txtEditCamin;
        private System.Windows.Forms.TextBox txtEditMedia;
        private System.Windows.Forms.TextBox txtEditFacultate;
        private System.Windows.Forms.TextBox txtEditNrMatricol;
        private System.Windows.Forms.TextBox txtEditNationalitate;
        private System.Windows.Forms.TextBox txtEditData;
        private System.Windows.Forms.TextBox txtEditPrenume;
        private System.Windows.Forms.TextBox txtEditNume;
        private System.Windows.Forms.Label lblEditCamin;
        private System.Windows.Forms.Label lblEditMedia;
        private System.Windows.Forms.Label lblEditFacultate;
        private System.Windows.Forms.Label lblEditNrMatricol;
        private System.Windows.Forms.Label lblEditNationalitate;
        private System.Windows.Forms.Label lblEditData;
        private System.Windows.Forms.Label lblEditPrenume;
        private System.Windows.Forms.Label lblEditNume;
    }
}