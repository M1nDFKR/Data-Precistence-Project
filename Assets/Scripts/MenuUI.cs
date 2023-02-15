using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MenuUI: MonoBehaviour
{
    
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void InputName (string pname){

        GameManager.Instance.name= pname;
    }
}