using GoogleSheetsToUnity;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeRecorder : MonoBehaviour
{
    public Text textoo;
    static readonly System.DateTime hora = System.DateTime.Now;
    public string tiempo;
    private readonly string sheetName = "Sheet1";
    private readonly string sheetId = "1g5pCDZYr-p8EqvGF4jrXAPyphay-gJswoMuWivNw3kk";
    float tiempoInicial;
    string actividad = "-1";
    float tiempoActividad = -1;
    List<string> data;
    void Start()
    {
        tiempo = hora.ToString("dd/MM/yyyy HH:mm");
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
        if (!actividad.Equals("Cube Activity End"))
        {
            actividad = "Cube Activity End";
            tiempoActividad = Time.timeSinceLevelLoad - tiempoInicial;
            send();
        }
    }
    public void registrarTiempoActividad2()
    {
        if (!actividad.Equals("Simon Says End"))
        {
            actividad = "Simon Says End";
            tiempoActividad = Time.timeSinceLevelLoad - tiempoActividad;
            send();
        }
    }
    public void registrarTiempoActividad3()
    {
        if (!actividad.Equals("Word Puzzle End"))
        {
            actividad = "Word Puzzle End";
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
