namespace ProjektNr2_Stepushenkov63334
{
    partial class SzeregLaboratoryjny
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnObliczSumeSzeregu = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtLicznikWyrazuSzeregu = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtEps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtXd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtXg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.btnWizualizacjaTabelaryczna = new System.Windows.Forms.Button();
            this.btnWizualizacjaGraficzna = new System.Windows.Forms.Button();
            this.btnResetuj = new System.Windows.Forms.Button();
            this.dgvTWS = new System.Windows.Forms.DataGridView();
            this.WartośćX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WartośćSzeregu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicznikWyrazów = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapisanieTablicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odczytanieTablicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartProgramyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykresLinowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykresPunktowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykresKolumnowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykresŚlubkowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koloryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorTłaWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorLiniiWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stylLiniiWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniaKreskowaDashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniaKreskowoKropkowaDashDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniaKropkowaDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ćągłaSolidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gróbośćLiniiWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaOpisuKontrolkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaOpisuFormularzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chtWykresSzeregu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTWS)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtWykresSzeregu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObliczSumeSzeregu
            // 
            this.btnObliczSumeSzeregu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObliczSumeSzeregu.Location = new System.Drawing.Point(830, 244);
            this.btnObliczSumeSzeregu.Name = "btnObliczSumeSzeregu";
            this.btnObliczSumeSzeregu.Size = new System.Drawing.Size(236, 34);
            this.btnObliczSumeSzeregu.TabIndex = 2;
            this.btnObliczSumeSzeregu.Text = "Oblicz sumę szeregu";
            this.btnObliczSumeSzeregu.UseVisualStyleBackColor = true;
            this.btnObliczSumeSzeregu.Click += new System.EventHandler(this.btnObliczSumeSzeregu_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtSuma
            // 
            this.txtSuma.Enabled = false;
            this.txtSuma.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSuma.Location = new System.Drawing.Point(830, 112);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.ReadOnly = true;
            this.txtSuma.Size = new System.Drawing.Size(236, 34);
            this.txtSuma.TabIndex = 3;
            // 
            // txtLicznikWyrazuSzeregu
            // 
            this.txtLicznikWyrazuSzeregu.Enabled = false;
            this.txtLicznikWyrazuSzeregu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLicznikWyrazuSzeregu.Location = new System.Drawing.Point(830, 204);
            this.txtLicznikWyrazuSzeregu.Name = "txtLicznikWyrazuSzeregu";
            this.txtLicznikWyrazuSzeregu.ReadOnly = true;
            this.txtLicznikWyrazuSzeregu.Size = new System.Drawing.Size(236, 34);
            this.txtLicznikWyrazuSzeregu.TabIndex = 4;
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtX.Location = new System.Drawing.Point(17, 109);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(236, 34);
            this.txtX.TabIndex = 5;
            // 
            // txtEps
            // 
            this.txtEps.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEps.Location = new System.Drawing.Point(17, 201);
            this.txtEps.Name = "txtEps";
            this.txtEps.Size = new System.Drawing.Size(236, 34);
            this.txtEps.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(304, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Analizator laboratoryjnego szeregu potęgowego";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 52);
            this.label2.TabIndex = 8;
            this.label2.Text = "Wartość zmiennej\r\nniezalieżnej X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 52);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dokładność oblicznia\r\nsumy szeregu Eps";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(826, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 52);
            this.label4.TabIndex = 10;
            this.label4.Text = "Obliczona suma\r\nszeregu potęgowego";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(826, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 52);
            this.label5.TabIndex = 11;
            this.label5.Text = "Liczba zsumowanych\r\nwyrazów szeregu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 52);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dolna granica przedziału\r\nXd (zmian wartości X)";
            // 
            // txtXd
            // 
            this.txtXd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtXd.Location = new System.Drawing.Point(17, 293);
            this.txtXd.Name = "txtXd";
            this.txtXd.Size = new System.Drawing.Size(236, 34);
            this.txtXd.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 52);
            this.label7.TabIndex = 14;
            this.label7.Text = "Górna granica przedziału\r\nXg (zmian wartości X)";
            // 
            // txtXg
            // 
            this.txtXg.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtXg.Location = new System.Drawing.Point(17, 385);
            this.txtXg.Name = "txtXg";
            this.txtXg.Size = new System.Drawing.Size(236, 34);
            this.txtXg.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(12, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 52);
            this.label8.TabIndex = 16;
            this.label8.Text = "Przyrost h (zmian\r\nwartości zmiennej X)";
            // 
            // txtH
            // 
            this.txtH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtH.Location = new System.Drawing.Point(17, 477);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(236, 34);
            this.txtH.TabIndex = 17;
            // 
            // btnWizualizacjaTabelaryczna
            // 
            this.btnWizualizacjaTabelaryczna.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWizualizacjaTabelaryczna.Location = new System.Drawing.Point(830, 284);
            this.btnWizualizacjaTabelaryczna.Name = "btnWizualizacjaTabelaryczna";
            this.btnWizualizacjaTabelaryczna.Size = new System.Drawing.Size(236, 91);
            this.btnWizualizacjaTabelaryczna.TabIndex = 18;
            this.btnWizualizacjaTabelaryczna.Text = "Tabelaryczna wizualizacja zmian wartości szeregu potęgowego";
            this.btnWizualizacjaTabelaryczna.UseVisualStyleBackColor = true;
            this.btnWizualizacjaTabelaryczna.Click += new System.EventHandler(this.btnWizualizacjaTabelaryczna_Click);
            // 
            // btnWizualizacjaGraficzna
            // 
            this.btnWizualizacjaGraficzna.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWizualizacjaGraficzna.Location = new System.Drawing.Point(830, 381);
            this.btnWizualizacjaGraficzna.Name = "btnWizualizacjaGraficzna";
            this.btnWizualizacjaGraficzna.Size = new System.Drawing.Size(236, 91);
            this.btnWizualizacjaGraficzna.TabIndex = 19;
            this.btnWizualizacjaGraficzna.Text = "Graficzna wizualizacja zmian wartości szeregu potęgowego";
            this.btnWizualizacjaGraficzna.UseVisualStyleBackColor = true;
            this.btnWizualizacjaGraficzna.Click += new System.EventHandler(this.btnWizualizacjaGraficzna_Click);
            // 
            // btnResetuj
            // 
            this.btnResetuj.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResetuj.Location = new System.Drawing.Point(830, 478);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(236, 64);
            this.btnResetuj.TabIndex = 20;
            this.btnResetuj.Text = "RESETUJ (ustal\r\nstan początkowy)";
            this.btnResetuj.UseVisualStyleBackColor = true;
            this.btnResetuj.Click += new System.EventHandler(this.btnResetuj_Click);
            // 
            // dgvTWS
            // 
            this.dgvTWS.BackgroundColor = System.Drawing.Color.White;
            this.dgvTWS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTWS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WartośćX,
            this.WartośćSzeregu,
            this.LicznikWyrazów});
            this.dgvTWS.Location = new System.Drawing.Point(261, 51);
            this.dgvTWS.Name = "dgvTWS";
            this.dgvTWS.RowHeadersWidth = 51;
            this.dgvTWS.RowTemplate.Height = 24;
            this.dgvTWS.Size = new System.Drawing.Size(553, 525);
            this.dgvTWS.TabIndex = 21;
            // 
            // WartośćX
            // 
            this.WartośćX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WartośćX.DefaultCellStyle = dataGridViewCellStyle1;
            this.WartośćX.HeaderText = "Wartość zmiennej niezależnej X";
            this.WartośćX.MinimumWidth = 6;
            this.WartośćX.Name = "WartośćX";
            // 
            // WartośćSzeregu
            // 
            this.WartośćSzeregu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WartośćSzeregu.DefaultCellStyle = dataGridViewCellStyle2;
            this.WartośćSzeregu.HeaderText = "Wartość szeregu dla X";
            this.WartośćSzeregu.MinimumWidth = 6;
            this.WartośćSzeregu.Name = "WartośćSzeregu";
            // 
            // LicznikWyrazów
            // 
            this.LicznikWyrazów.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LicznikWyrazów.DefaultCellStyle = dataGridViewCellStyle3;
            this.LicznikWyrazów.HeaderText = "Licznik zsumowanych wyrazów";
            this.LicznikWyrazów.MinimumWidth = 6;
            this.LicznikWyrazów.Name = "LicznikWyrazów";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.typWykresuToolStripMenuItem,
            this.koloryToolStripMenuItem,
            this.stylLiniiWykresuToolStripMenuItem,
            this.gróbośćLiniiWykresuToolStripMenuItem,
            this.czcionkaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1202, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapisanieTablicyToolStripMenuItem,
            this.odczytanieTablicyToolStripMenuItem,
            this.restartProgramyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zapisanieTablicyToolStripMenuItem
            // 
            this.zapisanieTablicyToolStripMenuItem.Name = "zapisanieTablicyToolStripMenuItem";
            this.zapisanieTablicyToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.zapisanieTablicyToolStripMenuItem.Text = "Zapisanie tablicy ";
            this.zapisanieTablicyToolStripMenuItem.Click += new System.EventHandler(this.zapisanieTablicyToolStripMenuItem_Click);
            // 
            // odczytanieTablicyToolStripMenuItem
            // 
            this.odczytanieTablicyToolStripMenuItem.Name = "odczytanieTablicyToolStripMenuItem";
            this.odczytanieTablicyToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.odczytanieTablicyToolStripMenuItem.Text = "Odczytanie tablicy";
            this.odczytanieTablicyToolStripMenuItem.Click += new System.EventHandler(this.odczytanieTablicyToolStripMenuItem_Click);
            // 
            // restartProgramyToolStripMenuItem
            // 
            this.restartProgramyToolStripMenuItem.Name = "restartProgramyToolStripMenuItem";
            this.restartProgramyToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.restartProgramyToolStripMenuItem.Text = "Restart programy";
            this.restartProgramyToolStripMenuItem.Click += new System.EventHandler(this.restartProgramyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.exitToolStripMenuItem.Text = "Wyjście";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // typWykresuToolStripMenuItem
            // 
            this.typWykresuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wykresLinowyToolStripMenuItem,
            this.wykresPunktowyToolStripMenuItem,
            this.wykresKolumnowyToolStripMenuItem,
            this.wykresŚlubkowyToolStripMenuItem});
            this.typWykresuToolStripMenuItem.Name = "typWykresuToolStripMenuItem";
            this.typWykresuToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.typWykresuToolStripMenuItem.Text = "Typ wykresu";
            // 
            // wykresLinowyToolStripMenuItem
            // 
            this.wykresLinowyToolStripMenuItem.Name = "wykresLinowyToolStripMenuItem";
            this.wykresLinowyToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.wykresLinowyToolStripMenuItem.Text = "Wykres linowy";
            // 
            // wykresPunktowyToolStripMenuItem
            // 
            this.wykresPunktowyToolStripMenuItem.Name = "wykresPunktowyToolStripMenuItem";
            this.wykresPunktowyToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.wykresPunktowyToolStripMenuItem.Text = "Wykres punktowy";
            // 
            // wykresKolumnowyToolStripMenuItem
            // 
            this.wykresKolumnowyToolStripMenuItem.Name = "wykresKolumnowyToolStripMenuItem";
            this.wykresKolumnowyToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.wykresKolumnowyToolStripMenuItem.Text = "Wykres kolumnowy";
            // 
            // wykresŚlubkowyToolStripMenuItem
            // 
            this.wykresŚlubkowyToolStripMenuItem.Name = "wykresŚlubkowyToolStripMenuItem";
            this.wykresŚlubkowyToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.wykresŚlubkowyToolStripMenuItem.Text = "Wykres ślubkowy";
            // 
            // koloryToolStripMenuItem
            // 
            this.koloryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolorTłaWykresuToolStripMenuItem,
            this.kolorLiniiWykresuToolStripMenuItem});
            this.koloryToolStripMenuItem.Name = "koloryToolStripMenuItem";
            this.koloryToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.koloryToolStripMenuItem.Text = "Kolory";
            // 
            // kolorTłaWykresuToolStripMenuItem
            // 
            this.kolorTłaWykresuToolStripMenuItem.Name = "kolorTłaWykresuToolStripMenuItem";
            this.kolorTłaWykresuToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.kolorTłaWykresuToolStripMenuItem.Text = "Kolor tła wykresu";
            this.kolorTłaWykresuToolStripMenuItem.Click += new System.EventHandler(this.kolorTłaWykresuToolStripMenuItem_Click);
            // 
            // kolorLiniiWykresuToolStripMenuItem
            // 
            this.kolorLiniiWykresuToolStripMenuItem.Name = "kolorLiniiWykresuToolStripMenuItem";
            this.kolorLiniiWykresuToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.kolorLiniiWykresuToolStripMenuItem.Text = "Kolor linii wykresu";
            this.kolorLiniiWykresuToolStripMenuItem.Click += new System.EventHandler(this.kolorLiniiWykresuToolStripMenuItem_Click);
            // 
            // stylLiniiWykresuToolStripMenuItem
            // 
            this.stylLiniiWykresuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liniaKreskowaDashToolStripMenuItem,
            this.liniaKreskowoKropkowaDashDotToolStripMenuItem,
            this.liniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem,
            this.liniaKropkowaDotToolStripMenuItem,
            this.ćągłaSolidToolStripMenuItem});
            this.stylLiniiWykresuToolStripMenuItem.Name = "stylLiniiWykresuToolStripMenuItem";
            this.stylLiniiWykresuToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.stylLiniiWykresuToolStripMenuItem.Text = "Styl linii wykresu";
            // 
            // liniaKreskowaDashToolStripMenuItem
            // 
            this.liniaKreskowaDashToolStripMenuItem.Name = "liniaKreskowaDashToolStripMenuItem";
            this.liniaKreskowaDashToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.liniaKreskowaDashToolStripMenuItem.Text = "Linia Kreskowa (Dash)";
            // 
            // liniaKreskowoKropkowaDashDotToolStripMenuItem
            // 
            this.liniaKreskowoKropkowaDashDotToolStripMenuItem.Name = "liniaKreskowoKropkowaDashDotToolStripMenuItem";
            this.liniaKreskowoKropkowaDashDotToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.liniaKreskowoKropkowaDashDotToolStripMenuItem.Text = "Linia KreskowoKropkowa (DashDot)";
            // 
            // liniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem
            // 
            this.liniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem.Name = "liniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem";
            this.liniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.liniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem.Text = "Linia KreskowoKropkowaKropkowa (DashDotDot)";
            // 
            // liniaKropkowaDotToolStripMenuItem
            // 
            this.liniaKropkowaDotToolStripMenuItem.Name = "liniaKropkowaDotToolStripMenuItem";
            this.liniaKropkowaDotToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.liniaKropkowaDotToolStripMenuItem.Text = "Linia Kropkowa (Dot)";
            // 
            // ćągłaSolidToolStripMenuItem
            // 
            this.ćągłaSolidToolStripMenuItem.Name = "ćągłaSolidToolStripMenuItem";
            this.ćągłaSolidToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.ćągłaSolidToolStripMenuItem.Text = "Ćągła (Solid)";
            // 
            // gróbośćLiniiWykresuToolStripMenuItem
            // 
            this.gróbośćLiniiWykresuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.gróbośćLiniiWykresuToolStripMenuItem.Name = "gróbośćLiniiWykresuToolStripMenuItem";
            this.gróbośćLiniiWykresuToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.gróbośćLiniiWykresuToolStripMenuItem.Text = "Gróbość linii wykresu";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem2.Text = "1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem3.Text = "2";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem4.Text = "3";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem5.Text = "4";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem6.Text = "5";
            // 
            // czcionkaToolStripMenuItem
            // 
            this.czcionkaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.czcionkaToolStripMenuItem1,
            this.czcionkaOpisuKontrolkiToolStripMenuItem,
            this.czcionkaOpisuFormularzaToolStripMenuItem});
            this.czcionkaToolStripMenuItem.Name = "czcionkaToolStripMenuItem";
            this.czcionkaToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.czcionkaToolStripMenuItem.Text = "Czcionka";
            // 
            // czcionkaToolStripMenuItem1
            // 
            this.czcionkaToolStripMenuItem1.Name = "czcionkaToolStripMenuItem1";
            this.czcionkaToolStripMenuItem1.Size = new System.Drawing.Size(267, 26);
            this.czcionkaToolStripMenuItem1.Text = "Czcionka opisu wykresu";
            this.czcionkaToolStripMenuItem1.Click += new System.EventHandler(this.czcionkaToolStripMenuItem1_Click);
            // 
            // czcionkaOpisuKontrolkiToolStripMenuItem
            // 
            this.czcionkaOpisuKontrolkiToolStripMenuItem.Name = "czcionkaOpisuKontrolkiToolStripMenuItem";
            this.czcionkaOpisuKontrolkiToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.czcionkaOpisuKontrolkiToolStripMenuItem.Text = "Czcionka opisu kontrolki";
            // 
            // czcionkaOpisuFormularzaToolStripMenuItem
            // 
            this.czcionkaOpisuFormularzaToolStripMenuItem.Name = "czcionkaOpisuFormularzaToolStripMenuItem";
            this.czcionkaOpisuFormularzaToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.czcionkaOpisuFormularzaToolStripMenuItem.Text = "Czcionka opisu formularza";
            // 
            // chtWykresSzeregu
            // 
            chartArea1.Name = "ChartArea1";
            this.chtWykresSzeregu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtWykresSzeregu.Legends.Add(legend1);
            this.chtWykresSzeregu.Location = new System.Drawing.Point(261, 51);
            this.chtWykresSzeregu.Name = "chtWykresSzeregu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtWykresSzeregu.Series.Add(series1);
            this.chtWykresSzeregu.Size = new System.Drawing.Size(553, 525);
            this.chtWykresSzeregu.TabIndex = 23;
            // 
            // SzeregLaboratoryjny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 588);
            this.Controls.Add(this.chtWykresSzeregu);
            this.Controls.Add(this.dgvTWS);
            this.Controls.Add(this.btnResetuj);
            this.Controls.Add(this.btnWizualizacjaGraficzna);
            this.Controls.Add(this.btnWizualizacjaTabelaryczna);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtXg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtXd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEps);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtLicznikWyrazuSzeregu);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.btnObliczSumeSzeregu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SzeregLaboratoryjny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szereg LaboratoryjnyNr2_Stepushenkov63334";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTWS)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtWykresSzeregu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnObliczSumeSzeregu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtEps;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtLicznikWyrazuSzeregu;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResetuj;
        private System.Windows.Forms.Button btnWizualizacjaGraficzna;
        private System.Windows.Forms.Button btnWizualizacjaTabelaryczna;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtXg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtXd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvTWS;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapisanieTablicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odczytanieTablicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartProgramyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wykresLinowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wykresPunktowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wykresKolumnowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wykresŚlubkowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koloryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorTłaWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorLiniiWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stylLiniiWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gróbośćLiniiWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem czcionkaOpisuKontrolkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaOpisuFormularzaToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtWykresSzeregu;
        private System.Windows.Forms.DataGridViewTextBoxColumn WartośćX;
        private System.Windows.Forms.DataGridViewTextBoxColumn WartośćSzeregu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicznikWyrazów;
        private System.Windows.Forms.ToolStripMenuItem liniaKreskowaDashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liniaKreskowoKropkowaDashDotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liniaKropkowaDotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ćągłaSolidToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}