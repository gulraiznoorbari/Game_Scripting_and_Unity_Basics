using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 0.3f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 0, _speed));
        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, 0, -_speed));
        } else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-_speed, 0, 0));
        } else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(_speed, 0, 0));
        }
    }
}
