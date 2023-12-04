using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        DbManager dbManager = new DbManager(); 



        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
           FrmHastaKayıtOl frmHastaKayıt = new FrmHastaKayıtOl();
            frmHastaKayıt.Show();
            this.Close();
            
        }

       

        private void BtnGiris_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Tbl_Hasta WHERE HastaTC = @tc AND HastaSifre = @sifre", dbManager.baglanti());

            cmd.Parameters.AddWithValue("@tc", mskbxTC.Text);
            cmd.Parameters.AddWithValue("@sifre", TxtSfre.Text);

            dbManager.baglanti();

            // Sorguyu çalıştırıp sonucu almak
            int result = (int)cmd.ExecuteScalar();

            dbManager.baglanti().Close();

            // Eşleşme kontrolü
            if (result > 0)
            {
                // Eşleşme bulundu, doğru TC ve şifre
                FrmHastaDetay2 frmHastaDetay2 = new FrmHastaDetay2();
                frmHastaDetay2.tcNo=mskbxTC.Text;
                frmHastaDetay2.Show();
                this.Close();
             
                
               
            }
            else
            {
                // Eşleşme bulunamadı, yanlış TC veya şifre
                MessageBox.Show("Hatalı TC veya şifre. Lütfen tekrar deneyin.");
            }


        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            this.Close();

            Anasayfa anaForm = Application.OpenForms["Anasayfa"] as Anasayfa;
            if (anaForm != null)
            {
                anaForm.Show();
            }
        }

        private void BtnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            FrmSifremiUnuttum sifremiUnuttum = new FrmSifremiUnuttum();
            sifremiUnuttum.Show();
            this.Hide();
        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
