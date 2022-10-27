using UnityEngine;
namespace Leaf
{
    /// <summary>
    /// 發射系統基底類別
    /// </summary>
    public class BaseFireSystem : MonoBehaviour
    {
        [SerializeField, Header("子彈預制物")]
        private GameObject prefabBullet;
        [SerializeField, Header("子彈生成點")]
        private Transform pointspawn;
    }
}