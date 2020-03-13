
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreCount : MonoBehaviour
{
    
    public TextMeshProUGUI score;
    public TextMeshProUGUI highScore;

    int scoreCounting;
    private void Start()
    {
        highScore.text = " High Score "+PlayerPrefs.GetInt("highScore", 0).ToString();
    }


    void Update()
    {
        scoreCounting = asteroidDestroyer.score;
        score.text = scoreCounting.ToString() ;
        if(scoreCounting > PlayerPrefs.GetInt("highScore", 0))
        {
            PlayerPrefs.SetInt("highScore", scoreCounting);
            highScore.text = " High Score " +scoreCounting.ToString();
        }
        
    }
}
