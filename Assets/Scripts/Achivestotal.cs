using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Achivestotal : MonoBehaviour
{
    
    // koint and koinh no value is assigned "0", assigned automatically "2" 
    [SerializeField] int koin = 0;
    [SerializeField] int koint = 2;
    [SerializeField] int koinh = 2;

    public Text kointext;
    public Text kointextb;
    public Text kointextj;
    
    [SerializeField] Button firstAch;
    [SerializeField] Button thisttAch;
    [SerializeField] Button treeAch;
    
    public void Cindition (int a, int b, int c, int d, Button but)
    {
        int money = PlayerPrefs.GetInt("a");
        PlayerPrefs.SetInt("a", a);
       
        if (a >= d && b == c)
        {
            but.interactable = true;

        }
        else
        {
            but.interactable = false;
        } 
    }
    void Start()
    {
 
        
        int koin = PlayerPrefs.GetInt("koin");
        int koint = PlayerPrefs.GetInt("koint");
        int koinh = PlayerPrefs.GetInt("koinh");
        if (koin == 1)
        {
            StartCoroutine(IdleFarm());
        }


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
        StartCoroutine(IdleFarm());
    }
    public void GetTwesdy()
    {
        int money = PlayerPrefs.GetInt("money");//���������
        money += 100;
        PlayerPrefs.SetInt("money", money);//���������

        
        int koint = 3;
        PlayerPrefs.SetInt("koint", koint);
    }
    public void GetThree()
    {
        int money = PlayerPrefs.GetInt("money");//���������
        money += 1000;
        PlayerPrefs.SetInt("money", money);//���������

        
        int koinh = 3;
        PlayerPrefs.SetInt("koinh", koinh);
    }
   
    IEnumerator IdleFarm()
    {

        
         yield return new WaitForSeconds(1f);

         int money = PlayerPrefs.GetInt("money");
         money++;
         Debug.Log(money);
         PlayerPrefs.SetInt("money", money);
         StartCoroutine(IdleFarm());
  
    }
  
    private void Update()
    {
        int money = PlayerPrefs.GetInt("money");
        int koin = PlayerPrefs.GetInt("koin");
        int koint = PlayerPrefs.GetInt("koint");
        int koinh = PlayerPrefs.GetInt("koinh");
        kointext.text = koin.ToString();
        kointextb.text = koint.ToString();
        kointextj.text = koinh.ToString();

        /*if (money >= 10 && koin ==0 )
        {
            firstAch.interactable = true;

        }
        else
        {
            firstAch.interactable = false;
        }*/
        Cindition(money, koin, 0, 10, firstAch);
        Cindition(money, koint, 2, 30, thisttAch);
        Cindition(money, koinh, 2, 60, treeAch);

       /* if (money >= 30 && koint ==1 )
        {
            thisttAch.interactable = true;

        }
        else
        {
            thisttAch.interactable = false;
        }
        if (money >= 60 && koinh ==1 )
        {
            treeAch.interactable = true;

        }
        else
        {
            treeAch.interactable = false;
        }*/
    }








}
