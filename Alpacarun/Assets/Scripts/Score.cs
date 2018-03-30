using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    private PlayerCollision death;

   

    private void Start()
    {
        death = GameObject.Find("spookje").GetComponent<PlayerCollision>();   
    }
    void Update () {
      
            
        
        if (death == false)
        {
            scoreText.text = player.position.z.ToString("0");
        }
     
	}
}
