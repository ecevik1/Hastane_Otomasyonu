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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje_Hastane
{
    public partial class FrmLaborant : Form
    {
        public FrmLaborant()
        {
            InitializeComponent();
        }

        DbManager dbManager = new DbManager();

        


        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = Application.OpenForms["Anasayfa"] as Anasayfa;
            if (anasayfa != null)
            {
                anasayfa.Show();
                this.Close();

            }
        }

            private void refresher()
        {
            this.tbl_TahlilTableAdapter.Fill(this.hastaneVeriTabaniDataSet1.Tbl_Tahlil);
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                String updateQuery = "UPDATE Tbl_Tahlil SET TahlilSonuc = @sonuc, TahlilDurum = 'SONUÇLANDI' WHERE TahlilID = @id";
                SqlCommand cmd = new SqlCommand(updateQuery, dbManager.baglanti());
                cmd.Parameters.AddWithValue("@id", lblID.Text);
                cmd.Parameters.AddWithValue("@sonuc", txtMessage.Text);

                cmd.ExecuteNonQuery();

                refresher();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gönderme Hatası : " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbManager.baglanti().Close();
            }
        }

        private void FrmLaborant_Load(object sender, EventArgs e)
        {
            
           refresher();
            //lblID.Text = "0";

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                lblID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                lblDoktor.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();


                string hastaTc = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                string command = "SELECT TOP 1 HastaAd FROM Tbl_Hasta WHERE HastaTC = @tc";

                SqlCommand cmd = new SqlCommand(command, dbManager.baglanti());
                
                    cmd.Parameters.AddWithValue("@tc", hastaTc);

                   

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string hastaAd = reader["HastaAd"].ToString();
                        lblHasta.Text = hastaAd;
                    }
                    reader.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("DataGridView Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbManager.baglanti().Close();
            }
        }


    }
}
