using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour

{
    public TMP_Text moneyText;
    public int currentGold; 

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("CurrentMoney", 0);  // bootleg way to reset remembered gold value Need to delete when finished (delete this probably)

        if (PlayerPrefs.HasKey("CurrentMoney"))
        {
            currentGold = PlayerPrefs.GetInt("CurrentMoney");
        }
        else
        {
            currentGold = 0;
            PlayerPrefs.SetInt("CurrentMoney", 0);
        }
        moneyText.text = ": " + currentGold;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddMoney(int goldToAdd)
    {
        currentGold += goldToAdd;
        PlayerPrefs.SetInt("CurrentMoney", currentGold);
        moneyText.text = ":" + currentGold;


    }
    public void GiveMoney(int goldToGive)
    {

        if (currentGold >= 1)
        {
            currentGold -= goldToGive;
            PlayerPrefs.SetInt("CurrentMoney", currentGold);
            moneyText.text = ":" + currentGold;
        }
           
         
    }
}
