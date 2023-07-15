using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    // Start is called before the first frame update
    void Start()
    {
        hits = 0;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hits++;
        }
        
        Debug.Log("Your score is: " + hits);
        
    }
}
