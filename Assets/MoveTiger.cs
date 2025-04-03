using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTiger : MonoBehaviour
{
    public float interval = 1.0f; // 切り替え間隔
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {

        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            transform.localScale = new Vector3(transform.localScale.x * -1, 1, 1);
            timer = 0f; // タイマーリセット
        }
    }
}
