using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuini : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 0f;
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void iniciar()
    {

        Time.timeScale = 1f;
        this.gameObject.SetActive(false);

    }
   public void sair (){
 
  Application.Quit();

   }

}

