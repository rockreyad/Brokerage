namespace Broker_Management
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.financeButton = new FontAwesome.Sharp.IconButton();
            this.clientListButton = new FontAwesome.Sharp.IconButton();
            this.recordButton = new FontAwesome.Sharp.IconButton();
            this.addButton = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTransactions = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelTotalClient = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelincome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconButtonDeveloper = new FontAwesome.Sharp.IconButton();
            this.minimizeButton = new FontAwesome.Sharp.IconButton();
            this.closeButton = new FontAwesome.Sharp.IconButton();
            this.iconButtonEditTrac = new FontAwesome.Sharp.IconButton();
            this.iconButtonEditClient = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDashboard.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(224)))), ((int)(((byte)(240)))));
            this.panelMenu.Controls.Add(this.panelButtons);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(232, 661);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.iconButton6);
            this.panelButtons.Controls.Add(this.financeButton);
            this.panelButtons.Controls.Add(this.clientListButton);
            this.panelButtons.Controls.Add(this.recordButton);
            this.panelButtons.Controls.Add(this.addButton);
            this.panelButtons.Controls.Add(this.iconButton1);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(0, 100);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(232, 561);
            this.panelButtons.TabIndex = 1;
            this.panelButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.panelButtons_Paint);
            // 
            // iconButton6
            // 
            this.iconButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.iconButton6.FlatAppearance.BorderSize = 2;
            this.iconButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iconButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton6.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(25, 453);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(190, 70);
            this.iconButton6.TabIndex = 1;
            this.iconButton6.Text = "SIGN OUT";
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton6.UseVisualStyleBackColor = true;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // financeButton
            // 
            this.financeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(175)))), ((int)(((byte)(207)))));
            this.financeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.financeButton.FlatAppearance.BorderSize = 0;
            this.financeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.financeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(124)))), ((int)(((byte)(207)))));
            this.financeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.financeButton.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financeButton.ForeColor = System.Drawing.Color.White;
            this.financeButton.IconChar = FontAwesome.Sharp.IconChar.Poll;
            this.financeButton.IconColor = System.Drawing.Color.White;
            this.financeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.financeButton.IconSize = 45;
            this.financeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.financeButton.Location = new System.Drawing.Point(25, 363);
            this.financeButton.Name = "financeButton";
            this.financeButton.Size = new System.Drawing.Size(190, 70);
            this.financeButton.TabIndex = 0;
            this.financeButton.Text = "       FINANCE";
            this.financeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.financeButton.UseVisualStyleBackColor = false;
            this.financeButton.Click += new System.EventHandler(this.financeButton_Click);
            // 
            // clientListButton
            // 
            this.clientListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(182)))), ((int)(((byte)(207)))));
            this.clientListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientListButton.FlatAppearance.BorderSize = 0;
            this.clientListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clientListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(124)))), ((int)(((byte)(207)))));
            this.clientListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientListButton.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientListButton.ForeColor = System.Drawing.Color.White;
            this.clientListButton.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.clientListButton.IconColor = System.Drawing.Color.White;
            this.clientListButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clientListButton.IconSize = 45;
            this.clientListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientListButton.Location = new System.Drawing.Point(25, 278);
            this.clientListButton.Name = "clientListButton";
            this.clientListButton.Size = new System.Drawing.Size(190, 70);
            this.clientListButton.TabIndex = 0;
            this.clientListButton.Text = "       CLIENT LIST";
            this.clientListButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientListButton.UseVisualStyleBackColor = false;
            this.clientListButton.Click += new System.EventHandler(this.clientListButton_Click);
            // 
            // recordButton
            // 
            this.recordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(188)))), ((int)(((byte)(207)))));
            this.recordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recordButton.FlatAppearance.BorderSize = 0;
            this.recordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.recordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(124)))), ((int)(((byte)(207)))));
            this.recordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordButton.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordButton.ForeColor = System.Drawing.Color.White;
            this.recordButton.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.recordButton.IconColor = System.Drawing.Color.White;
            this.recordButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.recordButton.IconSize = 45;
            this.recordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recordButton.Location = new System.Drawing.Point(25, 192);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(190, 70);
            this.recordButton.TabIndex = 0;
            this.recordButton.Text = "       RECORD";
            this.recordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recordButton.UseVisualStyleBackColor = false;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(207)))), ((int)(((byte)(201)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(124)))), ((int)(((byte)(207)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addButton.IconColor = System.Drawing.Color.White;
            this.addButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addButton.IconSize = 45;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(25, 105);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(190, 70);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "       ADD";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 45;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(25, 19);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(190, 70);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "       DASHBOARD";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Broker_Management.Properties.Resources.brokerage;
            this.pictureBox1.Location = new System.Drawing.Point(25, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.White;
            this.panelDashboard.Controls.Add(this.panel3);
            this.panelDashboard.Controls.Add(this.panel2);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(232, 68);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(904, 593);
            this.panelDashboard.TabIndex = 2;
            this.panelDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDashboard_Paint);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Broker_Management.Properties.Resources.Rectangle_91;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.iconButtonEditClient);
            this.panel3.Controls.Add(this.iconButtonEditTrac);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(553, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 212);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(84)))), ((int)(((byte)(209)))));
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(0, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(339, 36);
            this.panel5.TabIndex = 0;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(149, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Menu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Broker_Management.Properties.Resources.Rectangle_91;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.labelTransactions);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.labelTotalClient);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.labelTimer);
            this.panel2.Location = new System.Drawing.Point(3, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 577);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labelTransactions
            // 
            this.labelTransactions.AutoSize = true;
            this.labelTransactions.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(82)))));
            this.labelTransactions.Location = new System.Drawing.Point(222, 463);
            this.labelTransactions.Name = "labelTransactions";
            this.labelTransactions.Size = new System.Drawing.Size(21, 18);
            this.labelTransactions.TabIndex = 3;
            this.labelTransactions.Text = "16";
            this.labelTransactions.Click += new System.EventHandler(this.label12_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(82)))));
            this.label10.Location = new System.Drawing.Point(376, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "70%";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // labelTotalClient
            // 
            this.labelTotalClient.AutoSize = true;
            this.labelTotalClient.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(82)))));
            this.labelTotalClient.Location = new System.Drawing.Point(78, 336);
            this.labelTotalClient.Name = "labelTotalClient";
            this.labelTotalClient.Size = new System.Drawing.Size(21, 18);
            this.labelTotalClient.TabIndex = 3;
            this.labelTotalClient.Text = "12";
            this.labelTotalClient.Click += new System.EventHandler(this.label8_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(82)))));
            this.label14.Location = new System.Drawing.Point(347, 523);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 14);
            this.label14.TabIndex = 3;
            this.label14.Text = "History of Last 30 Days";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(82)))));
            this.label11.Location = new System.Drawing.Point(249, 463);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "Transactions";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(82)))));
            this.label13.Location = new System.Drawing.Point(306, 336);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 18);
            this.label13.TabIndex = 3;
            this.label13.Text = "Average";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(82)))));
            this.label9.Location = new System.Drawing.Point(416, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Profit";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(82)))));
            this.label7.Location = new System.Drawing.Point(105, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "New Client Added";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Broker_Management.Properties.Resources.Statistics1;
            this.pictureBox2.Location = new System.Drawing.Point(51, 304);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(455, 156);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Broker_Management.Properties.Resources.Rectangle_12;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.labelincome);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(51, 179);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(427, 66);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // labelincome
            // 
            this.labelincome.AutoSize = true;
            this.labelincome.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelincome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.labelincome.Location = new System.Drawing.Point(182, 9);
            this.labelincome.Name = "labelincome";
            this.labelincome.Size = new System.Drawing.Size(175, 48);
            this.labelincome.TabIndex = 0;
            this.labelincome.Text = "12,065,000";
            this.labelincome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelincome.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(0, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 53);
            this.label5.TabIndex = 0;
            this.label5.Text = "Income :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Calibri", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(62)))));
            this.labelTimer.Location = new System.Drawing.Point(26, 10);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(494, 146);
            this.labelTimer.TabIndex = 0;
            this.labelTimer.Text = "00:00:00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTimer.Click += new System.EventHandler(this.labelTimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "DASHBOARD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(671, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hi,";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(718, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "PRITOM";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.iconButtonDeveloper);
            this.panelTitleBar.Controls.Add(this.label3);
            this.panelTitleBar.Controls.Add(this.label2);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.minimizeButton);
            this.panelTitleBar.Controls.Add(this.closeButton);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(232, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(904, 68);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown_1);
            // 
            // iconButtonDeveloper
            // 
            this.iconButtonDeveloper.BackgroundImage = global::Broker_Management.Properties.Resources.info;
            this.iconButtonDeveloper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconButtonDeveloper.FlatAppearance.BorderSize = 0;
            this.iconButtonDeveloper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDeveloper.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonDeveloper.IconColor = System.Drawing.Color.Black;
            this.iconButtonDeveloper.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDeveloper.IconSize = 20;
            this.iconButtonDeveloper.Location = new System.Drawing.Point(189, 27);
            this.iconButtonDeveloper.Name = "iconButtonDeveloper";
            this.iconButtonDeveloper.Size = new System.Drawing.Size(35, 35);
            this.iconButtonDeveloper.TabIndex = 2;
            this.iconButtonDeveloper.UseVisualStyleBackColor = true;
            this.iconButtonDeveloper.Click += new System.EventHandler(this.iconButtonDeveloper_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.AutoSize = true;
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.minimizeButton.IconColor = System.Drawing.Color.White;
            this.minimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeButton.IconSize = 25;
            this.minimizeButton.Location = new System.Drawing.Point(808, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(50, 32);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.closeButton.IconColor = System.Drawing.Color.White;
            this.closeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeButton.IconSize = 25;
            this.closeButton.Location = new System.Drawing.Point(854, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 32);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // iconButtonEditTrac
            // 
            this.iconButtonEditTrac.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonEditTrac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButtonEditTrac.FlatAppearance.BorderSize = 0;
            this.iconButtonEditTrac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(83)))), ((int)(((byte)(113)))));
            this.iconButtonEditTrac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(184)))), ((int)(((byte)(141)))));
            this.iconButtonEditTrac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEditTrac.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonEditTrac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(25)))), ((int)(((byte)(130)))));
            this.iconButtonEditTrac.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.iconButtonEditTrac.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(25)))), ((int)(((byte)(130)))));
            this.iconButtonEditTrac.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEditTrac.IconSize = 40;
            this.iconButtonEditTrac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEditTrac.Location = new System.Drawing.Point(15, 79);
            this.iconButtonEditTrac.Name = "iconButtonEditTrac";
            this.iconButtonEditTrac.Size = new System.Drawing.Size(198, 36);
            this.iconButtonEditTrac.TabIndex = 1;
            this.iconButtonEditTrac.Text = "Edit Transaction";
            this.iconButtonEditTrac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonEditTrac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEditTrac.UseVisualStyleBackColor = false;
            // 
            // iconButtonEditClient
            // 
            this.iconButtonEditClient.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonEditClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButtonEditClient.FlatAppearance.BorderSize = 0;
            this.iconButtonEditClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(83)))), ((int)(((byte)(113)))));
            this.iconButtonEditClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(184)))), ((int)(((byte)(141)))));
            this.iconButtonEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEditClient.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonEditClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(25)))), ((int)(((byte)(130)))));
            this.iconButtonEditClient.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.iconButtonEditClient.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(25)))), ((int)(((byte)(130)))));
            this.iconButtonEditClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEditClient.IconSize = 40;
            this.iconButtonEditClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEditClient.Location = new System.Drawing.Point(15, 131);
            this.iconButtonEditClient.Name = "iconButtonEditClient";
            this.iconButtonEditClient.Size = new System.Drawing.Size(198, 36);
            this.iconButtonEditClient.TabIndex = 1;
            this.iconButtonEditClient.Text = "Edit Client";
            this.iconButtonEditClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonEditClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEditClient.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1136, 661);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDashboard.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Panel panelButtons;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton financeButton;
        private FontAwesome.Sharp.IconButton clientListButton;
        private FontAwesome.Sharp.IconButton recordButton;
        private FontAwesome.Sharp.IconButton addButton;
        private FontAwesome.Sharp.IconButton iconButton6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton closeButton;
        private FontAwesome.Sharp.IconButton minimizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelincome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelTransactions;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelTotalClient;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iconButtonDeveloper;
        private FontAwesome.Sharp.IconButton iconButtonEditTrac;
        private FontAwesome.Sharp.IconButton iconButtonEditClient;
    }
}

