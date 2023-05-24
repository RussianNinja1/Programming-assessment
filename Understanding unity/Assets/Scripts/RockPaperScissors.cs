using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RockPaperScissors : MonoBehaviour
{

    // Variable Declaration
    private int playerLives;
    private int enemyLives;
    private int randomNumber;

    public TMP_Text gameOutputText;
    public TMP_Text playerLifeCounter;
    public TMP_Text enemyLifeCounter;

    public Button rockButton;
    public Button paperButton;
    public Button scissorsButton;

    private bool GameRestarting;

    // Start is called before the first frame update
    void Start()
    {
        SetUpGame();
    }
    private void SetUpGame()
    {
        playerLives = 3;
        enemyLives = 3;
        
        //change text of the textbox
        gameOutputText.text = "Make A choice human! Rock, Paper, or Scissors?!";

        playerLifeCounter.text = playerLives.ToString();
        enemyLifeCounter.text = enemyLives.ToString();

    }
    public void ClickButton(int buttonClicked)
    {
        if(buttonClicked == 1)
        {
            gameOutputText.text = "you chose Rock";
        }
        else if (buttonClicked == 2)
        {
            gameOutputText.text = "you chose Paper";
        }
        else if (buttonClicked == 3)
        {
            gameOutputText.text = "you chose Scissors";
        }
    }
}
