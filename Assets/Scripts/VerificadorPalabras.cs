﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VerificadorPalabras : MonoBehaviour
{
    public TimeRecorder grabador;

    private List<GameObject> bloques;
    public GameObject gOPrefab;
    public float xI;
    public float yI;
    public float zI;
    public float espacio = 0.18f;

    public int completada = 0;
    private string palabra;
    public int palabraActual = 0;
    public GeneradorPalabras generadorPalabras;

    bool primeraVez = true;
    private SoundManager soundManager;

    void Awake()
    {
        soundManager = GameObject.FindObjectOfType<SoundManager>();
    }

    void Start()
    {
        empezarJuego();
    }

    void Update()
    {
        //print(completada+" = "+palabra.Length);
        if(completada == palabra.Length)
        {
            palabraActual++;
            destruirBloquesPalAnterior();
            empezarJuego();
            Invoke("Jugar", 2.0f);
            grabador.registrarTiempoActividad3();
        }
    }

    public void empezarJuego()
    {
        completada = 0;
        palabra = generadorPalabras.CambiarPalabra(palabraActual);
        bloques = new List<GameObject>();
        LlenarGameObjectsVacios();
    }


    public void Jugar()
    {
        float xtemp = xI+0.68f;
        char[] arr = palabra.ToCharArray(0, palabra.Length);
        for (int i = 0; i < arr.Length; i++)
        {
            bloques[i] = Instantiate(gOPrefab, new Vector3((xtemp += espacio), yI-.41f, zI+.35f), Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;
            //gOModelo.transform.localScale += new Vector3(3f, 3f, 3f);
            bloques[i].name = "" + arr[i];
            bloques[i].AddComponent<VerificarCaracter>();
        }
        if(primeraVez)
        {
            StartCoroutine(comenzarInstruccionesPalabras());
        }
        else{
            soundManager.PlaySound("Ins6L2");
            StartCoroutine(soundManager.CambiarInstruccionPantalla2("Ins3L2", 0, palabra, 0));
        } 
    }

    IEnumerator comenzarInstruccionesPalabras()
    {
        soundManager.PlaySound("Ins4L2");
        StartCoroutine(soundManager.CambiarInstruccionPantalla2("Ins3L2", 0, "animal", 0));
        yield return new WaitForSeconds(18);
        soundManager.PlaySound("Ins5L2");
        StartCoroutine(soundManager.CambiarInstruccionPantalla2("Ins5L2", 0, "animal", 0));
        yield return new WaitForSeconds(10);
        primeraVez = false;
        yield return new WaitForSeconds(10);
        soundManager.arrow.SetActive(false);
    }


    public void LlenarGameObjectsVacios()
    {
        for (int i = 0; i < palabra.Length; i++)
        {
            bloques.Add(gOPrefab);
        }
    }

    public void destruirBloquesPalAnterior()
    {
        for (int i = 0; i < palabra.Length; i++)
        {
            Destroy(bloques[i]);
        }
    }



    public void verificarPalabraCompletada()
    {       
            for (int i = 0; i < palabra.Length; i++)
            {
                if(bloques[i].gameObject.GetComponent<VerificarCaracter>()!=null)
                {
                    if(bloques[i].gameObject.GetComponent<VerificarCaracter>().completada)
                    {
                        completada++;
                        Update();
                    }
                }
            }       
    }
}