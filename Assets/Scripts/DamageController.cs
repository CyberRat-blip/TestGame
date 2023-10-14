using UnityEngine;
using TMPro;

public class DamageController : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public SpriteRenderer healthBar; // Ссылка на компонент SpriteRenderer для отображения полосы здоровья
    private Vector3 initialScale; // Начальный масштаб полосы здоровья
    public DropSystem dropSystem; // Ссылка на систему выпадения предметов
    void Start()
    {
        currentHealth = maxHealth;
        initialScale = healthBar.transform.localScale;
        UpdateHealthUI(); // Обновляем UI при старте
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Max(currentHealth, 0); // Защита от отрицательного здоровья
        UpdateHealthUI(); // Обновляем UI при получении урона

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Логика, которая выполняется при смерти врага
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        dropSystem.DropLoot(); // Вызываем метод выпадения предметов
        
        Destroy(gameObject);
    }

    void UpdateHealthUI()
    {
        float scaleX = (float)currentHealth / maxHealth; // Вычисляем новый масштаб по X для полосы
        healthBar.transform.localScale = new Vector3(initialScale.x * scaleX, initialScale.y, initialScale.z); // Устанавливаем новый масштаб

        
    }
}
