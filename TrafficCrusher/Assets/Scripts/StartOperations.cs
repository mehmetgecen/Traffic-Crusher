using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartOperations : MonoBehaviour
{
    public GameObject startButtons;
    public GameObject downButtons;
    public void StartMethod()
    {
        GameEssentials.isGameBeingPlayed = true;
        GameEssentials.isGameOver = false;
        LeanTween.move(startButtons, startButtons.GetComponent<StartButtonsScript>().downPos, .2f);
        LeanTween.move(downButtons, -downButtons.GetComponent<DownButtonsScript>().downPos, .2f);
    }
}
