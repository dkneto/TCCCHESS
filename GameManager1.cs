using UnityEngine;
public class GameManager1 : MonoBehaviour {
    
    public static GameManager1 instance;
    private Player winner;

    private void Awake() {
        if (instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    public void GameOver(Player winningPlayer) {
        winner = winningPlayer;
        Debug.Log("Jogo encerrado! O jogador vencedor é: " + winningPlayer);
    }
}
