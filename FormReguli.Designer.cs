namespace FazanProiect
{
    partial class FormReguli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReguli));
            this.labelReguliTitlu = new System.Windows.Forms.Label();
            this.labelReguli = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelReguliTitlu
            // 
            this.labelReguliTitlu.AutoSize = true;
            this.labelReguliTitlu.BackColor = System.Drawing.Color.White;
            this.labelReguliTitlu.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReguliTitlu.Location = new System.Drawing.Point(218, 22);
            this.labelReguliTitlu.Name = "labelReguliTitlu";
            this.labelReguliTitlu.Size = new System.Drawing.Size(238, 82);
            this.labelReguliTitlu.TabIndex = 5;
            this.labelReguliTitlu.Text = "Rules";
            // 
            // labelReguli
            // 
            this.labelReguli.AutoSize = true;
            this.labelReguli.BackColor = System.Drawing.Color.White;
            this.labelReguli.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReguli.Location = new System.Drawing.Point(12, 120);
            this.labelReguli.Name = "labelReguli";
            this.labelReguli.Size = new System.Drawing.Size(633, 525);
            this.labelReguli.TabIndex = 7;
            this.labelReguli.Text = resources.GetString("labelReguli.Text");
            // 
            // FormReguli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(662, 682);
            this.Controls.Add(this.labelReguli);
            this.Controls.Add(this.labelReguliTitlu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormReguli";
            this.Text = "Rules";
            this.Load += new System.EventHandler(this.FormReguli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReguliTitlu;
        private System.Windows.Forms.Label labelReguli;
    }
}