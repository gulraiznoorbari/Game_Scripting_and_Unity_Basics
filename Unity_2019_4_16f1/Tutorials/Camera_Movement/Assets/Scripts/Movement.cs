using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 2f;
    private void Update()
    {   // Transform.translate(new Vector3(x, y, z)) can also be used for movement.

        if (Input.GetKey(KeyCode.UpArrow) && transform.position.z < 60) 
        {
            transform.position += Time.deltaTime * _moveSpeed * Vector3.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.z > -85)
        {
            transform.position += Time.deltaTime * _moveSpeed * Vector3.back;
        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -82)
        {
            transform.position += Time.deltaTime * _moveSpeed * Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 90)
        {
            transform.position += Time.deltaTime * _moveSpeed * Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(53, 4.7f, -30);
        }
        

    }
}
