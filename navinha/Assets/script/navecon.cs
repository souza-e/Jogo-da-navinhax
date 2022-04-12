using System.Net.Mime;
using System.Transactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class navecon : MonoBehaviour
{
    // Start is called before the first frame update
    public float vel ;
   public int qqestrela ;
   public Text pontuacao;
    void Start()
    {
      //  qqestrela = 0;
    }

    // Update is called once per frame
    void Update()
    {
        movenave ();
       
    }
     public void movenave()
     {

  float cmdteclado = Input.GetAxisRaw("Horizontal")*vel*Time.deltaTime;
transform.position = new Vector2 ((transform.position.x + cmdteclado), transform.position.y );

    }
   public void somaestrela (){

       qqestrela ++;
       pontuacao.text ="" + qqestrela;
   }


}
