namespace FileManager.Presentation.WinSite
{
    partial class Vuelos
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
            this.lblOrigen = new System.Windows.Forms.Label();
            this.originCbo = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.destinationCbo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(41, 70);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(51, 17);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen";
            // 
            // originCbo
            // 
            this.originCbo.FormattingEnabled = true;
            this.originCbo.Location = new System.Drawing.Point(99, 70);
            this.originCbo.Name = "originCbo";
            this.originCbo.Size = new System.Drawing.Size(188, 24);
            this.originCbo.TabIndex = 1;
            this.originCbo.SelectedIndexChanged += new System.EventHandler(this.originCbo_SelectedIndexChanged);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(310, 76);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(56, 17);
            this.lblDestino.TabIndex = 2;
            this.lblDestino.Text = "Destino";
            // 
            // destinationCbo
            // 
            this.destinationCbo.FormattingEnabled = true;
            this.destinationCbo.Location = new System.Drawing.Point(372, 70);
            this.destinationCbo.Name = "destinationCbo";
            this.destinationCbo.Size = new System.Drawing.Size(177, 24);
            this.destinationCbo.TabIndex = 3;
            this.destinationCbo.SelectedIndexChanged += new System.EventHandler(this.destinationCbo_SelectedIndexChanged);
            // 
            // Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 176);
            this.Controls.Add(this.destinationCbo);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.originCbo);
            this.Controls.Add(this.lblOrigen);
            this.Name = "Vuelos";
            this.Text = "Vuelos";
            this.Load += new System.EventHandler(this.Vuelos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.ComboBox originCbo;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.ComboBox destinationCbo;
    }
}