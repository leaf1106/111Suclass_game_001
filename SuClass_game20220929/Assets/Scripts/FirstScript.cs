using UnityEngine;
/// <summary>
/// �Ĥ@�ӵ{��
/// </summary>

namespace Leaf
{
    public class FirstScript : MonoBehaviour
    {
        #region ���Ѥ��e
        /*�h�����
         * �h�����
         */
        //����ƥ�:�b�C���}�l�ɰ���@��
        private void Awake()
        {
            print("���o�A�U�w");
        }
        //�}�l�ƥ�:�b Awake �����@��
        private void Start()
        {
            print("<color=orange>�o�O�}�l�ƥ�</color>");
        }
        //��s�ƥ�:�b Start ��A�C����� 60 FPS
        private void Update()
        {
            print("<color=yellow>�o�O��s�ƥ�</color>");
        }

        #endregion
    }
}
