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
    public partial class FrmHastaBilgiDuzenle : Form
    {
        public FrmHastaBilgiDuzenle()
        {
            InitializeComponent();
        }
        DbManager dbManager = new DbManager();
        public String tcno;


        private void BTnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("UPDATE Tbl_Hasta SET HastaTelefon = @telno, HastaSifre = @sifre WHERE HastaTC = @tcno", dbManager.baglanti());
                sqlCommand.Parameters.AddWithValue("@tcno", tcno);
                sqlCommand.Parameters.AddWithValue("@telno", MskTxtTelefon.Text);
                sqlCommand.Parameters.AddWithValue("@sifre", TxtSfre.Text);

                int affectedRows = sqlCommand.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi hiçbir kayda etki etmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dbManager.baglanti().Close();
        }

        private void FrmHastaBilgiDuzenle_Load(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand("SELECT HastaAd,HastaSoyad,HastaTelefon,HastaCinsiyet,HastaSifre FROM Tbl_Hasta WHERE HastaTC = @tcno", dbManager.baglanti());

            cmd.Parameters.AddWithValue("@tcno", tcno);

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblAdSoyad.Text = reader["HastaAd"].ToString()+"  "+reader["HastaSoyad"].ToString();
                
                lblTCNO.Text = tcno;
                lblCinsiyet.Text = reader["HastaCinsiyet"].ToString();
                TxtSfre.Text = reader["HastaSifre"].ToString();
                MskTxtTelefon.Text = reader["HastaTelefon"].ToString();  
                
            }

            dbManager.baglanti().Close();

        }

        private void BtnGeri_Click(object sender, EventArgs e)
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
