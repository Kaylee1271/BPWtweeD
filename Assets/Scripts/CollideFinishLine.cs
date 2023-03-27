using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideFinishLine : MonoBehaviour
{
    [SerializeField]
    public string sceneName;

    void OnCollisionEnter2D(Collision2D Col)
    {
        Debug.Log("Geraakt finish berrijkt.");
        SceneManager.LoadScene(sceneName);
    }
}
