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
    public int total_money;
    private void Start()
    {
        money = PlayerPrefs.GetInt("money");
        total_money = PlayerPrefs.GetInt("total_money");
        levelScore = PlayerPrefs.GetInt("levelScore");
        moneyText.text = money.ToString();
        scoreText.text = levelScore.ToString();
    }
    public void ButtonClick()
    {
        money++;
        total_money++;
        if (money >= up)
        {
            ScoreUp();
            up *= 2;
        }
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("total_money", total_money);
        
    }
    public void ToUpping()
    {
        SceneManager.LoadScene(1);
    }
    public void ScoreUp()
    {
        levelScore++;
    }
    public void ClereBut()//уровень при сбрасывании увеличивваается впоследующем на 20
        //из-за умножения на 2
    {
        money = 0;
        PlayerPrefs.SetInt("money", money);
        levelScore = 1;
        up = 10;
        PlayerPrefs.SetInt("levelScore", levelScore);
        
    }    
    
   
    void Update()
    {
        moneyText.text = money.ToString();
        scoreText.text = levelScore.ToString();
        
    }
}
