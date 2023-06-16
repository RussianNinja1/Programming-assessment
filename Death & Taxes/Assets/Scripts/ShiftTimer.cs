using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using JetBrains.Annotations;
using Newtonsoft.Json.Bson;

public class ShiftTimer : MonoBehaviour
{
    //public string nextScene; //the next scene i want to load.
    float currentTime = 0f; 
    public float startingTime = 10f;
    [SerializeField] TMP_Text timerText; //addresses the text component in the the timer
    private DialogueManager dMan;
    public bool timeActive;

    // Start is called before the first frame update
    void Start()
    {
        timeActive = false;
        currentTime = startingTime; //set current time to starting time ( amount of time to complete level).
        dMan = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timeActive)
        {
            if (!dMan.DialogActive && timeActive ==true)
            {
                currentTime -= 1 * Time.deltaTime; // decreases time by 1 each second
                timerText.text = currentTime.ToString("0"); //writes time to Timer text
            }
        } 

        if (currentTime <=0)  // loads next scene
        {
            currentTime = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
       
    }
    public void TimeDamage(int timeDamageValue)
    {
        currentTime -= timeDamageValue;
    }
     


}
