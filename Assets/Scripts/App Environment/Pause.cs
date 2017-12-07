using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public void execute()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            return;
        }

        Time.timeScale = 0;
    }
}
