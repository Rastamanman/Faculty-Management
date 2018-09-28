namespace Proiect.View
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
            this.studentsList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addStudB = new System.Windows.Forms.Button();
            this.remStudB = new System.Windows.Forms.Button();
            this.viewStudB = new System.Windows.Forms.Button();
            this.studentInfo = new System.Windows.Forms.Panel();
            this.editStudB = new System.Windows.Forms.Button();
            this.saveChB = new System.Windows.Forms.Button();
            this.optiuniList = new System.Windows.Forms.ListView();
            this.idOp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numeOp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipOp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notaOP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeOptionB = new System.Windows.Forms.Button();
            this.addOptionB = new System.Windows.Forms.Button();
            this.cnp = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.soptiuni = new System.Windows.Forms.Label();
            this.ssex = new System.Windows.Forms.Label();
            this.sstatus = new System.Windows.Forms.Label();
            this.scnp = new System.Windows.Forms.Label();
            this.sprenume = new System.Windows.Forms.Label();
            this.prenume = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.Label();
            this.index = new System.Windows.Forms.Label();
            this.sindex = new System.Windows.Forms.Label();
            this.snume = new System.Windows.Forms.Label();
            this.sstud = new System.Windows.Forms.Label();
            this.specs = new System.Windows.Forms.TabPage();
            this.specList = new System.Windows.Forms.ListView();
            this.idSpecL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numeSpecL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.specInfo = new System.Windows.Forms.Panel();
            this.editSpecB = new System.Windows.Forms.Button();
            this.candList = new System.Windows.Forms.ListView();
            this.idStud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numeCand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenCand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.testsList = new System.Windows.Forms.ListView();
            this.idCerinta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.denumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.requirement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pondere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveTestsB = new System.Windows.Forms.Button();
            this.remTestB = new System.Windows.Forms.Button();
            this.seeAdmB = new System.Windows.Forms.Button();
            this.seeCandB = new System.Windows.Forms.Button();
            this.addTestB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scandidati = new System.Windows.Forms.Label();
            this.specBugSize = new System.Windows.Forms.Label();
            this.specTaxSize = new System.Windows.Forms.Label();
            this.specSize = new System.Windows.Forms.Label();
            this.specName = new System.Windows.Forms.Label();
            this.specID = new System.Windows.Forms.Label();
            this.sspecIndex = new System.Windows.Forms.Label();
            this.sname = new System.Windows.Forms.Label();
            this.remSpecB = new System.Windows.Forms.Button();
            this.addSpecB = new System.Windows.Forms.Button();
            this.viewSpecB = new System.Windows.Forms.Button();
            this.sspecs = new System.Windows.Forms.Label();
            this.editOpB = new System.Windows.Forms.Button();
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
            this.mainTab.Size = new System.Drawing.Size(784, 404);
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
            this.students.Size = new System.Drawing.Size(776, 378);
            this.students.TabIndex = 0;
            this.students.Text = "Students";
            this.students.UseVisualStyleBackColor = true;
            // 
            // studentsList
            // 
            this.studentsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.prename});
            this.studentsList.FullRowSelect = true;
            this.studentsList.Location = new System.Drawing.Point(6, 19);
            this.studentsList.Name = "studentsList";
            this.studentsList.Size = new System.Drawing.Size(318, 317);
            this.studentsList.TabIndex = 3;
            this.studentsList.UseCompatibleStateImageBehavior = false;
            this.studentsList.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // name
            // 
            this.name.Text = "Nume";
            this.name.Width = 115;
            // 
            // prename
            // 
            this.prename.Text = "Prenume";
            this.prename.Width = 135;
            // 
            // addStudB
            // 
            this.addStudB.Location = new System.Drawing.Point(222, 342);
            this.addStudB.Name = "addStudB";
            this.addStudB.Size = new System.Drawing.Size(102, 23);
            this.addStudB.TabIndex = 2;
            this.addStudB.Text = "Add New Student";
            this.addStudB.UseVisualStyleBackColor = true;
            this.addStudB.Click += new System.EventHandler(this.addStudB_Click);
            // 
            // remStudB
            // 
            this.remStudB.Location = new System.Drawing.Point(114, 342);
            this.remStudB.Name = "remStudB";
            this.remStudB.Size = new System.Drawing.Size(102, 23);
            this.remStudB.TabIndex = 2;
            this.remStudB.Text = "Remove Student";
            this.remStudB.UseVisualStyleBackColor = true;
            this.remStudB.Click += new System.EventHandler(this.remStudB_Click);
            // 
            // viewStudB
            // 
            this.viewStudB.Location = new System.Drawing.Point(6, 342);
            this.viewStudB.Name = "viewStudB";
            this.viewStudB.Size = new System.Drawing.Size(102, 23);
            this.viewStudB.TabIndex = 2;
            this.viewStudB.Text = "View Student";
            this.viewStudB.UseVisualStyleBackColor = true;
            this.viewStudB.Click += new System.EventHandler(this.viewStudB_Click);
            // 
            // studentInfo
            // 
            this.studentInfo.Controls.Add(this.editOpB);
            this.studentInfo.Controls.Add(this.editStudB);
            this.studentInfo.Controls.Add(this.saveChB);
            this.studentInfo.Controls.Add(this.optiuniList);
            this.studentInfo.Controls.Add(this.removeOptionB);
            this.studentInfo.Controls.Add(this.addOptionB);
            this.studentInfo.Controls.Add(this.cnp);
            this.studentInfo.Controls.Add(this.sex);
            this.studentInfo.Controls.Add(this.status);
            this.studentInfo.Controls.Add(this.soptiuni);
            this.studentInfo.Controls.Add(this.ssex);
            this.studentInfo.Controls.Add(this.sstatus);
            this.studentInfo.Controls.Add(this.scnp);
            this.studentInfo.Controls.Add(this.sprenume);
            this.studentInfo.Controls.Add(this.prenume);
            this.studentInfo.Controls.Add(this.nume);
            this.studentInfo.Controls.Add(this.index);
            this.studentInfo.Controls.Add(this.sindex);
            this.studentInfo.Controls.Add(this.snume);
            this.studentInfo.Location = new System.Drawing.Point(330, 7);
            this.studentInfo.Name = "studentInfo";
            this.studentInfo.Size = new System.Drawing.Size(410, 358);
            this.studentInfo.TabIndex = 0;
            // 
            // editStudB
            // 
            this.editStudB.Location = new System.Drawing.Point(16, 332);
            this.editStudB.Name = "editStudB";
            this.editStudB.Size = new System.Drawing.Size(378, 23);
            this.editStudB.TabIndex = 5;
            this.editStudB.Text = "Edit Student Info";
            this.editStudB.UseVisualStyleBackColor = true;
            this.editStudB.Click += new System.EventHandler(this.editStudB_Click);
            // 
            // saveChB
            // 
            this.saveChB.Location = new System.Drawing.Point(308, 303);
            this.saveChB.Name = "saveChB";
            this.saveChB.Size = new System.Drawing.Size(86, 23);
            this.saveChB.TabIndex = 4;
            this.saveChB.Text = "Save Changes";
            this.saveChB.UseVisualStyleBackColor = true;
            this.saveChB.Click += new System.EventHandler(this.saveChB_Click);
            // 
            // optiuniList
            // 
            this.optiuniList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idOp,
            this.numeOp,
            this.tipOp,
            this.notaOP});
            this.optiuniList.FullRowSelect = true;
            this.optiuniList.Location = new System.Drawing.Point(16, 166);
            this.optiuniList.Name = "optiuniList";
            this.optiuniList.Size = new System.Drawing.Size(378, 132);
            this.optiuniList.TabIndex = 3;
            this.optiuniList.UseCompatibleStateImageBehavior = false;
            this.optiuniList.View = System.Windows.Forms.View.Details;
            // 
            // idOp
            // 
            this.idOp.Text = "ID";
            // 
            // numeOp
            // 
            this.numeOp.Text = "Nume Specializare";
            this.numeOp.Width = 173;
            // 
            // tipOp
            // 
            this.tipOp.Text = "Taxa/Buget";
            this.tipOp.Width = 72;
            // 
            // notaOP
            // 
            this.notaOP.Text = "Nota";
            // 
            // removeOptionB
            // 
            this.removeOptionB.Location = new System.Drawing.Point(116, 304);
            this.removeOptionB.Name = "removeOptionB";
            this.removeOptionB.Size = new System.Drawing.Size(90, 23);
            this.removeOptionB.TabIndex = 2;
            this.removeOptionB.Text = "Remove Option";
            this.removeOptionB.UseVisualStyleBackColor = true;
            this.removeOptionB.Click += new System.EventHandler(this.removeOptionB_Click);
            // 
            // addOptionB
            // 
            this.addOptionB.Location = new System.Drawing.Point(16, 304);
            this.addOptionB.Name = "addOptionB";
            this.addOptionB.Size = new System.Drawing.Size(94, 23);
            this.addOptionB.TabIndex = 2;
            this.addOptionB.Text = "Add New Option";
            this.addOptionB.UseVisualStyleBackColor = true;
            this.addOptionB.Click += new System.EventHandler(this.addOptionB_Click);
            // 
            // cnp
            // 
            this.cnp.AutoSize = true;
            this.cnp.Location = new System.Drawing.Point(70, 80);
            this.cnp.Name = "cnp";
            this.cnp.Size = new System.Drawing.Size(10, 13);
            this.cnp.TabIndex = 0;
            this.cnp.Text = ".";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(70, 103);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(10, 13);
            this.sex.TabIndex = 0;
            this.sex.Text = ".";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(70, 126);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(10, 13);
            this.status.TabIndex = 0;
            this.status.Text = ".";
            // 
            // soptiuni
            // 
            this.soptiuni.AutoSize = true;
            this.soptiuni.Location = new System.Drawing.Point(12, 150);
            this.soptiuni.Name = "soptiuni";
            this.soptiuni.Size = new System.Drawing.Size(68, 13);
            this.soptiuni.TabIndex = 0;
            this.soptiuni.Text = "Lista Optiuni:";
            // 
            // ssex
            // 
            this.ssex.AutoSize = true;
            this.ssex.Location = new System.Drawing.Point(12, 103);
            this.ssex.Name = "ssex";
            this.ssex.Size = new System.Drawing.Size(28, 13);
            this.ssex.TabIndex = 0;
            this.ssex.Text = "Sex:";
            // 
            // sstatus
            // 
            this.sstatus.AutoSize = true;
            this.sstatus.Location = new System.Drawing.Point(13, 126);
            this.sstatus.Name = "sstatus";
            this.sstatus.Size = new System.Drawing.Size(40, 13);
            this.sstatus.TabIndex = 0;
            this.sstatus.Text = "Status:";
            // 
            // scnp
            // 
            this.scnp.AutoSize = true;
            this.scnp.Location = new System.Drawing.Point(12, 80);
            this.scnp.Name = "scnp";
            this.scnp.Size = new System.Drawing.Size(32, 13);
            this.scnp.TabIndex = 0;
            this.scnp.Text = "CNP:";
            // 
            // sprenume
            // 
            this.sprenume.AutoSize = true;
            this.sprenume.Location = new System.Drawing.Point(12, 57);
            this.sprenume.Name = "sprenume";
            this.sprenume.Size = new System.Drawing.Size(52, 13);
            this.sprenume.TabIndex = 0;
            this.sprenume.Text = "Prenume:";
            // 
            // prenume
            // 
            this.prenume.AutoSize = true;
            this.prenume.Location = new System.Drawing.Point(70, 57);
            this.prenume.Name = "prenume";
            this.prenume.Size = new System.Drawing.Size(10, 13);
            this.prenume.TabIndex = 0;
            this.prenume.Text = ".";
            // 
            // nume
            // 
            this.nume.AutoSize = true;
            this.nume.Location = new System.Drawing.Point(70, 33);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(10, 13);
            this.nume.TabIndex = 0;
            this.nume.Text = ".";
            // 
            // index
            // 
            this.index.AutoSize = true;
            this.index.Location = new System.Drawing.Point(70, 12);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(10, 13);
            this.index.TabIndex = 0;
            this.index.Text = ".";
            // 
            // sindex
            // 
            this.sindex.AutoSize = true;
            this.sindex.Location = new System.Drawing.Point(12, 12);
            this.sindex.Name = "sindex";
            this.sindex.Size = new System.Drawing.Size(21, 13);
            this.sindex.TabIndex = 0;
            this.sindex.Text = "ID:";
            // 
            // snume
            // 
            this.snume.AutoSize = true;
            this.snume.Location = new System.Drawing.Point(12, 33);
            this.snume.Name = "snume";
            this.snume.Size = new System.Drawing.Size(38, 13);
            this.snume.TabIndex = 0;
            this.snume.Text = "Nume:";
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
            // specs
            // 
            this.specs.Controls.Add(this.specList);
            this.specs.Controls.Add(this.specInfo);
            this.specs.Controls.Add(this.remSpecB);
            this.specs.Controls.Add(this.addSpecB);
            this.specs.Controls.Add(this.viewSpecB);
            this.specs.Controls.Add(this.sspecs);
            this.specs.Location = new System.Drawing.Point(4, 22);
            this.specs.Name = "specs";
            this.specs.Padding = new System.Windows.Forms.Padding(3);
            this.specs.Size = new System.Drawing.Size(776, 378);
            this.specs.TabIndex = 1;
            this.specs.Text = "Specs";
            this.specs.UseVisualStyleBackColor = true;
            // 
            // specList
            // 
            this.specList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idSpecL,
            this.numeSpecL});
            this.specList.FullRowSelect = true;
            this.specList.Location = new System.Drawing.Point(10, 24);
            this.specList.Name = "specList";
            this.specList.Size = new System.Drawing.Size(305, 319);
            this.specList.TabIndex = 4;
            this.specList.UseCompatibleStateImageBehavior = false;
            this.specList.View = System.Windows.Forms.View.Details;
            // 
            // idSpecL
            // 
            this.idSpecL.Text = "ID";
            // 
            // numeSpecL
            // 
            this.numeSpecL.Text = "Denumire";
            this.numeSpecL.Width = 240;
            // 
            // specInfo
            // 
            this.specInfo.Controls.Add(this.editSpecB);
            this.specInfo.Controls.Add(this.candList);
            this.specInfo.Controls.Add(this.testsList);
            this.specInfo.Controls.Add(this.saveTestsB);
            this.specInfo.Controls.Add(this.remTestB);
            this.specInfo.Controls.Add(this.seeAdmB);
            this.specInfo.Controls.Add(this.seeCandB);
            this.specInfo.Controls.Add(this.addTestB);
            this.specInfo.Controls.Add(this.label4);
            this.specInfo.Controls.Add(this.label2);
            this.specInfo.Controls.Add(this.label1);
            this.specInfo.Controls.Add(this.label3);
            this.specInfo.Controls.Add(this.scandidati);
            this.specInfo.Controls.Add(this.specBugSize);
            this.specInfo.Controls.Add(this.specTaxSize);
            this.specInfo.Controls.Add(this.specSize);
            this.specInfo.Controls.Add(this.specName);
            this.specInfo.Controls.Add(this.specID);
            this.specInfo.Controls.Add(this.sspecIndex);
            this.specInfo.Controls.Add(this.sname);
            this.specInfo.Location = new System.Drawing.Point(321, 7);
            this.specInfo.Name = "specInfo";
            this.specInfo.Size = new System.Drawing.Size(445, 365);
            this.specInfo.TabIndex = 3;
            // 
            // editSpecB
            // 
            this.editSpecB.Location = new System.Drawing.Point(360, 8);
            this.editSpecB.Name = "editSpecB";
            this.editSpecB.Size = new System.Drawing.Size(75, 66);
            this.editSpecB.TabIndex = 4;
            this.editSpecB.Text = "Edit Spec";
            this.editSpecB.UseVisualStyleBackColor = true;
            this.editSpecB.Click += new System.EventHandler(this.editSpecB_Click);
            // 
            // candList
            // 
            this.candList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idStud,
            this.numeCand,
            this.prenCand});
            this.candList.FullRowSelect = true;
            this.candList.Location = new System.Drawing.Point(16, 255);
            this.candList.Name = "candList";
            this.candList.Size = new System.Drawing.Size(425, 97);
            this.candList.TabIndex = 3;
            this.candList.UseCompatibleStateImageBehavior = false;
            this.candList.View = System.Windows.Forms.View.Details;
            // 
            // idStud
            // 
            this.idStud.Text = "ID";
            this.idStud.Width = 40;
            // 
            // numeCand
            // 
            this.numeCand.Text = "Nume";
            this.numeCand.Width = 150;
            // 
            // prenCand
            // 
            this.prenCand.Text = "Prenume";
            this.prenCand.Width = 227;
            // 
            // testsList
            // 
            this.testsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCerinta,
            this.denumire,
            this.requirement,
            this.pondere});
            this.testsList.FullRowSelect = true;
            this.testsList.Location = new System.Drawing.Point(16, 110);
            this.testsList.Name = "testsList";
            this.testsList.Size = new System.Drawing.Size(338, 97);
            this.testsList.TabIndex = 2;
            this.testsList.UseCompatibleStateImageBehavior = false;
            this.testsList.View = System.Windows.Forms.View.Details;
            // 
            // idCerinta
            // 
            this.idCerinta.Text = "ID";
            this.idCerinta.Width = 40;
            // 
            // denumire
            // 
            this.denumire.Text = "Denumire";
            this.denumire.Width = 120;
            // 
            // requirement
            // 
            this.requirement.Text = "Cerinta Minima";
            this.requirement.Width = 100;
            // 
            // pondere
            // 
            this.pondere.Text = "Pondere(%)";
            this.pondere.Width = 70;
            // 
            // saveTestsB
            // 
            this.saveTestsB.Location = new System.Drawing.Point(360, 170);
            this.saveTestsB.Name = "saveTestsB";
            this.saveTestsB.Size = new System.Drawing.Size(78, 37);
            this.saveTestsB.TabIndex = 2;
            this.saveTestsB.Text = "Save changes";
            this.saveTestsB.UseVisualStyleBackColor = true;
            this.saveTestsB.Click += new System.EventHandler(this.saveTestsB_Click);
            // 
            // remTestB
            // 
            this.remTestB.Location = new System.Drawing.Point(360, 140);
            this.remTestB.Name = "remTestB";
            this.remTestB.Size = new System.Drawing.Size(78, 24);
            this.remTestB.TabIndex = 2;
            this.remTestB.Text = "Remove test";
            this.remTestB.UseVisualStyleBackColor = true;
            this.remTestB.Click += new System.EventHandler(this.remTestB_Click);
            // 
            // seeAdmB
            // 
            this.seeAdmB.Location = new System.Drawing.Point(151, 213);
            this.seeAdmB.Name = "seeAdmB";
            this.seeAdmB.Size = new System.Drawing.Size(121, 24);
            this.seeAdmB.TabIndex = 2;
            this.seeAdmB.Text = "Vezi Admisi";
            this.seeAdmB.UseVisualStyleBackColor = true;
            this.seeAdmB.Click += new System.EventHandler(this.seeAdmB_Click);
            // 
            // seeCandB
            // 
            this.seeCandB.Location = new System.Drawing.Point(16, 213);
            this.seeCandB.Name = "seeCandB";
            this.seeCandB.Size = new System.Drawing.Size(129, 24);
            this.seeCandB.TabIndex = 2;
            this.seeCandB.Text = "Vezi Candidati";
            this.seeCandB.UseVisualStyleBackColor = true;
            this.seeCandB.Click += new System.EventHandler(this.seeCandB_Click);
            // 
            // addTestB
            // 
            this.addTestB.Location = new System.Drawing.Point(360, 110);
            this.addTestB.Name = "addTestB";
            this.addTestB.Size = new System.Drawing.Size(78, 24);
            this.addTestB.TabIndex = 2;
            this.addTestB.Text = "Add new test";
            this.addTestB.UseVisualStyleBackColor = true;
            this.addTestB.Click += new System.EventHandler(this.addTestB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Numar Locuri Buget:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numar Locuri Taxa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numar Locuri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Modalitati de admitere:";
            // 
            // scandidati
            // 
            this.scandidati.AutoSize = true;
            this.scandidati.Location = new System.Drawing.Point(13, 238);
            this.scandidati.Name = "scandidati";
            this.scandidati.Size = new System.Drawing.Size(79, 13);
            this.scandidati.TabIndex = 1;
            this.scandidati.Text = "Lista Candidati:";
            // 
            // specBugSize
            // 
            this.specBugSize.AutoSize = true;
            this.specBugSize.Location = new System.Drawing.Point(132, 78);
            this.specBugSize.Name = "specBugSize";
            this.specBugSize.Size = new System.Drawing.Size(10, 13);
            this.specBugSize.TabIndex = 1;
            this.specBugSize.Text = ".";
            // 
            // specTaxSize
            // 
            this.specTaxSize.AutoSize = true;
            this.specTaxSize.Location = new System.Drawing.Point(132, 61);
            this.specTaxSize.Name = "specTaxSize";
            this.specTaxSize.Size = new System.Drawing.Size(10, 13);
            this.specTaxSize.TabIndex = 1;
            this.specTaxSize.Text = ".";
            // 
            // specSize
            // 
            this.specSize.AutoSize = true;
            this.specSize.Location = new System.Drawing.Point(132, 43);
            this.specSize.Name = "specSize";
            this.specSize.Size = new System.Drawing.Size(10, 13);
            this.specSize.TabIndex = 1;
            this.specSize.Text = ".";
            // 
            // specName
            // 
            this.specName.AutoSize = true;
            this.specName.Location = new System.Drawing.Point(132, 25);
            this.specName.Name = "specName";
            this.specName.Size = new System.Drawing.Size(10, 13);
            this.specName.TabIndex = 1;
            this.specName.Text = ".";
            // 
            // specID
            // 
            this.specID.AutoSize = true;
            this.specID.Location = new System.Drawing.Point(132, 8);
            this.specID.Name = "specID";
            this.specID.Size = new System.Drawing.Size(10, 13);
            this.specID.TabIndex = 1;
            this.specID.Text = ".";
            // 
            // sspecIndex
            // 
            this.sspecIndex.AutoSize = true;
            this.sspecIndex.Location = new System.Drawing.Point(13, 8);
            this.sspecIndex.Name = "sspecIndex";
            this.sspecIndex.Size = new System.Drawing.Size(21, 13);
            this.sspecIndex.TabIndex = 1;
            this.sspecIndex.Text = "ID:";
            // 
            // sname
            // 
            this.sname.AutoSize = true;
            this.sname.Location = new System.Drawing.Point(13, 25);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(38, 13);
            this.sname.TabIndex = 1;
            this.sname.Text = "Nume:";
            // 
            // remSpecB
            // 
            this.remSpecB.Location = new System.Drawing.Point(216, 349);
            this.remSpecB.Name = "remSpecB";
            this.remSpecB.Size = new System.Drawing.Size(99, 23);
            this.remSpecB.TabIndex = 2;
            this.remSpecB.Text = "Remove Spec";
            this.remSpecB.UseVisualStyleBackColor = true;
            this.remSpecB.Click += new System.EventHandler(this.remSpecB_Click);
            // 
            // addSpecB
            // 
            this.addSpecB.Location = new System.Drawing.Point(111, 349);
            this.addSpecB.Name = "addSpecB";
            this.addSpecB.Size = new System.Drawing.Size(99, 23);
            this.addSpecB.TabIndex = 2;
            this.addSpecB.Text = "Add New Spec";
            this.addSpecB.UseVisualStyleBackColor = true;
            this.addSpecB.Click += new System.EventHandler(this.addSpecB_Click);
            // 
            // viewSpecB
            // 
            this.viewSpecB.Location = new System.Drawing.Point(6, 349);
            this.viewSpecB.Name = "viewSpecB";
            this.viewSpecB.Size = new System.Drawing.Size(99, 23);
            this.viewSpecB.TabIndex = 2;
            this.viewSpecB.Text = "View Spec Info";
            this.viewSpecB.UseVisualStyleBackColor = true;
            this.viewSpecB.Click += new System.EventHandler(this.viewSpecB_Click);
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
            // editOpB
            // 
            this.editOpB.Location = new System.Drawing.Point(212, 304);
            this.editOpB.Name = "editOpB";
            this.editOpB.Size = new System.Drawing.Size(90, 23);
            this.editOpB.TabIndex = 6;
            this.editOpB.Text = "Edit Option";
            this.editOpB.UseVisualStyleBackColor = true;
            this.editOpB.Click += new System.EventHandler(this.editOpB_Click);
            // 
            // FacultyV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 443);
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
        private System.Windows.Forms.Label soptiuni;
        private System.Windows.Forms.Button addStudB;
        private System.Windows.Forms.Button remStudB;
        private System.Windows.Forms.Button viewStudB;
        private System.Windows.Forms.Label sstud;
        private System.Windows.Forms.Button viewSpecB;
        private System.Windows.Forms.Label sspecs;
        private System.Windows.Forms.Panel specInfo;
        private System.Windows.Forms.Label sname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView testsList;
        private System.Windows.Forms.Label scandidati;
        private System.Windows.Forms.Label specTaxSize;
        private System.Windows.Forms.Label specSize;
        private System.Windows.Forms.Label specName;
        private System.Windows.Forms.ColumnHeader denumire;
        private System.Windows.Forms.ColumnHeader requirement;
        private System.Windows.Forms.Button saveTestsB;
        private System.Windows.Forms.Button remTestB;
        private System.Windows.Forms.Button addTestB;
        private System.Windows.Forms.Button remSpecB;
        private System.Windows.Forms.Button addSpecB;
        private System.Windows.Forms.ListView specList;
        private System.Windows.Forms.ListView studentsList;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader prename;
        private System.Windows.Forms.Label index;
        private System.Windows.Forms.Label sindex;
        private System.Windows.Forms.ListView optiuniList;
        private System.Windows.Forms.ColumnHeader idOp;
        private System.Windows.Forms.ColumnHeader numeOp;
        private System.Windows.Forms.ColumnHeader tipOp;
        private System.Windows.Forms.ColumnHeader notaOP;
        private System.Windows.Forms.ColumnHeader idSpecL;
        private System.Windows.Forms.ColumnHeader numeSpecL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label specBugSize;
        private System.Windows.Forms.Button seeAdmB;
        private System.Windows.Forms.Button seeCandB;
        private System.Windows.Forms.ListView candList;
        private System.Windows.Forms.ColumnHeader idCerinta;
        private System.Windows.Forms.ColumnHeader pondere;
        private System.Windows.Forms.ColumnHeader idStud;
        private System.Windows.Forms.ColumnHeader numeCand;
        private System.Windows.Forms.ColumnHeader prenCand;
        private System.Windows.Forms.Label specID;
        private System.Windows.Forms.Label sspecIndex;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Label ssex;
        private System.Windows.Forms.Button saveChB;
        private System.Windows.Forms.Button editStudB;
        private System.Windows.Forms.Button editSpecB;
        private System.Windows.Forms.Button editOpB;
    }
}