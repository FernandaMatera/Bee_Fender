using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generadorEnemigo : MonoBehaviour {

    public Transform[] posiciones;
    public int tiempoIntervalo;
    public GameObject enemigo;

	// Use this for initialization
	void Start () {
		
	}
	IEnumerator aLaBatalla()
    {
        int tiempo = 0;
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            tiempo++;
            if (tiempo > tiempoIntervalo)
            {
                int i = Random.Range(0, posiciones.Length);
                Instantiate(enemigo, posiciones[i]);
                tiempo = 0;
            }

        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
