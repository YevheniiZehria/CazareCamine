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
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNume.Location = new System.Drawing.Point(106, 74);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(84, 29);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume:";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPrenume.Location = new System.Drawing.Point(106, 146);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(117, 29);
            this.lblPrenume.TabIndex = 1;
            this.lblPrenume.Text = "Prenume:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblData.Location = new System.Drawing.Point(670, 70);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(157, 29);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data Nasterii:";
            // 
            // lblNationalitate
            // 
            this.lblNationalitate.AutoSize = true;
            this.lblNationalitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNationalitate.Location = new System.Drawing.Point(106, 218);
            this.lblNationalitate.Name = "lblNationalitate";
            this.lblNationalitate.Size = new System.Drawing.Size(153, 29);
            this.lblNationalitate.TabIndex = 3;
            this.lblNationalitate.Text = "Nationalitate:";
            // 
            // lblNr_matricol
            // 
            this.lblNr_matricol.AutoSize = true;
            this.lblNr_matricol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNr_matricol.Location = new System.Drawing.Point(670, 138);
            this.lblNr_matricol.Name = "lblNr_matricol";
            this.lblNr_matricol.Size = new System.Drawing.Size(201, 29);
            this.lblNr_matricol.TabIndex = 4;
            this.lblNr_matricol.Text = "Numarul Matricol:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMedia.Location = new System.Drawing.Point(670, 218);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(86, 29);
            this.lblMedia.TabIndex = 5;
            this.lblMedia.Text = "Media:";
            // 
            // lblFacultate
            // 
            this.lblFacultate.AutoSize = true;
            this.lblFacultate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblFacultate.Location = new System.Drawing.Point(106, 295);
            this.lblFacultate.Name = "lblFacultate";
            this.lblFacultate.Size = new System.Drawing.Size(117, 29);
            this.lblFacultate.TabIndex = 6;
            this.lblFacultate.Text = "Facultate:";
            // 
            // lblCamin
            // 
            this.lblCamin.AutoSize = true;
            this.lblCamin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCamin.Location = new System.Drawing.Point(668, 288);
            this.lblCamin.Name = "lblCamin";
            this.lblCamin.Size = new System.Drawing.Size(88, 29);
            this.lblCamin.TabIndex = 7;
            this.lblCamin.Text = "Camin:";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(218, 74);
            this.txtNume.Multiline = true;
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(155, 29);
            this.txtNume.TabIndex = 8;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(218, 146);
            this.txtPrenume.Multiline = true;
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(155, 29);
            this.txtPrenume.TabIndex = 9;
            // 
            // txtNationalitate
            // 
            this.txtNationalitate.Location = new System.Drawing.Point(254, 218);
            this.txtNationalitate.Multiline = true;
            this.txtNationalitate.Name = "txtNationalitate";
            this.txtNationalitate.Size = new System.Drawing.Size(119, 29);
            this.txtNationalitate.TabIndex = 10;
            // 
            // txtFacultate
            // 
            this.txtFacultate.Location = new System.Drawing.Point(218, 295);
            this.txtFacultate.Multiline = true;
            this.txtFacultate.Name = "txtFacultate";
            this.txtFacultate.Size = new System.Drawing.Size(155, 29);
            this.txtFacultate.TabIndex = 11;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(833, 70);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(155, 29);
            this.txtData.TabIndex = 12;
            // 
            // txtNr_matricol
            // 
            this.txtNr_matricol.Location = new System.Drawing.Point(892, 142);
            this.txtNr_matricol.Multiline = true;
            this.txtNr_matricol.Name = "txtNr_matricol";
            this.txtNr_matricol.Size = new System.Drawing.Size(90, 29);
            this.txtNr_matricol.TabIndex = 13;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(821, 218);
            this.txtMedia.Multiline = true;
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(155, 29);
            this.txtMedia.TabIndex = 14;
            // 
            // txtCamin
            // 
            this.txtCamin.FormattingEnabled = true;
            this.txtCamin.Items.AddRange(new object[] {
            "C1",
            "C2",
            "C3",
            "C4",
            "C5",
            "C6",
            "C7"});
            this.txtCamin.Location = new System.Drawing.Point(855, 293);
            this.txtCamin.Name = "txtCamin";
            this.txtCamin.Size = new System.Drawing.Size(121, 24);
            this.txtCamin.TabIndex = 15;
            // 
            // EroareNume
            // 
            this.EroareNume.AutoSize = true;
            this.EroareNume.BackColor = System.Drawing.Color.Transparent;
            this.EroareNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EroareNume.ForeColor = System.Drawing.Color.Red;
            this.EroareNume.Location = new System.Drawing.Point(379, 74);
            this.EroareNume.Name = "EroareNume";
            this.EroareNume.Size = new System.Drawing.Size(0, 25);
            this.EroareNume.TabIndex = 16;
            // 
            // EroarePrenume
            // 
            this.EroarePrenume.AutoSize = true;
            this.EroarePrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EroarePrenume.ForeColor = System.Drawing.Color.Red;
            this.EroarePrenume.Location = new System.Drawing.Point(379, 146);
            this.EroarePrenume.Name = "EroarePrenume";
            this.EroarePrenume.Size = new System.Drawing.Size(0, 25);
            this.EroarePrenume.TabIndex = 17;
            // 
            // EroareData
            // 
            this.EroareData.AutoSize = true;
            this.EroareData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EroareData.ForeColor = System.Drawing.Color.Red;
            this.EroareData.Location = new System.Drawing.Point(994, 73);
            this.EroareData.Name = "EroareData";
            this.EroareData.Size = new System.Drawing.Size(0, 25);
            this.EroareData.TabIndex = 18;
            // 
            // EroareFacultate
            // 
            this.EroareFacultate.AutoSize = true;
            this.EroareFacultate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EroareFacultate.ForeColor = System.Drawing.Color.Red;
            this.EroareFacultate.Location = new System.Drawing.Point(379, 299);
            this.EroareFacultate.Name = "EroareFacultate";
            this.EroareFacultate.Size = new System.Drawing.Size(0, 25);
            this.EroareFacultate.TabIndex = 19;
            // 
            // EroareNationalitate
            // 
            this.EroareNationalitate.AutoSize = true;
            this.EroareNationalitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EroareNationalitate.ForeColor = System.Drawing.Color.Red;
            this.EroareNationalitate.Location = new System.Drawing.Point(379, 221);
            this.EroareNationalitate.Name = "EroareNationalitate";
            this.EroareNationalitate.Size = new System.Drawing.Size(0, 25);
            this.EroareNationalitate.TabIndex = 20;
            // 
            // EroareNr_matricol
            // 
            this.EroareNr_matricol.AutoSize = true;
            this.EroareNr_matricol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EroareNr_matricol.ForeColor = System.Drawing.Color.Red;
            this.EroareNr_matricol.Location = new System.Drawing.Point(988, 142);
            this.EroareNr_matricol.Name = "EroareNr_matricol";
            this.EroareNr_matricol.Size = new System.Drawing.Size(0, 25);
            this.EroareNr_matricol.TabIndex = 21;
            // 
            // EroareMedia
            // 
            this.EroareMedia.AutoSize = true;
            this.EroareMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EroareMedia.ForeColor = System.Drawing.Color.Red;
            this.EroareMedia.Location = new System.Drawing.Point(982, 222);
            this.EroareMedia.Name = "EroareMedia";
            this.EroareMedia.Size = new System.Drawing.Size(0, 25);
            this.EroareMedia.TabIndex = 22;
            // 
            // EroareCamin
            // 
            this.EroareCamin.AutoSize = true;
            this.EroareCamin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EroareCamin.ForeColor = System.Drawing.Color.Red;
            this.EroareCamin.Location = new System.Drawing.Point(988, 298);
            this.EroareCamin.Name = "EroareCamin";
            this.EroareCamin.Size = new System.Drawing.Size(0, 25);
            this.EroareCamin.TabIndex = 23;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(337, 350);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(129, 49);
            this.btnAdauga.TabIndex = 24;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(496, 350);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 49);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reseteaza";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCauatare
            // 
            this.btnCauatare.Location = new System.Drawing.Point(634, 350);
            this.btnCauatare.Name = "btnCauatare";
            this.btnCauatare.Size = new System.Drawing.Size(110, 49);
            this.btnCauatare.TabIndex = 26;
            this.btnCauatare.Text = "Cautare";
            this.btnCauatare.UseVisualStyleBackColor = true;
            this.btnCauatare.Click += new System.EventHandler(this.btnCauatare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 450);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

