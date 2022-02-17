using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollowing : MonoBehaviour
{
    Camera camera;
    void Start()
    {
        camera = Camera.main;
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            FollowMouse();
        }
    }
    void FollowMouse()
    {
        Vector2 mouseCoord = camera.ScreenToWorldPoint(Input.mousePosition);
        if (gameObject.GetComponent<Collider2D>().OverlapPoint(mouseCoord))
        {
            gameObject.transform.position = mouseCoord;
        }

    }
}
