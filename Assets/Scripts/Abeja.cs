using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abeja : MonoBehaviour {

    public GameObject bala;
    static public bool Empezar = false;
    bool disparando = false;
    public int tiempoDisparo;

    IEnumerator disparar()
    {
        int tiempo = 0;
        while (Empezar)
        {
            yield return new WaitForSeconds(1.0f);
            tiempo++;
            if (tiempo > tiempoDisparo)
            {
                Instantiate(bala, transform);
                tiempo = 0;
            }
        }
        disparando = false;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Empezar && ! disparando)
        {
            disparando = true;
            StartCoroutine(disparar());
        }
		
	}
}
