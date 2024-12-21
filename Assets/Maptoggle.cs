using UnityEngine;

public class Maptoggle : MonoBehaviour
{
    public GameObject mapObject;  // ������ GameObject �̸��� ȥ������ �ʵ��� ������ ����
    private int count = 0;

    private void Start()
    {
        // �ʱ� ����: ��Ȱ��ȭ
        if (mapObject != null)
            mapObject.SetActive(false);
    }

    public void Onclick()
    {
        if (mapObject == null) return;

        // Ŭ���� ������ count ����
        count++;

        // Ȧ����� Ȱ��ȭ, ¦����� ��Ȱ��ȭ
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
