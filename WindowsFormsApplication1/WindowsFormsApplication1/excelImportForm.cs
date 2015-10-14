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
        public excelImportForm()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = ".xls";
            fileDialog.AddExtension = true;
            fileDialog.Filter = "Files (*.xls)|*.xls";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                this.pathTextBox.Text = fileDialog.FileName;
            }
        }

        private void LoadExcel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(sheetTextBox.Text))
            {
                string PathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathTextBox.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";

                OleDbConnection conn = new OleDbConnection(PathConn);

                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * From [" + sheetTextBox.Text + "$]", conn);

                DataTable dt = new DataTable();

                myDataAdapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            else {
                Shake(label2);
            }
            

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
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
            
            //System.IO.StringWriter writer = new System.IO.StringWriter();
            //dt.WriteXml(writer, XmlWriteMode.WriteSchema, false);
            //PrintOutput(writer, "Customer table, with hierarchy");
            
        }
        private static void PrintOutput(System.IO.TextWriter writer, string caption)
        {
            Console.WriteLine("==============================");
            Console.WriteLine(caption);
            Console.WriteLine("==============================");
            Console.WriteLine(writer.ToString());
        }

        private void LoadSave_Click(object sender, EventArgs e)
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
            }
        }

        private static void Shake(Label form)
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

        private void NewData_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            DataTable load = new DataTable();
            load.Columns.Add("ID",typeof(int));
            load.Columns.Add("name",typeof(string));

            dataGridView1.DataSource = load;
            //dataGridView1.DataSource = dat;
            //You can assign the Column types while initializing
            //DataGridViewColumn d1 = new DataGridViewTextBoxColumn();
            //DataGridViewColumn d2 = new DataGridViewTextBoxColumn();
            //DataGridViewColumn d3 = new DataGridViewCheckBoxColumn();
            //DataGridViewColumn d3 = new DataGridViewImageColumn();

            //Add Header Texts to be displayed on the Columns
            //d1.HeaderText = "ID";
            //d2.HeaderText = "NAMN";
            //d3.HeaderText = "FÄRDIG";

            //Add the Columns to the DataGridView
            //dataGridView1.Columns.AddRange(d1, d2);


            //dataGridView1.Refresh();
            //dataGridView1.EndEdit();
            //Finally add the Rows
            //dataGridView1.Rows.Add(5);
            //dataGridView1.EndEdit();
        }
    }
}
