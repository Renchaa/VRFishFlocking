using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateFlock : MonoBehaviour
{
    [SerializeField] private Flock flocks;
    [SerializeField] private int flockCount;
    [SerializeField] private Transform positionToInstantiate;
    private void Start()
    {
        for (int i = 0; i < flockCount; i++)
        {
            Instantiate(flocks, positionToInstantiate.position, Quaternion.identity);
        }
    }
}
