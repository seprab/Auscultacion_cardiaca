using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Interaccion : MonoBehaviour {

    public List<Collider> cuboCol;
    public Transform CameraTrans;

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
    public void ScrollRotacion(float rotacion)
    {
        CameraTrans.position=new Vector3();
    }
}
