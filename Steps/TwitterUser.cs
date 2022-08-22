using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steps
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class TwitterUser
    {
        /// <summary>
        /// Nick пользователя
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Nick">Nick пользователя</param>
        public TwitterUser(string Nick)
        {
            this.Nick = $"@{Nick}";
        }

        /// <summary>
        /// Публикация сообщения
        /// </summary>
        /// <param name="Msg">Текст сообщения</param>
        public void PublicMessage(string Msg)
        {
            var agrs = new TwitterMessageArgs()
            {
                Time = DateTime.Now.ToShortTimeString(),
                Message = Msg
            };

            Page.Print($"Сообщение \"{Msg}\" опубликовал {Nick}\n");

            //if (this.Post != null) Post(this, agrs);
            post?.Invoke(this, agrs);

        }

        /// <summary>
        /// Публикация сообщения
        /// </summary>
        /// <param name="Msg">Текст сообщения</param>
        /// <param name="Docs">Вложения</param>
        public void PublicMessage(string Msg, params Content[] Docs)
        {
            var args = new TwitterMessageArgs()
            {
                Time = DateTime.Now.ToShortTimeString(),
                Message = Msg,
                Objs = Docs
            };

            Page.Print($"Сообщение  \"{Msg}\" и другой контент опубликовал {Nick} \n");
            post?.Invoke(this, args);
        }

        private event Action<object, TwitterMessageArgs> post;

        #region ToDo

        public event Action<object, TwitterMessageArgs> Post
        {
            add // Организация подписки
            {
                Console.WriteLine($"У пользователя {this.Nick} новый подписчик. {(value.Target as TwitterUser).Nick}");
                post += value;
            }

            remove // Организация отписки
            {
                Console.WriteLine($"{(value.Target as TwitterUser).Nick} отписался от пользователя {this.Nick}. ");
                post -= value;
            }
        }

        #endregion

        /// <summary>
        /// Механизм отображения всех сообщений текущего пользователя в ленте
        /// </summary>
        /// <param name="sender">Отправитель сообщения</param>
        /// <param name="e">Параметры сообщения</param>
        public void Tape(object sender, TwitterMessageArgs e)
        {
            var user = sender as TwitterUser;

            Page.Print($"--> Лента {this.Nick}:  {user.Nick} опубликовал: {e.Message} ");

            if (e.Objs != null)
            {
                Console.Write("и ");
                foreach (var args in e.Objs)
                {
                    Console.Write($"{args.GetType().Name} ");
                }
            }
            Console.WriteLine();
        }
    }
}
