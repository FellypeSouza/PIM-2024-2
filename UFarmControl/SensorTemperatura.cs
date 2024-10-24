using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFarmControl
{
    public partial class SensorTemperatura
    {
        Boolean status;
        public Boolean getStatus()
        {
            return status;
        }
        public void setStatus(Boolean status) 
        {
            this.status = status;
        }
        DateTime dataColocado;
        public Boolean getDataColocado()
        {
            return status;
        }
        public void setDataColocado(DateTime dataColocado)
        {
            this.dataColocado = dataColocado;
        }
        public SensorTemperatura() 
        {
            status = false;
            dataColocado = DateTime.Today;
        }
    }
}
