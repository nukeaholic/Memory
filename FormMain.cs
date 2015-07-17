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
        private frm_Start frm_Start;
        private List <Array> flaggen = new List<Array>();

        private string[,] austria = new string[1, 2] { { "austria", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Austria.png" } };
        private string[,] belgium = new string[1, 2] { { "belgium", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Belgium.png" } };
        private string[,] czech = new string[1, 2] { { "czech republic", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\CzechRepublic.png" } };
        private string[,] denmark = new string[1, 2] { { "denmark", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Denmark.png" } };
        
        private string[,] france = new string[1, 2] { { "france", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\France.png" } };
        private string[,] germany = new string[1, 2] { { "germany", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Germany.png" } };
        private string[,] iceland = new string[1, 2] { { "iceland", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Iceland.png" } };
        private string[,] ireland = new string[1, 2] { { "ireland", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Ireland.png" } };
        
        private string[,] luxembourg = new string[1, 2] { { "luxembourg", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Luxembourg.png" } };
        private string[,] netherlands = new string[1, 2] { { "netherlands", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Netherlands.png" } };
        private string[,] norway = new string[1, 2] { { "norway", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Norway.png" } };
        private string[,] portugal = new string[1, 2] { { "portugal", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Portugal.png" } };
        
        private string[,] spain = new string[1, 2] { { "spain", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Spain.png" } };
        private string[,] sweden = new string[1, 2] { { "sweden", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Sweden.png" } };
        private string[,] switzerland = new string[1, 2] { { "switzerland", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\Switzerland.png" } };
        private string[,] uk = new string[1, 2] { { "united kingdom", "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources\\UK.png" } };
        
        //On Load
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ProcessDirectory(path);
        }


        public frm_Memory(frm_Start frm_Start)
        {
            InitializeComponent();
            this.frm_Start = frm_Start;
        }

        //btn_BACK
        private void btn_Back_OnClick(object sender, EventArgs e)
        {
            frm_Start.Visible = true;
            this.Close();
        }        

        //btn_QUIT
        private void btn_quit_main_onClick(object sender, EventArgs e)
        {
            frm_Start.Close();
            this.Close();
        }

        


        //Picboxen abfüllen
        public void ProcessDirectory(string targetDirectory)
        {



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

            bool flip = true;
            int i = 0;

            foreach (PictureBox box in picboxes)
            {
                string[,] local = (string[,])flaggen[i];

                if (flip) 
                {
                    MemoryHelp.ProcessFile(box, local[0, 1]);
                    flip = false;
                }
                else
                {
                    System.Drawing.Graphics g = box.CreateGraphics();
                    g.DrawString(local[0,0], new Font("Arial", 14), Brushes.Black, new Point(2, 2));
                    
                    
                    flip = true;
                }
                i++;
            }

            // Recurse into subdirectories of this directory. 
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);

        }



        //    using (Font myFont = new Font("Arial", 14))
        //    {
        //        e.Graphics.DrawString(name, myFont, Brushes.Black, new Point(2, 2));
        //    }


        //picBox_XX_onCLICK
        private void picBox_XX_onClick(object sender, EventArgs e)
        {
            PictureBox picBox = (PictureBox)sender;
        }

        
    }
}