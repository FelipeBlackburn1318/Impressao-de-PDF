namespace Impressao_PDF
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
            this.btnAdiciona = new System.Windows.Forms.Button();
            this.btnImprime = new System.Windows.Forms.Button();
            this.dtgPdf = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPdf)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdiciona
            // 
            resources.ApplyResources(this.btnAdiciona, "btnAdiciona");
            this.btnAdiciona.BackColor = System.Drawing.Color.DarkRed;
            this.btnAdiciona.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAdiciona.Name = "btnAdiciona";
            this.btnAdiciona.UseVisualStyleBackColor = false;
            this.btnAdiciona.Click += new System.EventHandler(this.btnAdiciona_Click);
            // 
            // btnImprime
            // 
            resources.ApplyResources(this.btnImprime, "btnImprime");
            this.btnImprime.BackColor = System.Drawing.Color.DarkGreen;
            this.btnImprime.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnImprime.Name = "btnImprime";
            this.btnImprime.UseVisualStyleBackColor = false;
            this.btnImprime.Click += new System.EventHandler(this.btnImprime_Click);
            // 
            // dtgPdf
            // 
            resources.ApplyResources(this.dtgPdf, "dtgPdf");
            this.dtgPdf.AllowUserToAddRows = false;
            this.dtgPdf.AllowUserToDeleteRows = false;
            this.dtgPdf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPdf.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dtgPdf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPdf.Name = "dtgPdf";
            // 
            // btnLimpar
            // 
            resources.ApplyResources(this.btnLimpar, "btnLimpar");
            this.btnLimpar.BackColor = System.Drawing.Color.DarkRed;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dtgPdf);
            this.Controls.Add(this.btnImprime);
            this.Controls.Add(this.btnAdiciona);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPdf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdiciona;
        private System.Windows.Forms.Button btnImprime;
        private System.Windows.Forms.DataGridView dtgPdf;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
    }
}

