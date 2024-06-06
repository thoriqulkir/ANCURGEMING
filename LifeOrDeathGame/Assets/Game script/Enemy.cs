using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform Player;

    public float speed;
    void Start() 
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if left
        if (Player.position.x < transform.position.x)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        //if right
        if (Player.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(1, 1, 1);
        } 
        
        Vector2 direction = Player.transform.position - transform.position;
        direction.Normalize();
        transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
    }
}
