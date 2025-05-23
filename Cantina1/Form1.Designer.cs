
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            txtPaidValue = new TextBox();
            lblClientName = new Label();
            txtClientName = new TextBox();
            numericUpDown1 = new NumericUpDown();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            label2 = new Label();
            lblChange = new Label();
            gbPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // txtProd
            // 
            txtProd.AutoSize = true;
            txtProd.BackColor = Color.White;
            txtProd.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProd.Location = new Point(70, 164);
            txtProd.Name = "txtProd";
            txtProd.Size = new Size(151, 37);
            txtProd.TabIndex = 0;
            txtProd.Text = "| Produtos";
            // 
            // txtCart
            // 
            txtCart.AutoSize = true;
            txtCart.BackColor = Color.White;
            txtCart.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCart.Location = new Point(731, 164);
            txtCart.Name = "txtCart";
            txtCart.Size = new Size(144, 37);
            txtCart.TabIndex = 1;
            txtCart.Text = "| Carrinho";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.WindowText;
            btnAdd.FlatAppearance.BorderColor = Color.Black;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Black;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Black;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.FromArgb(230, 255, 0);
            btnAdd.Location = new Point(554, 297);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 47);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRmv
            // 
            btnRmv.BackColor = SystemColors.WindowText;
            btnRmv.FlatAppearance.BorderColor = Color.Black;
            btnRmv.FlatAppearance.BorderSize = 0;
            btnRmv.FlatAppearance.MouseDownBackColor = Color.Black;
            btnRmv.FlatAppearance.MouseOverBackColor = Color.Black;
            btnRmv.FlatStyle = FlatStyle.Flat;
            btnRmv.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRmv.ForeColor = Color.FromArgb(230, 255, 0);
            btnRmv.Location = new Point(482, 347);
            btnRmv.Name = "btnRmv";
            btnRmv.Size = new Size(117, 47);
            btnRmv.TabIndex = 3;
            btnRmv.Text = "Remover";
            btnRmv.UseVisualStyleBackColor = false;
            btnRmv.Click += btnRmv_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = SystemColors.WindowText;
            btnCheckout.FlatAppearance.BorderColor = SystemColors.WindowText;
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.FlatAppearance.MouseDownBackColor = SystemColors.WindowText;
            btnCheckout.FlatAppearance.MouseOverBackColor = SystemColors.WindowText;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.FromArgb(230, 255, 0);
            btnCheckout.Location = new Point(493, 633);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(117, 45);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Finalizar";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(70, 217);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(304, 462);
            listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 21;
            listBox2.Location = new Point(731, 204);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(304, 315);
            listBox2.TabIndex = 6;
            // 
            // txtCantina
            // 
            txtCantina.AutoSize = true;
            txtCantina.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCantina.ForeColor = Color.FromArgb(230, 255, 0);
            txtCantina.Location = new Point(238, 54);
            txtCantina.Name = "txtCantina";
            txtCantina.Size = new Size(168, 47);
            txtCantina.TabIndex = 7;
            txtCantina.Text = "x Cantina";
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.BackColor = Color.White;
            txtTotal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(731, 522);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(73, 32);
            txtTotal.TabIndex = 8;
            txtTotal.Text = "Total:";
            // 
            // gbPayment
            // 
            gbPayment.BackColor = SystemColors.WindowText;
            gbPayment.Controls.Add(rbPix);
            gbPayment.Controls.Add(rbCredit);
            gbPayment.Controls.Add(rbDebit);
            gbPayment.Controls.Add(rbCash);
            gbPayment.FlatStyle = FlatStyle.Flat;
            gbPayment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbPayment.ForeColor = Color.FromArgb(230, 255, 0);
            gbPayment.Location = new Point(430, 400);
            gbPayment.Name = "gbPayment";
            gbPayment.Size = new Size(244, 140);
            gbPayment.TabIndex = 9;
            gbPayment.TabStop = false;
            gbPayment.Text = "Formas de pagamento";
            // 
            // rbPix
            // 
            rbPix.AutoSize = true;
            rbPix.Location = new Point(5, 109);
            rbPix.Name = "rbPix";
            rbPix.Size = new Size(52, 25);
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
            rbCredit.Size = new Size(83, 25);
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
            rbDebit.Size = new Size(78, 25);
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
            rbCash.Size = new Size(90, 25);
            rbCash.TabIndex = 0;
            rbCash.TabStop = true;
            rbCash.Text = "Dinheiro";
            rbCash.UseVisualStyleBackColor = true;
            rbCash.CheckedChanged += PaymentMethod_CheckedChanged;
            // 
            // lblPaidValue
            // 
            lblPaidValue.AutoSize = true;
            lblPaidValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaidValue.ForeColor = Color.FromArgb(230, 255, 0);
            lblPaidValue.Location = new Point(430, 569);
            lblPaidValue.Name = "lblPaidValue";
            lblPaidValue.Size = new Size(125, 21);
            lblPaidValue.TabIndex = 10;
            lblPaidValue.Text = "Valor Pago (R$):";
            // 
            // txtPaidValue
            // 
            txtPaidValue.Location = new Point(571, 567);
            txtPaidValue.Name = "txtPaidValue";
            txtPaidValue.Size = new Size(100, 23);
            txtPaidValue.TabIndex = 12;
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientName.ForeColor = Color.FromArgb(230, 255, 0);
            lblClientName.Location = new Point(430, 246);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(65, 21);
            lblClientName.TabIndex = 13;
            lblClientName.Text = "Cliente:";
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(509, 246);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(131, 23);
            txtClientName.TabIndex = 14;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = SystemColors.WindowText;
            numericUpDown1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown1.ForeColor = Color.FromArgb(230, 255, 0);
            numericUpDown1.Location = new Point(437, 308);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(82, 29);
            numericUpDown1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(70, 147);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(304, 70);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Location = new Point(731, 147);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(304, 70);
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Location = new Point(729, 509);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(306, 170);
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(731, 495);
            label1.Name = "label1";
            label1.Size = new Size(306, 24);
            label1.TabIndex = 20;
            label1.Text = "-------------------------------------";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(230, 255, 0);
            pictureBox5.Location = new Point(399, 147);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(304, 532);
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(430, 550);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(249, 84);
            pictureBox7.TabIndex = 23;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(422, 226);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(249, 65);
            pictureBox8.TabIndex = 24;
            pictureBox8.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(230, 255, 0);
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(405, 164);
            label2.Name = "label2";
            label2.Size = new Size(235, 37);
            label2.TabIndex = 25;
            label2.Text = "| Dados o Pedido";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.ForeColor = Color.FromArgb(230, 255, 0);
            lblChange.Location = new Point(557, 600);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(114, 21);
            lblChange.TabIndex = 11;
            lblChange.Text = "Troco: R$ 0,00";
            lblChange.Click += lblChange_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(1067, 712);
            Controls.Add(label2);
            Controls.Add(txtClientName);
            Controls.Add(lblClientName);
            Controls.Add(pictureBox8);
            Controls.Add(txtPaidValue);
            Controls.Add(lblPaidValue);
            Controls.Add(label1);
            Controls.Add(txtProd);
            Controls.Add(numericUpDown1);
            Controls.Add(lblChange);
            Controls.Add(gbPayment);
            Controls.Add(txtTotal);
            Controls.Add(txtCantina);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(btnCheckout);
            Controls.Add(btnRmv);
            Controls.Add(btnAdd);
            Controls.Add(txtCart);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbPayment.ResumeLayout(false);
            gbPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
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
        private TextBox txtPaidValue;
        private Label lblClientName;
        private TextBox txtClientName;
        private NumericUpDown numericUpDown1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Label label2;
        private Label lblChange;
    }
}
