using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private void Start()
    {
        EventSystem.MovementEvent += PlayerMove;
    }

    public void PlayerMove(Vector3 dir)
    {
        transform.position += dir * Time.deltaTime;
    }
}
