using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance {get; private set;}
    public float gameWidth = 26.2f;

    void Awake()
    {
        if(Instance != null && Instance != this) {
            Destroy(Instance);
        }else {
            Instance = this;
        }
    }
}
