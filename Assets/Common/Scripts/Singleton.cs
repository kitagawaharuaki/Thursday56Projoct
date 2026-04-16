using UnityEngine;

public class Singleton
{
    public class Singleton<T> where T : Singleton<T>, new()
    {
        private static T _instance;

        /// <summary>
        /// インスタンス
        /// </summary>
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new T();
                    _instance.Initialize();
                }
                return _instance;
            }
        }

        protected bool _isInitialize;

        /// <summary>
        /// 初期化
        /// </summary>
        protected virtual void Initialize()
        {
        }
    }
}
}
