using JetBrains.Annotations;
using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Animator anim;
    private bool m_FacingRight = true; // For determining which way the player is currently facing.

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVec = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (inputVec.magnitude > 1)
        {
            inputVec /= inputVec.magnitude;
        }
        
        //Code for Moving Horizontally
        if (Input.GetAxisRaw("Horizontal") > 0.5f)
        {
            transform.Translate (new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime,0f,0f));
        }

        else if (Input.GetAxisRaw("Horizontal") < -0.5f )
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
        }

        // Code for fliping Sprite based on direction facing.
        if (Input.GetAxisRaw("Horizontal") > 0.5f && !m_FacingRight) 
        {
            Flip();
        }

        else if (Input.GetAxisRaw("Horizontal") < -0.5f && m_FacingRight)
        {
            Flip();
        }

        //Code for Moving Vertically
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {

            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
        }

        ///OLD ATTEMPT
        /*if (Input.GetAxisRaw("Horizontal") > 0.5f && Input.GetAxisRaw("Vertical") > 0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed/2 * Time.deltaTime, 0f, 0f));
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed / 2 * Time.deltaTime, 0f));
        }*/
        /////////////////////////////////////////////////////////////////////////////////////////
        ///CODE FROM INTERNET NEEDS TESTING
        /*
        float movementInputX = Input.GetAxisRaw("Horizontal");
        float movementInputY = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(movementInputX, movementInputY);
        direction.Normalize();
        direction *= moveSpeed * Time.deltaTime;


        if ((movementInputX != 0f && movementInputY != 0f) || (movementInputX != 0f || movementInputY != 0f))
        {
            transform.Translate(new Vector3(direction.x, direction.y, 0f));
            myRigidbody.velocity = direction;
            playerMoving = true;
            lastMove = new Vector2(movementInputX, movementInputY);
        }

        if (movementInputX < 0.5f && movementInputX > -0.5f)
        {
            myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);
        }

        if (movementInputY < 0.5f && movementInputY > -0.5f)
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, 0f);
        }
        */
        /////////////////////////////////////////////////////////////////////////////////////////
        // Allows the move controls to talk to the animator
        anim.SetFloat("Move+", Input.GetAxisRaw("Horizontal"));
       anim.SetFloat("Move-", Input.GetAxisRaw("Vertical"));
    }
    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
