using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    int hits = 0;
    MeshRenderer renderer;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player") // only if player hits the object it turns red
        {
            renderer.material.color = Color.red;
            gameObject.tag = "Hit"; // Object is Hit so no score increase 

        }
    }
}
