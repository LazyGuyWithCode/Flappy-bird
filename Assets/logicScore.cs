using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class logicScore : MonoBehaviour
{
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic= GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addscore();
    }
}
