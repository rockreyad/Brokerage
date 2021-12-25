namespace Broker_Management
{
    partial class AdminLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButtonShowPass = new FontAwesome.Sharp.IconButton();
            this.textBoxSKey = new System.Windows.Forms.TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUnlockAdmin = new System.Windows.Forms.Button();
            this.iconButtonBack = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Broker_Management.Properties.Resources.brokerage_white;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // iconButtonShowPass
            // 
            this.iconButtonShowPass.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonShowPass.BackgroundImage = global::Broker_Management.Properties.Resources.eye;
            this.iconButtonShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconButtonShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonShowPass.FlatAppearance.BorderSize = 0;
            this.iconButtonShowPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButtonShowPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButtonShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonShowPass.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonShowPass.IconColor = System.Drawing.Color.Black;
            this.iconButtonShowPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonShowPass.Location = new System.Drawing.Point(336, 17);
            this.iconButtonShowPass.Name = "iconButtonShowPass";
            this.iconButtonShowPass.Size = new System.Drawing.Size(30, 30);
            this.iconButtonShowPass.TabIndex = 3;
            this.iconButtonShowPass.UseVisualStyleBackColor = false;
            this.iconButtonShowPass.Click += new System.EventHandler(this.iconButtonShowPass_Click);
            // 
            // textBoxSKey
            // 
            this.textBoxSKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBoxSKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSKey.Font = new System.Drawing.Font("Bahnschrift Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.textBoxSKey.Location = new System.Drawing.Point(44, 17);
            this.textBoxSKey.MaxLength = 15;
            this.textBoxSKey.Name = "textBoxSKey";
            this.textBoxSKey.Size = new System.Drawing.Size(286, 29);
            this.textBoxSKey.TabIndex = 2;
            this.textBoxSKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSKey.UseSystemPasswordChar = true;
            this.textBoxSKey.WordWrap = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.BackgroundImage = global::Broker_Management.Properties.Resources.key;
            this.iconPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 35;
            this.iconPictureBox2.Location = new System.Drawing.Point(3, 12);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(35, 35);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox2.TabIndex = 0;
            this.iconPictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Broker_Management.Properties.Resources.Rectangle_14;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.iconButtonShowPass);
            this.panel2.Controls.Add(this.textBoxSKey);
            this.panel2.Controls.Add(this.iconPictureBox2);
            this.panel2.Location = new System.Drawing.Point(75, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 59);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(123, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Encryption Key";
            // 
            // buttonUnlockAdmin
            // 
            this.buttonUnlockAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(207)))), ((int)(((byte)(201)))));
            this.buttonUnlockAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUnlockAdmin.FlatAppearance.BorderSize = 0;
            this.buttonUnlockAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonUnlockAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(124)))), ((int)(((byte)(207)))));
            this.buttonUnlockAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnlockAdmin.Font = new System.Drawing.Font("Bahnschrift SemiLight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnlockAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUnlockAdmin.Location = new System.Drawing.Point(260, 254);
            this.buttonUnlockAdmin.Name = "buttonUnlockAdmin";
            this.buttonUnlockAdmin.Size = new System.Drawing.Size(195, 56);
            this.buttonUnlockAdmin.TabIndex = 10;
            this.buttonUnlockAdmin.Text = "Unlock Admin Area";
            this.buttonUnlockAdmin.UseVisualStyleBackColor = false;
            this.buttonUnlockAdmin.Click += new System.EventHandler(this.buttonUnlockAdmin_Click);
            // 
            // iconButtonBack
            // 
            this.iconButtonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.iconButtonBack.FlatAppearance.BorderSize = 0;
            this.iconButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBack.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBack.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.iconButtonBack.IconColor = System.Drawing.Color.Black;
            this.iconButtonBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBack.IconSize = 40;
            this.iconButtonBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBack.Location = new System.Drawing.Point(75, 254);
            this.iconButtonBack.Name = "iconButtonBack";
            this.iconButtonBack.Size = new System.Drawing.Size(132, 56);
            this.iconButtonBack.TabIndex = 11;
            this.iconButtonBack.Text = "Go Back";
            this.iconButtonBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonBack.UseVisualStyleBackColor = false;
            this.iconButtonBack.Click += new System.EventHandler(this.iconButtonBack_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(18)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(547, 367);
            this.Controls.Add(this.iconButtonBack);
            this.Controls.Add(this.buttonUnlockAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButtonShowPass;
        private System.Windows.Forms.TextBox textBoxSKey;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUnlockAdmin;
        private FontAwesome.Sharp.IconButton iconButtonBack;
    }
}