using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BurgerKiosk
{
    public partial class name : Form
    {
        public name()
        {
            InitializeComponent();

        }

        int totalCost = 0;


        private void btnorder_Click(object sender, EventArgs e)
        {
            lbltotalcost.ForeColor = Color.FromArgb(0, 0, 192);

            totalCost.ToString();

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


            lbltotalcost.Text = $"총 금액: {totalCost:N0}원";

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

            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
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
            this.ActiveControl = null;
        }

        private void rdoChickenBurger_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void rdoPotato_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoCola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoCheese_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoSauce_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void totalcost_Click(object sender, EventArgs e)
        {

        }

        private void rdoHamBurger_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void lbltotalcost_Click(object sender, EventArgs e)
        {

        }

        private void name_Load(object sender, EventArgs e)
        {
            
        }

        private void name_Shown(object sender, EventArgs e)
        {
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            rdoHamBurger.Checked = false;
        }
    }
}
