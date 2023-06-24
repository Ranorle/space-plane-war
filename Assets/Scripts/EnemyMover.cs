using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public float speed = 1f; // 设置敌人的移动速度

    void Update()
    {
        // 每一帧移动敌人沿着z轴的负方向
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}