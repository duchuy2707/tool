namespace Mytool
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
            this.darkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.rdiBackend = new DarkUI.Controls.DarkRadioButton();
            this.rdiWallet = new DarkUI.Controls.DarkRadioButton();
            this.rdiNewsfeed = new DarkUI.Controls.DarkRadioButton();
            this.rdiBusiness = new DarkUI.Controls.DarkRadioButton();
            this.txtMessenger = new DarkUI.Controls.DarkTextBox();
            this.btnUpcode = new DarkUI.Controls.DarkButton();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.txtBranchPush = new DarkUI.Controls.DarkTextBox();
            this.darkGroupBox2 = new DarkUI.Controls.DarkGroupBox();
            this.lblInfo = new DarkUI.Controls.DarkLabel();
            this.btnCreateComponent = new DarkUI.Controls.DarkButton();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.txtComponentName = new DarkUI.Controls.DarkTextBox();
            this.darkGroupBox3 = new DarkUI.Controls.DarkGroupBox();
            this.rdiPullBackend = new DarkUI.Controls.DarkRadioButton();
            this.rdiPullWallet = new DarkUI.Controls.DarkRadioButton();
            this.rdiPullNewsfeed = new DarkUI.Controls.DarkRadioButton();
            this.rdiPullBusiness = new DarkUI.Controls.DarkRadioButton();
            this.btnPullCode = new DarkUI.Controls.DarkButton();
            this.darkLabel5 = new DarkUI.Controls.DarkLabel();
            this.txtBranchPull = new DarkUI.Controls.DarkTextBox();
            this.darkGroupBox4 = new DarkUI.Controls.DarkGroupBox();
            this.btnActionDocker = new DarkUI.Controls.DarkButton();
            this.rdiStop = new DarkUI.Controls.DarkRadioButton();
            this.rdiRestart = new DarkUI.Controls.DarkRadioButton();
            this.rdiStart = new DarkUI.Controls.DarkRadioButton();
            this.darkLabel4 = new DarkUI.Controls.DarkLabel();
            this.darkGroupBox5 = new DarkUI.Controls.DarkGroupBox();
            this.rdiLogBackend = new DarkUI.Controls.DarkRadioButton();
            this.rdiLogWallet = new DarkUI.Controls.DarkRadioButton();
            this.rdiLogNewsfeed = new DarkUI.Controls.DarkRadioButton();
            this.rdiLogBusiness = new DarkUI.Controls.DarkRadioButton();
            this.btnGetLog = new DarkUI.Controls.DarkButton();
            this.darkLabel6 = new DarkUI.Controls.DarkLabel();
            this.txtBranchLog = new DarkUI.Controls.DarkTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.darkButton2 = new DarkUI.Controls.DarkButton();
            this.txtFileLanguage = new DarkUI.Controls.DarkTextBox();
            this.btnStartSerivce = new DarkUI.Controls.DarkButton();
            this.darkGroupBox6 = new DarkUI.Controls.DarkGroupBox();
            this.cbServer = new DarkUI.Controls.DarkCheckBox();
            this.cbClient = new DarkUI.Controls.DarkCheckBox();
            this.cbListFolderSource = new DarkUI.Controls.DarkComboBox();
            this.darkLabel7 = new DarkUI.Controls.DarkLabel();
            this.darkGroupBox7 = new DarkUI.Controls.DarkGroupBox();
            this.darkTreeView1 = new DarkUI.Controls.DarkTreeView();
            this.btnPull = new DarkUI.Controls.DarkButton();
            this.btnPush = new DarkUI.Controls.DarkButton();
            this.btnStart = new DarkUI.Controls.DarkButton();
            this.darkGroupBox8 = new DarkUI.Controls.DarkGroupBox();
            this.txtMess = new DarkUI.Controls.DarkTextBox();
            this.btnBash = new DarkUI.Controls.DarkButton();
            this.darkGroupBox1.SuspendLayout();
            this.darkGroupBox2.SuspendLayout();
            this.darkGroupBox3.SuspendLayout();
            this.darkGroupBox4.SuspendLayout();
            this.darkGroupBox5.SuspendLayout();
            this.darkGroupBox6.SuspendLayout();
            this.darkGroupBox7.SuspendLayout();
            this.darkGroupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // darkGroupBox1
            // 
            this.darkGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox1.Controls.Add(this.rdiBackend);
            this.darkGroupBox1.Controls.Add(this.rdiWallet);
            this.darkGroupBox1.Controls.Add(this.rdiNewsfeed);
            this.darkGroupBox1.Controls.Add(this.rdiBusiness);
            this.darkGroupBox1.Controls.Add(this.txtMessenger);
            this.darkGroupBox1.Controls.Add(this.btnUpcode);
            this.darkGroupBox1.Controls.Add(this.darkLabel2);
            this.darkGroupBox1.Controls.Add(this.darkLabel1);
            this.darkGroupBox1.Controls.Add(this.txtBranchPush);
            this.darkGroupBox1.Location = new System.Drawing.Point(12, 77);
            this.darkGroupBox1.Name = "darkGroupBox1";
            this.darkGroupBox1.Size = new System.Drawing.Size(514, 99);
            this.darkGroupBox1.TabIndex = 0;
            this.darkGroupBox1.TabStop = false;
            this.darkGroupBox1.Text = "Upcode to repo git";
            // 
            // rdiBackend
            // 
            this.rdiBackend.AutoSize = true;
            this.rdiBackend.Location = new System.Drawing.Point(323, 76);
            this.rdiBackend.Name = "rdiBackend";
            this.rdiBackend.Size = new System.Drawing.Size(68, 17);
            this.rdiBackend.TabIndex = 4;
            this.rdiBackend.TabStop = true;
            this.rdiBackend.Text = "Backend";
            this.rdiBackend.MouseCaptureChanged += new System.EventHandler(this.rdiBackend_MouseCaptureChanged);
            // 
            // rdiWallet
            // 
            this.rdiWallet.AutoSize = true;
            this.rdiWallet.Location = new System.Drawing.Point(264, 76);
            this.rdiWallet.Name = "rdiWallet";
            this.rdiWallet.Size = new System.Drawing.Size(55, 17);
            this.rdiWallet.TabIndex = 4;
            this.rdiWallet.TabStop = true;
            this.rdiWallet.Text = "Wallet";
            this.rdiWallet.MouseCaptureChanged += new System.EventHandler(this.rdiWallet_MouseCaptureChanged);
            // 
            // rdiNewsfeed
            // 
            this.rdiNewsfeed.AutoSize = true;
            this.rdiNewsfeed.Checked = true;
            this.rdiNewsfeed.Location = new System.Drawing.Point(188, 76);
            this.rdiNewsfeed.Name = "rdiNewsfeed";
            this.rdiNewsfeed.Size = new System.Drawing.Size(73, 17);
            this.rdiNewsfeed.TabIndex = 4;
            this.rdiNewsfeed.TabStop = true;
            this.rdiNewsfeed.Text = "Newsfeed";
            this.rdiNewsfeed.MouseCaptureChanged += new System.EventHandler(this.rdiNewsfeed_MouseCaptureChanged);
            // 
            // rdiBusiness
            // 
            this.rdiBusiness.AutoSize = true;
            this.rdiBusiness.Location = new System.Drawing.Point(117, 76);
            this.rdiBusiness.Name = "rdiBusiness";
            this.rdiBusiness.Size = new System.Drawing.Size(67, 17);
            this.rdiBusiness.TabIndex = 4;
            this.rdiBusiness.TabStop = true;
            this.rdiBusiness.Text = "Business";
            this.rdiBusiness.MouseCaptureChanged += new System.EventHandler(this.rdiBusiness_MouseCaptureChanged);
            // 
            // txtMessenger
            // 
            this.txtMessenger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtMessenger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessenger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtMessenger.Location = new System.Drawing.Point(126, 45);
            this.txtMessenger.Name = "txtMessenger";
            this.txtMessenger.Size = new System.Drawing.Size(265, 20);
            this.txtMessenger.TabIndex = 3;
            this.txtMessenger.Text = "update";
            this.txtMessenger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMessenger_KeyPress);
            this.txtMessenger.Leave += new System.EventHandler(this.txtMessenger_Leave);
            // 
            // btnUpcode
            // 
            this.btnUpcode.Location = new System.Drawing.Point(397, 19);
            this.btnUpcode.Name = "btnUpcode";
            this.btnUpcode.Padding = new System.Windows.Forms.Padding(5);
            this.btnUpcode.Size = new System.Drawing.Size(105, 64);
            this.btnUpcode.TabIndex = 2;
            this.btnUpcode.Text = "UpCode";
            this.btnUpcode.Click += new System.EventHandler(this.btnUpcode_Click);
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(52, 44);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(65, 13);
            this.darkLabel2.TabIndex = 1;
            this.darkLabel2.Text = "Messenger: ";
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(71, 21);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(47, 13);
            this.darkLabel1.TabIndex = 1;
            this.darkLabel1.Text = "Branch: ";
            // 
            // txtBranchPush
            // 
            this.txtBranchPush.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtBranchPush.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchPush.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtBranchPush.Location = new System.Drawing.Point(126, 19);
            this.txtBranchPush.Name = "txtBranchPush";
            this.txtBranchPush.Size = new System.Drawing.Size(265, 20);
            this.txtBranchPush.TabIndex = 0;
            this.txtBranchPush.Text = "dev-duchuy";
            this.txtBranchPush.Leave += new System.EventHandler(this.txtBranchPush_Leave);
            // 
            // darkGroupBox2
            // 
            this.darkGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox2.Controls.Add(this.lblInfo);
            this.darkGroupBox2.Controls.Add(this.btnCreateComponent);
            this.darkGroupBox2.Controls.Add(this.darkLabel3);
            this.darkGroupBox2.Controls.Add(this.txtComponentName);
            this.darkGroupBox2.Location = new System.Drawing.Point(12, 13);
            this.darkGroupBox2.Name = "darkGroupBox2";
            this.darkGroupBox2.Size = new System.Drawing.Size(514, 58);
            this.darkGroupBox2.TabIndex = 1;
            this.darkGroupBox2.TabStop = false;
            this.darkGroupBox2.Text = "Create file Component Knockout";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblInfo.Location = new System.Drawing.Point(126, 45);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 3;
            // 
            // btnCreateComponent
            // 
            this.btnCreateComponent.Location = new System.Drawing.Point(397, 20);
            this.btnCreateComponent.Name = "btnCreateComponent";
            this.btnCreateComponent.Padding = new System.Windows.Forms.Padding(5);
            this.btnCreateComponent.Size = new System.Drawing.Size(105, 23);
            this.btnCreateComponent.TabIndex = 2;
            this.btnCreateComponent.Text = "Create";
            this.btnCreateComponent.Click += new System.EventHandler(this.btnCreateComponent_Click);
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(22, 22);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(96, 13);
            this.darkLabel3.TabIndex = 1;
            this.darkLabel3.Text = "Component name: ";
            // 
            // txtComponentName
            // 
            this.txtComponentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtComponentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComponentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtComponentName.Location = new System.Drawing.Point(126, 20);
            this.txtComponentName.Name = "txtComponentName";
            this.txtComponentName.Size = new System.Drawing.Size(265, 20);
            this.txtComponentName.TabIndex = 0;
            this.txtComponentName.Enter += new System.EventHandler(this.txtComponentName_Enter);
            // 
            // darkGroupBox3
            // 
            this.darkGroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox3.Controls.Add(this.rdiPullBackend);
            this.darkGroupBox3.Controls.Add(this.rdiPullWallet);
            this.darkGroupBox3.Controls.Add(this.rdiPullNewsfeed);
            this.darkGroupBox3.Controls.Add(this.rdiPullBusiness);
            this.darkGroupBox3.Controls.Add(this.btnPullCode);
            this.darkGroupBox3.Controls.Add(this.darkLabel5);
            this.darkGroupBox3.Controls.Add(this.txtBranchPull);
            this.darkGroupBox3.Location = new System.Drawing.Point(12, 182);
            this.darkGroupBox3.Name = "darkGroupBox3";
            this.darkGroupBox3.Size = new System.Drawing.Size(514, 82);
            this.darkGroupBox3.TabIndex = 0;
            this.darkGroupBox3.TabStop = false;
            this.darkGroupBox3.Text = "Pull code from repo git";
            // 
            // rdiPullBackend
            // 
            this.rdiPullBackend.AutoSize = true;
            this.rdiPullBackend.Location = new System.Drawing.Point(321, 46);
            this.rdiPullBackend.Name = "rdiPullBackend";
            this.rdiPullBackend.Size = new System.Drawing.Size(68, 17);
            this.rdiPullBackend.TabIndex = 4;
            this.rdiPullBackend.TabStop = true;
            this.rdiPullBackend.Text = "Backend";
            this.rdiPullBackend.MouseCaptureChanged += new System.EventHandler(this.rdiPullBackend_MouseCaptureChanged);
            // 
            // rdiPullWallet
            // 
            this.rdiPullWallet.AutoSize = true;
            this.rdiPullWallet.Location = new System.Drawing.Point(263, 46);
            this.rdiPullWallet.Name = "rdiPullWallet";
            this.rdiPullWallet.Size = new System.Drawing.Size(55, 17);
            this.rdiPullWallet.TabIndex = 4;
            this.rdiPullWallet.TabStop = true;
            this.rdiPullWallet.Text = "Wallet";
            this.rdiPullWallet.MouseCaptureChanged += new System.EventHandler(this.rdiPullWallet_MouseCaptureChanged);
            // 
            // rdiPullNewsfeed
            // 
            this.rdiPullNewsfeed.AutoSize = true;
            this.rdiPullNewsfeed.Checked = true;
            this.rdiPullNewsfeed.Location = new System.Drawing.Point(188, 46);
            this.rdiPullNewsfeed.Name = "rdiPullNewsfeed";
            this.rdiPullNewsfeed.Size = new System.Drawing.Size(73, 17);
            this.rdiPullNewsfeed.TabIndex = 4;
            this.rdiPullNewsfeed.TabStop = true;
            this.rdiPullNewsfeed.Text = "Newsfeed";
            this.rdiPullNewsfeed.MouseCaptureChanged += new System.EventHandler(this.rdiPullNewsfeed_MouseCaptureChanged);
            // 
            // rdiPullBusiness
            // 
            this.rdiPullBusiness.AutoSize = true;
            this.rdiPullBusiness.Location = new System.Drawing.Point(117, 46);
            this.rdiPullBusiness.Name = "rdiPullBusiness";
            this.rdiPullBusiness.Size = new System.Drawing.Size(67, 17);
            this.rdiPullBusiness.TabIndex = 4;
            this.rdiPullBusiness.TabStop = true;
            this.rdiPullBusiness.Text = "Business";
            this.rdiPullBusiness.MouseCaptureChanged += new System.EventHandler(this.rdiPullBusiness_MouseCaptureChanged);
            // 
            // btnPullCode
            // 
            this.btnPullCode.Location = new System.Drawing.Point(397, 19);
            this.btnPullCode.Name = "btnPullCode";
            this.btnPullCode.Padding = new System.Windows.Forms.Padding(5);
            this.btnPullCode.Size = new System.Drawing.Size(105, 44);
            this.btnPullCode.TabIndex = 2;
            this.btnPullCode.Text = "Pull Code";
            this.btnPullCode.Click += new System.EventHandler(this.btnPullCode_Click);
            // 
            // darkLabel5
            // 
            this.darkLabel5.AutoSize = true;
            this.darkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel5.Location = new System.Drawing.Point(71, 21);
            this.darkLabel5.Name = "darkLabel5";
            this.darkLabel5.Size = new System.Drawing.Size(47, 13);
            this.darkLabel5.TabIndex = 1;
            this.darkLabel5.Text = "Branch: ";
            // 
            // txtBranchPull
            // 
            this.txtBranchPull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtBranchPull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchPull.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtBranchPull.Location = new System.Drawing.Point(126, 19);
            this.txtBranchPull.Name = "txtBranchPull";
            this.txtBranchPull.Size = new System.Drawing.Size(265, 20);
            this.txtBranchPull.TabIndex = 0;
            this.txtBranchPull.Text = "develop";
            this.txtBranchPull.Leave += new System.EventHandler(this.txtBranchPull_Leave);
            // 
            // darkGroupBox4
            // 
            this.darkGroupBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox4.Controls.Add(this.btnActionDocker);
            this.darkGroupBox4.Controls.Add(this.rdiStop);
            this.darkGroupBox4.Controls.Add(this.rdiRestart);
            this.darkGroupBox4.Controls.Add(this.rdiStart);
            this.darkGroupBox4.Controls.Add(this.darkLabel4);
            this.darkGroupBox4.Location = new System.Drawing.Point(12, 358);
            this.darkGroupBox4.Name = "darkGroupBox4";
            this.darkGroupBox4.Size = new System.Drawing.Size(514, 55);
            this.darkGroupBox4.TabIndex = 2;
            this.darkGroupBox4.TabStop = false;
            this.darkGroupBox4.Text = "Docker";
            // 
            // btnActionDocker
            // 
            this.btnActionDocker.Location = new System.Drawing.Point(397, 13);
            this.btnActionDocker.Name = "btnActionDocker";
            this.btnActionDocker.Padding = new System.Windows.Forms.Padding(5);
            this.btnActionDocker.Size = new System.Drawing.Size(105, 24);
            this.btnActionDocker.TabIndex = 2;
            this.btnActionDocker.Text = "Action";
            this.btnActionDocker.Click += new System.EventHandler(this.btnActionDocker_Click);
            // 
            // rdiStop
            // 
            this.rdiStop.AutoSize = true;
            this.rdiStop.Location = new System.Drawing.Point(299, 17);
            this.rdiStop.Name = "rdiStop";
            this.rdiStop.Size = new System.Drawing.Size(47, 17);
            this.rdiStop.TabIndex = 1;
            this.rdiStop.Text = "Stop";
            // 
            // rdiRestart
            // 
            this.rdiRestart.AutoSize = true;
            this.rdiRestart.Location = new System.Drawing.Point(222, 17);
            this.rdiRestart.Name = "rdiRestart";
            this.rdiRestart.Size = new System.Drawing.Size(59, 17);
            this.rdiRestart.TabIndex = 1;
            this.rdiRestart.Text = "Restart";
            // 
            // rdiStart
            // 
            this.rdiStart.AutoSize = true;
            this.rdiStart.Checked = true;
            this.rdiStart.Location = new System.Drawing.Point(154, 16);
            this.rdiStart.Name = "rdiStart";
            this.rdiStart.Size = new System.Drawing.Size(47, 17);
            this.rdiStart.TabIndex = 1;
            this.rdiStart.TabStop = true;
            this.rdiStart.Text = "Start";
            // 
            // darkLabel4
            // 
            this.darkLabel4.AutoSize = true;
            this.darkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel4.Location = new System.Drawing.Point(75, 17);
            this.darkLabel4.Name = "darkLabel4";
            this.darkLabel4.Size = new System.Drawing.Size(43, 13);
            this.darkLabel4.TabIndex = 0;
            this.darkLabel4.Text = "Action: ";
            // 
            // darkGroupBox5
            // 
            this.darkGroupBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox5.Controls.Add(this.rdiLogBackend);
            this.darkGroupBox5.Controls.Add(this.rdiLogWallet);
            this.darkGroupBox5.Controls.Add(this.rdiLogNewsfeed);
            this.darkGroupBox5.Controls.Add(this.rdiLogBusiness);
            this.darkGroupBox5.Controls.Add(this.btnGetLog);
            this.darkGroupBox5.Controls.Add(this.darkLabel6);
            this.darkGroupBox5.Controls.Add(this.txtBranchLog);
            this.darkGroupBox5.Location = new System.Drawing.Point(12, 270);
            this.darkGroupBox5.Name = "darkGroupBox5";
            this.darkGroupBox5.Size = new System.Drawing.Size(514, 82);
            this.darkGroupBox5.TabIndex = 4;
            this.darkGroupBox5.TabStop = false;
            this.darkGroupBox5.Text = "View log file changed";
            // 
            // rdiLogBackend
            // 
            this.rdiLogBackend.AutoSize = true;
            this.rdiLogBackend.Location = new System.Drawing.Point(321, 46);
            this.rdiLogBackend.Name = "rdiLogBackend";
            this.rdiLogBackend.Size = new System.Drawing.Size(68, 17);
            this.rdiLogBackend.TabIndex = 10;
            this.rdiLogBackend.TabStop = true;
            this.rdiLogBackend.Text = "Backend";
            // 
            // rdiLogWallet
            // 
            this.rdiLogWallet.AutoSize = true;
            this.rdiLogWallet.Location = new System.Drawing.Point(263, 46);
            this.rdiLogWallet.Name = "rdiLogWallet";
            this.rdiLogWallet.Size = new System.Drawing.Size(55, 17);
            this.rdiLogWallet.TabIndex = 10;
            this.rdiLogWallet.TabStop = true;
            this.rdiLogWallet.Text = "Wallet";
            // 
            // rdiLogNewsfeed
            // 
            this.rdiLogNewsfeed.AutoSize = true;
            this.rdiLogNewsfeed.Checked = true;
            this.rdiLogNewsfeed.Location = new System.Drawing.Point(188, 46);
            this.rdiLogNewsfeed.Name = "rdiLogNewsfeed";
            this.rdiLogNewsfeed.Size = new System.Drawing.Size(73, 17);
            this.rdiLogNewsfeed.TabIndex = 10;
            this.rdiLogNewsfeed.TabStop = true;
            this.rdiLogNewsfeed.Text = "Newsfeed";
            // 
            // rdiLogBusiness
            // 
            this.rdiLogBusiness.AutoSize = true;
            this.rdiLogBusiness.Location = new System.Drawing.Point(117, 46);
            this.rdiLogBusiness.Name = "rdiLogBusiness";
            this.rdiLogBusiness.Size = new System.Drawing.Size(67, 17);
            this.rdiLogBusiness.TabIndex = 10;
            this.rdiLogBusiness.TabStop = true;
            this.rdiLogBusiness.Text = "Business";
            // 
            // btnGetLog
            // 
            this.btnGetLog.Location = new System.Drawing.Point(397, 19);
            this.btnGetLog.Name = "btnGetLog";
            this.btnGetLog.Padding = new System.Windows.Forms.Padding(5);
            this.btnGetLog.Size = new System.Drawing.Size(105, 44);
            this.btnGetLog.TabIndex = 9;
            this.btnGetLog.Text = "Get Log";
            this.btnGetLog.Click += new System.EventHandler(this.btnGetLog_Click);
            // 
            // darkLabel6
            // 
            this.darkLabel6.AutoSize = true;
            this.darkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel6.Location = new System.Drawing.Point(71, 21);
            this.darkLabel6.Name = "darkLabel6";
            this.darkLabel6.Size = new System.Drawing.Size(47, 13);
            this.darkLabel6.TabIndex = 1;
            this.darkLabel6.Text = "Branch: ";
            // 
            // txtBranchLog
            // 
            this.txtBranchLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtBranchLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtBranchLog.Location = new System.Drawing.Point(126, 19);
            this.txtBranchLog.Name = "txtBranchLog";
            this.txtBranchLog.Size = new System.Drawing.Size(265, 20);
            this.txtBranchLog.TabIndex = 8;
            this.txtBranchLog.Text = "develop";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(25, 19);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(99, 23);
            this.darkButton1.TabIndex = 5;
            this.darkButton1.Text = "Select File";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // darkButton2
            // 
            this.darkButton2.Location = new System.Drawing.Point(397, 19);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton2.Size = new System.Drawing.Size(105, 23);
            this.darkButton2.TabIndex = 6;
            this.darkButton2.Text = "Convert";
            this.darkButton2.Click += new System.EventHandler(this.darkButton2_Click);
            // 
            // txtFileLanguage
            // 
            this.txtFileLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtFileLanguage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtFileLanguage.Location = new System.Drawing.Point(130, 20);
            this.txtFileLanguage.Name = "txtFileLanguage";
            this.txtFileLanguage.Size = new System.Drawing.Size(259, 20);
            this.txtFileLanguage.TabIndex = 7;
            // 
            // btnStartSerivce
            // 
            this.btnStartSerivce.Location = new System.Drawing.Point(397, 19);
            this.btnStartSerivce.Name = "btnStartSerivce";
            this.btnStartSerivce.Padding = new System.Windows.Forms.Padding(5);
            this.btnStartSerivce.Size = new System.Drawing.Size(105, 23);
            this.btnStartSerivce.TabIndex = 6;
            this.btnStartSerivce.Text = "Start";
            this.btnStartSerivce.Click += new System.EventHandler(this.btnStartSerivce_Click);
            // 
            // darkGroupBox6
            // 
            this.darkGroupBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox6.Controls.Add(this.cbServer);
            this.darkGroupBox6.Controls.Add(this.btnStartSerivce);
            this.darkGroupBox6.Controls.Add(this.cbClient);
            this.darkGroupBox6.Controls.Add(this.cbListFolderSource);
            this.darkGroupBox6.Controls.Add(this.darkLabel7);
            this.darkGroupBox6.Location = new System.Drawing.Point(12, 480);
            this.darkGroupBox6.Name = "darkGroupBox6";
            this.darkGroupBox6.Size = new System.Drawing.Size(514, 55);
            this.darkGroupBox6.TabIndex = 2;
            this.darkGroupBox6.TabStop = false;
            this.darkGroupBox6.Text = "Service";
            // 
            // cbServer
            // 
            this.cbServer.AutoSize = true;
            this.cbServer.Checked = true;
            this.cbServer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbServer.Location = new System.Drawing.Point(326, 23);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(57, 17);
            this.cbServer.TabIndex = 2;
            this.cbServer.Text = "Server";
            // 
            // cbClient
            // 
            this.cbClient.AutoSize = true;
            this.cbClient.Checked = true;
            this.cbClient.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbClient.Location = new System.Drawing.Point(268, 23);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(52, 17);
            this.cbClient.TabIndex = 2;
            this.cbClient.Text = "Client";
            // 
            // cbListFolderSource
            // 
            this.cbListFolderSource.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbListFolderSource.FormattingEnabled = true;
            this.cbListFolderSource.Location = new System.Drawing.Point(78, 20);
            this.cbListFolderSource.Name = "cbListFolderSource";
            this.cbListFolderSource.Size = new System.Drawing.Size(183, 21);
            this.cbListFolderSource.TabIndex = 0;
            // 
            // darkLabel7
            // 
            this.darkLabel7.AutoSize = true;
            this.darkLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel7.Location = new System.Drawing.Point(28, 23);
            this.darkLabel7.Name = "darkLabel7";
            this.darkLabel7.Size = new System.Drawing.Size(44, 13);
            this.darkLabel7.TabIndex = 1;
            this.darkLabel7.Text = "Source:";
            // 
            // darkGroupBox7
            // 
            this.darkGroupBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox7.Controls.Add(this.darkButton1);
            this.darkGroupBox7.Controls.Add(this.darkButton2);
            this.darkGroupBox7.Controls.Add(this.txtFileLanguage);
            this.darkGroupBox7.Location = new System.Drawing.Point(12, 419);
            this.darkGroupBox7.Name = "darkGroupBox7";
            this.darkGroupBox7.Size = new System.Drawing.Size(514, 55);
            this.darkGroupBox7.TabIndex = 7;
            this.darkGroupBox7.TabStop = false;
            this.darkGroupBox7.Text = "Convert file Json to Json Flat";
            // 
            // darkTreeView1
            // 
            this.darkTreeView1.Location = new System.Drawing.Point(6, 45);
            this.darkTreeView1.MaxDragChange = 20;
            this.darkTreeView1.Name = "darkTreeView1";
            this.darkTreeView1.Size = new System.Drawing.Size(318, 395);
            this.darkTreeView1.TabIndex = 8;
            this.darkTreeView1.Text = "darkTreeView1";
            this.darkTreeView1.SelectedNodesChanged += new System.EventHandler(this.darkTreeView1_SelectedNodesChanged);
            // 
            // btnPull
            // 
            this.btnPull.Location = new System.Drawing.Point(6, 456);
            this.btnPull.Name = "btnPull";
            this.btnPull.Padding = new System.Windows.Forms.Padding(5);
            this.btnPull.Size = new System.Drawing.Size(75, 54);
            this.btnPull.TabIndex = 9;
            this.btnPull.Text = "Pull";
            this.btnPull.Click += new System.EventHandler(this.btnPull_Click);
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(87, 456);
            this.btnPush.Name = "btnPush";
            this.btnPush.Padding = new System.Windows.Forms.Padding(5);
            this.btnPush.Size = new System.Drawing.Size(75, 54);
            this.btnPush.TabIndex = 9;
            this.btnPush.Text = "Push";
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(168, 456);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(5);
            this.btnStart.Size = new System.Drawing.Size(75, 54);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // darkGroupBox8
            // 
            this.darkGroupBox8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox8.Controls.Add(this.btnBash);
            this.darkGroupBox8.Controls.Add(this.txtMess);
            this.darkGroupBox8.Controls.Add(this.darkTreeView1);
            this.darkGroupBox8.Controls.Add(this.btnStart);
            this.darkGroupBox8.Controls.Add(this.btnPush);
            this.darkGroupBox8.Controls.Add(this.btnPull);
            this.darkGroupBox8.Location = new System.Drawing.Point(532, 13);
            this.darkGroupBox8.Name = "darkGroupBox8";
            this.darkGroupBox8.Size = new System.Drawing.Size(332, 522);
            this.darkGroupBox8.TabIndex = 10;
            this.darkGroupBox8.TabStop = false;
            this.darkGroupBox8.Text = "Git & NPM v2";
            // 
            // txtMess
            // 
            this.txtMess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtMess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtMess.Location = new System.Drawing.Point(6, 22);
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(237, 20);
            this.txtMess.TabIndex = 10;
            this.txtMess.Text = "update";
            // 
            // btnBash
            // 
            this.btnBash.Location = new System.Drawing.Point(249, 456);
            this.btnBash.Name = "btnBash";
            this.btnBash.Padding = new System.Windows.Forms.Padding(5);
            this.btnBash.Size = new System.Drawing.Size(75, 54);
            this.btnBash.TabIndex = 11;
            this.btnBash.Text = "Bash";
            this.btnBash.Click += new System.EventHandler(this.btnBash_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 550);
            this.Controls.Add(this.darkGroupBox8);
            this.Controls.Add(this.darkGroupBox7);
            this.Controls.Add(this.darkGroupBox6);
            this.Controls.Add(this.darkGroupBox4);
            this.Controls.Add(this.darkGroupBox2);
            this.Controls.Add(this.darkGroupBox5);
            this.Controls.Add(this.darkGroupBox3);
            this.Controls.Add(this.darkGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My tool || tao lao tool || duchuy tool || 2.2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.darkGroupBox1.ResumeLayout(false);
            this.darkGroupBox1.PerformLayout();
            this.darkGroupBox2.ResumeLayout(false);
            this.darkGroupBox2.PerformLayout();
            this.darkGroupBox3.ResumeLayout(false);
            this.darkGroupBox3.PerformLayout();
            this.darkGroupBox4.ResumeLayout(false);
            this.darkGroupBox4.PerformLayout();
            this.darkGroupBox5.ResumeLayout(false);
            this.darkGroupBox5.PerformLayout();
            this.darkGroupBox6.ResumeLayout(false);
            this.darkGroupBox6.PerformLayout();
            this.darkGroupBox7.ResumeLayout(false);
            this.darkGroupBox7.PerformLayout();
            this.darkGroupBox8.ResumeLayout(false);
            this.darkGroupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkGroupBox darkGroupBox1;
        private DarkUI.Controls.DarkButton btnUpcode;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkTextBox txtBranchPush;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkRadioButton rdiBackend;
        private DarkUI.Controls.DarkRadioButton rdiWallet;
        private DarkUI.Controls.DarkRadioButton rdiNewsfeed;
        private DarkUI.Controls.DarkRadioButton rdiBusiness;
        private DarkUI.Controls.DarkTextBox txtMessenger;
        private DarkUI.Controls.DarkGroupBox darkGroupBox2;
        private DarkUI.Controls.DarkButton btnCreateComponent;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkTextBox txtComponentName;
        private DarkUI.Controls.DarkGroupBox darkGroupBox3;
        private DarkUI.Controls.DarkRadioButton rdiPullBackend;
        private DarkUI.Controls.DarkRadioButton rdiPullWallet;
        private DarkUI.Controls.DarkRadioButton rdiPullNewsfeed;
        private DarkUI.Controls.DarkRadioButton rdiPullBusiness;
        private DarkUI.Controls.DarkButton btnPullCode;
        private DarkUI.Controls.DarkLabel darkLabel5;
        private DarkUI.Controls.DarkTextBox txtBranchPull;
        private DarkUI.Controls.DarkGroupBox darkGroupBox4;
        private DarkUI.Controls.DarkButton btnActionDocker;
        private DarkUI.Controls.DarkRadioButton rdiStop;
        private DarkUI.Controls.DarkRadioButton rdiRestart;
        private DarkUI.Controls.DarkRadioButton rdiStart;
        private DarkUI.Controls.DarkLabel darkLabel4;
        private DarkUI.Controls.DarkLabel lblInfo;
        private DarkUI.Controls.DarkGroupBox darkGroupBox5;
        private DarkUI.Controls.DarkRadioButton rdiLogBackend;
        private DarkUI.Controls.DarkRadioButton rdiLogWallet;
        private DarkUI.Controls.DarkRadioButton rdiLogNewsfeed;
        private DarkUI.Controls.DarkRadioButton rdiLogBusiness;
        private DarkUI.Controls.DarkButton btnGetLog;
        private DarkUI.Controls.DarkLabel darkLabel6;
        private DarkUI.Controls.DarkTextBox txtBranchLog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DarkUI.Controls.DarkButton darkButton1;
        private DarkUI.Controls.DarkButton darkButton2;
        private DarkUI.Controls.DarkTextBox txtFileLanguage;
        private DarkUI.Controls.DarkButton btnStartSerivce;
        private DarkUI.Controls.DarkGroupBox darkGroupBox6;
        private DarkUI.Controls.DarkComboBox cbListFolderSource;
        private DarkUI.Controls.DarkCheckBox cbServer;
        private DarkUI.Controls.DarkCheckBox cbClient;
        private DarkUI.Controls.DarkLabel darkLabel7;
        private DarkUI.Controls.DarkGroupBox darkGroupBox7;
        private DarkUI.Controls.DarkTreeView darkTreeView1;
        private DarkUI.Controls.DarkButton btnPull;
        private DarkUI.Controls.DarkButton btnPush;
        private DarkUI.Controls.DarkButton btnStart;
        private DarkUI.Controls.DarkGroupBox darkGroupBox8;
        private DarkUI.Controls.DarkTextBox txtMess;
        private DarkUI.Controls.DarkButton btnBash;
    }
}

