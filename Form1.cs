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

        public string path = "D:\\Users\\ehanss\\Documents\\Visual Studio 2013\\Projects\\Memory\\Memory\\Resources";

        public Dictionary <Object,string> Feld = new Dictionary <Object,string>();


        public frm_Memory()
        {
            InitializeComponent();
        }

        private void btn_Back_OnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBox_XX_onClick(object sender, EventArgs e)
        {
            PictureBox picBox = (PictureBox)sender;
            //MessageBox.Show(picBox.Image);

            //ProcessDirectory(path);
        


        }

        private void btn_start_onClick(object sender, EventArgs e)
        {
            ProcessDirectory(path);
        }


        public void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory. 
            string[] fileEntries = Directory.GetFiles(targetDirectory);

            MemoryHelp.Shuffle(fileEntries);

            int i = 0;


            

            Feld.Add(picBox_00, picBox_00.ImageLocation);
            Feld.Add(picBox_01, picBox_01.ImageLocation);
            Feld.Add(picBox_02, picBox_02.ImageLocation);
            Feld.Add(picBox_03, picBox_03.ImageLocation);

            Feld.Add(picBox_10, picBox_10.ImageLocation);
            Feld.Add(picBox_11, picBox_11.ImageLocation);
            Feld.Add(picBox_12, picBox_12.ImageLocation);
            Feld.Add(picBox_13, picBox_13.ImageLocation);

            Feld.Add(picBox_20, picBox_20.ImageLocation);
            Feld.Add(picBox_21, picBox_21.ImageLocation);
            Feld.Add(picBox_22, picBox_22.ImageLocation);
            Feld.Add(picBox_23, picBox_23.ImageLocation);

            Feld.Add(picBox_30, picBox_30.ImageLocation);
            Feld.Add(picBox_31, picBox_31.ImageLocation);
            Feld.Add(picBox_32, picBox_32.ImageLocation);
            Feld.Add(picBox_33, picBox_33.ImageLocation);


            //list<picturebox> picboxes = new list<picturebox>();



            //picboxes.add(picbox_00);
            //picboxes.add(picbox_01);
            //picboxes.add(picbox_02);
            //picboxes.add(picbox_03);

            //picboxes.add(picbox_10);
            //picboxes.add(picbox_11);
            //picboxes.add(picbox_12);
            //picboxes.add(picbox_13);

            //picboxes.add(picbox_20);
            //picboxes.add(picbox_21);
            //picboxes.add(picbox_22);
            //picboxes.add(picbox_23);

            //picboxes.add(picbox_30);
            //picboxes.add(picbox_31);
            //picboxes.add(picbox_32);
            //picboxes.add(picbox_33);




            foreach (KeyValuePair<Object, string> entry in Feld)
            {
                MemoryHelp.ProcessFile((PictureBox)entry.Key, entry.Value);
            }


            
	

            // Recurse into subdirectories of this directory. 
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);

            
        }

        

        
    }
}