using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager I;

    public UserData User;

    private void Awake()
    {
        if(I == null)
        {
            I = this;
        }
        else
        {
            Destroy(gameObject);
        }      
    }
}
