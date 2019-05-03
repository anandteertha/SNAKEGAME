using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    [HideInInspector]
    public PlayerDirection direction;

    [HideInInspector]
    public float step_Length = 0.2f;

    [HideInInspector]
    public float movement_Frequency = 0.1f;


    [SerializeField]
    private GameObject tailPrefab;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
} // class