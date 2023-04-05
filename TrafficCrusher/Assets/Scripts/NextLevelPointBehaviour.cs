using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelPointBehaviour : MonoBehaviour
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
            GM.GetComponent<GameManager>().GetNextLevel();
        }
    }
}
