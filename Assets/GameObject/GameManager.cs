using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int maxHP = 100;
    public int currentHP;

    public Text scoreText;
    public Text hpText;

    void Start()
    {
        currentHP = maxHP;
        UpdateUI();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateUI();
    }

    public void DecreaseHP(int amount)
    {
        currentHP -= amount;
        if (currentHP <= 0)
        {
            currentHP = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            // ??? Over
        }
        UpdateUI();
    }

    void UpdateUI()
    {
        scoreText.text = "Score: " + score.ToString();
        hpText.text = "HP: " + currentHP.ToString();
    }
}
