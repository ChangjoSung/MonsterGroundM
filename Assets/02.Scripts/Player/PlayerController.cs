using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigid;
    private Animator animator;
    private Vector2 inputVec;
    public Vector3 inputVec3; 

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        inputVec3 = new Vector3(inputVec.x, 0, inputVec.y);
        Vector3 nextPos = inputVec3 * PlayerStats.walkSpeed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextPos);
    }

    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
        //Debug.Log($"{inputVec.x} / {inputVec.y}");
    }

    void LateUpdate()
    {
        // 애니메이션 모션 설정
        // 앞으로
        if (inputVec.y > 0)
        {
            animator.SetInteger("MoveType", 1);
            Debug.Log("animation forward");
        }

        else if (inputVec.y < 0) // 뒤로
        {
            animator.SetInteger("MoveType", 2);
            Debug.Log("animation backward");
        }
        else if (inputVec.x < 0) // 왼쪽으로
        {
            animator.SetInteger("MoveType", 3);
            Debug.Log("animation left");
        }
        else if (inputVec.x > 0) // 오른쪽으로
        {
            animator.SetInteger("MoveType", 4);
            Debug.Log("animation right");
        }

        else    // 멈춤
        {
            animator.SetInteger("MoveType", 0);
            Debug.Log("animation stop");
        }
    }
}
