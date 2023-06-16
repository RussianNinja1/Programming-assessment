using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialogueHolder1 : MonoBehaviour
{
    public string dialogue;
    private DialogueManager dMan;
    public string[] dialogueLines;
    private BoxCollider2D colid;
    private ShiftTimer sTime;
    // Start is called before the first frame update
    void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();
        colid = GetComponent<BoxCollider2D>();
        sTime = FindObjectOfType<ShiftTimer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            //dMan.ShowBox(dialogue);
            if (!dMan.DialogActive)
            {
                sTime.timeActive = true;
                dMan.dialogueLines = dialogueLines;
                dMan.currentLine = 0;
                dMan.ShowDialogue();
                colid.enabled = !colid.enabled;
                
            }

        }
    }
}
