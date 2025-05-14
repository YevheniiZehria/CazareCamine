namespace CazareCamine_WindowsForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNationalitate = new System.Windows.Forms.Label();
            this.lblNr_matricol = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblFacultate = new System.Windows.Forms.Label();
            this.lblCamin = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNationalitate = new System.Windows.Forms.TextBox();
            this.txtFacultate = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtNr_matricol = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtCamin = new System.Windows.Forms.ComboBox();
            this.EroareNume = new System.Windows.Forms.Label();
            this.EroarePrenume = new System.Windows.Forms.Label();
            this.EroareData = new System.Windows.Forms.Label();
            this.EroareFacultate = new System.Windows.Forms.Label();
            this.EroareNationalitate = new System.Windows.Forms.Label();
            this.EroareNr_matricol = new System.Windows.Forms.Label();
            this.EroareMedia = new System.Windows.Forms.Label();
            this.EroareCamin = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCauatare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNume.Location = new System.Drawing.Point(106, 74);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(61, 23);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume:";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrenume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrenume.Location = new System.Drawing.Point(106, 146);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(83, 23);
            this.lblPrenume.TabIndex = 1;
            this.lblPrenume.Text = "Prenume:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblData.Location = new System.Drawing.Point(670, 70);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(113, 23);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data Nasterii:";
            // 
            // lblNationalitate
            // 
            this.lblNationalitate.AutoSize = true;
            this.lblNationalitate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNationalitate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNationalitate.Location = new System.Drawing.Point(76, 217);
            this.lblNationalitate.Name = "lblNationalitate";
            this.lblNationalitate.Size = new System.Drawing.Size(113, 23);
            this.lblNationalitate.TabIndex = 3;
            this.lblNationalitate.Text = "Nationalitate:";
            // 
            // lblNr_matricol
            // 
            this.lblNr_matricol.AutoSize = true;
            this.lblNr_matricol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNr_matricol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNr_matricol.Location = new System.Drawing.Point(634, 138);
            this.lblNr_matricol.Name = "lblNr_matricol";
            this.lblNr_matricol.Size = new System.Drawing.Size(148, 23);
            this.lblNr_matricol.TabIndex = 4;
            this.lblNr_matricol.Text = "Numarul Matricol:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMedia.Location = new System.Drawing.Point(721, 217);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(61, 23);
            this.lblMedia.TabIndex = 5;
            this.lblMedia.Text = "Media:";
            // 
            // lblFacultate
            // 
            this.lblFacultate.AutoSize = true;
            this.lblFacultate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFacultate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFacultate.Location = new System.Drawing.Point(106, 295);
            this.lblFacultate.Name = "lblFacultate";
            this.lblFacultate.Size = new System.Drawing.Size(82, 23);
            this.lblFacultate.TabIndex = 6;
            this.lblFacultate.Text = "Facultate:";
            // 
            // lblCamin
            // 
            this.lblCamin.AutoSize = true;
            this.lblCamin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCamin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCamin.Location = new System.Drawing.Point(721, 293);
            this.lblCamin.Name = "lblCamin";
            this.lblCamin.Size = new System.Drawing.Size(63, 23);
            this.lblCamin.TabIndex = 7;
            this.lblCamin.Text = "Camin:";
            // 
            // txtNume
            // 
            this.txtNume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNume.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNume.Location = new System.Drawing.Point(218, 74);
            this.txtNume.Multiline = true;
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(200, 30);
            this.txtNume.TabIndex = 8;
            // 
            // txtPrenume
            // 
            this.txtPrenume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrenume.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrenume.Location = new System.Drawing.Point(218, 146);
            this.txtPrenume.Multiline = true;
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(200, 30);
            this.txtPrenume.TabIndex = 9;
            // 
            // txtNationalitate
            // 
            this.txtNationalitate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNationalitate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNationalitate.Location = new System.Drawing.Point(218, 210);
            this.txtNationalitate.Multiline = true;
            this.txtNationalitate.Name = "txtNationalitate";
            this.txtNationalitate.Size = new System.Drawing.Size(200, 30);
            this.txtNationalitate.TabIndex = 10;
            // 
            // txtFacultate
            // 
            this.txtFacultate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFacultate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFacultate.Location = new System.Drawing.Point(218, 295);
            this.txtFacultate.Multiline = true;
            this.txtFacultate.Name = "txtFacultate";
            this.txtFacultate.Size = new System.Drawing.Size(200, 30);
            this.txtFacultate.TabIndex = 11;
            // 
            // txtData
            // 
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtData.Location = new System.Drawing.Point(821, 68);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(200, 30);
            this.txtData.TabIndex = 12;
            // 
            // txtNr_matricol
            // 
            this.txtNr_matricol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNr_matricol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNr_matricol.Location = new System.Drawing.Point(821, 144);
            this.txtNr_matricol.Multiline = true;
            this.txtNr_matricol.Name = "txtNr_matricol";
            this.txtNr_matricol.Size = new System.Drawing.Size(200, 30);
            this.txtNr_matricol.TabIndex = 13;
            // 
            // txtMedia
            // 
            this.txtMedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMedia.Location = new System.Drawing.Point(821, 218);
            this.txtMedia.Multiline = true;
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(200, 30);
            this.txtMedia.TabIndex = 14;
            // 
            // txtCamin
            // 
            this.txtCamin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCamin.FormattingEnabled = true;
            this.txtCamin.Items.AddRange(new object[] {
            "C1",
            "C2",
            "C3",
            "C4",
            "C5",
            "C6",
            "C7"});
            this.txtCamin.Location = new System.Drawing.Point(821, 294);
            this.txtCamin.Name = "txtCamin";
            this.txtCamin.Size = new System.Drawing.Size(200, 31);
            this.txtCamin.TabIndex = 15;
            // 
            // EroareNume
            // 
            this.EroareNume.AutoSize = true;
            this.EroareNume.BackColor = System.Drawing.Color.Transparent;
            this.EroareNume.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.EroareNume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.EroareNume.Location = new System.Drawing.Point(379, 74);
            this.EroareNume.Name = "EroareNume";
            this.EroareNume.Size = new System.Drawing.Size(0, 19);
            this.EroareNume.TabIndex = 16;
            // 
            // EroarePrenume
            // 
            this.EroarePrenume.AutoSize = true;
            this.EroarePrenume.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.EroarePrenume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.EroarePrenume.Location = new System.Drawing.Point(379, 146);
            this.EroarePrenume.Name = "EroarePrenume";
            this.EroarePrenume.Size = new System.Drawing.Size(0, 19);
            this.EroarePrenume.TabIndex = 17;
            // 
            // EroareData
            // 
            this.EroareData.AutoSize = true;
            this.EroareData.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.EroareData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.EroareData.Location = new System.Drawing.Point(994, 73);
            this.EroareData.Name = "EroareData";
            this.EroareData.Size = new System.Drawing.Size(0, 19);
            this.EroareData.TabIndex = 18;
            // 
            // EroareFacultate
            // 
            this.EroareFacultate.AutoSize = true;
            this.EroareFacultate.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.EroareFacultate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.EroareFacultate.Location = new System.Drawing.Point(379, 299);
            this.EroareFacultate.Name = "EroareFacultate";
            this.EroareFacultate.Size = new System.Drawing.Size(0, 19);
            this.EroareFacultate.TabIndex = 19;
            // 
            // EroareNationalitate
            // 
            this.EroareNationalitate.AutoSize = true;
            this.EroareNationalitate.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.EroareNationalitate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.EroareNationalitate.Location = new System.Drawing.Point(379, 221);
            this.EroareNationalitate.Name = "EroareNationalitate";
            this.EroareNationalitate.Size = new System.Drawing.Size(0, 19);
            this.EroareNationalitate.TabIndex = 20;
            // 
            // EroareNr_matricol
            // 
            this.EroareNr_matricol.AutoSize = true;
            this.EroareNr_matricol.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.EroareNr_matricol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.EroareNr_matricol.Location = new System.Drawing.Point(988, 142);
            this.EroareNr_matricol.Name = "EroareNr_matricol";
            this.EroareNr_matricol.Size = new System.Drawing.Size(0, 19);
            this.EroareNr_matricol.TabIndex = 21;
            // 
            // EroareMedia
            // 
            this.EroareMedia.AutoSize = true;
            this.EroareMedia.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.EroareMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.EroareMedia.Location = new System.Drawing.Point(982, 222);
            this.EroareMedia.Name = "EroareMedia";
            this.EroareMedia.Size = new System.Drawing.Size(0, 19);
            this.EroareMedia.TabIndex = 22;
            // 
            // EroareCamin
            // 
            this.EroareCamin.AutoSize = true;
            this.EroareCamin.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.EroareCamin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.EroareCamin.Location = new System.Drawing.Point(988, 298);
            this.EroareCamin.Name = "EroareCamin";
            this.EroareCamin.Size = new System.Drawing.Size(0, 19);
            this.EroareCamin.TabIndex = 23;
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAdauga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdauga.FlatAppearance.BorderSize = 0;
            this.btnAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdauga.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdauga.ForeColor = System.Drawing.Color.White;
            this.btnAdauga.Location = new System.Drawing.Point(218, 400);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(180, 40);
            this.btnAdauga.TabIndex = 2;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(443, 400);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(180, 40);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reseteaza";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCauatare
            // 
            this.btnCauatare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnCauatare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCauatare.FlatAppearance.BorderSize = 0;
            this.btnCauatare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCauatare.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCauatare.ForeColor = System.Drawing.Color.White;
            this.btnCauatare.Location = new System.Drawing.Point(656, 400);
            this.btnCauatare.Name = "btnCauatare";
            this.btnCauatare.Size = new System.Drawing.Size(180, 40);
            this.btnCauatare.TabIndex = 0;
            this.btnCauatare.Text = "Cautare";
            this.btnCauatare.UseVisualStyleBackColor = false;
            this.btnCauatare.Click += new System.EventHandler(this.btnCauatare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnModificare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificare.FlatAppearance.BorderSize = 0;
            this.btnModificare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificare.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnModificare.ForeColor = System.Drawing.Color.White;
            this.btnModificare.Location = new System.Drawing.Point(443, 462);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(180, 40);
            this.btnModificare.TabIndex = 3;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = false;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnCauatare);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.EroareCamin);
            this.Controls.Add(this.EroareMedia);
            this.Controls.Add(this.EroareNr_matricol);
            this.Controls.Add(this.EroareNationalitate);
            this.Controls.Add(this.EroareFacultate);
            this.Controls.Add(this.EroareData);
            this.Controls.Add(this.EroarePrenume);
            this.Controls.Add(this.EroareNume);
            this.Controls.Add(this.txtCamin);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtNr_matricol);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtFacultate);
            this.Controls.Add(this.txtNationalitate);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblCamin);
            this.Controls.Add(this.lblFacultate);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblNr_matricol);
            this.Controls.Add(this.lblNationalitate);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionare Studenți - Sistem de Cazare în Cămine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblNationalitate;
        private System.Windows.Forms.Label lblNr_matricol;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblFacultate;
        private System.Windows.Forms.Label lblCamin;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNationalitate;
        private System.Windows.Forms.TextBox txtFacultate;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtNr_matricol;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.ComboBox txtCamin;
        private System.Windows.Forms.Label EroareNume;
        private System.Windows.Forms.Label EroarePrenume;
        private System.Windows.Forms.Label EroareData;
        private System.Windows.Forms.Label EroareFacultate;
        private System.Windows.Forms.Label EroareNationalitate;
        private System.Windows.Forms.Label EroareNr_matricol;
        private System.Windows.Forms.Label EroareMedia;
        private System.Windows.Forms.Label EroareCamin;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCauatare;
        private System.Windows.Forms.Button btnModificare;
    }
}

