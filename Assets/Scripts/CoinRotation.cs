using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public float speedRotation;

    private void Update()
    {
        transform.Rotate(0, speedRotation, 0, Space.World);
    }
}
