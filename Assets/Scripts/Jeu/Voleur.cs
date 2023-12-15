using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Voleur : MonoBehaviour
{
   
    public AudioClip sonObjet; //Son qui sera déclenché lorsque le voleur touche un objet.

    // variables utilisées dans la fonction TrouveUneCible() --> voir plus bas
    public GameObject ObjetCible;
    public GameObject[] lesObjets;

    //public GameObject objetsInteractifs;

    void Start()
    {
        
        
    }

   
    void Update()
    {
        //GetComponent<NavMeshAgent>().SetDestination(lesObjets);
        GetComponent<NavMeshAgent>().SetDestination(ObjetCible.transform.position);
    }

    //----------------------------------------------------------------------------------------------
    // Détection de collision. 
    void OnTriggerEnter(Collider infosCollision)
    {
        Update();
        if (infosCollision.gameObject.tag == "cadeau" || infosCollision.gameObject.tag == "canne")
        {
            Destroy(infosCollision.gameObject);
            GetComponent<AudioSource>().PlayOneShot(sonObjet);            
        }
    }
    //----------------------------------------------------------------------------------------------


    //----------------------------------------------------------------------------------------------
    //Appeler cette fonction pour trouver une cible à atteindre pour les voleurs.
    // Fonction à compléter
    void TrouveUneCible()
    {
        // Pour trouver un objet à partir de son tag...
        // si un objet est trouvé, il sera envoyé dans la variable. Sinon la variable sera null.
        ObjetCible = GameObject.FindGameObjectWithTag("cadeau");

        // Autre option qui permet de trouver TOUS les objets qui possèdent un tag particulier. À utiliser avec un tableau C#
        // Variable publique (déclarée dans le haut du script) pour la voir dans l'inspecteur.
        lesObjets = GameObject.FindGameObjectsWithTag("cadeau");

        // Pour savoir combien d'objets ont été récupérés dans le tableau --> lesObjets.Length;
        //lesObjets.Length;

        // C'est à vous de compléter à partir de là...
        

    }
    //----------------------------------------------------------------------------------------------



}
