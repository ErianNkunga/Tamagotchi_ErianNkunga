using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les3opdracht1
{
    public partial class frmMoodle : Form
    {
        private int _score;
        private bool _statusscore = false;
        private bool _message = true;
        public frmMoodle()
        {
            InitializeComponent();
        }

        private void pbScore_Click_1(object sender, EventArgs e)
        {

        }


        private void frmMoodle_Load(object sender, EventArgs e)
        {
            try 
            {
            
            // start bij laden programma
            timer1.Start();

            timer2.Start();
            
            }

            catch (System.Exception boodschap)
            {
                MessageBox.Show(boodschap.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // progressbar wordt steeds minder bij 1 
                pbHonger.Increment(-1);
                pbDorst.Increment(-1);

                // als de honger en dorst nul zijn dan gaat de welzijn aftellen
                if (pbHonger.Value < 1 || pbDorst.Value < 1)
                {
                    pbWelzijn.Increment(-1);
                }
                // hier is de code voor de werkende plaatjes
                if (pbWelzijn.Value > 75)
                {
                    pbAfbeelding.Image = Properties.Resources.Doge_meme_100___95;
                    pbAfbeelding.Refresh();
                }
                else if (pbWelzijn.Value < 75 && pbWelzijn.Value > 50)
                {
                    pbAfbeelding.Image = Properties.Resources.doge2;
                    pbAfbeelding.Refresh();
                }
                else if (pbWelzijn.Value < 50 && pbWelzijn.Value > 25)
                {
                    pbAfbeelding.Image = Properties.Resources.Doge_MID;
                    pbAfbeelding.Refresh();
                }
                else if (pbWelzijn.Value < 25 && pbWelzijn.Value > 1)
                {
                    pbAfbeelding.Image = Properties.Resources.doge_15_1;
                    pbAfbeelding.Refresh();
                }
                else if (pbWelzijn.Value == 0)
                {// Als de welzijn null is dan word msgbox gegeven
                    pbAfbeelding.Image = Properties.Resources.RIPdogee;
                    _statusscore = true;
                    if (_message == true)
                    {
                        int descore = _score - 1;
                        _message = false;
                        MessageBox.Show($"Doge is Dood! Jouw score is: {descore} punten.");

                        // als de gebruiker ok heb gedrukt sluit de app
                        Application.Exit();
                    }
                }
            }


            catch (System.Exception boodschap)
            {
                MessageBox.Show(boodschap.Message);
            }
        }

        private void pbHonger_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            { //voegt 5 toe aan honger
                pbHonger.Increment(+5);
            
            }
            catch (System.Exception boodschap)
            {
                MessageBox.Show(boodschap.Message);
            }
        }

        private void bttnDorst_Click(object sender, EventArgs e)
        {
            try
            { 
                //voegt 5 toe aan dorst
                pbDorst.Increment(+5);
            }

            catch (System.Exception boodschap)
            {
                MessageBox.Show(boodschap.Message);
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {// Voor het tellen van de score
            if (_statusscore != true)
            {
                lblGetal.Text = _score++.ToString();
            }
        }
    }
}
