using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(TriggerDisplay))]
public class TriggerTeleportObject : MonoBehaviour
{
    public GameObject objectToTeleport;
    public Transform transformToTeleportObjectTo;
    public float teleportDelay = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            Invoke("TeleportObject", teleportDelay);
    }

    private void TeleportObject()
    {
        if (!transformToTeleportObjectTo || objectToTeleport) ;
        {
            Debug.LogWarning("You have not assigned a reference for this teleport script");
        }
        objectToTeleport.transform.position = transformToTeleportObjectTo.position;
        objectToTeleport.transform.position = transformToTeleportObjectTo.position;
    }

    private void OnDrawGizmosSelected()
    {
        Debug.DrawLine(transformToTeleportObjectTo.position, objectToTeleport.transform.position);
    }

}
