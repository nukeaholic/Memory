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
using System.Globalization;


namespace Memory
{
    public partial class frm_Memory : Form
    {


        private string select;

        private List<KeyValuePair<String, Bitmap>> myDico = new List<KeyValuePair<String, Bitmap>>();

        private List<string> quest = new List<string>();
        private List<PictureBox> picboxes = new List<PictureBox>();

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
            if (bla == 1)
            {
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


            ResourceSet resourceSet = Resources_Flags.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

            

            foreach (DictionaryEntry entry in resourceSet)
            {
                Bitmap image = (Bitmap)entry.Value;
                String name = (String)entry.Key;

                KeyValuePair<String, Bitmap> keyValuePair = new KeyValuePair<String, Bitmap>(name, image);

                myDico.Add(keyValuePair);
            }

            
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

            shuffle.Shuffle(myDico);
            shuffle.Shuffle(picboxes);

            
            i = 0;
            foreach (PictureBox box in picboxes)
            {
                box.Enabled = true;
                box.Image = Resources_bg.background;

                //Bild wird eingefügt
                if (flip == true)
                {
                    box.Image = myDico[i].Value;
                    box.Tag = myDico[i].Key;
                    flip = false;
                }

                //Text wird eingefügt
                else
                {
                    box.Image = null;

                    box.Refresh();

                    //e.Graphics.DrawString(local[0, 0], new Font("Arial", 20), Brushes.Black, new Point(1, 100));
                    paint(myDico[i].Key, box);

                    box.Tag = myDico[i].Key;


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
                    colour = Color.LightGreen;
                    picboxblink(colour);
                    //MessageBox.Show("RICHTIG");

                    right_move++;
                    txtBox_right.Text = right_move.ToString();
                }

                //Wenn falsch Pictureboxen Rot anmalen und Timer starten
                else
                {
                    colour = Color.IndianRed;
                    picboxblink(colour);
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
                    myDico.Clear();
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


        // Die Timer werden aktiviert damit die ausgewählten Pictureboxen in einer Farbe blinken
        private void picboxblink(Color colour)
        {
            frm_paint(colour, picBox, temp);
            tmr_colour.Enabled = true;
            tmr_colour.Start();

        }
    }
}