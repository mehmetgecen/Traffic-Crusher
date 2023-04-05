using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRoadBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Car")
        {
            other.GetComponent<Rigidbody>().useGravity = true;
            if (other.tag == "Car")
                Destroy(other.gameObject, 3f);
            if(other.tag == "Player")
                GameEssentials.isGameOver = true;
        }
    }
}
