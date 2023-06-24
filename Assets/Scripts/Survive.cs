using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Survive : MonoBehaviour
{
    public GameObject objectToCheck;
    void DelayedAction()
    {
        SceneManager.LoadScene("FailedScean");
    }
    // Update方法每帧都会被调用
    void Update()
    {
        // 检查GameObject是否不再存在
        if (objectToCheck == null)
        {

            Invoke("DelayedAction", 1f);
            // 想要停止检查，禁用这个脚本
            enabled = false;
        }
    }
}
