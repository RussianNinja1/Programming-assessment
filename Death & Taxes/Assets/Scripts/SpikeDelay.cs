using System.Collections;
using UnityEngine;

public class SpikeDelay : MonoBehaviour
{
    public float startDelay; // Amount of seconds to wait before playing animation:
    [SerializeField] private float animRunTime; // Amount of time to play animation: 10 Frames, one per second.
    private Animator anim;

    private bool triggered;
    
    void Start()
    {
       anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(!triggered)
        {
            StartCoroutine(ActivateSpikes());

        }
    }
    private IEnumerator ActivateSpikes()
    {
        triggered = true;
        yield return new WaitForSeconds(startDelay);
        anim.SetBool("activated", true);
        yield return new WaitForSeconds(animRunTime);
        triggered = false;
        anim.SetBool("activated", false);
    }

}
