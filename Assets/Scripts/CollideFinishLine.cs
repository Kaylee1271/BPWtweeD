using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideFinishLine : MonoBehaviour
{
    [SerializeField]
    public string sceneName;
    public AudioSource Explode;
    public GameObject Explosion;
    public SpriteRenderer EndCollider;
    private BoxCollider2D Collider;

    void OnCollisionEnter2D(Collision2D Col)
    {
        this.EndCollider = GetComponent<SpriteRenderer>();
        this.EndCollider.enabled = false;
        this.Collider = GetComponent<BoxCollider2D>();
        this.Collider.enabled = false;
        Explode.Play();
        Explosion.SetActive(true);
        Invoke("Loader", 5.0f);
    }

    void Loader()
    {
        Debug.Log("Geraakt finish berrijkt.");
        SceneManager.LoadScene(sceneName);
    }
}
