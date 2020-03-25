using GoogleSheetsToUnity;
using System.Collections.Generic;
using UnityEngine;

public class TimeRecorder : MonoBehaviour
{
    readonly System.DateTime hora = System.DateTime.Now;
    private readonly string sheetName = "Sheet1";
    private readonly string sheetId = "1g5pCDZYr-p8EqvGF4jrXAPyphay-gJswoMuWivNw3kk";
    float tiempoInicial = Time.timeSinceLevelLoad;
    float actividad = 0;
    float tiempoActividad = -1;
    List<string> data;
    int extras = 0;
    bool agarrado = false;
    string objActual = "";
    public void agarraObjeto(string S)
    {
        extras++;
        tiempoActividad = Time.timeSinceLevelLoad - tiempoInicial;
        objActual = S;
        data = new List<string>()
        {
            hora.ToString(),
            actividad.ToString(),
            tiempoActividad.ToString().Replace(',','.'),
            objActual,
            "Agarrado"
        };
        GSTU_Search buscador = new GSTU_Search(sheetId, sheetName, "A2");
        SpreadsheetManager​.Append(buscador, new ValueRange(data), null);
    }
    public void sueltaObjeto()
    {
        tiempoActividad = Time.timeSinceLevelLoad - tiempoInicial;
        data = new List<string>()
        {
            hora.ToString(),
            actividad.ToString(),
            tiempoActividad.ToString().Replace(',','.'),
            objActual,
            "Soltado"
        };
        objActual = "";
        GSTU_Search buscador = new GSTU_Search(sheetId, sheetName, "A2");
        SpreadsheetManager​.Append(buscador, new ValueRange(data), null);
    }
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
        string adhd = "Posiblemente no presenta problemas de atención";
        if(actividad==1 && extras > 9)
        {
            adhd = "Posiblemente presenta problemas de atención";
        }
        if (actividad == 2 && extras > 3)
        {
            adhd = "Posiblemente presenta problemas de atención";
        }
        if (actividad == 3 && extras > 50)
        {
            adhd = "Posiblemente presenta problemas de atención";
        }
        data = new List<string>()
        {
            hora.ToString(),
            actividad.ToString(),
            tiempoActividad.ToString().Replace(',','.'),
            adhd
        };
        GSTU_Search buscador = new GSTU_Search(sheetId, sheetName, "A2");
        SpreadsheetManager​.Append(buscador, new ValueRange(data), null);
    }
}
