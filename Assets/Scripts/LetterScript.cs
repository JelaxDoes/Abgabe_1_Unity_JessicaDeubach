using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LetterScript : MonoBehaviour
{
    private Image LetterBox;
    public bool[] letterAvailability = new bool[26];
    private TextMeshProUGUI LetterText;

    private void Start()
    {
        LetterBox = GetComponent<Image>();
        LetterText = GetComponentInChildren<TextMeshProUGUI>();


        char randomLetter = GetRandomAvailableLetter();
        SetLetter(randomLetter);
    }

    private void SetLetter(char letter)
    {
        LetterText.text = letter.ToString();
    }

    private char GetRandomAvailableLetter()
    {
        
        List<char> availableLetters = new List<char>();
        for (int i = 0; i < letterAvailability.Length; i++)
        {
            if (letterAvailability[i])
            {
                availableLetters.Add((char)('A' + i));
            }
        }

        if (availableLetters.Count > 0)
        {
            return availableLetters[Random.Range(0, availableLetters.Count)];
        }
        else
        {
            
            return 'S';
        }
    }
    }
