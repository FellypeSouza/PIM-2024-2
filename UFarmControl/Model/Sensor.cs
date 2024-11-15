using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFarmControl
{
    public partial class Sensor
    {
        public Boolean status;
        public Boolean getStatus()
        {
            return status;
        }
        public void setStatus(Boolean status)
        {
            this.status = status;
        }
        public DateTime dataColocado;
        public DateTime getDataColocado()
        {
            return dataColocado;
        }
        public void setDataColocado(DateTime dataColocado)
        {
            this.dataColocado = dataColocado;
        }
        public Sensor()
        {
            status = false;
            dataColocado = DateTime.Now;

        }
    }
}
