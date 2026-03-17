using UnityEngine;

public class MyCharcter : MonoBehaviour
{
    public int Health = 100;                                            //체력을 선언 한사. (변수 정수 표현)
    public float Timer = 1.0f;                                              //타이머를 설정 한다. (변수 실수 표현)

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Health = Health = 100;                                          //첫 시작 할떄 100의 체력을 추가 한다.
    }

    // Update is called once per frame
    void Update()
    {
        Timer = Timer - Time.deltaTime;                                        //시간을 매 프레임마다 감소 시킨다. (deitaTime은 프레임간의 시간 간격 의미한다.)

        if (Timer <= 0)                                                   //만약 Time 의 수치가 0이하로 내려갈 경우
        {
            Timer = 1.0f;
        }
        Health = Health - 20;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Health = Health + 2;
        }

        if (Health < -0)
        {
            Destroy(this.gameObject);
        }
    }
}
