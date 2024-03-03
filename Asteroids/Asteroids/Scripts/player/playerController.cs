using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public Rigidbody2D player;
    public float speed = 10;

    void Update()
    {
        var direction = Input.GetAxis("Horizontal");
        player.velocity = new Vector2(0, direction * speed);
        player.rotation = -90f + direction * speed;
    }
}
