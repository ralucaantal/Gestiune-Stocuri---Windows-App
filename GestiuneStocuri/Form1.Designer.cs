namespace GestiuneStocuri
{
    partial class GestiuneStoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestiuneStoc));
            this.title = new System.Windows.Forms.Label();
            this.bt_receptie = new System.Windows.Forms.Button();
            this.gb_receptie = new System.Windows.Forms.GroupBox();
            this.comanda_btn = new System.Windows.Forms.Button();
            this.comanda_tb = new System.Windows.Forms.TextBox();
            this.comanda_label = new System.Windows.Forms.Label();
            this.ok1 = new System.Windows.Forms.Button();
            this.cantitate1 = new System.Windows.Forms.Label();
            this.tb_cantitate1 = new System.Windows.Forms.TextBox();
            this.id_l = new System.Windows.Forms.Label();
            this.id_cmb1 = new System.Windows.Forms.ComboBox();
            this.Mess1 = new System.Windows.Forms.RichTextBox();
            this.bt_inrg = new System.Windows.Forms.Button();
            this.gb_inrg = new System.Windows.Forms.GroupBox();
            this.mess2 = new System.Windows.Forms.RichTextBox();
            this.bt_locDisp = new System.Windows.Forms.Button();
            this.ok3 = new System.Windows.Forms.Button();
            this.pret1 = new System.Windows.Forms.Label();
            this.brand1 = new System.Windows.Forms.Label();
            this.den1 = new System.Windows.Forms.Label();
            this.id2 = new System.Windows.Forms.Label();
            this.pret2 = new System.Windows.Forms.TextBox();
            this.brand = new System.Windows.Forms.TextBox();
            this.den = new System.Windows.Forms.TextBox();
            this.id3 = new System.Windows.Forms.TextBox();
            this.stoc = new System.Windows.Forms.ListView();
            this.id_parfum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.den_parfum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brand_parfum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pret_parfum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stoc_parfum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paginaDePornireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depozitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printareStocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parfumuriIndisponibileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.gb_receptie.SuspendLayout();
            this.gb_inrg.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.Window;
            this.title.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 42);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(381, 26);
            this.title.TabIndex = 0;
            this.title.Text = "Gestiune stoc - Depozit parfumuri nr. 1";
            // 
            // bt_receptie
            // 
            this.bt_receptie.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_receptie.Location = new System.Drawing.Point(25, 91);
            this.bt_receptie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_receptie.Name = "bt_receptie";
            this.bt_receptie.Size = new System.Drawing.Size(200, 75);
            this.bt_receptie.TabIndex = 1;
            this.bt_receptie.Text = "Primire si procesare comenzi";
            this.bt_receptie.UseVisualStyleBackColor = true;
            this.bt_receptie.Click += new System.EventHandler(this.bt_receptie_Click);
            // 
            // gb_receptie
            // 
            this.gb_receptie.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gb_receptie.Controls.Add(this.comanda_btn);
            this.gb_receptie.Controls.Add(this.comanda_tb);
            this.gb_receptie.Controls.Add(this.comanda_label);
            this.gb_receptie.Controls.Add(this.ok1);
            this.gb_receptie.Controls.Add(this.cantitate1);
            this.gb_receptie.Controls.Add(this.tb_cantitate1);
            this.gb_receptie.Controls.Add(this.id_l);
            this.gb_receptie.Controls.Add(this.id_cmb1);
            this.gb_receptie.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_receptie.Location = new System.Drawing.Point(260, 79);
            this.gb_receptie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_receptie.Name = "gb_receptie";
            this.gb_receptie.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_receptie.Size = new System.Drawing.Size(512, 145);
            this.gb_receptie.TabIndex = 2;
            this.gb_receptie.TabStop = false;
            this.gb_receptie.Text = "Primire/Procesare comenzi";
            this.gb_receptie.Visible = false;
            // 
            // comanda_btn
            // 
            this.comanda_btn.Location = new System.Drawing.Point(253, 92);
            this.comanda_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comanda_btn.Name = "comanda_btn";
            this.comanda_btn.Size = new System.Drawing.Size(168, 26);
            this.comanda_btn.TabIndex = 7;
            this.comanda_btn.Text = "Ok!";
            this.comanda_btn.UseVisualStyleBackColor = true;
            this.comanda_btn.Visible = false;
            this.comanda_btn.Click += new System.EventHandler(this.comanda_btn_Click);
            // 
            // comanda_tb
            // 
            this.comanda_tb.Location = new System.Drawing.Point(84, 94);
            this.comanda_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comanda_tb.Name = "comanda_tb";
            this.comanda_tb.Size = new System.Drawing.Size(127, 22);
            this.comanda_tb.TabIndex = 6;
            this.comanda_tb.Visible = false;
            // 
            // comanda_label
            // 
            this.comanda_label.AutoSize = true;
            this.comanda_label.Location = new System.Drawing.Point(90, 73);
            this.comanda_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comanda_label.Name = "comanda_label";
            this.comanda_label.Size = new System.Drawing.Size(106, 15);
            this.comanda_label.TabIndex = 5;
            this.comanda_label.Text = "Pregatire de livrare";
            this.comanda_label.Visible = false;
            // 
            // ok1
            // 
            this.ok1.Location = new System.Drawing.Point(253, 47);
            this.ok1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ok1.Name = "ok1";
            this.ok1.Size = new System.Drawing.Size(168, 26);
            this.ok1.TabIndex = 4;
            this.ok1.Text = "Ok!";
            this.ok1.UseVisualStyleBackColor = true;
            this.ok1.Visible = false;
            this.ok1.Click += new System.EventHandler(this.ok1_Click);
            // 
            // cantitate1
            // 
            this.cantitate1.AutoSize = true;
            this.cantitate1.Location = new System.Drawing.Point(109, 30);
            this.cantitate1.Name = "cantitate1";
            this.cantitate1.Size = new System.Drawing.Size(94, 15);
            this.cantitate1.TabIndex = 3;
            this.cantitate1.Text = "Cantitate primită";
            this.cantitate1.Visible = false;
            // 
            // tb_cantitate1
            // 
            this.tb_cantitate1.Location = new System.Drawing.Point(84, 48);
            this.tb_cantitate1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_cantitate1.Name = "tb_cantitate1";
            this.tb_cantitate1.Size = new System.Drawing.Size(127, 22);
            this.tb_cantitate1.TabIndex = 2;
            this.tb_cantitate1.Visible = false;
            this.tb_cantitate1.TextChanged += new System.EventHandler(this.tb_cantitate1_TextChanged);
            // 
            // id_l
            // 
            this.id_l.AutoSize = true;
            this.id_l.Location = new System.Drawing.Point(44, 47);
            this.id_l.Name = "id_l";
            this.id_l.Size = new System.Drawing.Size(18, 15);
            this.id_l.TabIndex = 1;
            this.id_l.Text = "Id";
            // 
            // id_cmb1
            // 
            this.id_cmb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_cmb1.FormattingEnabled = true;
            this.id_cmb1.Location = new System.Drawing.Point(21, 65);
            this.id_cmb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_cmb1.Name = "id_cmb1";
            this.id_cmb1.Size = new System.Drawing.Size(43, 23);
            this.id_cmb1.TabIndex = 0;
            this.id_cmb1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Mess1
            // 
            this.Mess1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Mess1.Location = new System.Drawing.Point(31, 449);
            this.Mess1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mess1.Name = "Mess1";
            this.Mess1.Size = new System.Drawing.Size(1107, 185);
            this.Mess1.TabIndex = 3;
            this.Mess1.Text = "";
            // 
            // bt_inrg
            // 
            this.bt_inrg.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_inrg.Location = new System.Drawing.Point(31, 313);
            this.bt_inrg.Name = "bt_inrg";
            this.bt_inrg.Size = new System.Drawing.Size(193, 78);
            this.bt_inrg.TabIndex = 5;
            this.bt_inrg.Text = "Înregistrare produs nou";
            this.bt_inrg.UseVisualStyleBackColor = true;
            this.bt_inrg.Click += new System.EventHandler(this.bt_inrg_Click);
            // 
            // gb_inrg
            // 
            this.gb_inrg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gb_inrg.Controls.Add(this.mess2);
            this.gb_inrg.Controls.Add(this.bt_locDisp);
            this.gb_inrg.Controls.Add(this.ok3);
            this.gb_inrg.Controls.Add(this.pret1);
            this.gb_inrg.Controls.Add(this.brand1);
            this.gb_inrg.Controls.Add(this.den1);
            this.gb_inrg.Controls.Add(this.id2);
            this.gb_inrg.Controls.Add(this.pret2);
            this.gb_inrg.Controls.Add(this.brand);
            this.gb_inrg.Controls.Add(this.den);
            this.gb_inrg.Controls.Add(this.id3);
            this.gb_inrg.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_inrg.Location = new System.Drawing.Point(260, 279);
            this.gb_inrg.Name = "gb_inrg";
            this.gb_inrg.Size = new System.Drawing.Size(512, 142);
            this.gb_inrg.TabIndex = 6;
            this.gb_inrg.TabStop = false;
            this.gb_inrg.Text = "Înregistrare produs nou";
            this.gb_inrg.Visible = false;
            // 
            // mess2
            // 
            this.mess2.Location = new System.Drawing.Point(247, 94);
            this.mess2.Name = "mess2";
            this.mess2.Size = new System.Drawing.Size(227, 30);
            this.mess2.TabIndex = 9;
            this.mess2.Text = "";
            this.mess2.Visible = false;
            // 
            // bt_locDisp
            // 
            this.bt_locDisp.Location = new System.Drawing.Point(28, 94);
            this.bt_locDisp.Name = "bt_locDisp";
            this.bt_locDisp.Size = new System.Drawing.Size(183, 31);
            this.bt_locDisp.TabIndex = 8;
            this.bt_locDisp.Text = "Vizualizare locuri disponibile";
            this.bt_locDisp.UseVisualStyleBackColor = true;
            this.bt_locDisp.Visible = false;
            this.bt_locDisp.Click += new System.EventHandler(this.bt_locDisp_Click);
            // 
            // ok3
            // 
            this.ok3.Location = new System.Drawing.Point(375, 42);
            this.ok3.Name = "ok3";
            this.ok3.Size = new System.Drawing.Size(99, 23);
            this.ok3.TabIndex = 7;
            this.ok3.Text = "Ok!";
            this.ok3.UseVisualStyleBackColor = true;
            this.ok3.Click += new System.EventHandler(this.ok3_Click);
            // 
            // pret1
            // 
            this.pret1.AutoSize = true;
            this.pret1.Location = new System.Drawing.Point(324, 24);
            this.pret1.Name = "pret1";
            this.pret1.Size = new System.Drawing.Size(28, 15);
            this.pret1.TabIndex = 7;
            this.pret1.Text = "Pret";
            // 
            // brand1
            // 
            this.brand1.AutoSize = true;
            this.brand1.Location = new System.Drawing.Point(250, 24);
            this.brand1.Name = "brand1";
            this.brand1.Size = new System.Drawing.Size(39, 15);
            this.brand1.TabIndex = 6;
            this.brand1.Text = "Brand";
            // 
            // den1
            // 
            this.den1.AutoSize = true;
            this.den1.Location = new System.Drawing.Point(118, 24);
            this.den1.Name = "den1";
            this.den1.Size = new System.Drawing.Size(58, 15);
            this.den1.TabIndex = 5;
            this.den1.Text = "Denumire";
            // 
            // id2
            // 
            this.id2.AutoSize = true;
            this.id2.Location = new System.Drawing.Point(43, 24);
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(18, 15);
            this.id2.TabIndex = 4;
            this.id2.Text = "Id";
            // 
            // pret2
            // 
            this.pret2.Location = new System.Drawing.Point(308, 42);
            this.pret2.Name = "pret2";
            this.pret2.Size = new System.Drawing.Size(44, 22);
            this.pret2.TabIndex = 3;
            // 
            // brand
            // 
            this.brand.Location = new System.Drawing.Point(191, 42);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(98, 22);
            this.brand.TabIndex = 2;
            // 
            // den
            // 
            this.den.Location = new System.Drawing.Point(84, 42);
            this.den.Name = "den";
            this.den.Size = new System.Drawing.Size(92, 22);
            this.den.TabIndex = 1;
            // 
            // id3
            // 
            this.id3.Location = new System.Drawing.Point(15, 42);
            this.id3.Name = "id3";
            this.id3.Size = new System.Drawing.Size(46, 22);
            this.id3.TabIndex = 0;
            // 
            // stoc
            // 
            this.stoc.BackColor = System.Drawing.Color.RosyBrown;
            this.stoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_parfum,
            this.den_parfum,
            this.brand_parfum,
            this.pret_parfum,
            this.stoc_parfum});
            this.stoc.HideSelection = false;
            this.stoc.Location = new System.Drawing.Point(802, 79);
            this.stoc.Name = "stoc";
            this.stoc.Size = new System.Drawing.Size(336, 342);
            this.stoc.TabIndex = 7;
            this.stoc.UseCompatibleStateImageBehavior = false;
            this.stoc.View = System.Windows.Forms.View.Details;
            // 
            // id_parfum
            // 
            this.id_parfum.Text = "Id";
            this.id_parfum.Width = 30;
            // 
            // den_parfum
            // 
            this.den_parfum.Text = "Denumire";
            this.den_parfum.Width = 70;
            // 
            // brand_parfum
            // 
            this.brand_parfum.Text = "Brand";
            this.brand_parfum.Width = 50;
            // 
            // pret_parfum
            // 
            this.pret_parfum.Text = "Pret";
            this.pret_parfum.Width = 30;
            // 
            // stoc_parfum
            // 
            this.stoc_parfum.Text = "Stoc disponibil";
            this.stoc_parfum.Width = 50;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaDePornireToolStripMenuItem,
            this.depozitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1168, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paginaDePornireToolStripMenuItem
            // 
            this.paginaDePornireToolStripMenuItem.Name = "paginaDePornireToolStripMenuItem";
            this.paginaDePornireToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.paginaDePornireToolStripMenuItem.Text = "Pagina de pornire";
            // 
            // depozitToolStripMenuItem
            // 
            this.depozitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticiToolStripMenuItem,
            this.printareStocToolStripMenuItem,
            this.parfumuriIndisponibileToolStripMenuItem});
            this.depozitToolStripMenuItem.Name = "depozitToolStripMenuItem";
            this.depozitToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.depozitToolStripMenuItem.Text = "Depozit";
            // 
            // statisticiToolStripMenuItem
            // 
            this.statisticiToolStripMenuItem.Name = "statisticiToolStripMenuItem";
            this.statisticiToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.statisticiToolStripMenuItem.Text = "Statistica stoc";
            this.statisticiToolStripMenuItem.Click += new System.EventHandler(this.statisticiToolStripMenuItem_Click);
            // 
            // printareStocToolStripMenuItem
            // 
            this.printareStocToolStripMenuItem.Name = "printareStocToolStripMenuItem";
            this.printareStocToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.printareStocToolStripMenuItem.Text = "Parfumuri disponibile in  stoc";
            this.printareStocToolStripMenuItem.Click += new System.EventHandler(this.printareStocToolStripMenuItem_Click);
            // 
            // parfumuriIndisponibileToolStripMenuItem
            // 
            this.parfumuriIndisponibileToolStripMenuItem.Name = "parfumuriIndisponibileToolStripMenuItem";
            this.parfumuriIndisponibileToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.parfumuriIndisponibileToolStripMenuItem.Text = "Parfumuri indisponibile";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // GestiuneStoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1168, 660);
            this.Controls.Add(this.stoc);
            this.Controls.Add(this.gb_inrg);
            this.Controls.Add(this.bt_inrg);
            this.Controls.Add(this.Mess1);
            this.Controls.Add(this.gb_receptie);
            this.Controls.Add(this.bt_receptie);
            this.Controls.Add(this.title);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GestiuneStoc";
            this.Text = "GestiuneStoc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_receptie.ResumeLayout(false);
            this.gb_receptie.PerformLayout();
            this.gb_inrg.ResumeLayout(false);
            this.gb_inrg.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button bt_receptie;
        private System.Windows.Forms.GroupBox gb_receptie;
        private System.Windows.Forms.Label id_l;
        private System.Windows.Forms.ComboBox id_cmb1;
        private System.Windows.Forms.RichTextBox Mess1;
        private System.Windows.Forms.TextBox tb_cantitate1;
        private System.Windows.Forms.Label cantitate1;
        private System.Windows.Forms.Button ok1;
        private System.Windows.Forms.Button comanda_btn;
        private System.Windows.Forms.TextBox comanda_tb;
        private System.Windows.Forms.Label comanda_label;
        private System.Windows.Forms.Button bt_inrg;
        private System.Windows.Forms.GroupBox gb_inrg;
        private System.Windows.Forms.TextBox pret2;
        private System.Windows.Forms.TextBox brand;
        private System.Windows.Forms.TextBox den;
        private System.Windows.Forms.TextBox id3;
        private System.Windows.Forms.Button ok3;
        private System.Windows.Forms.Label pret1;
        private System.Windows.Forms.Label brand1;
        private System.Windows.Forms.Label den1;
        private System.Windows.Forms.Label id2;
        private System.Windows.Forms.Button bt_locDisp;
        private System.Windows.Forms.RichTextBox mess2;
        private System.Windows.Forms.ListView stoc;
        private System.Windows.Forms.ColumnHeader id_parfum;
        private System.Windows.Forms.ColumnHeader den_parfum;
        private System.Windows.Forms.ColumnHeader brand_parfum;
        private System.Windows.Forms.ColumnHeader pret_parfum;
        private System.Windows.Forms.ColumnHeader stoc_parfum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paginaDePornireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depozitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printareStocToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem parfumuriIndisponibileToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
    }
}

