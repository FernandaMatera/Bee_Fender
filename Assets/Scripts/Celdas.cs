using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Celdas : Generador {

    public GameObject panal;
    static public GameObject[] celdas;
    static int IndiceCelda = 0;
    public Color colorCelda;


    // Use this for initialization
	void Start () {

        if (celdas == null)
        {

            celdas = GameObject.FindGameObjectsWithTag("Cuadricula");

            for (int i = 0; i < celdas.Length; i++)
            {
                celdas[i].SetActive(false);
            }
        }
		
	}

    //public void celdaPolinzadora()
    //{
    //    if (IndiceCelda < celdas.Length)
    //    {
    //        celdas[IndiceCelda].GetComponent<Image>().color = Color.magenta;
    //        celdas[IndiceCelda].SetActive(true);

    //        IndiceCelda++;
    //        Crear();
    //    }
    //}

    //public void celdaProtectora()
    //{
    //    if (IndiceCelda < celdas.Length)
    //    {
    //        celdas[IndiceCelda].GetComponent<Image>().color = Color.blue;
    //        celdas[IndiceCelda].SetActive(true);

    //        IndiceCelda++;
    //        Crear();
    //    }
    //}



    public void GenerarCelda()
    {
        Debug.Log(IndiceCelda +" - "+celdas.Length);
        if (IndiceCelda < celdas.Length)
        {
           
            celdas[IndiceCelda].SetActive(true);
            celdas[IndiceCelda].GetComponent<Image>().color = colorCelda;
            IndiceCelda++;
            Crear();
        }
    }

    // Update is called once per frame
    void Update () {
        //if (!generarCelda)
        //    return;


        //if (Input.GetMouseButtonDown(0))
        //{
            
        //    Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit2D hit = Physics2D.Raycast(r.origin, r.direction);
        //    if (hit.collider != null)
        //    {

        //        if (hit.collider.CompareTag("Cuadricula"))
        //        {
        //            Transform t = hit.collider.transform;
        //            Instantiate(panal, t);
        //            generarCelda = false;
        //            Crear();
        //        }
        //    }
        //}
		
	}
}
