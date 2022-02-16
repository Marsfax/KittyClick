using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Achivestotal : MonoBehaviour
{
    //public int total_money;
    
    int koin = 1;
    public Text kointext;
    //int levelScore;
    [SerializeField] Button firstAch;

    void Start()
    {
      
       
    }
    public void LoMenu()
    {
        
        SceneManager.LoadScene(0);
    }
    public void GetFirst()
    {   
        int money = PlayerPrefs.GetInt("money");//загрузить
        money += 10;
        PlayerPrefs.SetInt("money", money);//сохранить

        
        int koin = 1;
        PlayerPrefs.SetInt("koin", koin);
        
    }
    /*public void ClearFirst()
    {
        int koin = PlayerPrefs.GetInt("koin");
        koin = 0;
        PlayerPrefs.SetInt("koin", koin);
    }*/
    private void Update()
    {
        int money = PlayerPrefs.GetInt("money");
        int koin = PlayerPrefs.GetInt("koin");
        kointext.text = koin.ToString();
        if (money >= 10 && koin ==0 )
        {
            firstAch.interactable = true;

        }
        else
        {
            firstAch.interactable = false;
        }
    }








}
