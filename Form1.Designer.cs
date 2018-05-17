namespace Filialauthentifizierung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Code = new System.Windows.Forms.Button();
            this.lbl_Code = new System.Windows.Forms.Label();
            this.txtb_FN = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtb_c1 = new System.Windows.Forms.TextBox();
            this.txtb_c2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Code
            // 
            this.btn_Code.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Code.Location = new System.Drawing.Point(58, 155);
            this.btn_Code.Name = "btn_Code";
            this.btn_Code.Size = new System.Drawing.Size(139, 49);
            this.btn_Code.TabIndex = 0;
            this.btn_Code.Text = "Code generieren";
            this.btn_Code.UseVisualStyleBackColor = true;
            this.btn_Code.Click += new System.EventHandler(this.btn_Code_Click);
            // 
            // lbl_Code
            // 
            this.lbl_Code.AutoSize = true;
            this.lbl_Code.Location = new System.Drawing.Point(318, 218);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(0, 13);
            this.lbl_Code.TabIndex = 1;
            // 
            // txtb_FN
            // 
            this.txtb_FN.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_FN.Location = new System.Drawing.Point(159, 12);
            this.txtb_FN.Name = "txtb_FN";
            this.txtb_FN.Size = new System.Drawing.Size(71, 24);
            this.txtb_FN.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(54, 24);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Filialnr.:";
            // 
            // txtb_c1
            // 
            this.txtb_c1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_c1.Location = new System.Drawing.Point(12, 52);
            this.txtb_c1.Name = "txtb_c1";
            this.txtb_c1.ReadOnly = true;
            this.txtb_c1.Size = new System.Drawing.Size(54, 24);
            this.txtb_c1.TabIndex = 4;
            this.txtb_c1.Text = "Code";
            // 
            // txtb_c2
            // 
            this.txtb_c2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_c2.Location = new System.Drawing.Point(159, 52);
            this.txtb_c2.Name = "txtb_c2";
            this.txtb_c2.ReadOnly = true;
            this.txtb_c2.Size = new System.Drawing.Size(71, 24);
            this.txtb_c2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(245, 215);
            this.Controls.Add(this.txtb_c2);
            this.Controls.Add(this.txtb_c1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtb_FN);
            this.Controls.Add(this.lbl_Code);
            this.Controls.Add(this.btn_Code);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Authenticator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Code;
        private System.Windows.Forms.Label lbl_Code;
        private System.Windows.Forms.TextBox txtb_FN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtb_c1;
        private System.Windows.Forms.TextBox txtb_c2;
    }
}

