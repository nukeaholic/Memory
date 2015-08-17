namespace Memory
{
    partial class frm_Memory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Memory));
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.txtBox_right = new System.Windows.Forms.TextBox();
            this.lbl_right = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_quit_main = new System.Windows.Forms.Button();
            this.lbl_Turns = new System.Windows.Forms.Label();
            this.txtBox_Turns = new System.Windows.Forms.TextBox();
            this.lbl_solution = new System.Windows.Forms.Label();
            this.tmr_colour = new System.Windows.Forms.Timer(this.components);
            this.picBox_01 = new System.Windows.Forms.PictureBox();
            this.picBox_02 = new System.Windows.Forms.PictureBox();
            this.picBox_03 = new System.Windows.Forms.PictureBox();
            this.picBox_10 = new System.Windows.Forms.PictureBox();
            this.picBox_20 = new System.Windows.Forms.PictureBox();
            this.picBox_30 = new System.Windows.Forms.PictureBox();
            this.picBox_11 = new System.Windows.Forms.PictureBox();
            this.picBox_21 = new System.Windows.Forms.PictureBox();
            this.picBox_31 = new System.Windows.Forms.PictureBox();
            this.picBox_32 = new System.Windows.Forms.PictureBox();
            this.picBox_33 = new System.Windows.Forms.PictureBox();
            this.picBox_23 = new System.Windows.Forms.PictureBox();
            this.picBox_13 = new System.Windows.Forms.PictureBox();
            this.picBox_22 = new System.Windows.Forms.PictureBox();
            this.picBox_12 = new System.Windows.Forms.PictureBox();
            this.picBox_00 = new System.Windows.Forms.PictureBox();
            this.pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_00)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.Controls.Add(this.txtBox_right);
            this.pnl_menu.Controls.Add(this.lbl_right);
            this.pnl_menu.Controls.Add(this.btn_start);
            this.pnl_menu.Controls.Add(this.btn_quit_main);
            this.pnl_menu.Controls.Add(this.lbl_Turns);
            this.pnl_menu.Controls.Add(this.txtBox_Turns);
            this.pnl_menu.Location = new System.Drawing.Point(1190, 70);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(217, 901);
            this.pnl_menu.TabIndex = 16;
            // 
            // txtBox_right
            // 
            this.txtBox_right.Enabled = false;
            this.txtBox_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_right.Location = new System.Drawing.Point(48, 362);
            this.txtBox_right.Name = "txtBox_right";
            this.txtBox_right.ReadOnly = true;
            this.txtBox_right.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBox_right.Size = new System.Drawing.Size(143, 53);
            this.txtBox_right.TabIndex = 8;
            this.txtBox_right.Text = "0";
            this.txtBox_right.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_right
            // 
            this.lbl_right.AutoSize = true;
            this.lbl_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_right.Location = new System.Drawing.Point(45, 335);
            this.lbl_right.Name = "lbl_right";
            this.lbl_right.Size = new System.Drawing.Size(101, 13);
            this.lbl_right.TabIndex = 7;
            this.lbl_right.Text = "Paare gefunden:";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(48, 618);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(143, 48);
            this.btn_start.TabIndex = 6;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_quit_main
            // 
            this.btn_quit_main.Location = new System.Drawing.Point(48, 693);
            this.btn_quit_main.Name = "btn_quit_main";
            this.btn_quit_main.Size = new System.Drawing.Size(143, 48);
            this.btn_quit_main.TabIndex = 5;
            this.btn_quit_main.Text = "Beenden";
            this.btn_quit_main.UseVisualStyleBackColor = true;
            this.btn_quit_main.Click += new System.EventHandler(this.btn_quit_main_onClick);
            // 
            // lbl_Turns
            // 
            this.lbl_Turns.AutoSize = true;
            this.lbl_Turns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Turns.Location = new System.Drawing.Point(45, 201);
            this.lbl_Turns.Name = "lbl_Turns";
            this.lbl_Turns.Size = new System.Drawing.Size(40, 13);
            this.lbl_Turns.TabIndex = 3;
            this.lbl_Turns.Text = "Züge:";
            // 
            // txtBox_Turns
            // 
            this.txtBox_Turns.Enabled = false;
            this.txtBox_Turns.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Turns.Location = new System.Drawing.Point(48, 232);
            this.txtBox_Turns.Name = "txtBox_Turns";
            this.txtBox_Turns.ReadOnly = true;
            this.txtBox_Turns.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBox_Turns.Size = new System.Drawing.Size(143, 53);
            this.txtBox_Turns.TabIndex = 2;
            this.txtBox_Turns.Text = "0";
            this.txtBox_Turns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_solution
            // 
            this.lbl_solution.AutoSize = true;
            this.lbl_solution.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_solution.Location = new System.Drawing.Point(494, 35);
            this.lbl_solution.Name = "lbl_solution";
            this.lbl_solution.Size = new System.Drawing.Size(278, 63);
            this.lbl_solution.TabIndex = 17;
            this.lbl_solution.Text = "Memory :)";
            // 
            // tmr_colour
            // 
            this.tmr_colour.Interval = 250;
            this.tmr_colour.Tick += new System.EventHandler(this.tmr_colour_Tick);
            // 
            // picBox_01
            // 
            this.picBox_01.BackColor = System.Drawing.Color.LightGray;
            this.picBox_01.Enabled = false;
            this.picBox_01.Image = ((System.Drawing.Image)(resources.GetObject("picBox_01.Image")));
            this.picBox_01.Location = new System.Drawing.Point(366, 155);
            this.picBox_01.Name = "picBox_01";
            this.picBox_01.Size = new System.Drawing.Size(200, 200);
            this.picBox_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_01.TabIndex = 15;
            this.picBox_01.TabStop = false;
            this.picBox_01.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_02
            // 
            this.picBox_02.BackColor = System.Drawing.Color.LightGray;
            this.picBox_02.Enabled = false;
            this.picBox_02.Image = ((System.Drawing.Image)(resources.GetObject("picBox_02.Image")));
            this.picBox_02.Location = new System.Drawing.Point(616, 155);
            this.picBox_02.Name = "picBox_02";
            this.picBox_02.Size = new System.Drawing.Size(200, 200);
            this.picBox_02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_02.TabIndex = 14;
            this.picBox_02.TabStop = false;
            this.picBox_02.Tag = "";
            this.picBox_02.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_03
            // 
            this.picBox_03.BackColor = System.Drawing.Color.LightGray;
            this.picBox_03.Enabled = false;
            this.picBox_03.Image = ((System.Drawing.Image)(resources.GetObject("picBox_03.Image")));
            this.picBox_03.Location = new System.Drawing.Point(866, 155);
            this.picBox_03.Name = "picBox_03";
            this.picBox_03.Size = new System.Drawing.Size(200, 200);
            this.picBox_03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_03.TabIndex = 13;
            this.picBox_03.TabStop = false;
            this.picBox_03.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_10
            // 
            this.picBox_10.BackColor = System.Drawing.Color.LightGray;
            this.picBox_10.Enabled = false;
            this.picBox_10.Image = ((System.Drawing.Image)(resources.GetObject("picBox_10.Image")));
            this.picBox_10.Location = new System.Drawing.Point(116, 405);
            this.picBox_10.Name = "picBox_10";
            this.picBox_10.Size = new System.Drawing.Size(200, 200);
            this.picBox_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_10.TabIndex = 12;
            this.picBox_10.TabStop = false;
            this.picBox_10.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_20
            // 
            this.picBox_20.BackColor = System.Drawing.Color.LightGray;
            this.picBox_20.Enabled = false;
            this.picBox_20.Image = ((System.Drawing.Image)(resources.GetObject("picBox_20.Image")));
            this.picBox_20.Location = new System.Drawing.Point(116, 655);
            this.picBox_20.Name = "picBox_20";
            this.picBox_20.Size = new System.Drawing.Size(200, 200);
            this.picBox_20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_20.TabIndex = 11;
            this.picBox_20.TabStop = false;
            this.picBox_20.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_30
            // 
            this.picBox_30.BackColor = System.Drawing.Color.LightGray;
            this.picBox_30.Enabled = false;
            this.picBox_30.Image = ((System.Drawing.Image)(resources.GetObject("picBox_30.Image")));
            this.picBox_30.Location = new System.Drawing.Point(116, 905);
            this.picBox_30.Name = "picBox_30";
            this.picBox_30.Size = new System.Drawing.Size(200, 200);
            this.picBox_30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_30.TabIndex = 10;
            this.picBox_30.TabStop = false;
            this.picBox_30.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_11
            // 
            this.picBox_11.BackColor = System.Drawing.Color.LightGray;
            this.picBox_11.Enabled = false;
            this.picBox_11.Image = ((System.Drawing.Image)(resources.GetObject("picBox_11.Image")));
            this.picBox_11.Location = new System.Drawing.Point(366, 405);
            this.picBox_11.Name = "picBox_11";
            this.picBox_11.Size = new System.Drawing.Size(200, 200);
            this.picBox_11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_11.TabIndex = 9;
            this.picBox_11.TabStop = false;
            this.picBox_11.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_21
            // 
            this.picBox_21.BackColor = System.Drawing.Color.LightGray;
            this.picBox_21.Enabled = false;
            this.picBox_21.Image = ((System.Drawing.Image)(resources.GetObject("picBox_21.Image")));
            this.picBox_21.Location = new System.Drawing.Point(366, 655);
            this.picBox_21.Name = "picBox_21";
            this.picBox_21.Size = new System.Drawing.Size(200, 200);
            this.picBox_21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_21.TabIndex = 8;
            this.picBox_21.TabStop = false;
            this.picBox_21.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_31
            // 
            this.picBox_31.BackColor = System.Drawing.Color.LightGray;
            this.picBox_31.Enabled = false;
            this.picBox_31.Image = ((System.Drawing.Image)(resources.GetObject("picBox_31.Image")));
            this.picBox_31.Location = new System.Drawing.Point(366, 905);
            this.picBox_31.Name = "picBox_31";
            this.picBox_31.Size = new System.Drawing.Size(200, 200);
            this.picBox_31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_31.TabIndex = 7;
            this.picBox_31.TabStop = false;
            this.picBox_31.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_32
            // 
            this.picBox_32.BackColor = System.Drawing.Color.LightGray;
            this.picBox_32.Enabled = false;
            this.picBox_32.Image = ((System.Drawing.Image)(resources.GetObject("picBox_32.Image")));
            this.picBox_32.Location = new System.Drawing.Point(616, 905);
            this.picBox_32.Name = "picBox_32";
            this.picBox_32.Size = new System.Drawing.Size(200, 200);
            this.picBox_32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_32.TabIndex = 6;
            this.picBox_32.TabStop = false;
            this.picBox_32.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_33
            // 
            this.picBox_33.BackColor = System.Drawing.Color.LightGray;
            this.picBox_33.Enabled = false;
            this.picBox_33.Image = ((System.Drawing.Image)(resources.GetObject("picBox_33.Image")));
            this.picBox_33.Location = new System.Drawing.Point(866, 905);
            this.picBox_33.Name = "picBox_33";
            this.picBox_33.Size = new System.Drawing.Size(200, 200);
            this.picBox_33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_33.TabIndex = 5;
            this.picBox_33.TabStop = false;
            this.picBox_33.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_23
            // 
            this.picBox_23.BackColor = System.Drawing.Color.LightGray;
            this.picBox_23.Enabled = false;
            this.picBox_23.Image = ((System.Drawing.Image)(resources.GetObject("picBox_23.Image")));
            this.picBox_23.Location = new System.Drawing.Point(866, 655);
            this.picBox_23.Name = "picBox_23";
            this.picBox_23.Size = new System.Drawing.Size(200, 200);
            this.picBox_23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_23.TabIndex = 4;
            this.picBox_23.TabStop = false;
            this.picBox_23.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_13
            // 
            this.picBox_13.BackColor = System.Drawing.Color.LightGray;
            this.picBox_13.Enabled = false;
            this.picBox_13.Image = ((System.Drawing.Image)(resources.GetObject("picBox_13.Image")));
            this.picBox_13.Location = new System.Drawing.Point(866, 405);
            this.picBox_13.Name = "picBox_13";
            this.picBox_13.Size = new System.Drawing.Size(200, 200);
            this.picBox_13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_13.TabIndex = 3;
            this.picBox_13.TabStop = false;
            this.picBox_13.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_22
            // 
            this.picBox_22.BackColor = System.Drawing.Color.LightGray;
            this.picBox_22.Enabled = false;
            this.picBox_22.Image = ((System.Drawing.Image)(resources.GetObject("picBox_22.Image")));
            this.picBox_22.Location = new System.Drawing.Point(616, 655);
            this.picBox_22.Name = "picBox_22";
            this.picBox_22.Size = new System.Drawing.Size(200, 200);
            this.picBox_22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_22.TabIndex = 2;
            this.picBox_22.TabStop = false;
            this.picBox_22.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_12
            // 
            this.picBox_12.BackColor = System.Drawing.Color.LightGray;
            this.picBox_12.Enabled = false;
            this.picBox_12.Image = ((System.Drawing.Image)(resources.GetObject("picBox_12.Image")));
            this.picBox_12.Location = new System.Drawing.Point(616, 405);
            this.picBox_12.Name = "picBox_12";
            this.picBox_12.Size = new System.Drawing.Size(200, 200);
            this.picBox_12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_12.TabIndex = 1;
            this.picBox_12.TabStop = false;
            this.picBox_12.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_00
            // 
            this.picBox_00.BackColor = System.Drawing.Color.LightGray;
            this.picBox_00.Enabled = false;
            this.picBox_00.Image = ((System.Drawing.Image)(resources.GetObject("picBox_00.Image")));
            this.picBox_00.Location = new System.Drawing.Point(116, 155);
            this.picBox_00.Name = "picBox_00";
            this.picBox_00.Size = new System.Drawing.Size(200, 200);
            this.picBox_00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_00.TabIndex = 0;
            this.picBox_00.TabStop = false;
            this.picBox_00.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // frm_Memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1428, 1181);
            this.Controls.Add(this.lbl_solution);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.picBox_01);
            this.Controls.Add(this.picBox_02);
            this.Controls.Add(this.picBox_03);
            this.Controls.Add(this.picBox_10);
            this.Controls.Add(this.picBox_20);
            this.Controls.Add(this.picBox_30);
            this.Controls.Add(this.picBox_11);
            this.Controls.Add(this.picBox_21);
            this.Controls.Add(this.picBox_31);
            this.Controls.Add(this.picBox_32);
            this.Controls.Add(this.picBox_33);
            this.Controls.Add(this.picBox_23);
            this.Controls.Add(this.picBox_13);
            this.Controls.Add(this.picBox_22);
            this.Controls.Add(this.picBox_12);
            this.Controls.Add(this.picBox_00);
            this.Name = "frm_Memory";
            this.Text = "Memory";
            this.pnl_menu.ResumeLayout(false);
            this.pnl_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_00)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Label lbl_Turns;
        private System.Windows.Forms.TextBox txtBox_Turns;
        public System.Windows.Forms.PictureBox picBox_00;
        public System.Windows.Forms.PictureBox picBox_12;
        public System.Windows.Forms.PictureBox picBox_22;
        public System.Windows.Forms.PictureBox picBox_13;
        public System.Windows.Forms.PictureBox picBox_23;
        public System.Windows.Forms.PictureBox picBox_33;
        public System.Windows.Forms.PictureBox picBox_32;
        public System.Windows.Forms.PictureBox picBox_31;
        public System.Windows.Forms.PictureBox picBox_21;
        public System.Windows.Forms.PictureBox picBox_11;
        public System.Windows.Forms.PictureBox picBox_30;
        public System.Windows.Forms.PictureBox picBox_20;
        public System.Windows.Forms.PictureBox picBox_10;
        public System.Windows.Forms.PictureBox picBox_03;
        public System.Windows.Forms.PictureBox picBox_02;
        public System.Windows.Forms.PictureBox picBox_01;
        private System.Windows.Forms.Button btn_quit_main;
        private System.Windows.Forms.Label lbl_solution;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Timer tmr_colour;
        private System.Windows.Forms.TextBox txtBox_right;
        private System.Windows.Forms.Label lbl_right;

        public System.Windows.Forms.PictureBox PicBox_01
        {
            get { return picBox_01; }
            set { picBox_01 = value; }
        }

    }
}

