namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheeze.Checked = false;
            chkSauce.Checked = false;

            lstOrder.Items.Clear();
            lblTotalCost.Text = "";
        }

        private void rdoHamBurger_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            int totalCost = 0;
            lstOrder.Items.Clear();

            // 메뉴 선택 안 했을 때
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblTotalCost.Text = "메뉴를 선택하세요";
                return;
            }

            // 메뉴
            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3000원");
            }

            // 옵션
            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3500원");
            }

            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2500원");
            }

            if (chkCheeze.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 1500원");
            }

            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 500원");
            }

            lblTotalCost.Text = "총 금액: " + totalCost + "원";
        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdoBulgogiBurger_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rdoChickenBurger_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkCola_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chkCheeze_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chkSauce_CheckedChanged(object sender, EventArgs e)
        {
          
        }
    }
}
