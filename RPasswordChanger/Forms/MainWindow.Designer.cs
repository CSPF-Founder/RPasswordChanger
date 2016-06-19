namespace RPasswordChanger.Forms
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainMenuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.passwordChangeTab = new System.Windows.Forms.TabPage();
            this.enableComputerButton = new System.Windows.Forms.Button();
            this.disableComputerButton = new System.Windows.Forms.Button();
            this.selectAllComputersCheckbox = new System.Windows.Forms.CheckBox();
            this.removeComputer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.defaultAdminRadio = new System.Windows.Forms.RadioButton();
            this.allAdminsRadio = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.waitMessageLabel = new System.Windows.Forms.Label();
            this.passwordProgress = new System.Windows.Forms.ProgressBar();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adDomainBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adCredButton = new System.Windows.Forms.Button();
            this.adPasswordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adUsernameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.computersCheckBox = new System.Windows.Forms.CheckedListBox();
            this.computerRetrieveTab = new System.Windows.Forms.TabPage();
            this.browseListButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.domainTextBox = new System.Windows.Forms.TextBox();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.getComputerListButton = new System.Windows.Forms.Button();
            this.passwordsTab = new System.Windows.Forms.TabPage();
            this.passwordsGridView = new System.Windows.Forms.DataGridView();
            this.systemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordsTabContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundListRetriever = new System.ComponentModel.BackgroundWorker();
            this.openListFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.passwordWorker = new System.ComponentModel.BackgroundWorker();
            this.exportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.loadListFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuBar.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.passwordChangeTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.computerRetrieveTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.passwordsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsGridView)).BeginInit();
            this.passwordsTabContextMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuBar
            // 
            this.mainMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuBar.Location = new System.Drawing.Point(0, 0);
            this.mainMenuBar.Name = "mainMenuBar";
            this.mainMenuBar.Size = new System.Drawing.Size(965, 24);
            this.mainMenuBar.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadListFromFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.passwordChangeTab);
            this.mainTabControl.Controls.Add(this.computerRetrieveTab);
            this.mainTabControl.Controls.Add(this.passwordsTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 24);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(965, 432);
            this.mainTabControl.TabIndex = 1;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            // 
            // passwordChangeTab
            // 
            this.passwordChangeTab.Controls.Add(this.enableComputerButton);
            this.passwordChangeTab.Controls.Add(this.disableComputerButton);
            this.passwordChangeTab.Controls.Add(this.selectAllComputersCheckbox);
            this.passwordChangeTab.Controls.Add(this.removeComputer);
            this.passwordChangeTab.Controls.Add(this.groupBox1);
            this.passwordChangeTab.Controls.Add(this.label5);
            this.passwordChangeTab.Controls.Add(this.waitMessageLabel);
            this.passwordChangeTab.Controls.Add(this.passwordProgress);
            this.passwordChangeTab.Controls.Add(this.changePasswordButton);
            this.passwordChangeTab.Controls.Add(this.panel1);
            this.passwordChangeTab.Controls.Add(this.label1);
            this.passwordChangeTab.Controls.Add(this.computersCheckBox);
            this.passwordChangeTab.Location = new System.Drawing.Point(4, 22);
            this.passwordChangeTab.Name = "passwordChangeTab";
            this.passwordChangeTab.Padding = new System.Windows.Forms.Padding(3);
            this.passwordChangeTab.Size = new System.Drawing.Size(957, 406);
            this.passwordChangeTab.TabIndex = 0;
            this.passwordChangeTab.Text = "Change Password";
            this.passwordChangeTab.UseVisualStyleBackColor = true;
            // 
            // enableComputerButton
            // 
            this.enableComputerButton.Location = new System.Drawing.Point(118, 47);
            this.enableComputerButton.Name = "enableComputerButton";
            this.enableComputerButton.Size = new System.Drawing.Size(75, 23);
            this.enableComputerButton.TabIndex = 19;
            this.enableComputerButton.Text = "Enable";
            this.enableComputerButton.UseVisualStyleBackColor = true;
            this.enableComputerButton.Click += new System.EventHandler(this.enableComputerButton_Click);
            // 
            // disableComputerButton
            // 
            this.disableComputerButton.Location = new System.Drawing.Point(199, 47);
            this.disableComputerButton.Name = "disableComputerButton";
            this.disableComputerButton.Size = new System.Drawing.Size(75, 23);
            this.disableComputerButton.TabIndex = 18;
            this.disableComputerButton.Text = "Disable";
            this.disableComputerButton.UseVisualStyleBackColor = true;
            this.disableComputerButton.Click += new System.EventHandler(this.disableComputerButton_Click);
            // 
            // selectAllComputersCheckbox
            // 
            this.selectAllComputersCheckbox.AutoSize = true;
            this.selectAllComputersCheckbox.Location = new System.Drawing.Point(67, 52);
            this.selectAllComputersCheckbox.Name = "selectAllComputersCheckbox";
            this.selectAllComputersCheckbox.Size = new System.Drawing.Size(15, 14);
            this.selectAllComputersCheckbox.TabIndex = 17;
            this.selectAllComputersCheckbox.UseVisualStyleBackColor = true;
            this.selectAllComputersCheckbox.Click += new System.EventHandler(this.selectAllComputersCheckbox_Click);
            // 
            // removeComputer
            // 
            this.removeComputer.Location = new System.Drawing.Point(280, 46);
            this.removeComputer.Name = "removeComputer";
            this.removeComputer.Size = new System.Drawing.Size(75, 23);
            this.removeComputer.TabIndex = 16;
            this.removeComputer.Text = "Remove";
            this.removeComputer.UseVisualStyleBackColor = true;
            this.removeComputer.Click += new System.EventHandler(this.removeComputer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.defaultAdminRadio);
            this.groupBox1.Controls.Add(this.allAdminsRadio);
            this.groupBox1.Location = new System.Drawing.Point(469, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 48);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // defaultAdminRadio
            // 
            this.defaultAdminRadio.AutoSize = true;
            this.defaultAdminRadio.Checked = true;
            this.defaultAdminRadio.Location = new System.Drawing.Point(19, 19);
            this.defaultAdminRadio.Name = "defaultAdminRadio";
            this.defaultAdminRadio.Size = new System.Drawing.Size(115, 17);
            this.defaultAdminRadio.TabIndex = 13;
            this.defaultAdminRadio.TabStop = true;
            this.defaultAdminRadio.Text = "Only Default Admin";
            this.defaultAdminRadio.UseVisualStyleBackColor = true;
            // 
            // allAdminsRadio
            // 
            this.allAdminsRadio.AutoSize = true;
            this.allAdminsRadio.Location = new System.Drawing.Point(155, 19);
            this.allAdminsRadio.Name = "allAdminsRadio";
            this.allAdminsRadio.Size = new System.Drawing.Size(98, 17);
            this.allAdminsRadio.TabIndex = 14;
            this.allAdminsRadio.TabStop = true;
            this.allAdminsRadio.Text = "All local Admins";
            this.allAdminsRadio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Computers List:";
            // 
            // waitMessageLabel
            // 
            this.waitMessageLabel.AutoSize = true;
            this.waitMessageLabel.Location = new System.Drawing.Point(469, 363);
            this.waitMessageLabel.Name = "waitMessageLabel";
            this.waitMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.waitMessageLabel.TabIndex = 11;
            // 
            // passwordProgress
            // 
            this.passwordProgress.Location = new System.Drawing.Point(469, 337);
            this.passwordProgress.Name = "passwordProgress";
            this.passwordProgress.Size = new System.Drawing.Size(297, 23);
            this.passwordProgress.TabIndex = 10;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(469, 271);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(297, 48);
            this.changePasswordButton.TabIndex = 9;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adDomainBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.adCredButton);
            this.panel1.Controls.Add(this.adPasswordBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.adUsernameBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(469, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 132);
            this.panel1.TabIndex = 8;
            // 
            // adDomainBox
            // 
            this.adDomainBox.Location = new System.Drawing.Point(91, 79);
            this.adDomainBox.Name = "adDomainBox";
            this.adDomainBox.Size = new System.Drawing.Size(190, 20);
            this.adDomainBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "AD Domain";
            // 
            // adCredButton
            // 
            this.adCredButton.Location = new System.Drawing.Point(91, 106);
            this.adCredButton.Name = "adCredButton";
            this.adCredButton.Size = new System.Drawing.Size(75, 23);
            this.adCredButton.TabIndex = 4;
            this.adCredButton.Text = "Set";
            this.adCredButton.UseVisualStyleBackColor = true;
            this.adCredButton.Click += new System.EventHandler(this.adCredButton_Click);
            // 
            // adPasswordBox
            // 
            this.adPasswordBox.Location = new System.Drawing.Point(91, 51);
            this.adPasswordBox.Name = "adPasswordBox";
            this.adPasswordBox.PasswordChar = '*';
            this.adPasswordBox.Size = new System.Drawing.Size(190, 20);
            this.adPasswordBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AD Password";
            // 
            // adUsernameBox
            // 
            this.adUsernameBox.Location = new System.Drawing.Point(91, 21);
            this.adUsernameBox.Name = "adUsernameBox";
            this.adUsernameBox.Size = new System.Drawing.Size(190, 20);
            this.adUsernameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "AD Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, -24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Computers List:";
            // 
            // computersCheckBox
            // 
            this.computersCheckBox.CheckOnClick = true;
            this.computersCheckBox.FormattingEnabled = true;
            this.computersCheckBox.Location = new System.Drawing.Point(67, 75);
            this.computersCheckBox.Name = "computersCheckBox";
            this.computersCheckBox.Size = new System.Drawing.Size(288, 289);
            this.computersCheckBox.TabIndex = 6;
            // 
            // computerRetrieveTab
            // 
            this.computerRetrieveTab.Controls.Add(this.browseListButton);
            this.computerRetrieveTab.Controls.Add(this.label11);
            this.computerRetrieveTab.Controls.Add(this.label10);
            this.computerRetrieveTab.Controls.Add(this.loadingLabel);
            this.computerRetrieveTab.Controls.Add(this.tableLayoutPanel1);
            this.computerRetrieveTab.Location = new System.Drawing.Point(4, 22);
            this.computerRetrieveTab.Name = "computerRetrieveTab";
            this.computerRetrieveTab.Padding = new System.Windows.Forms.Padding(3);
            this.computerRetrieveTab.Size = new System.Drawing.Size(957, 406);
            this.computerRetrieveTab.TabIndex = 1;
            this.computerRetrieveTab.Text = "Get Computers List";
            this.computerRetrieveTab.UseVisualStyleBackColor = true;
            // 
            // browseListButton
            // 
            this.browseListButton.Location = new System.Drawing.Point(293, 42);
            this.browseListButton.Name = "browseListButton";
            this.browseListButton.Size = new System.Drawing.Size(262, 30);
            this.browseListButton.TabIndex = 6;
            this.browseListButton.Text = "Browse ..";
            this.browseListButton.UseVisualStyleBackColor = true;
            this.browseListButton.Click += new System.EventHandler(this.browseListButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(82, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Load Computers List from File :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(82, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(273, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Retrieve Computers List from Active Directory :";
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Location = new System.Drawing.Point(261, 322);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(0, 13);
            this.loadingLabel.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.domainTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ipTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.usernameTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.passwordTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.getComputerListButton, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(197, 135);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(512, 161);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Domain";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Server IP";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Username";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Password";
            // 
            // domainTextBox
            // 
            this.domainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.domainTextBox.Location = new System.Drawing.Point(64, 3);
            this.domainTextBox.Name = "domainTextBox";
            this.domainTextBox.Size = new System.Drawing.Size(445, 20);
            this.domainTextBox.TabIndex = 4;
            // 
            // ipTextBox
            // 
            this.ipTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipTextBox.Location = new System.Drawing.Point(64, 29);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(445, 20);
            this.ipTextBox.TabIndex = 5;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.Location = new System.Drawing.Point(64, 55);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(445, 20);
            this.usernameTextBox.TabIndex = 6;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(64, 81);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(445, 20);
            this.passwordTextBox.TabIndex = 7;
            // 
            // getComputerListButton
            // 
            this.getComputerListButton.Location = new System.Drawing.Point(64, 107);
            this.getComputerListButton.Name = "getComputerListButton";
            this.getComputerListButton.Size = new System.Drawing.Size(445, 36);
            this.getComputerListButton.TabIndex = 8;
            this.getComputerListButton.Text = "Get Computers List";
            this.getComputerListButton.UseVisualStyleBackColor = true;
            this.getComputerListButton.Click += new System.EventHandler(this.getComputerListButton_Click);
            // 
            // passwordsTab
            // 
            this.passwordsTab.Controls.Add(this.passwordsGridView);
            this.passwordsTab.Location = new System.Drawing.Point(4, 22);
            this.passwordsTab.Name = "passwordsTab";
            this.passwordsTab.Padding = new System.Windows.Forms.Padding(3);
            this.passwordsTab.Size = new System.Drawing.Size(957, 406);
            this.passwordsTab.TabIndex = 2;
            this.passwordsTab.Text = "View Passwords";
            this.passwordsTab.UseVisualStyleBackColor = true;
            // 
            // passwordsGridView
            // 
            this.passwordsGridView.AllowUserToAddRows = false;
            this.passwordsGridView.AllowUserToDeleteRows = false;
            this.passwordsGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passwordsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.systemName,
            this.Username,
            this.Password,
            this.modifiedDate,
            this.status});
            this.passwordsGridView.ContextMenuStrip = this.passwordsTabContextMenu;
            this.passwordsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordsGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordsGridView.Location = new System.Drawing.Point(3, 3);
            this.passwordsGridView.Name = "passwordsGridView";
            this.passwordsGridView.ReadOnly = true;
            this.passwordsGridView.RowHeadersVisible = false;
            this.passwordsGridView.Size = new System.Drawing.Size(951, 400);
            this.passwordsGridView.TabIndex = 1;
            // 
            // systemName
            // 
            this.systemName.HeaderText = "System";
            this.systemName.Name = "systemName";
            this.systemName.ReadOnly = true;
            this.systemName.Width = 200;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 200;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 150;
            // 
            // modifiedDate
            // 
            this.modifiedDate.HeaderText = "Modified Date";
            this.modifiedDate.Name = "modifiedDate";
            this.modifiedDate.ReadOnly = true;
            this.modifiedDate.Width = 150;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // passwordsTabContextMenu
            // 
            this.passwordsTabContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.passwordsTabContextMenu.Name = "contextMenuStrip1";
            this.passwordsTabContextMenu.Size = new System.Drawing.Size(108, 26);
            this.passwordsTabContextMenu.Click += new System.EventHandler(this.passwordsTabContextMenu_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // backgroundListRetriever
            // 
            this.backgroundListRetriever.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundListRetriever_DoWork);
            this.backgroundListRetriever.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundListRetriever_RunWorkerCompleted);
            // 
            // passwordWorker
            // 
            this.passwordWorker.WorkerReportsProgress = true;
            this.passwordWorker.WorkerSupportsCancellation = true;
            this.passwordWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.passwordWorker_DoWork);
            this.passwordWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.passwordWorker_ProgressChanged);
            this.passwordWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.passwordWorker_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(965, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // loadListFromFileToolStripMenuItem
            // 
            this.loadListFromFileToolStripMenuItem.Name = "loadListFromFileToolStripMenuItem";
            this.loadListFromFileToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.loadListFromFileToolStripMenuItem.Text = "Load list from file";
            this.loadListFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadListFromFileToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 456);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainMenuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuBar;
            this.Name = "MainWindow";
            this.Text = "RPasswordChanger";
            this.mainMenuBar.ResumeLayout(false);
            this.mainMenuBar.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.passwordChangeTab.ResumeLayout(false);
            this.passwordChangeTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.computerRetrieveTab.ResumeLayout(false);
            this.computerRetrieveTab.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.passwordsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passwordsGridView)).EndInit();
            this.passwordsTabContextMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage passwordChangeTab;
        private System.Windows.Forms.TabPage computerRetrieveTab;
        private System.Windows.Forms.Label waitMessageLabel;
        private System.Windows.Forms.ProgressBar passwordProgress;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox adDomainBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button adCredButton;
        private System.Windows.Forms.TextBox adPasswordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adUsernameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox computersCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox domainTextBox;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button getComputerListButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button browseListButton;
        private System.Windows.Forms.TabPage passwordsTab;
        private System.Windows.Forms.DataGridView passwordsGridView;
        private System.ComponentModel.BackgroundWorker backgroundListRetriever;
        private System.Windows.Forms.OpenFileDialog openListFileDialog;
        private System.ComponentModel.BackgroundWorker passwordWorker;
        private System.Windows.Forms.SaveFileDialog exportFileDialog;
        private System.Windows.Forms.ContextMenuStrip passwordsTabContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.RadioButton defaultAdminRadio;
        private System.Windows.Forms.RadioButton allAdminsRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button removeComputer;
        private System.Windows.Forms.CheckBox selectAllComputersCheckbox;
        private System.Windows.Forms.Button disableComputerButton;
        private System.Windows.Forms.Button enableComputerButton;
        private System.Windows.Forms.ToolStripMenuItem loadListFromFileToolStripMenuItem;

    }
}

