using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    

    public List<LetterScript> letterBoxes; // Fügen Sie LetterBox-Elemente hinzu

    void Start()
    {
        // Legen Sie die Buchstabenverfügbarkeit für jedes LetterBox-Element fest
        SetLetterAvailability();

        // Hier können Sie andere Initialisierungen vornehmen oder die Puzzle-Logik starten
    }

    void SetLetterAvailability()
    {
        // Beispiel: Legen Sie die Verfügbarkeit aller Buchstaben auf true fest
        foreach (var letterBox in letterBoxes)
        {
            for (int i = 0; i < 26; i++)
            {
                letterBox.letterAvailability[i] = true;
            }
        }

        // Hier können Sie die Verfügbarkeit basierend auf Ihren Regeln ändern
        // Beispiel: Legen Sie den Buchstaben 'A' auf false fest (nicht verfügbar)
        foreach (var letterBox in letterBoxes)
        {
            letterBox.letterAvailability['Z' - 'Z'] = false;
        }
    }
}
