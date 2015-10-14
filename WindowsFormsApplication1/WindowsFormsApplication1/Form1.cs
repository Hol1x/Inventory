using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.IO;
using System.Timers;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        private AdressCheck AC;
        private System.Timers.Timer aTimer;

        public Form1()
        {
            InitializeComponent();
            Initialize();
            
        }
        //Initialize values
        private void Initialize()
        {
            server = "192.168.220.131";
            database = "test1";
            uid = "user";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            AC = new AdressCheck();

            UpdateBtn.MouseEnter += new EventHandler(UpdateBtn_MouseEnter);
            UpdateBtn.MouseLeave += new EventHandler(UpdateBtn_MouseLeave);
        }

        private void UpdateBtn_MouseLeave(object sender, EventArgs e)
        {
            this.UpdateBtn.Text = "Left";
            this.UpdateBtn.BackColor = Color.Red;
        }

        private void UpdateBtn_MouseEnter(object sender, EventArgs e)
        {
            this.UpdateBtn.Text = "Enterd";
        }

        //open connection to database
        private bool OpenConnection(){
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex) {

                
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        //create new Table
        public void CreateTable(String name) {

            String query = "CREATE TABLE " + name + " (id MEDIUMINT NOT NULL AUTO_INCREMENT,name varchar(25), age int)";

            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Execute command
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done creating table: "+name);
                //close connection
                this.CloseConnection();
            }
        }

        //Insert statement
        public void Insert()
        {
             String query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }



        //Backup
        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "C:\\MySqlBackup" + year + "-" + month + "-" + day +
            "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!");
            }
        }

        //Restore
        public void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert();
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            CreateTable("tableinfo");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            UserControl control = new UserControl();
            Form form2 = new Form();
            form2.MdiParent = this;
            form2.Show();
            //Form Form2 = new Form();
            //Form2.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateBtn.Text = "Updated";
            Update();
        }
        private void UpdateBtn_MouseHover(object sender, EventArgs e) {
            UpdateBtn.Text = "Hover";
            UpdateBtn.BackColor = Color.AliceBlue;
        }

        private void CheckIPbtn_Click(object sender, EventArgs e)
        {
            if (IPcheckBox.Checked)
            {
                aTimer = new System.Timers.Timer();
                aTimer.Interval = 2000;
                aTimer.Elapsed += ATimer_Elapsed;
                aTimer.Start();
            }
        }

        private void ATimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.ipCheckOutput.Text = AC.PingHost(IPtxt.Text).ToString();
        }

        private void LocalServerBtn_Click(object sender, EventArgs e)
        {
            
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ServerStart SS = new ServerStart();
            SS.StartServer();
        }

        private void SendString_Click(object sender, EventArgs e)
        {
            ServerStart SS = new ServerStart();
            SS.SendData();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Console.WriteLine("test");
        }

        private void dunno1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("dunno1 test");
        }
    }
}
