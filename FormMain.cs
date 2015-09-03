using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using Memory.Properties;


namespace Memory
{
    public partial class frm_Memory : Form
    {

        //private string[,] austria = new string[1, 2] { { "Austria", "..\\..\\Resources\\Austria.png" } };
        //private string[,] belgium = new string[1, 2] { { "Belgium", "..\\..\\Resources\\Belgium.png" } };
        //private string[,] czech = new string[1, 2] { { "Czech Republic", "..\\..\\Resources\\CzechRepublic.png" } };
        //private string[,] denmark = new string[1, 2] { { "Denmark", "..\\..\\Resources\\Denmark.png" } };

        //private string[,] france = new string[1, 2] { { "France", "..\\..\\Resources\\France.png" } };
        //private string[,] germany = new string[1, 2] { { "Germany", "..\\..\\Resources\\Germany.png" } };
        //private string[,] iceland = new string[1, 2] { { "Iceland", "..\\..\\Resources\\Iceland.png" } };
        //private string[,] ireland = new string[1, 2] { { "Ireland", "..\\..\\Resources\\Ireland.png" } };

        //private string[,] luxembourg = new string[1, 2] { { "Luxembourg", "..\\..\\Resources\\Luxembourg.png" } };
        //private string[,] netherlands = new string[1, 2] { { "Netherlands", "..\\..\\Resources\\Netherlands.png" } };
        //private string[,] norway = new string[1, 2] { { "Norway", "..\\..\\Resources\\Norway.png" } };
        //private string[,] portugal = new string[1, 2] { { "Portugal", "..\\..\\Resources\\Portugal.png" } };

        //private string[,] spain = new string[1, 2] { { "Spain", "..\\..\\Resources\\Spain.png" } };
        //private string[,] sweden = new string[1, 2] { { "Sweden", "..\\..\\Resources\\Sweden.png" } };
        //private string[,] switzerland = new string[1, 2] { { "Switzerland", "..\\..\\Resources\\Switzerland.png" } };
        //private string[,] uk = new string[1, 2] { { "United Kingdom", "..\\..\\Resources\\UK.png" } };

        private string select;
        //private string pathbg = "..\\..\\Resources\\background.jpg";

        private List<string> quest = new List<string>();
        private List<PictureBox> picboxes = new List<PictureBox>();
        private List<Bitmap> flaggen = new List<Bitmap>();

        private bool flip = true;
        private bool flop = true;
        private bool flap = true;

        private int right_move = 0;
        private int i = 0;
        private int move_counter = 0;
        private int wrong_move = 0;
        private int bla = 1;
        private int iff = 0;

        private PictureBox temp;
        private PictureBox current;
        private PictureBox picBox;

        private Color colour;

        


        //On Load
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        
        //onPAINT um die Pictureboxen beim Start mit Bildern oder Text zu versehen
        protected override void OnPaint(PaintEventArgs e)
        {
            if (bla == 1){
                ProcessDirectory();
                bla++;
            }
        }        

        public frm_Memory()
        {
            InitializeComponent();
        }
       

        //btn_QUIT zum beenden des Programms
        private void btn_quit_main_onClick(object sender, EventArgs e)
        {
            this.Close();
        }



        //btn_START um ein neues Spiel anzufangen
        private void btn_start_Click(object sender, EventArgs e)
        {
            ProcessDirectory();
        }


