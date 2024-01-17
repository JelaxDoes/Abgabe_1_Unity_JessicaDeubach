using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    

    public List<LetterScript> letterBoxes; 

    void Start()
    {
        
        SetLetterAvailability();

        
    }

    void SetLetterAvailability()
    {
        
        foreach (var letterBox in letterBoxes)
        {
            for (int i = 0; i < 26; i++)
            {
                letterBox.letterAvailability[i] = true;
            }
        }

        
        foreach (var letterBox in letterBoxes)
        {
            letterBox.letterAvailability['A' - 'A'] = false;
        }
    }
}
