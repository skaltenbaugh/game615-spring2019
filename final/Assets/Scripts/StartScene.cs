﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
 
    public void StartGame(int GameStart)
    {
        SceneManager.LoadScene(GameStart);
    }
        
    }
