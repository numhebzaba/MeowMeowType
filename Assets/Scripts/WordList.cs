using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WordList : MonoBehaviour
{
    private List<string> wordList = new List<string>()
    {
        "Test","word","DDAS"
    };
    private List<string> workingWords = new List<string>();

    private void Awake()
    {
        workingWords.AddRange(wordList);
        shuffle(workingWords);
        //ConvertToLower(workingWords);
        
    }
    private void shuffle(List<string> list)
    {
        for(int i = 0; i < list.Count; i++)
        {
            int random = Random.Range(i, list.Count);
            string temporary = list[i];

            list[i] = list[random];
            list[random] = temporary;
        }
    }
   
    private void ConvertToLower(List<string> list)
    {
        for(int i = 0; i< list.Count;i++)
            list[i] = list[i].ToLower();
    }
    public string getWord()
    {
        string newWord = string.Empty;

        if(workingWords.Count != 0)
        {
            newWord = workingWords.Last();
            workingWords.Remove(newWord);
        }

        return newWord;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
