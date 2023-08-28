using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    // start pipe spawner and set speed to 10
    // spawn a pipe
    void Start()
    {
        startPipes();
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        // spawns for spawnRate secs
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
        // transform hooks into the GameObject's position and rotation / transform component
    }

    // gets all existing pipes and stops them from moving (by tag search)
    public void stopPipes()
    {
        foreach (GameObject pipe in GameObject.FindGameObjectsWithTag("pipe"))
        {
            pipe.GetComponent<PipeMoveScript>().moveSpeed = 0;
        }
        this.gameObject.SetActive(false);
    }

    // sets pipe GameObject speed back to 10 and PipeSpawner back to active
    public void startPipes()
    {
        // pipe.GetComponent<PipeMoveScript>().stopPipes();
        pipe.GetComponent<PipeMoveScript>().moveSpeed = 10;
        this.gameObject.SetActive(true);
    }

    void spawnPipe()
    {

        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z), transform.rotation);
        // pipes.Add(newPipe);
    }
}
