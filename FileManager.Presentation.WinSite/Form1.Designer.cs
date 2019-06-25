namespace FileManager.Presentation.WinSite
{
    partial class Form1
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
            this.btnSaveTxt = new System.Windows.Forms.Button();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.btnSaveXML = new System.Windows.Forms.Button();
            this.btnSaveJSON = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateTxt = new System.Windows.Forms.Button();
            this.btnFindStudentTxt = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveTxt
            // 
            this.btnSaveTxt.Location = new System.Drawing.Point(32, 293);
            this.btnSaveTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveTxt.Name = "btnSaveTxt";
            this.btnSaveTxt.Size = new System.Drawing.Size(93, 41);
            this.btnSaveTxt.TabIndex = 0;
            this.btnSaveTxt.Text = "GuardarTxt";
            this.btnSaveTxt.UseVisualStyleBackColor = true;
            this.btnSaveTxt.Click += new System.EventHandler(this.BtnSaveTxt_Click);
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(35, 30);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(86, 17);
            this.lblStudentId.TabIndex = 1;
            this.lblStudentId.Text = "IdEstudiante";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(35, 89);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(35, 155);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 17);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Apellidos";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(35, 214);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(141, 17);
            this.lblDateOfBirth.TabIndex = 4;
            this.lblDateOfBirth.Text = "Fecha de Nacimiento";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(140, 25);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(100, 22);
            this.txtStudentId.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 82);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(140, 150);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 22);
            this.txtSurname.TabIndex = 7;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(182, 209);
            this.txtDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(100, 22);
            this.txtDateOfBirth.TabIndex = 8;
            // 
            // btnSaveXML
            // 
            this.btnSaveXML.Location = new System.Drawing.Point(155, 293);
            this.btnSaveXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveXML.Name = "btnSaveXML";
            this.btnSaveXML.Size = new System.Drawing.Size(99, 41);
            this.btnSaveXML.TabIndex = 9;
            this.btnSaveXML.Text = "GuardarXml";
            this.btnSaveXML.UseVisualStyleBackColor = true;
            this.btnSaveXML.Click += new System.EventHandler(this.BtnSaveXML_Click);
            // 
            // btnSaveJSON
            // 
            this.btnSaveJSON.Location = new System.Drawing.Point(279, 293);
            this.btnSaveJSON.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveJSON.Name = "btnSaveJSON";
            this.btnSaveJSON.Size = new System.Drawing.Size(107, 41);
            this.btnSaveJSON.TabIndex = 10;
            this.btnSaveJSON.Text = "GuardarJson";
            this.btnSaveJSON.UseVisualStyleBackColor = true;
            this.btnSaveJSON.Click += new System.EventHandler(this.BtnSaveJSON_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LanguageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(456, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LanguageToolStripMenuItem
            // 
            this.LanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem1,
            this.spanishToolStripMenuItem});
            this.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem";
            this.LanguageToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.LanguageToolStripMenuItem.Text = "Idioma";
            // 
            // englishToolStripMenuItem1
            // 
            this.englishToolStripMenuItem1.Name = "englishToolStripMenuItem1";
            this.englishToolStripMenuItem1.Size = new System.Drawing.Size(143, 26);
            this.englishToolStripMenuItem1.Text = "English";
            this.englishToolStripMenuItem1.Click += new System.EventHandler(this.EnglishToolStripMenuItem1_Click);
            // 
            // spanishToolStripMenuItem
            // 
            this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            this.spanishToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.spanishToolStripMenuItem.Text = "Spanish";
            this.spanishToolStripMenuItem.Click += new System.EventHandler(this.SpanishToolStripMenuItem_Click);
            // 
            // btnUpdateTxt
            // 
            this.btnUpdateTxt.Location = new System.Drawing.Point(32, 410);
            this.btnUpdateTxt.Name = "btnUpdateTxt";
            this.btnUpdateTxt.Size = new System.Drawing.Size(93, 44);
            this.btnUpdateTxt.TabIndex = 12;
            this.btnUpdateTxt.Text = "UpdateTxt";
            this.btnUpdateTxt.UseVisualStyleBackColor = true;
            this.btnUpdateTxt.Click += new System.EventHandler(this.BtnUpdateTxt_Click);
            // 
            // btnFindStudentTxt
            // 
            this.btnFindStudentTxt.Location = new System.Drawing.Point(32, 350);
            this.btnFindStudentTxt.Name = "btnFindStudentTxt";
            this.btnFindStudentTxt.Size = new System.Drawing.Size(89, 39);
            this.btnFindStudentTxt.TabIndex = 13;
            this.btnFindStudentTxt.Text = "BuscarTxt";
            this.btnFindStudentTxt.UseVisualStyleBackColor = true;
            this.btnFindStudentTxt.Click += new System.EventHandler(this.BtnFindStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 521);
            this.Controls.Add(this.btnFindStudentTxt);
            this.Controls.Add(this.btnUpdateTxt);
            this.Controls.Add(this.btnSaveJSON);
            this.Controls.Add(this.btnSaveXML);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.btnSaveTxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveTxt;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.Button btnSaveXML;
        private System.Windows.Forms.Button btnSaveJSON;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem LanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem spanishToolStripMenuItem;
        private System.Windows.Forms.Button btnUpdateTxt;
        private System.Windows.Forms.Button btnFindStudentTxt;
    }
}

