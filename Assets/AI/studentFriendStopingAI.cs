using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studentFriendStopingAI : MonoBehaviour
{
    public Tile stopTile;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMove>().moving = false;
            other.GetComponent<PlayerMove>().ClearDATA();
            other.GetComponent<PlayerMove>().MoveToTile(stopTile);
        }
    }
}
