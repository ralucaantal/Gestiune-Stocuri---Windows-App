using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Aceasta aplicatie se ocupa de gestiunea stocului unui depozit de parfumuri. Fiecare tip de produs are un loc stabilit
//Aveti optiunea de a primi comenzi de marfa, de a pregati comenzi pentru clienti, si de a inregistra produse noi

namespace GestiuneStocuri
{
    public partial class GestiuneStoc : Form
    {
        
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;


        public List<Parfum> ParfumuriDisponibile = new List<Parfum > ();
        public List<LocDepozit>locuriDepozit=new List<LocDepozit> ();

        public GestiuneStoc()
        {
            InitializeComponent();


            LocDepozit l1 = new LocDepozit("AA", 1, 1, false);
            LocDepozit l2 = new LocDepozit("AB", 2, 2, false);
            LocDepozit l3 = new LocDepozit("BB", 3, 3, false);
            LocDepozit l4 = new LocDepozit("BA", 1, 2, false);
            LocDepozit l5 = new LocDepozit("CC", 1, 1, false);
            LocDepozit l6 = new LocDepozit("CA", 2, 1, false);

            locuriDepozit.Add(l1);locuriDepozit.Add (l2);locuriDepozit.Add (l3);locuriDepozit.Add (l4);
            locuriDepozit.Add(l5);locuriDepozit.Add(l6);


            Parfum p1 = new Parfum(1, "Eros", "Versace", 450, 20, locuriDepozit[0]);
            Parfum p2 = new Parfum(2, "Because It's You", "Armani", 550, 40, locuriDepozit[1]);
            Parfum p3 = new Parfum(3, "Sauvage", "Dior", 700, 40, locuriDepozit[2]);
            Parfum p4 = new Parfum(4, "Guilty", "Gucci", 600, 75, locuriDepozit[3]);
            Parfum p5 = new Parfum(5, "Good Girl", "Carolina Herrera", 700, 40, locuriDepozit[2]);
            Parfum p6 = new Parfum(6, "La vie est belle", "Lancome", 600, 100, locuriDepozit[3]);

            ParfumuriDisponibile.Add(p1);ParfumuriDisponibile.Add(p2);ParfumuriDisponibile.Add (p3);ParfumuriDisponibile.Add (p4);
            ParfumuriDisponibile.Add(p5); ParfumuriDisponibile.Add(p6);

            foreach (Parfum p in ParfumuriDisponibile)
            {
                id_cmb1.Items.Add(p.id.ToString());
            }

            ListViewItem itm;
            foreach (Parfum p in ParfumuriDisponibile)
            {
                itm = new ListViewItem(p.id.ToString());
                itm.SubItems.Add(p.Denumire);
                itm.SubItems.Add(p.Brand);
                itm.SubItems.Add(p.Pret.ToString());
                itm.SubItems.Add(p.StocDisponibil.ToString());
                stoc.Items.Add(itm);
            }
            stoc.Refresh();

            //continutul listei e si in baza de date

            con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\40754\Documents\ASE\anul 2, sem 2\PAW\Proiect\GestiuneStocuri\GestiuneStocuri\Database1.mdf; Integrated Security = True");
            con.Open();

        }





        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void bt_receptie_Click(object sender, EventArgs e)
        {
            gb_receptie.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = id_cmb1.SelectedIndex;
            tb_cantitate1.Visible = true;
            cantitate1.Visible = true;
            ok1.Visible = true;
            comanda_tb.Visible = true;
            comanda_btn.Visible = true;
            comanda_label.Visible = true;
        }

        private void tb_cantitate1_TextChanged(object sender, EventArgs e)
        {
            int index = id_cmb1.SelectedIndex;
            int ch = int.Parse(tb_cantitate1.Text);

        }

