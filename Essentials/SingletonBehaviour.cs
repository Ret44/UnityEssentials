using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonBehaviour<T> : MonoBehaviour {

    public static T instance;

    public void Awake()
    {
        if (instance != null)
            Debug.LogWarningFormat("Multiple instances of {0} singleton!", (typeof(T)).ToString());

        T[] objs = FindObjectsOfType(typeof(T)) as T[];
        instance = objs[0];
    }

    public void OnDestroy()
    {
        instance = default(T);
    }
}
