namespace MarketSystem
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
            Titulo = new Label();
            nameProduto = new TextBox();
            valueProduto = new TextBox();
            btnCadastro = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(12, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(190, 37);
            Titulo.TabIndex = 0;
            Titulo.Text = "Market System";
            // 
            // nameProduto
            // 
            nameProduto.Location = new Point(51, 107);
            nameProduto.Name = "nameProduto";
            nameProduto.Size = new Size(151, 23);
            nameProduto.TabIndex = 1;
            // 
            // valueProduto
            // 
            valueProduto.Location = new Point(51, 155);
            valueProduto.Name = "valueProduto";
            valueProduto.Size = new Size(151, 23);
            valueProduto.TabIndex = 1;
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(62, 198);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(126, 35);
            btnCadastro.TabIndex = 2;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 126);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 302);
            Controls.Add(label1);
            Controls.Add(btnCadastro);
            Controls.Add(valueProduto);
            Controls.Add(nameProduto);
            Controls.Add(Titulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private TextBox nameProduto;
        private TextBox valueProduto;
        private Button btnCadastro;
        private Label label1;
    }
}
