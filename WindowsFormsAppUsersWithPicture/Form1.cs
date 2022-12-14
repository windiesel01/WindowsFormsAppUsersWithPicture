using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppUsersWithPicture
{
    public partial class Form1 : Form
    {
        Database database = new Database();
        public Form1()
        {
            InitializeComponent();
        }
        public void felhasznalokUpdate()
        {
            listBox_felhasznalok.Items.Clear();
            foreach (felhasznalok item in database.getAllFelhasznalo())
            {
                listBox_felhasznalok.Items.Add(item);
            }
        }
        private bool HianyzoAdat()
        {
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Nem adtál meg nevet!");
                textBox_nev.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_kep_neve.Text))
            {
                MessageBox.Show("Nem adatad meg a kép nevét!");
                textBox_kep_neve.Focus();
                return true;
            }
            return false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            felhasznalokUpdate();
        }

        private void hozzáadásToolStripMenuItem_insert_Click(object sender, EventArgs e)
        {
            if (HianyzoAdat())
            {
                return;
            }
            felhasznalok insertFelhasznalok = new felhasznalok(1, textBox_nev.Text, Convert.ToString(dateTimePicker_szuletes.Value),textBox_kep_neve.Text);
            if (database.insertFelhasznalo(insertFelhasznalok))
            {
                MessageBox.Show("Sikeres rögzités!");
                textBox_id.Text = "";
                textBox_nev.Text = "";
                textBox_kep_neve.Text = "";
            }
            else
            {
                MessageBox.Show("Sikertelen rögzités!");
            }
            felhasznalokUpdate();
            
        }

        private void módosításToolStripMenuItem_update_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Program.mainForm.listBox_felhasznalok.Text + " adatainak a módositása");
            felhasznalok ellenorzes = (felhasznalok)Program.mainForm.listBox_felhasznalok.SelectedItem;

            if (HianyzoAdat())
            {
                return;
            }
            felhasznalok updateFelhasznalok = new felhasznalok(1, textBox_nev.Text, Convert.ToString(dateTimePicker_szuletes.Value), textBox_kep_neve.Text);
            if (database.updateFelhasznalok(updateFelhasznalok))
            {
                MessageBox.Show("Sikeres módosítás!");
                textBox_id.Text = "";
                textBox_nev.Text = "";
                textBox_kep_neve.Text = "";
            }
            else
            {
                MessageBox.Show("Sikertelen módosítás!");

            }
            felhasznalokUpdate();
            
        }

        private void listBox_felhasznalok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_felhasznalok.SelectedIndex < 0)
            {
                return;
            }
            felhasznalok kivalasztott_felhasznalo = (felhasznalok)listBox_felhasznalok.SelectedItem;
            textBox_id.Text = kivalasztott_felhasznalo.Id.ToString();
            textBox_nev.Text = kivalasztott_felhasznalo.Nev.ToString();
            dateTimePicker_szuletes.Text = kivalasztott_felhasznalo.Szuletes.ToString();
            textBox_kep_neve.Text = kivalasztott_felhasznalo.Kep.ToString();
            try
            {
                pictureBox_felhasznalo_kep.Image = Image.FromFile(Environment.CurrentDirectory + @"\images\" + kivalasztott_felhasznalo.Kep.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            

        }

        private void törlésToolStripMenuItem_delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Program.mainForm.listBox_felhasznalok.Text + " adatainak a törlése");
            felhasznalok ellenorzes = (felhasznalok)Program.mainForm.listBox_felhasznalok.SelectedItem;

            felhasznalok deleteFelhasznalok = new felhasznalok(1, textBox_nev.Text, Convert.ToString(dateTimePicker_szuletes.Value), textBox_kep_neve.Text);
            if (database.deleteFelhasznalok(deleteFelhasznalok))
            {
                MessageBox.Show(" Sikeres törlés!");
                textBox_id.Text = "";
                textBox_nev.Text = "";
                textBox_kep_neve.Text = "";
            }
            else
            {
                MessageBox.Show(" Sikertelen törlés!");

            }
            felhasznalokUpdate();
        }

        private void képFeltöltésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.CurrentDirectory + @"\images");
        }
    }
}
