namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmConversorMoeda
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
            this.txtValorEmDolar = new System.Windows.Forms.TextBox();
            this.lblPrimeiroValor = new System.Windows.Forms.Label();
            this.lblSegundoValor = new System.Windows.Forms.Label();
            this.cmbPrimeiroValor = new System.Windows.Forms.ComboBox();
            this.cmbSegundoValor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtValorEmDolar
            // 
            this.txtValorEmDolar.BackColor = System.Drawing.Color.Silver;
            this.txtValorEmDolar.Location = new System.Drawing.Point(112, 64);
            this.txtValorEmDolar.Name = "txtValorEmDolar";
            this.txtValorEmDolar.PlaceholderText = "informe o valor";
            this.txtValorEmDolar.ShortcutsEnabled = false;
            this.txtValorEmDolar.Size = new System.Drawing.Size(151, 23);
            this.txtValorEmDolar.TabIndex = 1;
            // 
            // lblPrimeiroValor
            // 
            this.lblPrimeiroValor.AutoSize = true;
            this.lblPrimeiroValor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrimeiroValor.ForeColor = System.Drawing.Color.White;
            this.lblPrimeiroValor.Location = new System.Drawing.Point(12, 9);
            this.lblPrimeiroValor.Name = "lblPrimeiroValor";
            this.lblPrimeiroValor.Size = new System.Drawing.Size(0, 17);
            this.lblPrimeiroValor.TabIndex = 3;
            // 
            // lblSegundoValor
            // 
            this.lblSegundoValor.AutoSize = true;
            this.lblSegundoValor.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSegundoValor.ForeColor = System.Drawing.Color.White;
            this.lblSegundoValor.Location = new System.Drawing.Point(12, 26);
            this.lblSegundoValor.Name = "lblSegundoValor";
            this.lblSegundoValor.Size = new System.Drawing.Size(0, 30);
            this.lblSegundoValor.TabIndex = 4;
            // 
            // cmbPrimeiroValor
            // 
            this.cmbPrimeiroValor.AutoCompleteCustomSource.AddRange(new string[] {
            "D",
            "L",
            "E",
            "R"});
            this.cmbPrimeiroValor.FormattingEnabled = true;
            this.cmbPrimeiroValor.Items.AddRange(new object[] {
            "Dolar Americano",
            "Euro",
            "Libra Esterlina",
            "Real"});
            this.cmbPrimeiroValor.Location = new System.Drawing.Point(112, 93);
            this.cmbPrimeiroValor.Name = "cmbPrimeiroValor";
            this.cmbPrimeiroValor.Size = new System.Drawing.Size(151, 23);
            this.cmbPrimeiroValor.TabIndex = 5;
            this.cmbPrimeiroValor.SelectedIndexChanged += new System.EventHandler(this.cmbPrimeiroValor_SelectedIndexChanged);
            // 
            // cmbSegundoValor
            // 
            this.cmbSegundoValor.FormattingEnabled = true;
            this.cmbSegundoValor.Items.AddRange(new object[] {
            "Dolar Americano",
            "Euro",
            "Libra Esterlina"});
            this.cmbSegundoValor.Location = new System.Drawing.Point(112, 122);
            this.cmbSegundoValor.Name = "cmbSegundoValor";
            this.cmbSegundoValor.Size = new System.Drawing.Size(151, 23);
            this.cmbSegundoValor.TabIndex = 6;
            // 
            // frmConversorMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(318, 181);
            this.Controls.Add(this.cmbSegundoValor);
            this.Controls.Add(this.cmbPrimeiroValor);
            this.Controls.Add(this.lblSegundoValor);
            this.Controls.Add(this.lblPrimeiroValor);
            this.Controls.Add(this.txtValorEmDolar);
            this.MaximizeBox = false;
            this.Name = "frmConversorMoeda";
            this.Text = "frmConversorMoeda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtValorEmDolar;
        private Label lblPrimeiroValor;
        private Label lblSegundoValor;
        private ComboBox cmbPrimeiroValor;
        private ComboBox cmbSegundoValor;
    }
}