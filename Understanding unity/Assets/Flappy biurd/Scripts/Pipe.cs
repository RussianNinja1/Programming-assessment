using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pipe : MonoBehaviour
{
    public float speed = 1.5f;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position - (Vector3.right * speed * Time.deltaTime);

        if (transform.position.x <= -2.3f)
        {
            transform.position = transform.position + (new Vector3(2.3f * 2, 0, 0));
            transform.position = new Vector3(transform.position.x, Random.Range(-2.5f, -1),
            0);

            if (GameObject.Find("Text (TMP)"))
            {
                GameObject.Find("Text (TMP)").GetComponent<TMP_Text>().text = (++score).ToString();
            }
        }
    }
}
