using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public static Shop inst;
    public static int Gold;

    private void Awake()
    {
        if (inst == null)
        {
            inst = this;
            Gold = 0;
        }
        else
        {
            Destroy(gameObject);
        }
    }


}