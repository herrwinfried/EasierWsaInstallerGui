namespace WsaGui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.osgroup = new System.Windows.Forms.GroupBox();
            this.OtherOSLabel = new System.Windows.Forms.Label();
            this.OsOtherText = new System.Windows.Forms.TextBox();
            this.OSOther = new System.Windows.Forms.RadioButton();
            this.OsOpenSUSETW = new System.Windows.Forms.RadioButton();
            this.OsDebian = new System.Windows.Forms.RadioButton();
            this.OsUbuntu = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mention_orginal = new System.Windows.Forms.RadioButton();
            this.mention_magisk = new System.Windows.Forms.RadioButton();
            this.mention_wsagascript = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turkishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseArchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arm64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadsAndLinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSStoreForPowershellCoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSStoreForWSLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSStoreForWSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSStoreForUbuntuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSStoreForDebianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSStoreForOpenSUSETumbleweedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToOpengappsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolAdguardStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myGithubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToLicenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wsascriptProjectPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeveloperModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powershellNoExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clipboardCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.notgapps = new System.Windows.Forms.RadioButton();
            this.gapps_nano = new System.Windows.Forms.RadioButton();
            this.gapps_pico = new System.Windows.Forms.RadioButton();
            this.gapps_micro = new System.Windows.Forms.RadioButton();
            this.gapps_mini = new System.Windows.Forms.RadioButton();
            this.gapps_full = new System.Windows.Forms.RadioButton();
            this.gapps_aroma = new System.Windows.Forms.RadioButton();
            this.gapps_stock = new System.Windows.Forms.RadioButton();
            this.gapps_super = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.WsaTools = new System.Windows.Forms.CheckBox();
            this.Adb = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.enable_DevMode = new System.Windows.Forms.CheckBox();
            this.enable_vmp = new System.Windows.Forms.CheckBox();
            this.ready_button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.magisk_version_text = new System.Windows.Forms.Label();
            this.magisk_version_combobox = new System.Windows.Forms.ComboBox();
            this.wsa_release_combox = new System.Windows.Forms.ComboBox();
            this.wsa_release_Type = new System.Windows.Forms.Label();
            this.WsaUsernameButton = new System.Windows.Forms.Button();
            this.amazon_appstore = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WsaProductName = new System.Windows.Forms.TextBox();
            this.reset_button = new System.Windows.Forms.Button();
            this.osgroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // osgroup
            // 
            this.osgroup.Controls.Add(this.OtherOSLabel);
            this.osgroup.Controls.Add(this.OsOtherText);
            this.osgroup.Controls.Add(this.OSOther);
            this.osgroup.Controls.Add(this.OsOpenSUSETW);
            this.osgroup.Controls.Add(this.OsDebian);
            this.osgroup.Controls.Add(this.OsUbuntu);
            resources.ApplyResources(this.osgroup, "osgroup");
            this.osgroup.Name = "osgroup";
            this.osgroup.TabStop = false;
            // 
            // OtherOSLabel
            // 
            resources.ApplyResources(this.OtherOSLabel, "OtherOSLabel");
            this.OtherOSLabel.Name = "OtherOSLabel";
            // 
            // OsOtherText
            // 
            resources.ApplyResources(this.OsOtherText, "OsOtherText");
            this.OsOtherText.Name = "OsOtherText";
            this.OsOtherText.ReadOnly = true;
            // 
            // OSOther
            // 
            resources.ApplyResources(this.OSOther, "OSOther");
            this.OSOther.Name = "OSOther";
            this.OSOther.UseVisualStyleBackColor = true;
            this.OSOther.CheckedChanged += new System.EventHandler(this.OSOther_CheckedChanged);
            // 
            // OsOpenSUSETW
            // 
            resources.ApplyResources(this.OsOpenSUSETW, "OsOpenSUSETW");
            this.OsOpenSUSETW.Name = "OsOpenSUSETW";
            this.OsOpenSUSETW.UseVisualStyleBackColor = true;
            this.OsOpenSUSETW.CheckedChanged += new System.EventHandler(this.OsOpenSUSETW_CheckedChanged);
            // 
            // OsDebian
            // 
            resources.ApplyResources(this.OsDebian, "OsDebian");
            this.OsDebian.Name = "OsDebian";
            this.OsDebian.UseVisualStyleBackColor = true;
            this.OsDebian.CheckedChanged += new System.EventHandler(this.OsDebian_CheckedChanged);
            // 
            // OsUbuntu
            // 
            resources.ApplyResources(this.OsUbuntu, "OsUbuntu");
            this.OsUbuntu.Checked = true;
            this.OsUbuntu.Name = "OsUbuntu";
            this.OsUbuntu.TabStop = true;
            this.OsUbuntu.UseVisualStyleBackColor = true;
            this.OsUbuntu.CheckedChanged += new System.EventHandler(this.OsUbuntu_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mention_orginal);
            this.groupBox2.Controls.Add(this.mention_magisk);
            this.groupBox2.Controls.Add(this.mention_wsagascript);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // mention_orginal
            // 
            resources.ApplyResources(this.mention_orginal, "mention_orginal");
            this.mention_orginal.Name = "mention_orginal";
            this.mention_orginal.UseVisualStyleBackColor = true;
            this.mention_orginal.CheckedChanged += new System.EventHandler(this.mention_orginal_CheckedChanged);
            // 
            // mention_magisk
            // 
            resources.ApplyResources(this.mention_magisk, "mention_magisk");
            this.mention_magisk.Checked = true;
            this.mention_magisk.Name = "mention_magisk";
            this.mention_magisk.TabStop = true;
            this.mention_magisk.UseVisualStyleBackColor = true;
            this.mention_magisk.CheckedChanged += new System.EventHandler(this.mention_magisk_CheckedChanged);
            // 
            // mention_wsagascript
            // 
            resources.ApplyResources(this.mention_wsagascript, "mention_wsagascript");
            this.mention_wsagascript.Name = "mention_wsagascript";
            this.mention_wsagascript.UseVisualStyleBackColor = true;
            this.mention_wsagascript.CheckedChanged += new System.EventHandler(this.mention_wsagascript_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.chooseArchToolStripMenuItem,
            this.downloadsAndLinksToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.optionsToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.turkishToolStripMenuItem,
            this.germanToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // turkishToolStripMenuItem
            // 
            this.turkishToolStripMenuItem.Name = "turkishToolStripMenuItem";
            resources.ApplyResources(this.turkishToolStripMenuItem, "turkishToolStripMenuItem");
            this.turkishToolStripMenuItem.Click += new System.EventHandler(this.turkishToolStripMenuItem_Click);
            // 
            // germanToolStripMenuItem
            // 
            this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            resources.ApplyResources(this.germanToolStripMenuItem, "germanToolStripMenuItem");
            this.germanToolStripMenuItem.Click += new System.EventHandler(this.germanToolStripMenuItem_Click);
            // 
            // chooseArchToolStripMenuItem
            // 
            this.chooseArchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x64ToolStripMenuItem,
            this.arm64ToolStripMenuItem});
            this.chooseArchToolStripMenuItem.Name = "chooseArchToolStripMenuItem";
            resources.ApplyResources(this.chooseArchToolStripMenuItem, "chooseArchToolStripMenuItem");
            // 
            // x64ToolStripMenuItem
            // 
            this.x64ToolStripMenuItem.CheckOnClick = true;
            this.x64ToolStripMenuItem.Name = "x64ToolStripMenuItem";
            resources.ApplyResources(this.x64ToolStripMenuItem, "x64ToolStripMenuItem");
            this.x64ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.x64ToolStripMenuItem_CheckedChanged);
            this.x64ToolStripMenuItem.Click += new System.EventHandler(this.x64ToolStripMenuItem_Click);
            // 
            // arm64ToolStripMenuItem
            // 
            this.arm64ToolStripMenuItem.CheckOnClick = true;
            this.arm64ToolStripMenuItem.Name = "arm64ToolStripMenuItem";
            resources.ApplyResources(this.arm64ToolStripMenuItem, "arm64ToolStripMenuItem");
            this.arm64ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.arm64ToolStripMenuItem_CheckedChanged);
            this.arm64ToolStripMenuItem.Click += new System.EventHandler(this.arm64ToolStripMenuItem_Click);
            // 
            // downloadsAndLinksToolStripMenuItem
            // 
            this.downloadsAndLinksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSStoreForPowershellCoreToolStripMenuItem,
            this.mSStoreForWSLToolStripMenuItem,
            this.mSStoreForWSAToolStripMenuItem,
            this.mSStoreForUbuntuToolStripMenuItem,
            this.mSStoreForDebianToolStripMenuItem,
            this.mSStoreForOpenSUSETumbleweedToolStripMenuItem,
            this.goToOpengappsToolStripMenuItem,
            this.goToToolAdguardStripMenuItem});
            this.downloadsAndLinksToolStripMenuItem.Name = "downloadsAndLinksToolStripMenuItem";
            resources.ApplyResources(this.downloadsAndLinksToolStripMenuItem, "downloadsAndLinksToolStripMenuItem");
            // 
            // mSStoreForPowershellCoreToolStripMenuItem
            // 
            this.mSStoreForPowershellCoreToolStripMenuItem.Image = global::WsaGui.Properties.Resources.powershellicon;
            this.mSStoreForPowershellCoreToolStripMenuItem.Name = "mSStoreForPowershellCoreToolStripMenuItem";
            resources.ApplyResources(this.mSStoreForPowershellCoreToolStripMenuItem, "mSStoreForPowershellCoreToolStripMenuItem");
            this.mSStoreForPowershellCoreToolStripMenuItem.Click += new System.EventHandler(this.mSStoreForPowershellCoreToolStripMenuItem_Click);
            // 
            // mSStoreForWSLToolStripMenuItem
            // 
            this.mSStoreForWSLToolStripMenuItem.Image = global::WsaGui.Properties.Resources.linux;
            this.mSStoreForWSLToolStripMenuItem.Name = "mSStoreForWSLToolStripMenuItem";
            resources.ApplyResources(this.mSStoreForWSLToolStripMenuItem, "mSStoreForWSLToolStripMenuItem");
            this.mSStoreForWSLToolStripMenuItem.Click += new System.EventHandler(this.mSStoreForWSLToolStripMenuItem_Click);
            // 
            // mSStoreForWSAToolStripMenuItem
            // 
            resources.ApplyResources(this.mSStoreForWSAToolStripMenuItem, "mSStoreForWSAToolStripMenuItem");
            this.mSStoreForWSAToolStripMenuItem.Image = global::WsaGui.Properties.Resources.wsa;
            this.mSStoreForWSAToolStripMenuItem.Name = "mSStoreForWSAToolStripMenuItem";
            this.mSStoreForWSAToolStripMenuItem.Click += new System.EventHandler(this.mSStoreForWSAToolStripMenuItem_Click);
            // 
            // mSStoreForUbuntuToolStripMenuItem
            // 
            this.mSStoreForUbuntuToolStripMenuItem.Image = global::WsaGui.Properties.Resources.ubuntu;
            this.mSStoreForUbuntuToolStripMenuItem.Name = "mSStoreForUbuntuToolStripMenuItem";
            resources.ApplyResources(this.mSStoreForUbuntuToolStripMenuItem, "mSStoreForUbuntuToolStripMenuItem");
            this.mSStoreForUbuntuToolStripMenuItem.Click += new System.EventHandler(this.mSStoreForUbuntuToolStripMenuItem_Click);
            // 
            // mSStoreForDebianToolStripMenuItem
            // 
            this.mSStoreForDebianToolStripMenuItem.Image = global::WsaGui.Properties.Resources.debian;
            this.mSStoreForDebianToolStripMenuItem.Name = "mSStoreForDebianToolStripMenuItem";
            resources.ApplyResources(this.mSStoreForDebianToolStripMenuItem, "mSStoreForDebianToolStripMenuItem");
            this.mSStoreForDebianToolStripMenuItem.Click += new System.EventHandler(this.mSStoreForDebianToolStripMenuItem_Click);
            // 
            // mSStoreForOpenSUSETumbleweedToolStripMenuItem
            // 
            this.mSStoreForOpenSUSETumbleweedToolStripMenuItem.Image = global::WsaGui.Properties.Resources.opensuse;
            this.mSStoreForOpenSUSETumbleweedToolStripMenuItem.Name = "mSStoreForOpenSUSETumbleweedToolStripMenuItem";
            resources.ApplyResources(this.mSStoreForOpenSUSETumbleweedToolStripMenuItem, "mSStoreForOpenSUSETumbleweedToolStripMenuItem");
            this.mSStoreForOpenSUSETumbleweedToolStripMenuItem.Click += new System.EventHandler(this.mSStoreForOpenSUSETumbleweedToolStripMenuItem_Click);
            // 
            // goToOpengappsToolStripMenuItem
            // 
            this.goToOpengappsToolStripMenuItem.Image = global::WsaGui.Properties.Resources.opengapps;
            this.goToOpengappsToolStripMenuItem.Name = "goToOpengappsToolStripMenuItem";
            resources.ApplyResources(this.goToOpengappsToolStripMenuItem, "goToOpengappsToolStripMenuItem");
            this.goToOpengappsToolStripMenuItem.Click += new System.EventHandler(this.goToOpengappsToolStripMenuItem_Click);
            // 
            // goToToolAdguardStripMenuItem
            // 
            this.goToToolAdguardStripMenuItem.Name = "goToToolAdguardStripMenuItem";
            resources.ApplyResources(this.goToToolAdguardStripMenuItem, "goToToolAdguardStripMenuItem");
            this.goToToolAdguardStripMenuItem.Click += new System.EventHandler(this.goToToolAdguardStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myGithubToolStripMenuItem,
            this.projectPageToolStripMenuItem,
            this.goToLicenceToolStripMenuItem,
            this.wsascriptProjectPageToolStripMenuItem,
            this.donateToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // myGithubToolStripMenuItem
            // 
            this.myGithubToolStripMenuItem.Image = global::WsaGui.Properties.Resources.github;
            this.myGithubToolStripMenuItem.Name = "myGithubToolStripMenuItem";
            resources.ApplyResources(this.myGithubToolStripMenuItem, "myGithubToolStripMenuItem");
            this.myGithubToolStripMenuItem.Click += new System.EventHandler(this.myGithubToolStripMenuItem_Click);
            // 
            // projectPageToolStripMenuItem
            // 
            this.projectPageToolStripMenuItem.Image = global::WsaGui.Properties.Resources.wsa;
            this.projectPageToolStripMenuItem.Name = "projectPageToolStripMenuItem";
            resources.ApplyResources(this.projectPageToolStripMenuItem, "projectPageToolStripMenuItem");
            this.projectPageToolStripMenuItem.Click += new System.EventHandler(this.projectPageToolStripMenuItem_Click);
            // 
            // goToLicenceToolStripMenuItem
            // 
            this.goToLicenceToolStripMenuItem.Image = global::WsaGui.Properties.Resources.licence;
            this.goToLicenceToolStripMenuItem.Name = "goToLicenceToolStripMenuItem";
            resources.ApplyResources(this.goToLicenceToolStripMenuItem, "goToLicenceToolStripMenuItem");
            this.goToLicenceToolStripMenuItem.Click += new System.EventHandler(this.goToLicenceToolStripMenuItem_Click);
            // 
            // wsascriptProjectPageToolStripMenuItem
            // 
            this.wsascriptProjectPageToolStripMenuItem.Image = global::WsaGui.Properties.Resources.github;
            this.wsascriptProjectPageToolStripMenuItem.Name = "wsascriptProjectPageToolStripMenuItem";
            resources.ApplyResources(this.wsascriptProjectPageToolStripMenuItem, "wsascriptProjectPageToolStripMenuItem");
            this.wsascriptProjectPageToolStripMenuItem.Click += new System.EventHandler(this.wsascriptProjectPageToolStripMenuItem_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Image = global::WsaGui.Properties.Resources.donate;
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            resources.ApplyResources(this.donateToolStripMenuItem, "donateToolStripMenuItem");
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = global::WsaGui.Properties.Resources.info;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            resources.ApplyResources(this.aboutToolStripMenuItem1, "aboutToolStripMenuItem1");
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeveloperModeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // DeveloperModeToolStripMenuItem
            // 
            this.DeveloperModeToolStripMenuItem.CheckOnClick = true;
            this.DeveloperModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powershellNoExitToolStripMenuItem,
            this.clipboardCopyToolStripMenuItem});
            this.DeveloperModeToolStripMenuItem.Name = "DeveloperModeToolStripMenuItem";
            resources.ApplyResources(this.DeveloperModeToolStripMenuItem, "DeveloperModeToolStripMenuItem");
            // 
            // powershellNoExitToolStripMenuItem
            // 
            this.powershellNoExitToolStripMenuItem.Checked = true;
            this.powershellNoExitToolStripMenuItem.CheckOnClick = true;
            this.powershellNoExitToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.powershellNoExitToolStripMenuItem, "powershellNoExitToolStripMenuItem");
            this.powershellNoExitToolStripMenuItem.Name = "powershellNoExitToolStripMenuItem";
            // 
            // clipboardCopyToolStripMenuItem
            // 
            this.clipboardCopyToolStripMenuItem.CheckOnClick = true;
            this.clipboardCopyToolStripMenuItem.Name = "clipboardCopyToolStripMenuItem";
            resources.ApplyResources(this.clipboardCopyToolStripMenuItem, "clipboardCopyToolStripMenuItem");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.notgapps);
            this.groupBox3.Controls.Add(this.gapps_nano);
            this.groupBox3.Controls.Add(this.gapps_pico);
            this.groupBox3.Controls.Add(this.gapps_micro);
            this.groupBox3.Controls.Add(this.gapps_mini);
            this.groupBox3.Controls.Add(this.gapps_full);
            this.groupBox3.Controls.Add(this.gapps_aroma);
            this.groupBox3.Controls.Add(this.gapps_stock);
            this.groupBox3.Controls.Add(this.gapps_super);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // notgapps
            // 
            resources.ApplyResources(this.notgapps, "notgapps");
            this.notgapps.Name = "notgapps";
            this.notgapps.UseVisualStyleBackColor = true;
            // 
            // gapps_nano
            // 
            resources.ApplyResources(this.gapps_nano, "gapps_nano");
            this.gapps_nano.Name = "gapps_nano";
            this.gapps_nano.UseVisualStyleBackColor = true;
            // 
            // gapps_pico
            // 
            resources.ApplyResources(this.gapps_pico, "gapps_pico");
            this.gapps_pico.Checked = true;
            this.gapps_pico.Name = "gapps_pico";
            this.gapps_pico.TabStop = true;
            this.gapps_pico.UseVisualStyleBackColor = true;
            // 
            // gapps_micro
            // 
            resources.ApplyResources(this.gapps_micro, "gapps_micro");
            this.gapps_micro.Name = "gapps_micro";
            this.gapps_micro.UseVisualStyleBackColor = true;
            // 
            // gapps_mini
            // 
            resources.ApplyResources(this.gapps_mini, "gapps_mini");
            this.gapps_mini.Name = "gapps_mini";
            this.gapps_mini.UseVisualStyleBackColor = true;
            // 
            // gapps_full
            // 
            resources.ApplyResources(this.gapps_full, "gapps_full");
            this.gapps_full.Name = "gapps_full";
            this.gapps_full.UseVisualStyleBackColor = true;
            // 
            // gapps_aroma
            // 
            resources.ApplyResources(this.gapps_aroma, "gapps_aroma");
            this.gapps_aroma.Name = "gapps_aroma";
            this.gapps_aroma.UseVisualStyleBackColor = true;
            // 
            // gapps_stock
            // 
            resources.ApplyResources(this.gapps_stock, "gapps_stock");
            this.gapps_stock.Name = "gapps_stock";
            this.gapps_stock.UseVisualStyleBackColor = true;
            // 
            // gapps_super
            // 
            resources.ApplyResources(this.gapps_super, "gapps_super");
            this.gapps_super.Name = "gapps_super";
            this.gapps_super.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.WsaTools);
            this.groupBox4.Controls.Add(this.Adb);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // WsaTools
            // 
            resources.ApplyResources(this.WsaTools, "WsaTools");
            this.WsaTools.Name = "WsaTools";
            this.WsaTools.UseVisualStyleBackColor = true;
            // 
            // Adb
            // 
            this.Adb.Checked = true;
            this.Adb.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.Adb, "Adb");
            this.Adb.Name = "Adb";
            this.Adb.TabStop = false;
            this.Adb.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.enable_DevMode);
            this.groupBox5.Controls.Add(this.enable_vmp);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // enable_DevMode
            // 
            this.enable_DevMode.Checked = true;
            this.enable_DevMode.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.enable_DevMode, "enable_DevMode");
            this.enable_DevMode.Name = "enable_DevMode";
            this.enable_DevMode.UseVisualStyleBackColor = true;
            this.enable_DevMode.CheckedChanged += new System.EventHandler(this.enable_DevMode_CheckedChanged);
            // 
            // enable_vmp
            // 
            resources.ApplyResources(this.enable_vmp, "enable_vmp");
            this.enable_vmp.Checked = true;
            this.enable_vmp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enable_vmp.Name = "enable_vmp";
            this.enable_vmp.UseVisualStyleBackColor = true;
            this.enable_vmp.CheckedChanged += new System.EventHandler(this.enable_vmp_CheckedChanged);
            // 
            // ready_button
            // 
            resources.ApplyResources(this.ready_button, "ready_button");
            this.ready_button.Name = "ready_button";
            this.ready_button.UseVisualStyleBackColor = true;
            this.ready_button.Click += new System.EventHandler(this.ready_button_Click);
            // 
            // Exit_Button
            // 
            resources.ApplyResources(this.Exit_Button, "Exit_Button");
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.magisk_version_text);
            this.groupBox6.Controls.Add(this.magisk_version_combobox);
            this.groupBox6.Controls.Add(this.wsa_release_combox);
            this.groupBox6.Controls.Add(this.wsa_release_Type);
            this.groupBox6.Controls.Add(this.WsaUsernameButton);
            this.groupBox6.Controls.Add(this.amazon_appstore);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.WsaProductName);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // magisk_version_text
            // 
            resources.ApplyResources(this.magisk_version_text, "magisk_version_text");
            this.magisk_version_text.Name = "magisk_version_text";
            // 
            // magisk_version_combobox
            // 
            this.magisk_version_combobox.FormattingEnabled = true;
            this.magisk_version_combobox.Items.AddRange(new object[] {
            resources.GetString("magisk_version_combobox.Items"),
            resources.GetString("magisk_version_combobox.Items1"),
            resources.GetString("magisk_version_combobox.Items2"),
            resources.GetString("magisk_version_combobox.Items3")});
            resources.ApplyResources(this.magisk_version_combobox, "magisk_version_combobox");
            this.magisk_version_combobox.Name = "magisk_version_combobox";
            // 
            // wsa_release_combox
            // 
            this.wsa_release_combox.FormattingEnabled = true;
            this.wsa_release_combox.Items.AddRange(new object[] {
            resources.GetString("wsa_release_combox.Items"),
            resources.GetString("wsa_release_combox.Items1"),
            resources.GetString("wsa_release_combox.Items2"),
            resources.GetString("wsa_release_combox.Items3")});
            resources.ApplyResources(this.wsa_release_combox, "wsa_release_combox");
            this.wsa_release_combox.Name = "wsa_release_combox";
            // 
            // wsa_release_Type
            // 
            resources.ApplyResources(this.wsa_release_Type, "wsa_release_Type");
            this.wsa_release_Type.Name = "wsa_release_Type";
            // 
            // WsaUsernameButton
            // 
            resources.ApplyResources(this.WsaUsernameButton, "WsaUsernameButton");
            this.WsaUsernameButton.Name = "WsaUsernameButton";
            this.WsaUsernameButton.UseVisualStyleBackColor = true;
            this.WsaUsernameButton.Click += new System.EventHandler(this.WsaUsernameButton_Click);
            // 
            // amazon_appstore
            // 
            this.amazon_appstore.FormattingEnabled = true;
            this.amazon_appstore.Items.AddRange(new object[] {
            resources.GetString("amazon_appstore.Items"),
            resources.GetString("amazon_appstore.Items1")});
            resources.ApplyResources(this.amazon_appstore, "amazon_appstore");
            this.amazon_appstore.Name = "amazon_appstore";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // WsaProductName
            // 
            resources.ApplyResources(this.WsaProductName, "WsaProductName");
            this.WsaProductName.Name = "WsaProductName";
            this.WsaProductName.Tag = "";
            this.WsaProductName.Leave += new System.EventHandler(this.WsaProductName_Leave);
            // 
            // reset_button
            // 
            resources.ApplyResources(this.reset_button, "reset_button");
            this.reset_button.Name = "reset_button";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // Form1
            // 
            this.CancelButton = this.Exit_Button;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.ready_button);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.osgroup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.osgroup.ResumeLayout(false);
            this.osgroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox osgroup;
        private RadioButton OsDebian;
        private RadioButton OsUbuntu;
        private RadioButton OSOther;
        private RadioButton OsOpenSUSETW;
        private TextBox OsOtherText;
        private Label OtherOSLabel;
        private GroupBox groupBox2;
        private MenuStrip menuStrip1;
        private GroupBox groupBox3;
        private RadioButton gapps_nano;
        private RadioButton gapps_pico;
        private RadioButton gapps_micro;
        private RadioButton gapps_mini;
        private RadioButton gapps_full;
        private RadioButton gapps_stock;
        private RadioButton gapps_super;
        private RadioButton gapps_aroma;
        private RadioButton notgapps;
        private RadioButton mention_orginal;
        private RadioButton mention_magisk;
        private RadioButton mention_wsagascript;
        private GroupBox groupBox4;
        private CheckBox WsaTools;
        private CheckBox Adb;
        private GroupBox groupBox5;
        private Button ready_button;
        private Button Exit_Button;
        private Label label2;
        private GroupBox groupBox6;
        private Label label3;
        private TextBox WsaProductName;
        private ComboBox amazon_appstore;
        private Label label4;
        private ToolStripMenuItem downloadsAndLinksToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private CheckBox enable_vmp;
        private CheckBox enable_DevMode;
        private ToolStripMenuItem mSStoreForPowershellCoreToolStripMenuItem;
        private ToolStripMenuItem mSStoreForWSLToolStripMenuItem;
        private ToolStripMenuItem mSStoreForWSAToolStripMenuItem;
        private ToolStripMenuItem mSStoreForUbuntuToolStripMenuItem;
        private ToolStripMenuItem mSStoreForDebianToolStripMenuItem;
        private ToolStripMenuItem mSStoreForOpenSUSETumbleweedToolStripMenuItem;
        private ToolStripMenuItem goToOpengappsToolStripMenuItem;
        private ToolStripMenuItem goToToolAdguardStripMenuItem;
        private ToolStripMenuItem myGithubToolStripMenuItem;
        private ToolStripMenuItem projectPageToolStripMenuItem;
        private ToolStripMenuItem goToLicenceToolStripMenuItem;
        private ToolStripMenuItem donateToolStripMenuItem;
        private Button WsaUsernameButton;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripMenuItem wsascriptProjectPageToolStripMenuItem;
        private Label wsa_release_Type;
        private Label magisk_version_text;
        private ComboBox magisk_version_combobox;
        private ComboBox wsa_release_combox;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem chooseArchToolStripMenuItem;
        private ToolStripMenuItem x64ToolStripMenuItem;
        private ToolStripMenuItem arm64ToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem turkishToolStripMenuItem;
        private ToolStripMenuItem germanToolStripMenuItem;
        private Button reset_button;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem DeveloperModeToolStripMenuItem;
        private ToolStripMenuItem powershellNoExitToolStripMenuItem;
        private ToolStripMenuItem clipboardCopyToolStripMenuItem;
    }
}