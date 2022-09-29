namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmComissionamento
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
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblCodigoPeca = new System.Windows.Forms.Label();
            this.lblQuantidadePeca = new System.Windows.Forms.Label();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.txtCodigoPeca = new System.Windows.Forms.TextBox();
            this.txtQuantidadePeca = new System.Windows.Forms.TextBox();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCalcularComissao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(46, 62);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(57, 15);
            this.lblVendedor.TabIndex = 0;
            this.lblVendedor.Text = "Vendedor";
            // 
            // lblCodigoPeca
            // 
            this.lblCodigoPeca.AutoSize = true;
            this.lblCodigoPeca.Location = new System.Drawing.Point(46, 108);
            this.lblCodigoPeca.Name = "lblCodigoPeca";
            this.lblCodigoPeca.Size = new System.Drawing.Size(93, 15);
            this.lblCodigoPeca.TabIndex = 1;
            this.lblCodigoPeca.Text = "Código da Peça ";
            // 
            // lblQuantidadePeca
            // 
            this.lblQuantidadePeca.AutoSize = true;
            this.lblQuantidadePeca.Location = new System.Drawing.Point(46, 163);
            this.lblQuantidadePeca.Name = "lblQuantidadePeca";
            this.lblQuantidadePeca.Size = new System.Drawing.Size(113, 15);
            this.lblQuantidadePeca.TabIndex = 2;
            this.lblQuantidadePeca.Text = "Quantidade de Peça";
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Location = new System.Drawing.Point(290, 108);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(101, 15);
            this.lblPrecoUnitario.TabIndex = 3;
            this.lblPrecoUnitario.Text = "Preço  da Unitario";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Items.AddRange(new object[] {
            "JOAO",
            "JOAREZ",
            "JOAQUINA",
            "JOAZINHO",
            "JOANA"});
            this.cmbVendedor.Location = new System.Drawing.Point(160, 54);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(159, 23);
            this.cmbVendedor.TabIndex = 4;
            // 
            // txtCodigoPeca
            // 
            this.txtCodigoPeca.Location = new System.Drawing.Point(181, 100);
            this.txtCodigoPeca.Name = "txtCodigoPeca";
            this.txtCodigoPeca.Size = new System.Drawing.Size(100, 23);
            this.txtCodigoPeca.TabIndex = 5;
            this.txtCodigoPeca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtQuantidadePeca
            // 
            this.txtQuantidadePeca.Location = new System.Drawing.Point(181, 155);
            this.txtQuantidadePeca.Name = "txtQuantidadePeca";
            this.txtQuantidadePeca.Size = new System.Drawing.Size(100, 23);
            this.txtQuantidadePeca.TabIndex = 6;
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(408, 100);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(100, 23);
            this.txtPrecoUnitario.TabIndex = 7;
            this.txtPrecoUnitario.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 23);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btnCalcularComissao
            // 
            this.btnCalcularComissao.Location = new System.Drawing.Point(190, 214);
            this.btnCalcularComissao.Name = "btnCalcularComissao";
            this.btnCalcularComissao.Size = new System.Drawing.Size(171, 39);
            this.btnCalcularComissao.TabIndex = 9;
            this.btnCalcularComissao.Text = "Calcular Comissão";
            this.btnCalcularComissao.UseVisualStyleBackColor = true;
            // 
            // frmComissionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 290);
            this.Controls.Add(this.btnCalcularComissao);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtPrecoUnitario);
            this.Controls.Add(this.txtQuantidadePeca);
            this.Controls.Add(this.txtCodigoPeca);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(this.lblPrecoUnitario);
            this.Controls.Add(this.lblQuantidadePeca);
            this.Controls.Add(this.lblCodigoPeca);
            this.Controls.Add(this.lblVendedor);
            this.Name = "frmComissionamento";
            this.Text = "Comissão de Vendedores de Peças";
            this.Load += new System.EventHandler(this.frmComissionamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblVendedor;
        private Label lblCodigoPeca;
        private Label lblQuantidadePeca;
        private Label lblPrecoUnitario;
        private ComboBox cmbVendedor;
        private TextBox txtCodigoPeca;
        private TextBox txtQuantidadePeca;
        private TextBox txtPrecoUnitario;
        private DateTimePicker dateTimePicker1;
        private Button btnCalcularComissao;
    }
}