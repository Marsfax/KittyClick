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
    [SerializeField] bool isfirst;
    // Start is called before the first frame update
    void Start()
    {
        // проблема с выключением кнопки
        //int money = PlayerPrefs.GetInt("money");
        int total_money = PlayerPrefs.GetInt("total_money");
        //isfirst = 0;
        //isfirst = PlayerPrefs.GetInt("isfirst", isfirst==0 ? 0:1 );
        
        //you = PlayerPrefs.GetInt("you");
        //isfirst = PlayerPrefs.GetInt("isfirst") == 1 ? firstAch.GetComponent<Button>().interactable = true : firstAch.GetComponent<Button>().interactable = false;
        firstAch.GetComponent<Button>().interactable = false;
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
       ;
        int money = PlayerPrefs.GetInt("money");//загрузить
        money += 10;
        PlayerPrefs.SetInt("money", money);//сохранить
        firstAch.GetComponent<Button>().interactable = false;


    } 
    public void Love()
    {
        txt.text = "I Love my babe! your Marsel...";
    }


    
   


}
