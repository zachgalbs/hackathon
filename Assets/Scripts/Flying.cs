using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    private Vector3 direction;
    
    public float gravity = -10f;
    public float strength = 5f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            direction = Vector3.up*strength;

        }

        if (Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began){
                direction = Vector3.up * strength;
            }
        }

        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
}
