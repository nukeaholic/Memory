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
        private Dictionary<PictureBox, string> Feld = new Dictionary<PictureBox, string>();
        private List<PictureBox> picboxes = new List<PictureBox>();
        private frm_Start frm_Start;
        //private PaintEventArgs f;
        
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
            string[] fileEntries = Directory.GetFiles(targetDirectory);

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
  
            MemoryHelp.Shuffle(fileEntries);

            // loop über fileEntries as pfad
            // Erstellung von Dict
            //  -> Key Picturebox[i]
            //  -> Value pfad

            //bool flip = true;

            for (int i = 0; i < fileEntries.Length; )
            {
                //if (flip == true)
                //{
                //    Feld.Add(picboxes[i], fileEntries[i]);
                //    MemoryHelp.ProcessFile((PictureBox)picboxes[i], fileEntries[i]);
                //    flip = false;
                //}
                //else
                //{
                //    picboxes[i].Tag = fileEntries[i-1];
                //    picboxes[i].Invalidate();
                //    flip = true;
                //}

                //Feld.Add(picboxes[i], fileEntries[i]);
                MemoryHelp.ProcessFile((PictureBox)picboxes[i], fileEntries[i]);

                picboxes[i+1].Tag = fileEntries[i+1];
                picboxes[i+1].Invalidate();
                i = i+2;
                
            }

            // Recurse into subdirectories of this directory. 
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);

        }

        //picBox_XX_PAINT
        private void picBox_XX_Paint(object sender, PaintEventArgs e)
        {
            PictureBox picBox = (PictureBox)sender;
            string name = picBox.Tag.ToString();

            Console.WriteLine("*********************"+name);

            using (Font myFont = new Font("Arial", 14))
            {
                e.Graphics.DrawString(name, myFont, Brushes.Black, new Point(2, 2));
            }
        }

        //picBox_XX_onCLICK
        private void picBox_XX_onClick(object sender, EventArgs e)
        {
            PictureBox picBox = (PictureBox)sender;
        }

        
    }
}