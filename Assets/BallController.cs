using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;


    //�X�R�A��\������e�L�X�g(�ۑ�)
    public GameObject scoreText;
    public int Score = 0;
    //

    // Start is called before the first frame update
    void Start()
    {
        //ScoreText���擾
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
            //�����Ƀ��X�|�[�����������p
            //this.transform.position = new Vector3(3, 3, 4);
        }
    }
    void OnCollisionEnter(Collision other)
    {

        //�Փ˂��镨�̂ƃX�R�A�̑�����(�ۑ�)
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

        //�X�R�A��\���i�ۑ�j
        this.scoreText.GetComponent<Text>().text = "Score:" + Score;
    }
}
