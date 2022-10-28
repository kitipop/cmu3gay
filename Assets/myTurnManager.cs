using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

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
    public int ExtraTurn = 1;
    public TextMeshProUGUI turnText;

    public UnityEvent onNextTurn;

    public bool IsOver { get { return (CurrentTurn <= 0) ? true : false; } }

    private void Start()
    {
        CurrentTurn = StartTurn;
    }

    public void PassTurn()
    {
        CurrentTurn -= 1;

        updateTurnText();
        Debug.Log(CurrentTurn);
        onNextTurn.Invoke();

        if (CurrentTurn <= 0)
        {
            Debug.Log("Game Over");
        }
    }
    private void updateTurnText()
    {
        turnText.text = CurrentTurn + " / " + StartTurn;
    }

    public void GetExtraTurn()
    {
        CurrentTurn += ExtraTurn;
        updateTurnText();
        Debug.Log(CurrentTurn);
    }
}
