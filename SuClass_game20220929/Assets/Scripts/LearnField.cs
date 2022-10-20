using UnityEngine;

namespace Leaf
{
    /// <summary>
    /// �ǲ���� Field
    /// </summary>
    public class LearnField : MonoBehaviour
    {
        /// <summary>
        /// ��� Field:�x�s���
        /// �y�k:
        /// �׹��� ������� ���W��
        /// �p�H private:�Ȧb���\�ऺ����s���A�����
        /// </summary>
        private int level;
        //���� ���w�Ÿ�:�N����k�䪺���G���w������
        private string name = "Leaf";
        // ���} public:�Ҧ��\�ೣ����s���A���
        public int enemy = 6;

        public string playername = "Johnson";

        public float speed = 4.5f;
        public float jump = 3.5f;

        public bool isAttack = false;
        public bool hasWeapon = true;

        //���D
        [Header("��q")]
        public int HP = 99;
        //����
        [Tooltip("���a�C�����ɶ��C")]
        public float time = 15.5f;
        //�ƭȱM�νd��(�̤j�ȡA�̤p��)
        [Range(1, 99)]
        public int runspeed = 10;
        [Range(5f, 60f)]
        public float strength = 15.5f;
        //�ǦC�����:��ܨp�H���
        [SerializeField]
        private int bomb = 10;
    }

}
