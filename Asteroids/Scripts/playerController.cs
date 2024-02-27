using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 10;

    void Update()
    {
        var isPressingLeft = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
        var isPressingRight = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);
        float movement = speed * Time.deltaTime;

        if(isPressingLeft == isPressingRight) return;
        if(isPressingLeft) {
            movement *= -1f;
        }
        transform.position += new Vector3(movement,0,0);

    }
}
