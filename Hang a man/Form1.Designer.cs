namespace Hang_a_man
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Quit = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skrivord = new System.Windows.Forms.Label();
            this.guesswordbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnA = new System.Windows.Forms.Button();
            this.txtWholeWord = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wordbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(924, 490);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(188, 72);
            this.Quit.TabIndex = 2;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(749, 490);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(169, 72);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start/Restart";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Playbill", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.title.Location = new System.Drawing.Point(556, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(246, 73);
            this.title.TabIndex = 5;
            this.title.Text = "Hang a Man";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.skrivord);
            this.panel1.Controls.Add(this.guesswordbtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtWholeWord);
            this.panel1.Location = new System.Drawing.Point(566, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 380);
            this.panel1.TabIndex = 6;
            // 
            // skrivord
            // 
            this.skrivord.AutoSize = true;
            this.skrivord.Location = new System.Drawing.Point(21, 246);
            this.skrivord.Name = "skrivord";
            this.skrivord.Size = new System.Drawing.Size(135, 20);
            this.skrivord.TabIndex = 12;
            this.skrivord.Text = "Write the full word";
            // 
            // guesswordbtn
            // 
            this.guesswordbtn.Location = new System.Drawing.Point(346, 269);
            this.guesswordbtn.Name = "guesswordbtn";
            this.guesswordbtn.Size = new System.Drawing.Size(115, 34);
            this.guesswordbtn.TabIndex = 10;
            this.guesswordbtn.Text = "Guess Word";
            this.guesswordbtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnA);
            this.panel2.Location = new System.Drawing.Point(25, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 196);
            this.panel2.TabIndex = 9;
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(15, 26);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(48, 37);
            this.btnA.TabIndex = 0;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            // 
            // txtWholeWord
            // 
            this.txtWholeWord.Location = new System.Drawing.Point(25, 269);
            this.txtWholeWord.Name = "txtWholeWord";
            this.txtWholeWord.Size = new System.Drawing.Size(315, 26);
            this.txtWholeWord.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 488);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Wordbox
            // 
            this.Wordbox.BackColor = System.Drawing.SystemColors.WindowText;
            this.Wordbox.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wordbox.Location = new System.Drawing.Point(12, 513);
            this.Wordbox.Name = "Wordbox";
            this.Wordbox.Size = new System.Drawing.Size(522, 52);
            this.Wordbox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1124, 604);
            this.Controls.Add(this.Wordbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Quit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtWholeWord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label skrivord;
        private System.Windows.Forms.Button guesswordbtn;
        private System.Windows.Forms.TextBox Wordbox;
    }
}

