using UnityEngine;
using System.Collections;

public class Menus : MonoBehaviour {

    public GameObject descripcion;
    bool sumar = false;
    bool restar = false;
    void Update()
    {
        if (sumar == true) Aumentar();
        if (restar == true) Disminuir();
    }
    public void escalar()
    {
        if (gameObject.transform.lossyScale.y <= 0.26) sumar = true;
        else
        {
            descripcion.SetActive(false);
            restar = true;
        }
    }
    void Aumentar()
    {
        if (gameObject.transform.lossyScale.y <= 0.26)
        {
            transform.localScale += new Vector3(0, 0.01f, 0);
        }
        else
        {
            descripcion.SetActive(true);
            sumar = false;
        }
    }
    void Disminuir()
    {
        if (gameObject.transform.lossyScale.y >= 0.08)
        {
            transform.localScale -= new Vector3(0, 0.01f, 0);
        }
        else  restar = false;
    }
}
