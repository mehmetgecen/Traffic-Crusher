using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLights : MonoBehaviour
{

    public GameObject parentCrossroad;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100.0f) && hit.transform.gameObject != null)
            {
                if (hit.transform.tag == "ClickObject")
                {
                    parentCrossroad.GetComponent<CrossroadBehaviour>().getNextTrigger();
                }

            }
        }
    }
}
