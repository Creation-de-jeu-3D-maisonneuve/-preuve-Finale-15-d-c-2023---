using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SauvegarderElements : MonoBehaviour
{
    public GameObject musique;
    public GameObject ParticulesNeige;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(musique);
        DontDestroyOnLoad(ParticulesNeige);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
