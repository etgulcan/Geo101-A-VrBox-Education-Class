using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestionCheck : MonoBehaviour
{

    public GameObject q1;
    public GameObject q2;

    void Start()
{

}

    public void answer_correct()
    {
        q2.SetActive(true);
        q1.SetActive(false);
        ScoreManager.instance.inc_Score();

    
}

}