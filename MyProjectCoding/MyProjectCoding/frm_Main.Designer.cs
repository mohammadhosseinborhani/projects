namespace MyProjectCoding
{
    partial class frm_Main
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Students = new System.Windows.Forms.TabPage();
            this.lable_students_lastName = new System.Windows.Forms.Label();
            this.lable_students_code = new System.Windows.Forms.Label();
            this.lable_students_age = new System.Windows.Forms.Label();
            this.lable_students_firstName = new System.Windows.Forms.Label();
            this.button_students_search = new System.Windows.Forms.Button();
            this.button_students_clear = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_students_lastName = new System.Windows.Forms.TextBox();
            this.textBox_students_firstName = new System.Windows.Forms.TextBox();
            this.numberBox_students_code = new System.Windows.Forms.NumericUpDown();
            this.numberBox_students_age = new System.Windows.Forms.NumericUpDown();
            this.button_students_delete = new System.Windows.Forms.Button();
            this.button_students_edite = new System.Windows.Forms.Button();
            this.button_students_insert = new System.Windows.Forms.Button();
            this.dataGridView_Students = new System.Windows.Forms.DataGridView();
            this.Student_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_Teachers = new System.Windows.Forms.TabPage();
            this.lable_teachers_lastName = new System.Windows.Forms.Label();
            this.lable_teachers_firstName = new System.Windows.Forms.Label();
            this.button_teachers_search = new System.Windows.Forms.Button();
            this.button_teachers_clear = new System.Windows.Forms.Button();
            this.dataGridView_Teachers = new System.Windows.Forms.DataGridView();
            this.Teacher_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher_Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberBox_teachers_code = new System.Windows.Forms.NumericUpDown();
            this.numberBox_teachers_age = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_teachers_firstName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_teachers_lastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_teachers_delete = new System.Windows.Forms.Button();
            this.button_teachers_edite = new System.Windows.Forms.Button();
            this.button_teachers_insert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage_Lessons = new System.Windows.Forms.TabPage();
            this.lable_writer_lastName = new System.Windows.Forms.Label();
            this.lable_writer_firstName = new System.Windows.Forms.Label();
            this.lable_lessons_name = new System.Windows.Forms.Label();
            this.numberBox_lessons_code = new System.Windows.Forms.NumericUpDown();
            this.button_lessons_search = new System.Windows.Forms.Button();
            this.button_lessons_clear = new System.Windows.Forms.Button();
            this.dataGridView_Lessons = new System.Windows.Forms.DataGridView();
            this.Lesson_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lesson_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Writer_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Writer_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_lesson_delete = new System.Windows.Forms.Button();
            this.button_lessons_edit = new System.Windows.Forms.Button();
            this.textBox_lesson_name = new System.Windows.Forms.TextBox();
            this.textBox_writer_lastName = new System.Windows.Forms.TextBox();
            this.textBox_writer_firstName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button_lessons_insert = new System.Windows.Forms.Button();
            this.tabPage_Choice = new System.Windows.Forms.TabPage();
            this.numberBox_choice_lessonCode = new System.Windows.Forms.NumericUpDown();
            this.numberBox_choice_code = new System.Windows.Forms.NumericUpDown();
            this.numberBox_choice_studentCode = new System.Windows.Forms.NumericUpDown();
            this.numberBox_choice_teacherCode = new System.Windows.Forms.NumericUpDown();
            this.button_choice_search = new System.Windows.Forms.Button();
            this.button_choice_clear = new System.Windows.Forms.Button();
            this.dataGridView_Choice = new System.Windows.Forms.DataGridView();
            this.Choice_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Les_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stu_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tea_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Choice_PrehensionHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_choice_delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button_choice_insert = new System.Windows.Forms.Button();
            this.button_choice_edit = new System.Windows.Forms.Button();
            this.dateTimeSelector_choice_prehensionHistory = new Atf.UI.DateTimeSelector();
            this.timer_students_code = new System.Windows.Forms.Timer(this.components);
            this.button_student_refresh = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox_students_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox_students_age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Students)).BeginInit();
            this.tabPage_Teachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Teachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox_teachers_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox_teachers_age)).BeginInit();
            this.tabPage_Lessons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox_lessons_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lessons)).BeginInit();
            this.tabPage_Choice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox_choice_lessonCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox_choice_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox_choice_studentCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox_choice_teacherCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Choice)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_Students);
            this.tabControl.Controls.Add(this.tabPage_Teachers);
            this.tabControl.Controls.Add(this.tabPage_Lessons);
            this.tabControl.Controls.Add(this.tabPage_Choice);
            this.tabControl.Enabled = false;
            this.tabControl.Location = new System.Drawing.Point(1167, 132);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(890, 388);
            this.tabControl.TabIndex = 1;
            this.tabControl.Visible = false;
            // 
            // tabPage_Students
            // 
            this.tabPage_Students.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Students.Name = "tabPage_Students";
            this.tabPage_Students.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Students.Size = new System.Drawing.Size(882, 362);
            this.tabPage_Students.TabIndex = 0;
            this.tabPage_Students.Text = "دانش آموزان";
            this.tabPage_Students.UseVisualStyleBackColor = true;
            // 
            // lable_students_lastName
            // 
            this.lable_students_lastName.AutoSize = true;
            this.lable_students_lastName.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_students_lastName.ForeColor = System.Drawing.Color.Red;
            this.lable_students_lastName.Location = new System.Drawing.Point(546, 89);
            this.lable_students_lastName.Name = "lable_students_lastName";
            this.lable_students_lastName.Size = new System.Drawing.Size(0, 10);
            this.lable_students_lastName.TabIndex = 3;
            // 
            // lable_students_code
            // 
            this.lable_students_code.AutoSize = true;
            this.lable_students_code.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_students_code.ForeColor = System.Drawing.Color.Green;
            this.lable_students_code.Location = new System.Drawing.Point(546, 199);
            this.lable_students_code.Name = "lable_students_code";
            this.lable_students_code.Size = new System.Drawing.Size(0, 10);
            this.lable_students_code.TabIndex = 3;
            // 
            // lable_students_age
            // 
            this.lable_students_age.AutoSize = true;
            this.lable_students_age.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_students_age.ForeColor = System.Drawing.Color.Red;
            this.lable_students_age.Location = new System.Drawing.Point(701, 199);
            this.lable_students_age.Name = "lable_students_age";
            this.lable_students_age.Size = new System.Drawing.Size(0, 10);
            this.lable_students_age.TabIndex = 3;
            // 
            // lable_students_firstName
            // 
            this.lable_students_firstName.AutoSize = true;
            this.lable_students_firstName.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_students_firstName.ForeColor = System.Drawing.Color.Red;
            this.lable_students_firstName.Location = new System.Drawing.Point(701, 89);
            this.lable_students_firstName.Name = "lable_students_firstName";
            this.lable_students_firstName.Size = new System.Drawing.Size(0, 10);
            this.lable_students_firstName.TabIndex = 3;
            // 
            // button_students_search
            // 
            this.button_students_search.BackColor = System.Drawing.Color.White;
            this.button_students_search.ForeColor = System.Drawing.Color.Black;
            this.button_students_search.Location = new System.Drawing.Point(579, 286);
            this.button_students_search.Name = "button_students_search";
            this.button_students_search.Size = new System.Drawing.Size(75, 23);
            this.button_students_search.TabIndex = 2;
            this.button_students_search.Text = "جستو جو";
            this.button_students_search.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_students_search.UseVisualStyleBackColor = false;
            this.button_students_search.Click += new System.EventHandler(this.button_students_search_Click);
            // 
            // button_students_clear
            // 
            this.button_students_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_students_clear.ForeColor = System.Drawing.Color.White;
            this.button_students_clear.Location = new System.Drawing.Point(668, 286);
            this.button_students_clear.Name = "button_students_clear";
            this.button_students_clear.Size = new System.Drawing.Size(75, 23);
            this.button_students_clear.TabIndex = 2;
            this.button_students_clear.Text = "پاکسازی";
            this.button_students_clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_students_clear.UseVisualStyleBackColor = false;
            this.button_students_clear.Click += new System.EventHandler(this.button_students_clear_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(572, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "کد:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(716, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "سن:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام خانوادگی:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(722, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام:";
            // 
            // textBox_students_lastName
            // 
            this.textBox_students_lastName.Location = new System.Drawing.Point(491, 65);
            this.textBox_students_lastName.Name = "textBox_students_lastName";
            this.textBox_students_lastName.Size = new System.Drawing.Size(100, 21);
            this.textBox_students_lastName.TabIndex = 2;
            this.textBox_students_lastName.TextChanged += new System.EventHandler(this.textBox_students_lastName_TextChanged);
            // 
            // textBox_students_firstName
            // 
            this.textBox_students_firstName.Location = new System.Drawing.Point(644, 65);
            this.textBox_students_firstName.MaxLength = 10;
            this.textBox_students_firstName.Name = "textBox_students_firstName";
            this.textBox_students_firstName.Size = new System.Drawing.Size(100, 21);
            this.textBox_students_firstName.TabIndex = 2;
            this.textBox_students_firstName.TextChanged += new System.EventHandler(this.textBox_students_firstName_TextChanged);
            // 
            // numberBox_students_code
            // 
            this.numberBox_students_code.Location = new System.Drawing.Point(491, 175);
            this.numberBox_students_code.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numberBox_students_code.Name = "numberBox_students_code";
            this.numberBox_students_code.Size = new System.Drawing.Size(100, 21);
            this.numberBox_students_code.TabIndex = 2;
            this.numberBox_students_code.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numberBox_students_code.ValueChanged += new System.EventHandler(this.numberBox_students_code_ValueChanged);
            // 
            // numberBox_students_age
            // 
            this.numberBox_students_age.Location = new System.Drawing.Point(644, 175);
            this.numberBox_students_age.Name = "numberBox_students_age";
            this.numberBox_students_age.Size = new System.Drawing.Size(100, 21);
            this.numberBox_students_age.TabIndex = 2;
            this.numberBox_students_age.ValueChanged += new System.EventHandler(this.numberBox_students_age_ValueChanged);
            // 
            // button_students_delete
            // 
            this.button_students_delete.BackColor = System.Drawing.Color.Red;
            this.button_students_delete.ForeColor = System.Drawing.Color.White;
            this.button_students_delete.Location = new System.Drawing.Point(668, 315);
            this.button_students_delete.Name = "button_students_delete";
            this.button_students_delete.Size = new System.Drawing.Size(75, 23);
            this.button_students_delete.TabIndex = 1;
            this.button_students_delete.Text = "حذف";
            this.button_students_delete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_students_delete.UseVisualStyleBackColor = false;
            this.button_students_delete.Click += new System.EventHandler(this.button_students_delete_Click);
            // 
            // button_students_edite
            // 
            this.button_students_edite.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_students_edite.Enabled = false;
            this.button_students_edite.Location = new System.Drawing.Point(580, 313);
            this.button_students_edite.Name = "button_students_edite";
            this.button_students_edite.Size = new System.Drawing.Size(74, 23);
            this.button_students_edite.TabIndex = 1;
            this.button_students_edite.Text = "ویرایش";
            this.button_students_edite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_students_edite.UseVisualStyleBackColor = false;
            this.button_students_edite.Click += new System.EventHandler(this.button_students_edite_Click);
            // 
            // button_students_insert
            // 
            this.button_students_insert.BackColor = System.Drawing.Color.Aqua;
            this.button_students_insert.Enabled = false;
            this.button_students_insert.Location = new System.Drawing.Point(491, 313);
            this.button_students_insert.Name = "button_students_insert";
            this.button_students_insert.Size = new System.Drawing.Size(74, 23);
            this.button_students_insert.TabIndex = 1;
            this.button_students_insert.Text = "افزودن";
            this.button_students_insert.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_students_insert.UseVisualStyleBackColor = false;
            this.button_students_insert.Click += new System.EventHandler(this.button_students_insert_Click);
            // 
            // dataGridView_Students
            // 
            this.dataGridView_Students.AllowUserToAddRows = false;
            this.dataGridView_Students.AllowUserToDeleteRows = false;
            this.dataGridView_Students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Students.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_ID,
            this.Student_FirstName,
            this.Student_LastName,
            this.Student_Age});
            this.dataGridView_Students.Location = new System.Drawing.Point(8, 12);
            this.dataGridView_Students.Name = "dataGridView_Students";
            this.dataGridView_Students.ReadOnly = true;
            this.dataGridView_Students.Size = new System.Drawing.Size(467, 350);
            this.dataGridView_Students.TabIndex = 0;
            this.dataGridView_Students.Click += new System.EventHandler(this.dataGridView_Students_Click);
            // 
            // Student_ID
            // 
            this.Student_ID.DataPropertyName = "Student_ID";
            this.Student_ID.HeaderText = "کد دانش آموز";
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.ReadOnly = true;
            this.Student_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Student_FirstName
            // 
            this.Student_FirstName.DataPropertyName = "Student_FirstName";
            this.Student_FirstName.HeaderText = "نام";
            this.Student_FirstName.Name = "Student_FirstName";
            this.Student_FirstName.ReadOnly = true;
            this.Student_FirstName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Student_LastName
            // 
            this.Student_LastName.DataPropertyName = "Student_LastName";
            this.Student_LastName.HeaderText = "نام خانوادگی";
            this.Student_LastName.Name = "Student_LastName";
            this.Student_LastName.ReadOnly = true;
            this.Student_LastName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Student_Age
            // 
            this.Student_Age.DataPropertyName = "Student_Age";
            this.Student_Age.HeaderText = "سن";
            this.Student_Age.Name = "Student_Age";
            this.Student_Age.ReadOnly = true;
            this.Student_Age.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tabPage_Teachers
            // 
            this.tabPage_Teachers.Controls.Add(this.lable_teachers_lastName);
            this.tabPage_Teachers.Controls.Add(this.lable_teachers_firstName);
            this.tabPage_Teachers.Controls.Add(this.button_teachers_search);
            this.tabPage_Teachers.Controls.Add(this.button_teachers_clear);
            this.tabPage_Teachers.Controls.Add(this.dataGridView_Teachers);
            this.tabPage_Teachers.Controls.Add(this.numberBox_teachers_code);
            this.tabPage_Teachers.Controls.Add(this.numberBox_teachers_age);
            this.tabPage_Teachers.Controls.Add(this.label9);
            this.tabPage_Teachers.Controls.Add(this.textBox_teachers_firstName);
            this.tabPage_Teachers.Controls.Add(this.label15);
            this.tabPage_Teachers.Controls.Add(this.textBox_teachers_lastName);
            this.tabPage_Teachers.Controls.Add(this.label8);
            this.tabPage_Teachers.Controls.Add(this.button_teachers_delete);
            this.tabPage_Teachers.Controls.Add(this.button_teachers_edite);
            this.tabPage_Teachers.Controls.Add(this.button_teachers_insert);
            this.tabPage_Teachers.Controls.Add(this.label7);
            this.tabPage_Teachers.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Teachers.Name = "tabPage_Teachers";
            this.tabPage_Teachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Teachers.Size = new System.Drawing.Size(882, 362);
            this.tabPage_Teachers.TabIndex = 1;
            this.tabPage_Teachers.Text = "معلمین";
            this.tabPage_Teachers.UseVisualStyleBackColor = true;
            // 
            // lable_teachers_lastName
            // 
            this.lable_teachers_lastName.AutoSize = true;
            this.lable_teachers_lastName.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_teachers_lastName.ForeColor = System.Drawing.Color.Red;
            this.lable_teachers_lastName.Location = new System.Drawing.Point(562, 109);
            this.lable_teachers_lastName.Name = "lable_teachers_lastName";
            this.lable_teachers_lastName.Size = new System.Drawing.Size(0, 10);
            this.lable_teachers_lastName.TabIndex = 4;
            // 
            // lable_teachers_firstName
            // 
            this.lable_teachers_firstName.AutoSize = true;
            this.lable_teachers_firstName.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_teachers_firstName.ForeColor = System.Drawing.Color.Red;
            this.lable_teachers_firstName.Location = new System.Drawing.Point(714, 109);
            this.lable_teachers_firstName.Name = "lable_teachers_firstName";
            this.lable_teachers_firstName.Size = new System.Drawing.Size(0, 10);
            this.lable_teachers_firstName.TabIndex = 4;
            // 
            // button_teachers_search
            // 
            this.button_teachers_search.BackColor = System.Drawing.Color.White;
            this.button_teachers_search.ForeColor = System.Drawing.Color.Black;
            this.button_teachers_search.Location = new System.Drawing.Point(577, 306);
            this.button_teachers_search.Name = "button_teachers_search";
            this.button_teachers_search.Size = new System.Drawing.Size(75, 23);
            this.button_teachers_search.TabIndex = 2;
            this.button_teachers_search.Text = "جستو جو";
            this.button_teachers_search.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_teachers_search.UseVisualStyleBackColor = false;
            this.button_teachers_search.Click += new System.EventHandler(this.button_teacher_search);
            // 
            // button_teachers_clear
            // 
            this.button_teachers_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_teachers_clear.ForeColor = System.Drawing.Color.White;
            this.button_teachers_clear.Location = new System.Drawing.Point(666, 306);
            this.button_teachers_clear.Name = "button_teachers_clear";
            this.button_teachers_clear.Size = new System.Drawing.Size(75, 23);
            this.button_teachers_clear.TabIndex = 2;
            this.button_teachers_clear.Text = "پاکسازی";
            this.button_teachers_clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_teachers_clear.UseVisualStyleBackColor = false;
            this.button_teachers_clear.Click += new System.EventHandler(this.button_teachers_clear_Click);
            // 
            // dataGridView_Teachers
            // 
            this.dataGridView_Teachers.AllowUserToAddRows = false;
            this.dataGridView_Teachers.AllowUserToDeleteRows = false;
            this.dataGridView_Teachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Teachers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView_Teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Teachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Teacher_ID,
            this.Teacher_FirstName,
            this.Teacher_LastName,
            this.Teacher_Age});
            this.dataGridView_Teachers.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_Teachers.Name = "dataGridView_Teachers";
            this.dataGridView_Teachers.ReadOnly = true;
            this.dataGridView_Teachers.Size = new System.Drawing.Size(467, 350);
            this.dataGridView_Teachers.TabIndex = 0;
            this.dataGridView_Teachers.Click += new System.EventHandler(this.dataGridView_Teachers_Click);
            // 
            // Teacher_ID
            // 
            this.Teacher_ID.DataPropertyName = "Teacher_ID";
            this.Teacher_ID.HeaderText = "کد معلّم";
            this.Teacher_ID.Name = "Teacher_ID";
            this.Teacher_ID.ReadOnly = true;
            // 
            // Teacher_FirstName
            // 
            this.Teacher_FirstName.DataPropertyName = "Teacher_FirstName";
            this.Teacher_FirstName.HeaderText = "نام";
            this.Teacher_FirstName.Name = "Teacher_FirstName";
            this.Teacher_FirstName.ReadOnly = true;
            // 
            // Teacher_LastName
            // 
            this.Teacher_LastName.DataPropertyName = "Teacher_LastName";
            this.Teacher_LastName.HeaderText = "نام خانوادگی";
            this.Teacher_LastName.Name = "Teacher_LastName";
            this.Teacher_LastName.ReadOnly = true;
            // 
            // Teacher_Age
            // 
            this.Teacher_Age.DataPropertyName = "Teacher_Age";
            this.Teacher_Age.HeaderText = "سن";
            this.Teacher_Age.Name = "Teacher_Age";
            this.Teacher_Age.ReadOnly = true;
            // 
            // numberBox_teachers_code
            // 
            this.numberBox_teachers_code.Enabled = false;
            this.numberBox_teachers_code.Location = new System.Drawing.Point(489, 195);
            this.numberBox_teachers_code.Name = "numberBox_teachers_code";
            this.numberBox_teachers_code.Size = new System.Drawing.Size(100, 21);
            this.numberBox_teachers_code.TabIndex = 2;
            // 
            // numberBox_teachers_age
            // 
            this.numberBox_teachers_age.Location = new System.Drawing.Point(642, 195);
            this.numberBox_teachers_age.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberBox_teachers_age.Name = "numberBox_teachers_age";
            this.numberBox_teachers_age.Size = new System.Drawing.Size(100, 21);
            this.numberBox_teachers_age.TabIndex = 2;
            this.numberBox_teachers_age.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(714, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "سن:";
            // 
            // textBox_teachers_firstName
            // 
            this.textBox_teachers_firstName.Location = new System.Drawing.Point(642, 85);
            this.textBox_teachers_firstName.Name = "textBox_teachers_firstName";
            this.textBox_teachers_firstName.Size = new System.Drawing.Size(100, 21);
            this.textBox_teachers_firstName.TabIndex = 2;
            this.textBox_teachers_firstName.TextChanged += new System.EventHandler(this.textBox_teachers_firstName_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(570, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "کد:";
            // 
            // textBox_teachers_lastName
            // 
            this.textBox_teachers_lastName.Location = new System.Drawing.Point(489, 85);
            this.textBox_teachers_lastName.Name = "textBox_teachers_lastName";
            this.textBox_teachers_lastName.Size = new System.Drawing.Size(100, 21);
            this.textBox_teachers_lastName.TabIndex = 2;
            this.textBox_teachers_lastName.TextChanged += new System.EventHandler(this.textBox_teachers_lastName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(523, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "نام خانوادگی:";
            // 
            // button_teachers_delete
            // 
            this.button_teachers_delete.BackColor = System.Drawing.Color.Red;
            this.button_teachers_delete.ForeColor = System.Drawing.Color.White;
            this.button_teachers_delete.Location = new System.Drawing.Point(489, 306);
            this.button_teachers_delete.Name = "button_teachers_delete";
            this.button_teachers_delete.Size = new System.Drawing.Size(75, 23);
            this.button_teachers_delete.TabIndex = 1;
            this.button_teachers_delete.Text = "حذف";
            this.button_teachers_delete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_teachers_delete.UseVisualStyleBackColor = false;
            this.button_teachers_delete.Click += new System.EventHandler(this.button_teachers_delete_Click);
            // 
            // button_teachers_edite
            // 
            this.button_teachers_edite.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_teachers_edite.Enabled = false;
            this.button_teachers_edite.Location = new System.Drawing.Point(623, 333);
            this.button_teachers_edite.Name = "button_teachers_edite";
            this.button_teachers_edite.Size = new System.Drawing.Size(118, 23);
            this.button_teachers_edite.TabIndex = 1;
            this.button_teachers_edite.Text = "ویرایش";
            this.button_teachers_edite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_teachers_edite.UseVisualStyleBackColor = false;
            this.button_teachers_edite.Click += new System.EventHandler(this.button_teachers_edite_Click);
            // 
            // button_teachers_insert
            // 
            this.button_teachers_insert.BackColor = System.Drawing.Color.Aqua;
            this.button_teachers_insert.Enabled = false;
            this.button_teachers_insert.Location = new System.Drawing.Point(489, 333);
            this.button_teachers_insert.Name = "button_teachers_insert";
            this.button_teachers_insert.Size = new System.Drawing.Size(118, 23);
            this.button_teachers_insert.TabIndex = 1;
            this.button_teachers_insert.Text = "افزودن";
            this.button_teachers_insert.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_teachers_insert.UseVisualStyleBackColor = false;
            this.button_teachers_insert.Click += new System.EventHandler(this.button_teachers_insert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(720, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "نام:";
            // 
            // tabPage_Lessons
            // 
            this.tabPage_Lessons.Controls.Add(this.lable_writer_lastName);
            this.tabPage_Lessons.Controls.Add(this.lable_writer_firstName);
            this.tabPage_Lessons.Controls.Add(this.lable_lessons_name);
            this.tabPage_Lessons.Controls.Add(this.numberBox_lessons_code);
            this.tabPage_Lessons.Controls.Add(this.button_lessons_search);
            this.tabPage_Lessons.Controls.Add(this.button_lessons_clear);
            this.tabPage_Lessons.Controls.Add(this.dataGridView_Lessons);
            this.tabPage_Lessons.Controls.Add(this.button_lesson_delete);
            this.tabPage_Lessons.Controls.Add(this.button_lessons_edit);
            this.tabPage_Lessons.Controls.Add(this.textBox_lesson_name);
            this.tabPage_Lessons.Controls.Add(this.textBox_writer_lastName);
            this.tabPage_Lessons.Controls.Add(this.textBox_writer_firstName);
            this.tabPage_Lessons.Controls.Add(this.label16);
            this.tabPage_Lessons.Controls.Add(this.label13);
            this.tabPage_Lessons.Controls.Add(this.label11);
            this.tabPage_Lessons.Controls.Add(this.label10);
            this.tabPage_Lessons.Controls.Add(this.button_lessons_insert);
            this.tabPage_Lessons.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Lessons.Name = "tabPage_Lessons";
            this.tabPage_Lessons.Size = new System.Drawing.Size(882, 362);
            this.tabPage_Lessons.TabIndex = 2;
            this.tabPage_Lessons.Text = "دروس";
            this.tabPage_Lessons.UseVisualStyleBackColor = true;
            // 
            // lable_writer_lastName
            // 
            this.lable_writer_lastName.AutoSize = true;
            this.lable_writer_lastName.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_writer_lastName.ForeColor = System.Drawing.Color.Red;
            this.lable_writer_lastName.Location = new System.Drawing.Point(715, 219);
            this.lable_writer_lastName.Name = "lable_writer_lastName";
            this.lable_writer_lastName.Size = new System.Drawing.Size(0, 10);
            this.lable_writer_lastName.TabIndex = 4;
            // 
            // lable_writer_firstName
            // 
            this.lable_writer_firstName.AutoSize = true;
            this.lable_writer_firstName.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_writer_firstName.ForeColor = System.Drawing.Color.Red;
            this.lable_writer_firstName.Location = new System.Drawing.Point(562, 109);
            this.lable_writer_firstName.Name = "lable_writer_firstName";
            this.lable_writer_firstName.Size = new System.Drawing.Size(0, 10);
            this.lable_writer_firstName.TabIndex = 4;
            // 
            // lable_lessons_name
            // 
            this.lable_lessons_name.AutoSize = true;
            this.lable_lessons_name.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_lessons_name.ForeColor = System.Drawing.Color.Red;
            this.lable_lessons_name.Location = new System.Drawing.Point(713, 109);
            this.lable_lessons_name.Name = "lable_lessons_name";
            this.lable_lessons_name.Size = new System.Drawing.Size(0, 10);
            this.lable_lessons_name.TabIndex = 4;
            // 
            // numberBox_lessons_code
            // 
            this.numberBox_lessons_code.Enabled = false;
            this.numberBox_lessons_code.Location = new System.Drawing.Point(489, 195);
            this.numberBox_lessons_code.Name = "numberBox_lessons_code";
            this.numberBox_lessons_code.Size = new System.Drawing.Size(100, 21);
            this.numberBox_lessons_code.TabIndex = 3;
            // 
            // button_lessons_search
            // 
            this.button_lessons_search.BackColor = System.Drawing.Color.White;
            this.button_lessons_search.ForeColor = System.Drawing.Color.Black;
            this.button_lessons_search.Location = new System.Drawing.Point(577, 306);
            this.button_lessons_search.Name = "button_lessons_search";
            this.button_lessons_search.Size = new System.Drawing.Size(75, 23);
            this.button_lessons_search.TabIndex = 2;
            this.button_lessons_search.Text = "جستو جو";
            this.button_lessons_search.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_lessons_search.UseVisualStyleBackColor = false;
            this.button_lessons_search.Click += new System.EventHandler(this.button_lessons_search_Click);
            // 
            // button_lessons_clear
            // 
            this.button_lessons_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_lessons_clear.ForeColor = System.Drawing.Color.White;
            this.button_lessons_clear.Location = new System.Drawing.Point(666, 306);
            this.button_lessons_clear.Name = "button_lessons_clear";
            this.button_lessons_clear.Size = new System.Drawing.Size(75, 23);
            this.button_lessons_clear.TabIndex = 2;
            this.button_lessons_clear.Text = "پاکسازی";
            this.button_lessons_clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_lessons_clear.UseVisualStyleBackColor = false;
            this.button_lessons_clear.Click += new System.EventHandler(this.button_lessons_clear_Click);
            // 
            // dataGridView_Lessons
            // 
            this.dataGridView_Lessons.AllowUserToAddRows = false;
            this.dataGridView_Lessons.AllowUserToDeleteRows = false;
            this.dataGridView_Lessons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Lessons.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView_Lessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lessons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lesson_ID,
            this.Lesson_Name,
            this.Writer_FirstName,
            this.Writer_LastName});
            this.dataGridView_Lessons.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_Lessons.Name = "dataGridView_Lessons";
            this.dataGridView_Lessons.ReadOnly = true;
            this.dataGridView_Lessons.Size = new System.Drawing.Size(467, 350);
            this.dataGridView_Lessons.TabIndex = 0;
            this.dataGridView_Lessons.Click += new System.EventHandler(this.dataGridView_Lessons_Click);
            // 
            // Lesson_ID
            // 
            this.Lesson_ID.DataPropertyName = "Lesson_ID";
            this.Lesson_ID.HeaderText = "کد درس";
            this.Lesson_ID.Name = "Lesson_ID";
            this.Lesson_ID.ReadOnly = true;
            // 
            // Lesson_Name
            // 
            this.Lesson_Name.DataPropertyName = "Lesson_Name";
            this.Lesson_Name.HeaderText = "نام درس";
            this.Lesson_Name.Name = "Lesson_Name";
            this.Lesson_Name.ReadOnly = true;
            // 
            // Writer_FirstName
            // 
            this.Writer_FirstName.DataPropertyName = "Writer_FirstName";
            this.Writer_FirstName.HeaderText = "نام نویسنده";
            this.Writer_FirstName.Name = "Writer_FirstName";
            this.Writer_FirstName.ReadOnly = true;
            // 
            // Writer_LastName
            // 
            this.Writer_LastName.DataPropertyName = "Writer_LastName";
            this.Writer_LastName.HeaderText = "نام خانوادگی نویسنده";
            this.Writer_LastName.Name = "Writer_LastName";
            this.Writer_LastName.ReadOnly = true;
            // 
            // button_lesson_delete
            // 
            this.button_lesson_delete.BackColor = System.Drawing.Color.Red;
            this.button_lesson_delete.ForeColor = System.Drawing.Color.White;
            this.button_lesson_delete.Location = new System.Drawing.Point(489, 306);
            this.button_lesson_delete.Name = "button_lesson_delete";
            this.button_lesson_delete.Size = new System.Drawing.Size(75, 23);
            this.button_lesson_delete.TabIndex = 1;
            this.button_lesson_delete.Text = "حذف";
            this.button_lesson_delete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_lesson_delete.UseVisualStyleBackColor = false;
            this.button_lesson_delete.Click += new System.EventHandler(this.button_lesson_delete_Click);
            // 
            // button_lessons_edit
            // 
            this.button_lessons_edit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_lessons_edit.Enabled = false;
            this.button_lessons_edit.Location = new System.Drawing.Point(623, 333);
            this.button_lessons_edit.Name = "button_lessons_edit";
            this.button_lessons_edit.Size = new System.Drawing.Size(118, 23);
            this.button_lessons_edit.TabIndex = 1;
            this.button_lessons_edit.Text = "ویرایش";
            this.button_lessons_edit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_lessons_edit.UseVisualStyleBackColor = false;
            this.button_lessons_edit.Click += new System.EventHandler(this.button_lessons_edit_Click);
            // 
            // textBox_lesson_name
            // 
            this.textBox_lesson_name.Location = new System.Drawing.Point(642, 85);
            this.textBox_lesson_name.Name = "textBox_lesson_name";
            this.textBox_lesson_name.Size = new System.Drawing.Size(100, 21);
            this.textBox_lesson_name.TabIndex = 2;
            this.textBox_lesson_name.TextChanged += new System.EventHandler(this.textBox_lesson_name_TextChanged);
            // 
            // textBox_writer_lastName
            // 
            this.textBox_writer_lastName.Location = new System.Drawing.Point(642, 195);
            this.textBox_writer_lastName.Name = "textBox_writer_lastName";
            this.textBox_writer_lastName.Size = new System.Drawing.Size(100, 21);
            this.textBox_writer_lastName.TabIndex = 2;
            this.textBox_writer_lastName.TextChanged += new System.EventHandler(this.textBox_writer_lastName_TextChanged);
            // 
            // textBox_writer_firstName
            // 
            this.textBox_writer_firstName.Location = new System.Drawing.Point(489, 85);
            this.textBox_writer_firstName.Name = "textBox_writer_firstName";
            this.textBox_writer_firstName.Size = new System.Drawing.Size(100, 21);
            this.textBox_writer_firstName.TabIndex = 2;
            this.textBox_writer_firstName.TextChanged += new System.EventHandler(this.textBox_writer_firstName_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(570, 179);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "کد:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(678, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 26);
            this.label13.TabIndex = 2;
            this.label13.Text = "نام خانوادگی\r\nنویسنده:\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(527, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "نام نویسنده:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(696, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "نام درس:";
            // 
            // button_lessons_insert
            // 
            this.button_lessons_insert.BackColor = System.Drawing.Color.Aqua;
            this.button_lessons_insert.Enabled = false;
            this.button_lessons_insert.Location = new System.Drawing.Point(489, 333);
            this.button_lessons_insert.Name = "button_lessons_insert";
            this.button_lessons_insert.Size = new System.Drawing.Size(118, 23);
            this.button_lessons_insert.TabIndex = 1;
            this.button_lessons_insert.Text = "افزودن";
            this.button_lessons_insert.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_lessons_insert.UseVisualStyleBackColor = false;
            this.button_lessons_insert.Click += new System.EventHandler(this.button_lessons_insert_Click);
            // 
            // tabPage_Choice
            // 
            this.tabPage_Choice.Controls.Add(this.numberBox_choice_lessonCode);
            this.tabPage_Choice.Controls.Add(this.numberBox_choice_code);
            this.tabPage_Choice.Controls.Add(this.numberBox_choice_studentCode);
            this.tabPage_Choice.Controls.Add(this.numberBox_choice_teacherCode);
            this.tabPage_Choice.Controls.Add(this.button_choice_search);
            this.tabPage_Choice.Controls.Add(this.button_choice_clear);
            this.tabPage_Choice.Controls.Add(this.dataGridView_Choice);
            this.tabPage_Choice.Controls.Add(this.label12);
            this.tabPage_Choice.Controls.Add(this.label17);
            this.tabPage_Choice.Controls.Add(this.label5);
            this.tabPage_Choice.Controls.Add(this.label4);
            this.tabPage_Choice.Controls.Add(this.button_choice_delete);
            this.tabPage_Choice.Controls.Add(this.label6);
            this.tabPage_Choice.Controls.Add(this.button_choice_insert);
            this.tabPage_Choice.Controls.Add(this.button_choice_edit);
            this.tabPage_Choice.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Choice.Name = "tabPage_Choice";
            this.tabPage_Choice.Size = new System.Drawing.Size(882, 362);
            this.tabPage_Choice.TabIndex = 3;
            this.tabPage_Choice.Text = "اخذ";
            this.tabPage_Choice.UseVisualStyleBackColor = true;
            // 
            // numberBox_choice_lessonCode
            // 
            this.numberBox_choice_lessonCode.Location = new System.Drawing.Point(489, 151);
            this.numberBox_choice_lessonCode.Name = "numberBox_choice_lessonCode";
            this.numberBox_choice_lessonCode.Size = new System.Drawing.Size(100, 21);
            this.numberBox_choice_lessonCode.TabIndex = 5;
            // 
            // numberBox_choice_code
            // 
            this.numberBox_choice_code.Enabled = false;
            this.numberBox_choice_code.Location = new System.Drawing.Point(565, 227);
            this.numberBox_choice_code.Name = "numberBox_choice_code";
            this.numberBox_choice_code.Size = new System.Drawing.Size(100, 21);
            this.numberBox_choice_code.TabIndex = 5;
            // 
            // numberBox_choice_studentCode
            // 
            this.numberBox_choice_studentCode.Location = new System.Drawing.Point(641, 151);
            this.numberBox_choice_studentCode.Name = "numberBox_choice_studentCode";
            this.numberBox_choice_studentCode.Size = new System.Drawing.Size(100, 21);
            this.numberBox_choice_studentCode.TabIndex = 5;
            // 
            // numberBox_choice_teacherCode
            // 
            this.numberBox_choice_teacherCode.Location = new System.Drawing.Point(641, 41);
            this.numberBox_choice_teacherCode.Name = "numberBox_choice_teacherCode";
            this.numberBox_choice_teacherCode.Size = new System.Drawing.Size(100, 21);
            this.numberBox_choice_teacherCode.TabIndex = 5;
            // 
            // button_choice_search
            // 
            this.button_choice_search.BackColor = System.Drawing.Color.White;
            this.button_choice_search.ForeColor = System.Drawing.Color.Black;
            this.button_choice_search.Location = new System.Drawing.Point(577, 306);
            this.button_choice_search.Name = "button_choice_search";
            this.button_choice_search.Size = new System.Drawing.Size(75, 23);
            this.button_choice_search.TabIndex = 2;
            this.button_choice_search.Text = "جستو جو";
            this.button_choice_search.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_choice_search.UseVisualStyleBackColor = false;
            this.button_choice_search.Click += new System.EventHandler(this.button_choice_clear_Click);
            // 
            // button_choice_clear
            // 
            this.button_choice_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_choice_clear.ForeColor = System.Drawing.Color.White;
            this.button_choice_clear.Location = new System.Drawing.Point(666, 306);
            this.button_choice_clear.Name = "button_choice_clear";
            this.button_choice_clear.Size = new System.Drawing.Size(75, 23);
            this.button_choice_clear.TabIndex = 2;
            this.button_choice_clear.Text = "پاکسازی";
            this.button_choice_clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_choice_clear.UseVisualStyleBackColor = false;
            this.button_choice_clear.Click += new System.EventHandler(this.button_choice_clear_Click);
            // 
            // dataGridView_Choice
            // 
            this.dataGridView_Choice.AllowUserToAddRows = false;
            this.dataGridView_Choice.AllowUserToDeleteRows = false;
            this.dataGridView_Choice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Choice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView_Choice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Choice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Choice_ID,
            this.Les_ID,
            this.Stu_ID,
            this.Tea_ID,
            this.Choice_PrehensionHistory});
            this.dataGridView_Choice.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_Choice.Name = "dataGridView_Choice";
            this.dataGridView_Choice.ReadOnly = true;
            this.dataGridView_Choice.Size = new System.Drawing.Size(467, 350);
            this.dataGridView_Choice.TabIndex = 0;
            this.dataGridView_Choice.Click += new System.EventHandler(this.dataGridView_Choice_Click);
            // 
            // Choice_ID
            // 
            this.Choice_ID.DataPropertyName = "Choice_ID";
            this.Choice_ID.HeaderText = "کد اخذ";
            this.Choice_ID.Name = "Choice_ID";
            this.Choice_ID.ReadOnly = true;
            // 
            // Les_ID
            // 
            this.Les_ID.DataPropertyName = "Lesson_ID";
            this.Les_ID.HeaderText = "کد درس";
            this.Les_ID.Name = "Les_ID";
            this.Les_ID.ReadOnly = true;
            // 
            // Stu_ID
            // 
            this.Stu_ID.DataPropertyName = "Student_ID";
            this.Stu_ID.HeaderText = "کد دانش آموز";
            this.Stu_ID.Name = "Stu_ID";
            this.Stu_ID.ReadOnly = true;
            // 
            // Tea_ID
            // 
            this.Tea_ID.DataPropertyName = "Teacher_ID";
            this.Tea_ID.HeaderText = "کد معلّم";
            this.Tea_ID.Name = "Tea_ID";
            this.Tea_ID.ReadOnly = true;
            // 
            // Choice_PrehensionHistory
            // 
            this.Choice_PrehensionHistory.DataPropertyName = "Choice_PrehensionHistory";
            this.Choice_PrehensionHistory.HeaderText = "تاریخ اخذ";
            this.Choice_PrehensionHistory.Name = "Choice_PrehensionHistory";
            this.Choice_PrehensionHistory.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(541, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "تاریخ اخذ:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(646, 211);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "کد:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(695, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "کد معلّم:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(673, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "کد دانش آموز:";
            // 
            // button_choice_delete
            // 
            this.button_choice_delete.BackColor = System.Drawing.Color.Red;
            this.button_choice_delete.ForeColor = System.Drawing.Color.White;
            this.button_choice_delete.Location = new System.Drawing.Point(489, 306);
            this.button_choice_delete.Name = "button_choice_delete";
            this.button_choice_delete.Size = new System.Drawing.Size(75, 23);
            this.button_choice_delete.TabIndex = 1;
            this.button_choice_delete.Text = "حذف";
            this.button_choice_delete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_choice_delete.UseVisualStyleBackColor = false;
            this.button_choice_delete.Click += new System.EventHandler(this.button_choice_delete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "کد درس:";
            // 
            // button_choice_insert
            // 
            this.button_choice_insert.BackColor = System.Drawing.Color.Aqua;
            this.button_choice_insert.Location = new System.Drawing.Point(489, 333);
            this.button_choice_insert.Name = "button_choice_insert";
            this.button_choice_insert.Size = new System.Drawing.Size(118, 23);
            this.button_choice_insert.TabIndex = 1;
            this.button_choice_insert.Text = "افزودن";
            this.button_choice_insert.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_choice_insert.UseVisualStyleBackColor = false;
            // 
            // button_choice_edit
            // 
            this.button_choice_edit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_choice_edit.Location = new System.Drawing.Point(623, 333);
            this.button_choice_edit.Name = "button_choice_edit";
            this.button_choice_edit.Size = new System.Drawing.Size(118, 23);
            this.button_choice_edit.TabIndex = 1;
            this.button_choice_edit.Text = "ویرایش";
            this.button_choice_edit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_choice_edit.UseVisualStyleBackColor = false;
            // 
            // dateTimeSelector_choice_prehensionHistory
            // 
            this.dateTimeSelector_choice_prehensionHistory.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimeSelector_choice_prehensionHistory.Location = new System.Drawing.Point(479, 40);
            this.dateTimeSelector_choice_prehensionHistory.Name = "dateTimeSelector_choice_prehensionHistory";
            this.dateTimeSelector_choice_prehensionHistory.Size = new System.Drawing.Size(100, 21);
            this.dateTimeSelector_choice_prehensionHistory.TabIndex = 4;
            this.dateTimeSelector_choice_prehensionHistory.UsePersianFormat = true;
            // 
            // timer_students_code
            // 
            this.timer_students_code.Interval = 10000;
            this.timer_students_code.Tick += new System.EventHandler(this.timer_students_code_Tick);
            // 
            // button_student_refresh
            // 
            this.button_student_refresh.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_student_refresh.Location = new System.Drawing.Point(491, 286);
            this.button_student_refresh.Name = "button_student_refresh";
            this.button_student_refresh.Size = new System.Drawing.Size(74, 23);
            this.button_student_refresh.TabIndex = 1;
            this.button_student_refresh.Text = "تازه سازی";
            this.button_student_refresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_student_refresh.UseVisualStyleBackColor = false;
            this.button_student_refresh.Click += new System.EventHandler(this.button_student_refresh_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(755, 388);
            this.Controls.Add(this.lable_students_lastName);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lable_students_code);
            this.Controls.Add(this.dataGridView_Students);
            this.Controls.Add(this.lable_students_age);
            this.Controls.Add(this.button_student_refresh);
            this.Controls.Add(this.button_students_insert);
            this.Controls.Add(this.lable_students_firstName);
            this.Controls.Add(this.button_students_edite);
            this.Controls.Add(this.button_students_search);
            this.Controls.Add(this.button_students_delete);
            this.Controls.Add(this.button_students_clear);
            this.Controls.Add(this.numberBox_students_age);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numberBox_students_code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_students_firstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_students_lastName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پروژه دیتابیس - محمد حسین برهانی";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numberBox_students_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox_students_age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Students)).EndInit();
            this.tabPage_Teachers.ResumeLayout(false);
            this.tabPage_Teachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Teachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox_teachers_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox_teachers_age)).EndInit();
            this.tabPage_Lessons.ResumeLayout(false);
            this.tabPage_Lessons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox_lessons_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lessons)).EndInit();
            this.tabPage_Choice.ResumeLayout(false);
            this.tabPage_Choice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox_choice_lessonCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox_choice_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox_choice_studentCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBox_choice_teacherCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Choice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Teachers;
        private System.Windows.Forms.TabPage tabPage_Lessons;
        private System.Windows.Forms.TabPage tabPage_Choice;
        private System.Windows.Forms.DataGridView dataGridView_Teachers;
        private System.Windows.Forms.DataGridView dataGridView_Lessons;
        private System.Windows.Forms.DataGridView dataGridView_Choice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher_Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lesson_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lesson_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Writer_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Writer_LastName;
        private System.Windows.Forms.Button button_teachers_clear;
        private System.Windows.Forms.NumericUpDown numberBox_teachers_age;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_teachers_firstName;
        private System.Windows.Forms.TextBox textBox_teachers_lastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_teachers_edite;
        private System.Windows.Forms.Button button_teachers_insert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_lessons_clear;
        private System.Windows.Forms.Button button_lessons_edit;
        private System.Windows.Forms.TextBox textBox_lesson_name;
        private System.Windows.Forms.TextBox textBox_writer_lastName;
        private System.Windows.Forms.TextBox textBox_writer_firstName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_lessons_insert;
        private System.Windows.Forms.TabPage tabPage_Students;
        private System.Windows.Forms.Button button_students_clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_students_lastName;
        private System.Windows.Forms.TextBox textBox_students_firstName;
        private System.Windows.Forms.NumericUpDown numberBox_students_age;
        private System.Windows.Forms.Button button_students_delete;
        private System.Windows.Forms.Button button_students_edite;
        private System.Windows.Forms.Button button_students_insert;
        private System.Windows.Forms.DataGridView dataGridView_Students;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Age;
        private System.Windows.Forms.Button button_teachers_delete;
        private System.Windows.Forms.Button button_lesson_delete;
        private Atf.UI.DateTimeSelector dateTimeSelector_choice_prehensionHistory;
        private System.Windows.Forms.Button button_choice_clear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_choice_delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_choice_insert;
        private System.Windows.Forms.Button button_choice_edit;
        private System.Windows.Forms.NumericUpDown numberBox_choice_lessonCode;
        private System.Windows.Forms.NumericUpDown numberBox_choice_studentCode;
        private System.Windows.Forms.NumericUpDown numberBox_choice_teacherCode;
        private System.Windows.Forms.NumericUpDown numberBox_students_code;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numberBox_teachers_code;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numberBox_lessons_code;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numberBox_choice_code;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button_students_search;
        private System.Windows.Forms.Button button_teachers_search;
        private System.Windows.Forms.Button button_lessons_search;
        private System.Windows.Forms.Button button_choice_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Choice_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Les_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stu_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tea_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Choice_PrehensionHistory;
        private System.Windows.Forms.Label lable_students_firstName;
        private System.Windows.Forms.Label lable_students_lastName;
        private System.Windows.Forms.Label lable_teachers_lastName;
        private System.Windows.Forms.Label lable_teachers_firstName;
        private System.Windows.Forms.Label lable_writer_lastName;
        private System.Windows.Forms.Label lable_writer_firstName;
        private System.Windows.Forms.Label lable_lessons_name;
        private System.Windows.Forms.Label lable_students_code;
        private System.Windows.Forms.Label lable_students_age;
        private System.Windows.Forms.Timer timer_students_code;
        private System.Windows.Forms.Button button_student_refresh;
    }
}