using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    [HideInspector]
    public PlayerDirection direction;

    [HideInspector]
    public float step_length = 0.2f;

    [HideInspector]
    public float movement_frequency = 0.1f;

    private GameObject tailprefab;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
    // class