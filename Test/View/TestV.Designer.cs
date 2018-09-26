namespace Proiect.View
{
    partial class TestV
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
            this.sname = new System.Windows.Forms.Label();
            this.addTestB = new System.Windows.Forms.Button();
            this.nume = new System.Windows.Forms.TextBox();
            this.spond = new System.Windows.Forms.Label();
            this.sreq = new System.Windows.Forms.Label();
            this.pondere = new System.Windows.Forms.TextBox();
            this.req = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sname
            // 
            this.sname.AutoSize = true;
            this.sname.Location = new System.Drawing.Point(12, 21);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(55, 13);
            this.sname.TabIndex = 0;
            this.sname.Text = "Denumire:";
            // 
            // addTestB
            // 
            this.addTestB.Location = new System.Drawing.Point(83, 96);
            this.addTestB.Name = "addTestB";
            this.addTestB.Size = new System.Drawing.Size(94, 23);
            this.addTestB.TabIndex = 1;
            this.addTestB.Text = "Add";
            this.addTestB.UseVisualStyleBackColor = true;
            this.addTestB.Click += new System.EventHandler(this.addTestB_Click);
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(83, 18);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(160, 20);
            this.nume.TabIndex = 2;
            // 
            // spond
            // 
            this.spond.AutoSize = true;
            this.spond.Location = new System.Drawing.Point(12, 47);
            this.spond.Name = "spond";
            this.spond.Size = new System.Drawing.Size(50, 13);
            this.spond.TabIndex = 0;
            this.spond.Text = "Pondere:";
            // 
            // sreq
            // 
            this.sreq.AutoSize = true;
            this.sreq.Location = new System.Drawing.Point(12, 73);
            this.sreq.Name = "sreq";
            this.sreq.Size = new System.Drawing.Size(69, 13);
            this.sreq.TabIndex = 0;
            this.sreq.Text = "Nota Minima:";
            // 
            // pondere
            // 
            this.pondere.Location = new System.Drawing.Point(83, 44);
            this.pondere.Name = "pondere";
            this.pondere.Size = new System.Drawing.Size(160, 20);
            this.pondere.TabIndex = 2;
            // 
            // req
            // 
            this.req.Location = new System.Drawing.Point(83, 70);
            this.req.Name = "req";
            this.req.Size = new System.Drawing.Size(160, 20);
            this.req.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TestV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 158);
            this.Controls.Add(this.req);
            this.Controls.Add(this.pondere);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addTestB);
            this.Controls.Add(this.sreq);
            this.Controls.Add(this.spond);
            this.Controls.Add(this.sname);
            this.Name = "TestV";
            this.Text = "TestV";
            this.Load += new System.EventHandler(this.TestV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sname;
        private System.Windows.Forms.Button addTestB;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.Label spond;
        private System.Windows.Forms.Label sreq;
        private System.Windows.Forms.TextBox pondere;
        private System.Windows.Forms.TextBox req;
        private System.Windows.Forms.Button button2;
    }
}