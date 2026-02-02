using UnityEngine;

public class monsterspon : MonoBehaviour
{
    public float speed = 1f;
    public Transform bulletSpawnPoint;
    private float timer=0;
    //private DelayTimeMain Delaycount;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 4)
        {
            // 총알생성을 플레이어가 하지 않는다.
            //var bulletGo = Instantiate(bulletPrefab);

            // 오브젝트풀 에서 빌려오기
            timer = 0;
            var bulletGo = pool.instance.Pool.Get();

            bulletGo.transform.position = gameObject.transform.position;
        }

        // 가로 이동 반환값 : LeftArrow = -1 RightArrow = 1
        var h = Input.GetAxisRaw("Horizontal");
        // 세로 이동 반환값 : DownArrow = -1 UpArrow = 1        
        var v = Input.GetAxisRaw("Vertical");

        //단위 벡터 (크기가 1인 벡터)
        var dir = new Vector3(h, v, 0).normalized;

        this.transform.Translate(dir * this.speed * Time.deltaTime);
    }
}