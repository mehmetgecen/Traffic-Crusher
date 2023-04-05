using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCar : MonoBehaviour
{
    public bool carPass;

    private void Awake()
    {
        carPass = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Car")
        {
            if(!carPass)
            {
                if (!other.GetComponent<CarBehaviour>().passXPermit)
                    other.GetComponent<CarBehaviour>().movePermit = false;
                other.GetComponent<CarBehaviour>().passXPermit = false;
            }
            else
            {               
                other.GetComponent<CarBehaviour>().movePermit = true;
                other.GetComponent<CarBehaviour>().passXPermit = false;
            }
            
        }
    }
}
