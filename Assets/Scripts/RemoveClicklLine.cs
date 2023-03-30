using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveClicklLine : MonoBehaviour
{
    public void DestroyAll(string tag)
    {
        GameObject[] Lines = GameObject.FindGameObjectsWithTag(tag);
        for (int i = 0; i < Lines.Length; i++)
        {
            Destroy(Lines[i]);
        }
    }
}
