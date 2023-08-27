using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// invisible trigger area to increase score

// to reference gameObjects not in the scene/hierarchy; use tags to and find them
// allowing us to run another gameObjects script via this s
public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); // Searches for GameObject with tag "Logic", then gets its component called LogicScript
        // assigning it to the LogicScript reference slot
        // PipeMiddle.cs connects to LogicScript.cs in LogicManager GameObject
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
    }
}
