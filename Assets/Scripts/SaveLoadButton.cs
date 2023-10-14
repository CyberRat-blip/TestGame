/*using UnityEngine;

public class SaveLoadButton : MonoBehaviour
{
    public GameManager gameManager;

    public void SaveGame()
    {
        if (gameManager != null)
        {
            SaveData saveData = new SaveData();
            saveData.inventoryData = Inventory.Instance.SaveInventoryData();

            // Add player health and position to the saveData
            saveData.playerData = new SaveData.PlayerData
            {
                health = PlayerHealth.Instance.currentHealth,
                position = new float[] {
                PlayerMovement.Instance.transform.position.x,
                PlayerMovement.Instance.transform.position.y
            }
            };

            // Add any other data you want to save

            SaveSystem.SaveGame(saveData);
            Debug.Log("Saved");
        }
        else
        {
            Debug.LogError("GameManager is not assigned.");
        }
    }



}
*/