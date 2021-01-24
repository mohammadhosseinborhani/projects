using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.Sql;

namespace MyProjectCoding
{
    interface IMyProjectRepository
    {
        DataTable SelectAll(string _tablename);
        bool Delete(int _ID, string _tableName, string _rowName,out Exception e);
        bool InsertToStudnets(string _firstName,string _lastName, int _age, out Exception e);
        bool InsertToTeachers(string _firstName, string _lastName, int _age, out Exception e);
        bool InsertToLessons(string _lessonName, string _writerFirstName, string _writerLastName, out Exception e);
        bool InsertToChoice(int _studentID, int _teacherID, int _lessonID, out Exception e);
        bool EditStudents(string _firstName,string _lastName,int _age,int ID, out Exception e);
        bool EditTeachers(string _firstName, string _lastName,int _age,int ID, out Exception e);
        bool EditLessons(string _lessonName, string _writerFirstName, string _writerLastName, int ID, out Exception e);
        DataTable BrowsStudents(string _firstName, string _lastName, int _age, int ID, out Exception e);
        DataTable BrowsTeachers(string _firstName, string _lastName, int _age, int ID, out Exception e);
        DataTable BrowsLessons(string _name, string _writerFirstName, string _writerLastName, int ID, out Exception e);





        void TableChanger(string tableName,string requset);

        DataTable SearchingName(string TheName);

        DataTable SearchingWriter(string TheWriter);

        DataTable SearchingAge(int TheAge);

        //bool Insert(string Name, string Writer);


        
        bool ChoiceRequestForDelete(int id);

        bool Choice_Edit(int id, int Teach_id, int St_id, int Less_id, DateTime? date);

        //bool Choice_Insert( int Teach_id, int St_id, int Less_id, DateTime? date);

        bool Choice_Delete(int id);

        DataTable Choice_SelectAll();

        DataTable SearchingSt_id(int st_id);

        DataTable SearchingTeach_id(int Teach_id);

        DataTable SearchingLess_id(int Less_id);

        DataTable SearchingHistory(DateTime? date);
    }
}
