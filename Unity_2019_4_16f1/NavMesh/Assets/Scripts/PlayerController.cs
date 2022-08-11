using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private NavMeshAgent _agent;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                _agent.SetDestination(hit.point);
            }
        }
    }
}
