using UnityEngine;

namespace Leaf
{
    /// <summary>
    /// �ˮ`�t��
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("�|�y���ˮ`���ؼ�")]
        private string nameTarget;
        //private string nameTarget2;
        //private string nameTarget3;
        [SerializeField, Header("�z���w�s��")]
        private GameObject prefabExplossion;

        //�I�����}�l�ƥ� �@��
        private void OnCollisionEnter2D(Collision2D collision)
        {
            //print("�I��:" + collision.gameObject);

            //�p�G �I�쪫�󪺦W�� �]�t �ľ�1�B2�B3 �N�z��
            if(collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplossion, transform.position, transform.rotation);

                //Destroy �R��
                //gameObject ������
                Destroy(gameObject);
            }
        }

        //�I�����}�ƥ� �@��
        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }

        //�I������ƥ�
        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
    }
}


