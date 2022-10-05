using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraTurnPaper : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");

        if (other.gameObject.CompareTag("Player"))
        {
            myTurnManager.Instance.GetExtraTurn();
            Destroy(gameObject);
        }
    }
}
