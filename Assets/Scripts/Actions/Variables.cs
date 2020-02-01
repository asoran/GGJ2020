using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Variables : MonoBehaviour
{

    private int score = 0;
    public TextMeshProUGUI text_score;
    private int parasite = 500;
    public TextMeshProUGUI text_parasite;

    public void addToScore(int score)
    {
        this.score += score;
        text_score.text = "Score: " + score.ToString();
    }
    public int getScore()
    {
        return this.score;
    }

    public void addToParasite(int parasite)
    {
        this.parasite += parasite;
        text_parasite.text = "Parasite: " + parasite.ToString();
    }

    public int getParasite(int parasite)
    {
        return this.parasite;
    }

    private void Start()
    {
        text_score.text = "Score: " + score.ToString();
        text_parasite.text = "Parasite: " + parasite.ToString();
    }
}
