using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokladna_Pavel
{
    public partial class Form1 : Form
    {

        List<PokladniZaznam> pokladna;
        IRepos repositar;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JsonRepos jsonRepos = new JsonRepos("data.json");
            jsonRepos.vytvorTestData();
            repositar = jsonRepos;
            pokladna = repositar.NactiVse();

            Console.WriteLine("Load");

            foreach(var p in pokladna)
            {
                lvData.Items.Add(p.DoLvItem());
                if(!rokCombo.Items.Contains(p.Datum.Year))
                    rokCombo.Items.Add(p.Datum.Year);
                if(!mesicCombo.Items.Contains(p.Datum.Month))
                    mesicCombo.Items.Add(p.Datum.Month);
            }
        }

        private void mesicCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvData.Items.Clear();
            pokladna = repositar.NactiUcetniObdobi(Convert.ToInt32(rokCombo.SelectedItem), Convert.ToInt32(mesicCombo.SelectedItem));

            foreach (var p in pokladna)
            {
                lvData.Items.Add(p.DoLvItem());
            }
        }

        private void rokCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvData.Items.Clear();
            pokladna = repositar.NactiUcetniObdobi(Convert.ToInt32(rokCombo.SelectedItem), Convert.ToInt32(mesicCombo.SelectedItem));

            foreach (var p in pokladna)
            {
                lvData.Items.Add(p.DoLvItem());
            }
        }
    }
}
