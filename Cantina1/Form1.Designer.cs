
namespace Cantina1
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
            txtProd = new Label();
            txtCart = new Label();
            btnAdd = new Button();
            btnRmv = new Button();
            btnCheckout = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            txtCantina = new Label();
            txtTotal = new Label();
            gbPayment = new GroupBox();
            rbPix = new RadioButton();
            rbCredit = new RadioButton();
            rbDebit = new RadioButton();
            rbCash = new RadioButton();
            lblPaidValue = new Label();
            lblChange = new Label();
            txtPaidValue = new TextBox();
            lblClientName = new Label();
            txtClientName = new TextBox();
            gbPayment.SuspendLayout();
            SuspendLayout();
            // 
            // txtProd
            // 
            txtProd.AutoSize = true;
            txtProd.Location = new Point(62, 50);
            txtProd.Name = "txtProd";
            txtProd.Size = new Size(55, 15);
            txtProd.TabIndex = 0;
            txtProd.Text = "Produtos";
            // 
            // txtCart
            // 
            txtCart.AutoSize = true;
            txtCart.Location = new Point(616, 56);
            txtCart.Name = "txtCart";
            txtCart.Size = new Size(53, 15);
            txtCart.TabIndex = 1;
            txtCart.Text = "Carrinho";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(342, 100);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRmv
            // 
            btnRmv.Location = new Point(423, 97);
            btnRmv.Name = "btnRmv";
            btnRmv.Size = new Size(75, 26);
            btnRmv.TabIndex = 3;
            btnRmv.Text = "Remover";
            btnRmv.UseVisualStyleBackColor = true;
            btnRmv.Click += btnRmv_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(343, 386);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(75, 23);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Finalizar";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(62, 100);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(147, 214);
            listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(583, 100);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(153, 214);
            listBox2.TabIndex = 6;
            // 
            // txtCantina
            // 
            txtCantina.AutoSize = true;
            txtCantina.Location = new Point(356, 50);
            txtCantina.Name = "txtCantina";
            txtCantina.Size = new Size(48, 15);
            txtCantina.TabIndex = 7;
            txtCantina.Text = "Cantina";
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Location = new Point(583, 394);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(36, 15);
            txtTotal.TabIndex = 8;
            txtTotal.Text = "Total:";
            // 
            // gbPayment
            // 
            gbPayment.Controls.Add(rbPix);
            gbPayment.Controls.Add(rbCredit);
            gbPayment.Controls.Add(rbDebit);
            gbPayment.Controls.Add(rbCash);
            gbPayment.Location = new Point(342, 139);
            gbPayment.Name = "gbPayment";
            gbPayment.Size = new Size(200, 140);
            gbPayment.TabIndex = 9;
            gbPayment.TabStop = false;
            gbPayment.Text = "Formas de pagamento";
            // 
            // rbPix
            // 
            rbPix.AutoSize = true;
            rbPix.Location = new Point(5, 109);
            rbPix.Name = "rbPix";
            rbPix.Size = new Size(42, 19);
            rbPix.TabIndex = 3;
            rbPix.TabStop = true;
            rbPix.Text = "PIX";
            rbPix.UseVisualStyleBackColor = true;
            rbPix.CheckedChanged += PaymentMethod_CheckedChanged;
            // 
            // rbCredit
            // 
            rbCredit.AutoSize = true;
            rbCredit.Location = new Point(5, 78);
            rbCredit.Name = "rbCredit";
            rbCredit.Size = new Size(64, 19);
            rbCredit.TabIndex = 2;
            rbCredit.TabStop = true;
            rbCredit.Text = "Crédito";
            rbCredit.UseVisualStyleBackColor = true;
            rbCredit.CheckedChanged += PaymentMethod_CheckedChanged;
            // 
            // rbDebit
            // 
            rbDebit.AutoSize = true;
            rbDebit.Location = new Point(6, 50);
            rbDebit.Name = "rbDebit";
            rbDebit.Size = new Size(60, 19);
            rbDebit.TabIndex = 1;
            rbDebit.TabStop = true;
            rbDebit.Text = "Débito";
            rbDebit.UseVisualStyleBackColor = true;
            rbDebit.CheckedChanged += PaymentMethod_CheckedChanged;
            // 
            // rbCash
            // 
            rbCash.AutoSize = true;
            rbCash.Location = new Point(6, 21);
            rbCash.Name = "rbCash";
            rbCash.Size = new Size(70, 19);
            rbCash.TabIndex = 0;
            rbCash.TabStop = true;
            rbCash.Text = "Dinheiro";
            rbCash.UseVisualStyleBackColor = true;
            rbCash.CheckedChanged += PaymentMethod_CheckedChanged;
            // 
            // lblPaidValue
            // 
            lblPaidValue.AutoSize = true;
            lblPaidValue.Location = new Point(342, 329);
            lblPaidValue.Name = "lblPaidValue";
            lblPaidValue.Size = new Size(90, 15);
            lblPaidValue.TabIndex = 10;
            lblPaidValue.Text = "Valor Pago (R$):";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(342, 357);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(80, 15);
            lblChange.TabIndex = 11;
            lblChange.Text = "Troco: R$ 0,00";
            lblChange.Click += lblChange_Click;
            // 
            // txtPaidValue
            // 
            txtPaidValue.Location = new Point(438, 326);
            txtPaidValue.Name = "txtPaidValue";
            txtPaidValue.Size = new Size(100, 23);
            txtPaidValue.TabIndex = 12;
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Location = new Point(346, 297);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(47, 15);
            lblClientName.TabIndex = 13;
            lblClientName.Text = "Cliente:";
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(438, 294);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(100, 23);
            txtClientName.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 450);
            Controls.Add(txtClientName);
            Controls.Add(lblClientName);
            Controls.Add(txtPaidValue);
            Controls.Add(lblChange);
            Controls.Add(lblPaidValue);
            Controls.Add(gbPayment);
            Controls.Add(txtTotal);
            Controls.Add(txtCantina);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(btnCheckout);
            Controls.Add(btnRmv);
            Controls.Add(btnAdd);
            Controls.Add(txtCart);
            Controls.Add(txtProd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbPayment.ResumeLayout(false);
            gbPayment.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtProd;
        private Label txtCart;
        private Button btnAdd;
        private Button btnRmv;
        private Button btnCheckout;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label txtCantina;
        private Label txtTotal;
        private readonly EventHandler txtTotal_Click;
        private GroupBox gbPayment;
        private RadioButton rbPix;
        private RadioButton rbCredit;
        private RadioButton rbDebit;
        private RadioButton rbCash;
        private Label lblPaidValue;
        private Label lblChange;
        private TextBox txtPaidValue;
        private Label lblClientName;
        private TextBox txtClientName;
    }
}
