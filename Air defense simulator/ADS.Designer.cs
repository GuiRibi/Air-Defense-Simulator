namespace Air_defense_simulator
{
    partial class ADS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADS));
            this.buttonIFF = new System.Windows.Forms.Button();
            this.buttonShowAirway = new System.Windows.Forms.Button();
            this.buttonHideAirway = new System.Windows.Forms.Button();
            this.buttonIgnoreWarning = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonUnselect = new System.Windows.Forms.Button();
            this.buttonSalvo = new System.Windows.Forms.Button();
            this.buttonSingle = new System.Windows.Forms.Button();
            this.buttonEngage = new System.Windows.Forms.Button();
            this.pictureBoxFlipSwitch1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLight1 = new System.Windows.Forms.PictureBox();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timerTargetUpdate = new System.Windows.Forms.Timer(this.components);
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.Launcher1 = new System.Windows.Forms.Button();
            this.Launcher2 = new System.Windows.Forms.Button();
            this.Launcher4 = new System.Windows.Forms.Button();
            this.Launcher3 = new System.Windows.Forms.Button();
            this.Launcher7 = new System.Windows.Forms.Button();
            this.Launcher8 = new System.Windows.Forms.Button();
            this.Launcher6 = new System.Windows.Forms.Button();
            this.Launcher5 = new System.Windows.Forms.Button();
            this.Launcher11 = new System.Windows.Forms.Button();
            this.Launcher12 = new System.Windows.Forms.Button();
            this.Launcher10 = new System.Windows.Forms.Button();
            this.Launcher9 = new System.Windows.Forms.Button();
            this.Launcher15 = new System.Windows.Forms.Button();
            this.Launcher16 = new System.Windows.Forms.Button();
            this.Launcher14 = new System.Windows.Forms.Button();
            this.Launcher13 = new System.Windows.Forms.Button();
            this.Launcher19 = new System.Windows.Forms.Button();
            this.Launcher20 = new System.Windows.Forms.Button();
            this.Launcher18 = new System.Windows.Forms.Button();
            this.Launcher17 = new System.Windows.Forms.Button();
            this.Launcher24 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonReload = new System.Windows.Forms.Button();
            this.Launcher21 = new System.Windows.Forms.Button();
            this.Launcher22 = new System.Windows.Forms.Button();
            this.Launcher23 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button50X = new System.Windows.Forms.Button();
            this.button10X = new System.Windows.Forms.Button();
            this.button1X = new System.Windows.Forms.Button();
            this.richTextBoxReport = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxRadar = new System.Windows.Forms.PictureBox();
            this.labelClockHours = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelClockMinutes = new System.Windows.Forms.Label();
            this.labelClockSeconds = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSimulation = new System.Windows.Forms.Button();
            this.buttonGIP = new System.Windows.Forms.Button();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.timerNewTarget = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlipSwitch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLight1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRadar)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIFF
            // 
            this.buttonIFF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIFF.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonIFF.Enabled = false;
            this.buttonIFF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIFF.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonIFF.Location = new System.Drawing.Point(6, 101);
            this.buttonIFF.Name = "buttonIFF";
            this.buttonIFF.Size = new System.Drawing.Size(83, 61);
            this.buttonIFF.TabIndex = 1;
            this.buttonIFF.Text = "IFF";
            this.buttonIFF.UseVisualStyleBackColor = false;
            this.buttonIFF.Click += new System.EventHandler(this.buttonIFF_Click);
            // 
            // buttonShowAirway
            // 
            this.buttonShowAirway.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowAirway.BackColor = System.Drawing.Color.Khaki;
            this.buttonShowAirway.Enabled = false;
            this.buttonShowAirway.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShowAirway.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonShowAirway.Location = new System.Drawing.Point(140, 168);
            this.buttonShowAirway.Name = "buttonShowAirway";
            this.buttonShowAirway.Size = new System.Drawing.Size(61, 61);
            this.buttonShowAirway.TabIndex = 2;
            this.buttonShowAirway.Text = "Show AW";
            this.buttonShowAirway.UseVisualStyleBackColor = false;
            this.buttonShowAirway.Click += new System.EventHandler(this.buttonShowAirway_Click);
            // 
            // buttonHideAirway
            // 
            this.buttonHideAirway.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHideAirway.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonHideAirway.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHideAirway.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonHideAirway.Location = new System.Drawing.Point(207, 168);
            this.buttonHideAirway.Name = "buttonHideAirway";
            this.buttonHideAirway.Size = new System.Drawing.Size(61, 61);
            this.buttonHideAirway.TabIndex = 3;
            this.buttonHideAirway.Text = "Hide AW";
            this.buttonHideAirway.UseVisualStyleBackColor = false;
            this.buttonHideAirway.Click += new System.EventHandler(this.buttonHideAirway_Click);
            // 
            // buttonIgnoreWarning
            // 
            this.buttonIgnoreWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIgnoreWarning.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonIgnoreWarning.Enabled = false;
            this.buttonIgnoreWarning.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIgnoreWarning.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonIgnoreWarning.Location = new System.Drawing.Point(184, 101);
            this.buttonIgnoreWarning.Name = "buttonIgnoreWarning";
            this.buttonIgnoreWarning.Size = new System.Drawing.Size(84, 61);
            this.buttonIgnoreWarning.TabIndex = 4;
            this.buttonIgnoreWarning.Tag = "false";
            this.buttonIgnoreWarning.Text = "IW";
            this.buttonIgnoreWarning.UseVisualStyleBackColor = false;
            this.buttonIgnoreWarning.Click += new System.EventHandler(this.buttonIgnoreWarning_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelect.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSelect.Enabled = false;
            this.buttonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelect.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSelect.Location = new System.Drawing.Point(6, 168);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(61, 61);
            this.buttonSelect.TabIndex = 7;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonUnselect
            // 
            this.buttonUnselect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUnselect.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonUnselect.Enabled = false;
            this.buttonUnselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUnselect.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUnselect.Location = new System.Drawing.Point(73, 168);
            this.buttonUnselect.Name = "buttonUnselect";
            this.buttonUnselect.Size = new System.Drawing.Size(61, 61);
            this.buttonUnselect.TabIndex = 10;
            this.buttonUnselect.Text = "Unslct";
            this.buttonUnselect.UseVisualStyleBackColor = false;
            this.buttonUnselect.Click += new System.EventHandler(this.buttonUnselect_Click);
            // 
            // buttonSalvo
            // 
            this.buttonSalvo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalvo.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSalvo.Enabled = false;
            this.buttonSalvo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvo.Location = new System.Drawing.Point(73, 34);
            this.buttonSalvo.Name = "buttonSalvo";
            this.buttonSalvo.Size = new System.Drawing.Size(61, 61);
            this.buttonSalvo.TabIndex = 11;
            this.buttonSalvo.Text = "Salvo";
            this.buttonSalvo.UseVisualStyleBackColor = false;
            this.buttonSalvo.Click += new System.EventHandler(this.buttonSalvo_Click);
            // 
            // buttonSingle
            // 
            this.buttonSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSingle.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSingle.Enabled = false;
            this.buttonSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSingle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSingle.Location = new System.Drawing.Point(6, 34);
            this.buttonSingle.Name = "buttonSingle";
            this.buttonSingle.Size = new System.Drawing.Size(61, 61);
            this.buttonSingle.TabIndex = 12;
            this.buttonSingle.Text = "Single";
            this.buttonSingle.UseVisualStyleBackColor = false;
            this.buttonSingle.Click += new System.EventHandler(this.buttonSingle_Click);
            // 
            // buttonEngage
            // 
            this.buttonEngage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEngage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonEngage.Enabled = false;
            this.buttonEngage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEngage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEngage.Location = new System.Drawing.Point(207, 34);
            this.buttonEngage.Name = "buttonEngage";
            this.buttonEngage.Size = new System.Drawing.Size(61, 61);
            this.buttonEngage.TabIndex = 13;
            this.buttonEngage.Text = "ENG";
            this.buttonEngage.UseVisualStyleBackColor = false;
            this.buttonEngage.Click += new System.EventHandler(this.buttonEngage_Click);
            // 
            // pictureBoxFlipSwitch1
            // 
            this.pictureBoxFlipSwitch1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFlipSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFlipSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFlipSwitch1.Enabled = false;
            this.pictureBoxFlipSwitch1.Image = global::Air_defense_simulator.Properties.Resources.switch_down;
            this.pictureBoxFlipSwitch1.Location = new System.Drawing.Point(149, 29);
            this.pictureBoxFlipSwitch1.Name = "pictureBoxFlipSwitch1";
            this.pictureBoxFlipSwitch1.Size = new System.Drawing.Size(23, 67);
            this.pictureBoxFlipSwitch1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFlipSwitch1.TabIndex = 21;
            this.pictureBoxFlipSwitch1.TabStop = false;
            this.pictureBoxFlipSwitch1.Tag = "down";
            this.pictureBoxFlipSwitch1.Click += new System.EventHandler(this.pictureBoxFlipSwitch1_Click);
            // 
            // pictureBoxLight1
            // 
            this.pictureBoxLight1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLight1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLight1.Image = global::Air_defense_simulator.Properties.Resources.light_off;
            this.pictureBoxLight1.Location = new System.Drawing.Point(178, 53);
            this.pictureBoxLight1.Name = "pictureBoxLight1";
            this.pictureBoxLight1.Size = new System.Drawing.Size(20, 21);
            this.pictureBoxLight1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLight1.TabIndex = 24;
            this.pictureBoxLight1.TabStop = false;
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tag = "";
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(135, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Unlocked";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(140, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Locked";
            // 
            // timerTargetUpdate
            // 
            this.timerTargetUpdate.Enabled = true;
            this.timerTargetUpdate.Interval = 3000;
            this.timerTargetUpdate.Tick += new System.EventHandler(this.timerTargetUpdate_Tick);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Gainsboro;
            this.button13.Enabled = false;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button13.Location = new System.Drawing.Point(32, 271);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(40, 40);
            this.button13.TabIndex = 31;
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Gainsboro;
            this.button14.Enabled = false;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button14.Location = new System.Drawing.Point(32, 317);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(40, 40);
            this.button14.TabIndex = 32;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Gainsboro;
            this.button18.Enabled = false;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button18.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button18.Location = new System.Drawing.Point(32, 505);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(40, 40);
            this.button18.TabIndex = 36;
            this.button18.Text = "6";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Gainsboro;
            this.button19.Enabled = false;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button19.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button19.Location = new System.Drawing.Point(32, 459);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(40, 40);
            this.button19.TabIndex = 37;
            this.button19.Text = "5";
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Gainsboro;
            this.button20.Enabled = false;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button20.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button20.Location = new System.Drawing.Point(32, 409);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(40, 40);
            this.button20.TabIndex = 38;
            this.button20.Text = "4";
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Gainsboro;
            this.button21.Enabled = false;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button21.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button21.Location = new System.Drawing.Point(32, 363);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(40, 40);
            this.button21.TabIndex = 39;
            this.button21.Text = "3";
            this.button21.UseVisualStyleBackColor = false;
            // 
            // Launcher1
            // 
            this.Launcher1.BackColor = System.Drawing.Color.Lime;
            this.Launcher1.Enabled = false;
            this.Launcher1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher1.Location = new System.Drawing.Point(78, 277);
            this.Launcher1.Name = "Launcher1";
            this.Launcher1.Size = new System.Drawing.Size(30, 30);
            this.Launcher1.TabIndex = 40;
            this.Launcher1.Tag = "1";
            this.Launcher1.UseVisualStyleBackColor = false;
            // 
            // Launcher2
            // 
            this.Launcher2.BackColor = System.Drawing.Color.Lime;
            this.Launcher2.Enabled = false;
            this.Launcher2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher2.Location = new System.Drawing.Point(114, 277);
            this.Launcher2.Name = "Launcher2";
            this.Launcher2.Size = new System.Drawing.Size(30, 30);
            this.Launcher2.TabIndex = 41;
            this.Launcher2.Tag = "2";
            this.Launcher2.UseVisualStyleBackColor = false;
            // 
            // Launcher4
            // 
            this.Launcher4.BackColor = System.Drawing.Color.Lime;
            this.Launcher4.Enabled = false;
            this.Launcher4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher4.Location = new System.Drawing.Point(186, 277);
            this.Launcher4.Name = "Launcher4";
            this.Launcher4.Size = new System.Drawing.Size(30, 30);
            this.Launcher4.TabIndex = 42;
            this.Launcher4.Tag = "4";
            this.Launcher4.UseVisualStyleBackColor = false;
            // 
            // Launcher3
            // 
            this.Launcher3.BackColor = System.Drawing.Color.Lime;
            this.Launcher3.Enabled = false;
            this.Launcher3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher3.Location = new System.Drawing.Point(150, 277);
            this.Launcher3.Name = "Launcher3";
            this.Launcher3.Size = new System.Drawing.Size(30, 30);
            this.Launcher3.TabIndex = 43;
            this.Launcher3.Tag = "3";
            this.Launcher3.UseVisualStyleBackColor = false;
            // 
            // Launcher7
            // 
            this.Launcher7.BackColor = System.Drawing.Color.Lime;
            this.Launcher7.Enabled = false;
            this.Launcher7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher7.Location = new System.Drawing.Point(150, 322);
            this.Launcher7.Name = "Launcher7";
            this.Launcher7.Size = new System.Drawing.Size(30, 30);
            this.Launcher7.TabIndex = 47;
            this.Launcher7.Tag = "7";
            this.Launcher7.UseVisualStyleBackColor = false;
            // 
            // Launcher8
            // 
            this.Launcher8.BackColor = System.Drawing.Color.Lime;
            this.Launcher8.Enabled = false;
            this.Launcher8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher8.Location = new System.Drawing.Point(186, 322);
            this.Launcher8.Name = "Launcher8";
            this.Launcher8.Size = new System.Drawing.Size(30, 30);
            this.Launcher8.TabIndex = 46;
            this.Launcher8.Tag = "8";
            this.Launcher8.UseVisualStyleBackColor = false;
            // 
            // Launcher6
            // 
            this.Launcher6.BackColor = System.Drawing.Color.Lime;
            this.Launcher6.Enabled = false;
            this.Launcher6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher6.Location = new System.Drawing.Point(114, 322);
            this.Launcher6.Name = "Launcher6";
            this.Launcher6.Size = new System.Drawing.Size(30, 30);
            this.Launcher6.TabIndex = 45;
            this.Launcher6.Tag = "6";
            this.Launcher6.UseVisualStyleBackColor = false;
            // 
            // Launcher5
            // 
            this.Launcher5.BackColor = System.Drawing.Color.Lime;
            this.Launcher5.Enabled = false;
            this.Launcher5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher5.Location = new System.Drawing.Point(78, 322);
            this.Launcher5.Name = "Launcher5";
            this.Launcher5.Size = new System.Drawing.Size(30, 30);
            this.Launcher5.TabIndex = 44;
            this.Launcher5.Tag = "5";
            this.Launcher5.UseVisualStyleBackColor = false;
            // 
            // Launcher11
            // 
            this.Launcher11.BackColor = System.Drawing.Color.Lime;
            this.Launcher11.Enabled = false;
            this.Launcher11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher11.Location = new System.Drawing.Point(150, 368);
            this.Launcher11.Name = "Launcher11";
            this.Launcher11.Size = new System.Drawing.Size(30, 30);
            this.Launcher11.TabIndex = 51;
            this.Launcher11.Tag = "11";
            this.Launcher11.UseVisualStyleBackColor = false;
            // 
            // Launcher12
            // 
            this.Launcher12.BackColor = System.Drawing.Color.Lime;
            this.Launcher12.Enabled = false;
            this.Launcher12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher12.Location = new System.Drawing.Point(186, 368);
            this.Launcher12.Name = "Launcher12";
            this.Launcher12.Size = new System.Drawing.Size(30, 30);
            this.Launcher12.TabIndex = 50;
            this.Launcher12.Tag = "12";
            this.Launcher12.UseVisualStyleBackColor = false;
            // 
            // Launcher10
            // 
            this.Launcher10.BackColor = System.Drawing.Color.Lime;
            this.Launcher10.Enabled = false;
            this.Launcher10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher10.Location = new System.Drawing.Point(114, 368);
            this.Launcher10.Name = "Launcher10";
            this.Launcher10.Size = new System.Drawing.Size(30, 30);
            this.Launcher10.TabIndex = 49;
            this.Launcher10.Tag = "10";
            this.Launcher10.UseVisualStyleBackColor = false;
            // 
            // Launcher9
            // 
            this.Launcher9.BackColor = System.Drawing.Color.Lime;
            this.Launcher9.Enabled = false;
            this.Launcher9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher9.Location = new System.Drawing.Point(78, 368);
            this.Launcher9.Name = "Launcher9";
            this.Launcher9.Size = new System.Drawing.Size(30, 30);
            this.Launcher9.TabIndex = 48;
            this.Launcher9.Tag = "9";
            this.Launcher9.UseVisualStyleBackColor = false;
            // 
            // Launcher15
            // 
            this.Launcher15.BackColor = System.Drawing.Color.Lime;
            this.Launcher15.Enabled = false;
            this.Launcher15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher15.Location = new System.Drawing.Point(150, 414);
            this.Launcher15.Name = "Launcher15";
            this.Launcher15.Size = new System.Drawing.Size(30, 30);
            this.Launcher15.TabIndex = 55;
            this.Launcher15.Tag = "15";
            this.Launcher15.UseVisualStyleBackColor = false;
            // 
            // Launcher16
            // 
            this.Launcher16.BackColor = System.Drawing.Color.Lime;
            this.Launcher16.Enabled = false;
            this.Launcher16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher16.Location = new System.Drawing.Point(186, 414);
            this.Launcher16.Name = "Launcher16";
            this.Launcher16.Size = new System.Drawing.Size(30, 30);
            this.Launcher16.TabIndex = 54;
            this.Launcher16.Tag = "16";
            this.Launcher16.UseVisualStyleBackColor = false;
            // 
            // Launcher14
            // 
            this.Launcher14.BackColor = System.Drawing.Color.Lime;
            this.Launcher14.Enabled = false;
            this.Launcher14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher14.Location = new System.Drawing.Point(114, 414);
            this.Launcher14.Name = "Launcher14";
            this.Launcher14.Size = new System.Drawing.Size(30, 30);
            this.Launcher14.TabIndex = 53;
            this.Launcher14.Tag = "14";
            this.Launcher14.UseVisualStyleBackColor = false;
            // 
            // Launcher13
            // 
            this.Launcher13.BackColor = System.Drawing.Color.Lime;
            this.Launcher13.Enabled = false;
            this.Launcher13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher13.Location = new System.Drawing.Point(78, 414);
            this.Launcher13.Name = "Launcher13";
            this.Launcher13.Size = new System.Drawing.Size(30, 30);
            this.Launcher13.TabIndex = 52;
            this.Launcher13.Tag = "13";
            this.Launcher13.UseVisualStyleBackColor = false;
            // 
            // Launcher19
            // 
            this.Launcher19.BackColor = System.Drawing.Color.Lime;
            this.Launcher19.Enabled = false;
            this.Launcher19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher19.Location = new System.Drawing.Point(150, 464);
            this.Launcher19.Name = "Launcher19";
            this.Launcher19.Size = new System.Drawing.Size(30, 30);
            this.Launcher19.TabIndex = 59;
            this.Launcher19.Tag = "19";
            this.Launcher19.UseVisualStyleBackColor = false;
            // 
            // Launcher20
            // 
            this.Launcher20.BackColor = System.Drawing.Color.Lime;
            this.Launcher20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Launcher20.Enabled = false;
            this.Launcher20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher20.Location = new System.Drawing.Point(186, 464);
            this.Launcher20.Name = "Launcher20";
            this.Launcher20.Size = new System.Drawing.Size(30, 30);
            this.Launcher20.TabIndex = 58;
            this.Launcher20.Tag = "20";
            this.Launcher20.UseVisualStyleBackColor = false;
            // 
            // Launcher18
            // 
            this.Launcher18.BackColor = System.Drawing.Color.Lime;
            this.Launcher18.Enabled = false;
            this.Launcher18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher18.Location = new System.Drawing.Point(114, 464);
            this.Launcher18.Name = "Launcher18";
            this.Launcher18.Size = new System.Drawing.Size(30, 30);
            this.Launcher18.TabIndex = 57;
            this.Launcher18.Tag = "18";
            this.Launcher18.UseVisualStyleBackColor = false;
            // 
            // Launcher17
            // 
            this.Launcher17.BackColor = System.Drawing.Color.Lime;
            this.Launcher17.Enabled = false;
            this.Launcher17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher17.Location = new System.Drawing.Point(78, 464);
            this.Launcher17.Name = "Launcher17";
            this.Launcher17.Size = new System.Drawing.Size(30, 30);
            this.Launcher17.TabIndex = 56;
            this.Launcher17.Tag = "17";
            this.Launcher17.UseVisualStyleBackColor = false;
            // 
            // Launcher24
            // 
            this.Launcher24.BackColor = System.Drawing.Color.Lime;
            this.Launcher24.Enabled = false;
            this.Launcher24.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher24.Location = new System.Drawing.Point(186, 511);
            this.Launcher24.Name = "Launcher24";
            this.Launcher24.Size = new System.Drawing.Size(30, 30);
            this.Launcher24.TabIndex = 62;
            this.Launcher24.Tag = "24";
            this.Launcher24.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.groupBox1.Controls.Add(this.buttonReload);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(27, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 393);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Launchers";
            // 
            // buttonReload
            // 
            this.buttonReload.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonReload.Enabled = false;
            this.buttonReload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReload.Location = new System.Drawing.Point(5, 327);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(195, 51);
            this.buttonReload.TabIndex = 0;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = false;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            this.buttonReload.MouseEnter += new System.EventHandler(this.buttonReload_MouseEnter);
            this.buttonReload.MouseLeave += new System.EventHandler(this.buttonReload_MouseLeave);
            // 
            // Launcher21
            // 
            this.Launcher21.BackColor = System.Drawing.Color.Lime;
            this.Launcher21.Enabled = false;
            this.Launcher21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher21.Location = new System.Drawing.Point(78, 511);
            this.Launcher21.Name = "Launcher21";
            this.Launcher21.Size = new System.Drawing.Size(30, 30);
            this.Launcher21.TabIndex = 60;
            this.Launcher21.Tag = "21";
            this.Launcher21.UseVisualStyleBackColor = false;
            // 
            // Launcher22
            // 
            this.Launcher22.BackColor = System.Drawing.Color.Lime;
            this.Launcher22.Enabled = false;
            this.Launcher22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher22.Location = new System.Drawing.Point(114, 511);
            this.Launcher22.Name = "Launcher22";
            this.Launcher22.Size = new System.Drawing.Size(30, 30);
            this.Launcher22.TabIndex = 61;
            this.Launcher22.Tag = "22";
            this.Launcher22.UseVisualStyleBackColor = false;
            // 
            // Launcher23
            // 
            this.Launcher23.BackColor = System.Drawing.Color.Lime;
            this.Launcher23.Enabled = false;
            this.Launcher23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Launcher23.Location = new System.Drawing.Point(150, 511);
            this.Launcher23.Name = "Launcher23";
            this.Launcher23.Size = new System.Drawing.Size(30, 30);
            this.Launcher23.TabIndex = 63;
            this.Launcher23.Tag = "23";
            this.Launcher23.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.groupBox2.Controls.Add(this.button50X);
            this.groupBox2.Controls.Add(this.button10X);
            this.groupBox2.Controls.Add(this.button1X);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(27, 654);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 100);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Speed";
            // 
            // button50X
            // 
            this.button50X.BackColor = System.Drawing.Color.Gainsboro;
            this.button50X.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button50X.Location = new System.Drawing.Point(142, 49);
            this.button50X.Name = "button50X";
            this.button50X.Size = new System.Drawing.Size(56, 45);
            this.button50X.TabIndex = 68;
            this.button50X.Text = "50X";
            this.button50X.UseVisualStyleBackColor = false;
            this.button50X.Click += new System.EventHandler(this.button50X_Click);
            // 
            // button10X
            // 
            this.button10X.BackColor = System.Drawing.Color.Gainsboro;
            this.button10X.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10X.Location = new System.Drawing.Point(75, 49);
            this.button10X.Name = "button10X";
            this.button10X.Size = new System.Drawing.Size(57, 45);
            this.button10X.TabIndex = 67;
            this.button10X.Text = "10X";
            this.button10X.UseVisualStyleBackColor = false;
            this.button10X.Click += new System.EventHandler(this.button10X_Click);
            // 
            // button1X
            // 
            this.button1X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1X.Enabled = false;
            this.button1X.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1X.Location = new System.Drawing.Point(9, 49);
            this.button1X.Name = "button1X";
            this.button1X.Size = new System.Drawing.Size(56, 45);
            this.button1X.TabIndex = 66;
            this.button1X.Text = "1X";
            this.button1X.UseVisualStyleBackColor = false;
            this.button1X.Click += new System.EventHandler(this.button1X_Click);
            // 
            // richTextBoxReport
            // 
            this.richTextBoxReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBoxReport.BackColor = System.Drawing.Color.Black;
            this.richTextBoxReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxReport.ForeColor = System.Drawing.Color.White;
            this.richTextBoxReport.Location = new System.Drawing.Point(456, 398);
            this.richTextBoxReport.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBoxReport.Name = "richTextBoxReport";
            this.richTextBoxReport.ReadOnly = true;
            this.richTextBoxReport.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxReport.Size = new System.Drawing.Size(442, 148);
            this.richTextBoxReport.TabIndex = 66;
            this.richTextBoxReport.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.buttonEngage);
            this.groupBox3.Controls.Add(this.pictureBoxFlipSwitch1);
            this.groupBox3.Controls.Add(this.pictureBoxLight1);
            this.groupBox3.Controls.Add(this.buttonSalvo);
            this.groupBox3.Controls.Add(this.buttonSingle);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(539, 653);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 101);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Engagement Method";
            // 
            // pictureBoxRadar
            // 
            this.pictureBoxRadar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxRadar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRadar.BackgroundImage = global::Air_defense_simulator.Properties.Resources.Radar;
            this.pictureBoxRadar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxRadar.Enabled = false;
            this.pictureBoxRadar.Location = new System.Drawing.Point(361, 14);
            this.pictureBoxRadar.Name = "pictureBoxRadar";
            this.pictureBoxRadar.Size = new System.Drawing.Size(630, 630);
            this.pictureBoxRadar.TabIndex = 30;
            this.pictureBoxRadar.TabStop = false;
            this.pictureBoxRadar.Click += new System.EventHandler(this.pictureBoxRadar_Click);
            // 
            // labelClockHours
            // 
            this.labelClockHours.AutoSize = true;
            this.labelClockHours.BackColor = System.Drawing.Color.Transparent;
            this.labelClockHours.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClockHours.ForeColor = System.Drawing.Color.Red;
            this.labelClockHours.Location = new System.Drawing.Point(3, 3);
            this.labelClockHours.Name = "labelClockHours";
            this.labelClockHours.Size = new System.Drawing.Size(34, 28);
            this.labelClockHours.TabIndex = 0;
            this.labelClockHours.Text = "23";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(30, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 28);
            this.label3.TabIndex = 27;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(69, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = ":";
            // 
            // labelClockMinutes
            // 
            this.labelClockMinutes.AutoSize = true;
            this.labelClockMinutes.BackColor = System.Drawing.Color.Transparent;
            this.labelClockMinutes.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClockMinutes.ForeColor = System.Drawing.Color.Red;
            this.labelClockMinutes.Location = new System.Drawing.Point(40, 3);
            this.labelClockMinutes.Name = "labelClockMinutes";
            this.labelClockMinutes.Size = new System.Drawing.Size(34, 28);
            this.labelClockMinutes.TabIndex = 1;
            this.labelClockMinutes.Text = "59";
            // 
            // labelClockSeconds
            // 
            this.labelClockSeconds.AutoSize = true;
            this.labelClockSeconds.BackColor = System.Drawing.Color.Transparent;
            this.labelClockSeconds.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClockSeconds.ForeColor = System.Drawing.Color.Red;
            this.labelClockSeconds.Location = new System.Drawing.Point(78, 3);
            this.labelClockSeconds.Name = "labelClockSeconds";
            this.labelClockSeconds.Size = new System.Drawing.Size(34, 28);
            this.labelClockSeconds.TabIndex = 28;
            this.labelClockSeconds.Text = "59";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.labelClockSeconds);
            this.panel1.Controls.Add(this.labelClockMinutes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelClockHours);
            this.panel1.Location = new System.Drawing.Point(622, 570);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 34);
            this.panel1.TabIndex = 26;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.groupBox4.Controls.Add(this.buttonSimulation);
            this.groupBox4.Controls.Add(this.buttonGIP);
            this.groupBox4.Controls.Add(this.buttonHideAirway);
            this.groupBox4.Controls.Add(this.buttonShowAirway);
            this.groupBox4.Controls.Add(this.buttonIFF);
            this.groupBox4.Controls.Add(this.buttonIgnoreWarning);
            this.groupBox4.Controls.Add(this.buttonSelect);
            this.groupBox4.Controls.Add(this.buttonUnselect);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(1078, 511);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(274, 237);
            this.groupBox4.TabIndex = 68;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Controls";
            // 
            // buttonSimulation
            // 
            this.buttonSimulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSimulation.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSimulation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSimulation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSimulation.Location = new System.Drawing.Point(6, 34);
            this.buttonSimulation.Name = "buttonSimulation";
            this.buttonSimulation.Size = new System.Drawing.Size(262, 61);
            this.buttonSimulation.TabIndex = 71;
            this.buttonSimulation.Text = "Start Simulation";
            this.buttonSimulation.UseVisualStyleBackColor = false;
            this.buttonSimulation.Click += new System.EventHandler(this.buttonSimulation_Click);
            this.buttonSimulation.MouseEnter += new System.EventHandler(this.buttonSimulation_MouseEnter);
            this.buttonSimulation.MouseLeave += new System.EventHandler(this.buttonSimulation_MouseLeave);
            // 
            // buttonGIP
            // 
            this.buttonGIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGIP.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonGIP.Enabled = false;
            this.buttonGIP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGIP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGIP.Location = new System.Drawing.Point(95, 101);
            this.buttonGIP.Name = "buttonGIP";
            this.buttonGIP.Size = new System.Drawing.Size(83, 61);
            this.buttonGIP.TabIndex = 11;
            this.buttonGIP.Text = "GIP";
            this.buttonGIP.UseVisualStyleBackColor = false;
            this.buttonGIP.Click += new System.EventHandler(this.buttonGIP_Click);
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSettings.Image = global::Air_defense_simulator.Properties.Resources.Gear;
            this.pictureBoxSettings.Location = new System.Drawing.Point(1288, 11);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSettings.TabIndex = 69;
            this.pictureBoxSettings.TabStop = false;
            this.pictureBoxSettings.Click += new System.EventHandler(this.pictureBoxSettings_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::Air_defense_simulator.Properties.Resources.Close;
            this.pictureBoxClose.Location = new System.Drawing.Point(1329, 13);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 70;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // timerNewTarget
            // 
            this.timerNewTarget.Enabled = true;
            this.timerNewTarget.Interval = 3000;
            this.timerNewTarget.Tick += new System.EventHandler(this.timerNewTarget_Tick);
            // 
            // ADS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.pictureBoxSettings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBoxReport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Launcher23);
            this.Controls.Add(this.Launcher24);
            this.Controls.Add(this.Launcher22);
            this.Controls.Add(this.Launcher21);
            this.Controls.Add(this.Launcher19);
            this.Controls.Add(this.Launcher20);
            this.Controls.Add(this.Launcher18);
            this.Controls.Add(this.Launcher17);
            this.Controls.Add(this.Launcher15);
            this.Controls.Add(this.Launcher16);
            this.Controls.Add(this.Launcher14);
            this.Controls.Add(this.Launcher13);
            this.Controls.Add(this.Launcher11);
            this.Controls.Add(this.Launcher12);
            this.Controls.Add(this.Launcher10);
            this.Controls.Add(this.Launcher9);
            this.Controls.Add(this.Launcher7);
            this.Controls.Add(this.Launcher8);
            this.Controls.Add(this.Launcher6);
            this.Controls.Add(this.Launcher5);
            this.Controls.Add(this.Launcher3);
            this.Controls.Add(this.Launcher4);
            this.Controls.Add(this.Launcher2);
            this.Controls.Add(this.Launcher1);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBoxRadar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ADS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Air Defense Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlipSwitch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLight1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRadar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonIFF;
        private Button buttonShowAirway;
        private Button buttonHideAirway;
        private Button buttonIgnoreWarning;
        private Button buttonSelect;
        private Button buttonUnselect;
        private Button buttonSalvo;
        private Button buttonSingle;
        private Button buttonEngage;
        private PictureBox pictureBoxFlipSwitch1;
        private PictureBox pictureBoxLight1;
        private System.Windows.Forms.Timer timerClock;
        private Label label2;
        private Label label5;
        private System.Windows.Forms.Timer timerTargetUpdate;
        private Button button13;
        private Button button14;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button Launcher1;
        private Button Launcher2;
        private Button Launcher4;
        private Button Launcher3;
        private Button Launcher7;
        private Button Launcher8;
        private Button Launcher6;
        private Button Launcher5;
        private Button Launcher11;
        private Button Launcher12;
        private Button Launcher10;
        private Button Launcher9;
        private Button Launcher15;
        private Button Launcher16;
        private Button Launcher14;
        private Button Launcher13;
        private Button Launcher19;
        private Button Launcher20;
        private Button Launcher18;
        private Button Launcher17;
        private Button Launcher24;
        private GroupBox groupBox1;
        private Button Launcher21;
        private Button Launcher22;
        private Button Launcher23;
        private Button buttonReload;
        private GroupBox groupBox2;
        private Button button50X;
        private Button button10X;
        private Button button1X;
        private RichTextBox richTextBoxReport;
        private GroupBox groupBox3;
        private PictureBox pictureBoxRadar;
        private Label labelClockHours;
        private Label label3;
        private Label label4;
        private Label labelClockMinutes;
        private Label labelClockSeconds;
        private Panel panel1;
        private GroupBox groupBox4;
        private PictureBox pictureBoxSettings;
        private PictureBox pictureBoxClose;
        private Button buttonGIP;
        private Button buttonSimulation;
        private System.Windows.Forms.Timer timerNewTarget;
    }
}