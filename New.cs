using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace QRPS
{
    public partial class frmNew : Form
    {
        public frmNew()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void frmNew_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;database=qrps;username=root;password=");

            MySqlCommand command;
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            String insertQuery = "INSERT INTO qrps.qrps(purok,pook,name,member1,member2,member3,member4,image) VALUES(@purok, @pook, @name, @mem1, @mem2, @mem3, @mem4, @img)";

            connection.Open();

            command = new MySqlCommand(insertQuery, connection);

            command.Parameters.Add("@purok", MySqlDbType.VarChar);
            command.Parameters.Add("@pook", MySqlDbType.VarChar);
            command.Parameters.Add("@name", MySqlDbType.VarChar);
            command.Parameters.Add("@mem1", MySqlDbType.VarChar);
            command.Parameters.Add("@mem2", MySqlDbType.VarChar);
            command.Parameters.Add("@mem3", MySqlDbType.VarChar);
            command.Parameters.Add("@mem4", MySqlDbType.VarChar);

            command.Parameters.Add("@img", MySqlDbType.Blob);

            command.Parameters["@purok"].Value = txtpurok.Text;
            command.Parameters["@pook"].Value = txtPook.Text;
            command.Parameters["@name"].Value = txtName.Text;
            command.Parameters["@mem1"].Value = txtmem1.Text;
            command.Parameters["@mem2"].Value = txtmem2.Text;
            command.Parameters["@mem3"].Value = txtmem3.Text;
            command.Parameters["@mem4"].Value = txtmem4.Text;
            command.Parameters["@img"].Value = img;

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data Inserted");

                txtpurok.Text = "";
                txtPook.Clear();
                txtName.Clear();
                txtmem1.Clear();
                txtmem2.Clear();
                txtmem3.Clear();
                txtmem4.Clear();
                pictureBox1.Image = null;

            }

            connection.Close();
        }
    }

}
    

