using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public ChangeCloths change;

    private void Start()
    {
        if(PlayerPrefs.HasKey("Shirts"))
        {
            PlayerPrefs.SetInt("Shirt", 0);
        }
        if (PlayerPrefs.HasKey("Pants"))
        {
            PlayerPrefs.SetInt("Pants", 0);
        }
    }

    public void ChangeShirts()
    {
        for (int i = 0; i < change.itemCount; i++)
        {
            if (gameObject.name == "Shirts item at (" + i + ")")
            {
                chooseModel(i);
                PlayerPrefs.SetInt("Shirt", i);
            }

        }
    }
    public void ChangePants()
    {
        for (int i = 0; i < change.itemCount; i++)
        {
            if (gameObject.name == "Pants item at (" + i + ")")
            {
                chooseModel(i);
                PlayerPrefs.SetInt("Pants", i);
            }

        }
    }
    public void chooseModel(int num)
    {
        for (int i = 0; i < change.Models.Length; i++)
        {
            change.Models[i].SetActive(false);
            if (i == num)
            {
                change.Models[i].SetActive(true);
            }

        }    
    }
    
}
