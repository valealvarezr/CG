using UnityEngine;
using UnityEngine.VFX;

public class SceneManager : MonoBehaviour
{
    public GameObject button;
    public VisualEffect powerupVFX;
    public Animator anim;
    public static bool isPLaying = true;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            if (isPLaying)
                Pause();
            else
                Play();
        }
    }

    public void Play()
    {
        Time.timeScale = 1;
        if (button != null)
        {
            button.SetActive(true);
            gameObject.SetActive(false);
            isPLaying = true;
        }
    }

    public void Pause()
    {
        Time.timeScale = 0;
        if (button != null)
        {
            button.SetActive(true);
            gameObject.SetActive(false);
            isPLaying = false;
        }
    }

    public void Exit()
    {
        Application.Quit();
    }

   
}


