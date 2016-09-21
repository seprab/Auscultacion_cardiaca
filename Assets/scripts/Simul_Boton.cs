using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Simul_Boton : MonoBehaviour {

    public void activar()
    {
        gameObject.GetComponent<Image>().color = new Vector4(1, 1, 1, 1);
    }
    public void desactivar()
    {
        gameObject.GetComponent<Image>().color = new Vector4(0.757f, 0.757f, 0.757f, 0.609f);
    } 
}
