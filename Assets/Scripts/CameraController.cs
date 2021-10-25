using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private Vector3 offset;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = gameObject.transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        gameObject.transform.position = player.transform.position + offset;
    }
}
