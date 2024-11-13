using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Jogar(){
        SceneManager.LoadScene("CHESS");
    }

    public void Jogar2(){
        SceneManager.LoadScene("batpeao");
    }

    public void AbrirVideoYouTube()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=S1LsUT7jjDI");
    }

    public void AbrirExerciciosSite()
    {
        Application.OpenURL("https://pt.chesstempo.com/chess-tactics/");
    }

    public void Voltar()
    {
        SceneManager.LoadScene("start");
    }
}
