using GoogleSheetsToUnity;
using System.Collections.Generic;
using UnityEngine;

public class TimeRecorder : MonoBehaviour
{
    readonly System.DateTime hora = System.DateTime.Now;
    private readonly string sheetName = "Sheet1";
    private readonly string sheetId = "1g5pCDZYr-p8EqvGF4jrXAPyphay-gJswoMuWivNw3kk";
    float tiempoInicial = Time.timeSinceLevelLoad;
    float actividad = -1;
    float tiempoActividad = -1;
    List<string> data;
    public void registrarTiempoActividad1()
    {
        if (actividad != 1)
        {
            actividad = 1;
            tiempoActividad = Time.timeSinceLevelLoad - tiempoInicial;
            Debug.Log(tiempoActividad.ToString());
            send();
        }
    }
    public void registrarTiempoActividad2()
    {
        if (actividad != 2)
        {
            actividad = 2;
            tiempoActividad = Time.timeSinceLevelLoad - tiempoActividad;
            send();
        }
    }
    public void registrarTiempoActividad3()
    {
        if (actividad != 3)
        {
            actividad = 3;
            tiempoActividad = Time.timeSinceLevelLoad - tiempoActividad;
            send();
        }
    }
    private void send()
    {
        data = new List<string>()
        {
            hora.ToString(),
            actividad.ToString(),
            tiempoActividad.ToString().Replace(',','.')
        };
        GSTU_Search buscador = new GSTU_Search(sheetId, sheetName, "A2");
        SpreadsheetManager​.Append(buscador, new ValueRange(data), null);
    }
}