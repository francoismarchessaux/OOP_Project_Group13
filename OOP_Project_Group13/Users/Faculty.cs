using MySqlConnector;
using OOP_Project_Group13.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//23202 François Marchessaux 23410 Théotime Froget 22839 Louis Faverjon 23215 Victor Guy 23194 César Maurey
namespace OOP_Project_Group13
{
    public class Faculty : User
    {
        MySqlConnection con = Program.GetConnection();
        public List<Class> Classes { get; set; }
        public DateTime birthday { get; set; }
        public string address{ get; set; }
        public Faculty() { }
        
        public Faculty(int Id)
        {
            Classes = new List<Class>();
            String query = "SELECT * FROM users WHERE userID='" + Id + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            string[] info = new string[dt.Columns.Count];
            for (int i = 0; i < dt.Columns.Count; i++)
                info[i] = dt.Rows[0][i].ToString();
            ID = Convert.ToInt32(info[0]);
            name = info[1];
            firstName = info[2];
            status = info[4];
            password = info[5];
            mail = info[6];
            profilePicture = info[3];
            birthday = Convert.ToDateTime(info[7]);
            phone = info[8];
            address = info[9];
            if(info[10] != "")
            {
                string[] classes = info[10].Split(' ');
                for (int i = 0; i < classes.Length; i++)
                {
                    Class c = new Class(classes[i]);
                    Classes.Add(c);
                }
            }
        }
    }
}