using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UFarmControl
{
   public partial class SensorTemperatura : Sensor
    {
        public SensorTemperatura() 
        {
            status = false;
            dataColocado = DateTime.Now;
        }
    } 
}
