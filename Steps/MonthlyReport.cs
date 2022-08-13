using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steps
{
    /// <summary>
    /// Структура, описывающая данные по месяцам
    /// </summary>
    struct MonthlyReport
    {
        /// <summary>
        /// Название месяца
        /// </summary>
        public string Month;

        /// <summary>
        /// Доход
        /// </summary>
        public int Income;

        /// <summary>
        /// Расход
        /// </summary>
        public int consumption;

        /// <summary>
        /// Прибыль
        /// </summary>
        public int arrived;
    }
}
