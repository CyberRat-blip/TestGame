using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenu;

    private bool isPaused = false;



    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0; // Останавливаем игру
            pauseMenu.SetActive(true); // Активируем меню паузы
        }
        else
        {
            Time.timeScale = 1; // Возобновляем игру
            pauseMenu.SetActive(false); // Деактивируем меню паузы
        }
    }
}
