using System;

namespace WanteLes1_1
{
    internal class Program
    {
        public delegate int SendDocDelegate();

        /// <summary>
        /// Post to Blog
        /// </summary>
        /// <returns>0</returns>
        public static int PostToBlog()
        {
            Console.WriteLine("Posting to Blog");
            return 0;
        }

        /// <summary>
        /// Post to Class
        /// </summary>
        /// <returns>0</returns>
        public static int PostToClass()
        {
            Console.WriteLine("Posting to class");
            return 0;
        }

        /// <summary>
        /// Post to Email
        /// </summary>
        /// <returns>0</returns>
        public static int PostToEmail()
        {
            Console.WriteLine("Posting to email");
            return 0;
        }
        private static void Main(string[] args)
        {
            SendDocDelegate sendDocDelegate;
            if (DateTime.Now.Hour < 12)
            {
                sendDocDelegate = PostToBlog;
            }
            else if (DateTime.Now.Hour > 12 && DateTime.Now.Hour < 15)
            {
                sendDocDelegate = PostToClass;
            }
            else
            {
                sendDocDelegate = PostToEmail;
            }

            sendDocDelegate();

            Console.ReadKey();
        }
    }
}