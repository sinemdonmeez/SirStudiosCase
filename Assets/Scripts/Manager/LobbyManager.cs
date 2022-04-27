using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyManager : MonoBehaviour
{
    /* ------------------------------------------ */

    public static LobbyManager instance
    {
        get
        {
            if (!_instance)
                _instance = FindObjectOfType<LobbyManager>();

            return _instance;
        }
    }
    static LobbyManager _instance;

    /* ------------------------------------------ */

    public string GameSceneName;
    
    /* ------------------------------------------ */

}
