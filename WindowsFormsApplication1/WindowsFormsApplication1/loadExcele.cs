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
        public loadExcele()
        {
            InitializeComponent();
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
    }
}
