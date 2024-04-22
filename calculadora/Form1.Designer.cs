namespace calculadora
{
    partial class Calculadora
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
            txtDigitos = new TextBox();
            btnSoma = new Button();
            btnMultiplicacao = new Button();
            btnSubtracao = new Button();
            btnDivisao = new Button();
            btnIgual = new Button();
            btnVirgula = new Button();
            btnPorcentagem = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btnAC = new Button();
            btn4 = new Button();
            btn7 = new Button();
            btn1 = new Button();
            btnAlterarSinal = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btn2 = new Button();
            SuspendLayout();
            // 
            // txtDigitos
            // 
            txtDigitos.BackColor = Color.Black;
            txtDigitos.BorderStyle = BorderStyle.None;
            txtDigitos.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDigitos.ForeColor = Color.White;
            txtDigitos.Location = new Point(12, 45);
            txtDigitos.Name = "txtDigitos";
            txtDigitos.Size = new Size(263, 64);
            txtDigitos.TabIndex = 0;
            txtDigitos.KeyPress += txtDigitos_KeyPress;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.FromArgb(255, 192, 128);
            btnSoma.FlatStyle = FlatStyle.Popup;
            btnSoma.Font = new Font("Segoe UI", 26.25F);
            btnSoma.ForeColor = Color.White;
            btnSoma.Location = new Point(215, 350);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(60, 64);
            btnSoma.TabIndex = 2;
            btnSoma.Text = "+";
            btnSoma.TextAlign = ContentAlignment.TopCenter;
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.FromArgb(255, 192, 128);
            btnMultiplicacao.FlatStyle = FlatStyle.Popup;
            btnMultiplicacao.Font = new Font("Segoe UI", 26.25F);
            btnMultiplicacao.ForeColor = Color.White;
            btnMultiplicacao.Location = new Point(215, 210);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(60, 64);
            btnMultiplicacao.TabIndex = 3;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.TextAlign = ContentAlignment.TopCenter;
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.FromArgb(255, 192, 128);
            btnSubtracao.FlatStyle = FlatStyle.Popup;
            btnSubtracao.Font = new Font("Segoe UI", 26.25F);
            btnSubtracao.ForeColor = Color.White;
            btnSubtracao.Location = new Point(215, 280);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(60, 64);
            btnSubtracao.TabIndex = 4;
            btnSubtracao.Text = "-";
            btnSubtracao.TextAlign = ContentAlignment.TopCenter;
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.FromArgb(255, 192, 128);
            btnDivisao.FlatStyle = FlatStyle.Popup;
            btnDivisao.Font = new Font("Segoe UI", 26.25F);
            btnDivisao.ForeColor = Color.White;
            btnDivisao.Location = new Point(215, 140);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(60, 64);
            btnDivisao.TabIndex = 5;
            btnDivisao.Text = "÷";
            btnDivisao.TextAlign = ContentAlignment.TopCenter;
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.FromArgb(255, 192, 128);
            btnIgual.FlatStyle = FlatStyle.Popup;
            btnIgual.Font = new Font("Segoe UI", 26.25F);
            btnIgual.ForeColor = Color.White;
            btnIgual.Location = new Point(215, 420);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(60, 64);
            btnIgual.TabIndex = 6;
            btnIgual.Text = "=";
            btnIgual.TextAlign = ContentAlignment.TopCenter;
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.DimGray;
            btnVirgula.FlatStyle = FlatStyle.Popup;
            btnVirgula.Font = new Font("Segoe UI", 26.25F);
            btnVirgula.ForeColor = Color.White;
            btnVirgula.Location = new Point(149, 420);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(60, 64);
            btnVirgula.TabIndex = 11;
            btnVirgula.Text = ",";
            btnVirgula.TextAlign = ContentAlignment.TopCenter;
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnPorcentagem
            // 
            btnPorcentagem.BackColor = Color.FromArgb(224, 224, 224);
            btnPorcentagem.FlatStyle = FlatStyle.Popup;
            btnPorcentagem.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPorcentagem.ForeColor = Color.Black;
            btnPorcentagem.Location = new Point(149, 140);
            btnPorcentagem.Name = "btnPorcentagem";
            btnPorcentagem.Size = new Size(60, 64);
            btnPorcentagem.TabIndex = 10;
            btnPorcentagem.Text = "%";
            btnPorcentagem.UseVisualStyleBackColor = false;
            btnPorcentagem.Click += btnPorcentagem_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.DimGray;
            btn6.FlatStyle = FlatStyle.Popup;
            btn6.Font = new Font("Segoe UI", 26.25F);
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(149, 280);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 64);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.TextAlign = ContentAlignment.TopCenter;
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.DimGray;
            btn9.FlatStyle = FlatStyle.Popup;
            btn9.Font = new Font("Segoe UI", 26.25F);
            btn9.ForeColor = Color.White;
            btn9.Location = new Point(149, 210);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 64);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.TextAlign = ContentAlignment.TopCenter;
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.DimGray;
            btn3.FlatStyle = FlatStyle.Popup;
            btn3.Font = new Font("Segoe UI", 26.25F);
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(149, 350);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 64);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.TextAlign = ContentAlignment.TopCenter;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.DimGray;
            btn0.FlatStyle = FlatStyle.Popup;
            btn0.Font = new Font("Segoe UI", 26.25F);
            btn0.ForeColor = Color.White;
            btn0.Location = new Point(17, 420);
            btn0.Name = "btn0";
            btn0.Size = new Size(126, 64);
            btn0.TabIndex = 21;
            btn0.Text = "0";
            btn0.TextAlign = ContentAlignment.TopCenter;
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnAC
            // 
            btnAC.BackColor = Color.FromArgb(224, 224, 224);
            btnAC.FlatStyle = FlatStyle.Popup;
            btnAC.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAC.ForeColor = Color.Black;
            btnAC.Location = new Point(17, 140);
            btnAC.Name = "btnAC";
            btnAC.Size = new Size(60, 64);
            btnAC.TabIndex = 20;
            btnAC.Text = "AC";
            btnAC.UseVisualStyleBackColor = false;
            btnAC.Click += btnAC_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.DimGray;
            btn4.FlatStyle = FlatStyle.Popup;
            btn4.Font = new Font("Segoe UI", 26.25F);
            btn4.ForeColor = Color.White;
            btn4.Location = new Point(17, 280);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 64);
            btn4.TabIndex = 19;
            btn4.Text = "4";
            btn4.TextAlign = ContentAlignment.TopCenter;
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.DimGray;
            btn7.FlatStyle = FlatStyle.Popup;
            btn7.Font = new Font("Segoe UI", 26.25F);
            btn7.ForeColor = Color.White;
            btn7.Location = new Point(17, 210);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 64);
            btn7.TabIndex = 18;
            btn7.Text = "7";
            btn7.TextAlign = ContentAlignment.TopCenter;
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.DimGray;
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.Font = new Font("Segoe UI", 26.25F);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(17, 350);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 64);
            btn1.TabIndex = 17;
            btn1.Text = "1";
            btn1.TextAlign = ContentAlignment.TopCenter;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btnAlterarSinal
            // 
            btnAlterarSinal.BackColor = Color.FromArgb(224, 224, 224);
            btnAlterarSinal.FlatStyle = FlatStyle.Popup;
            btnAlterarSinal.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlterarSinal.ForeColor = Color.Black;
            btnAlterarSinal.Location = new Point(83, 140);
            btnAlterarSinal.Name = "btnAlterarSinal";
            btnAlterarSinal.Size = new Size(60, 64);
            btnAlterarSinal.TabIndex = 15;
            btnAlterarSinal.Text = "+/-";
            btnAlterarSinal.UseVisualStyleBackColor = false;
            btnAlterarSinal.Click += btnAlterarSinal_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.DimGray;
            btn5.FlatStyle = FlatStyle.Popup;
            btn5.Font = new Font("Segoe UI", 26.25F);
            btn5.ForeColor = Color.White;
            btn5.Location = new Point(83, 280);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 64);
            btn5.TabIndex = 14;
            btn5.Text = "5";
            btn5.TextAlign = ContentAlignment.TopCenter;
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.DimGray;
            btn8.FlatStyle = FlatStyle.Popup;
            btn8.Font = new Font("Segoe UI", 26.25F);
            btn8.ForeColor = Color.White;
            btn8.Location = new Point(83, 210);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 64);
            btn8.TabIndex = 13;
            btn8.Text = "8";
            btn8.TextAlign = ContentAlignment.TopCenter;
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.DimGray;
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.Font = new Font("Segoe UI", 26.25F);
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(83, 350);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 64);
            btn2.TabIndex = 12;
            btn2.Text = "2";
            btn2.TextAlign = ContentAlignment.TopCenter;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(287, 496);
            Controls.Add(btn0);
            Controls.Add(btnAC);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(btn1);
            Controls.Add(btnAlterarSinal);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btn2);
            Controls.Add(btnVirgula);
            Controls.Add(btnPorcentagem);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btn3);
            Controls.Add(btnIgual);
            Controls.Add(btnDivisao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSoma);
            Controls.Add(txtDigitos);
            Name = "Calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Calculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDigitos;
        private Button btnSoma;
        private Button btnMultiplicacao;
        private Button btnSubtracao;
        private Button btnDivisao;
        private Button btnIgual;
        private Button btnVirgula;
        private Button btnPorcentagem;
        private Button btn6;
        private Button btn9;
        private Button btn3;
        private Button btn0;
        private Button btnAC;
        private Button btn4;
        private Button btn7;
        private Button btn1;
        private Button btnAlterarSinal;
        private Button btn5;
        private Button btn8;
        private Button btn2;
    }
}
