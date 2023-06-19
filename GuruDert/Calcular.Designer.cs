namespace GuruDert
{
    partial class Calcular
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
            this.lb_computador = new System.Windows.Forms.Label();
            this.tx_comput = new System.Windows.Forms.TextBox();
            this.lb_cliente = new System.Windows.Forms.Label();
            this.tx_cliente = new System.Windows.Forms.TextBox();
            this.lb_pagamento = new System.Windows.Forms.Label();
            this.lb_final = new System.Windows.Forms.Label();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.cbx_servico = new System.Windows.Forms.ComboBox();
            this.cbx_pagamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_computador
            // 
            this.lb_computador.AutoSize = true;
            this.lb_computador.Location = new System.Drawing.Point(198, 62);
            this.lb_computador.Name = "lb_computador";
            this.lb_computador.Size = new System.Drawing.Size(84, 16);
            this.lb_computador.TabIndex = 0;
            this.lb_computador.Text = "Computador:";
            // 
            // tx_comput
            // 
            this.tx_comput.Location = new System.Drawing.Point(298, 59);
            this.tx_comput.Name = "tx_comput";
            this.tx_comput.Size = new System.Drawing.Size(100, 22);
            this.tx_comput.TabIndex = 1;
            // 
            // lb_cliente
            // 
            this.lb_cliente.AutoSize = true;
            this.lb_cliente.Location = new System.Drawing.Point(198, 98);
            this.lb_cliente.Name = "lb_cliente";
            this.lb_cliente.Size = new System.Drawing.Size(51, 16);
            this.lb_cliente.TabIndex = 2;
            this.lb_cliente.Text = "Cliente:";
            // 
            // tx_cliente
            // 
            this.tx_cliente.Location = new System.Drawing.Point(298, 98);
            this.tx_cliente.Name = "tx_cliente";
            this.tx_cliente.Size = new System.Drawing.Size(100, 22);
            this.tx_cliente.TabIndex = 3;
            // 
            // lb_pagamento
            // 
            this.lb_pagamento.AutoSize = true;
            this.lb_pagamento.Location = new System.Drawing.Point(173, 195);
            this.lb_pagamento.Name = "lb_pagamento";
            this.lb_pagamento.Size = new System.Drawing.Size(130, 16);
            this.lb_pagamento.TabIndex = 4;
            this.lb_pagamento.Text = "Tipo de Pagamento:";
            // 
            // lb_final
            // 
            this.lb_final.AutoSize = true;
            this.lb_final.Location = new System.Drawing.Point(197, 231);
            this.lb_final.Name = "lb_final";
            this.lb_final.Size = new System.Drawing.Size(69, 16);
            this.lb_final.TabIndex = 6;
            this.lb_final.Text = "Valor final:";
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(191, 273);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_salvar.TabIndex = 7;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(354, 273);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 8;
            this.bt_cancelar.Text = "Calcelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // cbx_servico
            // 
            this.cbx_servico.FormattingEnabled = true;
            this.cbx_servico.Items.AddRange(new object[] {
            "Formatação",
            "",
            "Limpeza",
            "",
            "Troca de Peça"});
            this.cbx_servico.Location = new System.Drawing.Point(308, 146);
            this.cbx_servico.Name = "cbx_servico";
            this.cbx_servico.Size = new System.Drawing.Size(121, 24);
            this.cbx_servico.TabIndex = 9;
            this.cbx_servico.SelectedIndexChanged += new System.EventHandler(this.cbx_servico_SelectedIndexChanged);
            // 
            // cbx_pagamento
            // 
            this.cbx_pagamento.FormattingEnabled = true;
            this.cbx_pagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "",
            "Pix",
            "",
            "Cartão"});
            this.cbx_pagamento.Location = new System.Drawing.Point(318, 195);
            this.cbx_pagamento.Name = "cbx_pagamento";
            this.cbx_pagamento.Size = new System.Drawing.Size(121, 24);
            this.cbx_pagamento.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Servico:";
            // 
            // Calcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_pagamento);
            this.Controls.Add(this.cbx_servico);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.lb_final);
            this.Controls.Add(this.lb_pagamento);
            this.Controls.Add(this.tx_cliente);
            this.Controls.Add(this.lb_cliente);
            this.Controls.Add(this.tx_comput);
            this.Controls.Add(this.lb_computador);
            this.Name = "Calcular";
            this.Text = "Calcular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_computador;
        private System.Windows.Forms.TextBox tx_comput;
        private System.Windows.Forms.Label lb_cliente;
        private System.Windows.Forms.TextBox tx_cliente;
        private System.Windows.Forms.Label lb_pagamento;
        private System.Windows.Forms.Label lb_final;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.ComboBox cbx_servico;
        private System.Windows.Forms.ComboBox cbx_pagamento;
        private System.Windows.Forms.Label label1;
    }
}