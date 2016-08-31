using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System;
using System.IO;

public class CrearPaciente : MonoBehaviour {

    int raza = 0;
    int contextura = 0;
    List<bool> sintomas = new List<bool>();

    void Start()
    {
        for(int i=0; i<4; i++)
        {
            sintomas.Add(false);
        }
    }

    public void razaElegir (int eleccion)
    {
        raza = eleccion;
    }
    public void contexElegir (int eleccion)
    {
        contextura = eleccion;
    }
    public void ActivarSintoma1(bool activar)
    {
        sintomas[0] = activar;
    }
    public void ActivarSintoma2(bool activar)
    {
        sintomas[1] = activar;
    }
    public void ActivarSintoma3(bool activar)
    {
        sintomas[2] = activar;
    }
    public void ActivarSintoma4(bool activar)
    {
        sintomas[3] = activar;
    }
    public void crearTxt()
    {
        string dir = "Assets/registros/PacienteX.txt";
        var Archivotexto = File.CreateText(dir);
        Archivotexto.WriteLine(raza);
        Archivotexto.WriteLine(contextura);
        Archivotexto.WriteLine(sintomas[0]);
        Archivotexto.WriteLine(sintomas[1]);
        Archivotexto.WriteLine(sintomas[2]);
        Archivotexto.WriteLine(sintomas[3]);
        Archivotexto.Close();
    }
    public void CambiarEscena ()
    {
        crearTxt();
        SceneManager.LoadScene("Simulacion");
    }
}
