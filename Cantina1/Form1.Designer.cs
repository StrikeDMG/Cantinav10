
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
            btnEnd = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            txtCantina = new Label();
            txtTotal = new Label();
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
            btnRmv.Location = new Point(342, 175);
            btnRmv.Name = "btnRmv";
            btnRmv.Size = new Size(75, 26);
            btnRmv.TabIndex = 3;
            btnRmv.Text = "Remover";
            btnRmv.UseVisualStyleBackColor = true;
            btnRmv.Click += btnRmv_Click;
            // 
            // btnEnd
            // 
            btnEnd.Location = new Point(342, 246);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(75, 23);
            btnEnd.TabIndex = 4;
            btnEnd.Text = "Finalizar";
            btnEnd.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(62, 100);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(147, 169);
            listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(583, 100);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(153, 169);
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
            txtTotal.Location = new Point(351, 296);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(36, 15);
            txtTotal.TabIndex = 8;
            txtTotal.Text = "Total:";
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotal);
            Controls.Add(txtCantina);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(btnEnd);
            Controls.Add(btnRmv);
            Controls.Add(btnAdd);
            Controls.Add(txtCart);
            Controls.Add(txtProd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtProd;
        private Label txtCart;
        private Button btnAdd;
        private Button btnRmv;
        private Button btnEnd;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label txtCantina;
        private Label txtTotal;
        private readonly EventHandler txtTotal_Click;
    }
}
