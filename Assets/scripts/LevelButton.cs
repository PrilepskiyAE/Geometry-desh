using TMPro;
using UnityEngine;

public class LevelButton : MonoBehaviour
{
    [SerializeField] private NavigationSystem _nav;
    [SerializeField] private string _sname;
    [SerializeField] private TextMeshProUGUI _uGUI;
    void Start()
    {
        if (PlayerPrefs.HasKey(_sname))
        {
            float persent = PlayerPrefs.GetFloat(_sname);
            _uGUI.text = persent + "%";
        }
        else _uGUI.text = "0%";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