        private void ok1_Click(object sender, EventArgs e)
        {
            stoc.Refresh();
            int cant = int.Parse(tb_cantitate1.Text); 
            int id = int.Parse(id_cmb1.Text);
            // if (!int.TryParse(tb_cantitate1.Text, out cant)) return;
            ParfumuriDisponibile[id].StocDisponibil = ParfumuriDisponibile[id].StocDisponibil + cant;
            Mess1.AppendText(String.Format("\nAi adaugat in stoc parfumul  {0}  {1}, cu id-ul {2}, la pret {3} lei. Adaugat de {4} ori. " ,ParfumuriDisponibile[id].Brand, ParfumuriDisponibile[id].Denumire,  id, ParfumuriDisponibile[id].Pret, cant));
            Mess1.AppendText(String.Format("\nIl poti adauga langa celelalte produse similare, in sectiunea {0}, numarul {1}, raftul {2}.",ParfumuriDisponibile[id].Loc.Sectiune, ParfumuriDisponibile[id].Loc.Numar, ParfumuriDisponibile[id].Loc.Raft));
            
            stoc.Items.Clear();
            ListViewItem itm;
            foreach (Parfum p in ParfumuriDisponibile)
            {
                itm = new ListViewItem(p.id.ToString());
                itm.SubItems.Add(p.Denumire);
                itm.SubItems.Add(p.Brand);
                itm.SubItems.Add(p.Pret.ToString());
                itm.SubItems.Add(p.StocDisponibil.ToString());
                stoc.Items.Add(itm);
            }
            stoc.Refresh();

            cmd = new SqlCommand("UPDATE PRODUSE SET STOC_DISPONIBIL = STOC_DISPONIBIL + @stoc_d",con);
            cmd.Parameters.AddWithValue("stoc_d", cant );
            cmd.ExecuteNonQuery();
        }

        private void comanda_btn_Click(object sender, EventArgs e)
        {

            stoc.Refresh();
            int cant = int.Parse(comanda_tb.Text), id = int.Parse(id_cmb1.Text);
            if (!int.TryParse(comanda_tb.Text, out cant)) return;
            if (ParfumuriDisponibile[id].StocDisponibil < cant)
            {
                Mess1.AppendText(String.Format("\nNu este destula cantitate din parfumul {0} {1} (id {2}). In stoc este disponibil doar de {3} ori.", ParfumuriDisponibile[id].Brand, ParfumuriDisponibile[id].Denumire, id, ParfumuriDisponibile[id].StocDisponibil));
                return;
            }
            ParfumuriDisponibile[id].StocDisponibil -= cant;
            Mess1.AppendText(String.Format("\nPoti pregati de livrare parfumul  {0}  {1}, cu id-ul {2}, la pret {3} lei. {4} bucati. ", ParfumuriDisponibile[id].Brand, ParfumuriDisponibile[id].Denumire, id, ParfumuriDisponibile[id].Pret, cant));
            Mess1.AppendText(String.Format("\nIl gasesti la sectiunea {0}, numarul {1}, raftul {2}.", ParfumuriDisponibile[id].Loc.Sectiune, ParfumuriDisponibile[id].Loc.Numar, ParfumuriDisponibile[id].Loc.Raft));
            stoc.Items.Clear();
            ListViewItem itm;
            foreach (Parfum p in ParfumuriDisponibile)
            {
                itm = new ListViewItem(p.id.ToString());
                itm.SubItems.Add(p.Denumire);
                itm.SubItems.Add(p.Brand);
                itm.SubItems.Add(p.Pret.ToString());
                itm.SubItems.Add(p.StocDisponibil.ToString());
                stoc.Items.Add(itm);
            }
            stoc.Refresh();

            cmd = new SqlCommand("UPDATE PRODUSE SET STOC_DISPONIBIL = STOC_DISPONIBIL - @stoc_d", con);
            cmd.Parameters.AddWithValue("stoc_d", cant);
            cmd.ExecuteNonQuery();
        }

        private void bt_inrg_Click(object sender, EventArgs e)
        {
            gb_inrg.Visible = true;
        }

