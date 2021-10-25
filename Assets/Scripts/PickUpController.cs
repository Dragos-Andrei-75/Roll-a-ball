using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(15f, 35f, 45f) * Time.deltaTime);
    }
}
