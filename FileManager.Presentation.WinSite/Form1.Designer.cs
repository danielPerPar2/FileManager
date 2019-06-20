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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveTxt
            // 
            resources.ApplyResources(this.btnSaveTxt, "btnSaveTxt");
            this.btnSaveTxt.Name = "btnSaveTxt";
            this.btnSaveTxt.UseVisualStyleBackColor = true;
            this.btnSaveTxt.Click += new System.EventHandler(this.BtnSaveTxt_Click);
            // 
            // lblStudentId
            // 
            resources.ApplyResources(this.lblStudentId, "lblStudentId");
            this.lblStudentId.Name = "lblStudentId";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // lblSurname
            // 
            resources.ApplyResources(this.lblSurname, "lblSurname");
            this.lblSurname.Name = "lblSurname";
            // 
            // lblDateOfBirth
            // 
            resources.ApplyResources(this.lblDateOfBirth, "lblDateOfBirth");
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            // 
            // txtStudentId
            // 
            resources.ApplyResources(this.txtStudentId, "txtStudentId");
            this.txtStudentId.Name = "txtStudentId";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // txtSurname
            // 
            resources.ApplyResources(this.txtSurname, "txtSurname");
            this.txtSurname.Name = "txtSurname";
            // 
            // txtDateOfBirth
            // 
            resources.ApplyResources(this.txtDateOfBirth, "txtDateOfBirth");
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            // 
            // btnSaveXML
            // 
            resources.ApplyResources(this.btnSaveXML, "btnSaveXML");
            this.btnSaveXML.Name = "btnSaveXML";
            this.btnSaveXML.UseVisualStyleBackColor = true;
            this.btnSaveXML.Click += new System.EventHandler(this.BtnSaveXML_Click);
            // 
            // btnSaveJSON
            // 
            resources.ApplyResources(this.btnSaveJSON, "btnSaveJSON");
            this.btnSaveJSON.Name = "btnSaveJSON";
            this.btnSaveJSON.UseVisualStyleBackColor = true;
            this.btnSaveJSON.Click += new System.EventHandler(this.BtnSaveJSON_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LanguageToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // LanguageToolStripMenuItem
            // 
            resources.ApplyResources(this.LanguageToolStripMenuItem, "LanguageToolStripMenuItem");
            this.LanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem1,
            this.spanishToolStripMenuItem});
            this.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem";
            // 
            // englishToolStripMenuItem1
            // 
            resources.ApplyResources(this.englishToolStripMenuItem1, "englishToolStripMenuItem1");
            this.englishToolStripMenuItem1.Name = "englishToolStripMenuItem1";
            this.englishToolStripMenuItem1.Click += new System.EventHandler(this.EnglishToolStripMenuItem1_Click);
            // 
            // spanishToolStripMenuItem
            // 
            resources.ApplyResources(this.spanishToolStripMenuItem, "spanishToolStripMenuItem");
            this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            this.spanishToolStripMenuItem.Click += new System.EventHandler(this.SpanishToolStripMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "Form1";
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
    }
}

