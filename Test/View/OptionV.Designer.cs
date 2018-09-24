namespace Test.View
{
    partial class OptionV
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
            this.addOpB = new System.Windows.Forms.Button();
            this.spec = new System.Windows.Forms.TextBox();
            this.sspec = new System.Windows.Forms.Label();
            this.buget = new System.Windows.Forms.CheckBox();
            this.cancelB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addOpB
            // 
            this.addOpB.Location = new System.Drawing.Point(15, 58);
            this.addOpB.Name = "addOpB";
            this.addOpB.Size = new System.Drawing.Size(124, 23);
            this.addOpB.TabIndex = 0;
            this.addOpB.Text = "Add Option";
            this.addOpB.UseVisualStyleBackColor = true;
            this.addOpB.Click += new System.EventHandler(this.addOpB_Click);
            // 
            // spec
            // 
            this.spec.Location = new System.Drawing.Point(85, 9);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(204, 20);
            this.spec.TabIndex = 1;
            // 
            // sspec
            // 
            this.sspec.AutoSize = true;
            this.sspec.Location = new System.Drawing.Point(12, 12);
            this.sspec.Name = "sspec";
            this.sspec.Size = new System.Drawing.Size(67, 13);
            this.sspec.TabIndex = 2;
            this.sspec.Text = "Specializare:";
            // 
            // buget
            // 
            this.buget.AutoSize = true;
            this.buget.Location = new System.Drawing.Point(85, 35);
            this.buget.Name = "buget";
            this.buget.Size = new System.Drawing.Size(54, 17);
            this.buget.TabIndex = 3;
            this.buget.Text = "Buget";
            this.buget.UseVisualStyleBackColor = true;
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(145, 58);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(137, 23);
            this.cancelB.TabIndex = 4;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // OptionV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 89);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.buget);
            this.Controls.Add(this.sspec);
            this.Controls.Add(this.spec);
            this.Controls.Add(this.addOpB);
            this.Name = "OptionV";
            this.Text = "OptionV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addOpB;
        private System.Windows.Forms.TextBox spec;
        private System.Windows.Forms.Label sspec;
        private System.Windows.Forms.CheckBox buget;
        private System.Windows.Forms.Button cancelB;
    }
}