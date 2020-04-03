using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace QRPS
{
    public partial class frmMaster : Form
    {
        public frmMaster()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)


        {

            MySqlConnection conn= new MySqlConnection("datasource=localhost;port=3306;database=qrps;username=root;password=");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM qrps WHERE name LIKE @name", conn);
            cmd.Parameters.AddWithValue("@name", string.Format("%{0}%", txtSearch.Text));
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv.DataSource = dt;
            conn.Close();
            conn.Dispose();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {

                lblCtr.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
                lblPurok.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                lblPook.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
                lblname.Text= dgv.SelectedRows[0].Cells[3].Value.ToString();
                lblm1.Text= dgv.SelectedRows[0].Cells[4].Value.ToString();
                lblm2.Text= dgv.SelectedRows[0].Cells[5].Value.ToString();
                lblm3.Text = dgv.SelectedRows[0].Cells[6].Value.ToString();
                lblm4.Text=dgv.SelectedRows[0].Cells[7].Value.ToString();
                var data = (Byte[])(dgv.SelectedRows[0].Cells["image"].Value);
                var stream = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(stream);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(lblname.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBox2.Image = code.GetGraphic(50);
        }
    }
}
