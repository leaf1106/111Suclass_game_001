using UnityEngine;

namespace Leaf
{
    /// <summary>
    /// 傷害系統
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("會造成傷害的目標")]
        private string nameTarget;
        //private string nameTarget2;
        //private string nameTarget3;
        [SerializeField, Header("爆炸預製物")]
        private GameObject prefabExplossion;

        //碰撞的開始事件 一次
        private void OnCollisionEnter2D(Collision2D collision)
        {
            //print("碰撞:" + collision.gameObject);

            //如果 碰到物件的名稱 包含 敵機1、2、3 就爆炸
            if(collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplossion, transform.position, transform.rotation);

                //Destroy 刪除
                //gameObject 此物件
                Destroy(gameObject);
            }
        }

        //碰撞離開事件 一次
        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }

        //碰撞持續事件
        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
    }
}


