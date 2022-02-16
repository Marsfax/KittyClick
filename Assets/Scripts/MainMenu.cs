using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    [SerializeField] int money;
    public Text moneyText;
    [SerializeField] int levelScore;
    public Text scoreText;
    private int up = 10;
    
    private void Start()
    {
        
        money = PlayerPrefs.GetInt("money");
        moneyText.text = money.ToString();
        
        levelScore = PlayerPrefs.GetInt("levelScore");
        scoreText.text = levelScore.ToString();
       
        
    }
    public void ButtonClick()
    {
        //pri dostigenii yvelichivaet uroven
        money++;
        
        if (money >= up)
        {
            ScoreUp();
            up *= 2;
        }
        PlayerPrefs.SetInt("money", money);
        
        
    }
    public void ToUpping()
    {
        SceneManager.LoadScene(1);
    }
    public void ScoreUp()
    {
        levelScore++;
    }
    public void ClereBut()
    {
        money = 0;
        PlayerPrefs.SetInt("money", money);
        levelScore = 1;
        up = 10;
        PlayerPrefs.SetInt("levelScore", levelScore);
        int koin = PlayerPrefs.GetInt("koin");
        koin = 0;
        PlayerPrefs.SetInt("koin", koin);

    }    
    
   
    void Update()
    {
        PlayerPrefs.SetInt("levelScore", levelScore);
        moneyText.text = money.ToString();
        scoreText.text = levelScore.ToString();
        
    }
}
