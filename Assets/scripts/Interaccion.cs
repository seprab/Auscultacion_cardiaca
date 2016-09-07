using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Interaccion : MonoBehaviour {

    public List<Collider> cuboCol;
    public GameObject CameraTrans;
    float RotGlob;
    float ZoomGlob;
    float AltGlob;

    void Start()
    {
        ZoomGlob = 100;
        RotGlob = -90;
        AltGlob = 0;
        ScrollRotacion(RotGlob, ZoomGlob, AltGlob);
    }
    void Update ()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, (ray.direction * 1000), Color.red);

        RaycastHit hit;
        for (int i = 0; i < 3; i++)
        {
            if (cuboCol[i].Raycast(ray, out hit, 1000.0F))
            {
                cuboCol[i].gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            }
            else
            {
                cuboCol[i].gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.white);
            }
        }
    }
    public void ValorRotacion(float rotacion)
    {
        RotGlob = rotacion;
        ScrollRotacion(RotGlob, ZoomGlob, AltGlob);
    }
    public void ValorZoom(float zoom)
    {
        ZoomGlob = zoom;
        ScrollRotacion(RotGlob, ZoomGlob, AltGlob);
    }
    public void altura(float Alt)
    {
        AltGlob = Alt;
        ScrollRotacion(RotGlob, ZoomGlob,AltGlob);
    }
    void ScrollRotacion(float rotacion, float zoom, float altura)
    {
        float radSin = Mathf.Cos(rotacion * Mathf.PI / 180);
        float radCos = Mathf.Sin(rotacion * Mathf.PI / 180);
        int radio =100;
        CameraTrans.transform.position= new Vector3(radSin * radio, altura,(radCos * radio)+zoom);
        CameraTrans.transform.LookAt(new Vector3(0.0f, 0.0f, 125.0f));
    }
}
