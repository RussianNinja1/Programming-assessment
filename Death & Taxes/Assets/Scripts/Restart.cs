using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public string mainMenu;
    public string restart;

    public void RestartGame()
    {
        PlayerPrefs.SetInt("CurrentMoney", 0);
        SceneManager.LoadScene(restart);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }

}

   