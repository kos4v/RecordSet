using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.ComponentModel;
using System.Windows.Forms;
using RecordSetProjectForOOAD;

namespace RecordSetProjectForOOAD.Model
{
    class RecordSet
    {
        private string connectionString;
        public RecordSet()
        {
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                    AttachDbFilename=|DataDirectory|\PersonDB.mdf;
                                    Integrated Security=True;
                                    Connect Timeout=30";
        }
        public List<Person> GetPersons()
        {
            List<Person> peoples = new List<Person>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlExpression = "SELECT * FROM [dbo].[Person]";
                try { connection.Open(); }
                catch { return peoples; }
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    peoples.Add(new Person(reader[1].ToString(), reader[2].ToString()));
                }
            }
            return peoples;
        }
        public List<Person> FindPerson(string FullName, string Email)
        {
            List<Person> peoples = new List<Person>();
            int option =0;
            if (!string.IsNullOrEmpty(FullName))
                option = option + 1;
            if (!string.IsNullOrEmpty(Email))
                option = option + 2;
            string sqlExpression = "SELECT * FROM [dbo].[Person] WHERE";
            switch (option)
            {
                case 1:
                    sqlExpression = sqlExpression + " FullName LIKE '%" + FullName + "%'";
                    break;
                case 2:
                    sqlExpression = sqlExpression +" Email LIKE '%" + Email + "%'";
                    break;
                case 3:
                    sqlExpression = sqlExpression + " Email LIKE '%" + Email + "%' AND FullName LIKE '%" + FullName + "%' ";
                    break;
                default:
                    return peoples;
            }

            int number = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (var item in peoples)
                {
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        peoples.Add(new Person(reader[1].ToString(), reader[2].ToString()));
                    }
                    number = command.ExecuteNonQuery();
                }
                connection.Close();
            }
            return peoples;

        }
        public void toDelete(List<Person> deleteContacts)
        {
            int number = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlExpression = "DELETE FROM [dbo].[Person] WHERE";
                connection.Open();
                foreach (var item in deleteContacts)
                {
                    sqlExpression = sqlExpression + " Email LIKE ('%" + item.Email + "%') AND FullName LIKE ('%" + item.FullName + "%')";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    number = command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public string AddRowsPerson(List<Person> peoples)
        {
            int number = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlExpression = "INSERT INTO [dbo].[Person] ( [FullName], [Email]) VALUES";
                foreach (var item in peoples)
                {
                    string values = "( N'" + item.FullName + "', N'" + item.Email + "')";
                    SqlCommand command = new SqlCommand(sqlExpression + values, connection);
                    number = command.ExecuteNonQuery();
                }
                connection.Close();
            }
            return "" + number;
        }
    }
}
