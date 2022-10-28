using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aiManager : MonoBehaviour
{
    public List<AIRotataion> aiRotations;

    public void OnNextTurn()
    {
        foreach (AIRotataion item in aiRotations)
        {
            item.onNextTurn();
        }
    }
}
