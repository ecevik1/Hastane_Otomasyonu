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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        DbManager dbManager = new DbManager();
        public String tcno;


        private void BTnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("UPDATE Tbl_Doktor SET DoktorTelefon = @telno, DoktorSifre = @sifre WHERE DoktorTC = @tcno", dbManager.baglanti());
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

        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT DoktorAd,DoktorSoyad,DoktorTelefon,DoktorBrans,DoktorSifre FROM Tbl_Doktor WHERE DoktorTC = @tcno", dbManager.baglanti());

            cmd.Parameters.AddWithValue("@tcno", tcno);

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblAdSoyad.Text = reader["DoktorAd"].ToString() + "  " + reader["DoktorSoyad"].ToString();

                lblTCNO.Text = tcno;
                lblBrans.Text = reader["DoktorBrans"].ToString();
                TxtSfre.Text = reader["DoktorSifre"].ToString();
                MskTxtTelefon.Text = reader["DoktorTelefon"].ToString();

            }

            dbManager.baglanti().Close();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmDoktorDetay frmDoktorDetay = Application.OpenForms["frmDoktorDetay"] as FrmDoktorDetay;


            if (frmDoktorDetay != null)
            {
                frmDoktorDetay.Show();
            }
        }
    }
}
