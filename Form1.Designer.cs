namespace BurgerKiosk
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
            grpMenu = new GroupBox();
            rdoChickenBurger = new RadioButton();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            rdoHamBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            lblTitle = new Label();
            chkPotato = new RadioButton();
            chkCola = new RadioButton();
            chkCheeze = new RadioButton();
            chkSauce = new RadioButton();
            grpOption = new GroupBox();
            grpOrder = new GroupBox();
            btnReset = new Button();
            BtnOrder = new Button();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            lblMessage = new Label();
            label1 = new Label();
            MessageBox = new Label();
            grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpOption.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(pictureBox3);
            grpMenu.Controls.Add(pictureBox2);
            grpMenu.Controls.Add(pictureBox1);
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Font = new Font("맑은 고딕", 14F);
            grpMenu.ForeColor = Color.Red;
            grpMenu.Location = new Point(36, 192);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(522, 549);
            grpMenu.TabIndex = 1;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            grpMenu.Enter += groupBox1_Enter;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.ForeColor = Color.Black;
            rdoChickenBurger.Location = new Point(37, 416);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(205, 55);
            rdoChickenBurger.TabIndex = 8;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            rdoChickenBurger.CheckedChanged += rdoChickenBurger_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(292, 362);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(200, 161);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(292, 202);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 154);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(292, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 159);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.ForeColor = Color.Black;
            rdoHamBurger.Location = new Point(37, 93);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(167, 55);
            rdoHamBurger.TabIndex = 3;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            rdoHamBurger.CheckedChanged += rdoHamBurger_CheckedChanged;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.ForeColor = Color.Black;
            rdoBulgogiBurger.Location = new Point(37, 246);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(243, 55);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            rdoBulgogiBurger.CheckedChanged += rdoBulgogiBurger_CheckedChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 27F);
            lblTitle.ForeColor = Color.RoyalBlue;
            lblTitle.Location = new Point(24, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(666, 96);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "버거 주문 키오스크";
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.ForeColor = Color.Black;
            chkPotato.Location = new Point(24, 80);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(205, 55);
            chkPotato.TabIndex = 4;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            chkPotato.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(24, 141);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(129, 55);
            chkCola.TabIndex = 5;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            chkCola.CheckedChanged += chkCola_CheckedChanged;
            // 
            // chkCheeze
            // 
            chkCheeze.AutoSize = true;
            chkCheeze.ForeColor = Color.Black;
            chkCheeze.Location = new Point(24, 202);
            chkCheeze.Name = "chkCheeze";
            chkCheeze.Size = new Size(218, 55);
            chkCheeze.TabIndex = 6;
            chkCheeze.Text = "치즈 추가";
            chkCheeze.UseVisualStyleBackColor = true;
            chkCheeze.CheckedChanged += chkCheeze_CheckedChanged;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(24, 261);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(218, 55);
            chkSauce.TabIndex = 7;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            chkSauce.CheckedChanged += chkSauce_CheckedChanged;
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkPotato);
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkCheeze);
            grpOption.Font = new Font("맑은 고딕", 14F);
            grpOption.ForeColor = Color.Red;
            grpOption.Location = new Point(585, 192);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(330, 549);
            grpOption.TabIndex = 7;
            grpOption.TabStop = false;
            grpOption.Text = "추가 옵션";
            grpOption.Enter += groupBox2_Enter;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(btnReset);
            grpOrder.Controls.Add(BtnOrder);
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 14F);
            grpOrder.ForeColor = Color.Red;
            grpOrder.Location = new Point(953, 192);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(330, 549);
            grpOrder.TabIndex = 8;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.Font = new Font("맑은 고딕", 9F);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(162, 480);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(150, 63);
            btnReset.TabIndex = 11;
            btnReset.Text = "주문 초기화";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // BtnOrder
            // 
            BtnOrder.BackColor = Color.Lime;
            BtnOrder.Font = new Font("맑은 고딕", 10F);
            BtnOrder.ForeColor = Color.White;
            BtnOrder.Location = new Point(6, 480);
            BtnOrder.Name = "BtnOrder";
            BtnOrder.Size = new Size(150, 63);
            BtnOrder.TabIndex = 10;
            BtnOrder.Text = "주문하기";
            BtnOrder.UseVisualStyleBackColor = false;
            BtnOrder.Click += BtnOrder_Click;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("맑은 고딕", 12F);
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(6, 426);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(195, 45);
            lblTotalCost.TabIndex = 9;
            lblTotalCost.Text = "총 금액: 0원";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(6, 56);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(324, 354);
            lstOrder.TabIndex = 9;
            lstOrder.SelectedIndexChanged += lstOrder_SelectedIndexChanged;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(36, 747);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 32);
            lblMessage.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 754);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 9;
            // 
            // MessageBox
            // 
            MessageBox.AutoSize = true;
            MessageBox.ForeColor = Color.Red;
            MessageBox.Location = new Point(959, 747);
            MessageBox.Name = "MessageBox";
            MessageBox.Size = new Size(238, 32);
            MessageBox.TabIndex = 10;
            MessageBox.Text = "메뉴를 선택해주세요";
            MessageBox.Click += MessageBox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 807);
            Controls.Add(MessageBox);
            Controls.Add(label1);
            Controls.Add(lblMessage);
            Controls.Add(grpOrder);
            Controls.Add(grpOption);
            Controls.Add(lblTitle);
            Controls.Add(grpMenu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox grpMenu;
        private RadioButton rdoBulgogiBurger;
        private Label lblTitle;
        private RadioButton rdoHamBurger;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private RadioButton chkPotato;
        private RadioButton chkCola;
        private RadioButton chkCheeze;
        private RadioButton chkSauce;
        private GroupBox grpOption;
        private GroupBox grpOrder;
        private Label lblTotalCost;
        private ListBox lstOrder;
        private Button btnReset;
        private Button BtnOrder;
        private RadioButton rdoChickenBurger;
        private Label lblMessage;
        private Label label1;
        private Label MessageBox;
    }
}
