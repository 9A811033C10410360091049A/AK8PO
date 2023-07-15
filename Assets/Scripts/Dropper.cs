using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidBody;
    [SerializeField] 
    int waitTime = 5;

    // Start is called before the first frame update
    void Start()
    {
        // 
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false; // Making object invisible
        //
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false; // Setting gravity to off

    }

    // Update is called once per frame
    void Update()
    {
        if(!(Time.time < waitTime))
        {
            //Debug.Log("Droping all objects ...");
            renderer.enabled = rigidBody.useGravity = true; // Make it visible and gravity on
        }
    }
}
