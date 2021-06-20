using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public GameObject canvas;
    public GameObject player;
    public Timer script;
    // Start is called before the first frame update
    void Start (){
        script = player.GetComponent<Timer>();
    }
    void Update (){
        if (Input.GetKeyDown(KeyCode.Escape)){
            Pause();
        }
    }
    public void Pause(){
        script.enabled = false;
        canvas.SetActive(true);
    }

    public void Resume(){
        script.enabled = true;
        canvas.SetActive(false);
    }

    public void Restart(){
      SceneManager.LoadScene("Level01");
    }
    public void MainMenu(){
      SceneManager.LoadScene("MainMenu");
    }

    public void Options(){
      SceneManager.LoadScene("Options");
    }
}
