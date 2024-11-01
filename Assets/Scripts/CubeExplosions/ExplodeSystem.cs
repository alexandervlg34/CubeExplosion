using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeSystem : MonoBehaviour
{
    public delegate void DelegateExplosion();

    
    public void One()
    {
        DelegateExplosion delegateExplosion;

        delegateExplosion = ExplodeOne;
        delegateExplosion += ExplodeTwo;
        delegateExplosion += ExplodeTwo;

        delegateExplosion?.Invoke();
        delegateExplosion();
    }
    public static void ExplodeOne()
    {
        Console.WriteLine("One");
    }

    public static void ExplodeTwo()
    {
        Console.WriteLine("Two");
    }
}
