using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundeffect : MonoBehaviour
{
    public AudioSource spikes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpikeSound()
    {
        spikes.Play();
    }
}
