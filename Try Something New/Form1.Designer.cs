namespace Try_Something_New
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
            this.SocialEvent = new System.Windows.Forms.PictureBox();
            this.Games = new System.Windows.Forms.PictureBox();
            this.NewSkills = new System.Windows.Forms.PictureBox();
            this.Indoor = new System.Windows.Forms.PictureBox();
            this.OutDoor = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SocialEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Games)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewSkills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Indoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // SocialEvent
            // 
            this.SocialEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SocialEvent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SocialEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SocialEvent.Location = new System.Drawing.Point(13, 13);
            this.SocialEvent.Name = "SocialEvent";
            this.SocialEvent.Size = new System.Drawing.Size(232, 173);
            this.SocialEvent.TabIndex = 1;
            this.SocialEvent.TabStop = false;
            this.SocialEvent.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Games
            // 
            this.Games.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Games.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Games.Location = new System.Drawing.Point(251, 13);
            this.Games.Name = "Games";
            this.Games.Size = new System.Drawing.Size(253, 173);
            this.Games.TabIndex = 2;
            this.Games.TabStop = false;
            this.Games.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // NewSkills
            // 
            this.NewSkills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NewSkills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewSkills.Location = new System.Drawing.Point(510, 12);
            this.NewSkills.Name = "NewSkills";
            this.NewSkills.Size = new System.Drawing.Size(234, 174);
            this.NewSkills.TabIndex = 3;
            this.NewSkills.TabStop = false;
            this.NewSkills.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Indoor
            // 
            this.Indoor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Indoor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Indoor.Location = new System.Drawing.Point(12, 192);
            this.Indoor.Name = "Indoor";
            this.Indoor.Size = new System.Drawing.Size(233, 176);
            this.Indoor.TabIndex = 4;
            this.Indoor.TabStop = false;
            this.Indoor.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // OutDoor
            // 
            this.OutDoor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutDoor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OutDoor.Location = new System.Drawing.Point(511, 192);
            this.OutDoor.Name = "OutDoor";
            this.OutDoor.Size = new System.Drawing.Size(234, 176);
            this.OutDoor.TabIndex = 5;
            this.OutDoor.TabStop = false;
            this.OutDoor.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(13, 374);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(732, 140);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(251, 192);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(253, 176);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(764, 526);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.OutDoor);
            this.Controls.Add(this.Indoor);
            this.Controls.Add(this.NewSkills);
            this.Controls.Add(this.Games);
            this.Controls.Add(this.SocialEvent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Try Something New";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SocialEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Games)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewSkills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Indoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox SocialEvent;
        private System.Windows.Forms.PictureBox Games;
        private System.Windows.Forms.PictureBox NewSkills;
        private System.Windows.Forms.PictureBox Indoor;
        private System.Windows.Forms.PictureBox OutDoor;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

