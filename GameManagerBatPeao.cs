using UnityEngine;

public class GameManagerBatPeao : MonoBehaviour {
    public static GameManagerBatPeao instance;

    private void Awake() {
        if (instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    public void GameOver() {
        Debug.Log("Jogo Terminado!");
    }
}
