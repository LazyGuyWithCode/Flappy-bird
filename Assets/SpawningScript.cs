using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningScript : MonoBehaviour
{
    public GameObject pipe;
    public float SpawnRate = 2;
    private float Timer = 0;
    public float HeightOffset = 10;
  
    // Start is called before the first frame update
    void Start()
    {
        spawnPipes();
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer < SpawnRate)
        {
            Timer = Timer + Time.deltaTime;
        }
        else 
        {
            spawnPipes();
            Timer = 0;
        }
        
    }
    void spawnPipes()
    {
        float highestSpawn = transform.position.y+HeightOffset;
        float lowestSpawn = transform.position.y -HeightOffset;

        Instantiate(pipe,new Vector3(transform.position.x, Random.Range(highestSpawn,lowestSpawn),0),transform.rotation);
    }
}
