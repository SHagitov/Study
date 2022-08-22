namespace Steps
{
    /// <summary>
    /// Наполнение твита
    /// </summary>
    public class TwitterMessageArgs
    {
        public string Time { get; set; }
        public string Message { get; set; }
        public Content[] Objs { get; set; }
    }
}
