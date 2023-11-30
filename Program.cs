using localDatabase;
using localDatabase.Database;
using System.Data.SQLite;

// //define location of the file
// string cs =@"URI=file:C:\Users\shali\OneDrive - The University of Alabama\MIS321\source\repos\localDatabase\test.db";

// //create a sqlit connection and use it to open a database
// using var con = new SQLiteConnection(cs);
// //open connection
// con.Open();

// //check version
// string stm = "select SQLITE_VERSION()";

// using var cmd = new SQLiteCommand(stm, con);

// //check version
// string version = cmd.ExecuteScalar().ToString();

// System.Console.WriteLine($"SQLite version: {version}");

// con.Close();

ISeedData savedObject = new SaveData();
savedObject.SeedData();