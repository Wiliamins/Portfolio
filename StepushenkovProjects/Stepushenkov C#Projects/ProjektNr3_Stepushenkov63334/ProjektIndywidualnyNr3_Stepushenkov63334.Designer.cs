namespace ProjektNr3_Stepushenkov63334
{
    partial class KokpitProjekt
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
            this.vvpbRysownica = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vvlblX = new System.Windows.Forms.Label();
            this.vvlblY = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vvZapisPliku = new System.Windows.Forms.ToolStripMenuItem();
            this.odczytanieTablicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vvExitZFormularza = new System.Windows.Forms.ToolStripMenuItem();
            this.vvRestartProgramu = new System.Windows.Forms.ToolStripMenuItem();
            this.koloryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vvkolorLinii = new System.Windows.Forms.ToolStripMenuItem();
            this.vvKolorTlaRysownicy = new System.Windows.Forms.ToolStripMenuItem();
            this.vvKolorWypelnienia = new System.Windows.Forms.ToolStripMenuItem();
            this.atrybutyLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grubośćLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stylLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grotyRozpoczęciaLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grotyZakończeniaLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrybutyKreślonejCzcionkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krójCzcionkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozmiarCzcionkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorCzcionkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.vvgrbFigury_Linie = new System.Windows.Forms.GroupBox();
            this.vvrdbKrzywaBeziera = new System.Windows.Forms.RadioButton();
            this.vvrdbOkrągWypelniony = new System.Windows.Forms.RadioButton();
            this.vvrdbOkrąg = new System.Windows.Forms.RadioButton();
            this.vvrdbElipsaWypelniona = new System.Windows.Forms.RadioButton();
            this.vvrdbElipsa = new System.Windows.Forms.RadioButton();
            this.vvrdbProstokątWypelniony = new System.Windows.Forms.RadioButton();
            this.vvrdbKwadratWypelniony = new System.Windows.Forms.RadioButton();
            this.vvrdbKwadrat = new System.Windows.Forms.RadioButton();
            this.vvrdbProstokąt = new System.Windows.Forms.RadioButton();
            this.vvsaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.vvcolorDialog1 = new System.Windows.Forms.ColorDialog();
            this.vvcolorDialog2 = new System.Windows.Forms.ColorDialog();
            this.vvcolorDialog3 = new System.Windows.Forms.ColorDialog();
            this.vvrdbSklejanaKrzywaBeziera = new System.Windows.Forms.RadioButton();
            this.vvrdbKrzywaKardynalna = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.vvpbRysownica)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.vvgrbFigury_Linie.SuspendLayout();
            this.SuspendLayout();
            // 
            // vvpbRysownica
            // 
            this.vvpbRysownica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vvpbRysownica.Location = new System.Drawing.Point(29, 59);
            this.vvpbRysownica.Margin = new System.Windows.Forms.Padding(2);
            this.vvpbRysownica.Name = "vvpbRysownica";
            this.vvpbRysownica.Size = new System.Drawing.Size(576, 343);
            this.vvpbRysownica.TabIndex = 39;
            this.vvpbRysownica.TabStop = false;
            this.vvpbRysownica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vvpbRysownica_MouseDown);
            this.vvpbRysownica.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vvpbRysownica_MouseMove);
            this.vvpbRysownica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.vvpbRysownica_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Współrzędne (x, y) położenia myśzy:";
            // 
            // vvlblX
            // 
            this.vvlblX.AutoSize = true;
            this.vvlblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vvlblX.Location = new System.Drawing.Point(389, 39);
            this.vvlblX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vvlblX.Name = "vvlblX";
            this.vvlblX.Size = new System.Drawing.Size(52, 18);
            this.vvlblX.TabIndex = 41;
            this.vvlblX.Text = "label2";
            // 
            // vvlblY
            // 
            this.vvlblY.AutoSize = true;
            this.vvlblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vvlblY.Location = new System.Drawing.Point(445, 39);
            this.vvlblY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vvlblY.Name = "vvlblY";
            this.vvlblY.Size = new System.Drawing.Size(52, 18);
            this.vvlblY.TabIndex = 42;
            this.vvlblY.Text = "label3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.koloryToolStripMenuItem,
            this.atrybutyLiniiToolStripMenuItem,
            this.atrybutyKreślonejCzcionkiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vvZapisPliku,
            this.odczytanieTablicyToolStripMenuItem,
            this.vvExitZFormularza,
            this.vvRestartProgramu});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // vvZapisPliku
            // 
            this.vvZapisPliku.Name = "vvZapisPliku";
            this.vvZapisPliku.Size = new System.Drawing.Size(204, 22);
            this.vvZapisPliku.Text = "Zapisza BitMapę w pliku";
            this.vvZapisPliku.Click += new System.EventHandler(this.vvZapisPliku_Click);
            // 
            // odczytanieTablicyToolStripMenuItem
            // 
            this.odczytanieTablicyToolStripMenuItem.Name = "odczytanieTablicyToolStripMenuItem";
            this.odczytanieTablicyToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.odczytanieTablicyToolStripMenuItem.Text = "Odczytaj BitMapę z pliku";
            // 
            // vvExitZFormularza
            // 
            this.vvExitZFormularza.Name = "vvExitZFormularza";
            this.vvExitZFormularza.Size = new System.Drawing.Size(204, 22);
            this.vvExitZFormularza.Text = "Exit z formularza";
            this.vvExitZFormularza.Click += new System.EventHandler(this.vvExitZFormularza_Click);
            // 
            // vvRestartProgramu
            // 
            this.vvRestartProgramu.Name = "vvRestartProgramu";
            this.vvRestartProgramu.Size = new System.Drawing.Size(204, 22);
            this.vvRestartProgramu.Text = "Restart programu";
            this.vvRestartProgramu.Click += new System.EventHandler(this.vvRestartProgramu_Click);
            // 
            // koloryToolStripMenuItem
            // 
            this.koloryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vvkolorLinii,
            this.vvKolorTlaRysownicy,
            this.vvKolorWypelnienia});
            this.koloryToolStripMenuItem.Name = "koloryToolStripMenuItem";
            this.koloryToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.koloryToolStripMenuItem.Text = "Kolory";
            // 
            // vvkolorLinii
            // 
            this.vvkolorLinii.Name = "vvkolorLinii";
            this.vvkolorLinii.Size = new System.Drawing.Size(174, 22);
            this.vvkolorLinii.Text = "Kolor linii";
            this.vvkolorLinii.Click += new System.EventHandler(this.vvkolorLinii_Click);
            // 
            // vvKolorTlaRysownicy
            // 
            this.vvKolorTlaRysownicy.Name = "vvKolorTlaRysownicy";
            this.vvKolorTlaRysownicy.Size = new System.Drawing.Size(174, 22);
            this.vvKolorTlaRysownicy.Text = "Kolor tla rysownicy";
            this.vvKolorTlaRysownicy.Click += new System.EventHandler(this.vvKolorTlaRysownicy_Click);
            // 
            // vvKolorWypelnienia
            // 
            this.vvKolorWypelnienia.Name = "vvKolorWypelnienia";
            this.vvKolorWypelnienia.Size = new System.Drawing.Size(174, 22);
            this.vvKolorWypelnienia.Text = "Kolor wypełnienia";
            this.vvKolorWypelnienia.Click += new System.EventHandler(this.vvKolorWypelnienia_Click);
            // 
            // atrybutyLiniiToolStripMenuItem
            // 
            this.atrybutyLiniiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grubośćLiniiToolStripMenuItem,
            this.stylLiniiToolStripMenuItem,
            this.grotyRozpoczęciaLiniiToolStripMenuItem,
            this.grotyZakończeniaLiniiToolStripMenuItem});
            this.atrybutyLiniiToolStripMenuItem.Name = "atrybutyLiniiToolStripMenuItem";
            this.atrybutyLiniiToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.atrybutyLiniiToolStripMenuItem.Text = "Atrybuty linii";
            // 
            // grubośćLiniiToolStripMenuItem
            // 
            this.grubośćLiniiToolStripMenuItem.Name = "grubośćLiniiToolStripMenuItem";
            this.grubośćLiniiToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.grubośćLiniiToolStripMenuItem.Text = "Grubość linii";
            // 
            // stylLiniiToolStripMenuItem
            // 
            this.stylLiniiToolStripMenuItem.Name = "stylLiniiToolStripMenuItem";
            this.stylLiniiToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.stylLiniiToolStripMenuItem.Text = "Styl linii";
            // 
            // grotyRozpoczęciaLiniiToolStripMenuItem
            // 
            this.grotyRozpoczęciaLiniiToolStripMenuItem.Name = "grotyRozpoczęciaLiniiToolStripMenuItem";
            this.grotyRozpoczęciaLiniiToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.grotyRozpoczęciaLiniiToolStripMenuItem.Text = "Groty rozpoczęcia linii";
            // 
            // grotyZakończeniaLiniiToolStripMenuItem
            // 
            this.grotyZakończeniaLiniiToolStripMenuItem.Name = "grotyZakończeniaLiniiToolStripMenuItem";
            this.grotyZakończeniaLiniiToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.grotyZakończeniaLiniiToolStripMenuItem.Text = "Groty zakończenia linii";
            // 
            // atrybutyKreślonejCzcionkiToolStripMenuItem
            // 
            this.atrybutyKreślonejCzcionkiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.krójCzcionkiToolStripMenuItem,
            this.rozmiarCzcionkiToolStripMenuItem,
            this.kolorCzcionkiToolStripMenuItem});
            this.atrybutyKreślonejCzcionkiToolStripMenuItem.Name = "atrybutyKreślonejCzcionkiToolStripMenuItem";
            this.atrybutyKreślonejCzcionkiToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.atrybutyKreślonejCzcionkiToolStripMenuItem.Text = "Atrybuty kreślonej czcionki";
            // 
            // krójCzcionkiToolStripMenuItem
            // 
            this.krójCzcionkiToolStripMenuItem.Name = "krójCzcionkiToolStripMenuItem";
            this.krójCzcionkiToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.krójCzcionkiToolStripMenuItem.Text = "Krój czcionki";
            // 
            // rozmiarCzcionkiToolStripMenuItem
            // 
            this.rozmiarCzcionkiToolStripMenuItem.Name = "rozmiarCzcionkiToolStripMenuItem";
            this.rozmiarCzcionkiToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.rozmiarCzcionkiToolStripMenuItem.Text = "Rozmiar czcionki";
            // 
            // kolorCzcionkiToolStripMenuItem
            // 
            this.kolorCzcionkiToolStripMenuItem.Name = "kolorCzcionkiToolStripMenuItem";
            this.kolorCzcionkiToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.kolorCzcionkiToolStripMenuItem.Text = "Kolor czcionki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(510, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "PROJEKT Nr 3 (kreślenie figur i linij geometrycznych)\r\n";
            // 
            // vvgrbFigury_Linie
            // 
            this.vvgrbFigury_Linie.Controls.Add(this.vvrdbKrzywaKardynalna);
            this.vvgrbFigury_Linie.Controls.Add(this.vvrdbSklejanaKrzywaBeziera);
            this.vvgrbFigury_Linie.Controls.Add(this.vvrdbKrzywaBeziera);
            this.vvgrbFigury_Linie.Controls.Add(this.vvrdbOkrągWypelniony);
            this.vvgrbFigury_Linie.Controls.Add(this.vvrdbOkrąg);
            this.vvgrbFigury_Linie.Controls.Add(this.vvrdbElipsaWypelniona);
            this.vvgrbFigury_Linie.Controls.Add(this.vvrdbElipsa);
            this.vvgrbFigury_Linie.Controls.Add(this.vvrdbProstokątWypelniony);
            this.vvgrbFigury_Linie.Controls.Add(this.vvrdbKwadratWypelniony);
            this.vvgrbFigury_Linie.Controls.Add(this.vvrdbKwadrat);
            this.vvgrbFigury_Linie.Controls.Add(this.vvrdbProstokąt);
            this.vvgrbFigury_Linie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vvgrbFigury_Linie.Location = new System.Drawing.Point(619, 59);
            this.vvgrbFigury_Linie.Name = "vvgrbFigury_Linie";
            this.vvgrbFigury_Linie.Size = new System.Drawing.Size(343, 466);
            this.vvgrbFigury_Linie.TabIndex = 45;
            this.vvgrbFigury_Linie.TabStop = false;
            this.vvgrbFigury_Linie.Text = "Wybierz (zaznacz) figurę lub linię geometryczną";
            // 
            // vvrdbKrzywaBeziera
            // 
            this.vvrdbKrzywaBeziera.AutoSize = true;
            this.vvrdbKrzywaBeziera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vvrdbKrzywaBeziera.Location = new System.Drawing.Point(7, 148);
            this.vvrdbKrzywaBeziera.Name = "vvrdbKrzywaBeziera";
            this.vvrdbKrzywaBeziera.Size = new System.Drawing.Size(109, 19);
            this.vvrdbKrzywaBeziera.TabIndex = 8;
            this.vvrdbKrzywaBeziera.TabStop = true;
            this.vvrdbKrzywaBeziera.Text = "Krzywa Beziera";
            this.vvrdbKrzywaBeziera.UseVisualStyleBackColor = true;
            this.vvrdbKrzywaBeziera.CheckedChanged += new System.EventHandler(this.vvrdbKrzywaBeziera_CheckedChanged);
            // 
            // vvrdbOkrągWypelniony
            // 
            this.vvrdbOkrągWypelniony.AutoSize = true;
            this.vvrdbOkrągWypelniony.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vvrdbOkrągWypelniony.Location = new System.Drawing.Point(116, 123);
            this.vvrdbOkrągWypelniony.Name = "vvrdbOkrągWypelniony";
            this.vvrdbOkrągWypelniony.Size = new System.Drawing.Size(123, 19);
            this.vvrdbOkrągWypelniony.TabIndex = 7;
            this.vvrdbOkrągWypelniony.TabStop = true;
            this.vvrdbOkrągWypelniony.Text = "Okrąg Wypelniony";
            this.vvrdbOkrągWypelniony.UseVisualStyleBackColor = true;
            // 
            // vvrdbOkrąg
            // 
            this.vvrdbOkrąg.AutoSize = true;
            this.vvrdbOkrąg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vvrdbOkrąg.Location = new System.Drawing.Point(7, 123);
            this.vvrdbOkrąg.Name = "vvrdbOkrąg";
            this.vvrdbOkrąg.Size = new System.Drawing.Size(58, 19);
            this.vvrdbOkrąg.TabIndex = 6;
            this.vvrdbOkrąg.TabStop = true;
            this.vvrdbOkrąg.Text = "Okrąg";
            this.vvrdbOkrąg.UseVisualStyleBackColor = true;
            // 
            // vvrdbElipsaWypelniona
            // 
            this.vvrdbElipsaWypelniona.AutoSize = true;
            this.vvrdbElipsaWypelniona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vvrdbElipsaWypelniona.Location = new System.Drawing.Point(116, 98);
            this.vvrdbElipsaWypelniona.Name = "vvrdbElipsaWypelniona";
            this.vvrdbElipsaWypelniona.Size = new System.Drawing.Size(126, 19);
            this.vvrdbElipsaWypelniona.TabIndex = 5;
            this.vvrdbElipsaWypelniona.TabStop = true;
            this.vvrdbElipsaWypelniona.Text = "Elipsa Wypelniona";
            this.vvrdbElipsaWypelniona.UseVisualStyleBackColor = true;
            // 
            // vvrdbElipsa
            // 
            this.vvrdbElipsa.AutoSize = true;
            this.vvrdbElipsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vvrdbElipsa.Location = new System.Drawing.Point(7, 98);
            this.vvrdbElipsa.Name = "vvrdbElipsa";
            this.vvrdbElipsa.Size = new System.Drawing.Size(59, 19);
            this.vvrdbElipsa.TabIndex = 4;
            this.vvrdbElipsa.TabStop = true;
            this.vvrdbElipsa.Text = "Elipsa";
            this.vvrdbElipsa.UseVisualStyleBackColor = true;
            this.vvrdbElipsa.CheckedChanged += new System.EventHandler(this.vvrdbElipsa_CheckedChanged);
            // 
            // vvrdbProstokątWypelniony
            // 
            this.vvrdbProstokątWypelniony.AutoSize = true;
            this.vvrdbProstokątWypelniony.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vvrdbProstokątWypelniony.Location = new System.Drawing.Point(116, 48);
            this.vvrdbProstokątWypelniony.Name = "vvrdbProstokątWypelniony";
            this.vvrdbProstokątWypelniony.Size = new System.Drawing.Size(141, 19);
            this.vvrdbProstokątWypelniony.TabIndex = 3;
            this.vvrdbProstokątWypelniony.TabStop = true;
            this.vvrdbProstokątWypelniony.Text = "Prostokąt Wypelniony";
            this.vvrdbProstokątWypelniony.UseVisualStyleBackColor = true;
            // 
            // vvrdbKwadratWypelniony
            // 
            this.vvrdbKwadratWypelniony.AutoSize = true;
            this.vvrdbKwadratWypelniony.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vvrdbKwadratWypelniony.Location = new System.Drawing.Point(116, 73);
            this.vvrdbKwadratWypelniony.Name = "vvrdbKwadratWypelniony";
            this.vvrdbKwadratWypelniony.Size = new System.Drawing.Size(135, 19);
            this.vvrdbKwadratWypelniony.TabIndex = 2;
            this.vvrdbKwadratWypelniony.TabStop = true;
            this.vvrdbKwadratWypelniony.Text = "Kwadrat Wypelniony";
            this.vvrdbKwadratWypelniony.UseVisualStyleBackColor = true;
            this.vvrdbKwadratWypelniony.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // vvrdbKwadrat
            // 
            this.vvrdbKwadrat.AutoSize = true;
            this.vvrdbKwadrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vvrdbKwadrat.Location = new System.Drawing.Point(7, 73);
            this.vvrdbKwadrat.Name = "vvrdbKwadrat";
            this.vvrdbKwadrat.Size = new System.Drawing.Size(70, 19);
            this.vvrdbKwadrat.TabIndex = 1;
            this.vvrdbKwadrat.TabStop = true;
            this.vvrdbKwadrat.Text = "Kwadrat";
            this.vvrdbKwadrat.UseVisualStyleBackColor = true;
            // 
            // vvrdbProstokąt
            // 
            this.vvrdbProstokąt.AutoSize = true;
            this.vvrdbProstokąt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vvrdbProstokąt.Location = new System.Drawing.Point(7, 48);
            this.vvrdbProstokąt.Name = "vvrdbProstokąt";
            this.vvrdbProstokąt.Size = new System.Drawing.Size(76, 19);
            this.vvrdbProstokąt.TabIndex = 0;
            this.vvrdbProstokąt.TabStop = true;
            this.vvrdbProstokąt.Text = "Prostokąt";
            this.vvrdbProstokąt.UseVisualStyleBackColor = true;
            // 
            // vvrdbSklejanaKrzywaBeziera
            // 
            this.vvrdbSklejanaKrzywaBeziera.AutoSize = true;
            this.vvrdbSklejanaKrzywaBeziera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vvrdbSklejanaKrzywaBeziera.Location = new System.Drawing.Point(7, 173);
            this.vvrdbSklejanaKrzywaBeziera.Name = "vvrdbSklejanaKrzywaBeziera";
            this.vvrdbSklejanaKrzywaBeziera.Size = new System.Drawing.Size(160, 19);
            this.vvrdbSklejanaKrzywaBeziera.TabIndex = 9;
            this.vvrdbSklejanaKrzywaBeziera.TabStop = true;
            this.vvrdbSklejanaKrzywaBeziera.Text = "Sklejana Krzywa Beziera";
            this.vvrdbSklejanaKrzywaBeziera.UseVisualStyleBackColor = true;
            // 
            // vvrdbKrzywaKardynalna
            // 
            this.vvrdbKrzywaKardynalna.AutoSize = true;
            this.vvrdbKrzywaKardynalna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vvrdbKrzywaKardynalna.Location = new System.Drawing.Point(7, 198);
            this.vvrdbKrzywaKardynalna.Name = "vvrdbKrzywaKardynalna";
            this.vvrdbKrzywaKardynalna.Size = new System.Drawing.Size(129, 19);
            this.vvrdbKrzywaKardynalna.TabIndex = 10;
            this.vvrdbKrzywaKardynalna.TabStop = true;
            this.vvrdbKrzywaKardynalna.Text = "Krzywa Kardynalna";
            this.vvrdbKrzywaKardynalna.UseVisualStyleBackColor = true;
            // 
            // KokpitProjekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 537);
            this.Controls.Add(this.vvgrbFigury_Linie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.vvlblY);
            this.Controls.Add(this.vvlblX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vvpbRysownica);
            this.Name = "KokpitProjekt";
            this.Text = "ProjektNr3_Stepushenkov63334";
            this.Load += new System.EventHandler(this.KokpitProjekt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vvpbRysownica)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.vvgrbFigury_Linie.ResumeLayout(false);
            this.vvgrbFigury_Linie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox vvpbRysownica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vvlblX;
        private System.Windows.Forms.Label vvlblY;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vvZapisPliku;
        private System.Windows.Forms.ToolStripMenuItem odczytanieTablicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vvExitZFormularza;
        private System.Windows.Forms.ToolStripMenuItem vvRestartProgramu;
        private System.Windows.Forms.ToolStripMenuItem koloryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vvkolorLinii;
        private System.Windows.Forms.ToolStripMenuItem vvKolorTlaRysownicy;
        private System.Windows.Forms.ToolStripMenuItem vvKolorWypelnienia;
        private System.Windows.Forms.ToolStripMenuItem atrybutyLiniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grubośćLiniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stylLiniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grotyRozpoczęciaLiniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grotyZakończeniaLiniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrybutyKreślonejCzcionkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krójCzcionkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozmiarCzcionkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorCzcionkiToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox vvgrbFigury_Linie;
        private System.Windows.Forms.RadioButton vvrdbProstokąt;
        private System.Windows.Forms.SaveFileDialog vvsaveFileDialog1;
        private System.Windows.Forms.ColorDialog vvcolorDialog1;
        private System.Windows.Forms.ColorDialog vvcolorDialog2;
        private System.Windows.Forms.ColorDialog vvcolorDialog3;
        private System.Windows.Forms.RadioButton vvrdbKwadrat;
        private System.Windows.Forms.RadioButton vvrdbKwadratWypelniony;
        private System.Windows.Forms.RadioButton vvrdbProstokątWypelniony;
        private System.Windows.Forms.RadioButton vvrdbElipsaWypelniona;
        private System.Windows.Forms.RadioButton vvrdbElipsa;
        private System.Windows.Forms.RadioButton vvrdbOkrąg;
        private System.Windows.Forms.RadioButton vvrdbOkrągWypelniony;
        private System.Windows.Forms.RadioButton vvrdbKrzywaBeziera;
        private System.Windows.Forms.RadioButton vvrdbKrzywaKardynalna;
        private System.Windows.Forms.RadioButton vvrdbSklejanaKrzywaBeziera;
    }
}