using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class MapPlayerMoveController : MonoBehaviour
{
    [SerializeField] private MapSettings _map;
    [SerializeField] private Flag _flag;

    private Camera _mainCamera;
    private NavMeshAgent _navMeshAgent;
    private Vector2 mousePosition;

    private void Start()
    {
        _mainCamera = Camera.main;
        _navMeshAgent = GetComponent<NavMeshAgent>();

        _navMeshAgent.updateRotation = false;
        _navMeshAgent.updateUpAxis = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
            Move(mousePosition);
        }
    }

    private void Move(Vector2 target)
    {
        if (target.x >= _map.topLeft.x && target.x <= _map.bottomRight.x && target.y <= _map.topLeft.y && target.y >= _map.bottomRight.y)
        {
            SetFlag(target);
            _navMeshAgent.SetDestination(target);
        }
    }

    private void SetFlag(Vector2 position)
    {
        if (_flag != null)
            _flag.gameObject.SetActive(false);

        _flag.transform.position = position;

        _flag.gameObject.SetActive(true);
    }
}
