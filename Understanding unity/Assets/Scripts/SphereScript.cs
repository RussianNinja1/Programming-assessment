using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Timeline;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Vector3 teleportPosition = new Vector3(0, 0, 10);
    public float maxFallHeight = -20;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < maxFallHeight)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(10, 0, 0));
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Renderer>().material.color = Color.red;

        }
        /*if (transform.position.y < -70)
        {
            Debug.Log("the abyss feels... so good.");
        }
        else if(transform.position.y <-40)
        {
            Debug.Log("Father.... HELP ME!!");
        }
        else if (transform.position.y < -10)
        {
            Debug.Log("I'm too far away!");
        }
        if (transform.position.y > -30)
        {
            Debug.Log("Weeeee");
        }
        else
        {
            Debug.Log("Arhhhhh!");
        }
            */
        /* if (transform.position.y < -20)
        {
            transform.position = new Vector3(0, 0, 0);
            transform.localScale = transform.localScale * 2;

        }
        */
        /*if (Input.GetKeyDown ("q"))
        {
            transform.position = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown ("s"))
        {
            transform.localScale = transform.localScale * 2;
        }*/


    }
}
