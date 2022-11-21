using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListLetters
{
    private string name;
    private float TimeAverage;
    private float NewTime;
    private int Correct;
    private int Incorrect;
    private float accuracy;
    private int Count;

    public ListLetters(string name, float TimeAverage, float NewTime, int Count)
    {
        this.name = name;
        this.TimeAverage = TimeAverage;
        this.NewTime = NewTime;
        this.Correct = 0;
        this.Incorrect = 0;
        this.Count = Count;
    }

    public string GetAllData
    {
        get { return this.name + " Correct: " + this.Correct + " Incorrect: " + this.Incorrect; }
    }

    public string getName
    {
        get { return name; }
    }

    public int getCount
    {
        get { return Count; }
    }

    public int GetWrongData
    {
        get { return Incorrect; }
    }

    public float GetAccuracy
    {
        get { return accuracy; }
    }

    public void UpdateWrongLetterData()
    {
        this.Incorrect += 1;
    }

    public void UpdateData()
    {
        this.Correct += 1;
        this.Count += 1;
    }

}
