using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puan : MonoBehaviour
{
    /* ------------------------------------------ */

    public int puan;

    /* ------------------------------------------ */

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            GameManager.instance.Puans.Remove(this);

            UserData.GamePuanUpdate(puan);
            //GameManager.instance.InstantiateRandomTimePuan();

            Destroy(this.gameObject);
        }
    }

    /* ------------------------------------------ */
}
