using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject InvertToogle;
    public Toggle Toogle;
    // Start is called before the first frame update
    //private int Inverted=0;

    void Start()
    {
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
      // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
       SceneManager.LoadScene("Level01");
    }
    
}
