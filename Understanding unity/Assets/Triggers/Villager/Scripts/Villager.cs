using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager : MonoBehaviour {

    public Renderer face;
    public Texture2D happy;
    public Texture2D sad;
    public Texture2D angry;
    public Texture2D awkward;
    public ParticleSystem particles1;
    public ParticleSystem particles2;

    private List<Rigidbody> childRbs = new List<Rigidbody>();
    private List<Collider> childCols = new List<Collider>();

    private bool blastingOff;
    private bool blasted;

    private void Start()
    {
        // Pre-load in all the rigidbodies and colliders from the child gameobjects
        foreach (Transform t in this.transform)
        {
            if (t.name != "FX")
            {
                // if NOT the FX transform, do the thing
                childRbs.Add(t.GetComponent<Rigidbody>());
                childCols.Add(t.GetComponent<Collider>());
            }
        }
    }

    private void Update()
    {
        if (blastingOff)
        {
            this.GetComponent<Rigidbody>().AddForce(transform.up * 20, ForceMode.Acceleration);
        }
    }


    // Public voids to access from inspector

    public void MakeHappy()
    {
        face.material.mainTexture = happy;
    }
    public void MakeSad()
    {
        face.material.mainTexture = sad;
    }
    public void MakeAwkward()
    {
        face.material.mainTexture = awkward;
    }
    public void MakeAngry()
    {
        face.material.mainTexture = angry;
    }

    public void Collapse()
    {
        SeparateRBs();
        ExplodeRBs(0);
    }

    public void Boom()
    {
        SeparateRBs();
        ExplodeRBs(300);
    }

    public void BigBoom()
    {
        SeparateRBs();
        ExplodeRBs(1000);
    }

    public void BlastOff()
    {
        if (blasted == false) // if BlastOff() has not been called before...
        {
            blastingOff = true; // set to True to run the bit of code in Update
            particles1.Play();
            Invoke("Fireworks", 4f);
            blasted = true;
        }
    }



    // Private Voids to help public voids do their things

    private void SeparateRBs()
    {
        // Turn off the parent collider and RB so it doesnt affct the child objects
        gameObject.GetComponent<Collider>().enabled = false;
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        
        foreach (Collider col in childCols)
        {
            col.enabled = true;
            //col.transform.SetParent(null);
        }
    }

    private void ExplodeRBs(float explosionForce)
    {
        foreach (Rigidbody rb in childRbs)
        {
            rb.isKinematic = false;
            rb.AddExplosionForce(explosionForce, this.transform.position, Random.Range(1, 10));
        }
    }

    private void Fireworks()
    {
        particles1.Stop();
        particles2.Play();
        Boom();
    }

}
