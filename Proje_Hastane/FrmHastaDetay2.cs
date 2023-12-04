using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmHastaDetay2 : Form
    {
        
        public FrmHastaDetay2()
        {
            InitializeComponent();
         
        }
        public String tcNo;
        public String hastaAdi, hastaSoyadi;
        DbManager DbManager  = new DbManager();

        
        
       

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

            Anasayfa anaForm = Application.OpenForms["Anasayfa"] as Anasayfa;
            if (anaForm != null)
            {
                anaForm.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

            Anasayfa anaForm = Application.OpenForms["Anasayfa"] as Anasayfa;
            if (anaForm != null)
            {
                anaForm.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgiDuzenle frmHastaBilgiDuzenle = new FrmHastaBilgiDuzenle();
            frmHastaBilgiDuzenle.tcno = tcNo;
            frmHastaBilgiDuzenle.Show();
            this.Hide();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            FrmRandevuAl frm1 = new FrmRandevuAl();
            frm1.tcNo = tcNo;
            frm1.Show();
            this.Hide();
        }

        private void btnRandevularim_Click(object sender, EventArgs e)
        {
            FrmHastaRandevularim frm2 = new FrmHastaRandevularim();
            frm2.tcNo = tcNo;
            frm2.Show();
            this.Hide();
        }

        private void btnRecetelerim_Click(object sender, EventArgs e)
        {
            FrmHastaRecetelerim frm3 = new FrmHastaRecetelerim();
            frm3.tcNo = tcNo;
            frm3.Show();
            this.Hide();
        }

        private void btnTahlillerim_Click(object sender, EventArgs e)
        {
            FrmHastaTahlillerim frm4 = new FrmHastaTahlillerim();
            frm4.tcNo = tcNo;
            frm4.Show();
            this.Hide();
        }

        private void FrmHastaDetay2_Load(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("SELECT HastaAd,HastaSoyad FROM Tbl_Hasta WHERE HastaTC = @tcno", DbManager.baglanti());

            cmd.Parameters.AddWithValue("@tcno", tcNo);

            DbDataReader reader = cmd.ExecuteReader();

            if ( reader.Read())
            {
                hastaAdi = reader["HastaAd"].ToString();
                hastaSoyadi = reader["HastaSoyad"].ToString() ;
            }
            lbl_AdSoyad.Text = hastaAdi+" "+hastaSoyadi;
            lbl_TC.Text = tcNo;
            
            DbManager.baglanti().Close();
        }
    }
}
