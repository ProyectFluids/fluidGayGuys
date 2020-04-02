using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ink : MonoBehaviour
{
    public GameObject shot;
    private MoveBehaviour _moveBehaviour;
    public int lifes = 1;
    private void Awake()
    {
        _moveBehaviour = GetComponent<MoveBehaviour>();
        shot = GameObject.Find("shotPoint");
    }
        void FixedUpdate()
    {
        _moveBehaviour.Move(-shot.transform.up);
    }
}
