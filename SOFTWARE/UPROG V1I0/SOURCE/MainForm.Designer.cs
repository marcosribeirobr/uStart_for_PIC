
namespace BootProgUsb
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MainForm_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainForm_Open_File = new System.Windows.Forms.Button();
            this.MainForm_Disconnect = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.MainForm_Upload = new System.Windows.Forms.Button();
            this.MainForm_Progress = new System.Windows.Forms.ProgressBar();
            this.MainForm_USB_Status = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.PortaUSB = new UsbLibrary.UsbHidPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.MainForm_MCU_Device = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainForm_USB_Status)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Red;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainForm_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 307);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(312, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // MainForm_Status
            // 
            this.MainForm_Status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MainForm_Status.ForeColor = System.Drawing.Color.White;
            this.MainForm_Status.Name = "MainForm_Status";
            this.MainForm_Status.Size = new System.Drawing.Size(297, 17);
            this.MainForm_Status.Spring = true;
            this.MainForm_Status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MainForm_Status.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.MainForm_Status.Click += new System.EventHandler(this.MainForm_Status_Click);
            // 
            // MainForm_Open_File
            // 
            this.MainForm_Open_File.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainForm_Open_File.Enabled = false;
            this.MainForm_Open_File.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainForm_Open_File.ForeColor = System.Drawing.Color.Black;
            this.MainForm_Open_File.Location = new System.Drawing.Point(175, 163);
            this.MainForm_Open_File.Name = "MainForm_Open_File";
            this.MainForm_Open_File.Size = new System.Drawing.Size(115, 39);
            this.MainForm_Open_File.TabIndex = 2;
            this.MainForm_Open_File.TabStop = false;
            this.MainForm_Open_File.Text = "ABRIR";
            this.MainForm_Open_File.UseVisualStyleBackColor = true;
            this.MainForm_Open_File.Click += new System.EventHandler(this.MainForm_Open_FileClick);
            // 
            // MainForm_Disconnect
            // 
            this.MainForm_Disconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainForm_Disconnect.Enabled = false;
            this.MainForm_Disconnect.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainForm_Disconnect.ForeColor = System.Drawing.Color.Black;
            this.MainForm_Disconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainForm_Disconnect.Location = new System.Drawing.Point(175, 103);
            this.MainForm_Disconnect.Name = "MainForm_Disconnect";
            this.MainForm_Disconnect.Size = new System.Drawing.Size(115, 39);
            this.MainForm_Disconnect.TabIndex = 1;
            this.MainForm_Disconnect.TabStop = false;
            this.MainForm_Disconnect.Text = "CONECTAR";
            this.MainForm_Disconnect.UseVisualStyleBackColor = true;
            this.MainForm_Disconnect.Click += new System.EventHandler(this.MainForm_DisconnectClick);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            this.openFile.Filter = "Hex Files|*.hex";
            this.openFile.RestoreDirectory = true;
            // 
            // MainForm_Upload
            // 
            this.MainForm_Upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainForm_Upload.Enabled = false;
            this.MainForm_Upload.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainForm_Upload.ForeColor = System.Drawing.Color.Black;
            this.MainForm_Upload.Location = new System.Drawing.Point(175, 223);
            this.MainForm_Upload.Name = "MainForm_Upload";
            this.MainForm_Upload.Size = new System.Drawing.Size(115, 39);
            this.MainForm_Upload.TabIndex = 3;
            this.MainForm_Upload.TabStop = false;
            this.MainForm_Upload.Text = "UPLOAD";
            this.MainForm_Upload.UseVisualStyleBackColor = true;
            this.MainForm_Upload.Click += new System.EventHandler(this.MainForm_UploadClick);
            // 
            // MainForm_Progress
            // 
            this.MainForm_Progress.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.MainForm_Progress.Location = new System.Drawing.Point(0, 275);
            this.MainForm_Progress.Name = "MainForm_Progress";
            this.MainForm_Progress.Size = new System.Drawing.Size(312, 29);
            this.MainForm_Progress.Step = 1;
            this.MainForm_Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.MainForm_Progress.TabIndex = 8;
            this.MainForm_Progress.Click += new System.EventHandler(this.MainForm_Progress_Click);
            // 
            // MainForm_USB_Status
            // 
            this.MainForm_USB_Status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainForm_USB_Status.Enabled = false;
            this.MainForm_USB_Status.Location = new System.Drawing.Point(205, 43);
            this.MainForm_USB_Status.Name = "MainForm_USB_Status";
            this.MainForm_USB_Status.Size = new System.Drawing.Size(54, 48);
            this.MainForm_USB_Status.TabIndex = 11;
            this.MainForm_USB_Status.TabStop = false;
            this.MainForm_USB_Status.Click += new System.EventHandler(this.MainForm_USB_Status_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3500;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.MainForm_MCU_Device});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(312, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.ToolTipText = "Chip Info";
            this.toolStripButton1.Click += new System.EventHandler(this.BtnInfoClick);
            // 
            // PortaUSB
            // 
            this.PortaUSB.ProductId = 1;
            this.PortaUSB.VendorId = 1;
            this.PortaUSB.OnSpecifiedDeviceArrived += new System.EventHandler(this.PortaUSBOnSpecifiedDeviceArrived);
            this.PortaUSB.OnSpecifiedDeviceRemoved += new System.EventHandler(this.PortaUSBOnSpecifiedDeviceRemoved);
            this.PortaUSB.OnDataRecieved += new UsbLibrary.DataRecievedEventHandler(this.DadosRecebidosDoPIC);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(63, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Conectar";
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(63, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "μStart for PIC";
            this.label2.UseMnemonic = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(14, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 42);
            this.label3.TabIndex = 16;
            this.label3.Text = "2";
            this.label3.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(14, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 42);
            this.label4.TabIndex = 17;
            this.label4.Text = "3";
            this.label4.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(14, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 42);
            this.label5.TabIndex = 18;
            this.label5.Text = "4";
            this.label5.UseMnemonic = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(14, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 42);
            this.label6.TabIndex = 19;
            this.label6.Text = "1";
            this.label6.UseMnemonic = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(63, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Aguardar";
            this.label7.UseMnemonic = false;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(63, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "link USB";
            this.label8.UseMnemonic = false;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(65, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Abrir";
            this.label9.UseMnemonic = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(66, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "arquivo .HEX";
            this.label10.UseMnemonic = false;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(66, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Iniciar";
            this.label11.UseMnemonic = false;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(66, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Upload";
            this.label12.UseMnemonic = false;
            // 
            // MainForm_MCU_Device
            // 
            this.MainForm_MCU_Device.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MainForm_MCU_Device.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.MainForm_MCU_Device.ForeColor = System.Drawing.Color.White;
            this.MainForm_MCU_Device.Name = "MainForm_MCU_Device";
            this.MainForm_MCU_Device.Size = new System.Drawing.Size(102, 22);
            this.MainForm_MCU_Device.Text = "Desconhecido";
            this.MainForm_MCU_Device.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.MainForm_MCU_Device.Click += new System.EventHandler(this.MainForm_MCU_Device_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(312, 329);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MainForm_USB_Status);
            this.Controls.Add(this.MainForm_Progress);
            this.Controls.Add(this.MainForm_Upload);
            this.Controls.Add(this.MainForm_Disconnect);
            this.Controls.Add(this.MainForm_Open_File);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "μProg for PIC ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainForm_USB_Status)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private UsbLibrary.UsbHidPort PortaUSB;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox MainForm_USB_Status;
		private System.Windows.Forms.ProgressBar MainForm_Progress;
        private System.Windows.Forms.Button MainForm_Upload;
		private System.Windows.Forms.OpenFileDialog openFile;
		private System.Windows.Forms.Button MainForm_Disconnect;
		private System.Windows.Forms.Button MainForm_Open_File;
		private System.Windows.Forms.ToolStripStatusLabel MainForm_Status;
		private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripLabel MainForm_MCU_Device;
	}
}
