using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektNr2_Stepushenkov63334
{
    public partial class KokpitProjektuNr2_Stepushenkov : Form
    {
        public KokpitProjektuNr2_Stepushenkov()
        {
            InitializeComponent();
        }

        private void KokpitProjektuNr2_Stepushenkov_FormClosing(object sender, FormClosingEventArgs e)
        {
            {
                /* utworzenie i wyświetlenie okna dialogowego dla spytania Użytkownika,
                 czy na pewno chce zamknąć aplikacje */
                DialogResult OknoMessage = MessageBox.Show("Czy na pewno chcesz zamknąć aplikacje?",
                    this.Text, MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                // rozpoznanie wybranego przycisku poleceń w oknie dialogowym 'MessageBox'
                if (OknoMessage == DialogResult.Yes)
                {
                    Application.Exit();
                }

                else
                    // anulujemy (kasujemy) zamknięcie formularza
                    e.Cancel = true; // czyli kasujemy zdarzenie zamknięcia formularza

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SzeregLaboratoryjny form2 = new SzeregLaboratoryjny();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SzeregIndywidualny form3 = new SzeregIndywidualny();
            form3.Show();
        }
    }
}