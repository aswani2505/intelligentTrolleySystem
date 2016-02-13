namespace ShoppingMarket
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.btn_GetBill = new RibbonStyle.RibbonMenuButton();
            this.btn_EmptyTroley = new RibbonStyle.RibbonMenuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TroleyNo = new System.Windows.Forms.TextBox();
            this.gv = new System.Windows.Forms.DataGridView();
            this.cmb_Com = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Port = new RibbonStyle.RibbonMenuButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // port
            // 
            this.port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.port_DataReceived);
            // 
            // btn_GetBill
            // 
            this.btn_GetBill.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.btn_GetBill.BackColor = System.Drawing.Color.Transparent;
            this.btn_GetBill.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.btn_GetBill.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.btn_GetBill.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.btn_GetBill.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.btn_GetBill.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_GetBill.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_GetBill.FadingSpeed = 20;
            this.btn_GetBill.FlatAppearance.BorderSize = 0;
            this.btn_GetBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GetBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetBill.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_GetBill.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.btn_GetBill.Image = ((System.Drawing.Image)(resources.GetObject("btn_GetBill.Image")));
            this.btn_GetBill.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.btn_GetBill.ImageOffset = 5;
            this.btn_GetBill.IsPressed = false;
            this.btn_GetBill.KeepPress = false;
            this.btn_GetBill.Location = new System.Drawing.Point(80, 161);
            this.btn_GetBill.MaxImageSize = new System.Drawing.Point(0, 0);
            this.btn_GetBill.MenuPos = new System.Drawing.Point(0, 0);
            this.btn_GetBill.Name = "btn_GetBill";
            this.btn_GetBill.Radius = 4;
            this.btn_GetBill.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.btn_GetBill.Size = new System.Drawing.Size(94, 30);
            this.btn_GetBill.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.btn_GetBill.SplitDistance = 0;
            this.btn_GetBill.TabIndex = 72;
            this.btn_GetBill.Text = "Get Bill";
            this.btn_GetBill.Title = "";
            this.btn_GetBill.UseVisualStyleBackColor = true;
            this.btn_GetBill.Click += new System.EventHandler(this.btn_GetBill_Click);
            // 
            // btn_EmptyTroley
            // 
            this.btn_EmptyTroley.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.btn_EmptyTroley.BackColor = System.Drawing.Color.Transparent;
            this.btn_EmptyTroley.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.btn_EmptyTroley.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btn_EmptyTroley.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.btn_EmptyTroley.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.btn_EmptyTroley.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_EmptyTroley.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))), ((int)(((byte)(0)))));
            this.btn_EmptyTroley.FadingSpeed = 20;
            this.btn_EmptyTroley.FlatAppearance.BorderSize = 0;
            this.btn_EmptyTroley.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EmptyTroley.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EmptyTroley.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_EmptyTroley.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.btn_EmptyTroley.Image = ((System.Drawing.Image)(resources.GetObject("btn_EmptyTroley.Image")));
            this.btn_EmptyTroley.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.btn_EmptyTroley.ImageOffset = 5;
            this.btn_EmptyTroley.IsPressed = false;
            this.btn_EmptyTroley.KeepPress = false;
            this.btn_EmptyTroley.Location = new System.Drawing.Point(208, 161);
            this.btn_EmptyTroley.MaxImageSize = new System.Drawing.Point(0, 0);
            this.btn_EmptyTroley.MenuPos = new System.Drawing.Point(0, 0);
            this.btn_EmptyTroley.Name = "btn_EmptyTroley";
            this.btn_EmptyTroley.Radius = 4;
            this.btn_EmptyTroley.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.btn_EmptyTroley.Size = new System.Drawing.Size(108, 30);
            this.btn_EmptyTroley.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.btn_EmptyTroley.SplitDistance = 0;
            this.btn_EmptyTroley.TabIndex = 71;
            this.btn_EmptyTroley.Text = "Empty Trolley";
            this.btn_EmptyTroley.Title = "";
            this.btn_EmptyTroley.UseVisualStyleBackColor = true;
            this.btn_EmptyTroley.Click += new System.EventHandler(this.btn_EmptyTroley_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Troley No.";
            // 
            // txt_TroleyNo
            // 
            this.txt_TroleyNo.Location = new System.Drawing.Point(166, 120);
            this.txt_TroleyNo.Name = "txt_TroleyNo";
            this.txt_TroleyNo.Size = new System.Drawing.Size(100, 20);
            this.txt_TroleyNo.TabIndex = 74;
            // 
            // gv
            // 
            this.gv.AllowUserToAddRows = false;
            this.gv.AllowUserToDeleteRows = false;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(8, 211);
            this.gv.Name = "gv";
            this.gv.ReadOnly = true;
            this.gv.Size = new System.Drawing.Size(414, 195);
            this.gv.TabIndex = 75;
            // 
            // cmb_Com
            // 
            this.cmb_Com.FormattingEnabled = true;
            this.cmb_Com.Location = new System.Drawing.Point(126, 76);
            this.cmb_Com.Name = "cmb_Com";
            this.cmb_Com.Size = new System.Drawing.Size(121, 21);
            this.cmb_Com.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Select COM Port";
            // 
            // btn_Port
            // 
            this.btn_Port.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.btn_Port.BackColor = System.Drawing.Color.Transparent;
            this.btn_Port.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.btn_Port.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.btn_Port.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.btn_Port.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.btn_Port.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Port.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Port.FadingSpeed = 20;
            this.btn_Port.FlatAppearance.BorderSize = 0;
            this.btn_Port.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Port.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Port.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Port.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.btn_Port.Image = ((System.Drawing.Image)(resources.GetObject("btn_Port.Image")));
            this.btn_Port.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.btn_Port.ImageOffset = 5;
            this.btn_Port.IsPressed = false;
            this.btn_Port.KeepPress = false;
            this.btn_Port.Location = new System.Drawing.Point(288, 70);
            this.btn_Port.MaxImageSize = new System.Drawing.Point(0, 0);
            this.btn_Port.MenuPos = new System.Drawing.Point(0, 0);
            this.btn_Port.Name = "btn_Port";
            this.btn_Port.Radius = 4;
            this.btn_Port.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.btn_Port.Size = new System.Drawing.Size(94, 30);
            this.btn_Port.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.btn_Port.SplitDistance = 0;
            this.btn_Port.TabIndex = 78;
            this.btn_Port.Text = "Open Port";
            this.btn_Port.Title = "";
            this.btn_Port.UseVisualStyleBackColor = true;
            this.btn_Port.Click += new System.EventHandler(this.btn_Port_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(409, 50);
            this.label3.TabIndex = 79;
            this.label3.Text = "SHOPPING MALL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Com);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.txt_TroleyNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GetBill);
            this.Controls.Add(this.btn_EmptyTroley);
            this.Name = "Form1";
            this.Text = "SHOPPING MARKET";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort port;
        private RibbonStyle.RibbonMenuButton btn_GetBill;
        private RibbonStyle.RibbonMenuButton btn_EmptyTroley;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TroleyNo;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.ComboBox cmb_Com;
        private System.Windows.Forms.Label label2;
        private RibbonStyle.RibbonMenuButton btn_Port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

