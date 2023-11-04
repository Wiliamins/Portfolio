namespace ProjektNr3_Stepushenkov63334
{
    partial class KokpitLab
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapisanieTablicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odczytanieTablicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitZFormularza = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koloryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorLinii = new System.Windows.Forms.ToolStripMenuItem();
            this.KolorTlaRysownicy = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorWypełnieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrybutyLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grubośćLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stylLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grotyRozpoczęciaLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grotyZakończeniaLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrybutyKreślonejCzcionkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krójCzcionkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozmiarCzcionkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorCzcionkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.rdbPunkt = new System.Windows.Forms.RadioButton();
            this.rdbLiniaProsta = new System.Windows.Forms.RadioButton();
            this.rdbLiniaKreślonaMyszą = new System.Windows.Forms.RadioButton();
            this.rdbWielokatForemny = new System.Windows.Forms.RadioButton();
            this.rdbWielokatWypelniony = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.rdbTrójkątSierpińskiego = new System.Windows.Forms.RadioButton();
            this.rdbDywan = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.numUD_LiczbaKątów2 = new System.Windows.Forms.NumericUpDown();
            this.numUD_LiczbaKątów = new System.Windows.Forms.NumericUpDown();
            this.numUD_PoziomRekurencji = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.lblLiczbaKątów = new System.Windows.Forms.Label();
            this.lblPoziomRekurencji = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.colorDialog4 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_LiczbaKątów2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_LiczbaKątów)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_PoziomRekurencji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapisanieTablicyToolStripMenuItem,
            this.odczytanieTablicyToolStripMenuItem,
            this.ExitZFormularza,
            this.exitToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zapisanieTablicyToolStripMenuItem
            // 
            this.zapisanieTablicyToolStripMenuItem.Name = "zapisanieTablicyToolStripMenuItem";
            this.zapisanieTablicyToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.zapisanieTablicyToolStripMenuItem.Text = "Zapisza BitMapę w pliku";
            this.zapisanieTablicyToolStripMenuItem.Click += new System.EventHandler(this.zapisanieTablicyToolStripMenuItem_Click);
            // 
            // odczytanieTablicyToolStripMenuItem
            // 
            this.odczytanieTablicyToolStripMenuItem.Name = "odczytanieTablicyToolStripMenuItem";
            this.odczytanieTablicyToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.odczytanieTablicyToolStripMenuItem.Text = "Odczytaj BitMapę z pliku";
            this.odczytanieTablicyToolStripMenuItem.Click += new System.EventHandler(this.odczytanieTablicyToolStripMenuItem_Click);
            // 
            // ExitZFormularza
            // 
            this.ExitZFormularza.Name = "ExitZFormularza";
            this.ExitZFormularza.Size = new System.Drawing.Size(204, 22);
            this.ExitZFormularza.Text = "Exit z formularza";
            this.ExitZFormularza.Click += new System.EventHandler(this.ExitZFormularza_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.exitToolStripMenuItem.Text = "Restart programu";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // koloryToolStripMenuItem
            // 
            this.koloryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolorLinii,
            this.KolorTlaRysownicy,
            this.kolorWypełnieniaToolStripMenuItem});
            this.koloryToolStripMenuItem.Name = "koloryToolStripMenuItem";
            this.koloryToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.koloryToolStripMenuItem.Text = "Kolory";
            // 
            // kolorLinii
            // 
            this.kolorLinii.Name = "kolorLinii";
            this.kolorLinii.Size = new System.Drawing.Size(174, 22);
            this.kolorLinii.Text = "Kolor linii";
            this.kolorLinii.Click += new System.EventHandler(this.kolorLinii_Click);
            // 
            // KolorTlaRysownicy
            // 
            this.KolorTlaRysownicy.Name = "KolorTlaRysownicy";
            this.KolorTlaRysownicy.Size = new System.Drawing.Size(174, 22);
            this.KolorTlaRysownicy.Text = "Kolor tla rysownicy";
            this.KolorTlaRysownicy.Click += new System.EventHandler(this.KolorTlaRysownicy_Click);
            // 
            // kolorWypełnieniaToolStripMenuItem
            // 
            this.kolorWypełnieniaToolStripMenuItem.Name = "kolorWypełnieniaToolStripMenuItem";
            this.kolorWypełnieniaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.kolorWypełnieniaToolStripMenuItem.Text = "Kolor wypełnienia";
            this.kolorWypełnieniaToolStripMenuItem.Click += new System.EventHandler(this.kolorWypełnieniaToolStripMenuItem_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Współrzędne (x, y) położenia myśzy:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblX.Location = new System.Drawing.Point(391, 38);
            this.lblX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(52, 18);
            this.lblX.TabIndex = 26;
            this.lblX.Text = "label2";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblY.Location = new System.Drawing.Point(447, 38);
            this.lblY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(52, 18);
            this.lblY.TabIndex = 27;
            this.lblY.Text = "label3";
            // 
            // rdbPunkt
            // 
            this.rdbPunkt.AutoSize = true;
            this.rdbPunkt.Location = new System.Drawing.Point(629, 74);
            this.rdbPunkt.Name = "rdbPunkt";
            this.rdbPunkt.Size = new System.Drawing.Size(53, 17);
            this.rdbPunkt.TabIndex = 28;
            this.rdbPunkt.TabStop = true;
            this.rdbPunkt.Text = "Punkt";
            this.rdbPunkt.UseVisualStyleBackColor = true;
            // 
            // rdbLiniaProsta
            // 
            this.rdbLiniaProsta.AutoSize = true;
            this.rdbLiniaProsta.Location = new System.Drawing.Point(629, 112);
            this.rdbLiniaProsta.Name = "rdbLiniaProsta";
            this.rdbLiniaProsta.Size = new System.Drawing.Size(79, 17);
            this.rdbLiniaProsta.TabIndex = 29;
            this.rdbLiniaProsta.TabStop = true;
            this.rdbLiniaProsta.Text = "Linia prosta";
            this.rdbLiniaProsta.UseVisualStyleBackColor = true;
            this.rdbLiniaProsta.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbLiniaKreślonaMyszą
            // 
            this.rdbLiniaKreślonaMyszą.AutoSize = true;
            this.rdbLiniaKreślonaMyszą.Location = new System.Drawing.Point(629, 149);
            this.rdbLiniaKreślonaMyszą.Name = "rdbLiniaKreślonaMyszą";
            this.rdbLiniaKreślonaMyszą.Size = new System.Drawing.Size(153, 17);
            this.rdbLiniaKreślonaMyszą.TabIndex = 30;
            this.rdbLiniaKreślonaMyszą.TabStop = true;
            this.rdbLiniaKreślonaMyszą.Text = "Linia ciągla kreślona myszą";
            this.rdbLiniaKreślonaMyszą.UseVisualStyleBackColor = true;
            // 
            // rdbWielokatForemny
            // 
            this.rdbWielokatForemny.AutoSize = true;
            this.rdbWielokatForemny.Location = new System.Drawing.Point(629, 188);
            this.rdbWielokatForemny.Name = "rdbWielokatForemny";
            this.rdbWielokatForemny.Size = new System.Drawing.Size(107, 17);
            this.rdbWielokatForemny.TabIndex = 31;
            this.rdbWielokatForemny.TabStop = true;
            this.rdbWielokatForemny.Text = "Wielokąt foremny";
            this.rdbWielokatForemny.UseVisualStyleBackColor = true;
            this.rdbWielokatForemny.CheckedChanged += new System.EventHandler(this.rdbWielokatForemny_CheckedChanged);
            // 
            // rdbWielokatWypelniony
            // 
            this.rdbWielokatWypelniony.AutoSize = true;
            this.rdbWielokatWypelniony.Location = new System.Drawing.Point(629, 226);
            this.rdbWielokatWypelniony.Name = "rdbWielokatWypelniony";
            this.rdbWielokatWypelniony.Size = new System.Drawing.Size(124, 17);
            this.rdbWielokatWypelniony.TabIndex = 32;
            this.rdbWielokatWypelniony.TabStop = true;
            this.rdbWielokatWypelniony.Text = "Wielokąt wypełniony";
            this.rdbWielokatWypelniony.UseVisualStyleBackColor = true;
            this.rdbWielokatWypelniony.CheckedChanged += new System.EventHandler(this.rdbWielokatWypelniony_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(629, 265);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(136, 17);
            this.radioButton6.TabIndex = 33;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Gwiazda wieloramienna";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // rdbTrójkątSierpińskiego
            // 
            this.rdbTrójkątSierpińskiego.AutoSize = true;
            this.rdbTrójkątSierpińskiego.Location = new System.Drawing.Point(629, 309);
            this.rdbTrójkątSierpińskiego.Name = "rdbTrójkątSierpińskiego";
            this.rdbTrójkątSierpińskiego.Size = new System.Drawing.Size(124, 17);
            this.rdbTrójkątSierpińskiego.TabIndex = 34;
            this.rdbTrójkątSierpińskiego.TabStop = true;
            this.rdbTrójkątSierpińskiego.Text = "Trójkąt Sierpińskiego";
            this.rdbTrójkątSierpińskiego.UseVisualStyleBackColor = true;
            this.rdbTrójkątSierpińskiego.CheckedChanged += new System.EventHandler(this.rdbTrójkąt_CheckedChanged);
            // 
            // rdbDywan
            // 
            this.rdbDywan.AutoSize = true;
            this.rdbDywan.Location = new System.Drawing.Point(629, 354);
            this.rdbDywan.Name = "rdbDywan";
            this.rdbDywan.Size = new System.Drawing.Size(124, 17);
            this.rdbDywan.TabIndex = 35;
            this.rdbDywan.TabStop = true;
            this.rdbDywan.Text = "Dywan Sierpińskiego";
            this.rdbDywan.UseVisualStyleBackColor = true;
            this.rdbDywan.CheckedChanged += new System.EventHandler(this.rdbDywan_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(629, 400);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(57, 17);
            this.radioButton9.TabIndex = 36;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Fraktal";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(522, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Laboratorium Nr 3 (kreślenie krzywych geometrycznych)\r\n";
            // 
            // pbRysownica
            // 
            this.pbRysownica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRysownica.Location = new System.Drawing.Point(31, 74);
            this.pbRysownica.Margin = new System.Windows.Forms.Padding(2);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(576, 343);
            this.pbRysownica.TabIndex = 38;
            this.pbRysownica.TabStop = false;
            this.pbRysownica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseDown);
            this.pbRysownica.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseMove);
            this.pbRysownica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseUp);
            // 
            // numUD_LiczbaKątów2
            // 
            this.numUD_LiczbaKątów2.Location = new System.Drawing.Point(829, 226);
            this.numUD_LiczbaKątów2.Name = "numUD_LiczbaKątów2";
            this.numUD_LiczbaKątów2.Size = new System.Drawing.Size(120, 20);
            this.numUD_LiczbaKątów2.TabIndex = 39;
            this.numUD_LiczbaKątów2.Visible = false;
            // 
            // numUD_LiczbaKątów
            // 
            this.numUD_LiczbaKątów.Location = new System.Drawing.Point(829, 185);
            this.numUD_LiczbaKątów.Name = "numUD_LiczbaKątów";
            this.numUD_LiczbaKątów.Size = new System.Drawing.Size(120, 20);
            this.numUD_LiczbaKątów.TabIndex = 40;
            this.numUD_LiczbaKątów.Visible = false;
            // 
            // numUD_PoziomRekurencji
            // 
            this.numUD_PoziomRekurencji.Location = new System.Drawing.Point(829, 306);
            this.numUD_PoziomRekurencji.Name = "numUD_PoziomRekurencji";
            this.numUD_PoziomRekurencji.Size = new System.Drawing.Size(120, 20);
            this.numUD_PoziomRekurencji.TabIndex = 41;
            this.numUD_PoziomRekurencji.Visible = false;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(829, 351);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown4.TabIndex = 42;
            this.numericUpDown4.Visible = false;
            // 
            // lblLiczbaKątów
            // 
            this.lblLiczbaKątów.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLiczbaKątów.Location = new System.Drawing.Point(826, 159);
            this.lblLiczbaKątów.Name = "lblLiczbaKątów";
            this.lblLiczbaKątów.Size = new System.Drawing.Size(123, 23);
            this.lblLiczbaKątów.TabIndex = 43;
            this.lblLiczbaKątów.Text = "Liczba kątów";
            this.lblLiczbaKątów.Visible = false;
            // 
            // lblPoziomRekurencji
            // 
            this.lblPoziomRekurencji.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPoziomRekurencji.Location = new System.Drawing.Point(804, 273);
            this.lblPoziomRekurencji.Name = "lblPoziomRekurencji";
            this.lblPoziomRekurencji.Size = new System.Drawing.Size(158, 30);
            this.lblPoziomRekurencji.TabIndex = 44;
            this.lblPoziomRekurencji.Text = "Poziom rekurencji";
            this.lblPoziomRekurencji.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // KokpitLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 540);
            this.Controls.Add(this.lblPoziomRekurencji);
            this.Controls.Add(this.lblLiczbaKątów);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numUD_PoziomRekurencji);
            this.Controls.Add(this.numUD_LiczbaKątów);
            this.Controls.Add(this.numUD_LiczbaKątów2);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.rdbDywan);
            this.Controls.Add(this.rdbTrójkątSierpińskiego);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.rdbWielokatWypelniony);
            this.Controls.Add(this.rdbWielokatForemny);
            this.Controls.Add(this.rdbLiniaKreślonaMyszą);
            this.Controls.Add(this.rdbLiniaProsta);
            this.Controls.Add(this.rdbPunkt);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "KokpitLab";
            this.Text = "LaboratoriumNr3_Vaiuta63247";
            this.Load += new System.EventHandler(this.KokpitLab_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_LiczbaKątów2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_LiczbaKątów)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_PoziomRekurencji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapisanieTablicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odczytanieTablicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitZFormularza;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koloryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorLinii;
        private System.Windows.Forms.ToolStripMenuItem KolorTlaRysownicy;
        private System.Windows.Forms.ToolStripMenuItem kolorWypełnieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrybutyLiniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grubośćLiniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stylLiniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grotyRozpoczęciaLiniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grotyZakończeniaLiniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrybutyKreślonejCzcionkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krójCzcionkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozmiarCzcionkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorCzcionkiToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.RadioButton rdbPunkt;
        private System.Windows.Forms.RadioButton rdbLiniaProsta;
        private System.Windows.Forms.RadioButton rdbLiniaKreślonaMyszą;
        private System.Windows.Forms.RadioButton rdbWielokatForemny;
        private System.Windows.Forms.RadioButton rdbWielokatWypelniony;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton rdbTrójkątSierpińskiego;
        private System.Windows.Forms.RadioButton rdbDywan;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.NumericUpDown numUD_LiczbaKątów2;
        private System.Windows.Forms.NumericUpDown numUD_LiczbaKątów;
        private System.Windows.Forms.NumericUpDown numUD_PoziomRekurencji;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label lblLiczbaKątów;
        private System.Windows.Forms.Label lblPoziomRekurencji;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.ColorDialog colorDialog4;
    }
}