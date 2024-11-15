using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFarmControl
{
    public partial class SensorUmidade : Sensor
    {
        public SensorUmidade()
        {
            status = false;
            dataColocado = DateTime.Now;
        }
    }
}
