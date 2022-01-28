namespace FixUpGuy
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zleceniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wszystkieZleceniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mojeZleceniaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.weźZlecenieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajZlecenieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.przypiszZlecenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.użytkownikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujSięToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zalogujSięToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUżytkownikaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńUżytkownikaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaUżytkownikówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.połaczenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_opis = new System.Windows.Forms.Label();
            this.text_opis = new System.Windows.Forms.RichTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.wybierz_termin = new System.Windows.Forms.Label();
            this.dodaj_link = new System.Windows.Forms.Label();
            this.text_link = new System.Windows.Forms.TextBox();
            this.but_dodaj = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_wez_id = new System.Windows.Forms.Label();
            this.label_wez_kom = new System.Windows.Forms.Label();
            this.text_wez_id = new System.Windows.Forms.TextBox();
            this.richText_wez_kom = new System.Windows.Forms.RichTextBox();
            this.but_wez_zlecenie = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.text_dodajuz_login = new System.Windows.Forms.Label();
            this.text_dodajuz_haslo = new System.Windows.Forms.Label();
            this.text_dodajuz_email = new System.Windows.Forms.Label();
            this.text_dodajuz_typkonta = new System.Windows.Forms.Label();
            this.textBox_dodajuz_login = new System.Windows.Forms.TextBox();
            this.textBox_dodajuz_haslo = new System.Windows.Forms.TextBox();
            this.textBox_dodajuz_email = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel_dodajuz_radio = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton_dodajuz_typadmin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_dodajuz_typserwis = new System.Windows.Forms.RadioButton();
            this.button_dodajuz_dodaj = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label_usunuz_login = new System.Windows.Forms.Label();
            this.textBox_usunuz_login = new System.Windows.Forms.TextBox();
            this.button_usunuz_usun = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label_przyp_id_klient = new System.Windows.Forms.Label();
            this.label_przyp_id_zlec = new System.Windows.Forms.Label();
            this.textBox_przyp_id_zlec = new System.Windows.Forms.TextBox();
            this.textBox_przyp_id_klient = new System.Windows.Forms.TextBox();
            this.button_przypisz_zlecenie = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel_dodajuz_radio.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.menuStrip1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(779, 32);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zleceniaToolStripMenuItem,
            this.użytkownikToolStripMenuItem,
            this.połaczenieToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(238, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // zleceniaToolStripMenuItem
            // 
            this.zleceniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wszystkieZleceniaToolStripMenuItem,
            this.mojeZleceniaToolStripMenuItem1,
            this.weźZlecenieToolStripMenuItem1,
            this.dodajZlecenieToolStripMenuItem1,
            this.przypiszZlecenieToolStripMenuItem});
            this.zleceniaToolStripMenuItem.Name = "zleceniaToolStripMenuItem";
            this.zleceniaToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.zleceniaToolStripMenuItem.Text = "Zlecenia";
            this.zleceniaToolStripMenuItem.Click += new System.EventHandler(this.zleceniaToolStripMenuItem_Click);
            // 
            // wszystkieZleceniaToolStripMenuItem
            // 
            this.wszystkieZleceniaToolStripMenuItem.Name = "wszystkieZleceniaToolStripMenuItem";
            this.wszystkieZleceniaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wszystkieZleceniaToolStripMenuItem.Text = "Wszystkie zlecenia";
            this.wszystkieZleceniaToolStripMenuItem.Click += new System.EventHandler(this.wszystkieZleceniaToolStripMenuItem_Click);
            // 
            // mojeZleceniaToolStripMenuItem1
            // 
            this.mojeZleceniaToolStripMenuItem1.Name = "mojeZleceniaToolStripMenuItem1";
            this.mojeZleceniaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.mojeZleceniaToolStripMenuItem1.Text = "Moje zlecenia";
            this.mojeZleceniaToolStripMenuItem1.Click += new System.EventHandler(this.mojeZleceniaToolStripMenuItem1_Click);
            // 
            // weźZlecenieToolStripMenuItem1
            // 
            this.weźZlecenieToolStripMenuItem1.Name = "weźZlecenieToolStripMenuItem1";
            this.weźZlecenieToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.weźZlecenieToolStripMenuItem1.Text = "Weź zlecenie";
            this.weźZlecenieToolStripMenuItem1.Click += new System.EventHandler(this.weźZlecenieToolStripMenuItem1_Click);
            // 
            // dodajZlecenieToolStripMenuItem1
            // 
            this.dodajZlecenieToolStripMenuItem1.Name = "dodajZlecenieToolStripMenuItem1";
            this.dodajZlecenieToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dodajZlecenieToolStripMenuItem1.Text = "Dodaj zlecenie";
            this.dodajZlecenieToolStripMenuItem1.Click += new System.EventHandler(this.dodajZlecenieToolStripMenuItem1_Click);
            // 
            // przypiszZlecenieToolStripMenuItem
            // 
            this.przypiszZlecenieToolStripMenuItem.Name = "przypiszZlecenieToolStripMenuItem";
            this.przypiszZlecenieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.przypiszZlecenieToolStripMenuItem.Text = "Przypisz zlecenie";
            this.przypiszZlecenieToolStripMenuItem.Click += new System.EventHandler(this.przypiszZlecenieToolStripMenuItem_Click);
            // 
            // użytkownikToolStripMenuItem
            // 
            this.użytkownikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wylogujSięToolStripMenuItem,
            this.zalogujSięToolStripMenuItem1,
            this.dodajUżytkownikaToolStripMenuItem1,
            this.usuńUżytkownikaToolStripMenuItem1,
            this.listaUżytkownikówToolStripMenuItem});
            this.użytkownikToolStripMenuItem.Name = "użytkownikToolStripMenuItem";
            this.użytkownikToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.użytkownikToolStripMenuItem.Text = "Użytkownik";
            // 
            // wylogujSięToolStripMenuItem
            // 
            this.wylogujSięToolStripMenuItem.Name = "wylogujSięToolStripMenuItem";
            this.wylogujSięToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wylogujSięToolStripMenuItem.Text = "Wyloguj się";
            this.wylogujSięToolStripMenuItem.Click += new System.EventHandler(this.wylogujSięToolStripMenuItem_Click);
            // 
            // zalogujSięToolStripMenuItem1
            // 
            this.zalogujSięToolStripMenuItem1.Name = "zalogujSięToolStripMenuItem1";
            this.zalogujSięToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.zalogujSięToolStripMenuItem1.Text = "Zaloguj się";
            this.zalogujSięToolStripMenuItem1.Click += new System.EventHandler(this.zalogujSięToolStripMenuItem1_Click);
            // 
            // dodajUżytkownikaToolStripMenuItem1
            // 
            this.dodajUżytkownikaToolStripMenuItem1.Name = "dodajUżytkownikaToolStripMenuItem1";
            this.dodajUżytkownikaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dodajUżytkownikaToolStripMenuItem1.Text = "Dodaj użytkownika";
            this.dodajUżytkownikaToolStripMenuItem1.Click += new System.EventHandler(this.dodajUżytkownikaToolStripMenuItem1_Click);
            // 
            // usuńUżytkownikaToolStripMenuItem1
            // 
            this.usuńUżytkownikaToolStripMenuItem1.Name = "usuńUżytkownikaToolStripMenuItem1";
            this.usuńUżytkownikaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.usuńUżytkownikaToolStripMenuItem1.Text = "Usuń użytkownika";
            this.usuńUżytkownikaToolStripMenuItem1.Click += new System.EventHandler(this.usuńUżytkownikaToolStripMenuItem1_Click);
            // 
            // listaUżytkownikówToolStripMenuItem
            // 
            this.listaUżytkownikówToolStripMenuItem.Name = "listaUżytkownikówToolStripMenuItem";
            this.listaUżytkownikówToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaUżytkownikówToolStripMenuItem.Text = "Lista użytkowników";
            this.listaUżytkownikówToolStripMenuItem.Click += new System.EventHandler(this.listaUżytkownikówToolStripMenuItem_Click);
            // 
            // połaczenieToolStripMenuItem
            // 
            this.połaczenieToolStripMenuItem.Name = "połaczenieToolStripMenuItem";
            this.połaczenieToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.połaczenieToolStripMenuItem.Text = "Połaczenie";
            this.połaczenieToolStripMenuItem.Click += new System.EventHandler(this.połaczenieToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(783, 446);
            this.flowLayoutPanel2.TabIndex = 2;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel3.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel3.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel3.Controls.Add(this.tableLayoutPanel4);
            this.flowLayoutPanel3.Controls.Add(this.tableLayoutPanel5);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 41);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(779, 416);
            this.flowLayoutPanel3.TabIndex = 3;
            this.flowLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.06485F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.93515F));
            this.tableLayoutPanel1.Controls.Add(this.label_opis, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.text_opis, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.monthCalendar1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.wybierz_termin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dodaj_link, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.text_link, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.but_dodaj, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.50794F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.49207F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(10, 21);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label_opis
            // 
            this.label_opis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_opis.AutoSize = true;
            this.label_opis.Location = new System.Drawing.Point(3, 0);
            this.label_opis.Name = "label_opis";
            this.label_opis.Size = new System.Drawing.Size(1, 1);
            this.label_opis.TabIndex = 0;
            this.label_opis.Text = "Wpisz opis(wymagane)";
            // 
            // text_opis
            // 
            this.text_opis.Location = new System.Drawing.Point(3, -11);
            this.text_opis.Name = "text_opis";
            this.text_opis.Size = new System.Drawing.Size(1, 1);
            this.text_opis.TabIndex = 1;
            this.text_opis.Text = "";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthCalendar1.Location = new System.Drawing.Point(14, -5);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // wybierz_termin
            // 
            this.wybierz_termin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wybierz_termin.AutoSize = true;
            this.wybierz_termin.Location = new System.Drawing.Point(8, 0);
            this.wybierz_termin.Name = "wybierz_termin";
            this.wybierz_termin.Size = new System.Drawing.Size(1, 1);
            this.wybierz_termin.TabIndex = 3;
            this.wybierz_termin.Text = "Wybierz termin(wymagane)";
            // 
            // dodaj_link
            // 
            this.dodaj_link.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dodaj_link.AutoSize = true;
            this.dodaj_link.Location = new System.Drawing.Point(3, -117);
            this.dodaj_link.Name = "dodaj_link";
            this.dodaj_link.Size = new System.Drawing.Size(1, 13);
            this.dodaj_link.TabIndex = 4;
            this.dodaj_link.Text = "Link(opcjonalnie)";
            // 
            // text_link
            // 
            this.text_link.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_link.Location = new System.Drawing.Point(3, -46);
            this.text_link.Name = "text_link";
            this.text_link.Size = new System.Drawing.Size(1, 20);
            this.text_link.TabIndex = 5;
            // 
            // but_dodaj
            // 
            this.but_dodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but_dodaj.Location = new System.Drawing.Point(8, -57);
            this.but_dodaj.Name = "but_dodaj";
            this.but_dodaj.Size = new System.Drawing.Size(1, 42);
            this.but_dodaj.TabIndex = 6;
            this.but_dodaj.Text = "Dodaj zlecenie";
            this.but_dodaj.UseVisualStyleBackColor = true;
            this.but_dodaj.Click += new System.EventHandler(this.but_dodaj_Click_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label_wez_id, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_wez_kom, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.text_wez_id, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.richText_wez_kom, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.but_wez_zlecenie, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(19, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.929078F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.07092F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(10, 21);
            this.tableLayoutPanel2.TabIndex = 3;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // label_wez_id
            // 
            this.label_wez_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_wez_id.AutoSize = true;
            this.label_wez_id.Location = new System.Drawing.Point(3, 0);
            this.label_wez_id.Name = "label_wez_id";
            this.label_wez_id.Size = new System.Drawing.Size(1, 1);
            this.label_wez_id.TabIndex = 0;
            this.label_wez_id.Text = "ID(wymagane)";
            // 
            // label_wez_kom
            // 
            this.label_wez_kom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_wez_kom.AutoSize = true;
            this.label_wez_kom.Location = new System.Drawing.Point(3, -7);
            this.label_wez_kom.Name = "label_wez_kom";
            this.label_wez_kom.Size = new System.Drawing.Size(1, 1);
            this.label_wez_kom.TabIndex = 1;
            this.label_wez_kom.Text = "Komentarz(opcjonalnie)";
            // 
            // text_wez_id
            // 
            this.text_wez_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_wez_id.Location = new System.Drawing.Point(8, 3);
            this.text_wez_id.Name = "text_wez_id";
            this.text_wez_id.Size = new System.Drawing.Size(1, 20);
            this.text_wez_id.TabIndex = 2;
            // 
            // richText_wez_kom
            // 
            this.richText_wez_kom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richText_wez_kom.Location = new System.Drawing.Point(8, -4);
            this.richText_wez_kom.Name = "richText_wez_kom";
            this.richText_wez_kom.Size = new System.Drawing.Size(1, 1);
            this.richText_wez_kom.TabIndex = 3;
            this.richText_wez_kom.Text = "";
            // 
            // but_wez_zlecenie
            // 
            this.but_wez_zlecenie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but_wez_zlecenie.Location = new System.Drawing.Point(8, -50);
            this.but_wez_zlecenie.Name = "but_wez_zlecenie";
            this.but_wez_zlecenie.Size = new System.Drawing.Size(1, 50);
            this.but_wez_zlecenie.TabIndex = 4;
            this.but_wez_zlecenie.Text = "Weź zlecenie";
            this.but_wez_zlecenie.UseVisualStyleBackColor = true;
            this.but_wez_zlecenie.Click += new System.EventHandler(this.but_wez_zlecenie_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.text_dodajuz_login, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.text_dodajuz_haslo, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.text_dodajuz_email, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.text_dodajuz_typkonta, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBox_dodajuz_login, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox_dodajuz_haslo, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox_dodajuz_email, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel_dodajuz_radio, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.button_dodajuz_dodaj, 0, 4);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(35, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.950249F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.68159F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.19901F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.92537F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.99005F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(10, 21);
            this.tableLayoutPanel3.TabIndex = 4;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // text_dodajuz_login
            // 
            this.text_dodajuz_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_dodajuz_login.AutoSize = true;
            this.text_dodajuz_login.Location = new System.Drawing.Point(3, 0);
            this.text_dodajuz_login.Name = "text_dodajuz_login";
            this.text_dodajuz_login.Size = new System.Drawing.Size(1, 2);
            this.text_dodajuz_login.TabIndex = 0;
            this.text_dodajuz_login.Text = "Login";
            // 
            // text_dodajuz_haslo
            // 
            this.text_dodajuz_haslo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_dodajuz_haslo.AutoSize = true;
            this.text_dodajuz_haslo.Location = new System.Drawing.Point(8, 0);
            this.text_dodajuz_haslo.Name = "text_dodajuz_haslo";
            this.text_dodajuz_haslo.Size = new System.Drawing.Size(1, 2);
            this.text_dodajuz_haslo.TabIndex = 1;
            this.text_dodajuz_haslo.Text = "Hasło";
            // 
            // text_dodajuz_email
            // 
            this.text_dodajuz_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_dodajuz_email.AutoSize = true;
            this.text_dodajuz_email.Location = new System.Drawing.Point(3, 4);
            this.text_dodajuz_email.Name = "text_dodajuz_email";
            this.text_dodajuz_email.Size = new System.Drawing.Size(1, 2);
            this.text_dodajuz_email.TabIndex = 2;
            this.text_dodajuz_email.Text = "E-mail";
            // 
            // text_dodajuz_typkonta
            // 
            this.text_dodajuz_typkonta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_dodajuz_typkonta.AutoSize = true;
            this.text_dodajuz_typkonta.Location = new System.Drawing.Point(8, 4);
            this.text_dodajuz_typkonta.Name = "text_dodajuz_typkonta";
            this.text_dodajuz_typkonta.Size = new System.Drawing.Size(1, 2);
            this.text_dodajuz_typkonta.TabIndex = 3;
            this.text_dodajuz_typkonta.Text = "Typ konta";
            // 
            // textBox_dodajuz_login
            // 
            this.textBox_dodajuz_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_dodajuz_login.Location = new System.Drawing.Point(3, 5);
            this.textBox_dodajuz_login.Name = "textBox_dodajuz_login";
            this.textBox_dodajuz_login.Size = new System.Drawing.Size(1, 20);
            this.textBox_dodajuz_login.TabIndex = 5;
            // 
            // textBox_dodajuz_haslo
            // 
            this.textBox_dodajuz_haslo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_dodajuz_haslo.Location = new System.Drawing.Point(8, 5);
            this.textBox_dodajuz_haslo.Name = "textBox_dodajuz_haslo";
            this.textBox_dodajuz_haslo.Size = new System.Drawing.Size(1, 20);
            this.textBox_dodajuz_haslo.TabIndex = 6;
            this.textBox_dodajuz_haslo.TextChanged += new System.EventHandler(this.textBox_dodajuz_haslo_TextChanged);
            // 
            // textBox_dodajuz_email
            // 
            this.textBox_dodajuz_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_dodajuz_email.Location = new System.Drawing.Point(3, 9);
            this.textBox_dodajuz_email.Name = "textBox_dodajuz_email";
            this.textBox_dodajuz_email.Size = new System.Drawing.Size(1, 20);
            this.textBox_dodajuz_email.TabIndex = 7;
            // 
            // flowLayoutPanel_dodajuz_radio
            // 
            this.flowLayoutPanel_dodajuz_radio.Controls.Add(this.radioButton_dodajuz_typadmin);
            this.flowLayoutPanel_dodajuz_radio.Controls.Add(this.label1);
            this.flowLayoutPanel_dodajuz_radio.Controls.Add(this.radioButton_dodajuz_typserwis);
            this.flowLayoutPanel_dodajuz_radio.Location = new System.Drawing.Point(8, 9);
            this.flowLayoutPanel_dodajuz_radio.Name = "flowLayoutPanel_dodajuz_radio";
            this.flowLayoutPanel_dodajuz_radio.Size = new System.Drawing.Size(1, 1);
            this.flowLayoutPanel_dodajuz_radio.TabIndex = 8;
            // 
            // radioButton_dodajuz_typadmin
            // 
            this.radioButton_dodajuz_typadmin.AutoSize = true;
            this.radioButton_dodajuz_typadmin.Location = new System.Drawing.Point(3, 3);
            this.radioButton_dodajuz_typadmin.Name = "radioButton_dodajuz_typadmin";
            this.radioButton_dodajuz_typadmin.Size = new System.Drawing.Size(85, 17);
            this.radioButton_dodajuz_typadmin.TabIndex = 0;
            this.radioButton_dodajuz_typadmin.TabStop = true;
            this.radioButton_dodajuz_typadmin.Text = "Administrator";
            this.radioButton_dodajuz_typadmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "(Uwaga: posiada wszystkie uprawnienia)";
            // 
            // radioButton_dodajuz_typserwis
            // 
            this.radioButton_dodajuz_typserwis.AutoSize = true;
            this.radioButton_dodajuz_typserwis.Location = new System.Drawing.Point(3, 44);
            this.radioButton_dodajuz_typserwis.Name = "radioButton_dodajuz_typserwis";
            this.radioButton_dodajuz_typserwis.Size = new System.Drawing.Size(71, 17);
            this.radioButton_dodajuz_typserwis.TabIndex = 2;
            this.radioButton_dodajuz_typserwis.TabStop = true;
            this.radioButton_dodajuz_typserwis.Text = "Serwisant";
            this.radioButton_dodajuz_typserwis.UseVisualStyleBackColor = true;
            // 
            // button_dodajuz_dodaj
            // 
            this.button_dodajuz_dodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_dodajuz_dodaj.Location = new System.Drawing.Point(3, 12);
            this.button_dodajuz_dodaj.Name = "button_dodajuz_dodaj";
            this.button_dodajuz_dodaj.Size = new System.Drawing.Size(1, 6);
            this.button_dodajuz_dodaj.TabIndex = 4;
            this.button_dodajuz_dodaj.Text = "Dodaj użytkownika";
            this.button_dodajuz_dodaj.UseVisualStyleBackColor = true;
            this.button_dodajuz_dodaj.Click += new System.EventHandler(this.button_dodajuz_dodaj_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tableLayoutPanel4.Controls.Add(this.label_usunuz_login, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox_usunuz_login, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.button_usunuz_usun, 1, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(51, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(10, 21);
            this.tableLayoutPanel4.TabIndex = 5;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // label_usunuz_login
            // 
            this.label_usunuz_login.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_usunuz_login.AutoSize = true;
            this.label_usunuz_login.Location = new System.Drawing.Point(-110, 0);
            this.label_usunuz_login.Name = "label_usunuz_login";
            this.label_usunuz_login.Size = new System.Drawing.Size(1, 1);
            this.label_usunuz_login.TabIndex = 0;
            this.label_usunuz_login.Text = "Login:";
            // 
            // textBox_usunuz_login
            // 
            this.textBox_usunuz_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_usunuz_login.Location = new System.Drawing.Point(-110, -91);
            this.textBox_usunuz_login.Name = "textBox_usunuz_login";
            this.textBox_usunuz_login.Size = new System.Drawing.Size(1, 20);
            this.textBox_usunuz_login.TabIndex = 1;
            // 
            // button_usunuz_usun
            // 
            this.button_usunuz_usun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_usunuz_usun.Location = new System.Drawing.Point(-110, -150);
            this.button_usunuz_usun.Name = "button_usunuz_usun";
            this.button_usunuz_usun.Size = new System.Drawing.Size(1, 25);
            this.button_usunuz_usun.TabIndex = 2;
            this.button_usunuz_usun.Text = "Usuń";
            this.button_usunuz_usun.UseVisualStyleBackColor = true;
            this.button_usunuz_usun.Click += new System.EventHandler(this.button_usunuz_usun_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.Controls.Add(this.label_przyp_id_klient, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label_przyp_id_zlec, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox_przyp_id_zlec, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.textBox_przyp_id_klient, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.button_przypisz_zlecenie, 1, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(67, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.70075F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.96758F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.91521F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.41646F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(10, 21);
            this.tableLayoutPanel5.TabIndex = 6;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // label_przyp_id_klient
            // 
            this.label_przyp_id_klient.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_przyp_id_klient.AutoSize = true;
            this.label_przyp_id_klient.Location = new System.Drawing.Point(9, 0);
            this.label_przyp_id_klient.Name = "label_przyp_id_klient";
            this.label_przyp_id_klient.Size = new System.Drawing.Size(1, 4);
            this.label_przyp_id_klient.TabIndex = 0;
            this.label_przyp_id_klient.Text = "Id serwisanta";
            // 
            // label_przyp_id_zlec
            // 
            this.label_przyp_id_zlec.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_przyp_id_zlec.AutoSize = true;
            this.label_przyp_id_zlec.Location = new System.Drawing.Point(3, 0);
            this.label_przyp_id_zlec.Name = "label_przyp_id_zlec";
            this.label_przyp_id_zlec.Size = new System.Drawing.Size(1, 4);
            this.label_przyp_id_zlec.TabIndex = 1;
            this.label_przyp_id_zlec.Text = "Id zlecenia";
            // 
            // textBox_przyp_id_zlec
            // 
            this.textBox_przyp_id_zlec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_przyp_id_zlec.Location = new System.Drawing.Point(3, 7);
            this.textBox_przyp_id_zlec.Name = "textBox_przyp_id_zlec";
            this.textBox_przyp_id_zlec.Size = new System.Drawing.Size(1, 20);
            this.textBox_przyp_id_zlec.TabIndex = 2;
            // 
            // textBox_przyp_id_klient
            // 
            this.textBox_przyp_id_klient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_przyp_id_klient.Location = new System.Drawing.Point(9, 7);
            this.textBox_przyp_id_klient.Name = "textBox_przyp_id_klient";
            this.textBox_przyp_id_klient.Size = new System.Drawing.Size(1, 20);
            this.textBox_przyp_id_klient.TabIndex = 3;
            // 
            // button_przypisz_zlecenie
            // 
            this.button_przypisz_zlecenie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_przypisz_zlecenie.Location = new System.Drawing.Point(7, 9);
            this.button_przypisz_zlecenie.Name = "button_przypisz_zlecenie";
            this.button_przypisz_zlecenie.Size = new System.Drawing.Size(1, 1);
            this.button_przypisz_zlecenie.TabIndex = 4;
            this.button_przypisz_zlecenie.Text = "Przypisz";
            this.button_przypisz_zlecenie.UseVisualStyleBackColor = true;
            this.button_przypisz_zlecenie.Click += new System.EventHandler(this.button_przypisz_zlecenie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.flowLayoutPanel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel_dodajuz_radio.ResumeLayout(false);
            this.flowLayoutPanel_dodajuz_radio.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zleceniaToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_opis;
        private System.Windows.Forms.RichTextBox text_opis;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label wybierz_termin;
        private System.Windows.Forms.Label dodaj_link;
        private System.Windows.Forms.TextBox text_link;
        private System.Windows.Forms.Button but_dodaj;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_wez_id;
        private System.Windows.Forms.Label label_wez_kom;
        private System.Windows.Forms.TextBox text_wez_id;
        private System.Windows.Forms.RichTextBox richText_wez_kom;
        private System.Windows.Forms.Button but_wez_zlecenie;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label text_dodajuz_login;
        private System.Windows.Forms.Label text_dodajuz_haslo;
        private System.Windows.Forms.Label text_dodajuz_email;
        private System.Windows.Forms.Label text_dodajuz_typkonta;
        private System.Windows.Forms.Button button_dodajuz_dodaj;
        private System.Windows.Forms.TextBox textBox_dodajuz_login;
        private System.Windows.Forms.TextBox textBox_dodajuz_haslo;
        private System.Windows.Forms.TextBox textBox_dodajuz_email;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_dodajuz_radio;
        private System.Windows.Forms.RadioButton radioButton_dodajuz_typadmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_dodajuz_typserwis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label_usunuz_login;
        private System.Windows.Forms.TextBox textBox_usunuz_login;
        private System.Windows.Forms.Button button_usunuz_usun;
        private System.Windows.Forms.ToolStripMenuItem wszystkieZleceniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mojeZleceniaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem weźZlecenieToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodajZlecenieToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem użytkownikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zalogujSięToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodajUżytkownikaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuńUżytkownikaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem połaczenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujSięToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przypiszZlecenieToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label_przyp_id_klient;
        private System.Windows.Forms.Label label_przyp_id_zlec;
        private System.Windows.Forms.TextBox textBox_przyp_id_zlec;
        private System.Windows.Forms.TextBox textBox_przyp_id_klient;
        private System.Windows.Forms.Button button_przypisz_zlecenie;
        private System.Windows.Forms.ToolStripMenuItem listaUżytkownikówToolStripMenuItem;
    }
}

