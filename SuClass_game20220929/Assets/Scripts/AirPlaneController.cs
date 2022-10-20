using UnityEngine;

namespace Leaf
{
    /// <summary>
    /// 飛機移動控制器2D模式
    /// </summary>
    public class AirPlaneController : MonoBehaviour
    {
        [Header("移動速度")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 4f;
        [Header("圖片")]
        [SerializeField]
        private Sprite pictureUp;
        [SerializeField]
        private Sprite pictureMid;
        [SerializeField]
        private Sprite pictureDown;
    }
}

