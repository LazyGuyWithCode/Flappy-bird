using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeScript : MonoBehaviour
    
{
    public float movespeed = 5;
    public float DeadZone = -39;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = transform.position + (Vector3.left * movespeed)* Time.deltaTime;
        if (transform.position.x < DeadZone)
        {
            Destroy(gameObject);
        }
        
    }
}
