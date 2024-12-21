using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public ScoreManager scoreManager; // ������ �� ScoreManager

    // �����, ���������� ��� ������������
    private void OnCollisionEnter(Collision collision)
    {
        // ���������, ��� ������������ ��������� � ������ ��������
        if (collision.gameObject.CompareTag("Object"))
        {
            scoreManager.DecreaseScore(); // ��������� �������
        }
    }
}