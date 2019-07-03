using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Colision : MonoBehaviour
{
    public AudioSource gotaSound;

    
    public Text textPonto;

    public Text vida;

    public int pontosVida=3;

    static int count;
    // Start is called before the first frame update
    void Start()
    {
      pontosVida=1;
    }

    // Update is called once per frame
    void Update()
    {
        
        textPonto.text=textPonto.text;
        pontosVida=(int.Parse(vida.text));
        print(pontosVida);
        if(pontosVida<=0){
                
                Invoke("endGame",2f);
                
                
        }
    }

    void endGame(){
        SceneManager.LoadScene("fim");
                
                print("muda cena");
    }

    

    void OnCollisionEnter (Collision col)
    {
     
            
        if (col.gameObject.name=="Bullet(Clone)" | col.gameObject.name=="hanburger(Clone)"){
            
            Destroy(col.gameObject);
            Destroy(gameObject);
            textPonto.text=(int.Parse(textPonto.text)+1).ToString();
            gotaSound.Play();  
            
        }

        if (col.gameObject.name=="canhao"){
           
            Destroy(gameObject);
          
            vida.text=pontosVida.ToString();

           

        }
        
    }
}
