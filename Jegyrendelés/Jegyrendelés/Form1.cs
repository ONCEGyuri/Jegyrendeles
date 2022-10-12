using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jegyrendelés
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cim_Click(object sender, EventArgs e)
        {

        }

        private void txF_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bSzamolas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Megnyomtad a gombot!");
            //Beolvasom a textBoxból az értéket
            int km = Convert.ToInt32(txKm.Text);

            //km-enként 35 Ft a viteldíj 
            double fizetendo = km * 35;

            //1. osztály (0.): 1.5x
            //2. osztály (1.): 1x
            if (cBOsztaly.SelectedIndex == 0)
            {
                fizetendo *= 1.5;
            }
            //cBOsztaly.SelectedItem: 1. osztály vagy 2. osztály

            //radioGombok kijelölését vizsgálom
            if (rb2.Checked == true)
            {
                //50% kedvezménnyel utazik
                fizetendo *= 0.5;
            }
            if (rb2.Checked == true)
            {
                //90% kedvezménnyel utazik
                fizetendo *= 0.1;
            }

            txF.Text = fizetendo.ToString();
        }
    }
}
