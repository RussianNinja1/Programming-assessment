using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position - (Vector3.right * speed * Time.deltaTime);

        if (transform.position.x <= -3.84f)
        {
            transform.position = transform.position + (Vector3.right * 3.84f * 2);
        }
    }
}
