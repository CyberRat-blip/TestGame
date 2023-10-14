using UnityEngine;

public class DataManager : MonoBehaviour
{
    // Метод, который присваивает значения персонажу, врагам и инвентарю
    public void ApplyDataToGame(SaveData data)
    {
        // Применить данные к персонажу
        PlayerHealth.Instance.currentHealth = data.playerData.health;
        PlayerMovement.Instance.transform.position = new Vector3(data.playerData.position[0], data.playerData.position[1], 0f);

        // Применить данные к врагам
        SaveSystem.LoadEnemies(data.enemiesData);

        // Применить данные к инвентарю
        Inventory.Instance.ApplyInventoryData(data.inventoryData);
    }

    // Метод, который сохраняет все данные
    public void SaveData()
    {
        SaveData data = new SaveData();
        data.inventoryData = Inventory.Instance.SaveInventoryData();

        // Добавьте код для сохранения здоровья персонажа и позиции

        SaveSystem.SaveGame(data);
        Debug.Log("Game data saved.");
    }
}
