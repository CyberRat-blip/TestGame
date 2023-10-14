using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayButtonClicked()
    {
        SceneManager.LoadScene("GameScene"); // Загрузить сцену игры
        Time.timeScale = 1;
    }

    public void ContinueButtonClicked()
    {
        // Реализуйте сохранение и загрузку прогресса, если нужно
    }

    public void SettingsButtonClicked()
    {
        SceneManager.LoadScene("SettingsScene"); // Загрузить сцену настроек
    }

    public void ExitButtonClicked()
    {
        Application.Quit(); // Закрыть приложение
    }
}