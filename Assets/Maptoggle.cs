using UnityEngine;

public class Maptoggle : MonoBehaviour
{
    public GameObject mapObject;  // 기존에 GameObject 이름과 혼동되지 않도록 변수명 변경
    private int count = 0;

    private void Start()
    {
        // 초기 상태: 비활성화
        if (mapObject != null)
            mapObject.SetActive(false);
    }

    public void Onclick()
    {
        if (mapObject == null) return;

        // 클릭할 때마다 count 증가
        count++;

        // 홀수라면 활성화, 짝수라면 비활성화
        if (count % 2 == 1)
        {
            mapObject.SetActive(true);
        }
        else
        {
            mapObject.SetActive(false);
        }
    }
}
