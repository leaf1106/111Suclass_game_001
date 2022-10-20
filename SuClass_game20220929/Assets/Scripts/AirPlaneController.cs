using UnityEngine;

namespace Leaf
{
    /// <summary>
    /// �������ʱ��2D�Ҧ�
    /// </summary>
    public class AirPlaneController : MonoBehaviour
    {
        [Header("���ʳt��")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 4f;
        [Header("�Ϥ�")]
        [SerializeField]
        private Sprite pictureUp;
        [SerializeField]
        private Sprite pictureMid;
        [SerializeField]
        private Sprite pictureDown;
    }
}

