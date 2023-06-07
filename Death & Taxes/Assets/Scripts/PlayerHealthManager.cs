using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public int playerMaxHealth; //total max health
    public int playerCurrentHealth; //current health 

    // Start is called before the first frame update
    void Start()
    {
        playerCurrentHealth = playerMaxHealth;  //sets current health to max health (aka full health on start)
    }

    // Update is called once per frame
    void Update()
    {
        if(playerCurrentHealth <=0) // if player health is less then or = to 0 deactivate the player object
        {
            gameObject.SetActive(false);
        }
    }
    public void HurtPlayer(int damageToGive)  //public funtions to that gets called on other script, with arguments that you can set to do different damage if needed
    {
        playerCurrentHealth -= damageToGive;
    }
    public void SetMaxHealth()  // public function to call if player ever incounter a healing item, or we need to reset health to full for any reason.
    {
        playerCurrentHealth = playerMaxHealth;
    }
}
