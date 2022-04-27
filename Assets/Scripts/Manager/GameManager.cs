using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /* ------------------------------------------ */

    public static GameManager instance 
    {
        get 
        {
            if (!_instance)
                _instance = FindObjectOfType<GameManager>();

            return _instance;
        }
    }static GameManager _instance;

    /* ------------------------------------------ */

    public string LobbySceneName;

    public GameObject PuanPrefab;

    public Transform PuanParent;

    public List<Puan> Puans = new List<Puan>();

    /* ------------------------------------------ */

    private void Start()
    {
        UserData.GamePuan = 0;
        UIManager.instance.InGameGroup.UpdatePuanUI();
        InstantiatePuan(5);

        Invoke("InstantiateRandomTimePuan", 5f);
        Invoke("WinSystem", 10f);
    }

    /* ------------------------------------------ */
    
    void InstantiatePuan(int amount = 1) 
    {
        for (int i = 0; i < amount; i++) 
        {
            float randomX = Random.Range(-7f, 7f);
            float randomZ = Random.Range(-23f, 23f);
            GameObject go = Instantiate(PuanPrefab, PuanParent);
            go.transform.position = new Vector3(randomX, 0.5f, randomZ);
            Puans.Add(go.GetComponent<Puan>());
        }
        
    }

    void InstantiateRandomTimePuan() 
    {
        if (Puans.Count < 5) 
        {
            int random = Random.Range(0, 100);

            if (random < 40) 
            {
                InstantiatePuan();
            }
        }

        Invoke("InstantiateRandomTimePuan", 1f);
    }

    void WinSystem() 
    {
        if (UserData.GamePuan == 100) 
        {
            StaticStageManagement.ChangeScene(LobbySceneName);
            UserData.IsGameWin = true;
        }

        Invoke("WinSystem", 1f);
    }
}
