using UnityEngine;
using UnityEngine.UI;

public class AutoDestroyBulletBehaviourScript : MonoBehaviour
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
        print("OnBecameInvisible "+gameObject.name);
        if (gameObject.name=="Target1(Clone)"){
            Destroy(gameObject);
        
           
        }
    }

    void sair(){
       
       if(gameObject.transform.position.z>20 | gameObject.transform.position.z<-20 & gameObject.name!="hamburguer" ){
            Destroy(gameObject);
                       
        }
    }

     
}
