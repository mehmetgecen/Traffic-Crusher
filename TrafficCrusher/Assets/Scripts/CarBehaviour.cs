using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBehaviour : MonoBehaviour
{
    public float speed = 5f;
    [HideInInspector] public bool movePermit;
     public bool passXPermit;

    private void Start()
    {
        movePermit = true;
        passXPermit = false;
        if (tag == "Player")
            GameEssentials.PLAYER_NEXT_ROTATION = 0;
    }
    void Update()
    {        

        if(movePermit)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if(passXPermit && !movePermit)
        {
            movePermit = true;
        }
        /*
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            GameEssentials.PLAYER_NEXT_ROTATION = 90f;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GameEssentials.PLAYER_NEXT_ROTATION = 0f;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GameEssentials.PLAYER_NEXT_ROTATION = -90f;
        }*/
    }


    public void TurnLeft()
    {
        GameEssentials.PLAYER_NEXT_ROTATION = -90f;
        
    }

    public void TurnRight()
    {
        GameEssentials.PLAYER_NEXT_ROTATION = 90f;
        
    }

    public void goAhead()
    {
        GameEssentials.PLAYER_NEXT_ROTATION = 0f;
       
    }
}
