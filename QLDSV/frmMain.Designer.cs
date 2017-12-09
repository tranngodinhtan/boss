namespace QLDSV
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pgTC = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbQLTK = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnQLTK = new DevExpress.XtraBars.BarButtonItem();
            this.rbQLL = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnQLL = new DevExpress.XtraBars.BarButtonItem();
            this.rbQLSV = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnQLSV = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnQLDSV = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnQLMH = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btDSSV = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.login = new DevExpress.XtraBars.BarStaticItem();
            this.hoten = new DevExpress.XtraBars.BarStaticItem();
            this.nhom = new DevExpress.XtraBars.BarStaticItem();
            this.khoa = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // pgTC
            // 
            this.pgTC.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbQLTK,
            this.rbQLL,
            this.rbQLSV,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup1});
            this.pgTC.Name = "pgTC";
            this.pgTC.Text = "Trang Chủ";
            // 
            // rbQLTK
            // 
            this.rbQLTK.ItemLinks.Add(this.btnQLTK);
            this.rbQLTK.Name = "rbQLTK";
            // 
            // btnQLTK
            // 
            this.btnQLTK.Caption = "Quản Lý Tài Khoản";
            this.btnQLTK.Id = 8;
            this.btnQLTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLTK.ImageOptions.Image")));
            this.btnQLTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLTK.ImageOptions.LargeImage")));
            this.btnQLTK.Name = "btnQLTK";
            this.btnQLTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // rbQLL
            // 
            this.rbQLL.ItemLinks.Add(this.btnQLL);
            this.rbQLL.Name = "rbQLL";
            // 
            // btnQLL
            // 
            this.btnQLL.Caption = "Quản Lý Lớp";
            this.btnQLL.Id = 11;
            this.btnQLL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLL.ImageOptions.Image")));
            this.btnQLL.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLL.ImageOptions.LargeImage")));
            this.btnQLL.Name = "btnQLL";
            this.btnQLL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLL_ItemClick);
            // 
            // rbQLSV
            // 
            this.rbQLSV.ItemLinks.Add(this.btnQLSV);
            this.rbQLSV.Name = "rbQLSV";
            // 
            // btnQLSV
            // 
            this.btnQLSV.Caption = "Quản Lý Sinh Viên";
            this.btnQLSV.Id = 9;
            this.btnQLSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSV.ImageOptions.Image")));
            this.btnQLSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLSV.ImageOptions.LargeImage")));
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnQLDSV);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // btnQLDSV
            // 
            this.btnQLDSV.Caption = "Quản Lý Điểm Sinh Viên";
            this.btnQLDSV.Id = 10;
            this.btnQLDSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLDSV.ImageOptions.Image")));
            this.btnQLDSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLDSV.ImageOptions.LargeImage")));
            this.btnQLDSV.Name = "btnQLDSV";
            this.btnQLDSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLDSV_ItemClick);
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnQLMH);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // btnQLMH
            // 
            this.btnQLMH.Caption = "Quản Lý Môn Học";
            this.btnQLMH.Id = 13;
            this.btnQLMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLMH.ImageOptions.Image")));
            this.btnQLMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLMH.ImageOptions.LargeImage")));
            this.btnQLMH.Name = "btnQLMH";
            this.btnQLMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLMH_ItemClick);
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btDSSV);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // btDSSV
            // 
            this.btDSSV.Caption = "In Danh Sách Sinh Viên";
            this.btDSSV.Id = 24;
            this.btDSSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btIn.ImageOptions.Image")));
            this.btDSSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btIn.ImageOptions.LargeImage")));
            this.btDSSV.Name = "btDSSV";
            this.btDSSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btIn_ItemClick);
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 6;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 14;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 15;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 16;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 17;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonGroup1,
            this.btnQLTK,
            this.btnQLSV,
            this.btnQLDSV,
            this.btnQLL,
            this.btnQLMH,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonGroup2,
            this.btnIn,
            this.btDSSV});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 25;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pgTC});
            this.ribbon.Size = new System.Drawing.Size(1008, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // barButtonGroup2
            // 
            this.barButtonGroup2.Caption = "barButtonGroup2";
            this.barButtonGroup2.Id = 21;
            this.barButtonGroup2.Name = "barButtonGroup2";
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In Danh Sách";
            this.btnIn.Id = 23;
            this.btnIn.Name = "btnIn";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.login);
            this.ribbonStatusBar.ItemLinks.Add(this.hoten);
            this.ribbonStatusBar.ItemLinks.Add(this.nhom);
            this.ribbonStatusBar.ItemLinks.Add(this.khoa);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 544);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1008, 31);
            // 
            // login
            // 
            this.login.Caption = "UserName";
            this.login.Id = 1;
            this.login.Name = "login";
            // 
            // hoten
            // 
            this.hoten.Caption = "Hoten";
            this.hoten.Id = 2;
            this.hoten.Name = "hoten";
            // 
            // nhom
            // 
            this.nhom.Caption = "Nhom";
            this.nhom.Id = 3;
            this.nhom.Name = "nhom";
            this.nhom.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barStaticItem3_ItemClick);
            // 
            // khoa
            // 
            this.khoa.Caption = "Khoa";
            this.khoa.Id = 4;
            this.khoa.Name = "khoa";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 575);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage pgTC;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbQLTK;
        private DevExpress.XtraBars.BarButtonItem btnQLTK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbQLL;
        private DevExpress.XtraBars.BarButtonItem btnQLL;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbQLSV;
        private DevExpress.XtraBars.BarButtonItem btnQLSV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnQLDSV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnQLMH;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem login;
        private DevExpress.XtraBars.BarStaticItem hoten;
        private DevExpress.XtraBars.BarStaticItem nhom;
        private DevExpress.XtraBars.BarStaticItem khoa;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btDSSV;
        private DevExpress.XtraBars.BarButtonItem btnIn;
    }
}