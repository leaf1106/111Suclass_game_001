using UnityEngine;

namespace Leaf
{
    /// <summary>
    /// 玩家發射系統
    /// </summary>
    public class PlayerFireSystem : BaseFireSystem
    {
        //偵測玩家的輸入行為 : 鍵盤、滑鼠、觸控、搖桿
        private void Update()
        {
            //如果 玩家 按下空白建 就會生成子彈
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }
    }

}

