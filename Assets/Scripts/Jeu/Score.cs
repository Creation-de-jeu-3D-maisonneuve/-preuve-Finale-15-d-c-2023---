using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI TextUI;

    private int TrouverParSanta;
    private int TrouverParVoleur1;
    private int TrouverParVoleur2;

    // Start is called before the first frame update
    void Start()
    {
        MiseAJourText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MiseAJourText()
    {
        TextUI.text = $"{TrouverParSanta}";
    }
}
