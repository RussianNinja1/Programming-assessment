using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIController : MonoBehaviour
{
    public TMP_Text messageText;
    public GameObject messagePanel;
    private float displayTimer;
    private float displayLength;
    private bool isShowingMessage = false;
    // Start is called before the first frame update
   public void ShowMessage(string message,float duration = 3)
    {
        messagePanel.SetActive(true);
        messageText.text = message;
        isShowingMessage = true;

        displayLength = duration;
        displayTimer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
     if(isShowingMessage)
        {
            if(Time.time - displayTimer > displayLength)
            {
                messagePanel.SetActive(false);
                isShowingMessage = false;
            }
        }
    }
}
