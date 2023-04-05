using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossroadBehaviour : MonoBehaviour
{
    public GameObject[] triggers;
    public GameObject[] lights; // 0 -> 02, 1 ->13
    [HideInInspector] public int currentTrigger = 0;

    private void Start()
    {
        UpdateTriggers();
        UpdateLights();
    }

    public void getNextTrigger()
    {
        currentTrigger = (currentTrigger + 1) % triggers.Length;
        UpdateTriggers();
        UpdateLights();
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Player")
        {
            other.transform.Rotate(new Vector3(0, GameEssentials.PLAYER_NEXT_ROTATION, 0));
            other.transform.GetComponent<CarBehaviour>().passXPermit = true;
        }
    }

    private void UpdateTriggers() // regulates triggers
    {
        foreach (GameObject g in triggers)
        {
            //g.SetActive(true);
            g.GetComponent<StopCar>().carPass = false;
        }
            
        //triggers[currentTrigger].SetActive(false); 
        //triggers[(currentTrigger+2)% triggers.Length].SetActive(false);
        triggers[currentTrigger].GetComponent<StopCar>().carPass = true;
        triggers[(currentTrigger + 2) % triggers.Length].GetComponent<StopCar>().carPass = true;
        triggers[currentTrigger].SetActive(false); triggers[currentTrigger].SetActive(true);
        triggers[(currentTrigger+2)% triggers.Length].SetActive(false); triggers[(currentTrigger + 2) % triggers.Length].SetActive(true);
    }

    private void UpdateLights()
    {
        if (currentTrigger % 2 == 0)
        {
            lights[1].SetActive(true);
            lights[0].SetActive(false);
        }
        else if (currentTrigger % 2 == 1)
        {
            lights[1].SetActive(false);
            lights[0].SetActive(true);
        }
    }
}
