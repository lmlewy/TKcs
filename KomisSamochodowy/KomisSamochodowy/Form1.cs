using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomisSamochodowy
{
    public partial class Form1 : Form
    {

        private Kontroler _kontroler = new Kontroler();


        public Form1()
        {
            InitializeComponent();
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
            odswierzComboBoxModel();
        }

        private void comboBoxMarka_Click(object sender, EventArgs e)
        {

            var dostepneMarki = _kontroler.PodajMarki();
            comboBoxMarka.DataSource = dostepneMarki;
            //comboBoxModel_Click(sender, e );
            //odswierzComboBoxModel();

        }


        private void comboBoxModel_Click(object sender, EventArgs e)
        {
            odswierzComboBoxModel();
            //var dostepneModele = _kontroler.PodajModele(comboBoxMarka.Text.ToString());
            //comboBoxModel.DataSource = dostepneModele;
            //comboBoxkolor_Click(sender, e);

        }

        private void odswierzComboBoxModel()
        {
            var dostepneModele = _kontroler.PodajModele(comboBoxMarka.Text.ToString());
            comboBoxModel.DataSource = dostepneModele;

        }



        private void comboBoxKolor_Click(object sender, EventArgs e)
        {

            var dostepneKolory = _kontroler.PodajKolory(comboBoxMarka.Text.ToString(), comboBoxModel.Text.ToString());
            comboBoxKolor.DataSource = dostepneKolory;


        }






    }
}
