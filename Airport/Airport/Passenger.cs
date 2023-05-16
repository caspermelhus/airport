using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport {
    internal class Passenger {
        public int Id;                  //social security number
        public string FirstName;
        public string LastName;
        public int Age;
        public string Nationality;
        
        /// <summary>
        /// 
        /// </summary>
        public Passenger() {
            Id = 0;
            FirstName = "";
            LastName = "";
            Age = 0;
            Nationality = "";

        }


        /// <summary>
        /// This funtion reads user inputs and send it to DBNewPassenger.
        /// </summary>
        public void NewPassenger() {
            //TODO!!!!! Make a library that reads user input and checks that it only contains char or ints
            //          So that user can only enter ints into age and id, and string into the rest

            DBNewPassenger(123, "Billy", "Bob", 66, "USA");

        }

        /// <summary>
        /// 
        /// </summary>
        public void EditPassenger() {


        }

        /// <summary>
        /// 
        /// </summary>
        public void DeletePassenger() {


        }

        /// <summary>
        /// 
        /// </summary>
        public void FindPassenger() {

        }

        /// <summary>
        /// 
        /// </summary>
        public void PrintPassengers() {

        }

        /// <summary>
        /// This function adds the data sent to it to the Passenger database.
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Age"></param>
        /// <param name="Nationality"></param>
        void DBNewPassenger(int Id, string FirstName, string LastName, int Age, string Nationality) {
            connection.Open();
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO Passenger (Id, FirstName, LastName, Age, Nationality) ");
            sb.Append("VALUES (@id, @firstname, @lastname, @age, @nationality);");
            string sql = sb.ToString();
            using (SqlCommand command = new SqlCommand(sql, connection)) {
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@firstname", FirstName);
                command.Parameters.AddWithValue("@lastname", LastName);
                command.Parameters.AddWithValue("@age", Age);
                command.Parameters.AddWithValue("@nationality", Nationality);

                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsAffected + " row(s) inserted");
            }

        }

        void DBEditPassenger() {

        }

        void DBDeletePassenger() {

        }

        void DBFindPassenger() {

        }

        void DBPrintPassenger() {

        }




    }
}
