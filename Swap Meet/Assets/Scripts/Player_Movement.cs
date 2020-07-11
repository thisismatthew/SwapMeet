using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public int speed = 5;

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3();
        move += new Vector3((Input.GetAxis("Horizontal")* speed) * Time.deltaTime, 0f, 0f);
        move += new Vector3(0f, 0f, (Input.GetAxis("Vertical")* speed) * Time.deltaTime);
        transform.Translate(move); 
        
    }
}
