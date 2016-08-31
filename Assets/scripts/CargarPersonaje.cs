﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;

public class CargarPersonaje : MonoBehaviour {

    public GameObject H_N_bien;
    public GameObject H_N_obeso;
    public GameObject H_B_bien;
    public GameObject H_B_obeso;

    void Start ()
    {
        leerTxt();
	}
	void leerTxt()
    {
        string dir = "Assets/registros/PacienteX.txt";
        string[] datos = File.ReadAllLines(dir);
        int raza = Int32.Parse(datos[0]);
        int contextura = Int32.Parse(datos[1]);
        List<bool> sin = new List<bool>();
        for (int i = 2; i < 6; i++)
        {
            sin.Add(Boolean.Parse(datos[i]));
        }
        cargaPj(raza,contextura,sin);
    }
    void cargaPj(int raza, int contextura, List<bool> sintoma)
    {
        if(raza==0)
        {
            if(contextura==1)
            {
                //H_N_bien
               GameObject paciente1= Instantiate(H_N_bien, new Vector3(0.0f, -140.0f, 125.0f), Quaternion.identity) as GameObject;
                paciente1.transform.localScale=new Vector3(100f, 100f, 100f);
                paciente1.transform.Rotate(new Vector3(0,1,0),180);
            }
            if(contextura==2)
            {
                //H_N_obeso
                GameObject paciente2 = Instantiate(H_N_obeso, new Vector3(0.0f, -140.0f, 125.0f), Quaternion.identity) as GameObject;
                paciente2.transform.localScale = new Vector3(100f, 100f, 100f);
                paciente2.transform.Rotate(new Vector3(0, 1, 0), 180);
            }
        }
        else if(raza==1)
        {
            if (contextura == 1)
            {
                //H_B_bien
                GameObject paciente3 = Instantiate(H_B_bien, new Vector3(0.0f, -140.0f, 125.0f), Quaternion.identity) as GameObject;
                paciente3.transform.localScale = new Vector3(100f, 100f, 100f);
                paciente3.transform.Rotate(new Vector3(0, 1, 0), 180);
            }
            if (contextura == 2)
            {
                //H_B_obeso
                GameObject paciente4 = Instantiate(H_B_obeso, new Vector3(0.0f, -140.0f, 125.0f), Quaternion.identity) as GameObject;
                paciente4.transform.localScale = new Vector3(100f, 100f, 100f);
                paciente4.transform.Rotate(new Vector3(0, 1, 0), 180);
            }
        }
        else
        {
            Debug.Log("Aun no se carga el pj");
        }
    }
	void Update ()
    {
	
	}
}