        //Die Pictureboxen werden in eine Liste gefüllt, und die Daten zu den Bildern werden in eine Liste gefüllt
        //Hier werden die Pictureboxen mit Text oder Bildern versehen
        public void ProcessDirectory()
        {
            btn_start.Enabled = false;


            foreach (Bitmap picture in Resources_Flags)
            {

            }

            //ResourceSet rs = new ResourceSet("items.resources");


            //// Create an IDictionaryEnumerator to read the data in the ResourceSet.
            //IDictionaryEnumerator id = rs.GetEnumerator();

            //// Iterate through the ResourceSet and display the contents to the console.  
            //while (id.MoveNext())
            //    MessageBox.Show("\n[{0}] \t{1}" + id.Key + "\n\n" + id.Value);

            //rs.Close();



            //Assembly assem = this.GetType().Assembly;
            //foreach (string resourceName in assem.GetManifestResourceNames())
            //{
            //    MessageBox.Show(resourceName);
            //}



            //ResXResourceReader rsxr = new ResXResourceReader("..\\..\\Properties\\Resources.resx"); // or whatever it's called
            //string msg = "";
            //foreach (DictionaryEntry de in rsxr)
            //{
            //    msg += de.Key.ToString() + " : " + de.Value.ToString() + "\r\n";
            //}
            //rsxr.Close();
            //MessageBox.Show(msg);



            //Flaggen in Liste

            //flaggen.Add(austria);
            //flaggen.Add(belgium);
            //flaggen.Add(czech);
            //flaggen.Add(denmark);

            //flaggen.Add(france);
            //flaggen.Add(germany);
            //flaggen.Add(iceland);
            //flaggen.Add(ireland);

            //flaggen.Add(luxembourg);
            //flaggen.Add(netherlands);
            //flaggen.Add(norway);
            //flaggen.Add(portugal);

            //flaggen.Add(spain);
            //flaggen.Add(sweden);
            //flaggen.Add(switzerland);
            //flaggen.Add(uk);


            // Pictureboxes in Liste

            picboxes.Add(picBox_00);
            picboxes.Add(picBox_01);
            picboxes.Add(picBox_02);
            picboxes.Add(picBox_03);

            picboxes.Add(picBox_10);
            picboxes.Add(picBox_11);
            picboxes.Add(picBox_12);
            picboxes.Add(picBox_13);

            picboxes.Add(picBox_20);
            picboxes.Add(picBox_21);
            picboxes.Add(picBox_22);
            picboxes.Add(picBox_23);

            picboxes.Add(picBox_30);
            picboxes.Add(picBox_31);
            picboxes.Add(picBox_32);
            picboxes.Add(picBox_33);

            MemoryHelp.Shuffle(flaggen);
            MemoryHelp.Shuffle(picboxes);

            // loop über fileEntries as pfad
            // Erstellung von Dict
            //  -> Key Picturebox[i]
            //  -> Value pfad



            i = 0;
            foreach (PictureBox box in picboxes)
            {
                box.Enabled = true;
                string[,] local = (string[,])flaggen[i];

                //Bild wird eingefügt
                if (flip == true)
                {
                    MemoryHelp.ProcessFile(box, local[0, 1]);
                    box.Tag = local[0, 0];
                    flip = false;
                }

                //Text wird eingefügt
                else
                {
                    box.Image = null;

                    box.Refresh();

                    //e.Graphics.DrawString(local[0, 0], new Font("Arial", 20), Brushes.Black, new Point(1, 100));
                    paint(local[0, 0], box);                    

                    box.Tag = local[0, 0];

                    flip = true;
                    i++;
                }
            }
        }

        //Text wird auf die Pictureboxen gezeichnet
        private void paint(string text, PictureBox box)
        {
            Rectangle rect1 = new Rectangle(0,0,200,200);

            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;


            System.Drawing.Graphics g = box.CreateGraphics();
            g.DrawString(text, new Font("Arial", 20), Brushes.Black, rect1, format);                

        }

        //Die ausgewählten Pictureboxen werden in einer bestimmten Farbe angemalt
        private void frm_paint(Color colour, PictureBox PicBoxOne, PictureBox PicBoxTwo)
        {
            PicBoxOne.BackColor = colour;
            PicBoxTwo.BackColor = colour;
            repaint(PicBoxOne);
            repaint(PicBoxTwo);
        }

