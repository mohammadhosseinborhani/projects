using System;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Windows.Forms;

namespace MyProjectCoding
{
    public partial class frm_Main : Form
    {
        IMyProjectRepository repository;
        string textInputValidatorMessage = "استفاده از اعداد، علائم خاصّ\nو حروف لاتین مجاز نیست";
        string textLengthValidatorMessage = "طول نوشته نباید کمتر از\nسه حرف باشد";
        string textNullspaceValidatorMessage = "استفاده از فضای خالی در ابتدا\nو انتهای نوشته مجاز نیست";
        string textMiddleNullspaceValidatorMessage = "استفاده بیش از یک فضای خالی\nدرمیان نوشته ها مجاز نیست";
        string codeNumberBoxGuideMessage = "مقدار این بخش در افزودن\nو ویرایش بی تأثیر است\n\nعدد -1 در جستو جو\nبی تأثیر است";

        bool isCodeInputGuideShown = false;

        public frm_Main()
        {
            InitializeComponent();
            repository = new MyProjectRepository();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            refresh();
        }

        //Students
        private void dataGridView_Students_Click(object sender, EventArgs e)
        {
            if (dataGridView_Students.CurrentRow != null)
            {
                textBox_students_firstName.Text = dataGridView_Students.CurrentRow.Cells[1].Value.ToString();
                textBox_students_lastName.Text = dataGridView_Students.CurrentRow.Cells[2].Value.ToString();
                numberBox_students_age.Value = (int)dataGridView_Students.CurrentRow.Cells[3].Value;
            }
        }
        private void button_students_clear_Click(object sender, EventArgs e)
        {
            clearStudents();

            button_students_insert.Enabled = false;
            button_students_edite.Enabled = false;
        }

