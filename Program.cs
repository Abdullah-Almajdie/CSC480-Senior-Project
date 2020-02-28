using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace Hospital_Management_System
{  
    //SQL Query class used to issue any SQL command on the database.
    public class SQLQuery
    {
        public const string ALL = "1=1";

        //This specifies the database that system will connect to.
        private static string db = "foo";

        //Used to call database for connection.
        public static string dbname { get => db; set => db = value; }

        //Server string used to establish connection for the SQL commands.
        private static string server = @"(localdb)\MyInstance";

        //Used to call server string for connection.
        public static string servername { get => server; set => server = value; }

        //Connection string used to establish connection
        public static string ConnectionString() => ("Server=" + servername + ";Database=" + dbname + ";Trusted_Connection=true");

        //Checks to see if it is possible to connect to specified connection settings.
        public static bool IsServerConnected()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString()))
            {
                try
                {
                    conn.Open();
                    SqlCommand test = new SqlCommand("SELECT 1", conn);
                    test.ExecuteScalar();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        //Gets the row count of the specified table, column, condition. Uses Count SQL command
        public static int RowCount(string COLUMN, string TABLE, string CONDITION)
        {
            int Count;
            using (SqlConnection conn = new SqlConnection(ConnectionString()))
            {
                //Creates Connection
                conn.Open();
                SqlCommand CountRows = new SqlCommand("SELECT COUNT(" + COLUMN + ") FROM dbo." + TABLE + " WHERE " + CONDITION, conn);
                Count = CountRows.ExecuteNonQuery();
                using (SqlDataReader reader = CountRows.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Count = reader.GetInt32(0);
                    }
                }
            }
            return Count;
        }

        //Gets the column count of specified table from information schema of tables. Uses Count SQL command.
        public static int ColumnCount(string TABLE)
        {
            int cnum = 0;
            using (SqlConnection conn = new SqlConnection(ConnectionString()))
            {
                conn.Open();
                //Counts the number of columns
                SqlCommand CountColumns = new SqlCommand("SELECT COUNT(COLUMN_NAME) FROM " + dbname + ".INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + TABLE + "';", conn);
                using (SqlDataReader reader = CountColumns.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cnum = reader.GetInt32(0);
                    }
                }
            }
            return cnum;
        }

        //Gets the column names of specified table from information schema of tables. Uses SELECT COLUMN_NAME.
        public static string[] ColumnNames(string TABLE)
        {
            string[] CNames = new string[ColumnCount(TABLE)];
            using (SqlConnection conn = new SqlConnection(ConnectionString()))
            {
                //Creates Connection
                conn.Open();

                //Retrieve ColumnNames from schema
                SqlCommand ColumnNames = new SqlCommand("SELECT COLUMN_NAME FROM " + dbname + ".INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + TABLE + "';", conn);
                List<string> listcolumnname = new List<string>();
                using (SqlDataReader reader = ColumnNames.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listcolumnname.Add(reader.GetString(0));
                    }
                }
                CNames = listcolumnname.ToArray();
            }
            return CNames;
        }

        //When called it inserts specified values into corresponding specified columns of a table. Uses INSERT INTO command.
        public static void Insert(string TABLE, string[] COLUMNS, object[] VALUES)
        {

            if (COLUMNS.Length == VALUES.Length)
            {
                string ColumnStr = COLUMNS[0];
                for (int i = 1; i < COLUMNS.Length; i++)
                {
                    ColumnStr += ", " + COLUMNS[i];
                }

                string ValuesStr;

                if (VALUES[0].GetType() == ALL.GetType()) { ValuesStr = "'" + VALUES[0] + "'"; }

                else { ValuesStr = Convert.ToString(VALUES[0]); }

                for (int i = 1; i < VALUES.Length; i++)
                {
                    if (VALUES[i].GetType() == ALL.GetType()) { ValuesStr += ", '" + VALUES[i] + "'"; }
                    else { ValuesStr += ", " + Convert.ToString(VALUES[i]); }
                }

                using (SqlConnection conn = new SqlConnection(ConnectionString()))
                {
                    //Creates Connection
                    conn.Open();
                    SqlCommand insert = new SqlCommand("INSERT INTO " + TABLE + " (" + ColumnStr + ") VALUES (" + ValuesStr + ");", conn);
                    insert.ExecuteNonQuery();
                }
            }
            else MessageBox.Show("Columns and Values Do not equal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Same as insert before but inserts specified values into corresponding existing columns of table. 
        //This means must be a value for every column in the table. Uses INSERT INTO command.
        public static void Insert(string TABLE, object[] VALUES)
        {

            if (VALUES.Length > 1)
            {
                string ValuesStr;

                if (VALUES[0].GetType() == ALL.GetType()) { ValuesStr = "'" + VALUES[0] + "'"; }

                else { ValuesStr = Convert.ToString(VALUES[0]); }

                for (int i = 1; i < VALUES.Length; i++)
                {
                    if (VALUES[i].GetType() == ALL.GetType()) { ValuesStr += ", '" + VALUES[i] + "'"; }
                    else { ValuesStr += ", " + Convert.ToString(VALUES[i]); }
                }

                using (SqlConnection conn = new SqlConnection(ConnectionString()))
                {
                    //Creates Connection
                    conn.Open();
                    SqlCommand insert = new SqlCommand("INSERT INTO " + TABLE + " VALUES (" + ValuesStr + ");", conn);
                    insert.ExecuteNonQuery();
                }
            }
            else MessageBox.Show("Columns and Values Do not equal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Returns a 1 or a 0 if specific cell value exists in a table. Uses IF EXISTS command.
        public static int Exists(string TABLE, string CONDITION)
        {
            int Exists = 0;
            using (SqlConnection conn = new SqlConnection(ConnectionString()))
            {
                //Creates Connection
                conn.Open();
                SqlCommand exist = new SqlCommand("IF EXISTS (SELECT * FROM dbo." + TABLE + " WHERE " + CONDITION + ") SELECT 1 AS returnValue;", conn);
                using (SqlDataReader reader = exist.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Exists = reader.GetInt32(0);
                    }
                }
            }
            //MessageBox.Show(Convert.ToString(Exists), "YES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return Exists;
        }

        //Selects a Single cell value. Must only be used when selecting a single cell value. Uses SELECT command
        public static object SingleSelect(string COLUMN, string TABLE, string CONDITION)
        {
            object value = null;
            using (SqlConnection conn = new SqlConnection(ConnectionString()))
            {
                //Creates Connection
                conn.Open();
                SqlCommand SelectCommand = new SqlCommand("SELECT " + COLUMN + " FROM dbo." + TABLE + " WHERE " + CONDITION, conn);
                using (SqlDataReader reader = SelectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        value = reader.GetValue(0);
                    }
                }
            }
            return value;
        }

        //Uses the datatable class to select an array of columns and values that meet the condition of table and appends the results to a data table. Uses SELECT command.
        public static DataTable SelectTable(string[] COLUMNS, string TABLE, string CONDITION)
        {
            //If I want to use 2d array instead of Data Table class.
            //string[,] results = new string[COLUMNS.Length, RowCount(COLUMNS[0], TABLE, CONDITION)];

            //Creates DataTable object for select statement.
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectionString()))
            {
                //Creates Connection
                conn.Open();

                string ColumnStr = COLUMNS[0];
                for (int i = 1; i < COLUMNS.Length; i++)
                {
                    ColumnStr += ", " + COLUMNS[i];
                }
                SqlCommand SelectCommand = new SqlCommand("SELECT " + ColumnStr + " FROM dbo." + TABLE + " WHERE " + CONDITION, conn);
                using (SqlDataReader reader = SelectCommand.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }

        //Same as SelectTable however it uses an innerjoin to concatenate two tables with values that meet the condition. Uses SELECT and INNER JOIN command.
        public static DataTable JoinSelectTable(string[] COLUMNS, string TABLE1, string TABLE2, string JOINCOL, string CONDITION)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectionString()))
            {
                //Creates Connection
                conn.Open();

                string ColumnStr = COLUMNS[0];
                for (int i = 1; i < COLUMNS.Length; i++)
                {
                    ColumnStr += ", " + COLUMNS[i];
                }
                SqlCommand SelectCommand = new SqlCommand("SELECT " + ColumnStr + " FROM dbo." + TABLE1 + " INNER JOIN dbo." + TABLE2 + " ON " + TABLE1 + "." + JOINCOL + "=" + TABLE2 + "." + JOINCOL + " WHERE " + CONDITION + ";", conn);
                using (SqlDataReader reader = SelectCommand.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }

        //Updates pre-existing row of a table when conditions are met. Uses UPDATE and SET commands.
        public static void UpdateRow(string TABLE, string COLUMN, string VALUE, string CONDITION)
        {
             using (SqlConnection conn = new SqlConnection(ConnectionString()))
                {
                    //Creates Connection
                    conn.Open();
                    SqlCommand update = new SqlCommand("UPDATE " + TABLE + " SET " + COLUMN + " = '" + VALUE + "' WHERE " + CONDITION + ";", conn);
                    update.ExecuteNonQuery();
                }
        }
    }

    //Validation class used by multiple forms in the system to validate text from the user.
    public class Validation
    {
        //This validity uses the system MailAddress type to check if the string is in valid email format. 
        //Does not confirm whether or not the email exists or not.
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        //This validity ensures password has length of eight or more characters, has a symbol, a number, uppercase and lowercase.
        //Source: https://social.msdn.microsoft.com/Forums/vstudio/en-US/5e3f27d2-49af-410a-85a2-3c47e3f77fb1/how-to-check-for-password-strength?forum=csharpgeneral
        public static bool IsValidPassword(string password)
        {
            //Checks for password length
            if (password.Length >= 8)
            {
                //Makes sure there is one uppercase and one lowercase letter
                if (Regex.Match(password, @"^(?=.*[a-z])(?=.*[A-Z]).+$", RegexOptions.ECMAScript).Success)
                {
                    //Make sure there is a number
                    if (Regex.Match(password, @"[0-9]+(\.[0-9][0-9]?)?", RegexOptions.ECMAScript).Success)
                    {
                        //Makes sure there is a symbol
                        if (Regex.Match(password, @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]", RegexOptions.ECMAScript).Success)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Password must have at least one symbol");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password must have at least one number");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Password must have at least one uppercase and one lowercase");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Password must be at least 8 characters");
                return false;
            }
        }
    }

    //Initializes the Log-In form on launch
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SqlInstance());
        }
    }
}
