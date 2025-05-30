namespace Cantina1
{
    partial class FormBalcao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxPedidosPendentes = new ListBox();
            btnMarcarEmPreparo = new Button();
            btnMarcarPronto = new Button();
            listBoxPedidosProntos = new ListBox();
            lblClienteDetalhe = new Label();
            lblStatusDetalhe = new Label();
            SuspendLayout();
            // 
            // listBoxPedidosPendentes
            // 
            listBoxPedidosPendentes.FormattingEnabled = true;
            listBoxPedidosPendentes.ItemHeight = 15;
            listBoxPedidosPendentes.Location = new Point(12, 12);
            listBoxPedidosPendentes.Name = "listBoxPedidosPendentes";
            listBoxPedidosPendentes.Size = new Size(271, 334);
            listBoxPedidosPendentes.TabIndex = 0;
            // 
            // btnMarcarEmPreparo
            // 
            btnMarcarEmPreparo.Location = new Point(95, 352);
            btnMarcarEmPreparo.Name = "btnMarcarEmPreparo";
            btnMarcarEmPreparo.Size = new Size(75, 23);
            btnMarcarEmPreparo.TabIndex = 1;
            btnMarcarEmPreparo.Text = "Preparo";
            btnMarcarEmPreparo.UseVisualStyleBackColor = true;
            // 
            // btnMarcarPronto
            // 
            btnMarcarPronto.Location = new Point(609, 352);
            btnMarcarPronto.Name = "btnMarcarPronto";
            btnMarcarPronto.Size = new Size(75, 23);
            btnMarcarPronto.TabIndex = 2;
            btnMarcarPronto.Text = "Pronto";
            btnMarcarPronto.UseVisualStyleBackColor = true;
            // 
            // listBoxPedidosProntos
            // 
            listBoxPedidosProntos.FormattingEnabled = true;
            listBoxPedidosProntos.ItemHeight = 15;
            listBoxPedidosProntos.Location = new Point(517, 12);
            listBoxPedidosProntos.Name = "listBoxPedidosProntos";
            listBoxPedidosProntos.Size = new Size(271, 334);
            listBoxPedidosProntos.TabIndex = 4;
            // 
            // lblClienteDetalhe
            // 
            lblClienteDetalhe.AutoSize = true;
            lblClienteDetalhe.Location = new Point(307, 16);
            lblClienteDetalhe.Name = "lblClienteDetalhe";
            lblClienteDetalhe.Size = new Size(38, 15);
            lblClienteDetalhe.TabIndex = 5;
            lblClienteDetalhe.Text = "label1";
            // 
            // lblStatusDetalhe
            // 
            lblStatusDetalhe.AutoSize = true;
            lblStatusDetalhe.Location = new Point(307, 240);
            lblStatusDetalhe.Name = "lblStatusDetalhe";
            lblStatusDetalhe.Size = new Size(38, 15);
            lblStatusDetalhe.TabIndex = 6;
            lblStatusDetalhe.Text = "label2";
            // 
            // FormBalcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatusDetalhe);
            Controls.Add(lblClienteDetalhe);
            Controls.Add(listBoxPedidosProntos);
            Controls.Add(btnMarcarPronto);
            Controls.Add(btnMarcarEmPreparo);
            Controls.Add(listBoxPedidosPendentes);
            Name = "FormBalcao";
            Text = "FormBalcao";
            Load += FormBalcao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxPedidosPendentes;
        private Button btnMarcarEmPreparo;
        private Button btnMarcarPronto;
        private ListBox listBoxPedidosProntos;
        private Label lblClienteDetalhe;
        private Label lblStatusDetalhe;
    }
}