using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ChargementPartie : MonoBehaviour
{
   
    //Fonction appelée lorqu'on clique sur le bouton pour commencer une partie
    public void DetectionClic()
    {
        GetComponent<AudioSource>().Play(); // lecture du son ho ho ho
        Invoke("ChargementJeu", 4.5f); // Appelle la fonction pour changer de scène après un délai de 4,5 secondes
    }


    // Fonction pour le changement de scène.
    void ChargementJeu()
    {
       SceneManager.LoadScene("Jeu");
    }

}
