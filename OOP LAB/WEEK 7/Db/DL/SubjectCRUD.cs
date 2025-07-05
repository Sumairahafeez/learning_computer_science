using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Db
{
    internal class SubjectCRUD
    {
        public static List<BLSubject> Subjects = new List<BLSubject>();
        public static void AddSubjectsToList(BLSubject s)
        {
            Subjects.Add(s);
        }
        public static bool ReadData()
        {  
            string connectionString = "server = localhost\\SQLEXPRESS01; database = UAMS; trusted_connection = true";
            string query = "SELECT * FROM Subject";
            using(SqlConnection connection = new SqlConnection(connectionString))
            {   SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
               SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    BLSubject subject = new BLSubject(
                    Convert.ToString(reader["SubjectCode"]),
                    Convert.ToInt32(reader["CreditHours"]),
                    Convert.ToString(reader["SubjectType"]),
                    Convert.ToInt64(reader["SubjectFee"]));
                    Subjects.Add(subject);
                    return true;
                    
                }
                return false;
            }
           
        }
        public static BLSubject StoreDataInDegrees(BLSubject subject,int DegreeId)
        {
            string connectionString = "server = localhost\\SQLEXPRESS01; database = UAMS; trusted_connection = true";
            string query = string.Format("INSERT INTO SUBJECT VALUES({0},{1},'{2}',{3},{4})", subject.SubjectCode, subject.CreditHours, subject.SubjectType, subject.SubjectFee,DegreeId);
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                        }
                catch
                {
                    Console.WriteLine("Error");
                }
                
               
                
               
                return null;
            }
        }
        public static List<BLSubject> GetDegreSubjects(int degreeID)
        {
            string conStr = "server = localhost\\SQLEXPRESS01; database = UAMS; trusted_connection = true";
            string query = string.Format("SELECT * FROM Subject Where DegreeID = " + degreeID);
            using(SqlConnection connection = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand(query,connection);
                connection.Open ();
                SqlDataReader reader = cmd.ExecuteReader();
                List<BLSubject> subjects = new List<BLSubject>();
                while (reader.Read())
                {
                    BLSubject subject = new BLSubject(
                    Convert.ToString(reader["SubjectCode"]),
                    Convert.ToInt32(reader["CreditHours"]),
                    Convert.ToString(reader["SubjectType"]),
                    Convert.ToInt64(reader["SubjectFee"]));
                    subjects.Add(subject);
                    

                }
                return subjects;
            }
        }
        public static List<BLSubject> GetRegisteredSubject(int StudentID)
        {
            string conStr = "server = localhost\\SQLEXPRESS01; database = UAMS; trusted_connection = true";
            string query = string.Format("SELECT * FROM Subject Where DegreeID = " + StudentID);
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<BLSubject> subjects = new List<BLSubject>();
                while (reader.Read())
                {
                    BLSubject subject = new BLSubject(
                    Convert.ToString(reader["SubjectCode"]),
                    Convert.ToInt32(reader["CreditHours"]),
                    Convert.ToString(reader["SubjectType"]),
                    Convert.ToInt64(reader["SubjectFee"]));
                    subjects.Add(subject);


                }
                return subjects;
            }
        }
        public static bool AddStudentID(int studentID,string subjectCode)
        {
            string connectionString = "server = localhost\\SQLEXPRESS01; database = UAMS; trusted_connection = true";
            string query = string.Format("INSERT INTO SUBJECT(StudentID) VALUES({0} WHERE SubjectCode = '{1}')", studentID, subjectCode);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;   
                }
                return false;
            }
        }
    }
}
