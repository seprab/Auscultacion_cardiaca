using UnityEngine;
using System.Collections;

public class Animacion : MonoBehaviour
{
    public RuntimeAnimatorController animSit;

    public void animar(GameObject paciente)
    {
        Animator sentado = paciente.GetComponent<Animator>();
        //sentado.runtimeAnimatorController = Resources.Load("Assets/animControl/H_B_obeso_contr") as RuntimeAnimatorController;
        sentado.runtimeAnimatorController = animSit;
    }
}
