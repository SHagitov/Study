using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steps
{
    class DataProcessing
    {
        string currentData;

        private OptionDataProcessing process;

        public void SetProcess(OptionDataProcessing Option)
        {
            this.process = Option;
        }

        public DataProcessing(string CurrentData)
        {
            this.currentData = CurrentData;
        }

        public void ActionProcessing()
        {
            process(this.currentData);
        }
    }
}
