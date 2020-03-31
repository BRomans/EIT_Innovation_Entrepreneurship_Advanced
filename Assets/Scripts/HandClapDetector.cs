using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandClapDetector : MonoBehaviour
{

    public PlayerMovement playerMovement;
    public GameObject startText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collision collision){
        if(collision.collider.gameObject.tag == "HandClap"){
            playerMovement.startMoving();
            Destroy(startText);
        } 
    }
}
