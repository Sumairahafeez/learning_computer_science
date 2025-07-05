using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UAMS2.UL;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;


namespace UAMS2
{
    internal class SubjectCRUD
    {
       public static List<BLSubject> Subjects =  new List<BLSubject>();
        public static void AddSubjectsToList(BLSubject s)
        {
            Subjects.Add(s);
        }
       
        public static BLSubject ISSubjectExists(string subjectCode)
        {
            foreach(BLSubject B in Subjects)
            {
                if(B.SubjectCode == subjectCode)
                {
                    return B;
                }
            }
            return null;
        }
        public static bool ReadData()
        {
           
            string connectionString = "server = DESKTOP-HCUI8PD\\SQLEXPRESS; database = DB; trusted_connection = true";
            string query = "SELECT * FROM Subject";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    BLSubject subject = new BLSubject(
                    Convert.ToString(reader["SubjectCode"]),
                    Convert.ToInt32(reader["CreditHours"]),
                    Convert.ToString(reader["SubjectType"]),
                    Convert.ToInt64(reader["SubjectFee"]));
                    Subjects.Add(subject);
                    return true;

                }
              
            }
            return false;
        }
        public static bool StoreData(BLSubject subject)
        {
            string connectionString = "server = DESKTOP-HCUI8PD\\SQLEXPRESS; database = DB; trusted_connection = true";
            string query = string.Format("INSERT INTO SUBJECT VALUES({0},{1},'{2}',{3})", subject.SubjectCode, subject.CreditHours, subject.SubjectType, subject.SubjectFee);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
               
            }
            return false;
        }
        public static BLSubject GetDegreeSubject(string DegreeTitle)
        {
            string conn_str = 
        }
    }
}
