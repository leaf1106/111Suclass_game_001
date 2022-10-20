using UnityEngine;

namespace Leaf
{
    ///<summary>
    ///移動速度
    ///</summary>
    public class MoveSpeed : MonoBehaviour
    {
        [SerializeField, Header("移動速度"), Range(-10, 0)]
        private float speed = -3.5f;
    }

}
