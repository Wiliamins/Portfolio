using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektNr3_Stepushenkov63334
{

    public partial class KokpitLab : Form
    {//deklaracje stałych dla potrzeb kreślenia krzywych geometrycznych
        const ushort PromieńPunktu = 2;
        //deklaracja zmiennych refrencyjnych narzędzi graficznych

        Graphics Rysownica;
        Pen Pióro;
        SolidBrush Pędzel;
        /*deklaracja zmienney 'punkt' dla przechowywania współrzędnych lokalizacji
         *(polożenia) kreślonej krzywej */
        Point Punkt = Point.Empty;//ustawienie współrzędnej: X = 0 oraz Y = 0
        public KokpitLab()
        {
            InitializeComponent();
            //"podpięcie" BitMapy do kontrolki PictureBox
            pbRysownica.Image = new Bitmap (pbRysownica.Width, pbRysownica.Height);
            //utworzenie egzemplarza powierzchni graficznej na BitMapie
            Rysownica = Graphics.FromImage(pbRysownica.Image);
            //utworzenie egzemplarza pióra
            Pióro = new Pen(Color.Red, 1.7F);
            //ustawienie niezbędnych atrybutów linii kreślonych piórem
            Pióro.DashStyle = DashStyle.Dash;
            Pióro.StartCap = LineCap.Round;
            Pióro.EndCap = LineCap.Round;
            //utworzenie egzemplarza pędzla
            Pędzel = new SolidBrush(Color.Blue);
           
           

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void pbRysownica_MouseDown(object sender, MouseEventArgs e)
        {
            //wizualizacja aktualnych współrzędnych
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();
            /*sprawdzenie, czy zdarzenie MouseDown zostało 'wywolane'
             * nacisnięciem lewego przycisku myszy*/
            if (e.Button == MouseButtons.Left)
                //tak, to zapamiętamy współrzędne połóżenia myszy
                Punkt = e.Location;
        }
        private void pbRysownica_MouseUp(object sender, MouseEventArgs e)
        {
            int LewyGórnyNarożnikX = (Punkt.X > e.Location.X) ? e.Location.X : Punkt.X;
            int LewyGórnyNarożnikY = (Punkt.Y > e.Location.Y) ? e.Location.Y : Punkt.Y;
            int Szerokość = Math.Abs(Punkt.X - e.Location.X);
            int Wysokość = Math.Abs(Punkt.Y - e.Location.Y);
            // obsługa zdarzenia MouseUp, to wykreślenia krzywej geometrycznej 
            //wizualizacja aktualnych współrzędnych
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();
            /*sprawdzenie, czy zdarzenie MouseUp zostało 'wywołane' zwolnienie lewego przycisku myszy*/
            if (e.Button == MouseButtons.Left);
            {//tak, wykreślamy odpowiednią krzywą, którą musimy teraz rozpoznać
                //czy zaznaczona (wybrana) jest kontrolka RadioButton dla punktu
                if (rdbPunkt.Checked)
                    //wykreślamy punkt
                    Rysownica.FillEllipse(Pędzel, Punkt.X - PromieńPunktu,
                        Punkt.Y - PromieńPunktu,
                        2 * PromieńPunktu,
                        2 * PromieńPunktu);
                /*czy zaznaczona (wybrana) jest kontrolka RadioButton dla 'LiniiProstej' */
                if (rdbLiniaProsta.Checked)
                    //tak, to wykreślamy linię prostą
                    Rysownica.DrawLine(Pióro, Punkt.X, Punkt.Y, e.Location.X, e.Location.Y);
                /* czy zaznaczona (wybrana) jest kontrolka RadioButton dla 'LiniiKreślonejMyszą'*/
                if (rdbLiniaKreślonaMyszą.Checked)
                    //tak, to wykreślamy ostatni odcinek linii kreślonej myszą 
                    Rysownica.DrawLine(Pióro, Punkt.X, Punkt.Y, e.Location.X, e.Location.Y);
                if (rdbWielokatForemny.Checked)
                {
                    ushort StopieńWielokąta;
                    int PromieńWielokąta;
                    double KątMiędzyWierzchołkamiWielokąta;
                    double KątPolożeniaPierwszegoWierzchłkaWielokąta = 0.0;

                    numUD_LiczbaKątów.Enabled = false;

                    PromieńWielokąta = Szerokość;
                    StopieńWielokąta = (ushort)numUD_LiczbaKątów.Value;
                    KątMiędzyWierzchołkamiWielokąta = 360F / StopieńWielokąta;
                    Point[] WierzchołkamiWielokąta = new Point[StopieńWielokąta];

                    for (int i = 0; i < StopieńWielokąta; i++)
                    {
                        WierzchołkamiWielokąta[i].X = LewyGórnyNarożnikX + (int)(PromieńWielokąta * Math.Cos(Math.PI * (KątPolożeniaPierwszegoWierzchłkaWielokąta + i * KątMiędzyWierzchołkamiWielokąta) / 180));
                        WierzchołkamiWielokąta[i].Y = LewyGórnyNarożnikY - (int)(PromieńWielokąta * Math.Sin(Math.PI * (KątPolożeniaPierwszegoWierzchłkaWielokąta + i * KątMiędzyWierzchołkamiWielokąta) / 180));
                    }

                    Rysownica.DrawPolygon(Pióro, WierzchołkamiWielokąta);
                }
                if (rdbWielokatWypelniony.Checked)
                {
                    ushort StopieńWielokątaWypełnionego;
                    int PromieńWielokątaWypełnionego;
                    double KątMiędzyWierzchołkamiWielokątaWypełnionego;
                    double KątPolożeniaPierwszegoWierzchłkaWielokątaWypełnionego = 0.0;

                    numUD_LiczbaKątów2.Enabled = false;

                    PromieńWielokątaWypełnionego = Szerokość;
                    StopieńWielokątaWypełnionego = (ushort)numUD_LiczbaKątów2.Value;
                    KątMiędzyWierzchołkamiWielokątaWypełnionego = 360F / StopieńWielokątaWypełnionego;
                    Point[] WierzchołkamiWielokątaWypełnionego = new Point[StopieńWielokątaWypełnionego];

                    for (int i = 0; i < StopieńWielokątaWypełnionego; i++)
                    {
                        WierzchołkamiWielokątaWypełnionego[i].X = LewyGórnyNarożnikX + (int)(PromieńWielokątaWypełnionego * Math.Cos(Math.PI * (KątPolożeniaPierwszegoWierzchłkaWielokątaWypełnionego + i * KątMiędzyWierzchołkamiWielokątaWypełnionego) / 180));
                        WierzchołkamiWielokątaWypełnionego[i].Y = LewyGórnyNarożnikY - (int)(PromieńWielokątaWypełnionego * Math.Sin(Math.PI * (KątPolożeniaPierwszegoWierzchłkaWielokątaWypełnionego + i * KątMiędzyWierzchołkamiWielokątaWypełnionego) / 180));
                    }

                    Rysownica.FillPolygon(Pędzel, WierzchołkamiWielokątaWypełnionego);
                }
                if (rdbTrójkątSierpińskiego.Checked)
                {
                    ushort poziomRekurencji = (ushort)numUD_PoziomRekurencji.Value;
                    Point WierzchołeGórny = new Point(LewyGórnyNarożnikX + Szerokość / 2, LewyGórnyNarożnikY);
                    Point WierzchołeLewy = new Point(LewyGórnyNarożnikX, LewyGórnyNarożnikY + Wysokość);
                    Point WierzchołePrawy = new Point(LewyGórnyNarożnikX + Szerokość, LewyGórnyNarożnikY + Wysokość);
                    WykreślTrójkątSierpińskiego(Rysownica, poziomRekurencji, kolorWypełnieniaToolStripMenuItem.BackColor, WierzchołeGórny, WierzchołeLewy, WierzchołePrawy);
                }




            }
            pbRysownica.Refresh();
        }
        private void pbRysownica_MouseMove(object sender, MouseEventArgs e)
        {  //obsługa przesunięcia myszy na powierchni graficznej
            //wizualizacja aktualnych współrzędnych
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();
            /* sprawdzenie, czy zdarzenie MouseMove zostało 'wywolane' przy wciśniętym lewym przycisku myszy */
            if (e.Button == MouseButtons.Left)
            //tak, wykreślamy krzywą o zmienianych rozmiarach
            {//czy jest zaznaczona jest kontrolka RadioButton dla 'Linii kreślonej myszą'
                if (rdbLiniaKreślonaMyszą.Checked)
                /*tak, to kreślimy "mały odcinek linii prostej i "przesuwamy" zmienną Punkt na koniec wykreślenego odcinku*/
                {//wykreślamy ten mały odzinek
                    Rysownica.DrawLine(Pióro, Punkt.X, Punkt.Y, e.Location.X, e.Location.Y);
                    //przesuwamy zmienną Punkt na koniec wykreślenego odcinka
                    Punkt = e.Location;

                }
                pbRysownica.Refresh();
            }



        }
        
        private void kolorLinii_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                 Pióro.Color = colorDialog1.Color;
            }
        }

        private void ExitZFormularza_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KolorTlaRysownicy_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                pbRysownica.BackColor = colorDialog2.Color;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void zapisanieTablicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(pbRysownica.Image == null)
                {
                    pbRysownica.Image.Save(saveFileDialog1.FileName);
                }
            }
        }

        private void odczytanieTablicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }
        private void rdbWielokatForemny_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWielokatForemny.Checked)
            {
                //MessageBox.Show("Wykreślenie wielokąta foremnego wymaga podania stopnia wielokąta, czyli liczby katów wielokata (minimalny stopień wielokąta jest równy 3)", "Wykreślanie wielokąta foremnego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblLiczbaKątów.Visible = true;
                numUD_LiczbaKątów.Visible = true;
                numUD_LiczbaKątów.Enabled = true;
                numUD_LiczbaKątów.Minimum = 3;
            }

            else
            {
                lblLiczbaKątów.Visible = false;
                numUD_LiczbaKątów.Visible = false;
            }
        }
        private void rdbWielokatWypelniony_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbWielokatWypelniony.Checked)
            {
                //MessageBox.Show("Wykreślenie wielokąta wypełnionego foremnego wymaga podania stopnia wielokąta, czyli liczby katów wielokata (minimalny stopień wielokąta jest równy 3)", "Wykreślanie wielokąta foremnego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblLiczbaKątów.Visible = true;
                numUD_LiczbaKątów2.Visible = true;
                numUD_LiczbaKątów2.Enabled = true;
                numUD_LiczbaKątów2.Minimum = 3;
            }

            else
            {
                lblLiczbaKątów.Visible = false;
                numUD_LiczbaKątów2.Visible = false;
            }
        }

        private void kolorWypełnieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog3.ShowDialog() == DialogResult.OK) ;
            {
                Pędzel.Color = colorDialog3.Color;
            }
        }
        void WykreślTrójkątSierpińskiego(Graphics Rysownica, int poziomRekurencji, Color KolorWypiełnienia, Point WierzchołeGórny, Point WierzchołeLewy, Point WierzchołePrawy)
        {//sprawdzenie warunku zakończenia rekurencji
            if (poziomRekurencji == 0)
            {/*wpisujemy do tablicy WierzchołkiTrójkata współrzędne wierzchołków trójkata, które podane są w liście prametrów metody*/
                Point[] WierzchołkiTrójkąta = { WierzchołeGórny, WierzchołeLewy, WierzchołePrawy };
                //ustawienie koloru wypełmiemia
                Pędzel.Color = colorDialog3.Color;
                Rysownica.FillPolygon(Pędzel, WierzchołkiTrójkąta);
                
            }

            else
            {
                Point PunktSrodkowyLewejKrawędzi = new Point((WierzchołeGórny.X + WierzchołeLewy.X) / 2, (WierzchołeGórny.Y + WierzchołeLewy.Y) / 2);
                Point PunktSrodkowyPrawejKrawędzi = new Point((WierzchołeGórny.X + WierzchołePrawy.X) / 2, (WierzchołeGórny.Y + WierzchołePrawy.Y) / 2);
                Point PunktSrodkowyDolneKrawędzi = new Point((WierzchołeLewy.X + WierzchołePrawy.X) / 2, (WierzchołeLewy.Y + WierzchołePrawy.Y) / 2);

                WykreślTrójkątSierpińskiego(Rysownica, poziomRekurencji - 1, KolorWypiełnienia, WierzchołeGórny, PunktSrodkowyLewejKrawędzi, PunktSrodkowyPrawejKrawędzi);
                WykreślTrójkątSierpińskiego(Rysownica, poziomRekurencji - 1, KolorWypiełnienia, PunktSrodkowyLewejKrawędzi, WierzchołeLewy, PunktSrodkowyDolneKrawędzi);
                WykreślTrójkątSierpińskiego(Rysownica, poziomRekurencji - 1, KolorWypiełnienia, PunktSrodkowyPrawejKrawędzi, PunktSrodkowyDolneKrawędzi, WierzchołePrawy);
            }
        }
        void DywanSierpińskiego(Graphics Rysownica, int poziomRekurencji, Color KolorWypełnienia, Point WierchołeGórnyLewy, Point WierchołeGórnyPrawy, Point WierchołęDolnyLewy, Point WierchołeDolnyPrawy)
        {
            if (poziomRekurencji ==0)
            {
                Point[] WierchołkiDywanu = { WierchołeGórnyLewy, WierchołeGórnyPrawy, WierchołęDolnyLewy, WierchołeDolnyPrawy };
                Pędzel.Color = colorDialog4.Color;
                Rysownica.FillPolygon(Pędzel, WierchołkiDywanu);
            }
            else
            {
                Point PunktSrodkowyGL = new Point((WierchołeGórnyLewy.X + WierchołeDolnyPrawy.X) / 3, (WierchołeGórnyLewy.Y + WierchołeDolnyPrawy.Y) / 3);
                Point PunktSrodkowyDP = new Point((WierchołeDolnyPrawy.X + WierchołęDolnyLewy.X) / 3, (WierchołęDolnyLewy.Y + WierchołęDolnyLewy.Y) / 3);

                DywanSierpińskiego(Rysownica, poziomRekurencji - 1, KolorWypełnienia, WierchołeGórnyLewy, PunktSrodkowyDP, PunktSrodkowyGL);
                DywanSierpińskiego(Rysownica, poziomRekurencji - 1, KolorWypełnienia, WierchołeGórnyPrawy, PunktSrodkowyDP, PunktSrodkowyGL);
                DywanSierpińskiego(Rysownica, poziomRekurencji - 1, KolorWypełnienia, WierchołęDolnyLewy, PunktSrodkowyDP, PunktSrodkowyGL);
                DywanSierpińskiego(Rysownica, poziomRekurencji - 1, KolorWypełnienia, WierchołeDolnyPrawy, PunktSrodkowyDP, PunktSrodkowyGL);

            }
        }
        private void rdbDywan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDywan.Checked)
            {
                //MessageBox.Show("Wykreślenie Trójkąta Sierpińskiego wymaga podania poziomu rekurencji (od 0 w górę) oraz wybrania koloru wypiełnienia\n" + "UWAGA: można też przyjąć ustawienia domyśle ...", "Kreślenie ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numUD_PoziomRekurencji.Value = 3;
                kolorWypełnieniaToolStripMenuItem.BackColor = Color.Yellow;
                lblPoziomRekurencji.Visible = true;
                numUD_PoziomRekurencji.Visible = true;

                numUD_PoziomRekurencji.Enabled = true;

            }

            else
            {
                lblPoziomRekurencji.Visible = false;
                numUD_PoziomRekurencji.Visible = false;

            }
        }
        private void DywanSierpińskiego(Graphics rysownica, int v, Color kolorWypełnienia, Point wierchołeGórnyLewy, Point punktSrodkowyDP, Point punktSrodkowyGL)
        {
            throw new NotImplementedException();
        }

        private void rdbTrójkąt_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTrójkątSierpińskiego.Checked)
            {
                //MessageBox.Show("Wykreślenie Trójkąta Sierpińskiego wymaga podania poziomu rekurencji (od 0 w górę) oraz wybrania koloru wypiełnienia\n" + "UWAGA: można też przyjąć ustawienia domyśle ...", "Kreślenie ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numUD_PoziomRekurencji.Value = 3;
                kolorWypełnieniaToolStripMenuItem.BackColor = Color.Yellow;
                lblPoziomRekurencji.Visible = true;
                numUD_PoziomRekurencji.Visible = true;
               
                numUD_PoziomRekurencji.Enabled = true;
               
            }

            else
            {
                lblPoziomRekurencji.Visible = false;
                numUD_PoziomRekurencji.Visible = false;
                
            }
        }

        private void KokpitLab_Load(object sender, EventArgs e)
        {

        }
    }
}