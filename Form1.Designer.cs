namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrCountTime = new System.Windows.Forms.Timer(this.components);
            this.lblMove = new System.Windows.Forms.Label();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btmPlay = new System.Windows.Forms.Button();
            this.btmGiveUp = new System.Windows.Forms.Button();
            this.btmRule = new System.Windows.Forms.Button();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.pic8 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.picBoxRodC = new System.Windows.Forms.PictureBox();
            this.picBoxRodB = new System.Windows.Forms.PictureBox();
            this.picBoxRodA = new System.Windows.Forms.PictureBox();
            this.btmHint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRodC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRodB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRodA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(625, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "B";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(870, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "C";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(588, 27);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(113, 20);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "Time: 00:00:00";
            // 
            // tmrCountTime
            // 
            this.tmrCountTime.Interval = 1000;
            this.tmrCountTime.Tick += new System.EventHandler(this.tmrCountTime_Tick);
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMove.Location = new System.Drawing.Point(613, 71);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(77, 20);
            this.lblMove.TabIndex = 18;
            this.lblMove.Text = "Moved : 0";
            this.lblMove.Click += new System.EventHandler(this.pic_Click);
            // 
            // nudLevel
            // 
            this.nudLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLevel.Location = new System.Drawing.Point(629, 112);
            this.nudLevel.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudLevel.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(40, 26);
            this.nudLevel.TabIndex = 19;
            this.nudLevel.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(570, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Disk";
            // 
            // btmPlay
            // 
            this.btmPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmPlay.Location = new System.Drawing.Point(341, 144);
            this.btmPlay.Name = "btmPlay";
            this.btmPlay.Size = new System.Drawing.Size(100, 30);
            this.btmPlay.TabIndex = 21;
            this.btmPlay.Text = "Play";
            this.btmPlay.UseVisualStyleBackColor = true;
            this.btmPlay.Click += new System.EventHandler(this.btmPlay_Click);
            // 
            // btmGiveUp
            // 
            this.btmGiveUp.Enabled = false;
            this.btmGiveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmGiveUp.Location = new System.Drawing.Point(535, 144);
            this.btmGiveUp.Name = "btmGiveUp";
            this.btmGiveUp.Size = new System.Drawing.Size(100, 30);
            this.btmGiveUp.TabIndex = 22;
            this.btmGiveUp.Text = "Give Up";
            this.btmGiveUp.UseVisualStyleBackColor = true;
            this.btmGiveUp.Click += new System.EventHandler(this.btmGiveUp_Click);
            // 
            // btmRule
            // 
            this.btmRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmRule.Location = new System.Drawing.Point(939, 144);
            this.btmRule.Name = "btmRule";
            this.btmRule.Size = new System.Drawing.Size(100, 30);
            this.btmRule.TabIndex = 23;
            this.btmRule.Text = "How to play";
            this.btmRule.UseVisualStyleBackColor = true;
            this.btmRule.Click += new System.EventHandler(this.btmRule_Click);
            // 
            // pic3
            // 
            this.pic3.Image = global::WindowsFormsApp1.Properties.Resources.Disk_3;
            this.pic3.Location = new System.Drawing.Point(768, 357);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(214, 20);
            this.pic3.TabIndex = 16;
            this.pic3.TabStop = false;
            this.pic3.Tag = "3";
            this.pic3.Visible = false;
            this.pic3.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic4
            // 
            this.pic4.Image = global::WindowsFormsApp1.Properties.Resources.Disk_4;
            this.pic4.Location = new System.Drawing.Point(768, 383);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(214, 20);
            this.pic4.TabIndex = 15;
            this.pic4.TabStop = false;
            this.pic4.Tag = "4";
            this.pic4.Visible = false;
            this.pic4.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic5
            // 
            this.pic5.Image = global::WindowsFormsApp1.Properties.Resources.Disk_5;
            this.pic5.Location = new System.Drawing.Point(768, 409);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(214, 20);
            this.pic5.TabIndex = 14;
            this.pic5.TabStop = false;
            this.pic5.Tag = "5";
            this.pic5.Visible = false;
            this.pic5.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic6
            // 
            this.pic6.Image = global::WindowsFormsApp1.Properties.Resources.Disk_6;
            this.pic6.Location = new System.Drawing.Point(768, 435);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(214, 20);
            this.pic6.TabIndex = 13;
            this.pic6.TabStop = false;
            this.pic6.Tag = "6";
            this.pic6.Visible = false;
            this.pic6.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic7
            // 
            this.pic7.Image = global::WindowsFormsApp1.Properties.Resources.Disk_7;
            this.pic7.Location = new System.Drawing.Point(768, 461);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(214, 20);
            this.pic7.TabIndex = 12;
            this.pic7.TabStop = false;
            this.pic7.Tag = "7";
            this.pic7.Visible = false;
            this.pic7.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic8
            // 
            this.pic8.Image = global::WindowsFormsApp1.Properties.Resources.Disk_8;
            this.pic8.Location = new System.Drawing.Point(768, 487);
            this.pic8.Name = "pic8";
            this.pic8.Size = new System.Drawing.Size(214, 20);
            this.pic8.TabIndex = 11;
            this.pic8.TabStop = false;
            this.pic8.Tag = "8";
            this.pic8.Visible = false;
            this.pic8.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic2
            // 
            this.pic2.Image = global::WindowsFormsApp1.Properties.Resources.Disk_2;
            this.pic2.Location = new System.Drawing.Point(526, 487);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(214, 20);
            this.pic2.TabIndex = 10;
            this.pic2.TabStop = false;
            this.pic2.Tag = "2";
            this.pic2.Visible = false;
            this.pic2.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic1
            // 
            this.pic1.Image = global::WindowsFormsApp1.Properties.Resources.Disk_1;
            this.pic1.Location = new System.Drawing.Point(284, 487);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(214, 20);
            this.pic1.TabIndex = 9;
            this.pic1.TabStop = false;
            this.pic1.Tag = "1";
            this.pic1.Visible = false;
            this.pic1.Click += new System.EventHandler(this.pic_Click);
            // 
            // picBoxRodC
            // 
            this.picBoxRodC.Image = global::WindowsFormsApp1.Properties.Resources.Rod_01;
            this.picBoxRodC.Location = new System.Drawing.Point(757, 280);
            this.picBoxRodC.Name = "picBoxRodC";
            this.picBoxRodC.Size = new System.Drawing.Size(236, 242);
            this.picBoxRodC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxRodC.TabIndex = 8;
            this.picBoxRodC.TabStop = false;
            this.picBoxRodC.Click += new System.EventHandler(this.picRod_Click);
            // 
            // picBoxRodB
            // 
            this.picBoxRodB.Image = global::WindowsFormsApp1.Properties.Resources.Rod_01;
            this.picBoxRodB.Location = new System.Drawing.Point(515, 280);
            this.picBoxRodB.Name = "picBoxRodB";
            this.picBoxRodB.Size = new System.Drawing.Size(236, 242);
            this.picBoxRodB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxRodB.TabIndex = 7;
            this.picBoxRodB.TabStop = false;
            this.picBoxRodB.Click += new System.EventHandler(this.picRod_Click);
            // 
            // picBoxRodA
            // 
            this.picBoxRodA.Image = global::WindowsFormsApp1.Properties.Resources.Rod_01;
            this.picBoxRodA.Location = new System.Drawing.Point(273, 280);
            this.picBoxRodA.Name = "picBoxRodA";
            this.picBoxRodA.Size = new System.Drawing.Size(236, 242);
            this.picBoxRodA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxRodA.TabIndex = 6;
            this.picBoxRodA.TabStop = false;
            this.picBoxRodA.Click += new System.EventHandler(this.picRod_Click);
            // 
            // btmHint
            // 
            this.btmHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmHint.Location = new System.Drawing.Point(738, 144);
            this.btmHint.Name = "btmHint";
            this.btmHint.Size = new System.Drawing.Size(100, 30);
            this.btmHint.TabIndex = 24;
            this.btmHint.Text = "Hint";
            this.btmHint.UseVisualStyleBackColor = true;
            this.btmHint.Click += new System.EventHandler(this.btmHint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1155, 580);
            this.Controls.Add(this.btmHint);
            this.Controls.Add(this.btmRule);
            this.Controls.Add(this.btmGiveUp);
            this.Controls.Add(this.btmPlay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudLevel);
            this.Controls.Add(this.lblMove);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic7);
            this.Controls.Add(this.pic8);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.picBoxRodC);
            this.Controls.Add(this.picBoxRodB);
            this.Controls.Add(this.picBoxRodA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hanoi";
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRodC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRodB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRodA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBoxRodA;
        private System.Windows.Forms.PictureBox picBoxRodB;
        private System.Windows.Forms.PictureBox picBoxRodC;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic8;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrCountTime;
        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btmPlay;
        private System.Windows.Forms.Button btmGiveUp;
        private System.Windows.Forms.Button btmRule;
        private System.Windows.Forms.Button btmHint;
    }
}

