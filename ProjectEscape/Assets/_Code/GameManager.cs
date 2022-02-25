using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager current;

    public void Awake()
    {
        current = this;
    }

    public event Action StartTutorial;

    public void startTutorial()
    {
        StartTutorial?.Invoke();
    }

    public event Action FinishTutorial;

    public void finishTutorial()
    {
        finishTutorial?.Invoke();
    }


}
