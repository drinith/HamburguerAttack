using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision col)
    {
        print("Colisão com o "+col.gameObject.name);
        if(col.gameObject.name=="Plane"){

            print("Colidiu com o plano");
        }else{
            print("Colisão com o "+col.gameObject.name);
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
