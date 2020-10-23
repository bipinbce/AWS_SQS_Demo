using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSSQSDemo.Models
{
    
    public class ServiceConfiguration
    {
        public AWSSQS AWSSQS { get; set; }
    }
    public class AWSSQS
    {
        public string QueueUrl { get; set; }
    }
}
