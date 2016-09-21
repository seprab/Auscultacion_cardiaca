using UnityEngine;
using System.Collections;

public class Animacion : MonoBehaviour
{
    public RuntimeAnimatorController animSit;
    GameObject pacienteX;
    public void animar(GameObject paciente)
    {
        Debug.Log("Yo estoy entrando");
        paciente.GetComponent<Animator>().runtimeAnimatorController = animSit;
        pacienteX = paciente;
        //Animator sentado = paciente.GetComponent<Animator>();
        //sentado.runtimeAnimatorController = Resources.Load("Assets/animControl/H_B_obeso_contr") as RuntimeAnimatorController;
        //sentado.runtimeAnimatorController = animSit;
        Debug.Log(paciente);
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Borramos al mister ");
            pacienteX.SetActive(false);
        }
    }
}
