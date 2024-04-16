using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Board : MonoBehaviour
{
    public GameObject card;
    // Start is called before the first frame update
    void Start()
    {
        //���� �ʱ�ȭ
        InitBoard();
    }

    void InitBoard()
    {
        int[] arr = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 };

        // ī�� ��ġ - ���� �ڵ�
        //arr = arr.OrderBy(x => Random.Range(0, arr.Length)).ToArray();

        //for (int i = 0; i < 16; i++)
        //{
        //    GameObject go = Instantiate(card, this.transform);

        //    float x = (i % 4) * 1.4f - 2.1f;
        //    float y = (i / 4) * 1.4f - 3.0f;

        //    go.transform.position = new Vector2(x, y);
        //    go.GetComponent<Card>().Setting(arr[i]);
        //}

        // ī�� ��ġ - �ٸ� �ڵ�(�迭 �̿�)
        for (int i = 0; i < arr.Length; i++)
        {
            //ī�� ����
            int j = Random.Range(i, arr.Length);
            if (i != j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            //ī�� ������ ����
            GameObject go = Instantiate(card, this.transform);
            //��ġ ����
            float x = (i % 4) * 1.4f - 2.1f;
            float y = (i / 4) * 1.4f - 3.0f;

            go.transform.position = new Vector2(x, y);
            go.GetComponent<Card>().Setting(arr[i]);
        }

        GameManager.instance.cardCount = arr.Length;
    }
}
