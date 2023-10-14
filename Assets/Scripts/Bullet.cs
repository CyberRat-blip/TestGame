using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f; // Скорость полета пули
    public float lifetime = 2f; // Время жизни пули

    private int damage = 1; // Урон пули

    void Start()
    {
        // Запускаем таймер уничтожения пули
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Если пуля попала во что-то, наносим урон и уничтожаем пулю
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<DamageController>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }

    public void SetDamage(int newDamage)
    {
        damage = newDamage;
    }
}