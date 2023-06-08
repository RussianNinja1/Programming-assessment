using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KnockbackScript : MonoBehaviour
{
    //[SerializeField] private Rigidbody2D rB;
    //[SerializeField] private float strength = 16, delay = 0.15f;
    //public UnityEvent Onbegin, OnDone;

    public PlayerController playerMovement;
    void OnCollisionEnter2D(Collision2D other)
    {
        //if (other.gameObject.tag == "Player")
        {
       //     other.gameObject.GetComponent<PlayerController>().KnockBack();
        }
           
    }
    //private IEnumerator Reset()
    //{
    //    yield return new WaitForSeconds(delay);
    //    rB.velocity = Vector3.zero;
    //}

   /* public void KnockBack(GameObject other)
    {
        StopAllCoroutines();
        Onbegin?.Invoke();
        Vector2 direction = (transform.position - other.transform.position).normalized;
        rB.AddForce(direction * strength, ForceMode2D.Impulse);
        StartCoroutine(Reset());
    }

    private IEnumerator Reset()
    {
        yield return new WaitForSeconds(delay);
        rB.velocity = Vector3.zero;
        OnDone?.Invoke();
    }

    */

}
