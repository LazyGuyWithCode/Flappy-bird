using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdscript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flapstrength;
    public LogicScript logic;
    private bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive == true)
        {
            myrigidbody.velocity = Vector2.up * flapstrength;
        }
        if (transform.position.y <= -18.3)
        {
            logic.GameOver();
            birdIsAlive=false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;
    }
    

}