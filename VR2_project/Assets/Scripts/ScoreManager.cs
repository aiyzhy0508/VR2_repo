using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // ������ �� ��������� �������
    private int score = 10; // ��������� �������� ��������

    // ����� ��� ���������� ��������
    public void DecreaseScore()
    {
        score--;
        if (score < 0) score = 0; // �� ��������� �������� ����� �������������
        scoreText.text = "Score: " + score;
    }
}