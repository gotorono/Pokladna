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

            foreach(var p in pokladna)
            {
                lvData.Items.Add(p.DoLvItem());
            }
        }
    }
}
