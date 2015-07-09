namespace Memory
{
    partial class frm_Start
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_quit_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(108, 416);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(456, 101);
            this.btn_Start.TabIndex = 6;
            this.btn_Start.Text = "Spiel Starten";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_onClick);
            // 
            // btn_quit_start
            // 
            this.btn_quit_start.Location = new System.Drawing.Point(108, 523);
            this.btn_quit_start.Name = "btn_quit_start";
            this.btn_quit_start.Size = new System.Drawing.Size(456, 101);
            this.btn_quit_start.TabIndex = 7;
            this.btn_quit_start.Text = "Beenden";
            this.btn_quit_start.UseVisualStyleBackColor = true;
            this.btn_quit_start.Click += new System.EventHandler(this.btn_quit_start_onClick);
            // 
            // frm_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 636);
            this.Controls.Add(this.btn_quit_start);
            this.Controls.Add(this.btn_Start);
            this.Name = "frm_Start";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_quit_start;
    }
}