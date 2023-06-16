using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    [Header("Health")]
    public int playerMaxHealth; //total max health
    public int playerCurrentHealth; //current health 

    [Header("I-frames")]
    [SerializeField] private float iFrameDuration; //duration of iframes in seconds.
    [SerializeField] private int NumOfFlashes; // number of flashes
    private SpriteRenderer spriteRend;

    [Header("Time Penelty On Death")]
    public ShiftTimer sTime;
    public int timeDamageValue;
    //private ShiftTimer timeDamage;

 

    // Start is called before the first frame update
    void Start()
    {
        playerCurrentHealth = playerMaxHealth;  //sets current health to max health (aka full health on start)
        spriteRend = GetComponent<SpriteRenderer>();
        sTime = FindObjectOfType<ShiftTimer>();

    }

    // Update is called once per frame
    void Update()
    {
        if(playerCurrentHealth <=0) // if player health is less then or = to 0 deactivate the player object
        {
            spriteRend.enabled = false;
            Debug.Log("i am now set active false");
            sTime.TimeDamage(timeDamageValue);
            Debug.Log("i should have done damage  to time");
            gameObject.transform.position = new Vector3(0, 0, 0);
            Debug.Log("i should have moved to start");
            SetMaxHealth(); 
            Debug.Log("i should have set health to make");
            spriteRend.enabled = true;
            Debug.Log("i should have set active to true");

        }
    }
    public void HurtPlayer(int damageToGive)  //public funtions to that gets called on other script, with arguments that you can set to do different damage if needed
    {
        playerCurrentHealth -= damageToGive;
        StartCoroutine(Invulnerability());

    }
    public void SetMaxHealth()  // public function to call if player ever incounter a healing item, or we need to reset health to full for any reason.
    {
        playerCurrentHealth = playerMaxHealth;
    }

    private IEnumerator Invulnerability()  // Function for to run containing the code for iframe, because we wait between lines of code we need to use an IEnum and Coroutines
    {
        Physics2D.IgnoreLayerCollision(6, 7, true); //player sprite is on 6 enemies are on 7, this will let us ignore collisions when the script runs
        for (int i = 0; i < NumOfFlashes; i++)
        {
            spriteRend.color = new Color(1, 0, 0, 0.5f);  //sets player color to red and opacity to 0.5.
            yield return new WaitForSeconds(iFrameDuration/(NumOfFlashes * 2)); 
            spriteRend.color = Color.white;
            yield return new WaitForSeconds(iFrameDuration / (NumOfFlashes * 2));
        }
        Physics2D.IgnoreLayerCollision(6, 7, false); // returns collisions to normal
    }
}
