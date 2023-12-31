using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// prefab gameObject to be used in PipeSpawn
public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed = 10;
    public float deadZone = -35;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; // Time.deltaTime ties the position change rate by an internal clock (not platform dependent)
        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }

    }

    public void destroyPipes()
    {
        Destroy(gameObject);
    }
}
