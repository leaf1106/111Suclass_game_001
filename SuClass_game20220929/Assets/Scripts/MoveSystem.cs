using UnityEngine;

namespace Leaf
{
    ///<summary>
    ///移動系統
    ///</summary>
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("移動速度"), Range(-10, 0)]
        private float speed = -3.5f;

        private void Update()
        {
            //transform此物件的Transform元件
            //Translate(x, y, z) 位移
            //Time.deltaTime每個幀數所花費之時間 
            transform.Translate(speed*Time.deltaTime , 0 , 0 );
        }
    }

}
