using UnityEngine;

public class DropSystem : MonoBehaviour
{
    public GameObject itemPrefab; // Префаб предмета

    public void DropLoot()
    {
        // Создаем экземпляр префаба на сцене
        GameObject newItem = Instantiate(itemPrefab, transform.position, Quaternion.identity);

        // Подключите здесь код, который делает предмет доступным для подбора игроком.
    }
}