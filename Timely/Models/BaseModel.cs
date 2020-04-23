using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timely.Models
{
    [Serializable]
    public class BaseModel
    {
        public string Id { get; set; }
        public BaseModel()
        {
            Id = Guid.NewGuid().ToString().Substring(0, 7);
        }
    }
}
