using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMove : TacticsMove 
{
    [Header("Animation")]
    public Animator animator;

	// Use this for initialization
	void Start () 
	{
        Init();
	}
	
	// Update is called once per frame
	void Update () 
	{
        Debug.DrawRay(transform.position, transform.forward);

        

        if (!moving)
        {
            FindSelectableTiles();
            CheckMouse();

            // animation
            animator.SetBool("IsRunning", false);
        }
        else
        {
            Move();

            // animation
            animator.SetBool("IsRunning", true);
        }
	}

    void CheckMouse()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Tile" && !myTurnManager.Instance.IsOver)
                {
                    Tile t = hit.collider.GetComponent<Tile>();

                    if (t.selectable)
                    {
                        MoveToTile(t);
                        myTurnManager.Instance.PassTurn();
                    }
                }
            }
        }
    }
}
