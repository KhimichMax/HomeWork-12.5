using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerState : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _menuPaus;
    
    private void CheckIsDeadPlayer()
    {
        if (!_player)
        {
            Time.timeScale = 0;
            _menuPaus.SetActive(true); 
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        Debug.Log(Time.timeScale);
    }
    
    void Update()
    {
        CheckIsDeadPlayer();
    }
}
