namespace Singleton
{
    public class SingletonClass
    {
        private SingletonClass() { }

        private static SingletonClass instance;

        /// <summary>
        /// This property creates an instance for you if doesn't exists any instance of this class and returns it.
        /// otherwise, returns previous instance.
        /// </summary>
        public static SingletonClass Instance
        {
            get
            {
                if (instance == null)
                    instance = new SingletonClass();

                return instance;
            }
        }

        /// <summary>
        /// The sample value with int type.
        /// </summary>
        public int intValue { get; set; }

        /// <summary>
        /// The sample value with string type.
        /// </summary>
        public string strValue { get; set; }

    }
}
