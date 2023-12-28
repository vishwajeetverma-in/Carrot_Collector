using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public FixedJoystick joystick;
     float hInput, vInput;
    public float movSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        hInput = joystick.Horizontal * movSpeed;
        vInput = joystick.Vertical * movSpeed;

        transform.Translate(hInput, vInput, 0);
    }


}
