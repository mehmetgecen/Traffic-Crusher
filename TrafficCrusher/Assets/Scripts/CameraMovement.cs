using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed = 1f;
    public GameObject followObj;
    Vector3 offset;

    private void Start()
    {
        offset = transform.position - followObj.transform.position;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        else if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        else if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        else if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.down * Time.deltaTime * speed);

        if (!GameEssentials.isGameOver && GameEssentials.isGameBeingPlayed)
            transform.position = followObj.transform.position + offset;
        
    }

    
}
