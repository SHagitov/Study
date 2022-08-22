using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steps
{
    /// <summary>
    /// Наполнение твита
    /// </summary>
    public class TwitterMessageArgs
    {
        public string Time { get; set; }
        public string Message { get; set; }
        public Content[] Objs { get; set; }
    }
}
