namespace Broker_Management
{
    partial class NewBroker
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
            this.textBoxUName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxUPass = new System.Windows.Forms.TextBox();
            this.buttonNewBroker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUName
            // 
            this.textBoxUName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBoxUName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUName.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.textBoxUName.HideSelection = false;
            this.textBoxUName.Location = new System.Drawing.Point(34, 74);
            this.textBoxUName.Name = "textBoxUName";
            this.textBoxUName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxUName.Size = new System.Drawing.Size(242, 26);
            this.textBoxUName.TabIndex = 3;
            this.textBoxUName.Text = "User Name";
            this.textBoxUName.WordWrap = false;
            this.textBoxUName.Enter += new System.EventHandler(this.textBoxUName_Enter);
            this.textBoxUName.Leave += new System.EventHandler(this.textBoxUName_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Broker_Management.Properties.Resources.Rectangle_14;
            this.pictureBox2.Location = new System.Drawing.Point(22, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(12)))), ((int)(((byte)(92)))));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(12)))), ((int)(((byte)(54)))));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(313, 39);
            this.panelTop.TabIndex = 5;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a New Broker";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Broker_Management.Properties.Resources.Rectangle_14;
            this.pictureBox1.Location = new System.Drawing.Point(22, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxUPass
            // 
            this.textBoxUPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.textBoxUPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUPass.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.textBoxUPass.HideSelection = false;
            this.textBoxUPass.Location = new System.Drawing.Point(34, 136);
            this.textBoxUPass.Name = "textBoxUPass";
            this.textBoxUPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxUPass.Size = new System.Drawing.Size(242, 26);
            this.textBoxUPass.TabIndex = 3;
            this.textBoxUPass.Text = "User Password";
            this.textBoxUPass.WordWrap = false;
            this.textBoxUPass.Enter += new System.EventHandler(this.textBoxUPass_Enter);
            this.textBoxUPass.Leave += new System.EventHandler(this.textBoxUPass_Leave);
            // 
            // buttonNewBroker
            // 
            this.buttonNewBroker.BackgroundImage = global::Broker_Management.Properties.Resources.Rectangle_20;
            this.buttonNewBroker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNewBroker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewBroker.FlatAppearance.BorderSize = 0;
            this.buttonNewBroker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewBroker.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewBroker.ForeColor = System.Drawing.Color.White;
            this.buttonNewBroker.Location = new System.Drawing.Point(187, 195);
            this.buttonNewBroker.Name = "buttonNewBroker";
            this.buttonNewBroker.Size = new System.Drawing.Size(99, 44);
            this.buttonNewBroker.TabIndex = 6;
            this.buttonNewBroker.Text = "ADD";
            this.buttonNewBroker.UseVisualStyleBackColor = true;
            this.buttonNewBroker.Click += new System.EventHandler(this.buttonNewBroker_Click);
            // 
            // NewBroker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 251);
            this.Controls.Add(this.buttonNewBroker);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.textBoxUPass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxUName);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewBroker";
            this.Text = "NewBroker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxUPass;
        private System.Windows.Forms.Button buttonNewBroker;
        private System.Windows.Forms.Label label1;
    }
}