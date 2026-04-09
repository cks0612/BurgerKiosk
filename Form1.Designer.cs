namespace BurgerKiosk
{
    partial class appname
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appname));
            lbllabname = new Label();
            grpMenu = new GroupBox();
            ckbgpxbx = new PictureBox();
            bbgpxbx = new PictureBox();
            bgpxbx = new PictureBox();
            rdoChickenBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoHamBurger = new RadioButton();
            gtpOption = new GroupBox();
            rdoSauce = new CheckBox();
            rdoCheese = new CheckBox();
            rdoCola = new CheckBox();
            rdoPotato = new CheckBox();
            grpOrder = new GroupBox();
            btnrst = new Button();
            lbltotalcost = new Label();
            lstOrder = new ListBox();
            btnorder = new Button();
            grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ckbgpxbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bbgpxbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bgpxbx).BeginInit();
            gtpOption.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lbllabname
            // 
            lbllabname.AutoSize = true;
            lbllabname.Font = new Font("한컴 말랑말랑 Bold", 36F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbllabname.Location = new Point(12, 27);
            lbllabname.Name = "lbllabname";
            lbllabname.Size = new Size(376, 62);
            lbllabname.TabIndex = 0;
            lbllabname.Text = "버거 주문 키오스크";
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(ckbgpxbx);
            grpMenu.Controls.Add(bbgpxbx);
            grpMenu.Controls.Add(bgpxbx);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Font = new Font("한컴 말랑말랑 Bold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpMenu.ForeColor = Color.FromArgb(192, 0, 0);
            grpMenu.Location = new Point(12, 118);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(376, 437);
            grpMenu.TabIndex = 1;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // ckbgpxbx
            // 
            ckbgpxbx.Image = (Image)resources.GetObject("ckbgpxbx.Image");
            ckbgpxbx.Location = new Point(228, 321);
            ckbgpxbx.Name = "ckbgpxbx";
            ckbgpxbx.Size = new Size(127, 115);
            ckbgpxbx.SizeMode = PictureBoxSizeMode.StretchImage;
            ckbgpxbx.TabIndex = 5;
            ckbgpxbx.TabStop = false;
            // 
            // bbgpxbx
            // 
            bbgpxbx.Image = (Image)resources.GetObject("bbgpxbx.Image");
            bbgpxbx.Location = new Point(228, 188);
            bbgpxbx.Name = "bbgpxbx";
            bbgpxbx.Size = new Size(127, 115);
            bbgpxbx.SizeMode = PictureBoxSizeMode.StretchImage;
            bbgpxbx.TabIndex = 4;
            bbgpxbx.TabStop = false;
            // 
            // bgpxbx
            // 
            bgpxbx.Image = (Image)resources.GetObject("bgpxbx.Image");
            bgpxbx.Location = new Point(228, 55);
            bgpxbx.Name = "bgpxbx";
            bgpxbx.Size = new Size(127, 115);
            bgpxbx.SizeMode = PictureBoxSizeMode.StretchImage;
            bgpxbx.TabIndex = 3;
            bgpxbx.TabStop = false;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoChickenBurger.ForeColor = Color.Purple;
            rdoChickenBurger.Location = new Point(21, 321);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(119, 35);
            rdoChickenBurger.TabIndex = 2;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨 버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            rdoChickenBurger.CheckedChanged += rdoChickenBurger_CheckedChanged;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoBulgogiBurger.ForeColor = Color.Purple;
            rdoBulgogiBurger.Location = new Point(21, 188);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(137, 35);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기 버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            rdoBulgogiBurger.CheckedChanged += rdoBulgogiBurger_CheckedChanged;
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("한컴 말랑말랑 Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoHamBurger.ForeColor = Color.Purple;
            rdoHamBurger.Location = new Point(21, 53);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(93, 35);
            rdoHamBurger.TabIndex = 0;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            rdoHamBurger.CheckedChanged += rdoHamBurger_CheckedChanged;
            // 
            // gtpOption
            // 
            gtpOption.Controls.Add(rdoSauce);
            gtpOption.Controls.Add(rdoCheese);
            gtpOption.Controls.Add(rdoCola);
            gtpOption.Controls.Add(rdoPotato);
            gtpOption.Font = new Font("한컴 말랑말랑 Bold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            gtpOption.ForeColor = Color.FromArgb(192, 0, 0);
            gtpOption.Location = new Point(419, 118);
            gtpOption.Name = "gtpOption";
            gtpOption.Size = new Size(192, 303);
            gtpOption.TabIndex = 2;
            gtpOption.TabStop = false;
            gtpOption.Text = "추가 옵션";
            // 
            // rdoSauce
            // 
            rdoSauce.AutoSize = true;
            rdoSauce.Font = new Font("한컴 말랑말랑 Bold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoSauce.ForeColor = Color.Black;
            rdoSauce.Location = new Point(6, 239);
            rdoSauce.Name = "rdoSauce";
            rdoSauce.Size = new Size(106, 31);
            rdoSauce.TabIndex = 4;
            rdoSauce.Text = "소스 추가";
            rdoSauce.UseVisualStyleBackColor = true;
            rdoSauce.CheckedChanged += rdoSauce_CheckedChanged;
            // 
            // rdoCheese
            // 
            rdoCheese.AutoSize = true;
            rdoCheese.Font = new Font("한컴 말랑말랑 Bold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoCheese.ForeColor = Color.Black;
            rdoCheese.Location = new Point(6, 179);
            rdoCheese.Name = "rdoCheese";
            rdoCheese.Size = new Size(107, 31);
            rdoCheese.TabIndex = 3;
            rdoCheese.Text = "치즈 추가";
            rdoCheese.UseVisualStyleBackColor = true;
            rdoCheese.CheckedChanged += rdoCheese_CheckedChanged;
            // 
            // rdoCola
            // 
            rdoCola.AutoSize = true;
            rdoCola.Font = new Font("한컴 말랑말랑 Bold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoCola.ForeColor = Color.Black;
            rdoCola.Location = new Point(6, 119);
            rdoCola.Name = "rdoCola";
            rdoCola.Size = new Size(67, 31);
            rdoCola.TabIndex = 1;
            rdoCola.Text = "콜라";
            rdoCola.UseVisualStyleBackColor = true;
            rdoCola.CheckedChanged += rdoCola_CheckedChanged;
            // 
            // rdoPotato
            // 
            rdoPotato.AutoSize = true;
            rdoPotato.Font = new Font("한컴 말랑말랑 Bold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoPotato.ForeColor = Color.Black;
            rdoPotato.Location = new Point(6, 59);
            rdoPotato.Name = "rdoPotato";
            rdoPotato.Size = new Size(103, 31);
            rdoPotato.TabIndex = 0;
            rdoPotato.Text = "감자튀김";
            rdoPotato.UseVisualStyleBackColor = true;
            rdoPotato.CheckedChanged += rdoPotato_CheckedChanged;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(btnrst);
            grpOrder.Controls.Add(lbltotalcost);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Controls.Add(btnorder);
            grpOrder.Font = new Font("한컴 말랑말랑 Bold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOrder.ForeColor = Color.FromArgb(192, 0, 0);
            grpOrder.Location = new Point(669, 118);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(314, 356);
            grpOrder.TabIndex = 3;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // btnrst
            // 
            btnrst.Font = new Font("한컴 말랑말랑 Bold", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnrst.ForeColor = Color.FromArgb(192, 0, 0);
            btnrst.Location = new Point(159, 287);
            btnrst.Name = "btnrst";
            btnrst.Size = new Size(139, 51);
            btnrst.TabIndex = 5;
            btnrst.Text = "초기화";
            btnrst.UseVisualStyleBackColor = true;
            btnrst.Click += btnrst_Click;
            // 
            // lbltotalcost
            // 
            lbltotalcost.AutoSize = true;
            lbltotalcost.ForeColor = Color.FromArgb(0, 0, 192);
            lbltotalcost.Location = new Point(16, 233);
            lbltotalcost.Name = "lbltotalcost";
            lbltotalcost.Size = new Size(122, 37);
            lbltotalcost.TabIndex = 1;
            lbltotalcost.Text = "총 금액 : ";
            lbltotalcost.Click += lbltotalcost_Click;
            // 
            // lstOrder
            // 
            lstOrder.Font = new Font("한컴 말랑말랑 Bold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(16, 53);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(282, 166);
            lstOrder.TabIndex = 0;
            lstOrder.TabStop = false;
            lstOrder.SelectedIndexChanged += lstOrder_SelectedIndexChanged;
            // 
            // btnorder
            // 
            btnorder.Font = new Font("한컴 말랑말랑 Bold", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnorder.ForeColor = Color.FromArgb(0, 192, 0);
            btnorder.Location = new Point(16, 287);
            btnorder.Name = "btnorder";
            btnorder.Size = new Size(136, 51);
            btnorder.TabIndex = 4;
            btnorder.Text = "주문하기";
            btnorder.UseVisualStyleBackColor = true;
            btnorder.Click += btnorder_Click;
            // 
            // appname
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 589);
            Controls.Add(grpOrder);
            Controls.Add(gtpOption);
            Controls.Add(grpMenu);
            Controls.Add(lbllabname);
            Name = "appname";
            Text = "Burger Kiosk v1";
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ckbgpxbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)bbgpxbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)bgpxbx).EndInit();
            gtpOption.ResumeLayout(false);
            gtpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllabname;
        private GroupBox grpMenu;
        private RadioButton rdoChickenBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoHamBurger;
        private GroupBox gtpOption;
        private PictureBox bgpxbx;
        private PictureBox bbgpxbx;
        private PictureBox ckbgpxbx;
        private CheckBox rdoSauce;
        private CheckBox rdoCheese;
        private CheckBox rdoCola;
        private CheckBox rdoPotato;
        private GroupBox grpOrder;
        private Button btnrst;
        private Button btnorder;
        private Label lbltotalcost;
        private ListBox lstOrder;
    }
}
