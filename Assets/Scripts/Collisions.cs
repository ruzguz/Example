using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    private int _score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) 
    {
        other.transform.GetComponent<Renderer>().material.color =  Color.blue;
    }

    private void OnTriggerEnter(Collider other) 
    {
        _score += 10;
        Destroy(other.gameObject);
    }
}
