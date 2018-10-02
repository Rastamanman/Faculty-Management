namespace Proiect.View
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
            this.sspec = new System.Windows.Forms.Label();
            this.cancelB = new System.Windows.Forms.Button();
            this.optionsList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addOpB
            // 
            this.addOpB.Location = new System.Drawing.Point(15, 39);
            this.addOpB.Name = "addOpB";
            this.addOpB.Size = new System.Drawing.Size(124, 23);
            this.addOpB.TabIndex = 0;
            this.addOpB.Text = "Add Option";
            this.addOpB.UseVisualStyleBackColor = true;
            this.addOpB.Click += new System.EventHandler(this.addOpB_Click);
            // 
            // sspec
            // 
            this.sspec.AutoSize = true;
            this.sspec.Location = new System.Drawing.Point(12, 15);
            this.sspec.Name = "sspec";
            this.sspec.Size = new System.Drawing.Size(67, 13);
            this.sspec.TabIndex = 2;
            this.sspec.Text = "Specializare:";
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(145, 39);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(137, 23);
            this.cancelB.TabIndex = 4;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // optionsList
            // 
            this.optionsList.FormattingEnabled = true;
            this.optionsList.Location = new System.Drawing.Point(80, 12);
            this.optionsList.Name = "optionsList";
            this.optionsList.Size = new System.Drawing.Size(204, 21);
            this.optionsList.TabIndex = 5;
            // 
            // OptionV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 72);
            this.Controls.Add(this.optionsList);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.sspec);
            this.Controls.Add(this.addOpB);
            this.Name = "OptionV";
            this.Text = "OptionV";
            this.Load += new System.EventHandler(this.OptionV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addOpB;
        private System.Windows.Forms.Label sspec;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.ComboBox optionsList;
    }
}