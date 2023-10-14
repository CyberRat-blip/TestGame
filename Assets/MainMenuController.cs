/*using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void ContinueGame()
    {
        StartCoroutine(LoadGameScene());
    }

    public System.Collections.IEnumerator LoadGameScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("GameScene");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        SaveData saveData = SaveSystem.instance.LoadGame();
        if (saveData != null)
        {
           // GameManager.Instance.ApplySaveData(saveData);
            Time.timeScale = 1;
        }
        else
        {
            Debug.LogError("No saved game data found.");
        }
    }
}
*/