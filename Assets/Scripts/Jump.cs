using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneJump : MonoBehaviour {
    // Use this for initialization
    void Start () {
		
    }
	
    // Update is called once per frame
    void Update () {
		
    }
    public void Jump ()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Jump2 ()
    {
        SceneManager.LoadScene("SampleScene");
        ScoreManager.instance.GuiLing();
    }
    public void Back ()
    {
        SceneManager.LoadScene("StartScean");
        ScoreManager.instance.GuiLing();
    }
    public void Exit ()
    {
    // 如果是在 Unity 编辑器中运行，停止播放
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
            Application.Quit();
    #endif
    }
}