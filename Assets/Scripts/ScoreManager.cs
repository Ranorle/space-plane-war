using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; // 单例，以便在其他脚本中访问
    
    public TextMeshProUGUI scoreText; // UI Text 组件，用于显示分数
    private static int score = 0; // 当前分数

    void Awake()
    {
        // 设置单例
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // 初始化分数为 0
        UpdateScoreText();
    }

    // 增加分数
    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    public void GuiLing()
    {
        score = 0;
        UpdateScoreText();
    }

    // 更新分数的 UI 显示
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}