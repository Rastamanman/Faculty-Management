namespace Proiect.View
{
    partial class StudV
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
            this.snume = new System.Windows.Forms.Label();
            this.tNume = new System.Windows.Forms.TextBox();
            this.sprenume = new System.Windows.Forms.Label();
            this.tPrenume = new System.Windows.Forms.TextBox();
            this.scnp = new System.Windows.Forms.Label();
            this.tCnp = new System.Windows.Forms.TextBox();
            this.saveAndAdd = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.sex = new System.Windows.Forms.Label();
            this.mascOpt = new System.Windows.Forms.RadioButton();
            this.femOpt = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // snume
            // 
            this.snume.AutoSize = true;
            this.snume.Location = new System.Drawing.Point(12, 23);
            this.snume.Name = "snume";
            this.snume.Size = new System.Drawing.Size(38, 13);
            this.snume.TabIndex = 0;
            this.snume.Text = "Name:";
            // 
            // tNume
            // 
            this.tNume.Location = new System.Drawing.Point(72, 20);
            this.tNume.Name = "tNume";
            this.tNume.Size = new System.Drawing.Size(253, 20);
            this.tNume.TabIndex = 1;
            // 
            // sprenume
            // 
            this.sprenume.AutoSize = true;
            this.sprenume.Location = new System.Drawing.Point(12, 50);
            this.sprenume.Name = "sprenume";
            this.sprenume.Size = new System.Drawing.Size(52, 13);
            this.sprenume.TabIndex = 0;
            this.sprenume.Text = "Prenume:";
            // 
            // tPrenume
            // 
            this.tPrenume.Location = new System.Drawing.Point(72, 47);
            this.tPrenume.Name = "tPrenume";
            this.tPrenume.Size = new System.Drawing.Size(253, 20);
            this.tPrenume.TabIndex = 1;
            // 
            // scnp
            // 
            this.scnp.AutoSize = true;
            this.scnp.Location = new System.Drawing.Point(12, 75);
            this.scnp.Name = "scnp";
            this.scnp.Size = new System.Drawing.Size(32, 13);
            this.scnp.TabIndex = 0;
            this.scnp.Text = "CNP:";
            // 
            // tCnp
            // 
            this.tCnp.Location = new System.Drawing.Point(72, 72);
            this.tCnp.Name = "tCnp";
            this.tCnp.Size = new System.Drawing.Size(253, 20);
            this.tCnp.TabIndex = 1;
            // 
            // saveAndAdd
            // 
            this.saveAndAdd.Location = new System.Drawing.Point(15, 128);
            this.saveAndAdd.Name = "saveAndAdd";
            this.saveAndAdd.Size = new System.Drawing.Size(310, 23);
            this.saveAndAdd.TabIndex = 4;
            this.saveAndAdd.Text = "Add Student";
            this.saveAndAdd.UseVisualStyleBackColor = true;
            this.saveAndAdd.Click += new System.EventHandler(this.saveAndAdd_Click);
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(15, 157);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(310, 23);
            this.cancelB.TabIndex = 5;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(12, 101);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(28, 13);
            this.sex.TabIndex = 0;
            this.sex.Text = "Sex:";
            // 
            // mascOpt
            // 
            this.mascOpt.AutoSize = true;
            this.mascOpt.Location = new System.Drawing.Point(72, 99);
            this.mascOpt.Name = "mascOpt";
            this.mascOpt.Size = new System.Drawing.Size(51, 17);
            this.mascOpt.TabIndex = 6;
            this.mascOpt.TabStop = true;
            this.mascOpt.Text = "Masc";
            this.mascOpt.UseVisualStyleBackColor = true;
            // 
            // femOpt
            // 
            this.femOpt.AutoSize = true;
            this.femOpt.Location = new System.Drawing.Point(174, 99);
            this.femOpt.Name = "femOpt";
            this.femOpt.Size = new System.Drawing.Size(45, 17);
            this.femOpt.TabIndex = 6;
            this.femOpt.TabStop = true;
            this.femOpt.Text = "Fem";
            this.femOpt.UseVisualStyleBackColor = true;
            // 
            // StudV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 198);
            this.Controls.Add(this.femOpt);
            this.Controls.Add(this.mascOpt);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.saveAndAdd);
            this.Controls.Add(this.tCnp);
            this.Controls.Add(this.tPrenume);
            this.Controls.Add(this.tNume);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.scnp);
            this.Controls.Add(this.sprenume);
            this.Controls.Add(this.snume);
            this.Name = "StudV";
            this.Text = "StudV";
            this.Load += new System.EventHandler(this.StudV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label snume;
        private System.Windows.Forms.Label sprenume;
        private System.Windows.Forms.Label scnp;
        private System.Windows.Forms.Button saveAndAdd;
        public System.Windows.Forms.TextBox tNume;
        public System.Windows.Forms.TextBox tPrenume;
        public System.Windows.Forms.TextBox tCnp;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.RadioButton mascOpt;
        private System.Windows.Forms.RadioButton femOpt;
    }
}