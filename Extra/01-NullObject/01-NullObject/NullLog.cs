namespace _01_NullObject
{
    public sealed class NullLog : ILog
    {
        public int RecordLimit
        {
            get
            {
                return 0;
            }
        }

        // number of elements already in the log
        public int RecordCount
        {
            get
            {
                return -1;
            }
            set
            {
               
            }
        }

        public void Info(string msg)
        {

        }

        public void Warn(string msg)
        {

        }
    }
}
