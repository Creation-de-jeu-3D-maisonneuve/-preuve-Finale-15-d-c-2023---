using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionFinale : MonoBehaviour
{
    
    private GameObject laMusique;
    private float volumeInitialMusique;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None; // désactive le lock du curseur
        
        // On récupère l'objet musique pour diminuer temporairement son volume
        laMusique = GameObject.FindGameObjectWithTag("musique");
        // On s'assure qu'il y a bien un objet avec le tag musique avant de faire le reste
        if(laMusique)
        {
            //on garde en mémoire la volume initiale de la musique.
            volumeInitialMusique = laMusique.GetComponent<AudioSource>().volume;
            //on met le volunme à 0
            laMusique.GetComponent<AudioSource>().volume = 0f;
            // on appelel une coroutine pour faire un fadeIn de la musique
            StartCoroutine(FadeIn());
        }
       
    }

    
    IEnumerator FadeIn()
    {
        //On attend 7 secondes avant d'augmenter le volume de la musique. Le temps que le son de la victoire puisse jouer
        yield return new WaitForSeconds(7);

        //boucle qui permet de faire un fadeIn de la musique. Avec une pause de 0.1 secondes entre chaque itération.
        while(laMusique.GetComponent<AudioSource>().volume < volumeInitialMusique)
        {
            laMusique.GetComponent<AudioSource>().volume += 0.01f;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
