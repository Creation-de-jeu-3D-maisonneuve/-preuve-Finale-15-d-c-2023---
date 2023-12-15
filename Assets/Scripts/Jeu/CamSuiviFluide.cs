using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSuiviFluide : MonoBehaviour
{
    public Transform Cible; // la cible à suivre
    public Vector3 Distance; // Distance de suivi
    public float Amortissement; // délai d'ajustement de la position de la caméra
    public Vector3 AjustementFocus; // permet d'ajuster l'endroit où regarde la caméra


    //Script pour la caméra qui suit le personnage.
    
    void FixedUpdate()
    {
        Vector3 positionFinale = Cible.transform.TransformPoint(Distance);
        transform.position = Vector3.Lerp(transform.position, positionFinale, Amortissement);
        transform.LookAt(Cible.transform.position + AjustementFocus);
    }
}
