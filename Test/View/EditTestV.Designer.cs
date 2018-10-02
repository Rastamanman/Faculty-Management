namespace Proiect.View
{
    partial class EditTestV
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
            this.editB = new System.Windows.Forms.Button();
            this.snume = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.TextBox();
            this.sreq = new System.Windows.Forms.Label();
            this.spond = new System.Windows.Forms.Label();
            this.req = new System.Windows.Forms.TextBox();
            this.pond = new System.Windows.Forms.TextBox();
            this.cancelB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editB
            // 
            this.editB.Location = new System.Drawing.Point(84, 97);
            this.editB.Name = "editB";
            this.editB.Size = new System.Drawing.Size(108, 31);
            this.editB.TabIndex = 0;
            this.editB.Text = "Save Changes";
            this.editB.UseVisualStyleBackColor = true;
            this.editB.Click += new System.EventHandler(this.editB_Click);
            // 
            // snume
            // 
            this.snume.AutoSize = true;
            this.snume.Location = new System.Drawing.Point(13, 13);
            this.snume.Name = "snume";
            this.snume.Size = new System.Drawing.Size(55, 13);
            this.snume.TabIndex = 1;
            this.snume.Text = "Denumire:";
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(102, 10);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(170, 20);
            this.nume.TabIndex = 2;
            // 
            // sreq
            // 
            this.sreq.AutoSize = true;
            this.sreq.Location = new System.Drawing.Point(13, 45);
            this.sreq.Name = "sreq";
            this.sreq.Size = new System.Drawing.Size(79, 13);
            this.sreq.TabIndex = 1;
            this.sreq.Text = "Cerinta Minima:";
            // 
            // spond
            // 
            this.spond.AutoSize = true;
            this.spond.Location = new System.Drawing.Point(13, 74);
            this.spond.Name = "spond";
            this.spond.Size = new System.Drawing.Size(47, 13);
            this.spond.TabIndex = 1;
            this.spond.Text = "Pondere";
            // 
            // req
            // 
            this.req.Location = new System.Drawing.Point(102, 42);
            this.req.Name = "req";
            this.req.Size = new System.Drawing.Size(170, 20);
            this.req.TabIndex = 2;
            // 
            // pond
            // 
            this.pond.Location = new System.Drawing.Point(102, 71);
            this.pond.Name = "pond";
            this.pond.Size = new System.Drawing.Size(170, 20);
            this.pond.TabIndex = 2;
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(84, 134);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(108, 31);
            this.cancelB.TabIndex = 0;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // EditTestV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 172);
            this.Controls.Add(this.pond);
            this.Controls.Add(this.req);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.spond);
            this.Controls.Add(this.sreq);
            this.Controls.Add(this.snume);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.editB);
            this.Name = "EditTestV";
            this.Text = "EditTestV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editB;
        private System.Windows.Forms.Label snume;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.Label sreq;
        private System.Windows.Forms.Label spond;
        private System.Windows.Forms.TextBox req;
        private System.Windows.Forms.TextBox pond;
        private System.Windows.Forms.Button cancelB;
    }
}