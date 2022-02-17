using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Achivestotal : MonoBehaviour
{
    //public int total_money;
    
    int koin = 0;
    int koint = 0;
    int koinh = 0;
    public Text kointext;
    //int levelScore;
    [SerializeField] Button firstAch;
    [SerializeField] Button thisttAch;
    [SerializeField] Button treeAch;
    

    void Start()
    {
      
       
    }
    public void LoMenu()
    {
        
        SceneManager.LoadScene(0);
    }
    public void GetFirst()
    {   
        int money = PlayerPrefs.GetInt("money");//���������
        money += 10;
        PlayerPrefs.SetInt("money", money);//���������

        
        int koin = 1;
        PlayerPrefs.SetInt("koin", koin);
        
    }
    public void GetTwesdy()
    {
        int money = PlayerPrefs.GetInt("money");//���������
        money += 100;
        PlayerPrefs.SetInt("money", money);//���������

        
        int koint = 1;
        PlayerPrefs.SetInt("koint", koint);
    }
    public void GetThree()
    {
        int money = PlayerPrefs.GetInt("money");//���������
        money += 1000;
        PlayerPrefs.SetInt("money", money);//���������

        
        int koinh = 1;
        PlayerPrefs.SetInt("koinh", koinh);
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
        int koint = PlayerPrefs.GetInt("koint");
        int koinh = PlayerPrefs.GetInt("koinh");
        kointext.text = koin.ToString();
        if (money >= 10 && koin ==0 )
        {
            firstAch.interactable = true;

        }
        else
        {
            firstAch.interactable = false;
        }
        if (money >= 100 && koint ==0 )
        {
            thisttAch.interactable = true;

        }
        else
        {
            thisttAch.interactable = false;
        }
        if (money >= 1000 && koinh ==0 )
        {
            treeAch.interactable = true;

        }
        else
        {
            treeAch.interactable = false;
        }
    }








}
