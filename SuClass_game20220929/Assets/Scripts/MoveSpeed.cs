using UnityEngine;

namespace Leaf
{
    ///<summary>
    ///���ʳt��
    ///</summary>
    public class MoveSpeed : MonoBehaviour
    {
        [SerializeField, Header("���ʳt��"), Range(-10, 0)]
        private float speed = -3.5f;
    }

}
