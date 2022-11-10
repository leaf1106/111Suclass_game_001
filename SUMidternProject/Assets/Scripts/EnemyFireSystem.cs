using System;
using UnityEngine;

namespace Leaf
{
    /// <summary>
    /// 敵方發射系統
    /// </summary>
    public class EnemyFireSystem : BaseFireSystem
    {
        [SerializeField, Header("生成間格"), Range(0, 3)]
        private float interval = 1.5f;
        private void Awake()
        {
            //呼叫自訂方法
            //SpawnBullet();

            InvokeRepeating("SpawnBullet", 0, interval);
        }
    }

}
