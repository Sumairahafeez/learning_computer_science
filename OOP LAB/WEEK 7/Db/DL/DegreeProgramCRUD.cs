using Db.BL;
using Db.UI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.DL
{
    internal class DegreeProgramCRUD
    {
        public static List<BLDegreeProgram> degreesList = new List<BLDegreeProgram>();
        public void AddDegree(SubjectCRUD S)
        {
            degreesList.Add(ULDegree.AddDegree(S));
        }
        public void ViewDegreePrograms()
        {
            foreach (BLDegreeProgram d in degreesList)
            {
                Console.WriteLine(d.DegreeTitle);
            }
        }


        public static BLDegreeProgram ISDegreeExists(string name)
        {
            foreach (BLDegreeProgram B in degreesList)
            {
                if (B.DegreeTitle == name)
                {
                    return B;
                }
            }
            return null;
        }
        public static bool ReadData()
        {
            string connectionString = "server = localhost\\SQLEXPRESS01; database = UAMS; trusted_connection = true";
            string query = "SELECT * FROM Degree";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<BLSubject> subjects = new List<BLSubject>();
                while (reader.Read())
                {
                    int degId = reader.GetInt32(0);
                    string DegreeTitle = reader.GetString(1);
                    int duration = reader.GetInt32(2);
                    int seats = reader.GetInt32(3);
                    subjects = SubjectCRUD.GetDegreSubjects(degId);
                    BLDegreeProgram degree = new BLDegreeProgram(DegreeTitle, duration, seats, subjects);
                    degreesList.Add(degree);
                    return true;
                }
            }
            return false;
        }
        public static bool StoreData(BLDegreeProgram B)
        {
            string connectionString = "server = localhost\\SQLEXPRESS01; database = UAMS; trusted_connection = true";
            
            string query = string.Format("INSERT INTO Degree(DegreeTitle,Duration,Seats)" + "VALUES('{0}',{1},{2})",
                            B.DegreeTitle, B.Duration, B.Seats);
            using(SqlConnection con = new SqlConnection((connectionString)))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if(rowsAffected > 0)
                {
                    return true;
                }
                
            }
            return false;
        }
        public static int GetDegreeId(string title)
        {
            string connectionString = "server = localhost\\SQLEXPRESS01; database = UAMS; trusted_connection = true";
            string query = string.Format("SELECT DegreeID FROM Degree WHERE DegreeTitle =  '{0}'", title);
            using(SqlConnection con = new SqlConnection((connectionString)))
            {
                SqlCommand command = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                int ID = 0;
               
                while(reader.Read())
                {
                    return Convert.ToInt32(reader["DegreeID"]);
                   
                }
                
                return ID;
                
            }
            
        }
        public static BLDegreeProgram GetStudentDegree(int DegreeID)
        {
            string connectionString = "server = localhost\\SQLEXPRESS01; database = UAMS; trusted_connection = true";
            string query = string.Format("SELECT * FROM Degree WHERE DegreeID =  '{0}'", DegreeID);
            using (SqlConnection con = new SqlConnection((connectionString)))
            {
                SqlCommand command = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                {
                    string title = Convert.ToString(reader["DegreeTitle"]);
                    int duration = Convert.ToInt32(reader["Duration"]);
                    int seats = Convert.ToInt32(reader["Seats"]);
                    BLDegreeProgram d = new BLDegreeProgram(title, duration, seats);
                    return d;
                }


                return null;    
                    
                
                
            }
        }
    }
}
