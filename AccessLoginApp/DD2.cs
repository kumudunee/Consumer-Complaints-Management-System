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
    public partial class DD2 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public DD2()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\c#\C# with ms access\LetterRecords.accdb;Persist Security Info=False;";
        }

        private void DD2_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                String query = "select * from DD2Letterrecords";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["LetterRefNo"].ToString());
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void txt_letterdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_letterSub_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DGM_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_attach_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into DD2Letterrecords ([LetterRefNo],[LetterDate],[LetterSubject],[DGM (C&C) letter ref No],[C&C letter date],[AttachmentletterRef no],[Attachment LetterDate],[AGMCSLetterRef no],[AGMCSLetterDate])values('" + txt_letterRef.Text + "','" + txt_letterdate.Value.ToString() + "','" + txt_letterSub.Text + "','" + txt_DGM.Text + "','" + date_cc.Value.ToString() + "','" + txt_attach.Text + "','" + date_attach.Value.ToString() + "','" + txt_AGMCSL.Text + "','" + date_AGMCSL.Value.ToString() + "')";

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                String query = "update DD2Letterrecords set [LetterDate]='" + txt_letterdate.Value.ToString() + "' ,[LetterSubject]='" + txt_letterSub.Text + "' ,[DGM (C&C) letter ref No]='" + txt_DGM.Text + "' ,[C&C letter date]='" + date_cc.Value.ToString() + "' ,[AttachmentletterRef no]='" + txt_attach.Text + "' ,[Attachment LetterDate]='" + date_attach.Value.ToString() + "' ,[AGMCSLetterRef no]='" + txt_AGMCSL.Text + "' ,[AGMCSLetterDate]='" + date_AGMCSL.Value.ToString() + "' where [LetterRefNo] = '" + txt_letterRef.Text + "' ";
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                String query = "delete from DD2Letterrecords where [LetterRefNo]='" + txt_letterRef.Text + "'";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                String query = "select * from DD2Letterrecords where [LetterRefNo]='" + comboBox1.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    
                    txt_letterRef.Text = reader["LetterRefNo"].ToString();
                    this.txt_letterdate.Text = reader["LetterDate"].ToString();
                    txt_letterSub.Text = reader["LetterSubject"].ToString();
                    txt_DGM.Text = reader["DGM (C&C) letter ref No"].ToString();
                    this.date_cc.Text = reader["C&C letter date"].ToString();
                    txt_attach.Text = reader["AttachmentletterRef no"].ToString();
                    this.date_attach.Text = reader["Attachment LetterDate"].ToString();
                    txt_AGMCSL.Text = reader["AGMCSLetterRef no"].ToString();
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
                String query = "select * from DD2Letterrecords";

                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    chart1.Series["LETTER DATE"].Points.AddXY(reader["LetterRefNo"].ToString(), reader["LetterDate"].ToString());

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
