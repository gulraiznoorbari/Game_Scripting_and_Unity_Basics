using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed = 0.3f;
    public FixedJoystick FixedJoystick;
    // Start is called before the first frame update
    void Update()
    {
        // Joystick Controls:
        transform.Translate(new Vector3(0, FixedJoystick.Vertical*Speed, FixedJoystick.Horizontal*Speed));
        
        // Keyboard Controls:
        //if(Input.GetKey(KeyCode.RightArrow))
        //{
        //    Debug.Log("Moves Forward.");
        //    transform.Translate(new Vector3(0, 0, Speed));
        //}
        //else if(Input.GetKey(KeyCode.LeftArrow))
        //{
        //    Debug.Log("Moves Backwards.");
        //    transform.Translate(new Vector3(0, 0, -Speed));
        //}
        //else if(Input.GetKey(KeyCode.UpArrow))
        //{
        //    Debug.Log("Moves Up.");
        //    transform.Translate(new Vector3(0, Speed, 0));
        //}
        //else if(Input.GetKey(KeyCode.DownArrow))
        //{
        //    Debug.Log("Moves Down.");
        //    transform.Translate(new Vector3(0, -Speed, 0));
        //}
        //else if(Input.GetKey(KeyCode.L))
        //{
        //    Debug.Log("Moves Right.");
        //    transform.Translate(new Vector3(Speed, 0, 0));
        //}
        //else if(Input.GetKey(KeyCode.R))
        //{
        //    Debug.Log("Moves Left.");
        //    transform.Translate(new Vector3(-Speed, 0, 0));
        //}
    }
    private const string EnemyTag = "Enemy Tag";
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.LogError($"Cube : onCollisionEnter() with {collision.gameObject.name}");
        if (collision.gameObject.tag == EnemyTag)
        {
            // Any kind of aimations, particles or player behaviour will be written here.
            Debug.LogError("Object collided with Enemy!");
            Destroy(collision.gameObject);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
       //Debug.LogError("Cube: onCollisionExit()");
    }
}
