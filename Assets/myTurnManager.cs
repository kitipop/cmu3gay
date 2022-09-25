using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myTurnManager : MonoBehaviour
{
    #region singaton
    public static myTurnManager Instance;

    private void Awake()
    {
        if (Instance is null)
        {
            Instance = this;
        }
    }
    #endregion

    public int StartTurn = 5;
    public int CurrentTurn;

    public bool IsOver { get { return (CurrentTurn <= 0) ? true : false; } }

    private void Start()
    {
        CurrentTurn = StartTurn;
    }

    public void PassTurn()
    {
        CurrentTurn -= 1;

        Debug.Log(CurrentTurn);

        if (CurrentTurn <= 0)
        {
            Debug.Log("Game Over");
        }
    }

    public void GetExtraTurn()
    {
        CurrentTurn += 1;

        Debug.Log(CurrentTurn);
    }
}
