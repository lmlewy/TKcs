using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KomisSamochodowy
{
    public partial class Form1 : Form
    {

        private Kontroler _kontroler = new Kontroler();


        public Form1()
        {
            InitializeComponent();
            var dostepneMarki = _kontroler.PodajMarki();
            comboBoxMarka.DataSource = dostepneMarki;
            comboBoxMarka.SelectedIndex = 0;

            var dostepneModele = _kontroler.PodajModele(comboBoxMarka.Text.ToString());
            comboBoxModel.DataSource = dostepneModele;
            comboBoxModel.SelectedIndex = 0;

            var dostepneSilniki = _kontroler.PodajSilniki(comboBoxMarka.Text.ToString(), comboBoxModel.Text.ToString());
            comboBoxSilnik.DataSource = dostepneSilniki;
            comboBoxSilnik.SelectedIndex = 0;

            checkBoxMetalic.Checked = false;
            var dostepneKolory = _kontroler.PodajKolory(comboBoxMarka.Text.ToString(), comboBoxModel.Text.ToString(),
                                                        comboBoxSilnik.Text.ToString(), checkBoxMetalic.Checked);
            comboBoxKolor.DataSource = dostepneKolory;
            comboBoxKolor.SelectedIndex = 0;
        }

        private void koniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _kontroler.DodajSamochod();
        }

        private void comboBoxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dostepneModele = _kontroler.PodajModele(comboBoxMarka.Text.ToString());
            comboBoxModel.DataSource = dostepneModele;
            comboBoxModel.SelectedIndex = 0;
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
            var dostepneSilniki = _kontroler.PodajSilniki(comboBoxMarka.Text.ToString(), comboBoxModel.Text.ToString());
            comboBoxSilnik.DataSource = dostepneSilniki;
            comboBoxSilnik.SelectedIndex = 0;

            //var dostepneKolory = _kontroler.PodajKolory(comboBoxMarka.Text.ToString(), comboBoxModel.Text.ToString());
            //comboBoxKolor.DataSource = dostepneKolory;
        }

        private void comboBoxSilnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            uaktualnijListeKolorow();
        }

        private void checkBoxMetalic_CheckStateChanged(object sender, EventArgs e)
        {
            uaktualnijListeKolorow();
        }

        private void uaktualnijListeKolorow()
        {
            var dostepneKolory = _kontroler.PodajKolory(comboBoxMarka.Text.ToString(), comboBoxModel.Text.ToString(),
                                                        comboBoxSilnik.Text.ToString(), checkBoxMetalic.Checked);
            comboBoxKolor.DataSource = dostepneKolory;
            comboBoxKolor.SelectedIndex = 0;
        }

        private void comboBoxKolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string sciezka = "E:/_podyplomowe2/przedmioty/TK/KomisSamochodowyCs/KomisSamochodowy/zdjecia/";

                pictureBoxSamochod.SizeMode = PictureBoxSizeMode.StretchImage;
                //pictureBoxSamochod.ImageLocation = "E:/_podyplomowe2/przedmioty/TK/KomisSamochodowyCs/KomisSamochodowy/zdjecia/126Pomaranczowy.jpg";

                sciezka = sciezka + _kontroler.PodajZdjecie(comboBoxMarka.Text.ToString(), comboBoxModel.Text.ToString(), comboBoxSilnik.Text.ToString(), comboBoxKolor.Text.ToString()) + ".jpg";
                pictureBoxSamochod.ImageLocation = sciezka;


            }
            catch
            {

            }


        }













    }
}
