using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeFileMDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSearchPathFileFirst_Click(object sender, EventArgs e)
        {
            string pathFileFirst = this.GetFilePath(sender, new CancelEventArgs());
            TextBoxPathFirstFile.Text = pathFileFirst;
            GetTables();
        }

        private void ButtonSearchPathFileSecond_Click(object sender, EventArgs e)
        {
            string pathFileSecond = this.GetFilePath(sender, new CancelEventArgs());

        }

        private void ButtonSavePathMergeFile_Click(object sender, EventArgs e)
        {
            string pathSaveMergeFile = this.GetFilePath(sender, new CancelEventArgs());

        }

        private string GetFilePath(object sender, CancelEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\giaco\\Downloads\"";
                openFileDialog.Filter = "access|*.accdb;*mdb";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    return openFileDialog.FileName;
            }
            return string.Empty;
        }

        private string tables(object sender, CancelEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\giaco\\Downloads\"";
                openFileDialog.Filter = "access|*.accdb;*mdb";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    return openFileDialog.FileName;
            }
            return string.Empty;
        }

        private void TextBoxMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void GetTables()
        {
            string filePath = TextBoxPathFirstFile.Text;
            string connectionstring = string.Empty;
            if (filePath.EndsWith(".mdb"))
                connectionstring = string.Format("Provider=Microsoft.jet.oledb.4.0;Data Source = " + filePath);
            else
                connectionstring = string.Format("Provider=Microsoft.ace.oledb.12.0;Data Source = " + filePath);

            using (OleDbConnection oleDbConnection = new OleDbConnection(connectionstring))
            {
                oleDbConnection.Open();
                DataTable dt = oleDbConnection.GetSchema();// ("Tables", new string[] { });
                ComboBoxTables.Items.Add(dt.TableName);
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    ComboBoxTables.Items.Add("------------");
                    ComboBoxTables.Items.Add(dt.Columns[i].ColumnName);
                    ComboBoxTables.Items.Add(dt.Columns[i].Table.Rows + "aqui ");
                    ComboBoxTables.Items.Add(dt.Columns[i].DataType);

                }
                //ComboBoxTables.DisplayMember = "table_name";
                //ComboBoxTables.ValueMember = "table_name";
                oleDbConnection.Close();
            }
        }
    }
}
