namespace cs_ais_hotel_dll
{
    partial class frmAISHotelDllTester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAISHotelDllTester));
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPortOpen = new System.Windows.Forms.ToolStripButton();
            this.btnPortClose = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editID = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGetStatus = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGetTime = new System.Windows.Forms.ToolStripButton();
            this.btnSetTime = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGetDLLVersion = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip3 = new System.Windows.Forms.ToolStrip();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.eBlackCard = new System.Windows.Forms.ToolStripTextBox();
            this.btnBlockCard = new System.Windows.Forms.ToolStripButton();
            this.btnUnblockCard = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUnblockAll = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnGetLastRTE = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip1.SuspendLayout();
            this.ToolStrip3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPortOpen,
            this.btnPortClose,
            this.ToolStripSeparator1,
            this.editID,
            this.ToolStripSeparator5,
            this.btnGetStatus,
            this.ToolStripSeparator2,
            this.btnGetTime,
            this.btnSetTime,
            this.toolStripSeparator3,
            this.btnGetDLLVersion});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ToolStrip1.Size = new System.Drawing.Size(790, 25);
            this.ToolStrip1.TabIndex = 13;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // btnPortOpen
            // 
            this.btnPortOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPortOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnPortOpen.Image")));
            this.btnPortOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPortOpen.Name = "btnPortOpen";
            this.btnPortOpen.Size = new System.Drawing.Size(62, 22);
            this.btnPortOpen.Text = "PortOpen";
            this.btnPortOpen.Click += new System.EventHandler(this.btnPortOpen_Click);
            // 
            // btnPortClose
            // 
            this.btnPortClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPortClose.Image = ((System.Drawing.Image)(resources.GetObject("btnPortClose.Image")));
            this.btnPortClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPortClose.Name = "btnPortClose";
            this.btnPortClose.Size = new System.Drawing.Size(62, 22);
            this.btnPortClose.Text = "PortClose";
            this.btnPortClose.Click += new System.EventHandler(this.btnPortClose_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // editID
            // 
            this.editID.Name = "editID";
            this.editID.Size = new System.Drawing.Size(30, 25);
            this.editID.Text = "1";
            this.editID.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editID.Leave += new System.EventHandler(this.editID_Leave);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGetStatus
            // 
            this.btnGetStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGetStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnGetStatus.Image")));
            this.btnGetStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGetStatus.Name = "btnGetStatus";
            this.btnGetStatus.Size = new System.Drawing.Size(77, 22);
            this.btnGetStatus.Text = "GET STATUS";
            this.btnGetStatus.Click += new System.EventHandler(this.btnGetStatus_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGetTime
            // 
            this.btnGetTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGetTime.Image = ((System.Drawing.Image)(resources.GetObject("btnGetTime.Image")));
            this.btnGetTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGetTime.Name = "btnGetTime";
            this.btnGetTime.Size = new System.Drawing.Size(59, 22);
            this.btnGetTime.Text = "Get Time";
            this.btnGetTime.Click += new System.EventHandler(this.btnGetTime_Click);
            // 
            // btnSetTime
            // 
            this.btnSetTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSetTime.Image = ((System.Drawing.Image)(resources.GetObject("btnSetTime.Image")));
            this.btnSetTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(57, 22);
            this.btnSetTime.Text = "Set Time";
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGetDLLVersion
            // 
            this.btnGetDLLVersion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnGetDLLVersion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGetDLLVersion.Image = ((System.Drawing.Image)(resources.GetObject("btnGetDLLVersion.Image")));
            this.btnGetDLLVersion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGetDLLVersion.Name = "btnGetDLLVersion";
            this.btnGetDLLVersion.Size = new System.Drawing.Size(88, 22);
            this.btnGetDLLVersion.Text = "GetDLLVersion";
            this.btnGetDLLVersion.Click += new System.EventHandler(this.btnGetDLLVersion_Click);
            // 
            // ToolStrip3
            // 
            this.ToolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabel1,
            this.eBlackCard,
            this.btnBlockCard,
            this.btnUnblockCard,
            this.ToolStripSeparator4,
            this.btnUnblockAll,
            this.btnGetLastRTE});
            this.ToolStrip3.Location = new System.Drawing.Point(0, 25);
            this.ToolStrip3.Name = "ToolStrip3";
            this.ToolStrip3.Size = new System.Drawing.Size(790, 25);
            this.ToolStrip3.TabIndex = 15;
            this.ToolStrip3.Text = "ToolStrip3";
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(53, 22);
            this.ToolStripLabel1.Text = "Blacklist:";
            // 
            // eBlackCard
            // 
            this.eBlackCard.Name = "eBlackCard";
            this.eBlackCard.Size = new System.Drawing.Size(50, 25);
            this.eBlackCard.Text = "9";
            this.eBlackCard.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eBlackCard.Leave += new System.EventHandler(this.eBlackCard_Leave);
            // 
            // btnBlockCard
            // 
            this.btnBlockCard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBlockCard.Image = ((System.Drawing.Image)(resources.GetObject("btnBlockCard.Image")));
            this.btnBlockCard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBlockCard.Name = "btnBlockCard";
            this.btnBlockCard.Size = new System.Drawing.Size(65, 22);
            this.btnBlockCard.Text = "BlockCard";
            this.btnBlockCard.Click += new System.EventHandler(this.btnBlockCard_Click);
            // 
            // btnUnblockCard
            // 
            this.btnUnblockCard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUnblockCard.Image = ((System.Drawing.Image)(resources.GetObject("btnUnblockCard.Image")));
            this.btnUnblockCard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnblockCard.Name = "btnUnblockCard";
            this.btnUnblockCard.Size = new System.Drawing.Size(80, 22);
            this.btnUnblockCard.Text = "UnblockCard";
            this.btnUnblockCard.Click += new System.EventHandler(this.btnUnblockCard_Click);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnUnblockAll
            // 
            this.btnUnblockAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUnblockAll.Image = ((System.Drawing.Image)(resources.GetObject("btnUnblockAll.Image")));
            this.btnUnblockAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnblockAll.Name = "btnUnblockAll";
            this.btnUnblockAll.Size = new System.Drawing.Size(69, 22);
            this.btnUnblockAll.Text = "UnblockAll";
            this.btnUnblockAll.Click += new System.EventHandler(this.btnUnblockAll_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 416);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(790, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(66, 17);
            this.statusLabel.Text = "statusLabel";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(790, 366);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // btnGetLastRTE
            // 
            this.btnGetLastRTE.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnGetLastRTE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGetLastRTE.Image = ((System.Drawing.Image)(resources.GetObject("btnGetLastRTE.Image")));
            this.btnGetLastRTE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGetLastRTE.Name = "btnGetLastRTE";
            this.btnGetLastRTE.Size = new System.Drawing.Size(70, 22);
            this.btnGetLastRTE.Text = "GetLastRTE";
            this.btnGetLastRTE.Click += new System.EventHandler(this.btnGetLastRTE_Click);
            // 
            // frmAISHotelDllTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 438);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ToolStrip3);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "frmAISHotelDllTester";
            this.Text = "frmAISHotelDllTester";
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ToolStrip3.ResumeLayout(false);
            this.ToolStrip3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btnPortOpen;
        internal System.Windows.Forms.ToolStripButton btnPortClose;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripTextBox editID;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
        internal System.Windows.Forms.ToolStripButton btnGetStatus;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton btnGetTime;
        internal System.Windows.Forms.ToolStripButton btnSetTime;
        internal System.Windows.Forms.ToolStrip ToolStrip3;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel1;
        internal System.Windows.Forms.ToolStripTextBox eBlackCard;
        internal System.Windows.Forms.ToolStripButton btnBlockCard;
        internal System.Windows.Forms.ToolStripButton btnUnblockCard;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        internal System.Windows.Forms.ToolStripButton btnUnblockAll;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnGetDLLVersion;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripButton btnGetLastRTE;
    }
}

