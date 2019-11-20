﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificarCaracter : MonoBehaviour
{
    public bool completada = false;
    public AudioClip correcto;
    public AudioClip incorrecto;
    public GameObject prefabABCMonstruos;
    public GameObject prefabABCBloques;

    private void Start()
    {
        correcto = Resources.Load<AudioClip>("Sonidos/positive-beeps");
        incorrecto = Resources.Load<AudioClip>("Sonidos/negative-beeps");
        prefabABCMonstruos = (GameObject)Resources.Load("Prefabs/Alfabeto", typeof(GameObject));
    }

    void OnTriggerEnter(Collider col)
    {
        if (((col.name.ToLower()) == this.name) || (col.name == ("block-"+this.name)))
        {
            AudioSource.PlayClipAtPoint(correcto, Vector3.zero, 1.0f);
            completada = true;
            this.gameObject.GetComponent<Renderer>().material.color = Color.green;
            CrearDuplicado(col.name);
        }
        else
        {
            if(!(col.name== "CustomHandRight") || !(col.name == "CustomHandRight"))
            { 
                AudioSource.PlayClipAtPoint(incorrecto, Vector3.zero, 1.0f);
                this.gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }

    
    public void CrearDuplicado(string nombrePrefab)
    {
        
        Vector3 Pos = prefabABCMonstruos.transform.Find(nombrePrefab).localPosition;

        //eulerAngles
        print("OMG"+ Pos.x+ " Y "+ Pos.y+ " Z " + Pos.z);
        GameObject alf = GameObject.Find("Alfabeto");
        GameObject hijo = new GameObject(nombrePrefab);
        hijo = Instantiate(GameObject.Find(nombrePrefab), Pos, Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;
        hijo.transform.SetParent(alf.transform);
        hijo.transform.localPosition = new Vector3(Pos.x, Pos.y, Pos.z);
    }

}