using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//esta en declarar una clase que contenga todas las variables que te 
//gustarían almacenar para el juego y se le agrega el Serializable para que sea compatible
[System.Serializable]
public class GameProgress
{
    //datos que estaran en el metagame y se deben ir modificando
    public int lvl = 1;
    public int miel = 0;
    public int cera = 0;
    public int numeroCeldillas = 1;
    //los valores son considerados como las bases 

}
