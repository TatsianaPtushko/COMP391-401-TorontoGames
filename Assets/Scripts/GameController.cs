using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class GameController : MonoBehaviour

{
[Header("UI Object")]
    public Text healthText;
    public GameObject gameOverTextObj;
    public GameObject restartTextObj;
    public GameObject winText;
    private int health=5;

    private bool gameOver = false;
    private bool restart = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
            restart = true;
            restartTextObj.SetActive(true);
        }

        if(restart)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Level_1");
            }
        }
    }


    public void DecreaseHealth(int minusHealth)
    {
        health -= minusHealth;
        UpdateHealthText();
    }


    private void UpdateHealthText()
    {
        healthText.text = "Health:" + health;
    }

    public void GameOver()
    {
        gameOver = true;
        gameOverTextObj.SetActive(true);
    }


}
