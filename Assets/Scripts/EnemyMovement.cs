using System;
using UnityEngine;
using System.Collections.Generic;

[Serializable]
public class EnemyData
{
    public int id;
    public int health;
    public float[] position;
}

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float detectionDistance = 5f;
    public int damage = 10;

    private Transform player;
    private bool isAttacking = false;
    private SpriteRenderer spriteRenderer;
    public int health = 100; // Здоровье
    public int currentHealth;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        spriteRenderer = GetComponent<SpriteRenderer>();

        currentHealth = health; // Инициализируем текущее здоровье
    }

    void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= detectionDistance && !isAttacking)
        {
            Vector2 direction = player.position - transform.position;
            transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);

            if (distanceToPlayer <= 2f)
            {
                Stop(); // Останавливаемся перед атакой
                Attack(); // Атакуем
            }
        }

        // Проверяем направление движения и разворачиваем спрайт при необходимости
        if (transform.position.x < player.position.x)
        {
            spriteRenderer.flipX = false; // Персонаж смотрит вправо
        }
        else
        {
            spriteRenderer.flipX = true; // Персонаж смотрит влево
        }
    }

    void Stop()
    {
        isAttacking = true;
    }

    void Attack()
    {
        Invoke("ResetAttack", 2f); // Вызываем ResetAttack через 2 секунды
        PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
        }
    }

    void ResetAttack()
    {
        isAttacking = false;
    }

    // Метод для получения данных о враге
    public EnemyData GetEnemyData()
    {
        EnemyData data = new EnemyData();
        data.id = gameObject.GetInstanceID();
        data.health = currentHealth;
        data.position = new float[] { transform.position.x, transform.position.y };
        return data;
    }

    // Метод для применения данных о враге
    public void SetEnemyData(EnemyData data)
    {
        currentHealth = data.health;
        Vector2 enemyPosition = new Vector2(data.position[0], data.position[1]);
        transform.position = enemyPosition;
    }
    public int GetEnemyHealth()
    {
        return health;
    }

    public int GetEnemyID()
    {
        return gameObject.GetInstanceID();
    }

    public void SetEnemyHealth(int newHealth)
    {
        health = newHealth;
    }
}
