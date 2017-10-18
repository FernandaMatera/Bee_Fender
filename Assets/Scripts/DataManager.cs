using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;     
       
// El espacio de nombres System.IO contiene funciones relacionadas con la carga y el almacenamiento de archivos


public class DataManager : MonoBehaviour
{

    private string gameDataFileName = "Assets/DataFolder/data.json";    //Ruta del JSON
    
    //Aca se cargara todos los metodos al incio del juego
    void Start()
    {

        LoadGameData();
        WriteData(LoadGameData());
    }

 
    //Este metodo abrira el json y lo leera
    private DatosJuego LoadGameData()
    {
        DatosJuego dato = new DatosJuego();
        //Se verifica si el archivo existe           
        if (File.Exists(gameDataFileName))
        {
            Debug.Log("El Archivo existe");
            string dataJSON = File.ReadAllText(gameDataFileName); //Se lee el archivo para ver que contiene

            //Se tiene un objeto de tipo DatosJuego el que se llamara dato,
            //con las utilidades de json se estructurara en base al objeto el string obtenido en formato json
            dato = JsonUtility.FromJson<DatosJuego>(dataJSON); 
                      

        }
        else
        {
            Debug.Log("El Archivo no existe");
            //en caso de que el archivo no exista se mostrara un mensaje
        }
        return dato;
    }

   
    private void WriteData(DatosJuego data)
    {
        //con el ToJson paso un objeto y devuelvo un string
        string dato = JsonUtility.ToJson(LoadGameData());
        Debug.Log(dato);

        SaveDataJSONFile("Assets/DataFolder",dato,"archivo1");        
    }

    private void SaveDataJSONFile(string path, string dataFile, string name)
    {
        File.WriteAllText(path+"/"+name+".json", dataFile);
    }

    public class Datito: MonoBehaviour
    {

        public string nombre;
        public int nivel;

        public void guardar()
        {
            DatosJuego prueba = new DatosJuego();
            prueba.datosJuego = new Dato[2];

            prueba.datosJuego[0].nombre = "hola";
            prueba.datosJuego[0].nivel = 1;
        }

    }

}
