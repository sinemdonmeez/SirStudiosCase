using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UserData
{
    /* ------------------------------------------ */

    public static int GamePuan;

    public static bool IsGameWin = false;

    /* ------------------------------------------ */

    public static void GamePuanUpdate(int value)
    {
        GamePuan += value;

        if (UIManager.instance)
        {
            UIManager.instance.InGameGroup.UpdatePuanUI();
        }
    }

    /* ------------------------------------------ */

}
