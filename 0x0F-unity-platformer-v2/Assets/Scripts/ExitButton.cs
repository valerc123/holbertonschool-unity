using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    public void Exit (){
        //UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("Exited");
        Application.Quit();
    }
}
