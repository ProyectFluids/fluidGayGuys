using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public Transform shotPoint;
    public GameObject shotPrefab;

    public float waiting = 5f;

    public void Start()
    {
        StartCoroutine(Shoot());
    }
    IEnumerator Shoot()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(shotPrefab, shotPoint.position, Quaternion.identity);
            yield return new WaitForSeconds(waiting);
        }
        waiting = waiting - 0.1f;
        yield return Shoot();

    }
}
