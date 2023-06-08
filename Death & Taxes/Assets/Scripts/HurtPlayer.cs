using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public int damageToGive;
    public PlayerController playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {
            //playerMovement.kBTime = playerMovement.KBTotalTime; 
            //if(other.transform.position.x <= transform.position.x)
            //{
            //    playerMovement.knockFromRight = true;
            //    Debug.Log("I got knocked from left");
            //}
            //if (other.transform.position.x >= transform.position.x)
            //{
            //    playerMovement.knockFromRight = false;
            //    Debug.Log("I got knocked from right");
            //}
            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive);
        }
    }
}
