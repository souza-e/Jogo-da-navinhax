using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerador : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] aleaestrelas;
    
    public Transform[] alealocais;
    public float tempoestrela;
    public float tempo;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tempo -= Time.deltaTime;
        if (tempo <= 0)
        {

           int aleestrela = Random.Range(0, aleaestrelas.Length );
            int ptale = Random.Range(0, alealocais.Length);
            Instantiate(aleaestrelas[aleestrela], alealocais[ptale].position, alealocais[ptale].rotation);
            tempo = tempoestrela;
        }
    }
}
