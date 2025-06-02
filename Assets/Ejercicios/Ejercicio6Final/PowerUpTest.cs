using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.VFX;

public class PowerUpTest : MonoBehaviour
{
    public Animator anim;
    public VisualEffect levelUp;
    private bool levelingUp;
    public PlayableDirector director;
    public PlayableAsset efecto, quitarEfecto;

    public void OnEfectoVale()
    {
        director.playableAsset = efecto;
        director.Play();
    }

    public void OnEfectoJeronimoYSantiago()
    {
        director.playableAsset = quitarEfecto;
        director.Evaluate();
        if(anim != null)
        {
            anim.SetTrigger("PowerUp");

            if(levelUp !=null)
                levelUp.Play();

            levelingUp = true;
            StartCoroutine(ResetBool(levelingUp, 0.5f)) ;
        }
    }

    IEnumerator ResetBool (bool boolToReset, float delay = 0.1f)
            {
                yield return new WaitForSeconds(delay);
                levelingUp = !levelingUp;
    }
}


