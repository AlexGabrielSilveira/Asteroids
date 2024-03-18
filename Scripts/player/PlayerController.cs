using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    public int MaxHealth = 100;
    public int currentHealth;

    public PlayerHeatlh healthBar;
    public Rigidbody2D player;
    public float speed = 15;


    private void Start() {
        currentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
    }
    void Update()
    {
        var direction = Input.GetAxis("Vertical");
        player.velocity = new Vector2(direction * speed, 0);
    }


}
