using UnityEngine;

public class EnemyInstantiator : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    void Start()
    {
        if (enemy == null) Debug.Log("cant find enemy");
        for (var i = 0; i < 10; i++)
        {
            Instantiate(enemy, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
        }
    }
}
