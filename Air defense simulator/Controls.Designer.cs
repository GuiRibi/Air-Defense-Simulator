namespace Menu
{
    partial class Controls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controls));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSelecting = new System.Windows.Forms.Label();
            this.labelFiring = new System.Windows.Forms.Label();
            this.labelIFF = new System.Windows.Forms.Label();
            this.labelUnselecting = new System.Windows.Forms.Label();
            this.labelUnderstanding = new System.Windows.Forms.Label();
            this.labelReloading = new System.Windows.Forms.Label();
            this.labelGIP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelText1 = new System.Windows.Forms.Label();
            this.richTextBoxText1 = new System.Windows.Forms.RichTextBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controls";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.62763F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.37238F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSelecting, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelFiring, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelIFF, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelUnselecting, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelUnderstanding, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelReloading, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelGIP, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 691);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelSelecting
            // 
            this.labelSelecting.AutoSize = true;
            this.labelSelecting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSelecting.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelecting.ForeColor = System.Drawing.Color.White;
            this.labelSelecting.Location = new System.Drawing.Point(94, 102);
            this.labelSelecting.Name = "labelSelecting";
            this.labelSelecting.Size = new System.Drawing.Size(126, 20);
            this.labelSelecting.TabIndex = 1;
            this.labelSelecting.Text = "Selecting a target";
            this.labelSelecting.Click += new System.EventHandler(this.labelSelecting_Click);
            this.labelSelecting.MouseEnter += new System.EventHandler(this.labelSelecting_MouseEnter);
            this.labelSelecting.MouseLeave += new System.EventHandler(this.labelSelecting_MouseLeave);
            // 
            // labelFiring
            // 
            this.labelFiring.AutoSize = true;
            this.labelFiring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFiring.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFiring.ForeColor = System.Drawing.Color.White;
            this.labelFiring.Location = new System.Drawing.Point(94, 244);
            this.labelFiring.Name = "labelFiring";
            this.labelFiring.Size = new System.Drawing.Size(107, 20);
            this.labelFiring.TabIndex = 2;
            this.labelFiring.Text = "Firing a missile";
            this.labelFiring.Click += new System.EventHandler(this.labelFiring_Click);
            this.labelFiring.MouseEnter += new System.EventHandler(this.labelFiring_MouseEnter);
            this.labelFiring.MouseLeave += new System.EventHandler(this.labelFiring_MouseLeave);
            // 
            // labelIFF
            // 
            this.labelIFF.AutoSize = true;
            this.labelIFF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelIFF.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIFF.ForeColor = System.Drawing.Color.White;
            this.labelIFF.Location = new System.Drawing.Point(94, 170);
            this.labelIFF.Name = "labelIFF";
            this.labelIFF.Size = new System.Drawing.Size(171, 20);
            this.labelIFF.TabIndex = 3;
            this.labelIFF.Text = "Identifying Friend or Foe";
            this.labelIFF.Click += new System.EventHandler(this.labelIFF_Click);
            this.labelIFF.MouseEnter += new System.EventHandler(this.labelIFF_MouseEnter);
            this.labelIFF.MouseLeave += new System.EventHandler(this.labelIFF_MouseLeave);
            // 
            // labelUnselecting
            // 
            this.labelUnselecting.AutoSize = true;
            this.labelUnselecting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelUnselecting.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnselecting.ForeColor = System.Drawing.Color.White;
            this.labelUnselecting.Location = new System.Drawing.Point(94, 316);
            this.labelUnselecting.Name = "labelUnselecting";
            this.labelUnselecting.Size = new System.Drawing.Size(142, 20);
            this.labelUnselecting.TabIndex = 4;
            this.labelUnselecting.Text = "Unselecting a target";
            this.labelUnselecting.Click += new System.EventHandler(this.labelUnselecting_Click);
            this.labelUnselecting.MouseEnter += new System.EventHandler(this.labelUnselecting_MouseEnter);
            this.labelUnselecting.MouseLeave += new System.EventHandler(this.labelUnselecting_MouseLeave);
            // 
            // labelUnderstanding
            // 
            this.labelUnderstanding.AutoSize = true;
            this.labelUnderstanding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(54)))));
            this.labelUnderstanding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelUnderstanding.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUnderstanding.ForeColor = System.Drawing.Color.White;
            this.labelUnderstanding.Location = new System.Drawing.Point(94, 35);
            this.labelUnderstanding.Name = "labelUnderstanding";
            this.labelUnderstanding.Size = new System.Drawing.Size(191, 20);
            this.labelUnderstanding.TabIndex = 5;
            this.labelUnderstanding.Text = "Understanding the visuals";
            this.labelUnderstanding.Click += new System.EventHandler(this.labelUnderstanding_Click);
            this.labelUnderstanding.MouseEnter += new System.EventHandler(this.labelUnderstanding_MouseEnter);
            this.labelUnderstanding.MouseLeave += new System.EventHandler(this.labelUnderstanding_MouseLeave);
            // 
            // labelReloading
            // 
            this.labelReloading.AutoSize = true;
            this.labelReloading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelReloading.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelReloading.ForeColor = System.Drawing.Color.White;
            this.labelReloading.Location = new System.Drawing.Point(94, 389);
            this.labelReloading.Name = "labelReloading";
            this.labelReloading.Size = new System.Drawing.Size(77, 20);
            this.labelReloading.TabIndex = 6;
            this.labelReloading.Text = "Reloading";
            this.labelReloading.Click += new System.EventHandler(this.labelReloading_Click);
            this.labelReloading.MouseEnter += new System.EventHandler(this.labelReloading_MouseEnter);
            this.labelReloading.MouseLeave += new System.EventHandler(this.labelReloading_MouseLeave);
            // 
            // labelGIP
            // 
            this.labelGIP.AutoSize = true;
            this.labelGIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGIP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGIP.ForeColor = System.Drawing.Color.White;
            this.labelGIP.Location = new System.Drawing.Point(94, 456);
            this.labelGIP.Name = "labelGIP";
            this.labelGIP.Size = new System.Drawing.Size(145, 20);
            this.labelGIP.TabIndex = 7;
            this.labelGIP.Text = "Ground Impact Point";
            this.labelGIP.Click += new System.EventHandler(this.labelGIP_Click);
            this.labelGIP.MouseEnter += new System.EventHandler(this.labelGIP_MouseEnter);
            this.labelGIP.MouseLeave += new System.EventHandler(this.labelGIP_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Air_defense_simulator.Properties.Resources.Understanding;
            this.pictureBox1.Location = new System.Drawing.Point(361, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "1";
            // 
            // labelText1
            // 
            this.labelText1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelText1.AutoSize = true;
            this.labelText1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelText1.ForeColor = System.Drawing.Color.White;
            this.labelText1.Location = new System.Drawing.Point(361, 24);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(493, 20);
            this.labelText1.TabIndex = 6;
            this.labelText1.Text = "This is the Control Panel of the Air Defense System you will be operating. \r\n";
            // 
            // richTextBoxText1
            // 
            this.richTextBoxText1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(54)))));
            this.richTextBoxText1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxText1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxText1.ForeColor = System.Drawing.Color.White;
            this.richTextBoxText1.Location = new System.Drawing.Point(361, 383);
            this.richTextBoxText1.Name = "richTextBoxText1";
            this.richTextBoxText1.ReadOnly = true;
            this.richTextBoxText1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxText1.Size = new System.Drawing.Size(549, 296);
            this.richTextBoxText1.TabIndex = 7;
            this.richTextBoxText1.Text = resources.GetString("richTextBoxText1.Text");
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::Air_defense_simulator.Properties.Resources.Xwhite;
            this.pictureBoxClose.Location = new System.Drawing.Point(957, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(22, 23);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 8;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.richTextBoxText1);
            this.Controls.Add(this.labelText1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Controls";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controls";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelSelecting;
        private Label labelFiring;
        private Label labelIFF;
        private Label labelUnselecting;
        private Label labelUnderstanding;
        private PictureBox pictureBox1;
        private Label labelText1;
        private RichTextBox richTextBoxText1;
        private PictureBox pictureBoxClose;
        private Label labelReloading;
        private Label labelGIP;
    }
}