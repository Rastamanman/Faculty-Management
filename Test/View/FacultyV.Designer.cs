namespace Test.View
{
    partial class FacultyV
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
            this.mainTab = new System.Windows.Forms.TabControl();
            this.students = new System.Windows.Forms.TabPage();
            this.studentsList = new System.Windows.Forms.ListBox();
            this.addStudB = new System.Windows.Forms.Button();
            this.remStudB = new System.Windows.Forms.Button();
            this.viewStudB = new System.Windows.Forms.Button();
            this.studentInfo = new System.Windows.Forms.Panel();
            this.removeOptionB = new System.Windows.Forms.Button();
            this.addOptionB = new System.Windows.Forms.Button();
            this.optiuni = new System.Windows.Forms.ListBox();
            this.cnp = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.soptiuni = new System.Windows.Forms.Label();
            this.sstatus = new System.Windows.Forms.Label();
            this.scnp = new System.Windows.Forms.Label();
            this.sprenume = new System.Windows.Forms.Label();
            this.prenume = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.Label();
            this.snume = new System.Windows.Forms.Label();
            this.specs = new System.Windows.Forms.TabPage();
            this.sstud = new System.Windows.Forms.Label();
            this.specList = new System.Windows.Forms.ListBox();
            this.sspecs = new System.Windows.Forms.Label();
            this.viewSpecB = new System.Windows.Forms.Button();
            this.specInfo = new System.Windows.Forms.Panel();
            this.sname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.specName = new System.Windows.Forms.Label();
            this.scandidati = new System.Windows.Forms.Label();
            this.specSize = new System.Windows.Forms.Label();
            this.specTaxSize = new System.Windows.Forms.Label();
            this.tests = new System.Windows.Forms.ListView();
            this.denumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.requirement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.candList = new System.Windows.Forms.ListBox();
            this.addSpecB = new System.Windows.Forms.Button();
            this.remSpecB = new System.Windows.Forms.Button();
            this.addTestB = new System.Windows.Forms.Button();
            this.remTestB = new System.Windows.Forms.Button();
            this.saveTestsB = new System.Windows.Forms.Button();
            this.mainTab.SuspendLayout();
            this.students.SuspendLayout();
            this.studentInfo.SuspendLayout();
            this.specs.SuspendLayout();
            this.specInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.students);
            this.mainTab.Controls.Add(this.specs);
            this.mainTab.Location = new System.Drawing.Point(12, 34);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(776, 404);
            this.mainTab.TabIndex = 0;
            // 
            // students
            // 
            this.students.Controls.Add(this.studentsList);
            this.students.Controls.Add(this.addStudB);
            this.students.Controls.Add(this.remStudB);
            this.students.Controls.Add(this.viewStudB);
            this.students.Controls.Add(this.studentInfo);
            this.students.Controls.Add(this.sstud);
            this.students.Location = new System.Drawing.Point(4, 22);
            this.students.Name = "students";
            this.students.Padding = new System.Windows.Forms.Padding(3);
            this.students.Size = new System.Drawing.Size(768, 378);
            this.students.TabIndex = 0;
            this.students.Text = "Students";
            this.students.UseVisualStyleBackColor = true;
            this.students.Click += new System.EventHandler(this.students_Click);
            // 
            // studentsList
            // 
            this.studentsList.FormattingEnabled = true;
            this.studentsList.Location = new System.Drawing.Point(7, 20);
            this.studentsList.Name = "studentsList";
            this.studentsList.Size = new System.Drawing.Size(317, 316);
            this.studentsList.TabIndex = 1;
            // 
            // addStudB
            // 
            this.addStudB.Location = new System.Drawing.Point(222, 342);
            this.addStudB.Name = "addStudB";
            this.addStudB.Size = new System.Drawing.Size(102, 23);
            this.addStudB.TabIndex = 2;
            this.addStudB.Text = "Add New Student";
            this.addStudB.UseVisualStyleBackColor = true;
            // 
            // remStudB
            // 
            this.remStudB.Location = new System.Drawing.Point(114, 342);
            this.remStudB.Name = "remStudB";
            this.remStudB.Size = new System.Drawing.Size(102, 23);
            this.remStudB.TabIndex = 2;
            this.remStudB.Text = "Remove Student";
            this.remStudB.UseVisualStyleBackColor = true;
            // 
            // viewStudB
            // 
            this.viewStudB.Location = new System.Drawing.Point(6, 342);
            this.viewStudB.Name = "viewStudB";
            this.viewStudB.Size = new System.Drawing.Size(102, 23);
            this.viewStudB.TabIndex = 2;
            this.viewStudB.Text = "View Student";
            this.viewStudB.UseVisualStyleBackColor = true;
            // 
            // studentInfo
            // 
            this.studentInfo.Controls.Add(this.removeOptionB);
            this.studentInfo.Controls.Add(this.addOptionB);
            this.studentInfo.Controls.Add(this.optiuni);
            this.studentInfo.Controls.Add(this.cnp);
            this.studentInfo.Controls.Add(this.status);
            this.studentInfo.Controls.Add(this.soptiuni);
            this.studentInfo.Controls.Add(this.sstatus);
            this.studentInfo.Controls.Add(this.scnp);
            this.studentInfo.Controls.Add(this.sprenume);
            this.studentInfo.Controls.Add(this.prenume);
            this.studentInfo.Controls.Add(this.nume);
            this.studentInfo.Controls.Add(this.snume);
            this.studentInfo.Location = new System.Drawing.Point(330, 7);
            this.studentInfo.Name = "studentInfo";
            this.studentInfo.Size = new System.Drawing.Size(432, 358);
            this.studentInfo.TabIndex = 0;
            // 
            // removeOptionB
            // 
            this.removeOptionB.Location = new System.Drawing.Point(124, 292);
            this.removeOptionB.Name = "removeOptionB";
            this.removeOptionB.Size = new System.Drawing.Size(102, 23);
            this.removeOptionB.TabIndex = 2;
            this.removeOptionB.Text = "Remove Option";
            this.removeOptionB.UseVisualStyleBackColor = true;
            // 
            // addOptionB
            // 
            this.addOptionB.Location = new System.Drawing.Point(16, 292);
            this.addOptionB.Name = "addOptionB";
            this.addOptionB.Size = new System.Drawing.Size(102, 23);
            this.addOptionB.TabIndex = 2;
            this.addOptionB.Text = "Add New Option";
            this.addOptionB.UseVisualStyleBackColor = true;
            // 
            // optiuni
            // 
            this.optiuni.FormattingEnabled = true;
            this.optiuni.Location = new System.Drawing.Point(15, 138);
            this.optiuni.Name = "optiuni";
            this.optiuni.Size = new System.Drawing.Size(211, 147);
            this.optiuni.TabIndex = 1;
            // 
            // cnp
            // 
            this.cnp.AutoSize = true;
            this.cnp.Location = new System.Drawing.Point(70, 70);
            this.cnp.Name = "cnp";
            this.cnp.Size = new System.Drawing.Size(61, 13);
            this.cnp.TabIndex = 0;
            this.cnp.Text = "defaultCNP";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(70, 95);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(69, 13);
            this.status.TabIndex = 0;
            this.status.Text = "defaultStatus";
            // 
            // soptiuni
            // 
            this.soptiuni.AutoSize = true;
            this.soptiuni.Location = new System.Drawing.Point(12, 122);
            this.soptiuni.Name = "soptiuni";
            this.soptiuni.Size = new System.Drawing.Size(68, 13);
            this.soptiuni.TabIndex = 0;
            this.soptiuni.Text = "Lista Optiuni:";
            // 
            // sstatus
            // 
            this.sstatus.AutoSize = true;
            this.sstatus.Location = new System.Drawing.Point(13, 95);
            this.sstatus.Name = "sstatus";
            this.sstatus.Size = new System.Drawing.Size(40, 13);
            this.sstatus.TabIndex = 0;
            this.sstatus.Text = "Status:";
            // 
            // scnp
            // 
            this.scnp.AutoSize = true;
            this.scnp.Location = new System.Drawing.Point(13, 70);
            this.scnp.Name = "scnp";
            this.scnp.Size = new System.Drawing.Size(32, 13);
            this.scnp.TabIndex = 0;
            this.scnp.Text = "CNP:";
            // 
            // sprenume
            // 
            this.sprenume.AutoSize = true;
            this.sprenume.Location = new System.Drawing.Point(12, 47);
            this.sprenume.Name = "sprenume";
            this.sprenume.Size = new System.Drawing.Size(52, 13);
            this.sprenume.TabIndex = 0;
            this.sprenume.Text = "Prenume:";
            // 
            // prenume
            // 
            this.prenume.AutoSize = true;
            this.prenume.Location = new System.Drawing.Point(70, 47);
            this.prenume.Name = "prenume";
            this.prenume.Size = new System.Drawing.Size(81, 13);
            this.prenume.TabIndex = 0;
            this.prenume.Text = "defaultSurname";
            // 
            // nume
            // 
            this.nume.AutoSize = true;
            this.nume.Location = new System.Drawing.Point(70, 23);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(67, 13);
            this.nume.TabIndex = 0;
            this.nume.Text = "defaultName";
            // 
            // snume
            // 
            this.snume.AutoSize = true;
            this.snume.Location = new System.Drawing.Point(12, 23);
            this.snume.Name = "snume";
            this.snume.Size = new System.Drawing.Size(38, 13);
            this.snume.TabIndex = 0;
            this.snume.Text = "Nume:";
            // 
            // specs
            // 
            this.specs.Controls.Add(this.specInfo);
            this.specs.Controls.Add(this.remSpecB);
            this.specs.Controls.Add(this.addSpecB);
            this.specs.Controls.Add(this.viewSpecB);
            this.specs.Controls.Add(this.sspecs);
            this.specs.Controls.Add(this.specList);
            this.specs.Location = new System.Drawing.Point(4, 22);
            this.specs.Name = "specs";
            this.specs.Padding = new System.Windows.Forms.Padding(3);
            this.specs.Size = new System.Drawing.Size(768, 378);
            this.specs.TabIndex = 1;
            this.specs.Text = "Specs";
            this.specs.UseVisualStyleBackColor = true;
            // 
            // sstud
            // 
            this.sstud.AutoSize = true;
            this.sstud.Location = new System.Drawing.Point(4, 3);
            this.sstud.Name = "sstud";
            this.sstud.Size = new System.Drawing.Size(71, 13);
            this.sstud.TabIndex = 0;
            this.sstud.Text = "Students List:";
            // 
            // specList
            // 
            this.specList.FormattingEnabled = true;
            this.specList.Location = new System.Drawing.Point(7, 28);
            this.specList.Name = "specList";
            this.specList.Size = new System.Drawing.Size(308, 316);
            this.specList.TabIndex = 0;
            // 
            // sspecs
            // 
            this.sspecs.AutoSize = true;
            this.sspecs.Location = new System.Drawing.Point(7, 7);
            this.sspecs.Name = "sspecs";
            this.sspecs.Size = new System.Drawing.Size(63, 13);
            this.sspecs.TabIndex = 1;
            this.sspecs.Text = "Specializari:";
            // 
            // viewSpecB
            // 
            this.viewSpecB.Location = new System.Drawing.Point(6, 349);
            this.viewSpecB.Name = "viewSpecB";
            this.viewSpecB.Size = new System.Drawing.Size(99, 23);
            this.viewSpecB.TabIndex = 2;
            this.viewSpecB.Text = "View Spec Info";
            this.viewSpecB.UseVisualStyleBackColor = true;
            // 
            // specInfo
            // 
            this.specInfo.Controls.Add(this.tests);
            this.specInfo.Controls.Add(this.saveTestsB);
            this.specInfo.Controls.Add(this.remTestB);
            this.specInfo.Controls.Add(this.addTestB);
            this.specInfo.Controls.Add(this.label2);
            this.specInfo.Controls.Add(this.label1);
            this.specInfo.Controls.Add(this.candList);
            this.specInfo.Controls.Add(this.label3);
            this.specInfo.Controls.Add(this.scandidati);
            this.specInfo.Controls.Add(this.specTaxSize);
            this.specInfo.Controls.Add(this.specSize);
            this.specInfo.Controls.Add(this.specName);
            this.specInfo.Controls.Add(this.sname);
            this.specInfo.Location = new System.Drawing.Point(321, 7);
            this.specInfo.Name = "specInfo";
            this.specInfo.Size = new System.Drawing.Size(441, 365);
            this.specInfo.TabIndex = 3;
            // 
            // sname
            // 
            this.sname.AutoSize = true;
            this.sname.Location = new System.Drawing.Point(13, 11);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(38, 13);
            this.sname.TabIndex = 1;
            this.sname.Text = "Nume:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numar Locuri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numar Locuri Taxa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Modalitati de admitere:";
            // 
            // specName
            // 
            this.specName.AutoSize = true;
            this.specName.Location = new System.Drawing.Point(132, 11);
            this.specName.Name = "specName";
            this.specName.Size = new System.Drawing.Size(67, 13);
            this.specName.TabIndex = 1;
            this.specName.Text = "defaultName";
            // 
            // scandidati
            // 
            this.scandidati.AutoSize = true;
            this.scandidati.Location = new System.Drawing.Point(13, 195);
            this.scandidati.Name = "scandidati";
            this.scandidati.Size = new System.Drawing.Size(79, 13);
            this.scandidati.TabIndex = 1;
            this.scandidati.Text = "Lista Candidati:";
            // 
            // specSize
            // 
            this.specSize.AutoSize = true;
            this.specSize.Location = new System.Drawing.Point(132, 34);
            this.specSize.Name = "specSize";
            this.specSize.Size = new System.Drawing.Size(59, 13);
            this.specSize.TabIndex = 1;
            this.specSize.Text = "defaultSize";
            // 
            // specTaxSize
            // 
            this.specTaxSize.AutoSize = true;
            this.specTaxSize.Location = new System.Drawing.Point(132, 56);
            this.specTaxSize.Name = "specTaxSize";
            this.specTaxSize.Size = new System.Drawing.Size(77, 13);
            this.specTaxSize.TabIndex = 1;
            this.specTaxSize.Text = "defaultTaxSize";
            // 
            // tests
            // 
            this.tests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.denumire,
            this.requirement});
            this.tests.Location = new System.Drawing.Point(16, 95);
            this.tests.Name = "tests";
            this.tests.Size = new System.Drawing.Size(338, 97);
            this.tests.TabIndex = 2;
            this.tests.UseCompatibleStateImageBehavior = false;
            // 
            // denumire
            // 
            this.denumire.Text = "Denumire";
            // 
            // requirement
            // 
            this.requirement.Text = "Cerinta";
            // 
            // candList
            // 
            this.candList.FormattingEnabled = true;
            this.candList.Location = new System.Drawing.Point(16, 211);
            this.candList.Name = "candList";
            this.candList.Size = new System.Drawing.Size(422, 108);
            this.candList.TabIndex = 0;
            // 
            // addSpecB
            // 
            this.addSpecB.Location = new System.Drawing.Point(111, 349);
            this.addSpecB.Name = "addSpecB";
            this.addSpecB.Size = new System.Drawing.Size(99, 23);
            this.addSpecB.TabIndex = 2;
            this.addSpecB.Text = "Add New Spec";
            this.addSpecB.UseVisualStyleBackColor = true;
            // 
            // remSpecB
            // 
            this.remSpecB.Location = new System.Drawing.Point(216, 349);
            this.remSpecB.Name = "remSpecB";
            this.remSpecB.Size = new System.Drawing.Size(99, 23);
            this.remSpecB.TabIndex = 2;
            this.remSpecB.Text = "Remove Spec";
            this.remSpecB.UseVisualStyleBackColor = true;
            // 
            // addTestB
            // 
            this.addTestB.Location = new System.Drawing.Point(360, 95);
            this.addTestB.Name = "addTestB";
            this.addTestB.Size = new System.Drawing.Size(78, 24);
            this.addTestB.TabIndex = 2;
            this.addTestB.Text = "Add new test";
            this.addTestB.UseVisualStyleBackColor = true;
            // 
            // remTestB
            // 
            this.remTestB.Location = new System.Drawing.Point(360, 125);
            this.remTestB.Name = "remTestB";
            this.remTestB.Size = new System.Drawing.Size(78, 24);
            this.remTestB.TabIndex = 2;
            this.remTestB.Text = "Remove test";
            this.remTestB.UseVisualStyleBackColor = true;
            // 
            // saveTestsB
            // 
            this.saveTestsB.Location = new System.Drawing.Point(360, 155);
            this.saveTestsB.Name = "saveTestsB";
            this.saveTestsB.Size = new System.Drawing.Size(78, 37);
            this.saveTestsB.TabIndex = 2;
            this.saveTestsB.Text = "Save changes";
            this.saveTestsB.UseVisualStyleBackColor = true;
            // 
            // FacultyV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTab);
            this.Name = "FacultyV";
            this.Text = "Faculty";
            this.Load += new System.EventHandler(this.Faculty_Load);
            this.mainTab.ResumeLayout(false);
            this.students.ResumeLayout(false);
            this.students.PerformLayout();
            this.studentInfo.ResumeLayout(false);
            this.studentInfo.PerformLayout();
            this.specs.ResumeLayout(false);
            this.specs.PerformLayout();
            this.specInfo.ResumeLayout(false);
            this.specInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage students;
        private System.Windows.Forms.Panel studentInfo;
        private System.Windows.Forms.Label sprenume;
        private System.Windows.Forms.Label prenume;
        private System.Windows.Forms.Label nume;
        private System.Windows.Forms.Label snume;
        private System.Windows.Forms.TabPage specs;
        private System.Windows.Forms.Label scnp;
        private System.Windows.Forms.Label cnp;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label sstatus;
        private System.Windows.Forms.Button removeOptionB;
        private System.Windows.Forms.Button addOptionB;
        private System.Windows.Forms.ListBox optiuni;
        private System.Windows.Forms.Label soptiuni;
        private System.Windows.Forms.ListBox studentsList;
        private System.Windows.Forms.Button addStudB;
        private System.Windows.Forms.Button remStudB;
        private System.Windows.Forms.Button viewStudB;
        private System.Windows.Forms.Label sstud;
        private System.Windows.Forms.Button viewSpecB;
        private System.Windows.Forms.Label sspecs;
        private System.Windows.Forms.ListBox specList;
        private System.Windows.Forms.Panel specInfo;
        private System.Windows.Forms.Label sname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView tests;
        private System.Windows.Forms.Label scandidati;
        private System.Windows.Forms.Label specTaxSize;
        private System.Windows.Forms.Label specSize;
        private System.Windows.Forms.Label specName;
        private System.Windows.Forms.ColumnHeader denumire;
        private System.Windows.Forms.ColumnHeader requirement;
        private System.Windows.Forms.Button saveTestsB;
        private System.Windows.Forms.Button remTestB;
        private System.Windows.Forms.Button addTestB;
        private System.Windows.Forms.ListBox candList;
        private System.Windows.Forms.Button remSpecB;
        private System.Windows.Forms.Button addSpecB;
    }
}