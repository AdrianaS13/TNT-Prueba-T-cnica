using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSaved : MonoBehaviour
{
    public GameObject[] SaveModels, SavePants;

    private void Start()
    {
        loadPlayer();
    }
    public void loadPlayer()
    {
        Debug.Log("PlayerPrefhirt: " + PlayerPrefs.GetInt("Shirt"));
        chooseModel1(PlayerPrefs.GetInt("Shirt"));
        chooseModel(PlayerPrefs.GetInt("Pants"));
    }
   
    public void chooseModel1(int num)
    {
        Debug.Log("You have clicked " + num);
        for (int i = 0; i < SaveModels.Length; i++)
        {
            SaveModels[i].SetActive(false);
            SavePants[i].SetActive(false);
            if (i == num)
            {
                SaveModels[i].SetActive(true);
                SavePants[i].SetActive(true);
                Debug.Log("true" + num);
            }

        }
    }
    public void chooseModel(int num)
    {
        Debug.Log("You have clicked " + num);
        for (int i = 0; i < SaveModels.Length; i++)
        {
            SavePants[i].SetActive(false);
            if (i == num)
            {
                SavePants[i].SetActive(true);
                Debug.Log("true" + num);
            }

        }
    }
}
