namespace HospitalManagementSystem
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReception = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnMedicine = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddPharmist = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDoctor = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddDoctor = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddreciption = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.viewMedicine1 = new HospitalManagementSystem.Views.Admin.ViewMedicine();
            this.viewReception1 = new HospitalManagementSystem.Views.Admin.ViewReception();
            this.viewPharmist1 = new HospitalManagementSystem.Views.Admin.ViewPharmist();
            this.viewDoctor1 = new HospitalManagementSystem.Views.Admin.ViewDoctor();
            this.addPharmist1 = new HospitalManagementSystem.Views.Admin.AddPharmist();
            this.addReception1 = new HospitalManagementSystem.Views.Admin.AddReception();
            this.addDoctor1 = new HospitalManagementSystem.Views.AddDoctor();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(1297, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(15, 18);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "x";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.btnReception);
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Controls.Add(this.btnMedicine);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAddPharmist);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnDoctor);
            this.panel1.Controls.Add(this.btnAddDoctor);
            this.panel1.Controls.Add(this.btnAddreciption);
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 698);
            this.panel1.TabIndex = 16;
            // 
            // btnReception
            // 
            this.btnReception.ActiveBorderThickness = 1;
            this.btnReception.ActiveCornerRadius = 20;
            this.btnReception.ActiveFillColor = System.Drawing.Color.Black;
            this.btnReception.ActiveForecolor = System.Drawing.Color.White;
            this.btnReception.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReception.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnReception.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReception.BackgroundImage")));
            this.btnReception.ButtonText = "View Receptionist";
            this.btnReception.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReception.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReception.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReception.IdleBorderThickness = 1;
            this.btnReception.IdleCornerRadius = 20;
            this.btnReception.IdleFillColor = System.Drawing.Color.DimGray;
            this.btnReception.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnReception.IdleLineColor = System.Drawing.Color.WhiteSmoke;
            this.btnReception.Location = new System.Drawing.Point(28, 452);
            this.btnReception.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReception.Name = "btnReception";
            this.btnReception.Size = new System.Drawing.Size(178, 42);
            this.btnReception.TabIndex = 30;
            this.btnReception.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReception.Click += new System.EventHandler(this.btnReception_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "View Doctor";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.DimGray;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.Location = new System.Drawing.Point(28, 313);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(178, 42);
            this.bunifuThinButton22.TabIndex = 29;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // btnMedicine
            // 
            this.btnMedicine.ActiveBorderThickness = 1;
            this.btnMedicine.ActiveCornerRadius = 20;
            this.btnMedicine.ActiveFillColor = System.Drawing.Color.Black;
            this.btnMedicine.ActiveForecolor = System.Drawing.Color.White;
            this.btnMedicine.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMedicine.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMedicine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMedicine.BackgroundImage")));
            this.btnMedicine.ButtonText = "View Medicine";
            this.btnMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicine.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicine.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMedicine.IdleBorderThickness = 1;
            this.btnMedicine.IdleCornerRadius = 20;
            this.btnMedicine.IdleFillColor = System.Drawing.Color.DimGray;
            this.btnMedicine.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnMedicine.IdleLineColor = System.Drawing.Color.WhiteSmoke;
            this.btnMedicine.Location = new System.Drawing.Point(28, 526);
            this.btnMedicine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(178, 42);
            this.btnMedicine.TabIndex = 28;
            this.btnMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(233, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(908, 493);
            this.panel3.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(-1, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "__________________________________________";
            // 
            // btnAddPharmist
            // 
            this.btnAddPharmist.ActiveBorderThickness = 1;
            this.btnAddPharmist.ActiveCornerRadius = 20;
            this.btnAddPharmist.ActiveFillColor = System.Drawing.Color.Black;
            this.btnAddPharmist.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddPharmist.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddPharmist.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAddPharmist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPharmist.BackgroundImage")));
            this.btnAddPharmist.ButtonText = "Add Pharmist";
            this.btnAddPharmist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPharmist.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPharmist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddPharmist.IdleBorderThickness = 1;
            this.btnAddPharmist.IdleCornerRadius = 20;
            this.btnAddPharmist.IdleFillColor = System.Drawing.Color.DimGray;
            this.btnAddPharmist.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnAddPharmist.IdleLineColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddPharmist.Location = new System.Drawing.Point(28, 230);
            this.btnAddPharmist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddPharmist.Name = "btnAddPharmist";
            this.btnAddPharmist.Size = new System.Drawing.Size(178, 42);
            this.btnAddPharmist.TabIndex = 27;
            this.btnAddPharmist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddPharmist.Click += new System.EventHandler(this.btnAddPharmist_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(60, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Admin Portal";
            // 
            // btnLogout
            // 
            this.btnLogout.ActiveBorderThickness = 1;
            this.btnLogout.ActiveCornerRadius = 20;
            this.btnLogout.ActiveFillColor = System.Drawing.Color.Black;
            this.btnLogout.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogout.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.ButtonText = "Logut";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.IdleBorderThickness = 1;
            this.btnLogout.IdleCornerRadius = 20;
            this.btnLogout.IdleFillColor = System.Drawing.Color.DimGray;
            this.btnLogout.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.IdleLineColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Location = new System.Drawing.Point(28, 612);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(178, 42);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDoctor
            // 
            this.btnDoctor.ActiveBorderThickness = 1;
            this.btnDoctor.ActiveCornerRadius = 20;
            this.btnDoctor.ActiveFillColor = System.Drawing.Color.Black;
            this.btnDoctor.ActiveForecolor = System.Drawing.Color.White;
            this.btnDoctor.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDoctor.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDoctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoctor.BackgroundImage")));
            this.btnDoctor.ButtonText = "View Pharmist";
            this.btnDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctor.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDoctor.IdleBorderThickness = 1;
            this.btnDoctor.IdleCornerRadius = 20;
            this.btnDoctor.IdleFillColor = System.Drawing.Color.DimGray;
            this.btnDoctor.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnDoctor.IdleLineColor = System.Drawing.Color.WhiteSmoke;
            this.btnDoctor.Location = new System.Drawing.Point(28, 380);
            this.btnDoctor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(178, 42);
            this.btnDoctor.TabIndex = 23;
            this.btnDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.ActiveBorderThickness = 1;
            this.btnAddDoctor.ActiveCornerRadius = 20;
            this.btnAddDoctor.ActiveFillColor = System.Drawing.Color.Black;
            this.btnAddDoctor.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddDoctor.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddDoctor.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAddDoctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddDoctor.BackgroundImage")));
            this.btnAddDoctor.ButtonText = "Add Doctor";
            this.btnAddDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDoctor.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDoctor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddDoctor.IdleBorderThickness = 1;
            this.btnAddDoctor.IdleCornerRadius = 20;
            this.btnAddDoctor.IdleFillColor = System.Drawing.Color.DimGray;
            this.btnAddDoctor.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnAddDoctor.IdleLineColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddDoctor.Location = new System.Drawing.Point(28, 79);
            this.btnAddDoctor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(178, 42);
            this.btnAddDoctor.TabIndex = 21;
            this.btnAddDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // btnAddreciption
            // 
            this.btnAddreciption.ActiveBorderThickness = 1;
            this.btnAddreciption.ActiveCornerRadius = 20;
            this.btnAddreciption.ActiveFillColor = System.Drawing.Color.Black;
            this.btnAddreciption.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddreciption.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddreciption.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAddreciption.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddreciption.BackgroundImage")));
            this.btnAddreciption.ButtonText = "Add Reciptionist";
            this.btnAddreciption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddreciption.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddreciption.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddreciption.IdleBorderThickness = 1;
            this.btnAddreciption.IdleCornerRadius = 20;
            this.btnAddreciption.IdleFillColor = System.Drawing.Color.DimGray;
            this.btnAddreciption.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnAddreciption.IdleLineColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddreciption.Location = new System.Drawing.Point(28, 156);
            this.btnAddreciption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddreciption.Name = "btnAddreciption";
            this.btnAddreciption.Size = new System.Drawing.Size(178, 42);
            this.btnAddreciption.TabIndex = 18;
            this.btnAddreciption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddreciption.Click += new System.EventHandler(this.btnAddreciption_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Location = new System.Drawing.Point(-5, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1315, 83);
            this.panel2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(437, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hospital Management System";
            // 
            // viewMedicine1
            // 
            this.viewMedicine1.Location = new System.Drawing.Point(252, 88);
            this.viewMedicine1.Name = "viewMedicine1";
            this.viewMedicine1.Size = new System.Drawing.Size(1075, 541);
            this.viewMedicine1.TabIndex = 24;
            // 
            // viewReception1
            // 
            this.viewReception1.Location = new System.Drawing.Point(252, 94);
            this.viewReception1.Name = "viewReception1";
            this.viewReception1.Size = new System.Drawing.Size(1088, 562);
            this.viewReception1.TabIndex = 23;
            // 
            // viewPharmist1
            // 
            this.viewPharmist1.Location = new System.Drawing.Point(252, 92);
            this.viewPharmist1.Name = "viewPharmist1";
            this.viewPharmist1.Size = new System.Drawing.Size(1076, 551);
            this.viewPharmist1.TabIndex = 22;
            // 
            // viewDoctor1
            // 
            this.viewDoctor1.Location = new System.Drawing.Point(252, 103);
            this.viewDoctor1.Name = "viewDoctor1";
            this.viewDoctor1.Size = new System.Drawing.Size(1048, 534);
            this.viewDoctor1.TabIndex = 21;
            // 
            // addPharmist1
            // 
            this.addPharmist1.Location = new System.Drawing.Point(252, 103);
            this.addPharmist1.Name = "addPharmist1";
            this.addPharmist1.Size = new System.Drawing.Size(956, 611);
            this.addPharmist1.TabIndex = 20;
            // 
            // addReception1
            // 
            this.addReception1.Location = new System.Drawing.Point(252, 103);
            this.addReception1.Name = "addReception1";
            this.addReception1.Size = new System.Drawing.Size(956, 507);
            this.addReception1.TabIndex = 19;
            // 
            // addDoctor1
            // 
            this.addDoctor1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addDoctor1.Location = new System.Drawing.Point(252, 92);
            this.addDoctor1.Name = "addDoctor1";
            this.addDoctor1.Size = new System.Drawing.Size(956, 625);
            this.addDoctor1.TabIndex = 25;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1311, 786);
            this.Controls.Add(this.addDoctor1);
            this.Controls.Add(this.viewMedicine1);
            this.Controls.Add(this.viewReception1);
            this.Controls.Add(this.viewPharmist1);
            this.Controls.Add(this.viewDoctor1);
            this.Controls.Add(this.addPharmist1);
            this.Controls.Add(this.addReception1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddreciption;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogout;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDoctor;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddDoctor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddPharmist;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMedicine;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReception;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Views.Admin.AddReception addReception1;
        private Views.Admin.AddPharmist addPharmist1;
        private Views.Admin.ViewDoctor viewDoctor1;
        private Views.Admin.ViewPharmist viewPharmist1;
        private Views.Admin.ViewReception viewReception1;
        private Views.Admin.ViewMedicine viewMedicine1;
        private Views.AddDoctor addDoctor1;
    }
}