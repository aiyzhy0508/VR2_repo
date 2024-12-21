using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Ссылка на текстовый элемент
    private int score = 10; // Начальное значение счётчика

    // Метод для уменьшения счётчика
    public void DecreaseScore()
    {
        score--;
        if (score < 0) score = 0; // Не позволяем счётчику стать отрицательным
        scoreText.text = "Score: " + score;
    }
}