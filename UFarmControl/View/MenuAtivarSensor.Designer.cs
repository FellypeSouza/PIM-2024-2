namespace UFarmControl.View
{
    partial class MenuAtivarSensor
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAtivarSensor = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Qual sensor deseja ativar ?";
            // 
            // comboBoxAtivarSensor
            // 
            this.comboBoxAtivarSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAtivarSensor.FormattingEnabled = true;
            this.comboBoxAtivarSensor.Items.AddRange(new object[] {
            "Sensor de Temperatura",
            "Sensor de Umidade",
            "Sensor de Luminosidade",
            "Sensor de CO2"});
            this.comboBoxAtivarSensor.Location = new System.Drawing.Point(21, 36);
            this.comboBoxAtivarSensor.Name = "comboBoxAtivarSensor";
            this.comboBoxAtivarSensor.Size = new System.Drawing.Size(196, 28);
            this.comboBoxAtivarSensor.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(72, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 25);
            this.button3.TabIndex = 5;
            this.button3.Text = "Confirmar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MenuAtivarSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 107);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBoxAtivarSensor);
            this.Controls.Add(this.label2);
            this.Name = "MenuAtivarSensor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAtivarSensor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAtivarSensor;
        private System.Windows.Forms.Button button3;
    }
}