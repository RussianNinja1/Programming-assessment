using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ButtonDisable : MonoBehaviour
{
    public Button myButton;

    private void Start()
    {
     //   myButton = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.B))
        {
            myButton.interactable = false;
        }
        
        //if(Input.GetKey(KeyCode.B) && myButton.interactable == false)
        //{
        //    myButton.interactable = true;
        //}
    }
}
