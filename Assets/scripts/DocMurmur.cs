using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;

public class DocMurmur : MonoBehaviour {

    private Text texto;
    string pitch=null;
    int grade=10;
    string quality=null;
    string behavior=null;
    string location=null;
    string radiation=null;

    public void Getpitch(int _pitch)
    {
        if (_pitch == 1) { pitch = "High"; }
        if (_pitch == 2) { pitch = "Medium"; }
        if (_pitch == 3) { pitch = "Low"; }
        Debug.Log("Pitch copiado");
        mostramos();
    }
    public void Getgrade(int _grade)
    {
        grade = _grade;
        mostramos();
        Debug.Log("grade copiado");
    }
    public void Getquality(int _quality)
    {
        if (_quality == 1) { quality = "blowing"; }
        if (_quality == 2) { quality = "harsh"; }
        if (_quality == 3) { quality = "rumbling"; }
        if (_quality == 4) { quality = "musical"; }
        Debug.Log("quality copiado");
        mostramos();
    }
    public void Getbehavior(int _behavior)
    {
        if (_behavior == 1) { behavior = "crescendo"; }
        if (_behavior == 2) { behavior = "decrescendo"; }
        if (_behavior == 3) { behavior = "crescendo-decrescendo"; }
        if (_behavior == 4) { behavior = "plateau"; }
        Debug.Log("behavior copiado");
        mostramos();
    }
    public void Getlocation(int _location)
    {
        if (_location == 1) { location = "sternum"; }
        if (_location == 2) { location = "apex"; }
        if (_location == 3) { location = "midsternal"; }
        if (_location == 4) { location = "midclavicular"; }
        if (_location == 5) { location = "axilary line"; }
        if (_location == 6) { location = "interspace"; }
        Debug.Log("location copiado");
        mostramos();
    }
    public void Getradiation(int _radiation)
    {
        if (_radiation == 1) { radiation = "sternum"; }
        if (_radiation == 2) { radiation = "apex"; }
        if (_radiation == 3) { radiation = "midsternal"; }
        if (_radiation == 4) { radiation = "midclavicular"; }
        if (_radiation == 5) { radiation = "axilary line"; }
        if (_radiation == 6) { radiation = "interspace"; }
        Debug.Log("radiation copiado");
        mostramos();
    }
    void mostramos()
    {
        string[] parametros = new string[] { pitch, quality, behavior, location, radiation };
        string vacio = null;
        string[] evitar = new string[] {vacio, vacio, vacio, vacio, vacio};

        if (parametros.Equals(evitar)) { }
        else if(grade != 10)
        {
            texto = gameObject.GetComponent<Text>();
            texto.text = pitch + "-pitched, grade " + grade + "/6, " + quality + " " + behavior + " murmur, heard best in the " + location + ", with radiation to the " + radiation;
            //Medium-pitched, grade 2/6, blowing decrescendo murmur, heard best in the 4th left interpace, with radiation to the apex
        }

    }
}