        //picBox_XX_onCLICK Was passiert wenn man auf eine Picturebox klickt
        private void picBox_XX_onClick(object sender, EventArgs e)
        {
            picBox = (PictureBox)sender;
            //MessageBox.Show(picBox.Tag+"\n***\n"+lbl_quest.Text);
            
            
            //Speichern der Bilderdaten bei nem ungeraden Klick
            if (flop == true){

                current = (PictureBox)picBox;
                select = picBox.Tag.ToString();
                flop = false;
                temp = picBox;


                picBox.BorderStyle = BorderStyle.Fixed3D;
                repaint(picBox);
                
            }

            //Überprüfung der Daten der 2 ausgewählten Pictureboxen
            else{
                foreach (PictureBox box in picboxes){
                    box.Enabled = false;
                    repaint(box);
                }

                //Wenn richtig Pictureboxen Grün anmalen und Timer starten
                if (picBox.Tag.Equals(select) && picBox.Name != current.Name)
                {
                    colour = Color.PaleGreen;
                    frm_paint(colour, picBox, temp);
                    tmr_colour.Enabled = true;
                    tmr_colour.Start();
                    //MessageBox.Show("RICHTIG");

                    right_move++;
                    txtBox_right.Text = right_move.ToString();
                }

                //Wenn falsch Pictureboxen Rot anmalen und Timer starten
                else
                {
                    colour = Color.IndianRed;
                    frm_paint(colour, picBox, temp);
                    tmr_colour.Enabled = true;
                    tmr_colour.Start();
                    //MessageBox.Show("FALSCH");
                    select = "";
                    wrong_move++;
                }

                move_counter++;
                txtBox_Turns.Text = move_counter.ToString();
                flop = true;
                temp.BorderStyle = BorderStyle.None;
                repaint(temp);

                //Wenn das Spiel vorbei ist
                if (right_move == 8)
                {
                    MessageBox.Show("Du hast es geschafft!\n\nDu hast nur " + move_counter + " Züge gebraucht!\n\nDu hast " + wrong_move + " Fehler gemacht.");
                    
                    //Verschiedene Zählvariablen werden auf 0 gesetzt
                    btn_start.Enabled = true;
                    move_counter = 0;
                    txtBox_Turns.Text = move_counter.ToString();
                    right_move = 0;
                    txtBox_right.Text = right_move.ToString();
                    wrong_move = 0;
                    //this.Close();

                    //verschiedene Eingenschaften aller Pictureboxen werden auf 0 gesetzt
                    foreach (PictureBox box in picboxes)
                    {
                        box.Visible = true;
                        box.Tag = null;
                        box.BackColor = Color.LightGray;
                        box.Image = Resources_bg.background;
                        box.Enabled = false;
                    }
                    //Hier wird der Inhalt der Listen gelöscht
                    picboxes.Clear();
                    flaggen.Clear();
                }
            }
        }

        //Wenn der Timer einen Intervall gemacht hat
        private void tmr_colour_Tick(object sender, EventArgs e)
        {
            //Sorgt dafür dass die Pictureboxen blinken
            if (iff <= 4)
            {
                iff++;
                
                if (flap == true)
                {
                    frm_paint(colour, picBox, temp);
                    flap = false;
                }
                else
                {
                    frm_paint(Color.LightGray, picBox, temp);
                    flap = true;
                }
            }

            //Wenn die Pictureboxen fertig geblinkt haben werden sie auf die Standardfarbe zurückgesetzt
            else
            {
                tmr_colour.Stop();
                tmr_colour.Enabled = false;
                

                //Wenn die richtig gelöst wurde, verschwinden die Pictureboxen
                if (picBox.Tag.Equals(select) && picBox.Name != current.Name)
                {
                    select = "";
                    picBox.Image = null;
                    picBox.Enabled = false;
                    picBox.Visible = false;
                    temp.Image = null;
                    temp.Enabled = false;
                    temp.Visible = false;
                }

                foreach (PictureBox box in picboxes)
                {
                    box.Enabled = true;
                    repaint(box);
                }

                frm_paint(Color.LightGray, picBox, temp);
                repaint(picBox);
                repaint(temp);

                iff = 0;
            }
        }

        
        //Der Text auf der Picturebox wird nur erneuert, da er verschwindet wenn man etwas an der Picturebox verändert
        private void repaint(PictureBox box)
        {
            if (box.Image == null)
            {
                box.Refresh();
                paint(box.Tag.ToString(), box);
            }            
        }
    }
}