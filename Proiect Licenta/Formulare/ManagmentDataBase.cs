using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.CodeDom.Compiler;
using System.Security.Cryptography.X509Certificates;
using System.Data;
using System.Windows.Forms;
using System.Reflection.Metadata.Ecma335;
using System.Reflection;


namespace Proiect_Licenta.Formulare
{
    public class ManagmentDataBase
    {
         public string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryBooks;Integrated Security=True;";
        //Data Source=(localdb)\ProjectModels;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False

        public User User { get; set; }


        public void CreateTableUser()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {


                    string interrogation = "CREATE TABLE USERS(UserID int primary key identity (1,1), Username varchar(50), Cnp varchar(50), Gmail varchar(50), Phone varchar(50), Password varchar(50))";
                    connection.Open();
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    command.ExecuteNonQuery();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.InnerException);
            }

        }

        public void CreateTableSubscription()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string interrogation = "CREATE TABLE SUBSCRIPTION(SubscriptionID int primary key identity(1,1), SubscriptionType varchar(50), SubscriptionPrice decimal(3,2), SubscriptionDuration int, UserID int FOREIGN KEY REFERENCES USERS(UserID))";// 3 cifre inainte de virgula  , 2 cifre dupa virgula,
                    connection.Open();
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error"+ ex.InnerException);
            }
        }



        public void SelectTableSubscription()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string interogation = "SELECT * FROM  SUBSCRIPTION";
                    connection.Open();
                    SqlCommand command = new SqlCommand(interogation, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error"  + ex.InnerException);
            }
        }

        public void InsertIntoTableSubscription()
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    string interrogation = "INSERT INTO  SUBSCRIPTION(SubscriptionType,SubscriptionPrice,SubscriptionDuration)VALUES (@SubscriptionType,@SubscriptionPrice,@SubscriptionDuration)";
                    connection.Open();
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    command.Parameters.AddWithValue("@SubscriptionType", "Basic");
                    command.Parameters.AddWithValue("@SubscriptionPrice", 10.00);
                    command.Parameters.AddWithValue("@SubscriptionDuration", 1);

                    string interrogation1 = "INSERT INTO SUBSCRIPTION(SubscriptionType,SubscriptionPrice,SubscriptionDuration)VALUES (@SubscriptionType1,@SubscriptionPrice1,@SubscriptionDuration1)";
                    SqlCommand command1 = new SqlCommand(interrogation1, connection);
                    command1.Parameters.AddWithValue("@SubscriptionType1", "Premium");
                    command1.Parameters.AddWithValue("@SubscriptionPrice1", 20.00);
                    command1.Parameters.AddWithValue("@SubscriptionDuration1", 1);

                    string interrogation2 = "INSERT INTO SUBSCRIPTION(SubscriptionType,SubscriptionPrice,SubscriptionDuration)VALUES (@SubscriptionType2,@SubscriptionPrice2,@SubscriptionDuration2)";
                    SqlCommand command2 = new SqlCommand(interrogation2, connection);
                    command2.Parameters.AddWithValue("@SubscriptionType2", "Annual");
                    command2.Parameters.AddWithValue("@SubscriptionPrice2", 80.00);
                    command2.Parameters.AddWithValue("@SubscriptionDuration2", 12);

                    command.ExecuteNonQuery();
                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error"+ ex.InnerException);
            }
        }

       
        public void ModifyTableUser()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string interrogation = " ALTER TABLE USERS ADD Country varchar(50)";
                    connection.Open();
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.InnerException);
            }
        }
       

        public void CreateAccountUser(string name, string cnp, string gmail, string phone, string password,string country)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string interrogation = "INSERT INTO USERS (Username,Cnp,Gmail,Phone,Password,Country) VALUES (@Username,@Cnp,@Gmail,@Phone,@Password,@Country) ";
                    connection.Open();
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    command.Parameters.AddWithValue("@Username", name);
                    command.Parameters.AddWithValue("@Cnp", cnp);
                    command.Parameters.AddWithValue("@Gmail", gmail);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Country", country);
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.InnerException);
            }
        }


       
     
        public bool  LoginUser(string a, string b)
        {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {


                    // numar radurile de coloane care indeplinez conditiile din clauza Where
                    string interrogation = $"SELECT COUNT (*) FROM USERS WHERE (Username = @Username AND Password =  @Password)";
                    connection.Open();
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    command.Parameters.AddWithValue("@Username", a);
                    command.Parameters.AddWithValue("@Password", b);
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("The account exist");
                        return true;
                    }

                    return false;
                }
        }
      
       
        public void SelectTableUser()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string interrogation = "SELECT * FROM USERS";
                    connection.Open();
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error"+ ex.InnerException);
            }
        }


    public void CreateTableBook()
        {
            try
            {


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string interrogation = "CREATE TABLE BOOKS(BookID int primary key identity (1,1), NameBook varchar(50), AuthorBook varchar(50))";
                    connection.Open();
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.InnerException);
            }
        }


        public void AllBooks(BookClass[] book)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string interrogation = "INSERT INTO BOOKS (NameBook, AuthorBook ) VALUES (@book[0],@book[1],@book[2],@book[3],@book[4],@book[5],@book[6],@book[7],@book[8],@book[9],@book[10],@book[11],@book[12],@book[13],@book[14],@book[15],@book[16],@book[17],@book[18],@book[19],@book[20],@book[21],@book[22],@book[23])";
                connection.Open();
                SqlCommand command = new SqlCommand(interrogation, connection);

                int i = 0;

                while (i <= book.Length)
                {
                    //evitare injection
                    command.Parameters.AddWithValue("@book[0]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[1]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[2]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[3]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[4]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[5]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[6]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[7]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[8]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[9]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[10]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[11]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[12]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[13]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[14]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[16]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[17]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[18]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[19]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[20]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[21]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[22]", book[i]);
                    i++;
                    command.Parameters.AddWithValue("@book[23]", book[i]);
                }

                command.ExecuteNonQuery();
            }

        }

       public BookClass book1 { get; set; }

        public void BorrowingBook()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string interrogation = $"SELECT  BookId FROM BOOKS WHERE NameBook = {book1.NameBook}";
                    connection.Open();
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    int numberBookId = (int)command.ExecuteScalar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.InnerException);
            }

        }



        public void SelectTableBooks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    string interrogation = "SELECT * FROM BOOKS";
                    connection.Open();
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.InnerException);
               
            }
        }

        public PaymentClass payment { get; set; }

        public void PaymentTable()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string interrogation = "CREATE TABLE PAYMENT (PaymentID int primary key identity(1,1), NumberCard varchar(50), CVV varchar(50), DataExp varchar(50), CardHolder varchar(50)) ";
                    connection.Open();
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    command.ExecuteNonQuery();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.InnerException);
            }
        }

        public void PaymentInfo()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string interrogation = "INSERT INTO PAYMENT(NumberCard,CVV,DataExp,CardHolder)VALUES (@NumberCard,@CVV,@DataExp,@CardHolder)";
                    connection.Open();
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    command.Parameters.AddWithValue("@NumberCard", payment.CardNumber);
                    command.Parameters.AddWithValue("@CVV", payment.CVV);
                    command.Parameters.AddWithValue("@DataExp", payment.Exp);
                    command.Parameters.AddWithValue("@CardHolder", payment.CardHolder);
                    command.ExecuteNonQuery();


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.  InnerException);
            }
        }


        public string ExtractGmail()
        {
            string gmail;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string interogation = "SELECT (Gmail) FROM USERS WHERE Username = @Username"; //returnează numele de conectare al utilizatorului care a efectuat autentificarea curentă în baza de date
                connection.Open();
                SqlCommand command = new SqlCommand(interogation, connection);
                //command.Parameters.AddWithValue("@Username");
                using (SqlDataReader rdr = command.ExecuteReader())
                {
                    gmail = Convert.ToString(rdr["Gmail"]);
                }
            }

            return gmail;
        }


        public string ExtractSubscription() 
        {
            string subsType;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string interogation = "SELECT SubscriptionType FROM CommonTable WHERE Username = CURRENT_USER";
                connection.Open();
                SqlCommand command = new SqlCommand(interogation, connection);
                
                using (SqlDataReader rdr = command.ExecuteReader())
                {
                      subsType = Convert.ToString( rdr["SubscriptionType"]);
                }
                
            }

            return subsType;
        }
        

        string cnp;
        public string ExtractCnp()
        {
             
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string interogation = "SELECT (Cnp) FROM USERS WHERE Username = CURRENT_USER";
                connection.Open();
                SqlCommand command = new SqlCommand(interogation,connection);
                using (SqlDataReader rdr = command.ExecuteReader())
                {
                     cnp = Convert.ToString(rdr["Cnp"]);
                }
            }

            return cnp;
        }

        public User user;
        public int FindAge()
        {
            int year =user.ExtractDataFromCnp(cnp);

            int age = 2024 - year;

            return age;
        }


        string nameUser;
        public string ExtractCurrentUserName()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string interrogation = "SELECT (Username) FROM USERS WHERE Username = @Username";
                connection.Open();
                SqlCommand command = new SqlCommand(interrogation, connection);
                string currentName= System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1]; // vreau functie sa mi gaseasa utilizatorul ce s a logat/creeat cont acum 

                command.Parameters.AddWithValue("@Username", currentName);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nameUser = (string)reader["Username"];
                    }
                }
            }

            return nameUser;
        }

        public void Search(string txt, DataTable table)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string interogation = "SELECT * FROM  BOOKS WHERE NameBook LIKE @NameBook";

                connection.Open();
                SqlCommand command = new SqlCommand(interogation, connection);

                command.Parameters.AddWithValue("@NameBook", txt + "%");

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // incarc datele citite de reader in table 
                    table.Load(reader);
                    // am stocat datele citite de reader in table
                    
                }

            }
        }

        public void CreateTableSubsBasic()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string interrogation = "CREATE TABLE TableSubsB(SubscriptionID int primary key identity(1,1), SubscriptionType varchar(50), SubscriptionPrice decimal(3,2), SubscriptionDuration int, UserID int FOREIGN KEY REFERENCES USERS(UserID))";
                    connection.Open();
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error "+ ex.InnerException);
            }
        }

         //SELECT column_name(s)
         //FROM table1
        //INNER JOIN table2
        //ON table1.column_name = table2.column_name;

        public void SubscBasic()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //SELECT*INTO newtable FROM oldtable= copiaza coloanele dintr un tabel vechi intr un tabel nou 
                    string interrogation = "SELECT * INTO TableSubsB FROM SUBSCRIPTION WHERE SubscriptionType = @SubscriptionType";
                    connection.Open();
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    command.Parameters.AddWithValue("@SubscriptionType", "Basic");
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception EX)
            {
                MessageBox.Show("eRROR "+ EX.InnerException);
            }

        }
        public void UserTableAndTableSubsB()
        {
            try
            {


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string interrogation = "SELECT USERS.UserID,USERS.Username,USERS.Cnp,USERS.Gmail,USERS.Phone,USERS.Password,TableSubsB.SubscriptionType,TableSubsB.SubscriptionPrice,TableSubsB.SubscriptionDuration FROM USERS JOIN TableSubsB ON  USERS.UserID = TableSubsB.UserID";
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception EX)
            {
                MessageBox.Show("error " + EX.InnerException);
            }

        }

        public void CreateTableSubsPremium()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string interrogation = "CREATE TABLE TableSubsPremium(SubscriptionID int primary key identity(1,1), SubscriptionType varchar(50), SubscriptionPrice decimal(3,2), SubscriptionDuration int, UserID int FOREIGN KEY REFERENCES USERS(UserID))";
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error" + ex.InnerException);
            }
        }

        public void SubsPremium()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string interrogation = "SELECT * INTO TableSubsPremium FROM SUBSCRIPTION WHERE SubscriptionType = @SubscriptionType";
                    connection.Open();
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    command.Parameters.AddWithValue("@SubscriptionType", "Premium");
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.InnerException);
            }
        }

        public void UserTableAndTableSubsP()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string interrogation = "SELECT USERS.UserID,USERS.Username,USERS.Cnp,USERS.Gmail,USERS.Phone,USERS.Password,TableSubsPremium.SubscriptionType,TableSubsPremium.SubscriptionPrice,TableSubsPremium.SubscriptionDuration FROM USERS JOIN TableSubsPremium ON  USERS.UserID = TableSubsPremium.UserID";
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.InnerException);
            }
        }

        public void CreateTableSubsAnnualy()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string interrogation = "CREATE TABLE TableSubsA(SubscriptionID int primary key identity(1,1), SubscriptionType varchar(50), SubscriptionPrice decimal(3,2), SubscriptionDuration int, UserID int FOREIGN KEY REFERENCES USERS(UserID))";
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.InnerException);
            }
        }
        public void SubsAnnualy()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string interrogation = "SELECT * INTO TableSubsA FROM SUBSCRIPTION WHERE SubscriptionType = @SubscriptionType";
                    connection.Open();
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    command.Parameters.AddWithValue("@SubscriptionType", "Annual");
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.InnerException);
            }
        }
        public void UserTableAndTableSubsA()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string interrogation = "SELECT USERS.UserID,USERS.Username,USERS.Cnp,USERS.Gmail,USERS.Phone,USERS.Password,TableSubsA.SubscriptionType,TableSubsA.SubscriptionPrice,TableSubsA.SubscriptionDuration FROM USERS JOIN TableSubsA ON  USERS.UserID = TableSubsA.UserID";
                    SqlCommand command = new SqlCommand(interrogation, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error" + ex.InnerException);
            }
        }
        // criptografie cu numere  


    }

}
