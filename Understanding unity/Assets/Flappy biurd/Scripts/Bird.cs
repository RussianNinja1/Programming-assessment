using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    public float flapHeight = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;

            GetComponent<Rigidbody2D>().AddForce(Vector2.up * flapHeight, ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D()
    {
        SceneManager.LoadScene(0);
    }
}
