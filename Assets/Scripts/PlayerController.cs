using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalImput;
    public float speed = 10.0f;
    private float xRange = 19.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalImput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalImput * Time.deltaTime * speed);

        if( transform.position.x>xRange) 
        {
       transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
    }
}
