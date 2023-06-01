using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TriggerDisplay))]
public class TriggerMessage : MonoBehaviour
{
    public string messageToShow = "Default Message";
    public float messageDuration = 3;





    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            GameObject.FindObjectOfType<UIController>().ShowMessage(messageToShow, messageDuration);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
