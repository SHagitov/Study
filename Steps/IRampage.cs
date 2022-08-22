namespace Steps
{
    /// <summary>
    /// Ультра атака
    /// </summary>
    internal interface IRampage
    {
        /// <summary>
        /// Количество зарядов
        /// </summary>
        int Charge { get; set; }

        /// <summary>
        /// Логика перезарядки
        /// </summary>
        void Recharge();

        /// <summary>
        /// Логика ультра атаки
        /// </summary>
        /// <param name="Target">Цель для атаки</param>
        void UltraAttack(Hero Target);

    }
}
