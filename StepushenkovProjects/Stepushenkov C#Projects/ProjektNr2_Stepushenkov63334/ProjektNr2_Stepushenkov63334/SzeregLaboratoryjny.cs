using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// dodanie nowej przestrzeni nazw, dla potrzeb kontrolki 'chart' 
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjektNr2_Stepushenkov63334
{ // deklaracja stałych opisujących granice przedziału zbieżności
    public partial class SzeregLaboratoryjny : Form
    {
        const float DgXd = float.MinValue;
        const float GgXg = float.MaxValue;
        //deklaracja zmiennej referencyjnej tablicy dwuwymiarowej
        float[,] TWS;

        public DialogResult PytanieDoUżytkownika { get; private set; }

        public SzeregLaboratoryjny() // konstruktor
        {
            InitializeComponent();

            dgvTWS.Visible = false;
            chtWykresSzeregu.Visible = false;
        }
        private void btnSzeregLaboratoryjny_Click(object sender, EventArgs e)
        { /* sprawdzenie, czy w kolekcji OpenForms jest już egzemplarza
           formularza SzeregLaboratoryjny*/
            foreach (Form Formularz in Application.OpenForms)
                /* sprawdzenie czy zidentyfikowany formularz w kolekcji
                 OpenForms jest egzemplarzem formularza SzeregLaboratoryjnego */
                if (Formularz.Name == "SzeregLaboratoryjny")
                { // ukrycie bieżącego formularza, którego referencję udostępnia autoreferencja: this 
                    this.Hide(); /* można też opuścić autoreferencję: this, czyli ukrycie bieżącego formularza można zapisać tak: Hide(); */
                    // odsłonięcie formularza SzeregLaboratoryjny
                    Formularz.Show();
                    // zakończenie (wyjście z) obsługi zdarzenia Click dla przycisku poleceń btnSzeregLaboratoryjny
                    return;
                }
            /* gdy "będziemy tutaj", to będzie to oznaczało, że formularz SzeregLaboratoryjny nie był jeszcze utworzony, 
             to go tworzymy i odsłaniamy */
            // utworzenie egzemlarza formularza SzeregLaboratiryjny
            SzeregLaboratoryjny AnalizatorSzeregu = new SzeregLaboratoryjny();
            // odsłonięcie nowego formularza
            AnalizatorSzeregu.Show();
            // ukrycie bieżącego formularza, czyli formularza głównego 
            this.Hide();
        }

        private void btnObliczSumeSzeregu_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            float X, Eps;
            if (!PobranieDanychWejściowych_X_Eps(out X, out Eps))
                return;

            float Suma;
            ushort LicznikWyrazów;
            //MessageBox.Show("Jestem przed wywołaniem metody ObliczWartośćSzeregu");
            Suma = ObliczWartośćSzeregu(X, Eps, out LicznikWyrazów);
            //MessageBox.Show("Jestem po wywołaniem metody ObliczWartośćSzeregu");
            txtSuma.Text = Suma.ToString();
            txtLicznikWyrazuSzeregu.Text = LicznikWyrazów.ToString();
            txtX.Enabled = false;
        }

        bool PobranieDanychWejściowych_X_Eps(out float X, out float Eps)
        {
            X = Eps = 0.0F;
            if (!float.TryParse(txtX.Text, out X))
            {
                errorProvider1.SetError(txtX, "ERROR: w zapisie wartości zmiennej X wystąpil niedozwolony znak");
                return false;
            }

            if (!float.TryParse(txtEps.Text, out Eps))
            {
                errorProvider1.SetError(txtEps, "ERROR: w zapisie dokłsdności zmiennej Eps wystąpil niedozwolony znak");
                return false;
            }

            if ((Eps <= 0.0F) || (Eps >= 1.0F))
            {
                errorProvider1.SetError(txtEps, "ERROR: podana dokłsdności zmiennej Eps spełnia warunku wejściowego: 0.0 < Eps < 1.0");
                return false;
            }

            return true;
        }

        float ObliczWartośćSzeregu(float X, float Eps, out ushort k)
        { // ustalenie warunków brzegowych (początkowewgo stanu obliczeń)
            k = 0; // licznik wyrazów szeregu
            float S = 0.0F; // "zerowa" suma szeregu
            float w = 1.0F; // "zerowy" (dla k = 0) wyraz szeregu 
            // powtarzanie onliczeń częściowych sum szeregu
            do
            {
                S = S + w; // obliczenie sumy k wyrazów szeregu 
                k++; // zwiększenie nmeru wyrazu szeregu
                w = w * (-1) * X / k; /* obliczenie wartości k-tego wyrazu szeregu */
            }

            while (Math.Abs(w) > Eps);
            // zwrot wyniku 
            return S;
        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            this.Hide();
            SzeregLaboratoryjny form2 = new SzeregLaboratoryjny();
            form2.Show();
        }
        private void TablicowanieWartościSzeregu1(float Xd, float Xg, float h, float Eps, out float[,] TWS)
        { // wyznaczenie liczby wierszy egzemplarza tablicy TWS
            int n = (int)((Xg - Xd) / h + 1);
            // utworzenie egzemplarza tablicy TWS
            TWS = new float[n, 3];
            // tablicowanie wartości szeregu w przedziale [Xd,Xg]
            // deklaracje pomocnicze
            float X;
            int i; // numer podprzedziału przedziału [Xd,Xg]
            ushort LicznikZsumowanychWyrazów;

            for (X = Xd, i = 0; i < TWS.GetLength(0); i++, X = Xd + i * h)
            /* nie piszemy tak: X = X + h, gdyż nastąpi kumulowanie błędów operacji
             '+' na wartościach typu float, które sa reprezentowane w komputerze z 
            pewnym przybliżeniem 'epsilon' */
            {
                TWS[i, 0] = X;
                TWS[i, 1] = ObliczWartośćSzeregu(X, Eps, out LicznikZsumowanychWyrazów);
                TWS[i, 2] = LicznikZsumowanychWyrazów;
            }
        }
        private void btnWizualizacjaTabelaryczna_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            float Eps, Xd, Xg, h;
            if (!PobranieDanychWejściowych_Eps_Xd_Xg_h(out Xd, out Xg, out h, out Eps))
            {
                return;
            }

            //float[,] TWS;

            if (TWS is null)
            {
                TablicowanieWartościSzeregu(Xd, Xg, h, Eps, out TWS);
            }

            WpisanieDoKontrolkiDataGridViewTablicy(TWS, dgvTWS);

            dgvTWS.Visible = true;
            chtWykresSzeregu.Visible = false;
        }

        #region Deklaracje metod pomocniczch

        bool PobranieDanychWejściowych_Eps_Xd_Xg_h(out float Xd, out float Xg, out float h, out float Eps)
        {
            Xd = Xg = h = Eps = 0.0F;
            if (!float.TryParse(txtXd.Text, out Xd))
            {
                errorProvider1.SetError(txtXd, "ERROR: wystąpił niedozwolony znak w zapisie danej Xd");
                return false;
            }

            if ((Xd < DgXd) || (Xd > GgXg))
            {
                errorProvider1.SetError(txtXd, "ERROR: podana wartość Xd nie należy do przedziału zbiezności szeregu");
                return false;
            }

            if (!float.TryParse(txtXg.Text, out Xg))
            {
                errorProvider1.SetError(txtXg, "ERROR: wystąpił niedozwolony znak w zapisie danej Xg");
                return false;
            }

            if ((Xg < DgXd) || (Xg > GgXg))
            {
                errorProvider1.SetError(txtXg, "ERROR: podana wartość Xg nie należy do przedziału zbiezności szeregu");
                return false;
            }

            if (Xg < Xd)
            {
                errorProvider1.SetError(txtXg, "ERROR: podana wartość Xg nie może być mniejsza od podaniej wartoszći Xd");
                return false;
            }

            txtXg.Enabled = false;
            txtXd.Enabled = false;

            if (!float.TryParse(txtH.Text, out h))
            {
                errorProvider1.SetError(txtH, "ERROR: w zapisie przyrostu 'h' wystąpił niedozwolony znak");
                return false;
            }

            if (h >= (Xg - Xd))
            {
                errorProvider1.SetError(txtH, "ERROR: wartość przyrostu 'h' nie może być większa od szerekości przedziału: (Xg - Xd)");
                return false;
            }

            txtH.Enabled = false;

            if (!float.TryParse(txtEps.Text, out Eps))
            {
                errorProvider1.SetError(txtEps, "ERROR: w zapisie dokładności obliczeń Eps wystąpił niedozwolony znak");
                return false;
            }

            if ((Eps <= 0.0F) || (Eps >= 1.0F))
            {
                errorProvider1.SetError(txtEps, "ERROR: podana wartość dokładbości obliczeń Eps nie spiłnia warunku wejściowego: 0.0 < Eps < 1.0");
                return false;
            }

            txtEps.Enabled = false;

            return true;
        }

        void TablicowanieWartościSzeregu(float Xd, float Xg, float h, float Eps, out float[,] TWS)
        {
            int n = (int)((Xg - Xd) / h + 1);
            TWS = new float[n + 1, 3];
            float X;
            int i;
            ushort LicznikZsumowanychWyrazów;

            for (X = Xd, i = 0; i < TWS.GetLength(0); i++, X = Xd + i * h)
            {
                TWS[i, 0] = X;
                TWS[i, 1] = ObliczWartośćSzeregu(X, Eps, out LicznikZsumowanychWyrazów);
                TWS[i, 2] = LicznikZsumowanychWyrazów;
            }
        }

        void WpisanieDoKontrolkiDataGridViewTablicy(float[,] TWS, DataGridView dgvTWS)
        {
            dgvTWS.Rows.Clear();

            for (int i = 0; i < TWS.GetLength(0); i++)
            {
                dgvTWS.Rows.Add();
                dgvTWS.Rows[i].Cells[0].Value = string.Format("{0:0.00}", TWS[i, 0]);
                dgvTWS.Rows[i].Cells[1].Value = string.Format("{0:0.000}", TWS[i, 1]);
                dgvTWS.Rows[i].Cells[2].Value = string.Format("{0}", (int)TWS[i, 2]);
            }
        }

        #endregion

        private void restartProgramyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void kolorTłaWykresuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog PaletaKolorów = new ColorDialog();
            PaletaKolorów.Color = this.BackColor;
            if (PaletaKolorów.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = PaletaKolorów.Color;
            }

            PaletaKolorów.Dispose();
        }

        private void kolorLiniiWykresuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog PaletaKolorów = new ColorDialog();
            PaletaKolorów.Color = this.ForeColor;
            if (PaletaKolorów.ShowDialog() == DialogResult.OK)
            {
                this.ForeColor = PaletaKolorów.Color;
            }

            PaletaKolorów.Dispose();
        }

        private void czcionkaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog OknoCzcionki = new FontDialog();
            OknoCzcionki.Font = this.Font;
            if (OknoCzcionki.ShowDialog() == DialogResult.OK)
            {
                this.Font = OknoCzcionki.Font;
            }

            OknoCzcionki.Dispose();
        }

        private void zapisanieTablicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TWS is null)
            {
                float Xd, Xg, h, Eps;

                if (!PobranieDanychWejściowych_Eps_Xd_Xg_h(out Xd, out Xg, out h, out Eps))
                {
                    MessageBox.Show("UWAGA: wystąpil bład w zapisie danych wejściowych i dane polecenie z menu 'Plik' nie może być obslużone");
                    return;
                }

                TablicowanieWartościSzeregu(Xd, Xg, h, Eps, out TWS);
            }

            SaveFileDialog OknoWyboruPlikuDoZapisu = new SaveFileDialog();
            OknoWyboruPlikuDoZapisu.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            OknoWyboruPlikuDoZapisu.FilterIndex = 1;
            OknoWyboruPlikuDoZapisu.RestoreDirectory = true;
            OknoWyboruPlikuDoZapisu.InitialDirectory = "C:\\";
            OknoWyboruPlikuDoZapisu.Title = "Wybór pliku do zapisu TWS (Tabloca Watrości Seregu)";

            if (OknoWyboruPlikuDoZapisu.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter PlikZnakowy = new System.IO.StreamWriter(OknoWyboruPlikuDoZapisu.FileName);
                try
                {
                    int i;
                    for (i = 0; i < TWS.GetLength(0); i++)
                    {
                        PlikZnakowy.Write(TWS[i, 0].ToString());
                        PlikZnakowy.Write("; \t");
                        PlikZnakowy.Write(TWS[i, 1].ToString());
                        PlikZnakowy.Write("; \t");
                        PlikZnakowy.WriteLine(TWS[i, 2].ToString());
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("ERROR: wystąpil błąd podczas zapisu danuch z TWS do pliku");
                }

                finally
                {
                    PlikZnakowy.Close();
                }
            }

            else
            {
                MessageBox.Show("UWAGA: nie został wybrany pliku do wpisania danych z tablicy TWS, to dane polecenie z menu 'Plik' nie może być wykonane");
            }
        }
        private void odczytanieTablicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OknoWyboryPlikuDoOdczytu = new OpenFileDialog();
            OknoWyboryPlikuDoOdczytu.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            OknoWyboryPlikuDoOdczytu.FilterIndex = 1;
            OknoWyboryPlikuDoOdczytu.RestoreDirectory = true;
            OknoWyboryPlikuDoOdczytu.InitialDirectory = "C:\\";
            OknoWyboryPlikuDoOdczytu.Title = "Wybór pliku do odcztu i zapisu TWS (Tabloca Watrości Seregu)";

            if (OknoWyboryPlikuDoOdczytu.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader PlikZnakowy = new System.IO.StreamReader(OknoWyboryPlikuDoOdczytu.FileName);
                string WierszDanych;
                ushort LicznikWierszy = 0;
                while ((WierszDanych = PlikZnakowy.ReadLine()) != null)
                {
                    LicznikWierszy++;
                }

                PlikZnakowy.Close();
                TWS = new float[LicznikWierszy, 3];
                PlikZnakowy = new System.IO.StreamReader(OknoWyboryPlikuDoOdczytu.FileName);
            }

            else
            {
                MessageBox.Show("UWAGA: nie został wybrany żaden plik do odczytu i wybrane polecenie z menu 'Plik' nie będzie wykonany");
            }
        }

        private void btnWizualizacjaGraficzna_Click(object sender, EventArgs e)
        {
            /* "zgaszenie" kontrolki errorProvider, któw mogła zostać zapalona podczas pobierania danych */
            errorProvider1.Dispose();
            // 1) Pobranie danych wejściowych z formularza
            // deklaracje zmiennych dla przechowania pobranych danych wejściowych
            float Xd, Xg, h, Eps;
            if (!PobranieDanychWejściowych_Eps_Xd_Xg_h(out Xd, out Xg, out h, out Eps))

                return;
            // 2) tablicowanie wartości szeregu
            // sprawdzenie czy tablica TWS była już utworzona 

            if (TWS is null) /* operator 'is' umożliwia sprawdzenie, czy w czasie wukonywania programu
                              wartość zmiennej TWS jest zgodna z wartością 'null' (pusty wskażnik) */
                /* egzemplarz tablicy TWS nie został jeszcze utworzony i 
                 szereg nie został stablicowany, to musimy go teraz
                utworzyć i stablicowanie wartości szeregu */

                TablicowanieWartościSzeregu(Xd, Xg, h, Eps, out TWS);
            /* 3) przepisanie danych z tablicy TWS do kontrolki Chart 
             umieszczonej na formularzu */

            WpisanieWynikówDoKontrolkiChart(TWS, chtWykresSzeregu);
            // 4) odsłonięcie i ukrycie kontrolek oraz ustawienie stany braku akrywności kontrolek 
            // ukrycie kontrolki DataGridView
            dgvTWS.Visible = false;
            // odsłonięcie kontrolki Chart
            chtWykresSzeregu.Visible = true;
            /* ustawienie stany braku aktywności przycisku poleceń: 
             Wizualizacja graficzna zmian wartości szeregu */
            btnWizualizacjaGraficzna.Enabled = false;
        }

        void WpisanieWynikówDoKontrolkiChart(float[,] TWS, Chart chtWykresSzeregu)
        {
            // 1. formatowanie (ustawienie atrybutów) kontrolki Chart,
            // obramowanie kontrolki Chart
            chtWykresSzeregu.BorderlineWidth = 2;
            chtWykresSzeregu.BorderlineColor = Color.Red;
            chtWykresSzeregu.BorderlineDashStyle = ChartDashStyle.DashDotDot;
            // skonfigurowanie kontrolki Chart
            // ustalenie tytułu wykresu
            chtWykresSzeregu.Titles.Add("Wykres zmian wartości szeregu S(X)");
            // umieszczenie legendy pod wykresem
            chtWykresSzeregu.Legends.FindByName("Legend1").Docking = Docking.Bottom;
            // ustawienie koloru tła
            chtWykresSzeregu.BackColor = Color.LightSkyBlue;
            chtWykresSzeregu.ChartAreas[0].AxisX.Title = "Wartości X";
            chtWykresSzeregu.ChartAreas[0].AxisY.Title = "Wartości S(X)";
            // sformatowanie opisu osi X (kontrolki Chart)
            chtWykresSzeregu.ChartAreas[0].AxisX.LabelStyle.Format = "{0:f2}";
            // sformatowanie opisu osi Y (kontrolki Chart)
            chtWykresSzeregu.ChartAreas[0].AxisY.LabelStyle.Format = "{0:f2}";
            // 2.formatowanie serii danych dodanej do kontrolki Chart,
            // "wyzerowanie" serii danych kontrolki Chart
            chtWykresSzeregu.Series.Clear();
            // dodanie nowej serii danych
            chtWykresSzeregu.Series.Add("Seria 0");
            // ustalenie nazw osi układu współrzędnych
            chtWykresSzeregu.Series[0].XValueMember = "X";
            chtWykresSzeregu.Series[0].YValueMembers = "Y";
            // ustalenie widoczności legendy
            chtWykresSzeregu.Series[0].IsVisibleInLegend = true;
            // ustalenie nazwy legendy (opisu linii wykresu)
            chtWykresSzeregu.Series[0].Name = "Wartość szeregu potęgowego S(X)"; // legenda
            // ustalenie typu wykresu
            chtWykresSzeregu.Series[0].ChartType = SeriesChartType.Line; // liniowy
            // ustawienie koloru linii
            chtWykresSzeregu.Series[0].Color = Color.Black;
            // ustalenie stylu linii
            chtWykresSzeregu.Series[0].BorderDashStyle = ChartDashStyle.Solid;
            // ustalenie grubości linii
            chtWykresSzeregu.Series[0].BorderWidth = 1;

            /*3.wpisania współrzędnych (X oraz Y) linii wykresu szeregu (na podstawie danych zapisanych w tablicy TWS) */
            /* dodanie do serii danych (kontrolki Chart) współrzędnych punktów wykresu (wartości X oraz Wartości Y, czyli wartości szeregu: S (X) */

            for (int i = 0; i < TWS.GetLength(0); i++)
            {
                chtWykresSzeregu.Series[0].Points.AddXY(TWS[i, 0], TWS[i, 1]);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { /* wyświetlenie okna dialogowego z pytaniem: " Czy rzeczywiście..."
           z ikoną pytajnika i trzema przyciskami: Yes, No i Cancel */
            DialogResult PytanieDoUżytkownika = MessageBox.Show("Czy na pewno chcesz zamknąć formularz (co może skutkować" +
                "utratą danych zapisanych na formularzu) i wyjść do formularża glównego?",
                this.Text, MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            /* rozpoznanie odpowiedzi użytkownika aplikacji i wykonanie stosowego działania;
             formularz może być zamknięty gdy użytkownik wybrał (kliknął) przycisk poleceń Tak */
            if (PytanieDoUżytkownika == DialogResult.Yes)
            { // potwiedzenia zamknięcia bieżącego formularza
                // czyli nie kasujemy zdarzenia zamknięcia formularza
                // odszukanie egzemplarza formularza głównego w kolekcji OpenForms
                foreach (Form Formularz in Application.OpenForms)
                    //sprawdzamy, czy został znaleziony formularz główny
                    if (Formularz.Name == "KokpitProjektuNr2")
                    { // ukrycie bieżącego formularza
                        this.Hide();
                        // odsłonięcie znalezionego głównego formularza
                        Formularz.Show();
                        // wyjście z metody obsługizdarzenia FormClosing
                        return;
                    }
                // utworzenie nowego egzemplarza formularza głównego
                KokpitProjektuNr2_Stepushenkov FormularzKokpitProjektuNr2 =
                    new KokpitProjektuNr2_Stepushenkov();
                // odsłonięcie nowego formularza głównego
                FormularzKokpitProjektuNr2.Show();
                // ukrycie bieżącego formularza
                this.Hide();
            }
           
              
                

        }
    }
}