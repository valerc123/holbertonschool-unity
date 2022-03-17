using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
  private int scene;
  void Start()
  {
    scene = PlayerPrefs.GetInt("previousLevel");
  }
  public void Back (){
    SceneManager.LoadScene(scene);
  }
}
