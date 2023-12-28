using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public FixedJoystick joystick;
     float hInput, vInput;
    public float movSpeed;
    int score = 0;
    public GameObject winText;
    public int winScore;



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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Carrot")
        {
            score++;
            Destroy(collision.gameObject);
            if(score >= winScore)
            {
                winText.SetActive(true);
            }
        }
    }


}
