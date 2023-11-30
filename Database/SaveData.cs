
using System.Data.SQLite;

namespace localDatabase.Database
{
    public class SaveData : ISeedData //implement interface in SaveDat class
    {
        public void SeedData() {
            //define location of the file
        
            string cs =@"URI=file:C:\Users\shali\OneDrive - The University of Alabama\MIS321\source\repos\localDatabase\test.db";

            //create a sqlit connection and use it to open a database
            using var con = new SQLiteConnection(cs);
            //open connection
            con.Open();

            //create command then pass the connection 
            using var cmd = new SQLiteCommand(con);

            //Drop table if it exist
            cmd.CommandText = "DROP TABLE IF EXISTS books";
            cmd.ExecuteNonQuery(); //drop table

            //Create A new table called "books"
            cmd.CommandText = @"CREATE TABLE books(id INTEGER_PRIMARY KEY, title TEXT, author TEXT)"; //sql statment
            cmd.ExecuteNonQuery();

            //I
            cmd.CommandText = @"INSERT INTO books(title, author VALUES (@title, @author)";
            //set prepared parameters
            cmd.Parameters.AddWithValue("@title", "Mistborn");
            cmd.Parameters.AddWithValue("@author", "Branden Sanderson");
            cmd.Prepare();
            cmd.ExecuteNonQuery();

             cmd.CommandText = @"INSERT INTO books(title, author VALUES (@title, @author)";
            //set prepared parameters
            cmd.Parameters.AddWithValue("@title", "Oatbringer");
            cmd.Parameters.AddWithValue("@author", "Branden Sanderson");
            cmd.Prepare();
            cmd.ExecuteNonQuery();





           // con.Close();
        }
    }
}