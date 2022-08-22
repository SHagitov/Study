using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steps
{
    /// <summary>
    /// Робот
    /// </summary>
    public class Robot : IEquatable<Robot>
    {
        /// <summary>
        /// Создание робота
        /// </summary>
        /// <param name="Nickname">Название</param>
        /// <param name="Dislocation">Место дислокации</param>
        public Robot(string Nickname, string Dislocation)
        {
            this.Nickname = Nickname;
            this.dislocation = Dislocation;
        }

        private string dislocation;// Место дислокации

        /// <summary>
        /// Место дислокации
        /// </summary>
        public string Dislocation { get { return this.dislocation; } }

        /// <summary>
        /// Никнейм
        /// </summary>
        public string Nickname { get; set; }

        public bool Equals(Robot other)
        {
            return this.Nickname == other.Nickname
                   && this.dislocation == other.dislocation;
        }
    }
}
