using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enumEx : MonoBehaviour
{
    IEnumerator WaitAndPrint()
    {
        // suspend execution for 5 seconds
        yield return new WaitForSeconds(5);
        print("Done");
    }

    IEnumerator DoorStageTwo()
    {
        yield return new WaitForSeconds(2);
    }

    IEnumerator Start()
    {
        
        yield return StartCoroutine("WaitAndPrint");

        BoolHub.doorAnimationIsDone = true;

        yield return StartCoroutine("DoorStageTwo");

        BoolHub.textIsUp = true;
    }

   
}
