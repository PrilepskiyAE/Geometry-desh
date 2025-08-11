using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgress : MonoBehaviour
{
    [SerializeField] private Slider _progressSlider;
    [SerializeField] private TextMeshProUGUI _presentText;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Transform _portalTransform;
    private float _maxX;
    public float Progress;
    void Start()
    {
        _maxX= _portalTransform.position.x- _playerTransform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float currentX = _portalTransform.position.x - _playerTransform.position.x;
        float percent = 1 - currentX / _maxX;
        _progressSlider.value = percent;
        float res = (Mathf.CeilToInt(percent * 100) + 1);
        if (res > 100) res = 100;
        Progress = res;
        _presentText.text = res.ToString("0") + "%";
    }
    
}
