using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studentFriendStopingAI : MonoBehaviour
{
    public Tile stopTile;

    [Header("Update Tile")]
    public float heightCol;
    public float widthCol;
    public float offset = 3;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position + (transform.right * offset), new Vector3(widthCol, 2, heightCol));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMove>().moving = false;
            other.GetComponent<PlayerMove>().ClearDATA();
            other.GetComponent<PlayerMove>().MoveToTile(stopTile);
        }
    }

    public void updateStopTile()
    {
        Collider[] colTile = Physics.OverlapBox(
            transform.position + (transform.right * offset),
            new Vector3(widthCol, 2, heightCol) / 2,
            transform.rotation
            );

        foreach (Collider item in colTile)
        {
            if(item.gameObject.HasComponent<Tile>())
            {
                stopTile = item.GetComponent<Tile>();
            }
        }
    }
}

public static class hasComponent
{
    public static bool HasComponent<T>(this GameObject flag) where T : Component
    {
        return flag.GetComponent<T>() != null;
    }
}