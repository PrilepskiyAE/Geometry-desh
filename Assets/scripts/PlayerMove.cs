using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3;
    [SerializeField]
    private Transform _player;
    [SerializeField]
    private float _maxYPosition = 5.5f;

    void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.Space) && (_player.position.y < _maxYPosition))
        {
            _player.Translate(Vector3.up *_speed* Time.deltaTime);
        }
        else if(_player.position.y>-_maxYPosition){
            _player.Translate(Vector3.down * _speed * Time.deltaTime);
        }

    }
}
