using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {
    public float speed = 8;
    private Rigidbody rb;

    void Start () {
        rb = GetComponent<Rigidbody>();
        // 使用世界空间的z轴方向，而不是物体的前方
        rb.velocity = Vector3.forward * speed;
    }
}