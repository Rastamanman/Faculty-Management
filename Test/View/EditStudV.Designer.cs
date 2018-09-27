namespace Proiect.View
{
    partial class EditStudV
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
            this.sname = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.TextBox();
            this.sprenume = new System.Windows.Forms.Label();
            this.scnp = new System.Windows.Forms.Label();
            this.prenume = new System.Windows.Forms.TextBox();
            this.cnp = new System.Windows.Forms.TextBox();
            this.cancelB = new System.Windows.Forms.Button();
            this.ssex = new System.Windows.Forms.Label();
            this.mascOp = new System.Windows.Forms.RadioButton();
            this.femOp = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(74, 133);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(129, 23);
            this.saveB.TabIndex = 0;
            this.saveB.Text = "Save Changes";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // sname
            // 
            this.sname.AutoSize = true;
            this.sname.Location = new System.Drawing.Point(12, 25);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(38, 13);
            this.sname.TabIndex = 1;
            this.sname.Text = "Nume:";
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(99, 22);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(173, 20);
            this.nume.TabIndex = 2;
            // 
            // sprenume
            // 
            this.sprenume.AutoSize = true;
            this.sprenume.Location = new System.Drawing.Point(12, 48);
            this.sprenume.Name = "sprenume";
            this.sprenume.Size = new System.Drawing.Size(52, 13);
            this.sprenume.TabIndex = 1;
            this.sprenume.Text = "Prenume:";
            // 
            // scnp
            // 
            this.scnp.AutoSize = true;
            this.scnp.Location = new System.Drawing.Point(12, 71);
            this.scnp.Name = "scnp";
            this.scnp.Size = new System.Drawing.Size(32, 13);
            this.scnp.TabIndex = 1;
            this.scnp.Text = "CNP:";
            // 
            // prenume
            // 
            this.prenume.Location = new System.Drawing.Point(99, 45);
            this.prenume.Name = "prenume";
            this.prenume.Size = new System.Drawing.Size(173, 20);
            this.prenume.TabIndex = 2;
            // 
            // cnp
            // 
            this.cnp.Location = new System.Drawing.Point(99, 68);
            this.cnp.Name = "cnp";
            this.cnp.Size = new System.Drawing.Size(173, 20);
            this.cnp.TabIndex = 2;
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(74, 162);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(129, 23);
            this.cancelB.TabIndex = 0;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // ssex
            // 
            this.ssex.AutoSize = true;
            this.ssex.Location = new System.Drawing.Point(12, 97);
            this.ssex.Name = "ssex";
            this.ssex.Size = new System.Drawing.Size(28, 13);
            this.ssex.TabIndex = 1;
            this.ssex.Text = "Sex:";
            // 
            // mascOp
            // 
            this.mascOp.AutoSize = true;
            this.mascOp.Location = new System.Drawing.Point(74, 97);
            this.mascOp.Name = "mascOp";
            this.mascOp.Size = new System.Drawing.Size(51, 17);
            this.mascOp.TabIndex = 3;
            this.mascOp.TabStop = true;
            this.mascOp.Text = "Masc";
            this.mascOp.UseVisualStyleBackColor = true;
            // 
            // femOp
            // 
            this.femOp.AutoSize = true;
            this.femOp.Location = new System.Drawing.Point(165, 97);
            this.femOp.Name = "femOp";
            this.femOp.Size = new System.Drawing.Size(45, 17);
            this.femOp.TabIndex = 3;
            this.femOp.TabStop = true;
            this.femOp.Text = "Fem";
            this.femOp.UseVisualStyleBackColor = true;
            // 
            // EditStudV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.femOp);
            this.Controls.Add(this.mascOp);
            this.Controls.Add(this.cnp);
            this.Controls.Add(this.prenume);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.ssex);
            this.Controls.Add(this.scnp);
            this.Controls.Add(this.sprenume);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.saveB);
            this.Name = "EditStudV";
            this.Text = "EditStudV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Label sname;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.Label sprenume;
        private System.Windows.Forms.Label scnp;
        private System.Windows.Forms.TextBox prenume;
        private System.Windows.Forms.TextBox cnp;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Label ssex;
        private System.Windows.Forms.RadioButton mascOp;
        private System.Windows.Forms.RadioButton femOp;
    }
}