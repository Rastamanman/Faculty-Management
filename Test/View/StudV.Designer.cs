namespace Test.View
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
            this.soptiuni = new System.Windows.Forms.Label();
            optList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addOpB = new System.Windows.Forms.Button();
            this.remOpB = new System.Windows.Forms.Button();
            this.saveAndAdd = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
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
            // soptiuni
            // 
            this.soptiuni.AutoSize = true;
            this.soptiuni.Location = new System.Drawing.Point(12, 101);
            this.soptiuni.Name = "soptiuni";
            this.soptiuni.Size = new System.Drawing.Size(43, 13);
            this.soptiuni.TabIndex = 0;
            this.soptiuni.Text = "Optiuni:";
            // 
            // optList
            // 
            optList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nume,
            this.tip});
            optList.FullRowSelect = true;
            optList.Location = new System.Drawing.Point(13, 118);
            optList.Name = "optList";
            optList.Size = new System.Drawing.Size(312, 130);
            optList.TabIndex = 2;
            optList.UseCompatibleStateImageBehavior = false;
            optList.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // nume
            // 
            this.nume.Text = "Nume Specializare";
            this.nume.Width = 171;
            // 
            // tip
            // 
            this.tip.Text = "Buget/Taxa";
            this.tip.Width = 76;
            // 
            // addOpB
            // 
            this.addOpB.Location = new System.Drawing.Point(15, 255);
            this.addOpB.Name = "addOpB";
            this.addOpB.Size = new System.Drawing.Size(151, 23);
            this.addOpB.TabIndex = 3;
            this.addOpB.Text = "Add Option";
            this.addOpB.UseVisualStyleBackColor = true;
            this.addOpB.Click += new System.EventHandler(this.addOpB_Click);
            // 
            // remOpB
            // 
            this.remOpB.Location = new System.Drawing.Point(172, 255);
            this.remOpB.Name = "remOpB";
            this.remOpB.Size = new System.Drawing.Size(153, 23);
            this.remOpB.TabIndex = 4;
            this.remOpB.Text = "Remove Option";
            this.remOpB.UseVisualStyleBackColor = true;
            this.remOpB.Click += new System.EventHandler(this.remOpB_Click);
            // 
            // saveAndAdd
            // 
            this.saveAndAdd.Location = new System.Drawing.Point(15, 284);
            this.saveAndAdd.Name = "saveAndAdd";
            this.saveAndAdd.Size = new System.Drawing.Size(310, 23);
            this.saveAndAdd.TabIndex = 4;
            this.saveAndAdd.Text = "Add Student";
            this.saveAndAdd.UseVisualStyleBackColor = true;
            this.saveAndAdd.Click += new System.EventHandler(this.saveAndAdd_Click);
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(15, 313);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(310, 23);
            this.cancelB.TabIndex = 5;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // StudV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 348);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.saveAndAdd);
            this.Controls.Add(this.remOpB);
            this.Controls.Add(this.addOpB);
            this.Controls.Add(optList);
            this.Controls.Add(this.tCnp);
            this.Controls.Add(this.tPrenume);
            this.Controls.Add(this.tNume);
            this.Controls.Add(this.soptiuni);
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
        private System.Windows.Forms.Label soptiuni;
        private System.Windows.Forms.Button addOpB;
        private System.Windows.Forms.Button remOpB;
        private System.Windows.Forms.Button saveAndAdd;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nume;
        private System.Windows.Forms.ColumnHeader tip;
        public System.Windows.Forms.TextBox tNume;
        public System.Windows.Forms.TextBox tPrenume;
        public System.Windows.Forms.TextBox tCnp;
        private System.Windows.Forms.Button cancelB;
        public static System.Windows.Forms.ListView optList;
    }
}