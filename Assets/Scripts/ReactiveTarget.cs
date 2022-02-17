using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    private Manager _gameManager;
    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<Manager>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.name == "Mover")
        {
            _gameManager.AddScore();
            GameObject.Destroy(gameObject);
        }
    }
}
