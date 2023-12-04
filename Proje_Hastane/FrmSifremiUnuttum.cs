using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmSifremiUnuttum : Form
    {
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
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

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            this.Close();

            List<Form> acikFormlar = new List<Form>();
            //List<Form> acikFormlar = new List<Form>();: acikFormlar adlı bir List oluşturuyoruz.
            //Bu liste, açık formları saklamak için kullanılacak.

            foreach (Form acikForm in Application.OpenForms)
            // Bu döngü, Application.OpenForms koleksiyonu içindeki her formu teker teker ele alır.
            // acikForm değişkeni, her dönüşte bir açık formu temsil eder.
            {

                if (acikForm is FrmSekreterGiris || acikForm is FrmHastaGiris || acikForm is FrmDoktorGiris)
                {
                    //Her formun türünü kontrol ediyoruz. Eğer bir form "FrmSekreterGiris", "FrmHastaGiris"
                    //veya "FrmDoktorGiris" türünden biriyse,
                    //bu formı acikFormlar listesine ekliyoruz.
                    //Bu, sadece belirli türdeki formları almak için bir kontrol işlemidir.
                    acikFormlar.Add(acikForm);
                }
            }
                //acikFormlar Listesine eklenen formu tekrardan görünür hale getiriyoruz.
                //Sadece bir Form açık kalacak şekilde kodlarımızı düzenlediğimizden ötürü
                //acikFormlar listesinde sadece bir eleman olacak
                //Bu sebeple aciFormlar[0].Show yaarak giris sayfamıza geri dönüyoruz.
                acikFormlar[0].Show();
            
        }
    }
}
