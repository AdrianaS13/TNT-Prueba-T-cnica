﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void changeScene()
    {
        SceneManager.LoadScene("Soccer");
    }

    public void Back()
    {
        PlayerPrefs.SetInt("Shirt", 0);    
        PlayerPrefs.SetInt("Pants", 0);
        SceneManager.LoadScene("Avatar");
    }


}
