namespace GuruDert
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_servico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_servico
            // 
            this.bt_servico.Location = new System.Drawing.Point(321, 224);
            this.bt_servico.Name = "bt_servico";
            this.bt_servico.Size = new System.Drawing.Size(75, 23);
            this.bt_servico.TabIndex = 1;
            this.bt_servico.Text = "Serviços";
            this.bt_servico.UseVisualStyleBackColor = true;
            this.bt_servico.Click += new System.EventHandler(this.bt_servico_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_servico);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_servico;
    }
}

