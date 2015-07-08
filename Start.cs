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
    public partial class frm_Start : Form
    {
        

        public frm_Start()
        {
            InitializeComponent();
        }
        
        private void btn_Start_onClick(object sender, EventArgs e)
        {

            frm_Memory frm_Main = new frm_Memory();
            
            frm_Main.Visible = true;

            this.Visible = false;

           // frm_Main.ProcessDirectory(path);

        }

        private void btn_quit_start_onClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
