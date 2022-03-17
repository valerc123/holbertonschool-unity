using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bottoncontroller : MonoBehaviour
{
    
    public Image   ButtonImage;
    public Sprite[]   Images;

    void start (){
      //ButtonImage = GetComponent<Image>();
    }
    public void highlight(int color)
    {
        ButtonImage.sprite = Images[color];
    }
    public void unhighlight(int color)
    {
        ButtonImage.sprite = Images[color];
    }
   public void click(int color)
    {
        ButtonImage.sprite = Images[color];
    }
 
}
