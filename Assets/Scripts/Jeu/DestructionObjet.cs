using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionObjet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //si jamais l'objet se retrouve plus bas que la zone de jeu, on s'assure de le détruire.
        if (transform.position.y < 0f) Destroy(gameObject);
    }
}
