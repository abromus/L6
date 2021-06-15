using UnityEngine;

public class Movement : MonoBehaviour
{
    private readonly float _speed = 3.5f;
    private readonly float _epsilon = 0.001f;

    private Target _target;

    private void Start()
    {
        _target = FindObjectOfType(typeof(Target)) as Target;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);

        if(Vector3.Distance(transform.position, _target.transform.position) <= _epsilon)
        {
            Destroy(gameObject);
        }
    }
}
