using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    int score = 0;

private void Awake() {
    
    instance = this;
}

void Start()
{
score=PlayerPrefs.GetInt("Score");
scoreText.text = "Score : " + score.ToString();
}

public void inc_Score(){
    score += 1;
    scoreText.text = "Score : " + score.ToString();
    PlayerPrefs.SetInt("Score",score);
}

private void OnApplicationQuit() {

    PlayerPrefs.DeleteAll();
}

}
