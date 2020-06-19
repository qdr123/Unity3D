using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Rspeed = 150;
    float angleX;
    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }


    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, 0, v);
        transform.Translate(dir * speed * Time.deltaTime);
    }
        private void Rotate()
        {
            float h = Input.GetAxis("Mouse X");
            angleX += h * Rspeed * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, angleX, 0);
        }
    }
