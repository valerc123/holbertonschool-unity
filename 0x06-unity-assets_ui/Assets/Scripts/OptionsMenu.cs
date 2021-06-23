using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
  public GameObject InvertToogle;
  public Toggle Toogle;
  private int scene;
  void Start()
  {
    scene = PlayerPrefs.GetInt("previousLevel");
    Toogle =  InvertToogle.GetComponent<Toggle>();
    Toogle.isOn = PlayerPrefs.GetInt("inverse") == 1 ? true : false;
  }
  void Update(){
    if(Toogle.isOn == true){
      PlayerPrefs.SetInt("inverse", 1);
      Debug.Log("inverse");
    }else{
      PlayerPrefs.SetInt("inverse", 0);
    }
  }
  public void Apply (){
    SceneManager.LoadScene(scene);
  }
}
