namespace calculadora
{
    public partial class Calculadora : Form
    {
        private decimal ultimoValor;
        private bool operacaoFoiSelecionada;
        private string operacaoSelecionada;


        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
        private void txtDigitos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private decimal CaptarValorTextBoxDigitos()
        {
            return decimal.Parse(txtDigitos.Text);
        }

        private void RealizarAcao(string acao)
        {
            switch (acao)
            {
                case "0":
                    txtDigitos.Text = txtDigitos.Text + "0";

                    break;

                case "1":

                    txtDigitos.Text = txtDigitos.Text + "1";

                    break;

                case "2":

                    txtDigitos.Text = txtDigitos.Text + "2";

                    break;

                case "3":

                    txtDigitos.Text = txtDigitos.Text + "3";

                    break;

                case "4":

                    txtDigitos.Text = txtDigitos.Text + "4";

                    break;

                case "5":

                    txtDigitos.Text = txtDigitos.Text + "5";

                    break;

                case "6":

                    txtDigitos.Text = txtDigitos.Text + "6";

                    break;

                case "7":

                    txtDigitos.Text = txtDigitos.Text + "7";

                    break;

                case "8":

                    txtDigitos.Text = txtDigitos.Text + "8";

                    break;

                case "9":

                    txtDigitos.Text = txtDigitos.Text + "9";

                    break;

                case "AC":

                    txtDigitos.Clear();

                    break;

                case "+/-":

                    txtDigitos.Text = (CaptarValorTextBoxDigitos() * -1).ToString();

                    break;

                case ",":

                    if (txtDigitos.TextLength > 0)
                    {
                        txtDigitos.Text = txtDigitos.Text + ",";
                    }

                    break;

                case "%":

                    txtDigitos.Text =  (CaptarValorTextBoxDigitos() / 100).ToString("#,##0.00").Replace(",00", "");
                    
                    break;

                case "+":

                    ultimoValor = CaptarValorTextBoxDigitos();
                    operacaoFoiSelecionada = true;
                    operacaoSelecionada = "+";
                    txtDigitos.Clear();

                    break;

                case "-":

                    ultimoValor = CaptarValorTextBoxDigitos();
                    operacaoFoiSelecionada = true;
                    operacaoSelecionada = "-";
                    txtDigitos.Clear();

                    break;

                case "/":

                    ultimoValor = CaptarValorTextBoxDigitos();
                    operacaoFoiSelecionada = true;
                    operacaoSelecionada = "/";
                    txtDigitos.Clear();

                    break;

                case "x":

                    ultimoValor = CaptarValorTextBoxDigitos();
                    operacaoFoiSelecionada = true;
                    operacaoSelecionada = "x";
                    txtDigitos.Clear();

                    break;

                case "=":

                    if (operacaoSelecionada == "+")
                    {

                        txtDigitos.Text = (ultimoValor + CaptarValorTextBoxDigitos()).ToString("#,##0.00").Replace(",00","") ;
                        ultimoValor = 0;
                        operacaoSelecionada = "";
                        operacaoFoiSelecionada = false;
                    }
                    else if (operacaoSelecionada == "-")
                    {
                        txtDigitos.Text = (ultimoValor - CaptarValorTextBoxDigitos()).ToString("#,##0.00").Replace(",00", "");
                        ultimoValor = 0;
                        operacaoSelecionada = "";
                        operacaoFoiSelecionada = false;
                    }
                    else if (operacaoSelecionada == "x")
                    {
                        txtDigitos.Text = (ultimoValor * CaptarValorTextBoxDigitos()).ToString("#,##0.00").Replace(",00", "");
                        ultimoValor = 0;
                        operacaoSelecionada = "";
                        operacaoFoiSelecionada = false;
                    }
                    else if (operacaoSelecionada == "/")
                    {
                        txtDigitos.Text = (ultimoValor / CaptarValorTextBoxDigitos()).ToString("#,##0.00").Replace(",00", "");
                        ultimoValor = 0;
                        operacaoSelecionada = "";
                        operacaoFoiSelecionada = false;
                    }

                    break;
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            RealizarAcao("+");
        }
        private void btnDivisao_Click(object sender, EventArgs e)
        {
            RealizarAcao("/");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            RealizarAcao("x");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            RealizarAcao("-");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            RealizarAcao("=");
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            RealizarAcao("AC");
        }

        private void btnAlterarSinal_Click(object sender, EventArgs e)
        {
            RealizarAcao("+/-");
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            RealizarAcao("%");
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            RealizarAcao(",");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            RealizarAcao("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            RealizarAcao("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            RealizarAcao("2");
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            RealizarAcao("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            RealizarAcao("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            RealizarAcao("5");
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            RealizarAcao("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            RealizarAcao("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            RealizarAcao("8");
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            RealizarAcao("9");
        }
    }
}
