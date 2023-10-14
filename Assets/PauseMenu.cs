using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void ReturnButtonClicked()
    {
        SceneManager.LoadScene("GameScene"); // Загрузить сцену игры
        Time.timeScale = 1; 
    }
    public void MenuButtonClicked()
    {
        SceneManager.LoadScene("Main-Menu-Example"); // Загрузить сцену игры
        Time.timeScale = 1;
    }



    public void ExitButtonClicked()
    {
        Application.Quit(); // Закрыть приложение
    }
}