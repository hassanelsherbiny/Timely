using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timely.Models
{
    public class WorkTask : BaseModel
    {
        public string TaskName { get; set; }

        public List<WorkPeriod> WorkPeriods { get; set; }

        public WorkTask()
        {
            WorkPeriods = new List<WorkPeriod>();
        }
    }
}
