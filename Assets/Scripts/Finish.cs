using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    MeshRenderer renderer;
    Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        renderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player") 
        {
            Debug.Log("Player hit the finish - respawning back to initial position");
            //GameObject players = GameObject.FindGameObjectsWithTag ("Player");
            //other.gameObject.position = startPosition;
            //player.position = startPosition;
        //foreach (GameObject player in players)
        //{
        //    Pos = player.transform.startPosition;
        //}

        }
    }
}
