using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Achivestotal : MonoBehaviour
{
    public int total_money;
    public Text txt;
    //int you=0;
    [SerializeField] Button firstAch;
    [SerializeField] bool isfirst ;
    // Start is called before the first frame update
    void Start()
    {
        // проблема с выключением кнопки
        //int money = PlayerPrefs.GetInt("money");
        total_money = PlayerPrefs.GetInt("total_money");
        //isfirst = 0;
        //isfirst = PlayerPrefs.GetInt("isfirst", isfirst==0 ? 0:1 );

        //you = PlayerPrefs.GetInt("you");
        //isfirst = PlayerPrefs.GetInt("isfirst") == 1 ? firstAch.GetComponent<Button>().interactable = true : firstAch.GetComponent<Button>().interactable = false;
        //isfirst = PlayerPrefs.GetInt("isfirst") == 1 ? true : false;
        if (PlayerPrefs.GetInt("isfirst") == 1)
        {
            isfirst = true;
        }
        else
        {
            isfirst = false;
        }
        if (total_money >= 10 && !isfirst)
        { 
            firstAch.interactable =true;
            
        }
        else
        {
            firstAch.interactable = false;
        }
    }
    public void LoMenu()
    {
        //PlayerPrefs.SetInt("you", you);
        SceneManager.LoadScene(0);
    }
    public void GetFirst()
    {   
        int money = PlayerPrefs.GetInt("money");//загрузить
        money += 10;
        PlayerPrefs.SetInt("money", money);//сохранить
        isfirst = true;
        PlayerPrefs.SetInt("isfirst", isfirst ? 1 : 0);
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("isfirst") == 1)
        {
            isfirst = true;
        }
        else
        {
            isfirst = false;
        }
    }







}
