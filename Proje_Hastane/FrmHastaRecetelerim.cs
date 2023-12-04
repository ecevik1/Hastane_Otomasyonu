using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmHastaRecetelerim : Form
    {
        public FrmHastaRecetelerim()
        {
            InitializeComponent();
        }

        public String tcNo;
        DbManager dbManager = new DbManager();

        private void FrmHastaRecetelerim_Load(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Select ReceteID,ReceteIcerik From Tbl_Recete Where ReceteHastaTC=@hastatc", dbManager.baglanti());
            cmd1.Parameters.AddWithValue("@hastatc", tcNo);
            DataTable dataTable1 = new DataTable();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(cmd1);
            dataAdapter1.Fill(dataTable1);
            dataGridView1.DataSource = dataTable1;

            dataGridView1.Columns["ReceteID"].Width = 30; // ReceteID sütununun genişliğini ayarlayın
            dataGridView1.Columns["ReceteIcerik"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // ReceteIcerik sütununu otomatik boyutlandırın
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            

            this.Close();

            FrmHastaDetay2 frmHastaDetay2 = Application.OpenForms["frmHastaDetay2"] as FrmHastaDetay2;
            if (frmHastaDetay2 != null)
            {
                frmHastaDetay2.Show();
            }
        }
    }
}
