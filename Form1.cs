using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class frm_Memory : Form
    {
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
            MessageBox.Show(picBox.Name);

        }
    }
}
