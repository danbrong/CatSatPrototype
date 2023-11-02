using UnityEngine.AI;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                _agent.SetDestination(hit.point);
            }
        }
    }
}
