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
            this.flatCount = flatCount;
            this.address = address;
        }

        private int floorCount; // Поле количество этажей
        private int flatCount;  // Поле количество квартир
        private string address; // Поле адрес


        /// <summary>
        /// Количество этажей
        /// </summary>
        public int FloorCount { get { return this.flatCount; } }

        /// <summary>
        /// Количество квартир
        /// </summary>
        public int FlatCount { get { return this.flatCount; } }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get { return this.address; } }

    }
}
