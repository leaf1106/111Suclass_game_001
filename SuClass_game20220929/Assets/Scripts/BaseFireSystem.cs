using UnityEngine;
namespace Leaf
{
    /// <summary>
    /// �o�g�t�ΰ����O
    /// </summary>
    public class BaseFireSystem : MonoBehaviour
    {
        [SerializeField, Header("�l�u�w�")]
        private GameObject prefabBullet;
        [SerializeField, Header("�l�u�ͦ��I")]
        private Transform pointspawn;
    }
}