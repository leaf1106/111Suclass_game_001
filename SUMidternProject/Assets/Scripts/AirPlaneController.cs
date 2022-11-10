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
        private float speedVertical = 6f;
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 8f;
        [Header("圖片")]
        [SerializeField]
        private Sprite pictureUp;
        [SerializeField]
        private Sprite pictureMid;
        [SerializeField]
        private Sprite pictureDown;
        [SerializeField, Header("圖片渲染元件")]
        private SpriteRenderer spr;

        private void Update()
        {
            //上下 WS Vertical
            //左右 AD Horizontal

            //上 W +1
            //下 S -1
            //沒按 0
            float v = Input.GetAxis("Vertical");
            //右 D +1
            //左 A -1
            //沒按 0
            float h = Input.GetAxis("Horizontal");

            transform.Translate(
                speedHorizontal * Time.deltaTime * h, 
                speedVertical * Time.deltaTime * v, 
                0);

        }
    }
}

