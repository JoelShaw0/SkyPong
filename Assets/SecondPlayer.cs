using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayer : MonoBehaviour
{
    public float moveSpeed = 100;
    int offscreen = 0;
    public KeyCode SecondUp;
    public KeyCode SecondDown;
    public KeyCode SecondLeft;
    public KeyCode SecondRight;
    public float tiltAngle;
    float smooth = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<Renderer>().isVisible)
        {
            offscreen++;
            if (offscreen > 3)
            {
                if (transform.position.y >= 0)
                {
                    transform.position = new Vector3(-7, 2, 0);
                }
                else
                {
                    transform.position = new Vector3(-7, -2, 0);
                }
            }
        }
        if (Input.GetKey(SecondUp))
        {
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime * moveSpeed;
        }
        else if (Input.GetKey(SecondDown))
        {
            transform.position += new Vector3(0, -1, 0) * Time.deltaTime * moveSpeed;
        }
        /*else if (Input.GetKey(SecondLeft))
        {
            float tiltAroundZ = 1 * tiltAngle;
            Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        }
        else if (Input.GetKey(SecondRight))
        {
            float tiltAroundZ = 1 * -tiltAngle;
            Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        }*/
    }
}
