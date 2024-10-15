using DireRaven22075;
using UnityEngine;

namespace STS.Manager
{
    public class AssetBundleManager : Singleton<AssetBundleManager>
    {



        public void Load(string id)
        {
            AssetBundle.LoadFromFile(
                $"{Application.dataPath}/Bundle/{id}.unity3d");
            //AssetBundle.LoadFromFile();
        }
        void Start()
        {
            
        }
        void Update()
        {

        }
    }
}
