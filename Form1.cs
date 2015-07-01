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
            //MessageBox.Show(picBox.Image.n);

            ProcessDirectory(path);
        


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

            List<PictureBox>  picBoxes = new List<PictureBox>();
            
            picBoxes.Add(picBox_00);
            picBoxes.Add(picBox_01);
            picBoxes.Add(picBox_02);

            picBoxes.Add(picBox_03);

            picBoxes.Add(picBox_10);
            picBoxes.Add(picBox_11);
            picBoxes.Add(picBox_12);
            picBoxes.Add(picBox_13);

            picBoxes.Add(picBox_20);
            picBoxes.Add(picBox_21);
            picBoxes.Add(picBox_22);
            picBoxes.Add(picBox_23);

            picBoxes.Add(picBox_30);
            picBoxes.Add(picBox_31);
            picBoxes.Add(picBox_32);
            picBoxes.Add(picBox_33);

            foreach (string fileName in fileEntries)
            {
                if (i <= 15)
                {
                    MemoryHelp.ProcessFile((PictureBox)picBoxes[i], fileName);
                    i++;
                }
            }

            
	

            // Recurse into subdirectories of this directory. 
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);

            
        }

        

        
    }
}