using System;

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
            this.Dislocation = Dislocation;
        }

        /// <summary>
        /// Место дислокации
        /// </summary>
        public string Dislocation { get; }

        /// <summary>
        /// Никнейм
        /// </summary>
        public string Nickname { get; set; }

        public bool Equals(Robot other)
        {
            return Nickname == other.Nickname
                   && Dislocation == other.Dislocation;
        }
    }
}
