using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private Transform playerPosition;
    private Vector3 offset = new Vector3(0f, 10f, -10f);

    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        gameObject.transform.localPosition = playerPosition.localPosition + offset;
        gameObject.transform.localRotation = Quaternion.Euler(45f, 0f, 0f);
    }
}
