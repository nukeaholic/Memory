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


namespace Memory
{
    public partial class frm_Memory : Form
    {

        

        private string path = "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources";
        //private Dictionary<PictureBox, string> Feld = new Dictionary<PictureBox, string>();
        private List<PictureBox> picboxes = new List<PictureBox>();
        private List <Array> flaggen = new List<Array>();

        private string[,] austria = new string[1, 2] { { "Austria", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Austria.png" } };
        private string[,] belgium = new string[1, 2] { { "Belgium", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Belgium.png" } };
        private string[,] czech = new string[1, 2] { { "Czech Republic", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\CzechRepublic.png" } };
        private string[,] denmark = new string[1, 2] { { "Denmark", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Denmark.png" } };
        
        private string[,] france = new string[1, 2] { { "France", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\France.png" } };
        private string[,] germany = new string[1, 2] { { "Germany", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Germany.png" } };
        private string[,] iceland = new string[1, 2] { { "Iceland", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Iceland.png" } };
        private string[,] ireland = new string[1, 2] { { "Ireland", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Ireland.png" } };
        
        private string[,] luxembourg = new string[1, 2] { { "Luxembourg", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Luxembourg.png" } };
        private string[,] netherlands = new string[1, 2] { { "Netherlands", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Netherlands.png" } };
        private string[,] norway = new string[1, 2] { { "Norway", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Norway.png" } };
        private string[,] portugal = new string[1, 2] { { "Portugal", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Portugal.png" } };
        
        private string[,] spain = new string[1, 2] { { "Spain", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Spain.png" } };
        private string[,] sweden = new string[1, 2] { { "Sweden", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Sweden.png" } };
        private string[,] switzerland = new string[1, 2] { { "Switzerland", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Switzerland.png" } };
        private string[,] uk = new string[1, 2] { { "United Kingdom", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\UK.png" } };

        private List<string> quest = new List<string>();

        private int f = 0;
        private int i = 0;
        private bool flip = true;
        private int move_counter = 0;
        private string select;
        private bool flop = true;
        private PictureBox temp;
        PictureBox current;

        //On Load
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //ProcessDirectory(path);
        }


        public frm_Memory()
        {
            InitializeComponent();
        }
       

        //btn_QUIT
        private void btn_quit_main_onClick(object sender, EventArgs e)
        {
            this.Close();
        }




        private void btn_start_Click(object sender, EventArgs e)
        {

            btn_start.Enabled = false;


            // Process the list of files found in the directory. 

            //string[] fileEntries = Directory.GetFiles(targetDirectory);



            //Flaggen in Liste

            flaggen.Add(austria);
            flaggen.Add(belgium);
            flaggen.Add(czech);
            flaggen.Add(denmark);

            flaggen.Add(france);
            flaggen.Add(germany);
            flaggen.Add(iceland);
            flaggen.Add(ireland);

            flaggen.Add(luxembourg);
            flaggen.Add(netherlands);
            flaggen.Add(norway);
            flaggen.Add(portugal);

            flaggen.Add(spain);
            flaggen.Add(sweden);
            flaggen.Add(switzerland);
            flaggen.Add(uk);


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


            

            foreach (PictureBox box in picboxes)
            {
                box.Enabled = true;
                string[,] local = (string[,])flaggen[i];
                if (flip == true)
                {
                    MemoryHelp.ProcessFile(box, local[0, 1]);
                    box.Tag = local[0, 0];
                    flip = false;
                }

                else
                {
                    
                    using (Font myFont = new Font("Arial", 20))
                    {
                        //e.Graphics.DrawString(local[0,0], myFont, Brushes.Black, new Point(2, 2));                        
                        //MessageBox.Show(e.ToString());
                        
                        System.Drawing.Graphics g = box.CreateGraphics();
                        g.DrawString(local[0, 0], myFont, Brushes.Black, new Point(1, 100));

                        box.Tag = local[0, 0];

                        flip = true;
                        i++;
                    }
                }
            }
        }


        //picBox_XX_onCLICK
        private void picBox_XX_onClick(object sender, EventArgs e)
        {
            PictureBox picBox = (PictureBox)sender;
            //MessageBox.Show(picBox.Tag+"\n***\n"+lbl_quest.Text);

            

            
            

            if (flop == true){

                current = (PictureBox)picBox;
                select = picBox.Tag.ToString();
                flop = false;
                temp = picBox;
            }

            else{ 

                if(picBox.Tag.Equals(select) && picBox.Name != current.Name)
                {
                    MessageBox.Show("RICHTIG");
                    select = "";
                    picBox.Enabled = false;
                    picBox.Visible = false;
                    temp.Enabled = false;
                    temp.Visible = false;

                    f++;
                }

                else{
                    MessageBox.Show("FALSCH");
                    select = "";
                }
                move_counter++;
                txtBox_Turns.Text = move_counter.ToString();
                flop = true;

                if (f == 8)
                {
                    MessageBox.Show("Du hast es geschafft!\n\nDu hast nur " + move_counter + " Züge gebraucht!");
                        this.Close();
                }
            }
            
        }

        

        
    }
}