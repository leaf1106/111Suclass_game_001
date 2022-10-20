using UnityEngine;

namespace Leaf
{
    /// <summary>
    /// 學習欄位 Field
    /// </summary>
    public class LearnField : MonoBehaviour
    {
        /// <summary>
        /// 欄位 Field:儲存資料
        /// 語法:
        /// 修飾詞 資料類型 欄位名稱
        /// 私人 private:僅在此功能內能夠存取，不顯示
        /// </summary>
        private int level;
        //等於 指定符號:將等於右邊的結果指定給左邊
        private string name = "Leaf";
        // 公開 public:所有功能都能夠存取，顯示
        public int enemy = 6;

        public string playername = "Johnson";

        public float speed = 4.5f;
        public float jump = 3.5f;

        public bool isAttack = false;
        public bool hasWeapon = true;

        //標題
        [Header("血量")]
        public int HP = 99;
        //提示
        [Tooltip("玩家遊玩的時間。")]
        public float time = 15.5f;
        //數值專用範圍(最大值，最小值)
        [Range(1, 99)]
        public int runspeed = 10;
        [Range(5f, 60f)]
        public float strength = 15.5f;
        //序列化欄位:顯示私人欄位
        [SerializeField]
        private int bomb = 10;
    }

}
