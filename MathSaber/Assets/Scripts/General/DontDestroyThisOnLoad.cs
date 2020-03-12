using UnityEngine;

namespace General
{
    public class DontDestroyThisOnLoad : MonoBehaviour
    {
        #region Singleton

        private static DontDestroyThisOnLoad _instance;

        private void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
            }

            if (_instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                DontDestroyOnLoad(gameObject);
            }
        }

        #endregion
    }
}