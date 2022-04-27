using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIGameStartGroup : MonoBehaviour
{
    /* ------------------------------------------ */

    public Button BtnStart;

    /* ------------------------------------------ */

    private void Awake()
    {
        BtnStart.onClick.AddListener(() => FunStart());
    }

    /* ------------------------------------------ */

    public void FunStart() 
    {
        StaticStageManagement.ChangeScene(LobbyManager.instance.GameSceneName);
    }

    /* ------------------------------------------ */

    public void SetActive(bool active) 
    {
        this.gameObject.SetActive(active);
    }

    /* ------------------------------------------ */

}
