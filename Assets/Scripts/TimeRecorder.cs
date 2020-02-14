using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeRecorder : MonoBehaviour
{
    System.DateTime hora = System.DateTime.Now;
    float tiempoInicial = Time.timeSinceLevelLoad;
    float tiempoActividad1 = -1;
    float tiempoActividad2 = -1;
    float tiempoActividad3 = -1;
    // 2x2 https://docs.google.com/forms/u/0/d/e/1FAIpQLSfeBI1jQTRXxycJQKozXC1FS51D_Yz1ncWILOCgvntAuk5HHw/formResponse entry.265794969 entry.339583602 entry.1770909071
    // 6x6 https://docs.google.com/forms/u/0/d/e/1FAIpQLSfeBI1jQTRXxycJQKozXC1FS51D_Yz1ncWILOCgvntAuk5HHw/formResponse entry.1754340615 entry.1075263137 entry.17703641
    [SerializeField] private string BASE_URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSfeBI1jQTRXxycJQKozXC1FS51D_Yz1ncWILOCgvntAuk5HHw/formResponse";
    IEnumerator Post (float tiempo1, float tiempo2, float tiempo3)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1754340615", "" + tiempo1);
        form.AddField("entry.1075263137", "" + tiempo2);
        form.AddField("entry.17703641", ""+tiempo3);
        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;
    }
    public void send()
    {
        StartCoroutine(Post(tiempoActividad1, tiempoActividad2, tiempoActividad3));
    }
    public void registrarTiempoActividad1()
    {
        tiempoActividad1 = Time.timeSinceLevelLoad - tiempoInicial;
    }
    public void registrarTiempoActividad2()
    {
        tiempoActividad2 = Time.timeSinceLevelLoad - tiempoActividad1;
    }
    public void registrarTiempoActividad3()
    {
        if (tiempoActividad3 == -1) {
            tiempoActividad3 = Time.timeSinceLevelLoad - tiempoActividad2;
            this.send();
        }
    }
}
