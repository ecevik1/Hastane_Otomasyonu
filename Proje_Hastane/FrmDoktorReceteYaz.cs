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
    public partial class FrmDoktorReceteYaz : Form
    {
        public FrmDoktorReceteYaz()
        {
            InitializeComponent();
        }
        public String tcNo;
        DbManager dbManager = new DbManager();
        private void btnGonder_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Recete (ReceteIcerik ,ReceteHastaTC) VALUES (@recete ,@hastaTC) ;",dbManager.baglanti());
            cmd.Parameters.AddWithValue("@recete", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@hastaTc", tcNo);
            cmd.ExecuteNonQuery();
            dbManager.baglanti().Close();

            this.Close();
        }
    }
}
