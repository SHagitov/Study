namespace Steps
{
    internal class DataProcessing
    {
        private readonly string currentData;

        private OptionDataProcessing process;

        public void SetProcess(OptionDataProcessing Option)
        {
            process = Option;
        }

        public DataProcessing(string CurrentData)
        {
            currentData = CurrentData;
        }

        public void ActionProcessing()
        {
            process(currentData);
        }
    }
}
