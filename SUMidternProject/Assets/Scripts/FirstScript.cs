using UnityEngine;
/// <summary>
/// 第一個程式
/// </summary>

namespace Leaf
{
    public class FirstScript : MonoBehaviour
    {
        #region 註解內容
        /*多行註解
         * 多行註解
         */
        //喚醒事件:在遊戲開始時執行一次
        private void Awake()
        {
            print("哈囉，沃德");
        }
        //開始事件:在 Awake 後執行一次
        private void Start()
        {
            print("<color=orange>這是開始事件</color>");
        }
        //更新事件:在 Start 後，每秒執行 60 FPS
        private void Update()
        {
            print("<color=yellow>這是更新事件</color>");
        }

        #endregion
    }
}
