using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Adjust the speed for the application.
    public float speed = 1.0f;
    // Detect if the player has started
    private bool isStarted = false;
    // All the checkpoints
    public GameObject[] targets;
    // The target (cylinder) position.
    private GameObject target;
    
    private int targetCounter = 0;

    void Start()
    {
        target = targets[targetCounter];
    }

    void Update()
    {
        if(isStarted) {
            // Move our position a step closer to the target.
            float step =  speed * Time.deltaTime; // calculate distance to move

            // Check if the position of the cube and sphere are approximately equal.
            if (!(Vector3.Distance(transform.position, target.transform.position) < 0.001f))
            {
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);

            } else if(targetCounter < 3) {
                targetCounter++;
                target = targets[targetCounter];
                speed += 0.2f;
            }
        }
    }

    public void startMoving() {
        this.isStarted = true;
    }

    public void stopMoving() {
        this.isStarted = false;
    }

    public void setSpeed(float speed) {
        this.speed = speed;
    }

    public void setTarget(GameObject target) {
        this.target = target;
    }
}
