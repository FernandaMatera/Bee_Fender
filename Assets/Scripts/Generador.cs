using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Generador : MonoBehaviour {

    public int[] materialesNecesarios;
    public int[] cantidadNecesaria;

    public int indice;
    public int cantidad;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per framea
	void Update () { 
		
	}

    public void Crear()
    {
        //GameManager.Instance.Restar(materiales[indice]);
        //agregar(indice,cantidad);
        
        for (int i = 0 ; i < materialesNecesarios.Length; i++)
        {
            GameManager.Instance().Restar(materialesNecesarios[i], cantidadNecesaria[i]);
            //cantidadNecesario[i];
        }
        GameManager.Instance().Agregar(indice, cantidad);

    }


   // public void crearCelda(Transform t)
   // {
   //     if (t.childCount != 0)
   //        return;

   //  GameObject g = Instantiate(Panal.gameObject, t.position, gameObject.transform.rotation) as GameObject;
   //g.transform.SetParent(t);


}
