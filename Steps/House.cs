namespace Steps
{
    /// <summary>
    /// класс «Дом»
    /// </summary>
    public class House
    {
        /// <summary>
        /// Создание дома
        /// </summary>
        /// <param name="FloorCount">Количество этажей</param>
        /// <param name="flatCount">Количество квартир</param>
        /// <param name="address">Адрес</param>
        public House(int FloorCount, int flatCount, string address)
        {
            this.floorCount = FloorCount;
            this.FloorCount = flatCount;
            this.Address = address;
        }

        private int floorCount; // Поле количество этажей


        /// <summary>
        /// Количество этажей
        /// </summary>
        public int FloorCount { get; }

        /// <summary>
        /// Количество квартир
        /// </summary>
        public int FlatCount => this.FloorCount;

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; }

    }
}
