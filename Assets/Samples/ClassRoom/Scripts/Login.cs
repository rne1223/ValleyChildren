﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using System;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public GameObject username;
    public GameObject password;
    private string Username;
    private string Password;
    private String[] Lines;
    private string DecryptedPass;

    public void LoginButton()
    {
        bool UN = false;
        bool PW = false;
        if (Username != "")
        {
            if (System.IO.File.Exists(@"C:/UnityTestFolder/" + Username + ".csv"))
            {
                UN = true;
                Lines = System.IO.File.ReadAllLines(@"E:/UnityTestFolder/" + Username + ".csv");
            }
            else
            {
                Debug.LogWarning("Username Invaild");
            }
        }
        else
        {
            Debug.LogWarning("Username Field Empty");
        }
        if (Password != "")
        {
            if (System.IO.File.Exists(@"E:/UnityTestFolder/" + Username + ".csv"))
            {
                int i = 1;
                foreach (char c in Lines[2])
                {
                    i++;
                    char Decrypted = (char)(c / i);
                    DecryptedPass += Decrypted.ToString();
                }
                if (Password == DecryptedPass)
                {
                    PW = true;
                }
                else
                {
                    Debug.LogWarning("Password Is invalid");
                }
            }
            else
            {
                Debug.LogWarning("Password Is invalid");
            }
        }
        else
        {
            Debug.LogWarning("Password Field Empty");
        }
        if (UN == true && PW == true)
        {
            username.GetComponent<InputField>().text = "";
            password.GetComponent<InputField>().text = "";
            print("Login Sucessful");
            Application.LoadLevel("Start Menu");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (username.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Password != "" && Password != "")
            {
                LoginButton();
            }
        }
        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
    }
}

