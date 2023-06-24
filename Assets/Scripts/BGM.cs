using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BGM : MonoBehaviour
{
    public Button toggleMusicButton; // 按钮的引用
    // Start is called before the first frame update
    private AudioSource BackGroundMusic;
    private bool isPlaying = true;
    
    void Start()
    {
        BackGroundMusic = GetComponent<AudioSource>();
        toggleMusicButton.onClick.AddListener(ToggleMusic);
        
    }
    public void ToggleMusic()
    {
        if (isPlaying)
        {
            // 如果音乐正在播放, 暂停它
            BackGroundMusic.Pause();
        }
        else
        {
            // 如果音乐已暂停, 播放它
            BackGroundMusic.Play();
        }
        // 切换状态标志
        isPlaying = !isPlaying;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
