namespace UFarmControl.View
{
    partial class MenuDesativarSensor
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
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxDesativarSensor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(77, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 25);
            this.button3.TabIndex = 10;
            this.button3.Text = "Confirmar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBoxDesativarSensor
            // 
            this.comboBoxDesativarSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDesativarSensor.FormattingEnabled = true;
            this.comboBoxDesativarSensor.Items.AddRange(new object[] {
            "Sensor de Temperatura",
            "Sensor de Umidade",
            "Sensor de Luminosidade",
            "Sensor de CO2"});
            this.comboBoxDesativarSensor.Location = new System.Drawing.Point(25, 39);
            this.comboBoxDesativarSensor.Name = "comboBoxDesativarSensor";
            this.comboBoxDesativarSensor.Size = new System.Drawing.Size(196, 28);
            this.comboBoxDesativarSensor.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Qual sensor deseja desativar ?";
            // 
            // MenuDesativarSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 109);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBoxDesativarSensor);
            this.Controls.Add(this.label2);
            this.Name = "MenuDesativarSensor";
            this.Text = "MenuDesativarSensor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxDesativarSensor;
        private System.Windows.Forms.Label label2;
    }
}