using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed = 5;
    public float dead_zone = -25; // Checks for when an object is off the screen 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < dead_zone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
