using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBehaviour : MonoBehaviour
{
    float alfa = 10;
    float waiting = 0.1f;
    Vector3 movement;
    private SpriteRenderer _spriteRenderer;
    void Start()
    {
        StartCoroutine("Rotate");
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    IEnumerator Rotate()
    {
        for (int i=0; i<100; i++)
        {
            //alfa++;
            movement = new Vector3(0, 0, alfa);
            //transform.rotation = Quaternion.AngleAxis(alfa, Vector3.forward);
            //transform.rotation = transform.rotation + movement;
            transform.Rotate(0, 0, alfa*Mathf.PI/180);
            yield return null;
            //yield return new WaitForSeconds(waiting);
        }
        alfa= alfa + 0.2f;
        int k = Random.Range(0, 4);
        switch(k)
        {
            case 0:
                _spriteRenderer.color = Color.cyan;
                break;
            case 1:
                _spriteRenderer.color = Color.magenta;
                break;
            case 2:
                _spriteRenderer.color = Color.yellow;
                break;
            case 3:
                _spriteRenderer.color = Color.green;
                break;
        }

        //yield return new WaitForSeconds(waiting);
        yield return Rotate();

    }
}
