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
    public partial class loadExcele : Form
    {
        bool edited = false;
        string initText = "Blad1";
        
        public loadExcele()
        {
            
            InitializeComponent();
            sheetTextBox.Text = initText;
        }

        private void Done_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(pathTextBox.Text))
  {
	  if (!string.IsNullOrWhiteSpace(sheetTextBox.Text))
	            {
	                string PathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathTextBox.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
	
	                OleDbConnection conn = new OleDbConnection(PathConn);
	
	                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * From [" + sheetTextBox.Text + "$]", conn);
	
	                DataTable dt = new DataTable();
	
	                myDataAdapter.Fill(dt);
                    excelImportForm frm = (excelImportForm)Application.OpenForms["excelImportForm"];
                    
                    if (frm != null)
                    {
                    	frm.DataGridViewContent = dt;
                    }
	                
                    this.Close();
	
	            }
	            else
	            {
	                excelImportForm.Shake(this.label2);
	            }
  } 
  else
  {
                excelImportForm.Shake(this.label1);
  }

        }

        private void ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = ".xls";
            fileDialog.AddExtension = true;
            fileDialog.Filter = "Files (*.xls)|*.xls";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pathTextBox.Text = fileDialog.FileName;
            }
        }

        private void sheetTextBox_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(edited);
        }
        
        private void sheetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            edited = !char.IsControl(e.KeyChar);
            Console.WriteLine("KeyPressed " + edited);
        }

        private void sheetTextBox_Enter(object sender, EventArgs e)
        {
            if (!edited) sheetTextBox.Clear();
            Console.WriteLine("Enter "+edited );
        }

        private void sheetTextBox_Leave(object sender, EventArgs e)
        {
            if (!edited) sheetTextBox.Text = initText;
            Console.WriteLine("Leave "+ edited);
        }

        private void sheetTextBox_Leave_1(object sender, EventArgs e)
        {
            Console.WriteLine("Leave " + edited);
        }

        private void pathTextBox_DragOver(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

        }

        private void pathTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            string s = "";

            foreach (string File in FileList)
                s = s + " " + File;
            pathTextBox.Text = s;
        }

        private void loadExcele_Load(object sender, EventArgs e)
        {
            pathTextBox.AllowDrop = true;
            pathTextBox.DragEnter += new DragEventHandler(pathTextBox_DragEnter);
            pathTextBox.DragDrop += new DragEventHandler(pathTextBox_DragDrop);
        }

        private void pathTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            string s = "";

            foreach (string File in FileList)
                s = s + " " + File;
            pathTextBox.Text = s;
        }

        private void pathTextBox_DragLeave(object sender, EventArgs e)
        {
            pathTextBox.Text = "";
        }
    }
}
