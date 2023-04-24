using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;


    //スコアを表示するテキスト(課題)
    public GameObject scoreText;
    public int Score = 0;
    //

    // Start is called before the first frame update
    void Start()
    {
        //ScoreTextを取得
        this.scoreText = GameObject.Find("ScoreText");
        //

        this.gameoverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text> ().text = "Game Over";
            //無限にリスポーンしたい時用
            //this.transform.position = new Vector3(3, 3, 4);
        }
    }
    void OnCollisionEnter(Collision other)
    {

        //衝突する物体とスコアの増加量(課題)
        if (other.gameObject.tag == "SmallStarTag")
        {
            Score += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            Score += 40;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            Score += 20;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            Score += 100;
        }
        Debug.Log(Score);

        //スコアを表示（課題）
        this.scoreText.GetComponent<Text>().text = "Score:" + Score;
    }
}
