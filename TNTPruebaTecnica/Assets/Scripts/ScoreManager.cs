using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    #region Singleton

    public static ScoreManager instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion

    public static int Score1 = 0;
    public TextMeshProUGUI score;
    private void Update()
    {
        score.text = Score1.ToString();
    }


    public void ResetPosition()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
