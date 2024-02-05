using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager I;

    public Text cashNumTxt;
    public Text balanceNumTxt;

    int cash = 100000;
    int balance = 50000;


    private void Awake()
    {
        I = this;
    }


    void Start()
    {
        cashNumTxt.text = cash.ToString();
        balanceNumTxt.text = balance.ToString();
    }

   
    void Update()
    {
        
    }

    public void Deposit()
    {

    }
    

}