        private void ok3_Click(object sender, EventArgs e)
        {
            


            Parfum p = new Parfum();
            p.id = int.Parse(id3.Text);
            p.Denumire = den.Text.ToString();
            p.Brand= brand.Text.ToString();
            p.Pret = int.Parse(pret2.Text);
            Mess1.AppendText(String.Format("\nFelicitari! Ai inregistrat cu succes parfumul cu id-ul {0}, denumire {1}, brand {2}, pret {3}.", p.id, p.Denumire, p.Brand, p.Pret));

            cmd = new SqlCommand("INSERT INTO PRODUSE (id, denumire, brand, pret, stoc_disponibil, loc_depozit) VALUES (@id,'@denumire', '@brand', @pret,@stoc_disponibil,@loc_depozit)", con);
            cmd.Parameters.Add("@id", p.id);
            cmd.Parameters.Add("@denumire", p.Denumire);
            cmd.Parameters.Add("@brand", p.Brand);

            cmd.Parameters.Add("@pret", p.Pret);
            cmd.Parameters.Add("@stoc_disponibil", p.StocDisponibil);
            cmd.Parameters.Add("@loc_depozit", p.Loc.ToString());

            cmd.ExecuteNonQuery();

            ParfumuriDisponibile.Add(p);
            id_cmb1.Items.Add(id3.Text);
            bt_locDisp.Visible = true;
            stoc.Items.Clear();
            ListViewItem itm;
            foreach (Parfum parf in ParfumuriDisponibile)
            {
                itm = new ListViewItem(parf.id.ToString());
                itm.SubItems.Add(parf.Denumire);
                itm.SubItems.Add(parf.Brand);
                itm.SubItems.Add(parf.Pret.ToString());
                itm.SubItems.Add(parf.StocDisponibil.ToString());
                stoc.Items.Add(itm);
            }
            stoc.Refresh();

            
        }

        private void bt_locDisp_Click(object sender, EventArgs e)
        {
            mess2.Visible = true;
            foreach(LocDepozit  l in locuriDepozit)
            {
                if(l.Ocupat==false)
                {
                    mess2.AppendText(String.Format("\nLocul din sectiunea {0}, numarul {1}, raftul {2} este liber.", l.Sectiune, l.Numar, l.Raft));
                }
            }
        }

        private void statisticiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 desen = new Form2();
            int[] vectContor = new int[10];

            foreach(Parfum p in ParfumuriDisponibile)
            {
                int poz = p.StocDisponibil/10;
                if (p.StocDisponibil/10 == 10)
                {
                    poz = 9;
                }
                vectContor[poz]++;
            }

            
            desen.stocuri = vectContor;

            for (int j = 0; j < 10; j++)
            {
                Mess1.Text += desen.stocuri[j];
            }

            for (int i = 0; i < 10; i++)
            {

                
                Mess1.Text += $"\r\n{i} cu stocul: {vectContor[i]*10}";

            }

            desen.ShowDialog();
        }

        private void printareStocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("Lista parfumurilor disponibile: \n", new Font("Times New Roman", 25), Brushes.Black, 10, 10);
            int linia = 1;
            foreach (Parfum p in ParfumuriDisponibile)
            {
                g.DrawString($"\r\n{p} ", new Font("Times New Roman", 17), Brushes.Black, 10, 10 + linia * 22);
                linia++;

            }
        }
    }

    [Serializable]
    public class Parfum 
    {
        public int id { get; set; }

        private string denumire;
        public string Denumire { get { return denumire; } set { denumire = value; } }

        public string Brand { get; set; }
        public int Pret { get; set; }
        public int StocDisponibil { get; set; }

        public LocDepozit Loc;

        public Parfum(int i, string den, string b, int p, int s, LocDepozit l)
        {
            this.id = i; this.denumire = den; this.Brand = b; this.Pret = p;
            this.StocDisponibil = s; this.Loc = l;
        }

        public Parfum()
        {
            this.id = 0;this.denumire = "N/A";this.Brand = "N/A";this.Pret = 0;
            this.StocDisponibil = 0; this.Loc = null;
        }

        public override string ToString()
        {
            
            return $"{id}: {Denumire} {Brand} {Pret} {StocDisponibil} se gaseste in depozit la {Loc}";
        }
    }

}

public class LocDepozit
{
    public string Sectiune { get; set; }
    public int Numar { get; set; }
    public int Raft { get; set; }

    public bool Ocupat { get; set; }

    public LocDepozit(string s, int nr, int r, bool b)
    {
        this.Sectiune = s;
        this.Numar = nr;
        this.Raft = r;
        this.Ocupat = b;
    }

    public override string ToString()
    {
        int i = 0;
        if(this.Ocupat==true)
        {
            i = 1;
        }
        return $"{Sectiune}: {Numar} {Raft} {i}";
    }

}
