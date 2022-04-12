using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estrela : MonoBehaviour
{
    // Start is called before the first frame update
   private void OnTriggerEnter2D(Collider2D collision){

       if(collision.gameObject.CompareTag("nave"))
       {
          collision.GetComponent<navecon>().somaestrela();
           Debug.Log("colidiu oirra");
           Destroy (gameObject, 0.1f);
       }
if(collision.gameObject.CompareTag("parede"))
       {
       
        Destroy (gameObject, 0.1f);
       
       }

   }
}
