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
    public partial class Generation_Division : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Generation_Division()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\c#\C# with ms access\LetterRecords.accdb;Persist Security Info=False;";
        }

        private void Generation_Division_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                String query = "select * from GenerationDivision";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Letter Ref No"].ToString());
                }

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into GenerationDivision ([Letter Ref No],[Letter Date],[Letter Subject],[DGM (C&C)letter ref No],[C&C letter date],[Attachment letter Ref no],[Attachment letter date],[AGM (CS) letter ref no],[AGM (CS) letter date])values('" + txt_letterRef.Text + "','" + txt_letterdate.Value.ToString() + "','" + txt_letterSub.Text + "','" + txt_DGM.Text + "','" + date_cc.Value.ToString() + "','" + txt_attach.Text + "','" + date_attach.Value.ToString() + "','" + txt_AGMCSL.Text + "','" + date_AGMCSL.Value.ToString() + "')";

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Saved");
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
                String query = "delete from GenerationDivision where [Letter Ref No]='" + txt_letterRef.Text + "'";
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

        private void txt_letterSub_TextChanged(object sender, EventArgs e)
        {

        }

        private void attachment_Click(object sender, EventArgs e)
        {

        }

        private void attach_date_Click(object sender, EventArgs e)
        {

        }

        private void date_attach_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                String query = "update GenerationDivision set [Letter Date]='" + txt_letterdate.Value.ToString() + "' ,[Letter Subject]='" + txt_letterSub.Text + "' ,[DGM (C&C)letter ref No]='" + txt_DGM.Text + "' ,[C&C letter date]='" + date_cc.Value.ToString() + "' ,[Attachment letter Ref no]='" + txt_attach.Text + "' ,[Attachment letter date]='" + date_attach.Value.ToString() + "' ,[AGM (CS) letter ref no]='" + txt_AGMCSL.Text + "' ,[AGM (CS) letter date]='" + date_AGMCSL.Value.ToString() + "' where [Letter Ref No] = '" + txt_letterRef.Text + "' ";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                String query = "select * from GenerationDivision where [Letter Ref No]='" + comboBox1.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    txt_letterRef.Text = reader["Letter Ref No"].ToString();
                    this.txt_letterdate.Text = reader["Letter Date"].ToString();
                    txt_letterSub.Text = reader["Letter Subject"].ToString();
                    txt_DGM.Text = reader["DGM (C&C)letter ref No"].ToString();
                    this.date_cc.Text = reader["C&C letter date"].ToString();
                    txt_attach.Text = reader["Attachment letter Ref no"].ToString();
                    this.date_attach.Text = reader["Attachment letter date"].ToString();
                    txt_AGMCSL.Text = reader["AGM (CS) letter ref no"].ToString();
                    this.date_AGMCSL.Text = reader["AGM (CS) letter date"].ToString();

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
                String query = "select * from GenerationDivision";

                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    chart1.Series["LETTER DATE"].Points.AddXY(reader["Letter Ref No"].ToString(), reader["Letter Date"].ToString());

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
