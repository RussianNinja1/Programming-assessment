using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ShiftTimer : MonoBehaviour
{
    //public string nextScene; //the next scene i want to load.
    float currentTime = 0f; 
    public float startingTime = 10f;
    [SerializeField] TMP_Text timerText; //addresses the text component in the the timer
    
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime; //set current time to starting time ( amount of time to complete level).
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime; // decreases time by 1 each second
        timerText.text = currentTime.ToString("0"); //writes time to Timer text

        if (currentTime <=0)  // loads next scene
        {
            currentTime = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
       
    }
}
