using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerItecation : MonoBehaviour
{
    [SerializeField] private GameObject _playerImage;
    [SerializeField] private GameObject _trail;
    [SerializeField] private PlayerMove _player;
    [SerializeField] private GameObject _loseEffect;
    [SerializeField] private GameObject _winEffect;
    [SerializeField] private NavigationSystem _nav;
    [SerializeField] private LevelProgress _progress;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Obstacal>())
        {
            Lose();

        }

        if (collision.gameObject.GetComponent<Portal>()) {
           Win();
        }

    }

    private void Stop()
    {
     _playerImage.SetActive(false);
     _trail.SetActive(false);
     _player.enabled = false;
        if (PlayerPrefs.HasKey(_nav.getName()))
        {
            float oldPersent = PlayerPrefs.GetFloat(_nav.getName());
            if (_progress.Progress > oldPersent)
            {
                PlayerPrefs.SetFloat(_nav.getName(), _progress.Progress);
            }
        }
        else {
            PlayerPrefs.SetFloat(_nav.getName(), _progress.Progress);
        }
       
    }

   

    private void Lose()
    {
    Stop();
     _loseEffect.SetActive(true);
        Invoke(nameof(_nav.Restart), 2f);
    }
    private void Win()
    {
        Stop();
        _winEffect.SetActive(true);
        Invoke(nameof(_nav.NextLevel), 2f);
    }

}
