using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionUpDown : MonoBehaviour
{
    public float speed;
  
    public void Update()
    {
        float y = Mathf.PingPong(Time.time * speed, 2);
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
    
}
