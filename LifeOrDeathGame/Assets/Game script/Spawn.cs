using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    void Start()
    {
        Instantiate(player, transform.position, Quaternion.identity);
    }
}
