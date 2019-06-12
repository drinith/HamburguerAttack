using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Colision : MonoBehaviour
{

    public TextMesh textMesh=null;
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
            
        }else if (col.gameObject.name=="Bullet(Clone)" | col.gameObject.name=="Hamburguer(Clone)"){
            Debug.Log("acertou tiro ");
            Destroy(col.gameObject);
            Destroy(gameObject);
            textMesh.text="Acertou";
    
        }
        
    }
}
