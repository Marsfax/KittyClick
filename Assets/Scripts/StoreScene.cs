using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoreScene : MonoBehaviour
{
    
    public Sprite Oneimage;
    public Sprite Twoimage;
    [SerializeField] int icona;
    [SerializeField] int money;
    //PlayerPrefs.SetInt("money", money);
    [SerializeField] Button firstIcon;

    void Start()
    {
        icona = 0;
        PlayerPrefs.SetInt("icona", icona);

    }
  
    public void LoMenu()
    {   
        SceneManager.LoadScene(0);
    }
    //public void LoadIcon()
   // {
       // Oneimage.GetComponent<Sprite>(Twoimage);

   // }
    void Update()
    {
        PlayerPrefs.SetInt("money", money);
        if (money >= 10 && icona == 0)
        {
            firstIcon.interactable = true;

        }
        else
        {
            firstIcon.interactable = false;
        }
    }
    /*void imageUp()
    {
        var Upping3 = 
    }*/
}
