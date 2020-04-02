using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    [RequireComponent(typeof(Rigidbody2D))]

    public class MoveBehaviour : MonoBehaviour
    {
        [SerializeField]
        private Vector2 _direction;
        [SerializeField]
        private float _speed = 10;
        private Rigidbody2D _rb;
        public void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }
    public void Move(Vector3 newdir)
    {
        _rb.MovePosition(new Vector3(transform.position.x + newdir.x * _speed * Time.deltaTime,
            transform.position.y + newdir.y * _speed * Time.deltaTime, 0));
    }
    public void Move()
        {
            _rb.MovePosition(new Vector2(transform.position.x + _direction.x * _speed * Time.deltaTime,
                transform.position.y + _direction.y * _speed * Time.deltaTime));
        }
}
