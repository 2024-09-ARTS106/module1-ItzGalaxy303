using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    void Update()
    {
        if (Input.GetKey(KeyCode.W)) { transform.Translate(0, 0, speed); }
        if (Input.GetKey(KeyCode.S)) { transform.Translate(0, 0, -speed); }
        if(Input.GetKey(KeyCode.A)) { transform.Translate(-speed, 0, 0); }
        if(Input.GetKey(KeyCode.D)) {transform.Translate(speed, 0, 0); }
        
    }

}
