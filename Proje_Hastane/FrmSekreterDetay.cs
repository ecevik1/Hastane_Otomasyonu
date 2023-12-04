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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = Application.OpenForms["Anasayfa"] as Anasayfa;
            if (anasayfa != null)
            {
                anasayfa.Close();
            }
        }
        DbManager dbManager = new DbManager();
        public String tcNo,adsoyad;


        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmSekreterDoktorPanel frm = new FrmSekreterDoktorPanel();
            frm.Show();
            this.Hide();
            
        }

        private void btnPoliklinik_Click(object sender, EventArgs e)
        {
            FrmPoliklinik frmPoliklinik = new FrmPoliklinik();
            frmPoliklinik.ShowDialog();
        }

        private void btnDuyuru_Click(object sender, EventArgs e)
        {

        }

        private void BtnRandevuPanel_Click(object sender, EventArgs e)
        {

        }

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("Select SekreterAd,SekreterSoyad From Tbl_Sekreter Where SekreterTC=@tc ",dbManager.baglanti());
            cmd.Parameters.AddWithValue("@tc", tcNo);

            SqlDataReader reader=cmd.ExecuteReader();

            while(reader.Read())
            {
                adsoyad = (reader["SekreterAd"].ToString()+" " + reader["SekreterSoyad"].ToString());
            }

            lbl_AdSoyad.Text = adsoyad;
            lbl_TC.Text = tcNo;
            reader.Close();
            dbManager.baglanti().Close();
        }
    }
}
