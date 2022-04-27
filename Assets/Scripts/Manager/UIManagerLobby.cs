using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerLobby : MonoBehaviour
{
    /* ------------------------------------------ */

    public static UIManagerLobby instance
    {
        get
        {
            if (!_instance)
                _instance = FindObjectOfType<UIManagerLobby>();

            return _instance;
        }
    }
    static UIManagerLobby _instance;

    /* ------------------------------------------ */

    public UIGameStartGroup GameStartGroup;
    public UIWinGroup WinGroup;

    /* ------------------------------------------ */

    private void Awake()
    {
        if (UserData.IsGameWin)
        {
            WinGroup.SetActive(true);
            GameStartGroup.SetActive(false);
            UserData.IsGameWin = false;
        }
        else 
        {
            WinGroup.SetActive(false);
            GameStartGroup.SetActive(true);
        }
    }

    /* ------------------------------------------ */

}
