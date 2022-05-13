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
    public Text ScoreTextArch;
    private int up = 20;
    
    private void Start()
    {
        up = PlayerPrefs.GetInt("up");
        money = PlayerPrefs.GetInt("money");
        moneyText.text = money.ToString();
        
        levelScore = PlayerPrefs.GetInt("levelScore");
        scoreText.text = levelScore.ToString();
        ScoreTextArch.text = levelScore.ToString();
        int koin = PlayerPrefs.GetInt("koin");
        if (koin == 1)
        {
            StartCoroutine(IdleFarm());
        }
        

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
    public void ButtonClick()
    {
        //pri dostigenii yvelichivaet uroven
        money++;

        PlayerPrefs.SetInt("money", money);
        
        
    }
    public void ToUpping()
    {
        SceneManager.LoadScene(1);
    }
    public void StoreScene()
    {
        SceneManager.LoadScene(2);
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
        up = 20;
        PlayerPrefs.SetInt("up", up);
        PlayerPrefs.SetInt("levelScore", levelScore);
        int koin = PlayerPrefs.GetInt("koin");
        koin = 0;
        PlayerPrefs.SetInt("koin", koin);
        //StopCoroutine(IdleFarm());
        StopAllCoroutines();
    }
    

    void Update()
    {
        PlayerPrefs.SetInt("levelScore", levelScore);
        money = PlayerPrefs.GetInt("money");
        PlayerPrefs.GetInt("up");
        if (money >= up)
        {
            ScoreUp();
            up *= 2;
            PlayerPrefs.SetInt("up", up);
        }
        PlayerPrefs.SetInt("money", money);
        moneyText.text = money.ToString();
        scoreText.text = levelScore.ToString();
        ScoreTextArch.text = levelScore.ToString();
        
    }
}
