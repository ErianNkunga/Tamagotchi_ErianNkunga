
namespace Les3opdracht1
{
    partial class frmMoodle
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
            this.bttnEten = new System.Windows.Forms.Button();
            this.bttnDorst = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHP = new System.Windows.Forms.Label();
            this.lblDrink = new System.Windows.Forms.Label();
            this.lblHonger = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblGetal = new System.Windows.Forms.Label();
            this.pbAfbeelding = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pbDorst = new Les3opdracht1.CustomProgressBar();
            this.pbHonger = new Les3opdracht1.CustomProgressBar();
            this.pbWelzijn = new Les3opdracht1.CustomProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfbeelding)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnEten
            // 
            this.bttnEten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEten.Location = new System.Drawing.Point(212, 491);
            this.bttnEten.Name = "bttnEten";
            this.bttnEten.Size = new System.Drawing.Size(138, 75);
            this.bttnEten.TabIndex = 5;
            this.bttnEten.Text = "🍔 geven";
            this.bttnEten.UseVisualStyleBackColor = true;
            this.bttnEten.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttnDorst
            // 
            this.bttnDorst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDorst.Location = new System.Drawing.Point(378, 491);
            this.bttnDorst.Name = "bttnDorst";
            this.bttnDorst.Size = new System.Drawing.Size(138, 75);
            this.bttnDorst.TabIndex = 6;
            this.bttnDorst.Text = "🥛 geven";
            this.bttnDorst.UseVisualStyleBackColor = true;
            this.bttnDorst.Click += new System.EventHandler(this.bttnDorst_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.Location = new System.Drawing.Point(128, 324);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(63, 20);
            this.lblHP.TabIndex = 7;
            this.lblHP.Text = "Welzijn:";
            // 
            // lblDrink
            // 
            this.lblDrink.AutoSize = true;
            this.lblDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrink.Location = new System.Drawing.Point(128, 443);
            this.lblDrink.Name = "lblDrink";
            this.lblDrink.Size = new System.Drawing.Size(56, 20);
            this.lblDrink.TabIndex = 8;
            this.lblDrink.Text = "Water:";
            // 
            // lblHonger
            // 
            this.lblHonger.AutoSize = true;
            this.lblHonger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHonger.Location = new System.Drawing.Point(128, 386);
            this.lblHonger.Name = "lblHonger";
            this.lblHonger.Size = new System.Drawing.Size(66, 20);
            this.lblHonger.TabIndex = 9;
            this.lblHonger.Text = "Honger:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(336, 595);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "Score:";
            // 
            // lblGetal
            // 
            this.lblGetal.AutoSize = true;
            this.lblGetal.Location = new System.Drawing.Point(375, 595);
            this.lblGetal.Name = "lblGetal";
            this.lblGetal.Size = new System.Drawing.Size(13, 13);
            this.lblGetal.TabIndex = 11;
            this.lblGetal.Text = "0";
            // 
            // pbAfbeelding
            // 
            this.pbAfbeelding.Image = global::Les3opdracht1.Properties.Resources.Doge_meme_100___95;
            this.pbAfbeelding.InitialImage = null;
            this.pbAfbeelding.Location = new System.Drawing.Point(212, 29);
            this.pbAfbeelding.Name = "pbAfbeelding";
            this.pbAfbeelding.Size = new System.Drawing.Size(304, 273);
            this.pbAfbeelding.TabIndex = 3;
            this.pbAfbeelding.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pbDorst
            // 
            this.pbDorst.Location = new System.Drawing.Point(212, 440);
            this.pbDorst.Name = "pbDorst";
            this.pbDorst.Size = new System.Drawing.Size(304, 23);
            this.pbDorst.TabIndex = 2;
            this.pbDorst.Value = 100;
            // 
            // pbHonger
            // 
            this.pbHonger.BackColor = System.Drawing.SystemColors.Control;
            this.pbHonger.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pbHonger.Location = new System.Drawing.Point(212, 383);
            this.pbHonger.Name = "pbHonger";
            this.pbHonger.Size = new System.Drawing.Size(304, 23);
            this.pbHonger.TabIndex = 1;
            this.pbHonger.Value = 100;
            this.pbHonger.Click += new System.EventHandler(this.pbHonger_Click);
            // 
            // pbWelzijn
            // 
            this.pbWelzijn.Location = new System.Drawing.Point(212, 324);
            this.pbWelzijn.Name = "pbWelzijn";
            this.pbWelzijn.Size = new System.Drawing.Size(304, 23);
            this.pbWelzijn.TabIndex = 0;
            this.pbWelzijn.Value = 100;
            this.pbWelzijn.Click += new System.EventHandler(this.pbScore_Click_1);
            // 
            // frmMoodle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(740, 642);
            this.Controls.Add(this.lblGetal);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblHonger);
            this.Controls.Add(this.lblDrink);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.bttnDorst);
            this.Controls.Add(this.bttnEten);
            this.Controls.Add(this.pbAfbeelding);
            this.Controls.Add(this.pbDorst);
            this.Controls.Add(this.pbHonger);
            this.Controls.Add(this.pbWelzijn);
            this.MaximizeBox = false;
            this.Name = "frmMoodle";
            this.Text = "Dogegotchi";
            this.Load += new System.EventHandler(this.frmMoodle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAfbeelding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomProgressBar pbWelzijn;
        private CustomProgressBar pbHonger;
        private CustomProgressBar pbDorst;
        private System.Windows.Forms.PictureBox pbAfbeelding;
        private System.Windows.Forms.Button bttnEten;
        private System.Windows.Forms.Button bttnDorst;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblDrink;
        private System.Windows.Forms.Label lblHonger;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblGetal;
        private System.Windows.Forms.Timer timer2;
    }
}

