using UnityEngine;

public class PursuitMovement : MonoBehaviour
{
    private readonly float _speed = 3.5f;
    private readonly float _epsilon = 0.001f;

    private Player _player;

    private void Start()
    {
        _player = FindObjectOfType(typeof(Player)) as Player;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, _speed * Time.deltaTime);

        if(Vector3.Distance(transform.position, _player.transform.position) <= _epsilon)
        {
            Destroy(gameObject);
        }
    }
}
