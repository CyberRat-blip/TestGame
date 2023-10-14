using UnityEngine;
using TMPro;

public class DamageController : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public SpriteRenderer healthBar; // ������ �� ��������� SpriteRenderer ��� ����������� ������ ��������
    private Vector3 initialScale; // ��������� ������� ������ ��������
    public DropSystem dropSystem; // ������ �� ������� ��������� ���������
    void Start()
    {
        currentHealth = maxHealth;
        initialScale = healthBar.transform.localScale;
        UpdateHealthUI(); // ��������� UI ��� ������
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Max(currentHealth, 0); // ������ �� �������������� ��������
        UpdateHealthUI(); // ��������� UI ��� ��������� �����

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // ������, ������� ����������� ��� ������ �����
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        dropSystem.DropLoot(); // �������� ����� ��������� ���������
        
        Destroy(gameObject);
    }

    void UpdateHealthUI()
    {
        float scaleX = (float)currentHealth / maxHealth; // ��������� ����� ������� �� X ��� ������
        healthBar.transform.localScale = new Vector3(initialScale.x * scaleX, initialScale.y, initialScale.z); // ������������� ����� �������

        
    }
}
