using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    public AudioClip explosionSound; // 音效文件

    private void Start()
    {
        // 不需要在这里添加 AudioSource，因为我们将在每次碰撞时创建一个新的游戏对象来播放音效
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }

        // 创建爆炸效果，并添加 AutoDestroyParticleSystem 脚本
        GameObject explosionInstance = Instantiate(explosion, transform.position, transform.rotation);
        explosionInstance.AddComponent<AutoDestroyParticleSystem>();

        // 播放音效
        if (explosionSound != null)
        {
            // 创建一个新的空游戏对象来播放音效
            GameObject audioObject = new GameObject("TempAudio");
            audioObject.transform.position = transform.position;
            AudioSource audioSource = audioObject.AddComponent<AudioSource>();
            audioSource.clip = explosionSound;
            audioSource.Play();

            // 销毁音频对象
            Destroy(audioObject, audioSource.clip.length);
        }

        // 击败敌人加分
        ScoreManager.instance.AddScore(1);

        if (other.tag == "Player")
        {
            GameObject playerExplosionInstance = Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            playerExplosionInstance.AddComponent<AutoDestroyParticleSystem>();
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}