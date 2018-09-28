namespace Proiect.View
{
    partial class EditOptionV
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
            this.buget = new System.Windows.Forms.CheckBox();
            this.nume = new System.Windows.Forms.TextBox();
            this.snume = new System.Windows.Forms.Label();
            this.cancelB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(74, 59);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(116, 23);
            this.saveB.TabIndex = 0;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // buget
            // 
            this.buget.AutoSize = true;
            this.buget.Location = new System.Drawing.Point(74, 36);
            this.buget.Name = "buget";
            this.buget.Size = new System.Drawing.Size(54, 17);
            this.buget.TabIndex = 1;
            this.buget.Text = "Buget";
            this.buget.UseVisualStyleBackColor = true;
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(74, 10);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(198, 20);
            this.nume.TabIndex = 2;
            // 
            // snume
            // 
            this.snume.AutoSize = true;
            this.snume.Location = new System.Drawing.Point(13, 13);
            this.snume.Name = "snume";
            this.snume.Size = new System.Drawing.Size(55, 13);
            this.snume.TabIndex = 3;
            this.snume.Text = "Denumire:";
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(74, 88);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(116, 23);
            this.cancelB.TabIndex = 0;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // EditOptionV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 119);
            this.Controls.Add(this.snume);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.buget);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.saveB);
            this.Name = "EditOptionV";
            this.Text = "EditOptionV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.CheckBox buget;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.Label snume;
        private System.Windows.Forms.Button cancelB;
    }
}