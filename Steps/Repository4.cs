using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steps
{
    /// <summary>
    /// Репозиторий
    /// </summary>
    struct Repository4
    {
        /// <summary>
        /// База данных сотрудников
        /// </summary>
        private Worker[] Workers;


        public string this[int index]
        {
            get { return this.Workers[index].Print(); }
        }

        public string this[string i]
        {
            get
            {
                switch (i)
                {
                    case "+": return "Плюс";
                    case "-": return "Минус";
                    case "*": return "Умножить";
                    default: return "что-то иное";
                }
            }

        }


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Args">Список сотрудников</param>
        public Repository4(params Worker[] Args)
        {
            Workers = Args;
        }
    }
}