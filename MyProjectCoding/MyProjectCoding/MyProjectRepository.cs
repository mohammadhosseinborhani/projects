using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyProjectCoding
{
    class MyProjectRepository : IMyProjectRepository
    {
        public static string Request;
        public static string TableName;
        SqlConnection Connection = new SqlConnection("Data Source=DESKTOP-EUL6OQQ\\SIKHORA;Initial Catalog=TheProject;Integrated Security=true");

        public DataTable SelectAll(string _tablename)
        {
            DataTable data = new DataTable();
            string qurey = "Select * From " + _tablename;
            SqlDataAdapter adapter = new SqlDataAdapter(qurey, Connection);
            adapter.Fill(data);
            return data;

        }
        public bool Delete(int _ID, string _tableName, string _rowName, out Exception e)
        {
            string qurey = $"Delete From {_tableName} Where {_rowName} = @ID";
            SqlCommand command = new SqlCommand(qurey, Connection);
            try
            {
                e = null;

                command.Parameters.AddWithValue("@ID", _ID);
                Connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception exception)
            {
                e = exception;
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }
        public bool InsertToStudnets(string _firstName, string _lastName, int _age, out Exception e)
        {
            string qurey = "Insert Into Students (Student_FirstName,Student_LastName,Student_Age) Values(@FirstName,@lastName,@Age)";
            try
            {
                e = null;

                SqlCommand command = new SqlCommand(qurey, Connection);
                command.Parameters.AddWithValue("@FirstName", _firstName);
                command.Parameters.AddWithValue("@lastName", _lastName);
                command.Parameters.AddWithValue("@Age", _age);
                Connection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception exception)
            {
                e = exception;
                return false;
            }
            finally
            {
                Connection.Close();
            }

        }
        public bool InsertToTeachers(string _firstName, string _lastName, int _age, out Exception e)
        {
            string qurey = "Insert Into Teachers (Teacher_FirstName,Teacher_LastName,Teacher_Age) Values(@FirstName,@lastName,@Age)";
            try
            {
                e = null;

                SqlCommand command = new SqlCommand(qurey, Connection);
                command.Parameters.AddWithValue("@FirstName", _firstName);
                command.Parameters.AddWithValue("@lastName", _lastName);
                command.Parameters.AddWithValue("@Age", _age);
                Connection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception exception)
            {
                e = exception;
                return false;
            }
            finally
            {
                Connection.Close();
            }

        }
        public bool InsertToLessons(string _lessonName, string _writerFirstName, string _writerLastName, out Exception e)
        {
            string qurey = "Insert Into Lessons (Lesson_Name,Writer_FirstName,Writer_LastName) Values(@LessonName,@WriterFirstName,@WriterLasteName)";
            try
            {
                e = null;

                SqlCommand command = new SqlCommand(qurey, Connection);
                command.Parameters.AddWithValue("@LessonName", _lessonName);
                command.Parameters.AddWithValue("@WriterFirstName", _writerFirstName);
                command.Parameters.AddWithValue("@WriterLasteName", _writerLastName);
                Connection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception exception)
            {
                e = exception;
                return false;
            }
            finally
            {
                Connection.Close();
            }

        }
        public bool EditStudents(string _firstName, string _lastName, int _age, int ID, out Exception e)
        {
            string qurey = "Update Students Set Student_FirstName = @FirstName,Student_LastName = @LastName ,Student_Age = @Age Where Student_ID = @ID";

            try
            {
                SqlCommand command = new SqlCommand(qurey, Connection);
                command.Parameters.AddWithValue("@FirstName", _firstName);
                command.Parameters.AddWithValue("@LastName", _lastName);
                command.Parameters.AddWithValue("@Age", _age);
                command.Parameters.AddWithValue("@ID", ID);
                Connection.Open();
                command.ExecuteNonQuery();
                e = null;
                return true;
            }

            catch (Exception exception)
            {
                e = exception;
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }
        public bool EditTeachers(string _firstName, string _lastName, int _age, int ID, out Exception e)
        {
            string qurey = "Update Teachers Set Teacher_FirstName = @FirstName,Teacher_LastName = @LastName ,Teacher_Age = @Age Where Teacher_ID = @ID";

            try
            {
                SqlCommand command = new SqlCommand(qurey, Connection);
                command.Parameters.AddWithValue("@FirstName", _firstName);
                command.Parameters.AddWithValue("@LastName", _lastName);
                command.Parameters.AddWithValue("@Age", _age);
                command.Parameters.AddWithValue("@ID", ID);
                Connection.Open();
                command.ExecuteNonQuery();
                e = null;
                return true;
            }

            catch (Exception exception)
            {
                e = exception;
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }
        public bool EditLessons(string _lessonName, string _writerFirstName, string _writerLastName, int ID, out Exception e)
        {
            string qurey = "Update Lessons Set Lesson_Name= @LessonName,Writer_FirstName= @WriterFirstName,Writer_LastName = @WriterLastName Where Lesson_ID = @ID";

            try
            {
                SqlCommand command = new SqlCommand(qurey, Connection);
                command.Parameters.AddWithValue("@LessonName", _lessonName);
                command.Parameters.AddWithValue("@WriterFirstName", _writerFirstName);
                command.Parameters.AddWithValue("@WriterLastName", _writerLastName);
                command.Parameters.AddWithValue("@ID", ID);
                Connection.Open();
                command.ExecuteNonQuery();
                e = null;
                return true;
            }
            catch (Exception exception)
            {
                e = exception;
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }
        public DataTable BrowsStudents(string _firstName, string _lastName, int _age, int ID, out Exception e)
        {
            try
            {
                DataTable data = new DataTable();
                string query = "Select * From Students where";
                SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
                bool isntFirst = false;
                if (_firstName != "" || _lastName != "" || _age != 0 || ID != -1)
                {
                    if (_firstName != "")
                    {
                        adapter.SelectCommand.CommandText += " Student_FirstName like @FirstName";
                        adapter.SelectCommand.Parameters.AddWithValue("@FirstName", "%" + _firstName + "%");
                        isntFirst = true;
                    }

                    if (_lastName != "")
                    {
                        if (isntFirst == true)
                        {
                            adapter.SelectCommand.CommandText += " and ";
                        }
                        else
                        {
                            isntFirst = true;
                        }

                        adapter.SelectCommand.CommandText += "Student_LastName like @LastName";
                        adapter.SelectCommand.Parameters.AddWithValue("@LastName", "%" + _lastName + "%");
                    }

                    if (_age != 0)
                    {
                        if (isntFirst == true)
                        {
                            adapter.SelectCommand.CommandText += " and ";
                        }
                        else
                        {
                            isntFirst = true;
                        }

                        adapter.SelectCommand.CommandText += " Student_Age like @Age";
                        adapter.SelectCommand.Parameters.AddWithValue("@Age", _age);
                    }

                    if (ID != -1)
                    {
                        if (isntFirst == true)
                        {
                            adapter.SelectCommand.CommandText += " and ";
                        }
                        else
                        {
                            isntFirst = true;
                        }

                        adapter.SelectCommand.CommandText += " Student_ID like @ID";
                        adapter.SelectCommand.Parameters.AddWithValue("@ID", ID);
                    }
                }
                else
                {
                    adapter.SelectCommand.CommandText = query.Substring(0, query.Length - 5);
                }
                adapter.Fill(data);
                e = null;
                return data;
            }
            catch (Exception exception)
            {
                e = exception;
                return null;
            }
        }
        public DataTable BrowsTeachers(string _firstName, string _lastName, int _age, int ID, out Exception e)
        {
            try
            {
                DataTable data = new DataTable();
                string query = "Select * From Teachers where";
                SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
                bool isntFirst = false;
                if (_firstName != "" || _lastName != "" || _age != 0 || ID != -1)
                {
                    if (_firstName != "")
                    {
                        adapter.SelectCommand.CommandText += " Teacher_FirstName like @FirstName";
                        adapter.SelectCommand.Parameters.AddWithValue("@FirstName", "%" + _firstName + "%");
                        isntFirst = true;
                    }

                    if (_lastName != "")
                    {
                        if (isntFirst == true)
                        {
                            adapter.SelectCommand.CommandText += " and";
                        }
                        else
                        {
                            isntFirst = true;
                        }

                        adapter.SelectCommand.CommandText += "Teacher_LastName like @LastName";
                        adapter.SelectCommand.Parameters.AddWithValue("@LastName", "%" + _lastName + "%");
                    }

                    if (_age != 0)
                    {
                        if (isntFirst == true)
                        {
                            adapter.SelectCommand.CommandText += " and";
                        }
                        else
                        {
                            isntFirst = true;
                        }

                        adapter.SelectCommand.CommandText += " Teacher_Age like @Age";
                        adapter.SelectCommand.Parameters.AddWithValue("@Age", _age);
                    }

                    if (ID != -1)
                    {
                        if (isntFirst == true)
                        {
                            adapter.SelectCommand.CommandText += " and";
                        }
                        else
                        {
                            isntFirst = true;
                        }

                        adapter.SelectCommand.CommandText += " Teacher_ID like @ID";
                        adapter.SelectCommand.Parameters.AddWithValue("@ID", ID);
                    }
                }
                else
                {
                    adapter.SelectCommand.CommandText = query.Substring(0, query.Length - 5);
                }
                adapter.Fill(data);
                e = null;
                MessageBox.Show(adapter.SelectCommand.CommandText);
                return data;
            }
            catch (Exception exception)
            {
                e = exception;
                return null;
            }
        }
        public DataTable BrowsLessons(string _name, string _writerFirstName, string _writerLastName, int ID, out Exception e)
        {
            try
            {
                DataTable data = new DataTable();
                string query = "Select * From Lessons where";
                SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
                bool isntFirst = false;
                if (_name != "" || _writerFirstName != "" || _writerLastName != "" || ID != -1)
                {
                    if (_name != "")
                    {
                        adapter.SelectCommand.CommandText += " Lesson_Name like @Name";
                        adapter.SelectCommand.Parameters.AddWithValue("@Name", "%" + _name + "%");
                        isntFirst = true;
                    }

                    if (_writerFirstName != "")
                    {
                        if (isntFirst == true)
                        {
                            adapter.SelectCommand.CommandText += " and";
                        }
                        else
                        {
                            isntFirst = true;
                        }

                        adapter.SelectCommand.CommandText += "Lesson_WriterFirstName like @WriterFirstName";
                        adapter.SelectCommand.Parameters.AddWithValue("@WriterFirstName", "%" + _writerFirstName + "%");
                    }

                    if (_writerLastName != "")
                    {
                        if (isntFirst == true)
                        {
                            adapter.SelectCommand.CommandText += " and";
                        }
                        else
                        {
                            isntFirst = true;
                        }

                        adapter.SelectCommand.CommandText += " Lesson_WriterLastName like @WriterLastName";
                        adapter.SelectCommand.Parameters.AddWithValue("@WriterLastName", "%" + _writerLastName + "%");
                    }

                    if (ID != -1)
                    {
                        if (isntFirst == true)
                        {
                            adapter.SelectCommand.CommandText += " and";
                        }
                        else
                        {
                            isntFirst = true;
                        }

                        adapter.SelectCommand.CommandText += " Lesson_ID like @ID";
                        adapter.SelectCommand.Parameters.AddWithValue("@ID", ID);
                    }
                }
                else
                {
                    adapter.SelectCommand.CommandText = query.Substring(0, query.Length - 5);
                }
                adapter.Fill(data);
                e = null;
                MessageBox.Show(adapter.SelectCommand.CommandText);
                return data;
            }
            catch (Exception exception)
            {
                e = exception;
                return null;
            }
        }



        public bool InsertToChoice(int _studentID, int _teacherID, int _LessonID, out Exception e)
        {
            string qurey = "Insert Into Choice (Student_ID,Teacher_ID,Lesson_ID) Values(@StudnetID,@TeacherID,@LessonID)";
            try
            {
                e = null;

                SqlCommand command = new SqlCommand(qurey, Connection);
                command.Parameters.AddWithValue("@StudnetID", _studentID);
                command.Parameters.AddWithValue("@TeacherID", _teacherID);
                command.Parameters.AddWithValue("@LessonID", _LessonID);
                Connection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception exception)
            {
                e = exception;
                return false;
            }
            finally
            {
                Connection.Close();
            }

        }
        public bool ChoiceRequestForDelete(int id)
        {
            string qurey = "Delete From Choice Where Choice." + Request + " = @id";
            SqlCommand command = new SqlCommand(qurey, Connection);

            try
            {
                command.Parameters.AddWithValue("@id", id);
                Connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;

            }
            finally
            {
                Connection.Close();
            }
        }
        public bool Choice_Delete(int id)
        {
            string qurey = "Delete From Choice Where Choice.ID = @Parameter";
            SqlCommand command = new SqlCommand(qurey, Connection);
            try
            {
                command.Parameters.AddWithValue("@Parameter", id);
                Connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;

            }
            finally
            {
                Connection.Close();
            }
        }
        public bool Choice_Edit(int id, int Teach_id, int St_id, int Less_id, DateTime? date)
        {
            string qurey = "Update Choice Set Teach_id = @Teach,St = @Stu , Less_id = @Less, History = @history Where ID = @ID";

            try
            {
                SqlCommand command = new SqlCommand(qurey, Connection);
                command.Parameters.AddWithValue("@Teach", Teach_id);
                command.Parameters.AddWithValue("Stu", St_id);
                command.Parameters.AddWithValue("@Less", Less_id);
                command.Parameters.AddWithValue("@history", date);
                Connection.Open();
                command.ExecuteNonQuery();
                return true;
            }

            catch
            {

                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        //public bool Choice_Insert(int Teach_id, int St_id, int Less_id, DateTime? date)
        //{
        //    string qurey = "Insert Into Choice(Teach_ID,St_ID,Less_ID,History) Values(@Teach,@Stu,@Less,@History)";


        //        SqlCommand command = new SqlCommand(qurey, Connection);
        //        command.Parameters.AddWithValue("@Teach", Teach_id);
        //        command.Parameters.AddWithValue("@Stu", St_id);
        //        command.Parameters.AddWithValue("@Less", Less_id);
        //        command.Parameters.AddWithValue("@History", date);


        //        Connection.Open();
        //        command.ExecuteNonQuery();

        //        return true;


        //}

        public DataTable Choice_SelectAll()
        {
            DataTable data = new DataTable();
            string qurey = "Select Choice.ID,Lesson.Name,student.Name,Teacher.Name,Choice.History from Lesson Inner join (student Inner join(Teacher Inner Join Choice On Teacher.ID = Choice.St_ID)On student.ID = Choice.St_ID)On Lesson.ID = Choice.Less_ID";
            SqlDataAdapter adapter = new SqlDataAdapter(qurey, Connection);
            adapter.Fill(data);
            return data;
        }

        public bool Insert(string Name, string Writer)
        {
            string qurey = "Insert Into " + TableName + "(Name,Writer) Values(@Name,@Writer)";
            try
            {
                SqlCommand command = new SqlCommand(qurey, Connection);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Writer", Writer);

                Connection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch
            {

                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

        public DataTable SearchingAge(int TheAge)
        {
            DataTable data = new DataTable();
            string qurey = "Select * From " + TableName + " Where " + TableName + ".Age = @Age ";
            SqlDataAdapter adapter = new SqlDataAdapter(qurey, Connection);
            adapter.SelectCommand.Parameters.AddWithValue("@Age", TheAge);
            adapter.Fill(data);
            return data;
        }

        public DataTable SearchingHistory(DateTime? date)
        {
            throw new NotImplementedException();
        }

        public DataTable SearchingLess_id(int Less_id)
        {
            throw new NotImplementedException();
        }

        public DataTable SearchingName(string TheName)
        {
            DataTable data = new DataTable();
            string qurey = "Select * From " + TableName + " Where " + TableName + ".Name like @Name ";
            SqlDataAdapter adapter = new SqlDataAdapter(qurey, Connection);
            adapter.SelectCommand.Parameters.AddWithValue("@Name", "%" + TheName + "%");
            adapter.Fill(data);
            return data;
        }

        public DataTable SearchingSt_id(int st_id)
        {
            throw new NotImplementedException();
        }

        public DataTable SearchingTeach_id(int Teach_id)
        {
            throw new NotImplementedException();
        }

        public DataTable SearchingWriter(string TheWriter)
        {
            DataTable data = new DataTable();
            string qurey = "Select * From " + TableName + " Where " + TableName + ".Writer like @Writer ";
            SqlDataAdapter adapter = new SqlDataAdapter(qurey, Connection);
            adapter.SelectCommand.Parameters.AddWithValue("@Writer", "%" + TheWriter + "%");

            adapter.Fill(data);
            return data;
        }

        public void TableChanger(string tableName, string requset)
        {
            TableName = tableName;
            Request = requset;
        }
    }
}
