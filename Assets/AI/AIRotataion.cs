using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum rotaion
{
    left = 1,
    right = -1
}

public class AIRotataion : MonoBehaviour
{
    public rotaion ro;

    public void onNextTurn()
    {
        transform.Rotate((Vector3.up * ((int)ro)) * 90, Space.World);
    }
}
