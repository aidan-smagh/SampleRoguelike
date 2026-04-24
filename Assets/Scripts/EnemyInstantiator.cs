using UnityEngine;
using System.Collections;

public class EnemyInstantiator : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    void Start()
    {
        StartCoroutine(SpawnEnemiesRoutine());
    }
    IEnumerator SpawnEnemiesRoutine()
    {
        for (var i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(2.0f);
            GameObject clone = Instantiate(enemy, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
            clone.SetActive(true);
            clone.GetComponent<Animator>().enabled = true;
            clone.GetComponent<CharacterController>().enabled = true;
        }

    }
}
