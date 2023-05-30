using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCube : MonoBehaviour
{

    void OnTriggerEnter()
    {
        Debug.Log("happy to see you");
    }

    void OnTriggerExit()
    {
        Debug.Log("Sorry to see you go");
    }

     void OnTriggerStay()
    {
        Debug.Log("I wish you would leave");
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
