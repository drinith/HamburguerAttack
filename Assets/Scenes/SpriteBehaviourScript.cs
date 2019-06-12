using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteBehaviourScript : MonoBehaviour
{
   
    public float rotationSpeed = 100.0f;
    public float speed = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /*void Update()
    {
        if (Input.GetButtonDown("left")){

            transform.Rotate(Vector3.up);
        }

        if (Input.GetKeyDown("right"))
        {
            
            print("space key was pressed");
        }
    }*/
   

    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, 0, translation);

        // Rotate around our y-axis
        transform.Rotate(0, rotation, 0);

        /*
        if (Input.GetMouseButtonDown(0))
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            go.transform.position = Camera.main.transform.position;
            Rigidbody rb = go.AddComponent<Rigidbody>();
            Vector3 v3T = Input.mousePosition;
            v3T.x = 10.0f;
            go.transform.LookAt(Camera.main.ScreenToWorldPoint(v3T));
            rb.AddRelativeForce(Vector3.forward * 1000);
           
        }*/
    }
}
