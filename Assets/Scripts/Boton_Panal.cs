using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton_Panal : MonoBehaviour {

    public Animator controlador;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void boton ()
    {
        controlador.enabled = true;
        bool estadoActual = controlador.GetBool("abajo");
        controlador.SetBool("abajo", !estadoActual);
    }
}
