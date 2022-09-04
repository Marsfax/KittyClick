using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoreScene : MonoBehaviour
{
   
    public Sprite pic1;
    public Sprite pic2;//zamenit sprite na image

    public Image im;
    void Start()
    {
        im = GetComponent<Image>();
        im.sprite = pic1;
    }

    public void oclickk()
    {
        if (im.sprite == pic1)
        {
            im.sprite = pic2;
            return;
        }

        else if (im.sprite == pic2)
        {
            im.sprite = pic1;
            return;
        }
    }
   
}
