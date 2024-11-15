using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFarmControl
{
    public partial class SensorCo2 : Sensor
    {
        public SensorCo2()
        {
            status = false;
            dataColocado = DateTime.Now;
        }
    }
}
