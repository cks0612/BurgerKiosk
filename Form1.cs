using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BurgerKiosk
{
    public partial class appname : Form
    {
        public appname()
        {
            InitializeComponent();

        }

        int totalCost = 0;

        private void UpdateTotalCost()
        {
            totalCost = 0;
            lstOrder.Items.Clear();

            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기 버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨 버거 3,000원");
            }
            else
            {
                lbltotalcost.ForeColor = Color.Red;
                lbltotalcost.Text = "메뉴를 선택해주세요.";
                return;
            }

            if (rdoPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            if (rdoCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (rdoCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }
            if (rdoSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }

            lbltotalcost.ForeColor = Color.FromArgb(0, 0, 192);
            lbltotalcost.Text = $"총 금액: {totalCost:N0}원";
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            lbltotalcost.ForeColor = Color.FromArgb(0, 0, 192);


            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lbltotalcost.ForeColor = Color.Red;
                lbltotalcost.Text = "메뉴를 선택해주세요.";
                return;
            }

        }


        private void btnrst_Click(object sender, EventArgs e)
        {
            lbltotalcost.ForeColor = Color.FromArgb(0, 0, 192);


            rdoPotato.Checked = false;
            rdoCola.Checked = false;
            rdoCheese.Checked = false;
            rdoSauce.Checked = false;
            lstOrder.Items.Clear();
            lbltotalcost.Text = "총 금액 : ";
            totalCost = 0;
        }

        private void rdoBulgogiBurger_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void rdoChickenBurger_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void rdoPotato_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void rdoCola_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void rdoCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void rdoSauce_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void totalcost_Click(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void rdoHamBurger_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void lbltotalcost_Click(object sender, EventArgs e)
        {

        }

        private void btnorder_KeyDown(object sender, KeyEventArgs e)
        {
            lbltotalcost.ForeColor = Color.FromArgb(0, 0, 192);


            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lbltotalcost.ForeColor = Color.Red;
                lbltotalcost.Text = "메뉴를 선택해주세요.";
                return;
            }
        }

        private void btnrst_KeyDown(object sender, KeyEventArgs e)
        {
            lbltotalcost.ForeColor = Color.FromArgb(0, 0, 192);


            rdoPotato.Checked = false;
            rdoCola.Checked = false;
            rdoCheese.Checked = false;
            rdoSauce.Checked = false;
            lstOrder.Items.Clear();
            lbltotalcost.Text = "총 금액 : ";
            totalCost = 0;
        }
    }
}