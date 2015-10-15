using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class excelImportForm : Form
    {
        DataTable dat = new DataTable();
        string lastSavedFile;
        public excelImportForm()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
        }

        public DataTable DataGridViewContent{
            get{
            return null;
            }
            set{
                dataGridView1.DataSource = value;
            }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        void OnProcessExit(object sender, EventArgs e)
        {
            Console.WriteLine("I'm out of here");
            
            AutoSave();
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateSaveCounter();
            Console.WriteLine("something happend in counter");
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Update the balance column whenever the value of any cell changes.
            UpdateSaveCounter();
            Console.WriteLine("something happend in counter");
        }

        
        

        private void AutoSave() {
            dataGridView1.EndEdit();
            BindingSource bs = new BindingSource();


            //dat = (DataTable) (dataGridView1.DataSource);
            //dat.AcceptChanges();
            //dat.TableName = "saveData";
            //dat.WriteXml("data.xsd", XmlWriteMode.WriteSchema);

            //BindingSource bs = (BindingSource)dataGridView1.DataSource;
            DataTable dt = dataGridView1.DataSource as DataTable;
            //dataGridView1.Update();
            dt.TableName = "AutoDataSave";
            //SaveFileDialog fileDialog = new SaveFileDialog();
            
                dt.WriteXml(lastSavedFile, XmlWriteMode.WriteSchema);
                System.Windows.Forms.MessageBox.Show("Data Saved");

            
        }

        

        
        public void DataGridViewUpdate(DataTable dt)
        {
            dataGridView1.DataSource = dt;
        }

        public static void Shake(Label form)
        {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 10;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
        }

        

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = ".xsd";
            fileDialog.AddExtension = true;
            fileDialog.Filter = "Files (*.xsd)|*.xsd";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Console.WriteLine("FileDialog Done");
                DataTable dt = new DataTable();
                //Console.WriteLine("Create DataTable ds Done");
                dt.ReadXmlSchema(fileDialog.FileName);
                dt.ReadXml(fileDialog.FileName);
                //Console.WriteLine("ReadXml from FileDialog Done");
                dataGridView1.DataSource = dt;
                //Console.WriteLine("Set dataGridView1.DataSource to DataTable dt Done");
                lastSavedFile = fileDialog.FileName;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dataGridView1.EndEdit();
            BindingSource bs = new BindingSource();


            //dat = (DataTable) (dataGridView1.DataSource);
            //dat.AcceptChanges();
            //dat.TableName = "saveData";
            //dat.WriteXml("data.xsd", XmlWriteMode.WriteSchema);

            //BindingSource bs = (BindingSource)dataGridView1.DataSource;
            DataTable dt = dataGridView1.DataSource as DataTable;
            dataGridView1.Update();
            dt.TableName = "SavedData";
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.DefaultExt = ".xsd";
            fileDialog.AddExtension = true;
            fileDialog.Filter = "Files (*.xsd)|*.xsd";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dt.WriteXml(fileDialog.FileName, XmlWriteMode.WriteSchema);
                System.Windows.Forms.MessageBox.Show("Data Saved");

            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DataTable load = new DataTable();
            load.Columns.Add("ID", typeof(int));
            load.Columns.Add("name", typeof(string));

            dataGridView1.DataSource = load;
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadExcele frm = new loadExcele();
            frm.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true) {
                Console.WriteLine(lastSavedFile);
                if (lastSavedFile != null){
	                System.Threading.Thread.Sleep(2000);
                    AutoSave();
}
            }
            
        }
    }
}
