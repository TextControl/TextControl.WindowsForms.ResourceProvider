namespace tx_resource
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbDpi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCulture = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rb32 = new System.Windows.Forms.RadioButton();
            this.rb16 = new System.Windows.Forms.RadioButton();
            this.cbRibbonTabs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangeFillColor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panelFillColor = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChangeStrokeColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelStrokeColor = new System.Windows.Forms.Panel();
            this.lblSelectedResource = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbKeyTip = new System.Windows.Forms.TextBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbToolTipDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbToolTipTitle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(751, 420);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cbDpi
            // 
            this.cbDpi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDpi.FormattingEnabled = true;
            this.cbDpi.Items.AddRange(new object[] {
            "96",
            "144",
            "192",
            "288",
            "384"});
            this.cbDpi.Location = new System.Drawing.Point(96, 40);
            this.cbDpi.Name = "cbDpi";
            this.cbDpi.Size = new System.Drawing.Size(121, 21);
            this.cbDpi.TabIndex = 1;
            this.cbDpi.SelectedValueChanged += new System.EventHandler(this.cbDpi_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DPI:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbToolTipTitle);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.tbToolTipDescription);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.tbText);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.tbKeyTip);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.lblSelectedResource);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1MinSize = 320;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(1075, 582);
            this.splitContainer1.SplitterDistance = 320;
            this.splitContainer1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preview:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(272, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 420);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cbRibbonTabs);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 162);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelStrokeColor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.panelFillColor);
            this.groupBox2.Controls.Add(this.btnChangeStrokeColor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnChangeFillColor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbCulture);
            this.groupBox2.Location = new System.Drawing.Point(317, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 139);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Culture:";
            // 
            // cbCulture
            // 
            this.cbCulture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCulture.FormattingEnabled = true;
            this.cbCulture.Items.AddRange(new object[] {
            "en-US",
            "de-DE"});
            this.cbCulture.Location = new System.Drawing.Point(10, 44);
            this.cbCulture.Name = "cbCulture";
            this.cbCulture.Size = new System.Drawing.Size(152, 21);
            this.cbCulture.TabIndex = 8;
            this.cbCulture.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rb32);
            this.groupBox1.Controls.Add(this.cbDpi);
            this.groupBox1.Controls.Add(this.rb16);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 87);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Size Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Raster size:";
            // 
            // rb32
            // 
            this.rb32.AutoSize = true;
            this.rb32.Location = new System.Drawing.Point(9, 56);
            this.rb32.Name = "rb32";
            this.rb32.Size = new System.Drawing.Size(48, 17);
            this.rb32.TabIndex = 7;
            this.rb32.Text = "32px";
            this.rb32.UseVisualStyleBackColor = true;
            this.rb32.CheckedChanged += new System.EventHandler(this.rb32_CheckedChanged);
            // 
            // rb16
            // 
            this.rb16.AutoSize = true;
            this.rb16.Checked = true;
            this.rb16.Location = new System.Drawing.Point(9, 40);
            this.rb16.Name = "rb16";
            this.rb16.Size = new System.Drawing.Size(48, 17);
            this.rb16.TabIndex = 6;
            this.rb16.TabStop = true;
            this.rb16.Text = "16px";
            this.rb16.UseVisualStyleBackColor = true;
            // 
            // cbRibbonTabs
            // 
            this.cbRibbonTabs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRibbonTabs.FormattingEnabled = true;
            this.cbRibbonTabs.Location = new System.Drawing.Point(6, 26);
            this.cbRibbonTabs.Name = "cbRibbonTabs";
            this.cbRibbonTabs.Size = new System.Drawing.Size(296, 21);
            this.cbRibbonTabs.TabIndex = 4;
            this.cbRibbonTabs.SelectedIndexChanged += new System.EventHandler(this.cbRibbonTabs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Ribbon Tab:";
            // 
            // btnChangeFillColor
            // 
            this.btnChangeFillColor.Location = new System.Drawing.Point(38, 93);
            this.btnChangeFillColor.Name = "btnChangeFillColor";
            this.btnChangeFillColor.Size = new System.Drawing.Size(39, 25);
            this.btnChangeFillColor.TabIndex = 10;
            this.btnChangeFillColor.Text = "...";
            this.btnChangeFillColor.UseVisualStyleBackColor = true;
            this.btnChangeFillColor.Click += new System.EventHandler(this.btnChangeFillColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fill Color:";
            // 
            // panelFillColor
            // 
            this.panelFillColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFillColor.Location = new System.Drawing.Point(10, 93);
            this.panelFillColor.Margin = new System.Windows.Forms.Padding(0);
            this.panelFillColor.Name = "panelFillColor";
            this.panelFillColor.Size = new System.Drawing.Size(25, 25);
            this.panelFillColor.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Stroke Color:";
            // 
            // btnChangeStrokeColor
            // 
            this.btnChangeStrokeColor.Location = new System.Drawing.Point(124, 93);
            this.btnChangeStrokeColor.Name = "btnChangeStrokeColor";
            this.btnChangeStrokeColor.Size = new System.Drawing.Size(39, 25);
            this.btnChangeStrokeColor.TabIndex = 13;
            this.btnChangeStrokeColor.Text = "...";
            this.btnChangeStrokeColor.UseVisualStyleBackColor = true;
            this.btnChangeStrokeColor.Click += new System.EventHandler(this.btnChangeStrokeColor_Click);
            // 
            // panelStrokeColor
            // 
            this.panelStrokeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStrokeColor.Location = new System.Drawing.Point(96, 93);
            this.panelStrokeColor.Margin = new System.Windows.Forms.Padding(0);
            this.panelStrokeColor.Name = "panelStrokeColor";
            this.panelStrokeColor.Size = new System.Drawing.Size(25, 25);
            this.panelStrokeColor.TabIndex = 13;
            // 
            // lblSelectedResource
            // 
            this.lblSelectedResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedResource.Location = new System.Drawing.Point(12, 25);
            this.lblSelectedResource.Name = "lblSelectedResource";
            this.lblSelectedResource.ReadOnly = true;
            this.lblSelectedResource.Size = new System.Drawing.Size(268, 26);
            this.lblSelectedResource.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Key Tip:";
            // 
            // tbKeyTip
            // 
            this.tbKeyTip.Location = new System.Drawing.Point(12, 380);
            this.tbKeyTip.Name = "tbKeyTip";
            this.tbKeyTip.ReadOnly = true;
            this.tbKeyTip.Size = new System.Drawing.Size(272, 20);
            this.tbKeyTip.TabIndex = 7;
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(12, 424);
            this.tbText.Name = "tbText";
            this.tbText.ReadOnly = true;
            this.tbText.Size = new System.Drawing.Size(272, 20);
            this.tbText.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Text:";
            // 
            // tbToolTipDescription
            // 
            this.tbToolTipDescription.Location = new System.Drawing.Point(12, 468);
            this.tbToolTipDescription.Multiline = true;
            this.tbToolTipDescription.Name = "tbToolTipDescription";
            this.tbToolTipDescription.ReadOnly = true;
            this.tbToolTipDescription.Size = new System.Drawing.Size(272, 47);
            this.tbToolTipDescription.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "ToolTip Description:";
            // 
            // tbToolTipTitle
            // 
            this.tbToolTipTitle.Location = new System.Drawing.Point(12, 539);
            this.tbToolTipTitle.Name = "tbToolTipTitle";
            this.tbToolTipTitle.ReadOnly = true;
            this.tbToolTipTitle.Size = new System.Drawing.Size(272, 20);
            this.tbToolTipTitle.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 523);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "ToolTip Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 582);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TX Text Control Resource Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cbDpi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cbRibbonTabs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rb32;
        private System.Windows.Forms.RadioButton rb16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCulture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChangeFillColor;
        private System.Windows.Forms.Panel panelFillColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChangeStrokeColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelStrokeColor;
        private System.Windows.Forms.TextBox lblSelectedResource;
        private System.Windows.Forms.TextBox tbKeyTip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbToolTipDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbToolTipTitle;
        private System.Windows.Forms.Label label11;
    }
}

