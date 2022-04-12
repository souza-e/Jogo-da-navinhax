using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroide : MonoBehaviour
{
    // Start is called before the first frame update
    
        
    
 private void OnTriggerEnter2D(Collider2D collision){

       if(collision.gameObject.CompareTag("nave"))
       {
          
           Debug.Log("fim de jogo");
           Destroy (gameObject);
       }
if(collision.gameObject.CompareTag("parede"))
       {
       
        Destroy (gameObject, 0.1f);
       
       }


   }



}


