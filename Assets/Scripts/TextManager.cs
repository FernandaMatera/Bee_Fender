using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

    public Text[] materiales;

	// Use this for initialization
	void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {
        ActualizarTextos();
		
	}

    public void ActualizarTextos()
    {
        for (int i = 0; i < materiales.Length; i++)
        {
            if (materiales[i] != null)
            {
                materiales[i].text = "" + GameManager.Instance().materiales[i].ToString();
            }
        }
    }

}
