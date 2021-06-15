using UnityEngine;

public class SpawnerPoint : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    public void Create()
    {
        GameObject enemy;
        const float minColor = 0f;
        const float maxColor = 1f;

        enemy = Instantiate(_prefab, transform.position, Quaternion.identity);
        enemy.GetComponent<SpriteRenderer>().color = new Color(Random.Range(minColor, maxColor),
                                                         Random.Range(minColor, maxColor),
                                                         Random.Range(minColor, maxColor));
        enemy.transform.parent = transform;
    }
}
