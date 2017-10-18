using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaleNectarATuLife : Generador {



    public new void Crear()
    {
        int nectar=0;

        for (int i = 0; i < materialesNecesarios.Length; i++)
        {

            nectar += GameManager.Instance().materiales[materialesNecesarios[i]]*cantidad;
            //cantidadNecesario[i];

        }
        GameManager.Instance().Agregar(indice, nectar);
    }
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
