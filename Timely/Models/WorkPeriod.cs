using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timely.Models
{
    public class WorkPeriod : BaseModel
    {
        public DateTime From { get; set; }
        public DateTime? To { get; set; }

        public TimeSpan Period
        {
            get
            {
                return To != null ? (To.Value - From) : new TimeSpan();
            }
        }

    }
}
