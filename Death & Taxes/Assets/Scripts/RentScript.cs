using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class RentScript : MonoBehaviour
{

    public int value;
    public MoneyManager theMM;
    public TMP_Text effectText;
    public int currentDue = 0;
    public int totalDue = 100;
    public Button nextDayBotton;
    public string gameOver;

    // Start is called before the first frame update
    void Start()
    {
        theMM = FindObjectOfType<MoneyManager>();
        currentDue = 0;
        effectText.text = "Rent Due:" + currentDue + " / " + totalDue;
        
    }

    // Update is called once per frame
    void Update()
    {
      if(currentDue != totalDue)
        {
            nextDayBotton.interactable = false;

        }
        else
        {
            nextDayBotton.interactable = true;
        }
    }
    public void PlusGold()
    {
        if(currentDue < totalDue && theMM.currentGold > 0)
        {
            currentDue += 1;
            effectText.text = "Rent Due:" + currentDue + " / " + totalDue;
            theMM.GiveMoney(value);
        }
       
    }
    public void MinusGold()
    {
        if(currentDue >= 1)
        {
            currentDue -= 1;
            effectText.text = "Rent Due:" + currentDue + " / " + totalDue;
            theMM.AddMoney(value);
        }
       
    }
    public void NextDay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void surrender()
    {
        SceneManager.LoadScene(gameOver);
    }
}
