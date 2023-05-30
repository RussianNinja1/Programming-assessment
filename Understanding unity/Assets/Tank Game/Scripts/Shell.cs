using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public int damage = 20;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 4f);
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "player")
        {
            other.gameObject.GetComponent<TankController>().TakeDamage(damage);
        }
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
