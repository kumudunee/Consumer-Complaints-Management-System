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

namespace AccessLoginApp
{
    public partial class DD1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public DD1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\c#\C# with ms access\LetterRecords.accdb;Persist Security Info=False;";

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into DD1Letterrecords ([Serial number],[LetterRefNo],[LetterDate],[LetterSubject],[DGM (c&C) letter ref no],[C&C letter date],[AttachmentletterRefNo],[Attachment LetterDate],[AGMCSLetterREfNo],[AGMCSLetterDate])values('" + txt_serial.Text+ "','" + txt_letterRef.Text + "','" + txt_letterdate.Value.ToString() + "','" + txt_letterSub.Text + "','" + txt_DGM.Text + "','" + date_cc.Value.ToString() + "','" + txt_attach.Text + "','" + date_attach.Value.ToString() + "','" + txt_AGMCSL.Text + "','" + date_AGMCSL.Value.ToString() + "')";

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void AGMCSL_Click(object sender, EventArgs e)
        {

        }

        private void txt_attach_TextChanged(object sender, EventArgs e)
        {

        }

        private void attach_date_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                String query = "update DD1Letterrecords set [LetterRefNo]='"+ txt_letterRef.Text + "' ,[LetterDate]='"+ txt_letterdate.Value.ToString() + "' ,[LetterSubject]='"+ txt_letterSub.Text + "' ,[DGM (c&C) letter ref no]='"+ txt_DGM.Text + "' ,[C&C letter date]='"+ date_cc.Value.ToString() + "' ,[AttachmentletterRefNo]='"+ txt_attach.Text + "' ,[Attachment LetterDate]='"+ date_attach.Value.ToString() + "' ,[AGMCSLetterREfNo]='"+ txt_AGMCSL.Text + "' ,[AGMCSLetterDate]='"+ date_AGMCSL.Value.ToString() + "' where [Serial number] = '"+ txt_serial.Text + "' ";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Edit Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void DD1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                String query = "select * from DD1Letterrecords";
                command.CommandText = query;
                
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Serial number"].ToString());
                }
                
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                String query = "delete from DD1Letterrecords where [Serial number]='"+ txt_serial.Text + "'";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void date_cc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_letterSub_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_letterRef_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                String query = "select * from DD1Letterrecords where [Serial number]='"+comboBox1.Text+"'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txt_serial.Text = reader["Serial number"].ToString();
                    txt_letterRef.Text = reader["LetterRefNo"].ToString();
                    this.txt_letterdate.Text = reader["LetterDate"].ToString();
                    txt_letterSub.Text = reader["LetterSubject"].ToString();
                    txt_DGM.Text = reader["DGM (c&C) letter ref no"].ToString();
                    this.date_cc.Text = reader["C&C letter date"].ToString();
                    txt_attach.Text = reader["AttachmentletterRefNo"].ToString();
                    this.date_attach.Text = reader["Attachment LetterDate"].ToString();
                    txt_AGMCSL.Text = reader["AGMCSLetterREfNo"].ToString();
                    this.date_AGMCSL.Text = reader["AGMCSLetterDate"].ToString();

                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btn_chart_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                String query = "select * from DD1Letterrecords";
                
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    chart1.Series["LETTER DATE"].Points.AddXY(reader["Serial number"].ToString(), reader["LetterDate"].ToString());

                }
                connection.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
