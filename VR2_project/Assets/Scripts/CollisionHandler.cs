using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public ScoreManager scoreManager; // Ссылка на ScoreManager

    // Метод, вызываемый при столкновении
    private void OnCollisionEnter(Collision collision)
    {
        // Проверяем, что столкновение произошло с другим объектом
        if (collision.gameObject.CompareTag("Object"))
        {
            scoreManager.DecreaseScore(); // Уменьшаем счётчик
        }
    }
}