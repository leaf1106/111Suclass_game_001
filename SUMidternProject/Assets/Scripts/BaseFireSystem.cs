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
        private Transform pointSpawn;

        //自訂方法
        //生成子彈
        // protect 保護級別 : 允許子類別存取
        protected void SpawnBullet()
        {
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
        }
    }
}