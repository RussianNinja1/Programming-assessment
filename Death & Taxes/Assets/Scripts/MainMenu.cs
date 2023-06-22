using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string Day0;

    public void StartGame()
    {
        SceneManager.LoadScene(Day0);
        PlayerPrefs.SetInt("CurrentMoney", 0);
    }

    public void OpenOptions()
    {

    }
    public void CloseOptions()
    {

    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }


}
