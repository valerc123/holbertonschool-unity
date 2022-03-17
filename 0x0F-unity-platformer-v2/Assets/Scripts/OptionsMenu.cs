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
  public Slider soundSlider;
  public Slider soundSliderSFX;
  public float soundSliderValueSFX;
  public float soundSliderValue;
  private float volumbg;
  private float volumbgSFX;
  void Start()
  {
    soundSliderValue = 0;
    scene = PlayerPrefs.GetInt("previousLevel");
    Toogle =  InvertToogle.GetComponent<Toggle>();
    Toogle.isOn = PlayerPrefs.GetInt("inverse") == 1 ? true : false;
    volumbg = PlayerPrefs.GetFloat("bgsoundvolum");
    soundSlider.value = volumbg;

    volumbgSFX = PlayerPrefs.GetFloat("SFXsoundVolum");
    soundSliderSFX.value = volumbgSFX;
  }
  void Update(){
    soundSliderValue = soundSlider.value;
    PlayerPrefs.SetFloat("backgroundSound", soundSliderValue);

    soundSliderValueSFX = soundSliderSFX.value;
    PlayerPrefs.SetFloat("SFXsound", soundSliderValueSFX);

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
