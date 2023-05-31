using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{

    public GameObject teleNode;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Vector3 nodeLocation = teleNode.transform.position;
            other.transform.position = nodeLocation;
            Quaternion nodeRotation = teleNode.transform.rotation;
            other.transform.rotation = nodeRotation;

            Debug.Log("I have collided");
        }
    }
    private void OnDrawGizmos()
    {
        if (teleNode)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, teleNode.transform.position);
        }
    }

}
