using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steps
{
    public class Temporary<Template1, Template2>
    {
        public Temporary(Template1 Value1, Template2 Value2)
        {
            Property1 = Value1;
            Property2 = Value2;
        }

        public Template1 Property1 { get; set; }
        public Template2 Property2 { get; set; }

        public void GetPropertyInformation()
        {
            Console.WriteLine($"type Property1: {Property1.GetType(),14} value1:{Property1,7}");
            Console.WriteLine($"type Property2: {Property2.GetType(),14} value2:{Property2,7}\n");
        }
    }
}
