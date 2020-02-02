using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

/*

rechauffement reffroidissement 50 et-50 (voir la doc)
blink 4 cartes
-100 -> ecran de fin
implementé rareté (voir doc)

*/

public class Variables : MonoBehaviour
{

    private float score = 0;
    public TextMeshProUGUI text_score;
    public TextMeshProUGUI text_event;
    private int parasite = 500;
    private int parasite_mute = 0;
    public TextMeshProUGUI text_parasite;
    public TextMeshProUGUI text_parasite_mute;
    public Image logoRandom;
    private float timeReproduction = 5.0f;
     

     
     void Update()
     {
         timeReproduction -= Time.deltaTime;
         if(timeReproduction < 0)
         {
             reproduce();
             timeReproduction=5.0f;
         }
     }
     public void reproduce(){
        //faire ici la reproduction (à recoder)
        parasite_mute+=(int)(parasite_mute*0.1f);
        //faire ici la reproduction (à recoder)
        parasite+=(int)(parasite*0.1f);
        mutation(0.005f);
        die(1);
        eat();
     }
     public void mutation(float probabilite){
        parasite_mute+=(int)(parasite*probabilite);
        parasite-=(int)(parasite*probabilite);
     }
     public void die(int time){
        parasite_mute-= (int)(parasite_mute*0.03f*time);
        parasite-=(int)(parasite*0.001f*time);
        if(parasite_mute<0) parasite_mute=0;
        if(parasite<0) parasite=0;
        text_parasite.text = "parasite:"+this.parasite;
        text_parasite_mute.text = "parasite mute:"+this.parasite_mute;
     }
     public void eat(){
        float perte=(parasite_mute*0.03f)+(parasite*0.01f);
        addToScore(-perte);
     }
    public void addToScore(float score)
    {
        this.score += score;
        if(this.score>=200){
            text_score.text = "Gagné";
        }else if(this.score<=-100){
            text_score.text = "Perdu";
        }else text_score.text = "Score: " + this.score;
    }
    public void mutationEnd()
    {
       text_score.text = "Un nouveau parasite a été créé.\n Vous avez perdu!";
    }
    public float getScore()
    {
        return this.score;
    }

    public void addToParasite(int parasite)
    {
        this.parasite += parasite;
        text_parasite.text = "Parasite: " + this.parasite;
    }

    public int getParasite()
    {
        return this.parasite;
    }

    private void Start()
    {
        text_score.text = "Score: " + score.ToString();
        text_parasite.text = "Parasite: " + parasite.ToString();
        Color temp = logoRandom.color;
        temp.a=0f;
        logoRandom.color = temp;
    }
}
