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
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_quit_main = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Turns = new System.Windows.Forms.Label();
            this.txtBox_Turns = new System.Windows.Forms.TextBox();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.txtbox_Timer = new System.Windows.Forms.TextBox();
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
            this.pnl_menu.Controls.Add(this.btn_quit_main);
            this.pnl_menu.Controls.Add(this.btn_Back);
            this.pnl_menu.Controls.Add(this.lbl_Turns);
            this.pnl_menu.Controls.Add(this.txtBox_Turns);
            this.pnl_menu.Controls.Add(this.lbl_Timer);
            this.pnl_menu.Controls.Add(this.txtbox_Timer);
            this.pnl_menu.Location = new System.Drawing.Point(1190, 70);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(217, 750);
            this.pnl_menu.TabIndex = 16;
            // 
            // btn_quit_main
            // 
            this.btn_quit_main.Location = new System.Drawing.Point(48, 430);
            this.btn_quit_main.Name = "btn_quit_main";
            this.btn_quit_main.Size = new System.Drawing.Size(143, 48);
            this.btn_quit_main.TabIndex = 5;
            this.btn_quit_main.Text = "Beenden";
            this.btn_quit_main.UseVisualStyleBackColor = true;
            this.btn_quit_main.Click += new System.EventHandler(this.btn_quit_main_onClick);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(48, 361);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(143, 48);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Zurück";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_OnClick);
            // 
            // lbl_Turns
            // 
            this.lbl_Turns.AutoSize = true;
            this.lbl_Turns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Turns.Location = new System.Drawing.Point(66, 184);
            this.lbl_Turns.Name = "lbl_Turns";
            this.lbl_Turns.Size = new System.Drawing.Size(40, 13);
            this.lbl_Turns.TabIndex = 3;
            this.lbl_Turns.Text = "Züge:";
            // 
            // txtBox_Turns
            // 
            this.txtBox_Turns.Enabled = false;
            this.txtBox_Turns.Location = new System.Drawing.Point(59, 200);
            this.txtBox_Turns.Name = "txtBox_Turns";
            this.txtBox_Turns.ReadOnly = true;
            this.txtBox_Turns.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBox_Turns.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Turns.TabIndex = 2;
            this.txtBox_Turns.Text = "0";
            this.txtBox_Turns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.AutoSize = true;
            this.lbl_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Timer.Location = new System.Drawing.Point(66, 114);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(42, 13);
            this.lbl_Timer.TabIndex = 1;
            this.lbl_Timer.Text = "Timer:";
            // 
            // txtbox_Timer
            // 
            this.txtbox_Timer.Enabled = false;
            this.txtbox_Timer.Location = new System.Drawing.Point(59, 130);
            this.txtbox_Timer.Name = "txtbox_Timer";
            this.txtbox_Timer.ReadOnly = true;
            this.txtbox_Timer.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Timer.TabIndex = 0;
            this.txtbox_Timer.Text = "00:00";
            this.txtbox_Timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picBox_01
            // 
            this.picBox_01.BackColor = System.Drawing.SystemColors.Control;
            this.picBox_01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_01.Location = new System.Drawing.Point(370, 70);
            this.picBox_01.Name = "picBox_01";
            this.picBox_01.Size = new System.Drawing.Size(200, 200);
            this.picBox_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_01.TabIndex = 15;
            this.picBox_01.TabStop = false;
            this.picBox_01.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_02
            // 
            this.picBox_02.BackColor = System.Drawing.SystemColors.Control;
            this.picBox_02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_02.Location = new System.Drawing.Point(620, 70);
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
            this.picBox_03.BackColor = System.Drawing.SystemColors.Control;
            this.picBox_03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_03.Location = new System.Drawing.Point(870, 70);
            this.picBox_03.Name = "picBox_03";
            this.picBox_03.Size = new System.Drawing.Size(200, 200);
            this.picBox_03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_03.TabIndex = 13;
            this.picBox_03.TabStop = false;
            this.picBox_03.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_10
            // 
            this.picBox_10.BackColor = System.Drawing.SystemColors.Control;
            this.picBox_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_10.Location = new System.Drawing.Point(120, 320);
            this.picBox_10.Name = "picBox_10";
            this.picBox_10.Size = new System.Drawing.Size(200, 200);
            this.picBox_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_10.TabIndex = 12;
            this.picBox_10.TabStop = false;
            this.picBox_10.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_20
            // 
            this.picBox_20.BackColor = System.Drawing.SystemColors.Control;
            this.picBox_20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_20.Location = new System.Drawing.Point(120, 570);
            this.picBox_20.Name = "picBox_20";
            this.picBox_20.Size = new System.Drawing.Size(200, 200);
            this.picBox_20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_20.TabIndex = 11;
            this.picBox_20.TabStop = false;
            this.picBox_20.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_30
            // 
            this.picBox_30.BackColor = System.Drawing.SystemColors.Control;
            this.picBox_30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_30.Location = new System.Drawing.Point(120, 820);
            this.picBox_30.Name = "picBox_30";
            this.picBox_30.Size = new System.Drawing.Size(200, 200);
            this.picBox_30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_30.TabIndex = 10;
            this.picBox_30.TabStop = false;
            this.picBox_30.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_11
            // 
            this.picBox_11.BackColor = System.Drawing.SystemColors.Control;
            this.picBox_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_11.Location = new System.Drawing.Point(370, 320);
            this.picBox_11.Name = "picBox_11";
            this.picBox_11.Size = new System.Drawing.Size(200, 200);
            this.picBox_11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_11.TabIndex = 9;
            this.picBox_11.TabStop = false;
            this.picBox_11.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_21
            // 
            this.picBox_21.BackColor = System.Drawing.SystemColors.Control;
            this.picBox_21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_21.Location = new System.Drawing.Point(370, 570);
            this.picBox_21.Name = "picBox_21";
            this.picBox_21.Size = new System.Drawing.Size(200, 200);
            this.picBox_21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_21.TabIndex = 8;
            this.picBox_21.TabStop = false;
            this.picBox_21.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_31
            // 
            this.picBox_31.BackColor = System.Drawing.SystemColors.Control;
            this.picBox_31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_31.Location = new System.Drawing.Point(370, 820);
            this.picBox_31.Name = "picBox_31";
            this.picBox_31.Size = new System.Drawing.Size(200, 200);
            this.picBox_31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_31.TabIndex = 7;
            this.picBox_31.TabStop = false;
            this.picBox_31.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_32
            // 
            this.picBox_32.BackColor = System.Drawing.SystemColors.Control;
            this.picBox_32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_32.Location = new System.Drawing.Point(620, 820);
            this.picBox_32.Name = "picBox_32";
            this.picBox_32.Size = new System.Drawing.Size(200, 200);
            this.picBox_32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_32.TabIndex = 6;
            this.picBox_32.TabStop = false;
            this.picBox_32.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_33
            // 
            this.picBox_33.BackColor = System.Drawing.SystemColors.Control;
            this.picBox_33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_33.Location = new System.Drawing.Point(870, 820);
            this.picBox_33.Name = "picBox_33";
            this.picBox_33.Size = new System.Drawing.Size(200, 200);
            this.picBox_33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_33.TabIndex = 5;
            this.picBox_33.TabStop = false;
            this.picBox_33.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_23
            // 
            this.picBox_23.BackColor = System.Drawing.SystemColors.Control;
            this.picBox_23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_23.Location = new System.Drawing.Point(870, 570);
            this.picBox_23.Name = "picBox_23";
            this.picBox_23.Size = new System.Drawing.Size(200, 200);
            this.picBox_23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_23.TabIndex = 4;
            this.picBox_23.TabStop = false;
            this.picBox_23.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_13
            // 
            this.picBox_13.BackColor = System.Drawing.SystemColors.Control;
            this.picBox_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_13.Location = new System.Drawing.Point(870, 320);
            this.picBox_13.Name = "picBox_13";
            this.picBox_13.Size = new System.Drawing.Size(200, 200);
            this.picBox_13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_13.TabIndex = 3;
            this.picBox_13.TabStop = false;
            this.picBox_13.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_22
            // 
            this.picBox_22.BackColor = System.Drawing.SystemColors.Control;
            this.picBox_22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_22.Location = new System.Drawing.Point(620, 570);
            this.picBox_22.Name = "picBox_22";
            this.picBox_22.Size = new System.Drawing.Size(200, 200);
            this.picBox_22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_22.TabIndex = 2;
            this.picBox_22.TabStop = false;
            this.picBox_22.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_12
            // 
            this.picBox_12.BackColor = System.Drawing.SystemColors.Control;
            this.picBox_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_12.Location = new System.Drawing.Point(620, 320);
            this.picBox_12.Name = "picBox_12";
            this.picBox_12.Size = new System.Drawing.Size(200, 200);
            this.picBox_12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_12.TabIndex = 1;
            this.picBox_12.TabStop = false;
            this.picBox_12.Click += new System.EventHandler(this.picBox_XX_onClick);
            // 
            // picBox_00
            // 
            this.picBox_00.BackColor = System.Drawing.SystemColors.Control;
            this.picBox_00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_00.Location = new System.Drawing.Point(120, 70);
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
            this.ClientSize = new System.Drawing.Size(1428, 1064);
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

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Label lbl_Turns;
        private System.Windows.Forms.TextBox txtBox_Turns;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.TextBox txtbox_Timer;
        private System.Windows.Forms.Button btn_Back;
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

        public System.Windows.Forms.PictureBox PicBox_01
        {
            get { return picBox_01; }
            set { picBox_01 = value; }
        }

    }
}

