using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class StaticStageManagement
{
    public static void ChangeScene(string s) 
    {
        SceneManager.LoadScene(s);
    }
}
