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
                DataTable dt = oleDbConnection.GetSchema("Tables", new string[] { null, null, null, "table" });
                ComboBoxTables.DataSource = dt;
                ComboBoxTables.DisplayMember = "table_name";
                ComboBoxTables.ValueMember = "table_name";
                oleDbConnection.Close();
            }
        }

        private void SelectTables()
        {
            string filePath = TextBoxPathFirstFile.Text;
            string connectionstring = string.Empty;
            if (filePath.EndsWith(".mdb"))
                connectionstring = string.Format("Provider=Microsoft.jet.oledb.4.0;Data Source = " + filePath);
            else
                connectionstring = string.Format("Provider=Microsoft.ace.oledb.12.0;Data Source = " + filePath);
            using (OleDbConnection oleDbConnection = new OleDbConnection(connectionstring))
            {
                OleDbCommand cmd = new OleDbCommand(string.Format(@"SELECT 
                                                                   [cpf]
                                                                  ,[nome]
                                                                  ,[nascimento]
                                                                  ,[matricula]
                                                                  ,[banco_emprestimo]
                                                                  ,[prazo]
                                                                  ,[parcela]
                                                                  ,[contrato]
                                                                  ,[Margem]
                                                                  ,[margem_rmc]
                                                                  ,[fone_atual]
                                                                  ,[fone_atual1]
                                                                  ,[fone_atual2]
                                                                  ,[fone_fixo]
                                                                  ,[fone4]
                                                                  ,[fone5]
                                                                  ,[fone6]
                                                                  ,[fone7]
                                                                  ,[fone8]
                                                                  ,[fone9]
                                                                  ,[cidade]
                                                                  ,[uf]
                                                                  ,[endereco]
                                                                  ,[bairro]
                                                                  ,[cep]
                                                                  ,[orgao]
                                                                  ,[salario]
                                                                  ,[descontos]
                                                                  ,[liquido]
                                                                  ,[agencia]
                                                                  ,[banco]
                                                                  ,[cc]
                                                                  ,[rju]
                                                                  ,[sit]
                                                                  ,[convenio]
                                                              FROM {0}", ComboBoxTables.Text));
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = oleDbConnection;
                oleDbDataAdapter.SelectCommand = cmd;
                DataTable dataTable = new DataTable();
                try
                {
                    oleDbDataAdapter.Fill(dataTable);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return;
                }
                dataGridView1.DataSource = dataTable;
            }
        }

        public static void ReadData(string connectionString, string queryString)
        {
            DataTable dataTable = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);

                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    dataTable = reader.GetSchemaTable();
                }
                reader.Close();
                //dataGridView1.DataSource = dataTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectTables();
        }
    }
}