        private void button_students_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"آیا از حذف {dataGridView_Students.CurrentRow.Cells[1].Value.ToString()} {dataGridView_Students.CurrentRow.Cells[2].Value.ToString()} اطمینان دارید؟", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (repository.Delete(int.Parse(dataGridView_Students.CurrentRow.Cells[0].Value.ToString()), "Students", "Student_ID", out Exception exception) != true)
                {
                    MessageBox.Show("عملیات با شکست مواجه شد :(", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(exception.ToString(), "متن ارور", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                refresh();
            }
        }

        private void button_students_insert_Click(object sender, EventArgs e)
        {
            if (repository.InsertToStudnets(textBox_students_firstName.Text, textBox_students_lastName.Text, (int)numberBox_students_age.Value, out Exception exception))
            {
                refresh();
            }
            else
            {
                MessageBox.Show("عملیات با شکست مواجه شد :(", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(exception.ToString(), "متن ارور", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button_students_edite_Click(object sender, EventArgs e)
        {
            if (repository.EditStudents(textBox_students_firstName.Text, textBox_students_lastName.Text, (int)numberBox_students_age.Value, (int)dataGridView_Students.CurrentRow.Cells[0].Value, out Exception exception))
            {
                refresh();
            }
            else
            {
                MessageBox.Show("عملیات با شکست مواجه شد :(", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(exception.ToString(), "متن ارور", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox_students_firstName_TextChanged(object sender, EventArgs e)
        {
            textValidatorSystem(textBox_students_firstName, lable_students_firstName, button_students_insert, button_students_edite);
        }

        private void textBox_students_lastName_TextChanged(object sender, EventArgs e)
        {
            textValidatorSystem(textBox_students_lastName, lable_students_lastName, button_students_insert, button_students_edite);
        }

        private void button_students_search_Click(object sender, EventArgs e)
        {
            var data = repository.BrowsStudents(textBox_students_firstName.Text, textBox_students_lastName.Text, (int)numberBox_students_age.Value, (int)numberBox_students_code.Value, out Exception exception);

            if (data != null)
            {
                dataGridView_Students.DataSource = data;
            }
            else
            {
                MessageBox.Show("عملیات با شکست مواجه شد :(", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(exception.ToString(), "متن ارور", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void numberBox_students_age_ValueChanged(object sender, EventArgs e)
        {
            if (ageNumberBoxValidator(numberBox_students_age, 16, 19, out string message))
            {
                button_students_insert.Enabled = false;
                button_students_edite.Enabled = false;

                lable_students_age.Text = message;
                setPositionOfControle(lable_students_age, numberBox_students_age);
            }
            else
            {
                button_students_insert.Enabled = true;
                button_students_edite.Enabled = true;

                lable_students_age.Text = message;
            }
        }

        private void numberBox_students_code_ValueChanged(object sender, EventArgs e)
        {
            if (isCodeInputGuideShown == false)
            {
                lable_students_code.Text = codeNumberBoxGuideMessage;
                setPositionOfControle(lable_students_code, numberBox_students_code);
                timer_students_code.Enabled = true;
                isCodeInputGuideShown = true;
            }
        }

        private void timer_students_code_Tick(object sender, EventArgs e)
        {
            lable_students_code.Text = "";
        }

        private void button_student_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
        //

        //Teachers
        private void dataGridView_Teachers_Click(object sender, EventArgs e)
        {
            if (dataGridView_Teachers.CurrentRow != null)
            {
                textBox_teachers_firstName.Text = dataGridView_Teachers.CurrentRow.Cells[1].Value.ToString();
                textBox_teachers_lastName.Text = dataGridView_Teachers.CurrentRow.Cells[2].Value.ToString();
                numberBox_teachers_age.Value = (int)dataGridView_Teachers.CurrentRow.Cells[3].Value;

            }
        }

        private void button_teachers_clear_Click(object sender, EventArgs e)
        {
            clearTeachers();
        }

        private void button_teachers_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"آیا از حذف {dataGridView_Teachers.CurrentRow.Cells[1].Value.ToString()} {dataGridView_Teachers.CurrentRow.Cells[2].Value.ToString()} اطمینان دارید؟", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (repository.Delete(int.Parse(dataGridView_Teachers.CurrentRow.Cells[0].Value.ToString()), "Teachers", "Teacher_ID", out Exception exception) != true)
                {
                    MessageBox.Show("عملیات با شکست مواجه شد :(", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(exception.ToString(), "متن ارور", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                refresh();
            }
        }

        private void button_teachers_insert_Click(object sender, EventArgs e)
        {
            if (repository.InsertToTeachers(textBox_teachers_firstName.Text, textBox_teachers_lastName.Text, (int)numberBox_teachers_age.Value, out Exception exception))
            {
                refresh();
            }
            else
            {
                MessageBox.Show("عملیات با شکست مواجه شد :(", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(exception.ToString(), "متن ارور", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox_teachers_firstName_TextChanged(object sender, EventArgs e)
        {
            textValidatorSystem(textBox_teachers_firstName, lable_teachers_firstName, button_teachers_insert, button_teachers_edite);
        }

        private void textBox_teachers_lastName_TextChanged(object sender, EventArgs e)
        {
            textValidatorSystem(textBox_teachers_lastName, lable_teachers_lastName, button_teachers_insert, button_teachers_edite);
        }

        private void button_teachers_edite_Click(object sender, EventArgs e)
        {
            if (repository.EditTeachers(textBox_teachers_firstName.Text, textBox_teachers_lastName.Text, (int)numberBox_teachers_age.Value, (int)dataGridView_Teachers.CurrentRow.Cells[0].Value, out Exception exception))
            {
                refresh();
            }
            else
            {
                MessageBox.Show("عملیات با شکست مواجه شد :(", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(exception.ToString(), "متن ارور", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_teacher_search(object sender, EventArgs e)
        {
            var data = repository.BrowsTeachers(textBox_teachers_firstName.Text, textBox_teachers_lastName.Text, (int)numberBox_teachers_age.Value, (int)numberBox_teachers_code.Value, out Exception exception);

            if (data != null)
            {
                dataGridView_Teachers.DataSource = data;
            }
            else
            {
                MessageBox.Show("عملیات با شکست مواجه شد :(", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(exception.ToString(), "متن ارور", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //

        //Lessons
        private void dataGridView_Lessons_Click(object sender, EventArgs e)
        {
            if (dataGridView_Lessons.CurrentRow != null)
            {
                textBox_lesson_name.Text = dataGridView_Lessons.CurrentRow.Cells[1].Value.ToString();
                textBox_writer_firstName.Text = dataGridView_Lessons.CurrentRow.Cells[2].Value.ToString();
                textBox_writer_lastName.Text = dataGridView_Lessons.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void button_lessons_clear_Click(object sender, EventArgs e)
        {
            clearLessons();
        }

        private void button_lesson_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"آیا از حذف کتاب {dataGridView_Lessons.CurrentRow.Cells[1].Value.ToString()} اطمینان دارید؟", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (repository.Delete(int.Parse(dataGridView_Lessons.CurrentRow.Cells[0].Value.ToString()), "Lessons", "Lesson_ID", out Exception exception) != true)
                {
                    MessageBox.Show("عملیات با شکست مواجه شد :(", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(exception.ToString(), "متن ارور", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                refresh();
            }
        }

        private void button_lessons_insert_Click(object sender, EventArgs e)
        {
            if (repository.InsertToLessons(textBox_lesson_name.Text, textBox_writer_firstName.Text, textBox_writer_lastName.Text, out Exception exception))
            {
                refresh();
            }
            else
            {
                MessageBox.Show("عملیات با شکست مواجه شد :(", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(exception.ToString(), "متن ارور", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox_lesson_name_TextChanged(object sender, EventArgs e)
        {
            textValidatorSystem(textBox_lesson_name, lable_lessons_name, button_lessons_insert, button_lessons_edit);
        }

        private void textBox_writer_firstName_TextChanged(object sender, EventArgs e)
        {
            textValidatorSystem(textBox_writer_firstName, lable_writer_firstName, button_lessons_insert, button_lessons_edit);
        }

        private void textBox_writer_lastName_TextChanged(object sender, EventArgs e)
        {
            textValidatorSystem(textBox_writer_lastName, lable_writer_lastName, button_lessons_insert, button_lessons_edit);
        }

        private void button_lessons_edit_Click(object sender, EventArgs e)
        {
            if (repository.EditLessons(textBox_lesson_name.Text, textBox_writer_firstName.Text, textBox_writer_lastName.Text, (int)dataGridView_Lessons.CurrentRow.Cells[0].Value, out Exception exception))
            {
                refresh();
            }
            else
            {
                MessageBox.Show("عملیات با شکست مواجه شد :(", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(exception.ToString(), "متن ارور", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_lessons_search_Click(object sender, EventArgs e)
        {
            var data = repository.BrowsLessons(textBox_lesson_name.Text, textBox_writer_firstName.Text, textBox_writer_lastName.Text, (int)numberBox_lessons_code.Value, out Exception exception);

            if (data != null)
            {
                dataGridView_Lessons.DataSource = data;
            }
            else
            {
                MessageBox.Show("عملیات با شکست مواجه شد :(", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(exception.ToString(), "متن ارور", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //

        //Choice
        private void dataGridView_Choice_Click(object sender, EventArgs e)
        {
            if (dataGridView_Choice.CurrentRow != null)
            {
                numberBox_choice_lessonCode.Value = (int)dataGridView_Choice.CurrentRow.Cells[1].Value;
                numberBox_choice_studentCode.Value = (int)dataGridView_Choice.CurrentRow.Cells[2].Value;
                numberBox_choice_teacherCode.Value = (int)dataGridView_Choice.CurrentRow.Cells[3].Value;
                // dateTimeSelector_choice_prehensionHistory.Value = DateTime.ParseExact(dataGridView_Choice.CurrentRow.Cells[4].Value.ToString(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            }
        }
        private void button_choice_clear_Click(object sender, EventArgs e)
        {
            clearChoice();
        }

        private void button_choice_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از حذف این اخذ اطمینان دارید؟", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (repository.Delete((int)dataGridView_Choice.CurrentRow.Cells[0].Value, "Choice", "Choice_ID", out Exception exception) != true)
                {
                    MessageBox.Show("عملیات با شکست مواجه شد :(", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(exception.ToString(), "متن ارور", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                refresh();
            }
        }
        //

        //methods
       
        bool ageNumberBoxValidator(NumericUpDown _numericUpDown, int _min, int _max, out string _message)
        {
            if ((_numericUpDown.Value <= _max && _numericUpDown.Value >= _min) || _numericUpDown.Value == 0)
            {
                _message = null;
                return false;
            }
            else
            {
                _message = $"سنّ فقط میتواند بین {_min} و {_max} باشد\n(عدد صفر در جستو جو بی تأثیر است)";
                return true;
            }
        }

        void refresh()
        {
            dataGridView_Students.DataSource = repository.SelectAll("Students");
            dataGridView_Teachers.DataSource = repository.SelectAll("Teachers");
            dataGridView_Lessons.DataSource = repository.SelectAll("Lessons");
            dataGridView_Choice.DataSource = repository.SelectAll("Choice");
        }

        void disableOrEnableButtons(Control[] _controls, bool _status)
        {
            foreach (var c in _controls)
            {
                c.Enabled = _status;
            }
        }

        void clearStudents()
        {
            textBox_students_firstName.Text = "";
            textBox_students_lastName.Text = "";
            numberBox_students_age.Value = 0;
            numberBox_students_code.Value = -1;
        }

        void clearTeachers()
        {
            textBox_teachers_firstName.Text = "";
            textBox_teachers_lastName.Text = "";
        }

        void clearLessons()
        {
            textBox_lesson_name.Text = "";
            textBox_writer_firstName.Text = "";
            textBox_writer_lastName.Text = "";
        }

        void clearChoice()
        {
            numberBox_choice_lessonCode.Value = 0;
            numberBox_choice_studentCode.Value = 0;
            numberBox_choice_teacherCode.Value = 0;
            dateTimeSelector_choice_prehensionHistory.Value = null;
        }
        public void setPositionOfControle(Control _childControl, Control _parentControle)
        {
            Point p = new Point();

            p = _parentControle.Location;
            p.Y += _parentControle.Height;
            p.X += _parentControle.Width - _childControl.Width;
            _childControl.Location = p;
        }

        bool textInputValidator(TextBox _textBox)
        {
            Regex r = new Regex("[ا-ی]");
            string s;

            foreach (char text in _textBox.Text)
            {
                s = text.ToString();
                if (r.IsMatch(s.ToString()) == false && (s != "آ" && s != "ؤ" && s != "إ" && s != "أ" && s != "ء" && s != " "))
                {
                    return true;
                }
            }
            return false;
        }

        bool textLenghValidator(TextBox _textBox)
        {
            string s = _textBox.Text.ToString();

            if (s.Length < 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool textNullspaceValidator(TextBox _textBox)
        {
            string s = _textBox.Text.ToString();

            if (s[0] == ' ' || s[s.Length - 1] == ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool textMiddleNullSpaceValidator(TextBox _textBox)
        {
            string s = _textBox.Text.ToString();
            int i = 0;

            foreach (char c in s)
            {
                if (String.IsNullOrWhiteSpace(c.ToString()) != true)
                {
                    if (i > 0)
                        i--;
                }
                else
                {
                    i++;
                    if (i == 2)
                        return true;
                }
            }
            return false;
        }

        void textValidatorSystem(TextBox _textBox, Label _lable, Button _buttonInsert, Button _buttonEdite)
        {
            if (_textBox.Text == "")
            {
                _buttonInsert.Enabled = false;
                _buttonEdite.Enabled = false;

                _lable.Text = "";
            }
            else if (textLenghValidator(_textBox))
            {
                _buttonInsert.Enabled = false;
                _buttonEdite.Enabled = false;

                _lable.Text = textLengthValidatorMessage;
                setPositionOfControle(_lable, _textBox);
            }
            else if (textNullspaceValidator(_textBox))
            {
                _buttonInsert.Enabled = false;
                _buttonEdite.Enabled = false;

                _lable.Text = textNullspaceValidatorMessage;
                setPositionOfControle(_lable, _textBox);
            }
            else if (textMiddleNullSpaceValidator(_textBox))
            {
                _buttonInsert.Enabled = false;
                _buttonEdite.Enabled = false;

                _lable.Text = textMiddleNullspaceValidatorMessage;
                setPositionOfControle(_lable, _textBox);
            }
            else if (textInputValidator(_textBox))
            {
                _buttonInsert.Enabled = false;
                _buttonEdite.Enabled = false;

                _lable.Text = textInputValidatorMessage;
                setPositionOfControle(_lable, _textBox);
            }
            else
            {
                _buttonInsert.Enabled = true;
                _buttonEdite.Enabled = true;

                _lable.Text = "";
            }
        }
        //
    }
}
