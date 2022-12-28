using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SubjectChoice_Buttons : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Panel1;
    public GameObject Panel2;


    public void ButtonGeneral1() {
    Panel1.SetActive(false);
    Panel.SetActive(true);
   }
   public void ButtonGeneral2() {
    Panel1.SetActive(false);
    Panel2.SetActive(true);
   }

   public void ButtonLesson1() {
    
    SceneManager.LoadScene(3);
   }
   public void ButtonQuestion1() {
    SceneManager.LoadScene(2);
   }

   public void ButtonReturn()
   {
        Panel1.SetActive(false);
        Panel.SetActive(false);
        Panel2.SetActive(false);
    }
   
}
