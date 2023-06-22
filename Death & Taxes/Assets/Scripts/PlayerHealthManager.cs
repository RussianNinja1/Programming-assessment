using System.Collections;
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
    public ShiftTimer1 sTime;
    public int timeDamageValue;

 

    // Start is called before the first frame update
    void Start()
    {
        playerCurrentHealth = playerMaxHealth;  //sets current health to max health (aka full health on start)
        spriteRend = GetComponent<SpriteRenderer>();
        sTime = FindObjectOfType<ShiftTimer1>();

    }

    // Update is called once per frame
    void Update()
    {
        if(playerCurrentHealth <=0) // if player health is less then or = to 0 deactivate the player object
        {
            spriteRend.enabled = false;
            sTime.TimeDamage(timeDamageValue);
            gameObject.transform.position = new Vector3(0, 0, 0);
            SetMaxHealth(); 
            spriteRend.enabled = true;
            

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
            yield return new WaitForSeconds(iFrameDuration/(NumOfFlashes * 2));  // duration is divided by number of flashes to calculate duration of each flash, howwever due to us having 2 color changes/ 2 delay we need the number of flashed to be twice as small so multiply by 2 in brackets
            spriteRend.color = Color.white;
            yield return new WaitForSeconds(iFrameDuration / (NumOfFlashes * 2));
        }
        Physics2D.IgnoreLayerCollision(6, 7, false); // returns collisions to normal
    }
}
