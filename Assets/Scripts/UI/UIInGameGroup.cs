using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIInGameGroup : MonoBehaviour
{
    /* ------------------------------------------ */

    public TextMeshProUGUI TxtPuan;

    /* ------------------------------------------ */

    public void UpdatePuanUI() 
    {
        TxtPuan.text = "Puan: " +UserData.GamePuan;
    }

    public void SetActive(bool active) 
    {
        this.gameObject.SetActive(active);
    }

    /* ------------------------------------------ */

}
