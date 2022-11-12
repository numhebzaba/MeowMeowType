using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Typer : MonoBehaviour
{
    public WordList wordList = null;
    public TMP_Text wordOutput = null;   
   
    private string remainWord = string.Empty;
    private string currentWord = string.Empty;

    void Start()
    {
        SetCurrentWord();
    }
    private void SetCurrentWord()
    {
        currentWord = wordList.getWord();
        SetRemainWord(currentWord);
    }
    private void SetRemainWord(string newString)
    {
        remainWord = newString;
        wordOutput.text = remainWord;
    }
    void Update()
    {
        CheckInput();
    }
    private void CheckInput()
    {
        if (Input.anyKeyDown)
        {
            string keyPressed = Input.inputString;

            if (keyPressed.Length == 1)
                EnterLetter(keyPressed);
        }
    }
    private void EnterLetter(string typedLetter)
    {
        if (IsCorrectLetter(typedLetter))
        {
            RemoveLetter();

            if(IsWordComplete())
                SetCurrentWord();
        }
    }
    private bool IsCorrectLetter(string letter)
    {
        return remainWord.IndexOf(letter)==0;
    }
    private void RemoveLetter()
    {
        string newString = remainWord.Remove(0,1);
        SetRemainWord(newString);
    }
    private bool IsWordComplete()
    {
        return remainWord.Length == 0;
    }
}
