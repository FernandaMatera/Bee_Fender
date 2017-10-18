using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int[] materiales;
    private static GameManager instance;

    public GameObject Panal;


    public static GameManager Instance()
    {
        if (instance == null)
        {
            instance = new GameManager();
        }

        return instance;
    }

    public void Restar(int indice, int cantidad)
    {
        materiales[indice] -= cantidad;

    }

    public void Agregar(int indice, int cantidad)
    {
        materiales[indice] += cantidad;

    } 

    // Use this for initialization
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
