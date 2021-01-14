namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Tytuł = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEps = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtXd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGraficzna = new System.Windows.Forms.Button();
            this.btnWizualizacja = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtEpsc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtXg = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtXgc = new System.Windows.Forms.TextBox();
            this.txtXdc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.ZmiennaniezależnaX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wartośćfx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszWynikiZKontrolkiDataGridViewWPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pobranieWynikuZapisanegoWKontrolceDataGridViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijFormularzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjścieZProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nawigacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularzKredytyILokatyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stylLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniaKropkowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniaKreskowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniaKreskowoKropkowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniaKropkowoKreskowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorLiniiWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorTłaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrybutyFormularzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmianaKoloruFormularzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaFormularzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorCzcionkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWizualizacjaTabelaryczna = new System.Windows.Forms.Label();
            this.txtWynikSzeregu = new System.Windows.Forms.TextBox();
            this.lblCałka = new System.Windows.Forms.Label();
            this.lblWynikSzeregu = new System.Windows.Forms.Label();
            this.txtWynikCałki = new System.Windows.Forms.TextBox();
            this.chtGraficzna = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraficzna)).BeginInit();
            this.SuspendLayout();
            // 
            // Tytuł
            // 
            this.Tytuł.BackColor = System.Drawing.Color.LightCyan;
            this.Tytuł.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tytuł.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Tytuł.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tytuł.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Tytuł.Location = new System.Drawing.Point(238, 348);
            this.Tytuł.Name = "Tytuł";
            this.Tytuł.Size = new System.Drawing.Size(180, 35);
            this.Tytuł.TabIndex = 0;
            this.Tytuł.Text = "Obliczanie Całki";
            this.Tytuł.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tytuł.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dolna granica zmian X - Xd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(25, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Górna granica zmian X - Xg";
            // 
            // txtEps
            // 
            this.txtEps.Location = new System.Drawing.Point(243, 187);
            this.txtEps.Name = "txtEps";
            this.txtEps.Size = new System.Drawing.Size(172, 20);
            this.txtEps.TabIndex = 3;
            this.txtEps.TextChanged += new System.EventHandler(this.txtEps_TextChanged);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(243, 105);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(172, 20);
            this.txtX.TabIndex = 4;
            this.txtX.TextChanged += new System.EventHandler(this.txtXd_TextChanged);
            // 
            // txtXd
            // 
            this.txtXd.Location = new System.Drawing.Point(243, 131);
            this.txtXd.Name = "txtXd";
            this.txtXd.Size = new System.Drawing.Size(172, 20);
            this.txtXd.TabIndex = 5;
            this.txtXd.TextChanged += new System.EventHandler(this.txtXg_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(99, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dokładność Eps:";
            // 
            // btnOblicz
            // 
            this.btnOblicz.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnOblicz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOblicz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOblicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOblicz.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnOblicz.Location = new System.Drawing.Point(147, 482);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(193, 51);
            this.btnOblicz.TabIndex = 7;
            this.btnOblicz.Text = "Oblicz całkę";
            this.btnOblicz.UseVisualStyleBackColor = false;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(486, 456);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 54);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Resetuj";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGraficzna
            // 
            this.btnGraficzna.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnGraficzna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGraficzna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGraficzna.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnGraficzna.Location = new System.Drawing.Point(642, 356);
            this.btnGraficzna.Name = "btnGraficzna";
            this.btnGraficzna.Size = new System.Drawing.Size(193, 72);
            this.btnGraficzna.TabIndex = 9;
            this.btnGraficzna.Text = "Wizualizacja Graficzna";
            this.btnGraficzna.UseVisualStyleBackColor = false;
            this.btnGraficzna.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnWizualizacja
            // 
            this.btnWizualizacja.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnWizualizacja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWizualizacja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWizualizacja.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnWizualizacja.Location = new System.Drawing.Point(642, 186);
            this.btnWizualizacja.Name = "btnWizualizacja";
            this.btnWizualizacja.Size = new System.Drawing.Size(193, 73);
            this.btnWizualizacja.TabIndex = 10;
            this.btnWizualizacja.Text = "Wizualizacja Tabelaryczna";
            this.btnWizualizacja.UseVisualStyleBackColor = false;
            this.btnWizualizacja.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(243, 213);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(172, 20);
            this.txtH.TabIndex = 11;
            // 
            // txtEpsc
            // 
            this.txtEpsc.Location = new System.Drawing.Point(158, 456);
            this.txtEpsc.Name = "txtEpsc";
            this.txtEpsc.Size = new System.Drawing.Size(172, 20);
            this.txtEpsc.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(480, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Metoda całkowania";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(19, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Przyrost zmiennej X - H<1;3)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(19, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Zmienna niezależna X <1;3):";
            // 
            // txtXg
            // 
            this.txtXg.Location = new System.Drawing.Point(243, 161);
            this.txtXg.Name = "txtXg";
            this.txtXg.Size = new System.Drawing.Size(172, 20);
            this.txtXg.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Location = new System.Drawing.Point(230, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 56);
            this.button4.TabIndex = 17;
            this.button4.Text = "Oblicz wartość F(x)";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Dolna granica <1;3)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(9, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Górna granica <1;3)";
            // 
            // txtXgc
            // 
            this.txtXgc.Location = new System.Drawing.Point(158, 404);
            this.txtXgc.Name = "txtXgc";
            this.txtXgc.Size = new System.Drawing.Size(172, 20);
            this.txtXgc.TabIndex = 21;
            // 
            // txtXdc
            // 
            this.txtXdc.Location = new System.Drawing.Point(158, 430);
            this.txtXdc.Name = "txtXdc";
            this.txtXdc.Size = new System.Drawing.Size(172, 20);
            this.txtXdc.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(22, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Dokładność Eps:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Trapezów",
            "Jakiegośtypa"});
            this.comboBox1.Location = new System.Drawing.Point(358, 404);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightCyan;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label10.Location = new System.Drawing.Point(187, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(283, 30);
            this.label10.TabIndex = 25;
            this.label10.Text = "Obliczanie Sumy Szeregu";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(441, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 128);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // dgvTabela
            // 
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZmiennaniezależnaX,
            this.Wartośćfx});
            this.dgvTabela.Location = new System.Drawing.Point(940, 88);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.Size = new System.Drawing.Size(362, 340);
            this.dgvTabela.TabIndex = 28;
            // 
            // ZmiennaniezależnaX
            // 
            this.ZmiennaniezależnaX.HeaderText = "Zmienna niezależna X";
            this.ZmiennaniezależnaX.Name = "ZmiennaniezależnaX";
            this.ZmiennaniezależnaX.Width = 160;
            // 
            // Wartośćfx
            // 
            this.Wartośćfx.HeaderText = "Wartość F(x)";
            this.Wartośćfx.Name = "Wartośćfx";
            this.Wartośćfx.Width = 160;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.nawigacjaToolStripMenuItem,
            this.stylLiniiToolStripMenuItem,
            this.kolorLiniiWykresuToolStripMenuItem,
            this.atrybutyFormularzaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszWynikiZKontrolkiDataGridViewWPlikuToolStripMenuItem,
            this.pobranieWynikuZapisanegoWKontrolceDataGridViewToolStripMenuItem,
            this.zamknijFormularzToolStripMenuItem,
            this.wyjścieZProgramuToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszWynikiZKontrolkiDataGridViewWPlikuToolStripMenuItem
            // 
            this.zapiszWynikiZKontrolkiDataGridViewWPlikuToolStripMenuItem.Name = "zapiszWynikiZKontrolkiDataGridViewWPlikuToolStripMenuItem";
            this.zapiszWynikiZKontrolkiDataGridViewWPlikuToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.zapiszWynikiZKontrolkiDataGridViewWPlikuToolStripMenuItem.Text = "Zapisz wyniki z kontrolki DataGridView w pliku";
            // 
            // pobranieWynikuZapisanegoWKontrolceDataGridViewToolStripMenuItem
            // 
            this.pobranieWynikuZapisanegoWKontrolceDataGridViewToolStripMenuItem.Name = "pobranieWynikuZapisanegoWKontrolceDataGridViewToolStripMenuItem";
            this.pobranieWynikuZapisanegoWKontrolceDataGridViewToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.pobranieWynikuZapisanegoWKontrolceDataGridViewToolStripMenuItem.Text = "Pobranie wyniku zapisanego w kontrolce DataGridView";
            // 
            // zamknijFormularzToolStripMenuItem
            // 
            this.zamknijFormularzToolStripMenuItem.Name = "zamknijFormularzToolStripMenuItem";
            this.zamknijFormularzToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.zamknijFormularzToolStripMenuItem.Text = "Zamknij formularz";
            // 
            // wyjścieZProgramuToolStripMenuItem
            // 
            this.wyjścieZProgramuToolStripMenuItem.Name = "wyjścieZProgramuToolStripMenuItem";
            this.wyjścieZProgramuToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.wyjścieZProgramuToolStripMenuItem.Text = "Wyjście z programu";
            // 
            // nawigacjaToolStripMenuItem
            // 
            this.nawigacjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularzKredytyILokatyToolStripMenuItem});
            this.nawigacjaToolStripMenuItem.Name = "nawigacjaToolStripMenuItem";
            this.nawigacjaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.nawigacjaToolStripMenuItem.Text = "Nawigacja";
            // 
            // formularzKredytyILokatyToolStripMenuItem
            // 
            this.formularzKredytyILokatyToolStripMenuItem.Name = "formularzKredytyILokatyToolStripMenuItem";
            this.formularzKredytyILokatyToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.formularzKredytyILokatyToolStripMenuItem.Text = "Formularz Kredyty i Lokaty";
            // 
            // stylLiniiToolStripMenuItem
            // 
            this.stylLiniiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liniaKropkowaToolStripMenuItem,
            this.liniaKreskowaToolStripMenuItem,
            this.liniaKreskowoKropkowaToolStripMenuItem,
            this.liniaKropkowoKreskowaToolStripMenuItem});
            this.stylLiniiToolStripMenuItem.Name = "stylLiniiToolStripMenuItem";
            this.stylLiniiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.stylLiniiToolStripMenuItem.Text = "Styl linii ";
            // 
            // liniaKropkowaToolStripMenuItem
            // 
            this.liniaKropkowaToolStripMenuItem.Name = "liniaKropkowaToolStripMenuItem";
            this.liniaKropkowaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.liniaKropkowaToolStripMenuItem.Text = "Linia kropkowa";
            this.liniaKropkowaToolStripMenuItem.Click += new System.EventHandler(this.liniaKropkowaToolStripMenuItem_Click);
            // 
            // liniaKreskowaToolStripMenuItem
            // 
            this.liniaKreskowaToolStripMenuItem.Name = "liniaKreskowaToolStripMenuItem";
            this.liniaKreskowaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.liniaKreskowaToolStripMenuItem.Text = "Linia kreskowa";
            // 
            // liniaKreskowoKropkowaToolStripMenuItem
            // 
            this.liniaKreskowoKropkowaToolStripMenuItem.Name = "liniaKreskowoKropkowaToolStripMenuItem";
            this.liniaKreskowoKropkowaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.liniaKreskowoKropkowaToolStripMenuItem.Text = "Linia kreskowo kropkowa";
            // 
            // liniaKropkowoKreskowaToolStripMenuItem
            // 
            this.liniaKropkowoKreskowaToolStripMenuItem.Name = "liniaKropkowoKreskowaToolStripMenuItem";
            this.liniaKropkowoKreskowaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.liniaKropkowoKreskowaToolStripMenuItem.Text = "Linia kropkowo kreskowa";
            // 
            // kolorLiniiWykresuToolStripMenuItem
            // 
            this.kolorLiniiWykresuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolorLiniiToolStripMenuItem,
            this.kolorTłaToolStripMenuItem});
            this.kolorLiniiWykresuToolStripMenuItem.Name = "kolorLiniiWykresuToolStripMenuItem";
            this.kolorLiniiWykresuToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.kolorLiniiWykresuToolStripMenuItem.Text = "Kolor linii wykresu";
            this.kolorLiniiWykresuToolStripMenuItem.Click += new System.EventHandler(this.kolorLiniiWykresuToolStripMenuItem_Click);
            // 
            // kolorLiniiToolStripMenuItem
            // 
            this.kolorLiniiToolStripMenuItem.Name = "kolorLiniiToolStripMenuItem";
            this.kolorLiniiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kolorLiniiToolStripMenuItem.Text = "Kolor linii";
            // 
            // kolorTłaToolStripMenuItem
            // 
            this.kolorTłaToolStripMenuItem.Name = "kolorTłaToolStripMenuItem";
            this.kolorTłaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kolorTłaToolStripMenuItem.Text = "Kolor tła";
            // 
            // atrybutyFormularzaToolStripMenuItem
            // 
            this.atrybutyFormularzaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zmianaKoloruFormularzaToolStripMenuItem,
            this.czcionkaFormularzaToolStripMenuItem,
            this.kolorCzcionkiToolStripMenuItem});
            this.atrybutyFormularzaToolStripMenuItem.Name = "atrybutyFormularzaToolStripMenuItem";
            this.atrybutyFormularzaToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.atrybutyFormularzaToolStripMenuItem.Text = "Atrybuty formularza";
            // 
            // zmianaKoloruFormularzaToolStripMenuItem
            // 
            this.zmianaKoloruFormularzaToolStripMenuItem.Name = "zmianaKoloruFormularzaToolStripMenuItem";
            this.zmianaKoloruFormularzaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.zmianaKoloruFormularzaToolStripMenuItem.Text = "Kolor  formularza";
            this.zmianaKoloruFormularzaToolStripMenuItem.Click += new System.EventHandler(this.zmianaKoloruFormularzaToolStripMenuItem_Click);
            // 
            // czcionkaFormularzaToolStripMenuItem
            // 
            this.czcionkaFormularzaToolStripMenuItem.Name = "czcionkaFormularzaToolStripMenuItem";
            this.czcionkaFormularzaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.czcionkaFormularzaToolStripMenuItem.Text = "Czcionka formularza";
            this.czcionkaFormularzaToolStripMenuItem.Click += new System.EventHandler(this.czcionkaFormularzaToolStripMenuItem_Click);
            // 
            // kolorCzcionkiToolStripMenuItem
            // 
            this.kolorCzcionkiToolStripMenuItem.Name = "kolorCzcionkiToolStripMenuItem";
            this.kolorCzcionkiToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.kolorCzcionkiToolStripMenuItem.Text = "Kolor czcionki";
            // 
            // lblWizualizacjaTabelaryczna
            // 
            this.lblWizualizacjaTabelaryczna.AutoSize = true;
            this.lblWizualizacjaTabelaryczna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWizualizacjaTabelaryczna.Location = new System.Drawing.Point(1028, 55);
            this.lblWizualizacjaTabelaryczna.Name = "lblWizualizacjaTabelaryczna";
            this.lblWizualizacjaTabelaryczna.Size = new System.Drawing.Size(194, 20);
            this.lblWizualizacjaTabelaryczna.TabIndex = 27;
            this.lblWizualizacjaTabelaryczna.Text = "Wizualizacja Tabelaryczna";
            this.lblWizualizacjaTabelaryczna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWizualizacjaTabelaryczna.Visible = false;
            // 
            // txtWynikSzeregu
            // 
            this.txtWynikSzeregu.Location = new System.Drawing.Point(243, 301);
            this.txtWynikSzeregu.Name = "txtWynikSzeregu";
            this.txtWynikSzeregu.Size = new System.Drawing.Size(172, 20);
            this.txtWynikSzeregu.TabIndex = 30;
            // 
            // lblCałka
            // 
            this.lblCałka.AutoSize = true;
            this.lblCałka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCałka.Location = new System.Drawing.Point(65, 539);
            this.lblCałka.Name = "lblCałka";
            this.lblCałka.Size = new System.Drawing.Size(87, 20);
            this.lblCałka.TabIndex = 32;
            this.lblCałka.Text = "Wynik całki";
            // 
            // lblWynikSzeregu
            // 
            this.lblWynikSzeregu.AutoSize = true;
            this.lblWynikSzeregu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWynikSzeregu.Location = new System.Drawing.Point(127, 301);
            this.lblWynikSzeregu.Name = "lblWynikSzeregu";
            this.lblWynikSzeregu.Size = new System.Drawing.Size(115, 20);
            this.lblWynikSzeregu.TabIndex = 33;
            this.lblWynikSzeregu.Text = "Suma Szeregu";
            // 
            // txtWynikCałki
            // 
            this.txtWynikCałki.Location = new System.Drawing.Point(158, 539);
            this.txtWynikCałki.Name = "txtWynikCałki";
            this.txtWynikCałki.Size = new System.Drawing.Size(172, 20);
            this.txtWynikCałki.TabIndex = 31;
            // 
            // chtGraficzna
            // 
            chartArea2.Name = "ChartArea1";
            this.chtGraficzna.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtGraficzna.Legends.Add(legend2);
            this.chtGraficzna.Location = new System.Drawing.Point(940, 88);
            this.chtGraficzna.Name = "chtGraficzna";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtGraficzna.Series.Add(series2);
            this.chtGraficzna.Size = new System.Drawing.Size(362, 340);
            this.chtGraficzna.TabIndex = 34;
            this.chtGraficzna.Text = "Wykres Zmiany Wartości F(x)";
            this.chtGraficzna.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1354, 726);
            this.Controls.Add(this.chtGraficzna);
            this.Controls.Add(this.lblWynikSzeregu);
            this.Controls.Add(this.lblCałka);
            this.Controls.Add(this.txtWynikCałki);
            this.Controls.Add(this.txtWynikSzeregu);
            this.Controls.Add(this.dgvTabela);
            this.Controls.Add(this.lblWizualizacjaTabelaryczna);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtXdc);
            this.Controls.Add(this.txtXgc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtXg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEpsc);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.btnWizualizacja);
            this.Controls.Add(this.btnGraficzna);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtXd);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtEps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tytuł);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraficzna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tytuł;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEps;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtXd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGraficzna;
        private System.Windows.Forms.Button btnWizualizacja;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEpsc;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtXg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtXdc;
        private System.Windows.Forms.TextBox txtXgc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszWynikiZKontrolkiDataGridViewWPlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pobranieWynikuZapisanegoWKontrolceDataGridViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijFormularzToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem wyjścieZProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nawigacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularzKredytyILokatyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stylLiniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liniaKropkowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liniaKreskowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liniaKreskowoKropkowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liniaKropkowoKreskowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorLiniiWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorLiniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorTłaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrybutyFormularzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmianaKoloruFormularzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaFormularzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorCzcionkiToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZmiennaniezależnaX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wartośćfx;
        private System.Windows.Forms.Label lblWizualizacjaTabelaryczna;
        private System.Windows.Forms.Label lblWynikSzeregu;
        private System.Windows.Forms.Label lblCałka;
        private System.Windows.Forms.TextBox txtWynikCałki;
        private System.Windows.Forms.TextBox txtWynikSzeregu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraficzna;
    }
}

