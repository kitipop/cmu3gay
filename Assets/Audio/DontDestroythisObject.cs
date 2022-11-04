using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroythisObject : MonoBehaviour
{
    public static DontDestroythisObject instance;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
