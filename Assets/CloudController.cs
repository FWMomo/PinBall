using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    //�ŏ��T�C�Y
    private float minimum = 1.0f;
    //�g��E�k���X�s�[�h
    private float magspeed = 10.0f;
    //�g�嗦
    private float magnification = 0.07f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale = new Vector3(this.minimum + Mathf.Sin(Time.time * this.magspeed) * this.magnification, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * this.magspeed) * this.magnification);
    }
}