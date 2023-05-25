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
        if (buttonClicked == 1)
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

        randomNumber = Random.Range(1, 4);
        DoBattle(buttonClicked, randomNumber);
    }

    private void DoBattle (int playerChoice, int enemyChoice)
    {
        if (playerChoice == enemyChoice)
        {
            gameOutputText.text += "\n Its draw";
        }
        else if (playerChoice == 2 && enemyChoice == 1)
        {
            gameOutputText.text += "\n the enemy chose rock and you won";
            enemyLives--;
        }
        else if (playerChoice == 3 && enemyChoice == 1)
        {
            gameOutputText.text += "\n the enemy chose rock and you lost";
            playerLives--;
        }

        else if (playerChoice == 3 && enemyChoice == 2)
        {
            gameOutputText.text += "\n the enemy chose paper and you won";
            enemyLives--;
        }
        else if (playerChoice == 1 && enemyChoice == 2)
        {
            gameOutputText.text += "\n the enemy chose paper and you lost";
            playerLives--;
        }
        else if (playerChoice == 1 && enemyChoice == 3)
        {
            gameOutputText.text += "\n the enemy chose Scissors and you won";
            enemyLives--;
        }
        else if (playerChoice == 2 && enemyChoice == 3)
        {
            gameOutputText.text += "\n the enemy chose Scissors and you lost";
            playerLives--;
        }
        playerLifeCounter.text = playerLives.ToString();
        enemyLifeCounter.text = enemyLives.ToString();
        
        if (playerLives == 0)
        {
            gameOutputText.text += "\nThou hast losteth the match!";
        }
        if (enemyLives == 0)
        {
            gameOutputText.text += "\nThou hast Won the match!";
        }
    }
}