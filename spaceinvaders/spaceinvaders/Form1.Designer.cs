namespace spaceinvaders
{
    partial class Form1
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
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.avion2 = new System.Windows.Forms.PictureBox();
            this.avion = new System.Windows.Forms.PictureBox();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.MetakTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.avion2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avion)).BeginInit();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 10;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // avion2
            // 
            this.avion2.BackColor = System.Drawing.Color.Black;
            this.avion2.Image = global::spaceinvaders.Properties.Resources.avion2;
            this.avion2.Location = new System.Drawing.Point(240, 559);
            this.avion2.Name = "avion2";
            this.avion2.Size = new System.Drawing.Size(78, 75);
            this.avion2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avion2.TabIndex = 1;
            this.avion2.TabStop = false;
            this.avion2.Tag = "player";
            this.avion2.Visible = false;
            // 
            // avion
            // 
            this.avion.BackColor = System.Drawing.Color.Black;
            this.avion.Image = global::spaceinvaders.Properties.Resources.avion1;
            this.avion.Location = new System.Drawing.Point(572, 559);
            this.avion.Name = "avion";
            this.avion.Size = new System.Drawing.Size(78, 75);
            this.avion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avion.TabIndex = 0;
            this.avion.TabStop = false;
            this.avion.Tag = "player";
            this.avion.Visible = false;
            // 
            // timer5
            // 
            this.timer5.Interval = 10;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 10;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // timer7
            // 
            this.timer7.Interval = 10;
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // timer8
            // 
            this.timer8.Interval = 10;
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 1;
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 108);
            this.label1.TabIndex = 2;
            this.label1.Text = "GAME OVER";
            this.label1.Visible = false;
            // 
            // MetakTimer
            // 
            this.MetakTimer.Interval = 7;
            this.MetakTimer.Tick += new System.EventHandler(this.MetakTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(884, 718);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avion2);
            this.Controls.Add(this.avion);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.avion2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox avion;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox avion2;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer MetakTimer;
    }
}

