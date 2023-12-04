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
    public partial class FrmHastaRandevularim : Form
    {
        public FrmHastaRandevularim()
        {
            InitializeComponent();
        }
        public String tcNo;
        DbManager dbManager = new DbManager();

        private void FrmHastaRandevularim_Load(object sender, EventArgs e)
        {
            //Randevuları listeleme

            SqlCommand cmd1 = new SqlCommand("Select RandevuTC,RandevuTarih,RandevuSaat,RandevuDoktor From Tbl_Randevu Where RandevuTC=@hastatc and RandevuDurum=1", dbManager.baglanti());
            cmd1.Parameters.AddWithValue("@hastatc", tcNo);
            DataTable dataTable1 = new DataTable();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(cmd1);
            dataAdapter1.Fill(dataTable1);
            dataGridView1.DataSource = dataTable1;
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

        private String selectedRowIn;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

