using GoogleSheetsToUnity;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeRecorder : MonoBehaviour
{
    public Text textoo;
    static readonly System.DateTime hora = System.DateTime.Now;
    public string tiempo = hora.ToString().Substring(0,15);
    private readonly string sheetName = "Sheet1";
    private readonly string sheetId = "1g5pCDZYr-p8EqvGF4jrXAPyphay-gJswoMuWivNw3kk";
    float tiempoInicial;
    string actividad = "-1";
    float tiempoActividad = -1;
    List<string> data;
    void Start()
    {
        textoo.text = tiempo;
        tiempoInicial = Time.timeSinceLevelLoad;
    }
    public void agarre(string s)
    {
        actividad = s;
        tiempoActividad = Time.timeSinceLevelLoad - tiempoInicial;
        send();
    }
    public void registrarTiempoActividad1()
    {
        if (!actividad.Equals("1"))
        {
            actividad = "1";
            tiempoActividad = Time.timeSinceLevelLoad - tiempoInicial;
            Debug.Log(tiempoActividad.ToString());
            send();
        }
    }
    public void registrarTiempoActividad2()
    {
        if (!actividad.Equals("2"))
        {
            actividad = "2";
            tiempoActividad = Time.timeSinceLevelLoad - tiempoActividad;
            send();
        }
    }
    public void registrarTiempoActividad3()
    {
        if (!actividad.Equals("3"))
        {
            actividad = "3";
            tiempoActividad = Time.timeSinceLevelLoad - tiempoActividad;
            send();
        }
    }
    private void send()
    {
        data = new List<string>()
        {
            tiempo,
            actividad,
            tiempoActividad.ToString().Replace(',','.')
        };
        GSTU_Search buscador = new GSTU_Search(sheetId, sheetName, "A2");
        SpreadsheetManager​.Append(buscador, new ValueRange(data), null);
    }
}
