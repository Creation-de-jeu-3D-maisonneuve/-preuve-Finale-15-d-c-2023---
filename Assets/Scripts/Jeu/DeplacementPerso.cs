using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementPerso : MonoBehaviour
{
    public float vitesse; // vitesse de déplacement du perso
    public float vitesseTourne; // vitesse de rotation du perso
    public AudioClip sonObjet; // son lorsque le perso ramasse un objet.
    public bool rotationSouris = true; // true si c'est la souris qui gère la rotation du perso. False si c'est le clavier
    public bool curseurInvisible; // est-ce qu'on cache le curseur.

    private CharacterController controleur;



    void Start()
    {
        if(curseurInvisible)Cursor.lockState =  CursorLockMode.Locked;
        controleur = GetComponent<CharacterController>();
    }

    
    void FixedUpdate()
    {
        // Déplacement du personnage
        //on va chercher les valeurs de l'axe vertical et horizontal.
        Vector3 valeursInputs = Vector3.zero;
        valeursInputs.z = Input.GetAxis("Vertical");
        valeursInputs.x = Input.GetAxis("Horizontal");
        //Si la rotation se fait avec le clavier, on désactive le déplacement gauche/droite
        if (!rotationSouris) valeursInputs.x = 0f;

        // On transforme le déplacement pour obtenir le résultat selon les axes du monde
        Vector3 deplacement = transform.TransformDirection(valeursInputs * vitesse);
        //on applique le déplcement
        controleur.SimpleMove(deplacement * Time.deltaTime);
           
        
       // Gestion de la rotation du personnage
        float tourne;
        // tourner le personnage en fonction du déplacement horizontal de la souris
        if (rotationSouris)
        {
            tourne = Input.GetAxis("Mouse X") * vitesseTourne * Time.deltaTime;
        }
        // tourner le personnage selon les flèches du clavier
        else
        {
            tourne = Input.GetAxis("Horizontal") * vitesseTourne * Time.deltaTime;
        }
        // on applique la rotation
        transform.Rotate(0f, tourne * vitesseTourne * Time.deltaTime, 0f);


    }
    // Détection de collision. Avec le component CharacterController, il faut utiliser la fonction OnControllerColliderHit
    private void OnTriggerEnter(Collider infosCollision)
    {
        //si on touche un cadeau ou une canne... On détruit l'objet
        if (infosCollision.gameObject.tag == "cadeau" || infosCollision.gameObject.tag == "canne")
        {
            Destroy(infosCollision.gameObject);
            GetComponent<AudioSource>().PlayOneShot(sonObjet);
            infosCollision.gameObject.tag = "Untagged";
        }
    }

  
}
