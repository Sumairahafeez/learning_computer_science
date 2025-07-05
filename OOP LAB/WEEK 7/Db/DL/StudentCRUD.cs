using Db.BL;
using Db.UI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.DL
{
    internal class StudentCRUD
    {
        public static List<BLStudent> studentList = new List<BLStudent>();
        public List<BLStudent> sortedStudent = new List<BLStudent>();
        public void AddStudent()
        {

            studentList.Add(ULStudent.AddStudent());
        }
        public void SortStudentsAccordingToMerit()
        {

            foreach (BLStudent student in studentList)
            {
                student.CalculateMerit();
            }
            sortedStudent = studentList.OrderByDescending(o => o.merit).ToList();

        }
        public BLStudent StudentPresent(string name)
        {
            foreach (BLStudent s in studentList)
            {
                if (name == s.Name && s.programReg != null)
                {
                    return s;
                }
            }
            return null;
        }
        public static bool ReadData()
        {
            string connectionString = "server = localhost\\SQLEXPRESS01; database = UAMS; trusted_connection = true";
            string query = string.Format("SELECT * FROM Students");
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand Command = new SqlCommand(query, connection);
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {   int studentID = Convert.ToInt32(reader["StudentID"]);
                string name = Convert.ToString(reader["Name"]);
                int age = Convert.ToInt32(reader["Age"]);
                float FSCMarks = Convert.ToSingle(reader["FSCMarks"]);
                float EcatMarks = Convert.ToSingle(reader["EcatMarks"]);
                int DegreeID = Convert.ToInt32(reader["DegreeID"]);
               
                BLDegreeProgram degree = DegreeProgramCRUD.GetStudentDegree(DegreeID);
                
                //float merit = reader.GetFloat(5);
                BLStudent st = new BLStudent(name, age, FSCMarks, EcatMarks);
                st.programReg = degree;
               List<BLSubject> subjects = new List<BLSubject>();
                subjects = SubjectCRUD.GetRegisteredSubject(studentID);
                st.registerSub = subjects;
                studentList.Add(st);
                connection.Close();
                return true;
            }

            return false;
        }
        public static BLStudent StoreData(BLStudent student)
        {
            int DegreeID = DegreeProgramCRUD.GetDegreeId(student.programReg.DegreeTitle);
            string connectionString = "server = localhost\\SQLEXPRESS01; database = UAMS; trusted_connection = true";
            string query = string.Format("INSERT INTO Students VALUES('{0}',{1},{2},{3},{4})",
                  student.Name, student.age, student.FSCMarks, student.EcatMarks,DegreeID);

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand Command = new SqlCommand(query, connection);
            int rowsAffected = Command.ExecuteNonQuery();
            connection.Close();
            if (rowsAffected > 0)
            {
                Console.WriteLine("Data Entered Succesfully");
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.ReadKey();
            return null;
        }
        public static int GetStudentID(string name)
        {
            string connectionString = "server = localhost\\SQLEXPRESS01; database = UAMS; trusted_connection = true";
            string query = string.Format("SELECT StudentID FROM Students WHERE Name =  '{0}'", name);
            using (SqlConnection con = new SqlConnection((connectionString)))
            {
                SqlCommand command = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                int ID = 0;

                while (reader.Read())
                {
                    ID =  Convert.ToInt32(reader["StudentID"]);

                }

                return ID;

            }
        }
    }
}
