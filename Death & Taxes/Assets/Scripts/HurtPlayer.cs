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
            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive); // calls the hurt player function on collision, damage is set in inspection thanks to public variable. 
        }
    }
}
