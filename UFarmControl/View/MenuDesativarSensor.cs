using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UFarmControl.View
{
    public partial class MenuDesativarSensor : Form
    {
        private SensorTemperatura SensorTemperatura;
        private SensorLuminosidade SensorLuminosidade;
        private SensorUmidade SensorUmidade;
        private SensorCo2 SensorCo2;
        public MenuDesativarSensor(SensorTemperatura SensorTemperatura,
                                SensorLuminosidade SensorLuminosidade,
                                SensorUmidade SensorUmidade,
                                SensorCo2 SensorCo2)
        {
            InitializeComponent();
            this.SensorTemperatura = SensorTemperatura;
            this.SensorUmidade = SensorUmidade;
            this.SensorCo2 = SensorCo2;
            this.SensorLuminosidade = SensorLuminosidade;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBoxDesativarSensor.Text == "Sensor de Temperatura")
            {
                SensorTemperatura.setStatus(true);

            }
            else if (comboBoxDesativarSensor.Text == "Sensor de Umidade")
            {
                SensorUmidade.setStatus(true);
            }
            else if (comboBoxDesativarSensor.Text == "Sensor de Luminosidade")
            {
                SensorLuminosidade.setStatus(true);
            }
            else if (comboBoxDesativarSensor.Text == "Sensor de CO2")
            {
                SensorCo2.setStatus(true);
            }
            this.Hide();
        }
    }
}
