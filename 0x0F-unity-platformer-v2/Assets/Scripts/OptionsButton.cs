using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class OptionsButton : MonoBehaviour
{
  private int scene;
  public void Options(){
    scene = SceneManager.GetActiveScene().buildIndex;
    PlayerPrefs.SetInt("previousLevel",scene);
    SceneManager.LoadScene("Options");
  }
}
