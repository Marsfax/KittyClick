using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Achivestotal : MonoBehaviour
{
    
    // koint and koinh no value is assigned "0", assigned automatically "2" 
    [SerializeField] int koin = 0;
    [SerializeField] int koint = 0;
    [SerializeField] int koinh = 0;

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
        if (koint == 1)
        {
            StartCoroutine(IdleFarmt());
        }
        if (koinh == 1)
        {
            StartCoroutine(IdleFarmh());
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

        int koint = 1;
        PlayerPrefs.SetInt("koint", koint);
        StartCoroutine(IdleFarmt());
    }
    public void GetThree()
    {
        int money = PlayerPrefs.GetInt("money");//���������
        money += 1000;
        PlayerPrefs.SetInt("money", money);//���������

        int koinh = 1;
        PlayerPrefs.SetInt("koinh", koinh);
        StartCoroutine(IdleFarmh());
    }
   
    IEnumerator IdleFarm()
    {

         yield return new WaitForSeconds(1f);

         int money = PlayerPrefs.GetInt("money");
         money += 1;
         Debug.Log(money);
         PlayerPrefs.SetInt("money", money);
         StartCoroutine(IdleFarm());
  
    }
    IEnumerator IdleFarmt()
    {

        yield return new WaitForSeconds(1f);

        int money = PlayerPrefs.GetInt("money");
        money += 100;
        Debug.Log(money);
        PlayerPrefs.SetInt("money", money);
        StartCoroutine(IdleFarmt());

    }
    IEnumerator IdleFarmh()
    {

        yield return new WaitForSeconds(1f);

        int money = PlayerPrefs.GetInt("money");
        money += 1000;
        Debug.Log(money);
        PlayerPrefs.SetInt("money", money);
        StartCoroutine(IdleFarmh());

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

        Cindition(money, koin, 0, 10, firstAch);
        Cindition(money, koint, 0, 100, thisttAch);
        Cindition(money, koinh, 0, 1000, treeAch);

    }








}
