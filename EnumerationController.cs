using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnumerationController : MonoBehaviour
{
    [SerializeField] Transform Target;
    [SerializeField] EnumActionState CurrentAction;
    [SerializeField] TMP_Text EnumTeller;
    [SerializeField] float MoveSpeed;

    Vector3 MoveDir = Vector3.zero;
    bool canMove = false;

    private void Start()
    {
        InputManager.initEnumController(this);
    }

    private void Update()
    {
        transform.position += MoveSpeed * MoveDir * Time.deltaTime;
        EnumTeller.text = CurrentAction.ToString();
    }

    public void UseAction()
    {
        if (CurrentAction == EnumActionState.Taller)
        {
            Target.localScale += new Vector3(0, 1, 0);
        }
        else if (CurrentAction == EnumActionState.Shorter)
        {
            Target.localScale -= new Vector3(0, 1, 0);
        }
        else if (CurrentAction == EnumActionState.ColorChange)
        {
            Target.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1);
        }
        else if (CurrentAction == EnumActionState.Movement)
        {
            canMove = true;
        }
    }

    public void MovePlayer(Vector3 newMoveDir)
    {
        Debug.Log("Performed Move");
        if (canMove)
        {
            MoveDir = -newMoveDir;
        }
        else 
        {
            MoveDir = Vector3.zero;
        }
    }

    public void ChangeActionState(EnumActionState newState)
    {
        CurrentAction = newState;
        MoveDir = Vector3.zero;
        canMove = (newState == EnumActionState.Movement);
    }
}
