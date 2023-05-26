using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class MoveMe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, 0, 0.1f);
        }*/
        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0, 0, -0.1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position = transform.position + new Vector3(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.position = transform.position + new Vector3(0, 0.1f, 0);
        }
        /////////////
        if (Input.GetKeyDown(KeyCode.H))
        {
            transform.position = transform.position + (transform.forward * 0.1f); /* move you forward on the z axis*/
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            transform.Rotate(new Vector3(0, 1, 0));/* rotate you on the y axis*/
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.localScale = transform.localScale + (Vector3.one * 0.1f);/* scale shape by 0.1 every frame*/
        }
        if (Input.GetKey(KeyCode.L))
        {
            gameObject.SetActive(false);/*turn off object*/
        }
    }
}