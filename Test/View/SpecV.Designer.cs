namespace Proiect.View
{
    partial class SpecVcs
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
            this.addSpecB = new System.Windows.Forms.Button();
            this.snrLoc = new System.Windows.Forms.Label();
            this.sname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.snrTax = new System.Windows.Forms.Label();
            this.loc = new System.Windows.Forms.TextBox();
            this.locTax = new System.Windows.Forms.TextBox();
            this.cancelB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addSpecB
            // 
            this.addSpecB.Location = new System.Drawing.Point(61, 87);
            this.addSpecB.Name = "addSpecB";
            this.addSpecB.Size = new System.Drawing.Size(112, 23);
            this.addSpecB.TabIndex = 0;
            this.addSpecB.Text = "Add";
            this.addSpecB.UseVisualStyleBackColor = true;
            this.addSpecB.Click += new System.EventHandler(this.addSpecB_Click);
            // 
            // snrLoc
            // 
            this.snrLoc.AutoSize = true;
            this.snrLoc.Location = new System.Drawing.Point(12, 36);
            this.snrLoc.Name = "snrLoc";
            this.snrLoc.Size = new System.Drawing.Size(73, 13);
            this.snrLoc.TabIndex = 1;
            this.snrLoc.Text = "Numar Locuri:";
            // 
            // sname
            // 
            this.sname.AutoSize = true;
            this.sname.Location = new System.Drawing.Point(12, 9);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(55, 13);
            this.sname.TabIndex = 2;
            this.sname.Text = "Denumire:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(129, 6);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 3;
            // 
            // snrTax
            // 
            this.snrTax.AutoSize = true;
            this.snrTax.Location = new System.Drawing.Point(12, 64);
            this.snrTax.Name = "snrTax";
            this.snrTax.Size = new System.Drawing.Size(100, 13);
            this.snrTax.TabIndex = 1;
            this.snrTax.Text = "Numar Locuri Taxa:";
            // 
            // loc
            // 
            this.loc.Location = new System.Drawing.Point(129, 33);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(100, 20);
            this.loc.TabIndex = 3;
            // 
            // locTax
            // 
            this.locTax.Location = new System.Drawing.Point(129, 61);
            this.locTax.Name = "locTax";
            this.locTax.Size = new System.Drawing.Size(100, 20);
            this.locTax.TabIndex = 3;
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(61, 116);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(112, 23);
            this.cancelB.TabIndex = 0;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // SpecVcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 157);
            this.Controls.Add(this.locTax);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.name);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.snrTax);
            this.Controls.Add(this.snrLoc);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.addSpecB);
            this.Name = "SpecVcs";
            this.Text = "SpecVcs";
            this.Load += new System.EventHandler(this.SpecVcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSpecB;
        private System.Windows.Forms.Label snrLoc;
        private System.Windows.Forms.Label sname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label snrTax;
        private System.Windows.Forms.TextBox loc;
        private System.Windows.Forms.TextBox locTax;
        private System.Windows.Forms.Button cancelB;
    }
}