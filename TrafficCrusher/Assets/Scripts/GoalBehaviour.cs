using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehaviour : MonoBehaviour
{
    private GameObject GM;

    private void Start()
    {
        GM = GameObject.FindGameObjectWithTag("GameManager");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
           // GM.GetComponent<GameManager>().LerpNextLevel();
            GM.GetComponent<TimeScript>().CalculateScore();
            GM.GetComponent<TimeScript>().timeValue+=10;
            other.GetComponent<CarBehaviour>().speed += .3f;                
        }
    }
}
