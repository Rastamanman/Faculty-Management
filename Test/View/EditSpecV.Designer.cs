namespace Proiect.View
{
    partial class EditSpecV
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
            this.saveB = new System.Windows.Forms.Button();
            this.snume = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.TextBox();
            this.snrloc = new System.Windows.Forms.Label();
            this.nrLoc = new System.Windows.Forms.TextBox();
            this.snrloctax = new System.Windows.Forms.Label();
            this.nrLocTax = new System.Windows.Forms.TextBox();
            this.cancelB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(58, 80);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(104, 23);
            this.saveB.TabIndex = 0;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // snume
            // 
            this.snume.AutoSize = true;
            this.snume.Location = new System.Drawing.Point(12, 9);
            this.snume.Name = "snume";
            this.snume.Size = new System.Drawing.Size(55, 13);
            this.snume.TabIndex = 1;
            this.snume.Text = "Denumire:";
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(113, 6);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(100, 20);
            this.nume.TabIndex = 2;
            // 
            // snrloc
            // 
            this.snrloc.AutoSize = true;
            this.snrloc.Location = new System.Drawing.Point(12, 33);
            this.snrloc.Name = "snrloc";
            this.snrloc.Size = new System.Drawing.Size(73, 13);
            this.snrloc.TabIndex = 1;
            this.snrloc.Text = "Numar Locuri:";
            // 
            // nrLoc
            // 
            this.nrLoc.Location = new System.Drawing.Point(113, 30);
            this.nrLoc.Name = "nrLoc";
            this.nrLoc.Size = new System.Drawing.Size(100, 20);
            this.nrLoc.TabIndex = 2;
            // 
            // snrloctax
            // 
            this.snrloctax.AutoSize = true;
            this.snrloctax.Location = new System.Drawing.Point(12, 57);
            this.snrloctax.Name = "snrloctax";
            this.snrloctax.Size = new System.Drawing.Size(100, 13);
            this.snrloctax.TabIndex = 1;
            this.snrloctax.Text = "Numar Locuri Taxa:";
            // 
            // nrLocTax
            // 
            this.nrLocTax.Location = new System.Drawing.Point(113, 54);
            this.nrLocTax.Name = "nrLocTax";
            this.nrLocTax.Size = new System.Drawing.Size(100, 20);
            this.nrLocTax.TabIndex = 2;
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(58, 109);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(104, 23);
            this.cancelB.TabIndex = 0;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // EditSpecV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 141);
            this.Controls.Add(this.nrLocTax);
            this.Controls.Add(this.nrLoc);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.snrloctax);
            this.Controls.Add(this.snrloc);
            this.Controls.Add(this.snume);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.saveB);
            this.Name = "EditSpecV";
            this.Text = "EditSpecV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Label snume;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.Label snrloc;
        private System.Windows.Forms.TextBox nrLoc;
        private System.Windows.Forms.Label snrloctax;
        private System.Windows.Forms.TextBox nrLocTax;
        private System.Windows.Forms.Button cancelB;
    }
}