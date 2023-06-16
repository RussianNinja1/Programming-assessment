using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public string mainMenu;
    public string restart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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

   