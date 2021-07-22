using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
# if UNITY_EDITOR
using UnityEditor;
#endif



public class PauseMenu : MonoBehaviour
{
  public AudioMixerSnapshot paused;
  public AudioMixerSnapshot unpaused;

  public GameObject canvas;
  public GameObject player;
  public Timer script;
  private int scene;
  void Start (){
    script = player.GetComponent<Timer>();
  }
  void Update (){
    if (Input.GetKeyDown(KeyCode.Escape)){
      Pause();
    }
  }

  void TransitionTo (){

  }



  public void Pause(){
    script.enabled = false;
    canvas.SetActive(true);
    Time.timeScale = Time.timeScale == 0 ? 1 : 0;
    Lowpass();
  }

  void Lowpass(){
    if (Time.timeScale == 0){
      paused.TransitionTo(.01f);
    }else{
      unpaused.TransitionTo(.01f);
    }
  } 
  public void Resume(){
    script.enabled = true;
    canvas.SetActive(false);
  }

  public void Restart(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
  public void MainMenu(){
    SceneManager.LoadScene("MainMenu");
  }

  public void Options(){
    scene = SceneManager.GetActiveScene().buildIndex;
    PlayerPrefs.SetInt("previousLevel",scene);
    SceneManager.LoadScene("Options");
    Debug.Log ("scene"+scene);
  }
}       
