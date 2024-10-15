using System;
using System.IO;
using UnityEngine;

namespace STS
{
    public class Setting
    {
        private string path;
        private void Awake()
        {
            switch (Application.platform)
            {
                case RuntimePlatform.Android: 
                    path = Application.persistentDataPath; 
                    break;
                case RuntimePlatform.WindowsPlayer: 
                    path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); 
                    break;
            }
            FileStream stream = new FileStream(path + "/setting.json", FileMode.OpenOrCreate);

        }
    }
}
