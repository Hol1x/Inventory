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
    public partial class LoadExcel : Form
    {
        
        public LoadExcel()
        {
            InitializeComponent();
            
        }

        private void Done_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(sheetTextBox.Text))
            {
                string PathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathTextBox.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";

                OleDbConnection conn = new OleDbConnection(PathConn);

                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * From [" + sheetTextBox.Text + "$]", conn);

                DataTable dt = new DataTable();

                myDataAdapter.Fill(dt);
               excelImportForm.dataGridView1

            }
            else
            {
                excelImportForm.Shake(this.label2);
            }

        }
    }
}
