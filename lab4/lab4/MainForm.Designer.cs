namespace lab4
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnBakeWheatBread;
        private System.Windows.Forms.Button btnBakeRyeBread;
        private System.Windows.Forms.Label lblBreadType;
        private System.Windows.Forms.Label lblBreadSize;
        private System.Windows.Forms.Label lblFilling;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnBakeWheatBread = new System.Windows.Forms.Button();
            this.btnBakeRyeBread = new System.Windows.Forms.Button();
            this.lblBreadType = new System.Windows.Forms.Label();
            this.lblBreadSize = new System.Windows.Forms.Label();
            this.lblFilling = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBakeWheatBread
            // 
            this.btnBakeWheatBread.Location = new System.Drawing.Point(20, 20);
            this.btnBakeWheatBread.Name = "btnBakeWheatBread";
            this.btnBakeWheatBread.Size = new System.Drawing.Size(196, 57);
            this.btnBakeWheatBread.TabIndex = 0;
            this.btnBakeWheatBread.Text = "Випекти пшеничний хліб";
            this.btnBakeWheatBread.UseVisualStyleBackColor = true;
            this.btnBakeWheatBread.Click += new System.EventHandler(this.btnBakeWheatBread_Click);
            // 
            // btnBakeRyeBread
            // 
            this.btnBakeRyeBread.Location = new System.Drawing.Point(255, 20);
            this.btnBakeRyeBread.Name = "btnBakeRyeBread";
            this.btnBakeRyeBread.Size = new System.Drawing.Size(203, 57);
            this.btnBakeRyeBread.TabIndex = 1;
            this.btnBakeRyeBread.Text = "Випекти житній хліб";
            this.btnBakeRyeBread.UseVisualStyleBackColor = true;
            this.btnBakeRyeBread.Click += new System.EventHandler(this.btnBakeRyeBread_Click);
            // 
            // lblBreadType
            // 
            this.lblBreadType.AutoSize = true;
            this.lblBreadType.Location = new System.Drawing.Point(20, 80);
            this.lblBreadType.Name = "lblBreadType";
            this.lblBreadType.Size = new System.Drawing.Size(42, 16);
            this.lblBreadType.TabIndex = 2;
            this.lblBreadType.Text = "Type:";
            // 
            // lblBreadSize
            // 
            this.lblBreadSize.AutoSize = true;
            this.lblBreadSize.Location = new System.Drawing.Point(20, 120);
            this.lblBreadSize.Name = "lblBreadSize";
            this.lblBreadSize.Size = new System.Drawing.Size(36, 16);
            this.lblBreadSize.TabIndex = 3;
            this.lblBreadSize.Text = "Size:";
            // 
            // lblFilling
            // 
            this.lblFilling.AutoSize = true;
            this.lblFilling.Location = new System.Drawing.Point(20, 160);
            this.lblFilling.Name = "lblFilling";
            this.lblFilling.Size = new System.Drawing.Size(45, 16);
            this.lblFilling.TabIndex = 4;
            this.lblFilling.Text = "Filling:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 191);
            this.Controls.Add(this.btnBakeWheatBread);
            this.Controls.Add(this.btnBakeRyeBread);
            this.Controls.Add(this.lblBreadType);
            this.Controls.Add(this.lblBreadSize);
            this.Controls.Add(this.lblFilling);
            this.Name = "MainForm";
            this.Text = "Пекарня - Патерн Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

