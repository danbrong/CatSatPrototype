using UnityEngine.AI;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    // Variable Declaration
    public GameObject clickField; // For instantiating the UI Game Object
    private Vector3 mousePos; // tracks where mouse clicks
    


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

            // Click Feedback, Instantiate Prefab Object
            mousePos = hit.point;
            Instantiate(clickField, mousePos, Quaternion.identity);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player Collision!");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Player Exited");
    }
       

}
