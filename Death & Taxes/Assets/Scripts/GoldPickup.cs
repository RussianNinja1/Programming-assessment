using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GoldPickup : MonoBehaviour
{
    public int value;
    public MoneyManager theMM;
    public AudioSource coinSound;
    public float waitTime;
    SpriteRenderer spriteRend;
    Collider2D colid;

    // Start is called before the first frame update
    void Start()
    {
        theMM = FindObjectOfType<MoneyManager>();
        spriteRend = GetComponent<SpriteRenderer>();
        colid = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            StartCoroutine(CoinSounds());
            theMM.AddMoney(value);
        }
    }
    private IEnumerator CoinSounds()
    {
        coinSound.Play();
        colid.enabled = false;
        spriteRend.enabled = false;
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
    }
    
}
