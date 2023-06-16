using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Newtonsoft.Json.Bson;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueBox;
    public TMP_Text dialogueText;

    public bool DialogActive;

    public string[] dialogueLines;
    public int currentLine;

    private PlayerController ThePlayer;
    // Start is called before the first frame update
    void Start()
    {
        ThePlayer = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogActive && Input.GetKeyDown(KeyCode.Space))
        {
            //dialogueBox.SetActive(false);
            //DialogActive = false;
            currentLine++;
        }
        if (currentLine >= dialogueLines.Length)
        {
            dialogueBox.SetActive(false);
            DialogActive = false;

            currentLine = 0;
            ThePlayer.canMove = true;
        }
        dialogueText.text = dialogueLines[currentLine];

    }
    public void ShowBox(string dialogue)
    {
        DialogActive = true;
        dialogueBox.SetActive(true);
        dialogueText.text = dialogue;
    }

    public void ShowDialogue()
    {
        DialogActive = true;
        dialogueBox.SetActive(true);
        ThePlayer.canMove = false;

    }
}
