﻿using System.Collections;
using UnityEngine;

public class empezarJuegoSecuencia : MonoBehaviour
{
    public float intensidadLuz;
    public Light Luz;
    public AudioClip sonido;
    public ControladorJuego controlador;
    public Animator anim;

    private bool pTouched = false;

    void Start()
    {
        intensidadLuz = Luz.intensity;
        pTouched = false;
    }

    IEnumerator AnimPlay()
    {
        anim.SetBool("press", true);
        yield return new WaitForSeconds(1);
        anim.SetBool("press", false);
    }

    public void Activar() {
        
            Luz.intensity = intensidadLuz;
            Luz.gameObject.SetActive(true);
            StartCoroutine(AnimPlay());
            AudioSource.PlayClipAtPoint(sonido, Vector3.zero, 1.0f);
            StartCoroutine(controlador.Jugar());
    }

    void OnTriggerEnter()
    {

        if (!pTouched)
        {
            pTouched = true;
            Activar();
            //yield return new WaitForSeconds(3);    
            pTouched = false;    
        }
    }

}
