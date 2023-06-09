using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 5f;
    private float currentMoveSpeed;
    public float diagonalMoveModif;
    private Animator anim;
    private Rigidbody2D myRigidBody;
    private bool m_FacingRight = true; // For determining which way the player is currently facing.
    

    [Header("Knockback")]

    [SerializeField] private bool knockedbacked;
    [SerializeField] private float strength = 100;
    [SerializeField] private float delay = 2f;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!knockedbacked)
        {
            PlayerMovement();
        }
    }
    private void Flip() //function for fliping the sprite
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void OnCollisionEnter2D(Collision2D other) //knockback script.
    {
        if(other.gameObject.tag == "Enemy")
        {
            knockedbacked = true;
            Vector2 direction = (transform.position - other.transform.position).normalized;
            Vector2 knockback = (direction * strength);
            myRigidBody.AddForce(knockback, ForceMode2D.Impulse);
            StartCoroutine(Reset());
            //Debug.Log("I Should be getting knocked back now");
        }
    }

    private IEnumerator Reset()  //Enum to reset knockback, and delay timer.
    {
        yield return new WaitForSeconds(delay);
        knockedbacked = false;
        //Debug.Log("The Enum is running");
    }
    private void PlayerMovement()
    {
        // Setting neat variables for X/Y RawAxis
        float movementInputX = Input.GetAxisRaw("Horizontal");
        float movementInputY = Input.GetAxisRaw("Vertical");

        //Code for Moving Horizontally
        if (movementInputX > 0.5f)
        {
            myRigidBody.velocity = new Vector2(movementInputX * currentMoveSpeed, myRigidBody.velocity.y);
        }

        else if (movementInputX < -0.5f)
        {
            myRigidBody.velocity = new Vector2(movementInputX * currentMoveSpeed, myRigidBody.velocity.y);
        }

        // Code for fliping Sprite based on direction facing.
        if (movementInputX > 0.5f && !m_FacingRight)
        {
            Flip();
        }

        else if (movementInputX < -0.5f && m_FacingRight)
        {
            Flip();
        }

        //Code for Moving Vertically
        if (movementInputY > 0.5f || movementInputY < -0.5f)
        {
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, movementInputY * currentMoveSpeed);
        }

        //code to stop skating
        if (movementInputX < 0.5f && movementInputX > -0.5f)
        {
            myRigidBody.velocity = new Vector2(0f, myRigidBody.velocity.y);
        }

        if (movementInputY < 0.5f && movementInputY > -0.5f)
        {
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, 0f);
        }

        //code to adjust diagonal movespeed
        if (Mathf.Abs(movementInputX) > 0.5f && Mathf.Abs(movementInputY) > 0.5f)
        {
            currentMoveSpeed = moveSpeed * diagonalMoveModif;
        }
        else
        {
            currentMoveSpeed = moveSpeed;
        }

        // Allows the move controls to talk to the animator
        anim.SetFloat("Move+", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("Move-", Input.GetAxisRaw("Vertical"));
    }
}
