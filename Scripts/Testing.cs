using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    Grid grid;
    int value;

    private void Start()
    {
        grid = new Grid(100, 100, 10f, new Vector3(20, 0));
    }

}