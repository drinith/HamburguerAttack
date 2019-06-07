using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroyBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sair();
    }

    void OnBecameInvisible()
    {
        if (gameObject.name=="Target1(Clone)"){
            Destroy(gameObject);
            Debug.Log(name + " is out!"); // This line prints!
        }
    }

    void sair(){
        if(gameObject.transform.position.z>20 | gameObject.transform.position.z<-20 & gameObject.name!="hamburguer"){
            Destroy(gameObject);
            Debug.Log(name + "Saiu"); // This line prints
            
        }
    }

     
}
