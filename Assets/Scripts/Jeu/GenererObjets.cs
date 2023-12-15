using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenererObjets : MonoBehaviour
{
    public GameObject cadeau1;
    public GameObject cadeau2;
    public GameObject canne;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Cadeau1", 1f, Random.Range(1,3));
        InvokeRepeating("Cadeau2", 1f, Random.Range(1,3));
        InvokeRepeating("Canne", 1f, Random.Range(1,3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Cadeau1()
    {
        //cadeau1 = Vector3(Random.Range(2.5f, 55.9f), 0, Random.Range(2.9f, 57.8f));
        GameObject clone1 = Instantiate(cadeau1);
        clone1.SetActive(true);
    }
    void Cadeau2()
    {
        GameObject clone2 = Instantiate(cadeau2);
        clone2.SetActive(true);
    }
    void Canne()
    {
        GameObject clone3 = Instantiate(canne);
        clone3.SetActive(true);
    }
}
