
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LetterScript : MonoBehaviour, IPointerClickHandler
{
    private Image LetterBox;
    public bool[] letterAvailability = new bool[26];
    public bool isCorrect = false;
    public TextMeshProUGUI LetterText;
    public AudioClip clickSound;
    private AudioSource audioSource;





    public LetterScript GetLetterScript()
    {
        return this;
    }
    private void Start()
    {

        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        audioSource.clip = clickSound;

        LetterBox = GetComponentInChildren<Image>();  // hatte es sehr lange nur als GetComponent und nicht ComponentChild, deswegen bin ich ewig nicht weitergekommen
        LetterText = GetComponentInChildren<TextMeshProUGUI>();// festlegen was der Text ist


        char randomLetter = GetRandomAvailableLetter(); // RandomLetter Funktion ansprechen
        SetLetter(randomLetter);
    }

    public void ReloadScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    public void OnPointerClick(PointerEventData eventData)
    {

        audioSource.Play(); // wenn angeklickt spiel sound
        Debug.Log("LetterImage wurde angeklickt!");// wenn angeklickt debug das
        LetterScript letterScript = GetLetterScript();  // irgendwie hat das bei mir nicht geklappt ich glaub ich hab irgendwas im inspector falsch mit dem
        //eventtrigger component
        if (letterScript != null)
        {

            if (letterScript.isCorrect) // wenn buchstabe correct ist ...
            {

                SetCorrectColor();
            }
            else // sonst
            {
                SetIncorrectColor();
                ReloadScene();
            }
        }
          

    }

        private void SetLetter(char letter)
    {
        LetterText.text = letter.ToString();  // Text
        
    }


    private void SetCorrectColor()
    {
       
        LetterBox.color = Color.green; // correct letter auf grün
    }

    private void SetIncorrectColor()
    {
        
        LetterBox.color = Color.red; // falscher letter auf rot
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
