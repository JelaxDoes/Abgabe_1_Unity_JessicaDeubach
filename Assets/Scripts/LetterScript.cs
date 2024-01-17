
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class LetterScript : MonoBehaviour, IPointerClickHandler
{
    private Image LetterBox;
    public bool[] letterAvailability = new bool[26];
    public bool isCorrect = false;
    public TextMeshProUGUI LetterText;




    public LetterScript GetLetterScript()
    {
        return this;
    }
    private void Start()
    {
        LetterBox = GetComponent<Image>();
        LetterText = GetComponentInChildren<TextMeshProUGUI>();


        char randomLetter = GetRandomAvailableLetter();
        SetLetter(randomLetter);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        LetterScript letterScript = GetLetterScript();
        if (letterScript != null)
        {

            if (letterScript.isCorrect)
            {

                SetCorrectColor();
            }
            else
            {
                SetIncorrectColor();
            }
        }
          

    }

        private void SetLetter(char letter)
    {
        LetterText.text = letter.ToString();
        
    }


    private void SetCorrectColor()
    {
       
        LetterBox.color = Color.green;
    }

    private void SetIncorrectColor()
    {
        
        LetterBox.color = Color.red;
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
