using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public GameObject wizard;

    public TextMeshProUGUI _wizardText;
    public Animator anim;
    public Animation door;

    public GameObject buttons;

    public Button button1;
    public Button button2;
    public Button button3;

    public GameObject button1GO;
    public GameObject button2GO;
    public GameObject button3GO;

    public TextMeshProUGUI button1TXT;
    public TextMeshProUGUI button2TXT;
    public TextMeshProUGUI button3TXT;

    public string[] wizardDialogue;

    int currentWizText;

    // Start is called before the first frame update
    void Start()
    {
        _wizardText = GetComponent<TextMeshProUGUI>();
        _wizardText.enabled = false;
        buttons.SetActive(false);

        currentWizText = 0;
    }
    // Update is called once per frame
    void Update()
    {
        DoorAnimationDone();
        _wizardText.text = wizardDialogue[currentWizText];

       
        WizardBranches();
    }

    void DoorAnimationDone()
    {
        _wizardText.enabled = BoolHub.doorAnimationIsDone;
        buttons.SetActive(BoolHub.textIsUp);
    }

    public void Button1Clicked()
    {
        Debug.Log("1 Clicked");
        BoolHub.button1IsClicked = true;
    }

    public void Button2Clicked()
    {
        Debug.Log("2 Clicked");
        BoolHub.button2IsClicked = true;
    }

    public void Button3Clicked()
    {
        Debug.Log("3 Clicked");
        BoolHub.button3IsClicked = true;
    }

    void WizardBranches()
    {
        Woah();
        GameOver();
        LiveWithMe();
        ImGumbledore();
        FindIfWorthy();
    }

    void DialogueExampleCode()
    {
        if (currentWizText == 0)
        {
            button1GO.SetActive(true);
            button2GO.SetActive(true);
            button3GO.SetActive(true);

            button1TXT.text = "";
            button2TXT.text = "";
            button3TXT.text = "";

            if (BoolHub.button1IsClicked)
            {
                //currentWizText = ;
                //BoolHub.button1IsClicked = false;
            }
            if (BoolHub.button2IsClicked)
            {
                //currentWizText = ;
                //BoolHub.button2IsClicked = false;
            }
            if (BoolHub.button3IsClicked)
            {
                //currentWizText = ;
                //BoolHub.button3IsClicked = false;
            }

        }
    }

    void Woah()
    {
        if (currentWizText == 0)
        {
            button1GO.SetActive(true);
            button2GO.SetActive(true);
            button3GO.SetActive(false);

            button1TXT.text = "Woah!";
            button2TXT.text = "Hey, Fuck off";
            button3TXT.text = "";

            if (BoolHub.button1IsClicked)
            {
                currentWizText = 1;
                BoolHub.button1IsClicked = false;
            }
            if (BoolHub.button2IsClicked)
            {
                currentWizText = 2;
                BoolHub.button2IsClicked = false;
            }
            if (BoolHub.button3IsClicked)
            {
                //currentWizText = ;
                //BoolHub.button3IsClicked = false;
            }

        }
    }

    void GameOver()
    {
        if (currentWizText == 2)
        {
            button1GO.SetActive(false);
            button2GO.SetActive(false);
            button3GO.SetActive(false);

            button1TXT.text = "";
            button2TXT.text = "";
            button3TXT.text = "";

            if (BoolHub.button1IsClicked)
            {
                currentWizText = 1;
                BoolHub.button1IsClicked = false;
            }
            if (BoolHub.button2IsClicked)
            {
                currentWizText = 2;
                BoolHub.button2IsClicked = false;
            }
            if (BoolHub.button3IsClicked)
            {
                //currentWizText = ;
                //BoolHub.button3IsClicked = false;
            }
            anim.SetBool("youlose", true);
            
        }
    }

    void LiveWithMe()
    {
        if (currentWizText == 1)
        {
            button1GO.SetActive(true);
            button2GO.SetActive(true);
            button3GO.SetActive(true);

            button1TXT.text = "What? I don't even KNOW you.";
            button2TXT.text = "Absolutely";
            button3TXT.text = "*Pretend not to hear the wizard*";

            if (BoolHub.button1IsClicked)
            {
                currentWizText = 3;
                BoolHub.button1IsClicked = false;
            }
            if (BoolHub.button2IsClicked)
            {
                currentWizText = 4;
                BoolHub.button2IsClicked = false;
            }
            if (BoolHub.button3IsClicked)
            {
                currentWizText = 5;
                BoolHub.button3IsClicked = false;
            }

        }
    }

    void ImGumbledore()
    {
        if (currentWizText == 3)
        {
            button1GO.SetActive(true);
            button2GO.SetActive(true);
            button3GO.SetActive(false);

            button1TXT.text = "Still don't know you";
            button2TXT.text = "Okay, let's live together platonically";
            button3TXT.text = "";

            if (BoolHub.button1IsClicked)
            {
                //currentWizText = ;
                //BoolHub.button1IsClicked = false;
            }
            if (BoolHub.button2IsClicked)
            {
                currentWizText = 4
;
                BoolHub.button2IsClicked = false;
            }
            if (BoolHub.button3IsClicked)
            {
                //currentWizText = ;
                //BoolHub.button3IsClicked = false;
            }

        }
    }

    void FindIfWorthy()
    {
        if (currentWizText == 4)
        {
            button1GO.SetActive(true);
            button2GO.SetActive(true);
            button3GO.SetActive(false);

            button1TXT.text = "How do I prove my worth?";
            button2TXT.text = "*Dance*";
            button3TXT.text = "";

            if (BoolHub.button1IsClicked)
            {
                //currentWizText = ;
                //BoolHub.button1IsClicked = false;
            }
            if (BoolHub.button2IsClicked)
            {
                //currentWizText = ;
                //BoolHub.button2IsClicked = false;
            }
            if (BoolHub.button3IsClicked)
            {
                //currentWizText = ;
                //BoolHub.button3IsClicked = false;
            }

        }
    }
}
