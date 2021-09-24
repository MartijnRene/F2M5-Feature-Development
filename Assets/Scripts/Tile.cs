using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField]
    private bool buildable;

    public bool GetIsBuildable()
    {
        return buildable;
    }
}
