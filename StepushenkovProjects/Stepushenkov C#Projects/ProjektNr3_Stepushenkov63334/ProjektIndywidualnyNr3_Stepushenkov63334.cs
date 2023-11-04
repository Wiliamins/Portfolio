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
    public partial class KokpitProjekt : Form
    {
        const ushort PromieńPunktu = 2;
        //deklaracja zmiennych refrencyjnych narzędzi graficznych
        //bool kolor = false;
       // Point vvCenter;
        Rectangle vvSquare;
        Point vvEndPoint;
        Point vvStartPoint;
       
        //Point vvRightpoint;
        // Point vvLeftpoint;

        Graphics Rysownica;
        Pen Pióro;
        SolidBrush Pędzel;
        /*deklaracja zmienney 'punkt' dla przechowywania współrzędnych lokalizacji
         *(polożenia) kreślonej krzywej */
        Point Punkt = Point.Empty;//ustawienie współrzędnej: X = 0 oraz Y = 0
        Point vvpx, vvpy;
        int vvx, vvy, vvsX, vvsY, vvcX, vvcY;
        struct OpisKrzywejBeziera
        {
            public Point PunktP0;
            public Point PunktP1;
            public Point PunktP2;
            public Point PunktP3;
            public Point PunktP4;
            public ushort NumerPunktuKontrolnego;
            public float PromieńPunktuKontrolnego;
        }
        OpisKrzywejBeziera KrzywaBeziera;
        Font FontOpisuPunktów = new Font("Arial", 10, FontStyle.Italic);

        public KokpitProjekt()
        {
            InitializeComponent();
            //"podpięcie" BitMapy do kontrolki PictureBox
            vvpbRysownica.Image = new Bitmap(vvpbRysownica.Width, vvpbRysownica.Height);
            //utworzenie egzemplarza powierzchni graficznej na BitMapie
            Rysownica = Graphics.FromImage(vvpbRysownica.Image);
            //utworzenie egzemplarza pióra
            Pióro = new Pen(Color.Red);
            //ustawienie niezbędnych atrybutów linii kreślonych piórem
            Pióro.DashStyle = DashStyle.Dash;
            Pióro.StartCap = LineCap.Round;
            Pióro.EndCap = LineCap.Round;
            //utworzenie egzemplarza pędzla
            Pędzel = new SolidBrush(Color.Blue);
            Rectangle vvrect;
            int vvx, vvy, vvsX, vvsY, vvcX, vvcY;
        }

        private void KokpitProjekt_Load(object sender, EventArgs e)
        {

        }

        private void vvpbRysownica_MouseDown(object sender, MouseEventArgs e)
        {
            
            vvpy = e.Location;
            //wizualizacja aktualnych współrzędnych
            vvlblX.Text = e.Location.X.ToString();
            vvlblY.Text = e.Location.Y.ToString();
            /*sprawdzenie, czy zdarzenie MouseDown zostało 'wywolane'
             * nacisnięciem lewego przycisku myszy*/
            if (e.Button == MouseButtons.Left)
                //tak, to zapamiętamy współrzędne połóżenia myszy
                Punkt = e.Location;
            vvcX = e.X;
            vvcY = e.Y;
            vvStartPoint = new Point(e.X, e.Y);
            vvSquare = new Rectangle();
            vvSquare.X = vvStartPoint.X;
            vvSquare.Y = vvStartPoint.Y;
            Point[] BezierPoints = { vvStartPoint };  





        }

        private void vvpbRysownica_MouseUp(object sender, MouseEventArgs e)
        {
            vvsX = vvx - vvcX;
            vvsY = vvy - vvcY;
             // obsługa zdarzenia MouseUp, to wykreślenia krzywej geometrycznej 
            //wizualizacja aktualnych współrzędnych
            vvlblX.Text = e.Location.X.ToString();
            vvlblY.Text = e.Location.Y.ToString();
            /*sprawdzenie, czy zdarzenie MouseUp zostało 'wywołane' zwolnienie lewego przycisku myszy*/
            if (e.Button == MouseButtons.Left) ;
            {//tak, wykreślamy odpowiednią krzywą, którą musimy teraz rozpoznać
             //czy zaznaczona (wybrana) jest kontrolka RadioButton dla punktu
                if (vvrdbProstokąt.Checked)
                {
                    Rysownica.DrawRectangle(Pióro, vvcX, vvcY, vvsX, vvsY);
                   
                }
                if (vvrdbKwadrat.Checked)
                {

                    Rysownica.DrawRectangle(Pióro, vvSquare.X, vvSquare.Y, vvSquare.Width, vvSquare.Height);
                    
                    
                }
                if (vvrdbProstokątWypelniony.Checked) 
                {
                    Rysownica.FillRectangle(Pędzel, vvcX, vvcY, vvsX, vvsY);
                }
                if (vvrdbKwadratWypelniony.Checked)
                {

                    Rysownica.FillRectangle(Pędzel,vvSquare.X, vvSquare.Y, vvSquare.Width, vvSquare.Height);
                }
                if (vvrdbElipsa.Checked)
                {
                    Rysownica.DrawEllipse(Pióro, vvcX, vvcY, vvsX, vvsY);
                }
                if (vvrdbElipsaWypelniona.Checked)
                {
                    Rysownica.FillEllipse(Pędzel, vvcX, vvcY, vvsX, vvsY);
                }
                if (vvrdbOkrąg.Checked)
                {
                    Rysownica.DrawEllipse(Pióro, new Rectangle(vvSquare.X, vvSquare.Y, vvSquare.Width, vvSquare.Height));
                }
                if (vvrdbOkrągWypelniony.Checked)
                {
                    Rysownica.FillEllipse(Pędzel, vvSquare.X, vvSquare.Y, 90, 90);
                }
                if (vvrdbKrzywaBeziera.Checked)
                {
                    if (vvgrbFigury_Linie.Enabled)
                    {
                        vvgrbFigury_Linie.Enabled = false;
                        KrzywaBeziera.NumerPunktuKontrolnego = 0;
                        KrzywaBeziera.PromieńPunktuKontrolnego = 5;
                        KrzywaBeziera.PunktP0 = e.Location;
                        KrzywaBeziera.PunktP4 = KrzywaBeziera.PunktP0;
                        using (SolidBrush PędzelB = new SolidBrush(Color.Black))
                        {
                            Rysownica.FillEllipse(PędzelB, e.Location.X - KrzywaBeziera.PromieńPunktuKontrolnego, e.Location.Y - KrzywaBeziera.PromieńPunktuKontrolnego,
                                2 * KrzywaBeziera.PromieńPunktuKontrolnego, 2 * KrzywaBeziera.PromieńPunktuKontrolnego);
                            Rysownica.DrawString("p" + KrzywaBeziera.NumerPunktuKontrolnego.ToString(), FontOpisuPunktów, PędzelB, e.Location);

                        }
                    

                    }
                    else
                    {
                        KrzywaBeziera.NumerPunktuKontrolnego++;
                        switch (KrzywaBeziera.NumerPunktuKontrolnego)
                        {
                            case 1: KrzywaBeziera.PunktP1 = e.Location; break;
                            case 2: KrzywaBeziera.PunktP2 = e.Location; break;
                            case 3: KrzywaBeziera.PunktP3 = e.Location; break;
                            

                        }
                        if (KrzywaBeziera.NumerPunktuKontrolnego < 3)
                        {
                            using (SolidBrush PędzelB = new SolidBrush(Color.Red))
                            {
                                Rysownica.FillEllipse(PędzelB, e.Location.X - KrzywaBeziera.PromieńPunktuKontrolnego, e.Location.Y - KrzywaBeziera.PromieńPunktuKontrolnego,
                                    2 * KrzywaBeziera.PromieńPunktuKontrolnego,
                                    2 * KrzywaBeziera.PromieńPunktuKontrolnego);
                                Rysownica.DrawString("p" + KrzywaBeziera.NumerPunktuKontrolnego.ToString(),
                                    FontOpisuPunktów, PędzelB, e.Location);
                            }


                        }
                        else
                        {
                            using (SolidBrush PędzelB = new SolidBrush(Color.Black))
                            {
                                Rysownica.FillEllipse(PędzelB,
                                    e.Location.X - KrzywaBeziera.PromieńPunktuKontrolnego,
                                    e.Location.Y - KrzywaBeziera.PromieńPunktuKontrolnego,
                                    2 * KrzywaBeziera.PromieńPunktuKontrolnego,
                                    2 * KrzywaBeziera.PromieńPunktuKontrolnego);
                                Rysownica.DrawString("p" + KrzywaBeziera.NumerPunktuKontrolnego.ToString(), FontOpisuPunktów, PędzelB, e.Location);
                            }
                            Rysownica.DrawBezier(Pióro, KrzywaBeziera.PunktP0,
                                KrzywaBeziera.PunktP1,
                                KrzywaBeziera.PunktP2,
                                KrzywaBeziera.PunktP3
                                );

                            vvgrbFigury_Linie.Enabled = true;
                        }
                    }
                    
                }
                if (vvrdbSklejanaKrzywaBeziera.Checked)
                {

                }
                if (vvrdbKrzywaKardynalna.Checked)
                {


                }

            }
            vvpbRysownica.Refresh();
        }
        
        private void vvpbRysownica_MouseMove(object sender, MouseEventArgs e)
        {
            //obsługa przesunięcia myszy na powierchni graficznej
            //wizualizacja aktualnych współrzędnych
            vvlblX.Text = e.Location.X.ToString();
            vvlblY.Text = e.Location.Y.ToString();
            /* sprawdzenie, czy zdarzenie MouseMove zostało 'wywolane' przy wciśniętym lewym przycisku myszy */
            if (e.Button == MouseButtons.Left)
            //tak, wykreślamy krzywą o zmienianych rozmiarach
            {//czy jest zaznaczona jest kontrolka RadioButton dla 'Linii kreślonej myszą'
                
                    
                vvpbRysownica.Refresh();
                vvx = e.X;
                vvy = e.Y;
                vvsX = e.X - e.X;
                vvsY = e.Y - e.Y;


            }
            if (vvrdbKwadrat.Checked)
            {
                
                vvEndPoint = new Point(e.X, e.Y);
                int vvmaxLength = Math.Max(vvEndPoint.X - vvStartPoint.X, vvEndPoint.Y - vvStartPoint.Y);
                vvSquare.Width = vvmaxLength;
                vvSquare.Height = vvmaxLength;
                //Point[] vvCenterr = new Point[vvmaxLength / 2];
                //vvRightpoint = new Point(e.X, vvStartPoint.Y);
                //vvLeftpoint = new Point(vvStartPoint.X, e.Y);



            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void vvrdbElipsa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void vvrdbKrzywaBeziera_CheckedChanged(object sender, EventArgs e)
        {
            if (vvrdbKrzywaBeziera.Checked)
            {
                MessageBox.Show("Wykreślenie krzywej beziera wymaga zaznaczenia" +
                    "(kliknięciem) 4 punktów na Rysownicy",
                    "kreślenie Krzywej Beziera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void vvExitZFormularza_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vvRestartProgramu_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void vvZapisPliku_Click(object sender, EventArgs e)
        {
            vvsaveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (vvsaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (vvpbRysownica.Image == null)
                {
                    vvpbRysownica.Image.Save(vvsaveFileDialog1.FileName);
                }
            }
        }

        private void vvkolorLinii_Click(object sender, EventArgs e)
        {
            if (vvcolorDialog1.ShowDialog() == DialogResult.OK)
            {
                Pióro.Color = vvcolorDialog1.Color;
            }
        }

        private void vvKolorTlaRysownicy_Click(object sender, EventArgs e)
        {
            if (vvcolorDialog2.ShowDialog() == DialogResult.OK)
            {
                vvpbRysownica.BackColor = vvcolorDialog2.Color;
            }
        }

        private void vvKolorWypelnienia_Click(object sender, EventArgs e)
        {
            if (vvcolorDialog3.ShowDialog() == DialogResult.OK) ;
            {
                Pędzel.Color = vvcolorDialog3.Color;
            }
        }
    }
}
