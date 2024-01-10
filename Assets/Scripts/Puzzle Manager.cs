using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    

    public List<LetterScript> letterBoxes; // F�gen Sie LetterBox-Elemente hinzu

    void Start()
    {
        // Legen Sie die Buchstabenverf�gbarkeit f�r jedes LetterBox-Element fest
        SetLetterAvailability();

        // Hier k�nnen Sie andere Initialisierungen vornehmen oder die Puzzle-Logik starten
    }

    void SetLetterAvailability()
    {
        // Beispiel: Legen Sie die Verf�gbarkeit aller Buchstaben auf true fest
        foreach (var letterBox in letterBoxes)
        {
            for (int i = 0; i < 26; i++)
            {
                letterBox.letterAvailability[i] = true;
            }
        }

        // Hier k�nnen Sie die Verf�gbarkeit basierend auf Ihren Regeln �ndern
        // Beispiel: Legen Sie den Buchstaben 'A' auf false fest (nicht verf�gbar)
        foreach (var letterBox in letterBoxes)
        {
            letterBox.letterAvailability['Z' - 'Z'] = false;
        }
    }
}
