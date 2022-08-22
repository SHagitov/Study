using System;

namespace Steps
{
    public class ApiService
    {
        public static string GetData()
        {
            string t = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                t += Guid.NewGuid().ToString();
            }
            return t;
        }
    }
}
