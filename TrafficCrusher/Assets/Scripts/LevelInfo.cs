using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInfo : MonoBehaviour
{
    public GameObject[] policeCars;
    public GameObject connectionPointStart;
    public GameObject connectionPointEnd;

    private void Start()
    {
        //DeActivatePolice();
    }

    public void ActivatePolice()
    {
        foreach (GameObject police in policeCars)
            police.GetComponent<CarBehaviour>().movePermit = true;
    }
    public void DeActivatePolice()
    {
        foreach (GameObject police in policeCars)
            police.GetComponent<CarBehaviour>().movePermit = false;
    }
}
