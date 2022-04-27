using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIWinGroup : MonoBehaviour
{
    /* ------------------------------------------ */

    public TextMeshProUGUI TxtPuan;

    public Button BtnAgain;

    /* ------------------------------------------ */

    private void Awake()
    {
        BtnAgain.onClick.AddListener(() => FunAgain());
    }

    private void Start()
    {
        UpdatePuanUI();
    }
    /* ------------------------------------------ */

    public void FunAgain() 
    {
        StaticStageManagement.ChangeScene(LobbyManager.instance.GameSceneName);
    }

    /* ------------------------------------------ */

    public void UpdatePuanUI() 
    {
        TxtPuan.text = "Puan: " + UserData.GamePuan;
    }

    public void SetActive(bool active) 
    {
        this.gameObject.SetActive(active);
    }

    /* ------------------------------------------ */

}
