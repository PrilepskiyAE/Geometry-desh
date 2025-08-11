using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3;
    [SerializeField]
    private Transform _player;
    [SerializeField]
    private float _maxYPosition = 5.5f;
    private float _yPosition;
    private float _oldYPosition;

    void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
        if (Input.GetMouseButton(0))
           {
            _yPosition += _speed * Time.deltaTime;  
           }
        else
        {
            _yPosition -= _speed * Time.deltaTime;

        }

        _yPosition = Mathf.Clamp(_yPosition,-_maxYPosition, _maxYPosition);
        _player.localPosition=new Vector3(0,_yPosition,0);


        if (_yPosition > _oldYPosition)
        {
            _player.localEulerAngles = new Vector3(0, 0, 45);
        }
        else if (_yPosition < _oldYPosition)
        {
            _player.localEulerAngles = new Vector3(0, 0, -45);
        }
        else {
            _player.localEulerAngles = new Vector3(0, 0, 0);
        }

        _oldYPosition = _yPosition;
    }

    
}
