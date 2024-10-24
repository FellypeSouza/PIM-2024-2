namespace UFarmControl
{
    partial class PaginaProprietario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaProprietario));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button40 = new System.Windows.Forms.Button();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.button39 = new System.Windows.Forms.Button();
            this.label259 = new System.Windows.Forms.Label();
            this.label258 = new System.Windows.Forms.Label();
            this.label257 = new System.Windows.Forms.Label();
            this.label256 = new System.Windows.Forms.Label();
            this.label255 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lucros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prejuizos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gastosMensais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "UFarm Control";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ItemSize = new System.Drawing.Size(80, 30);
            this.tabControl1.Location = new System.Drawing.Point(-2, 63);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1194, 593);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1186, 555);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "Relatórios";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(982, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 32);
            this.button2.TabIndex = 27;
            this.button2.Text = "Consultar Dados";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lucros,
            this.Prejuizos,
            this.gastosMensais});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1186, 555);
            this.dataGridView2.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage4.Controls.Add(this.button40);
            this.tabPage4.Controls.Add(this.pictureBox15);
            this.tabPage4.Controls.Add(this.button39);
            this.tabPage4.Controls.Add(this.label259);
            this.tabPage4.Controls.Add(this.label258);
            this.tabPage4.Controls.Add(this.label257);
            this.tabPage4.Controls.Add(this.label256);
            this.tabPage4.Controls.Add(this.label255);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1186, 555);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Meu Perfil";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(604, 438);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(103, 30);
            this.button40.TabIndex = 8;
            this.button40.Text = "Alterar Senha";
            this.button40.UseVisualStyleBackColor = true;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(481, 69);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(226, 204);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 7;
            this.pictureBox15.TabStop = false;
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(481, 438);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(103, 30);
            this.button39.TabIndex = 6;
            this.button39.Text = "Alterar Dados";
            this.button39.UseVisualStyleBackColor = true;
            // 
            // label259
            // 
            this.label259.AutoSize = true;
            this.label259.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label259.Location = new System.Drawing.Point(477, 353);
            this.label259.Name = "label259";
            this.label259.Size = new System.Drawing.Size(75, 20);
            this.label259.TabIndex = 4;
            this.label259.Text = "Telefone:";
            // 
            // label258
            // 
            this.label258.AutoSize = true;
            this.label258.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label258.Location = new System.Drawing.Point(477, 373);
            this.label258.Name = "label258";
            this.label258.Size = new System.Drawing.Size(56, 20);
            this.label258.TabIndex = 3;
            this.label258.Text = "Cargo:";
            // 
            // label257
            // 
            this.label257.AutoSize = true;
            this.label257.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label257.Location = new System.Drawing.Point(477, 393);
            this.label257.Name = "label257";
            this.label257.Size = new System.Drawing.Size(52, 20);
            this.label257.TabIndex = 2;
            this.label257.Text = "Email:";
            // 
            // label256
            // 
            this.label256.AutoSize = true;
            this.label256.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label256.Location = new System.Drawing.Point(477, 333);
            this.label256.Name = "label256";
            this.label256.Size = new System.Drawing.Size(45, 20);
            this.label256.TabIndex = 1;
            this.label256.Text = "CEP:";
            // 
            // label255
            // 
            this.label255.AutoSize = true;
            this.label255.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label255.Location = new System.Drawing.Point(476, 298);
            this.label255.Name = "label255";
            this.label255.Size = new System.Drawing.Size(70, 25);
            this.label255.TabIndex = 0;
            this.label255.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(997, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bem vindo(a) Fellype";
            // 
            // Lucros
            // 
            this.Lucros.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Lucros.HeaderText = "Lucros";
            this.Lucros.Name = "Lucros";
            this.Lucros.ReadOnly = true;
            this.Lucros.Width = 76;
            // 
            // Prejuizos
            // 
            this.Prejuizos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Prejuizos.HeaderText = "Prejuízos";
            this.Prejuizos.Name = "Prejuizos";
            this.Prejuizos.ReadOnly = true;
            this.Prejuizos.Width = 91;
            // 
            // gastosMensais
            // 
            this.gastosMensais.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gastosMensais.HeaderText = "Gastos Mensais";
            this.gastosMensais.Name = "gastosMensais";
            this.gastosMensais.ReadOnly = true;
            this.gastosMensais.Width = 123;
            // 
            // PaginaProprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 654);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "PaginaProprietario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaginaProprietario";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Label label259;
        private System.Windows.Forms.Label label258;
        private System.Windows.Forms.Label label257;
        private System.Windows.Forms.Label label256;
        private System.Windows.Forms.Label label255;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lucros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prejuizos;
        private System.Windows.Forms.DataGridViewTextBoxColumn gastosMensais;
    }
}