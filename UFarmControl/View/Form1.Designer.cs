namespace UFarmControl
{
    partial class Form1
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
            this.nome = new System.Windows.Forms.TextBox();
            this.cep = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.registrar = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.TextBox();
            this.senhaCheckBox = new System.Windows.Forms.CheckBox();
            this.limpar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCampoVazio = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(154, 130);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(160, 20);
            this.nome.TabIndex = 0;
            // 
            // cep
            // 
            this.cep.Location = new System.Drawing.Point(154, 172);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(160, 20);
            this.cep.TabIndex = 1;
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(154, 214);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(160, 20);
            this.telefone.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CEP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(149, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Insira seus dados";
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(154, 391);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(75, 23);
            this.registrar.TabIndex = 9;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(154, 298);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(160, 20);
            this.email.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Senha";
            // 
            // senha
            // 
            this.senha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.senha.Location = new System.Drawing.Point(154, 339);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(160, 20);
            this.senha.TabIndex = 10;
            this.senha.UseSystemPasswordChar = true;
            // 
            // senhaCheckBox
            // 
            this.senhaCheckBox.AutoSize = true;
            this.senhaCheckBox.Location = new System.Drawing.Point(154, 365);
            this.senhaCheckBox.Name = "senhaCheckBox";
            this.senhaCheckBox.Size = new System.Drawing.Size(102, 17);
            this.senhaCheckBox.TabIndex = 12;
            this.senhaCheckBox.Text = "Visualizar senha";
            this.senhaCheckBox.UseVisualStyleBackColor = true;
            this.senhaCheckBox.CheckedChanged += new System.EventHandler(this.senhaCheckBox_CheckedChanged);
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(239, 391);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(75, 23);
            this.limpar.TabIndex = 13;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "UFarm Control";
            // 
            // labelCampoVazio
            // 
            this.labelCampoVazio.AutoSize = true;
            this.labelCampoVazio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCampoVazio.Location = new System.Drawing.Point(101, 424);
            this.labelCampoVazio.Name = "labelCampoVazio";
            this.labelCampoVazio.Size = new System.Drawing.Size(0, 20);
            this.labelCampoVazio.TabIndex = 15;
            this.labelCampoVazio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Funcionário",
            "Gerente",
            "Proprietário"});
            this.comboBox1.Location = new System.Drawing.Point(154, 256);
            this.comboBox1.MaxDropDownItems = 3;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cargo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelCampoVazio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.senhaCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.cep);
            this.Controls.Add(this.nome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox cep;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.CheckBox senhaCheckBox;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelCampoVazio;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
    }
}

