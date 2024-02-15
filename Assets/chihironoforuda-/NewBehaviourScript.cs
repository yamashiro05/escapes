using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{public List<Vector2> correctPattern; // 正しいパターンを設定
    public Image dotPrefab;
    public float dotSize = 50f;

    private List<Vector2> userPattern;
    private LineRenderer lineRenderer;
    private bool isRecordingPattern = false;

    // Start is called before the first frame update
    void Start()
    {
      userPattern = new List<Vector2>();
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
              if (Input.GetMouseButtonDown(0))
        {
            StartRecordingPattern();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopRecordingPattern();
            ValidatePattern();
        }

        if (isRecordingPattern)
        {
            RecordPattern();
        }
        
    }
 void StartRecordingPattern()
    {
        isRecordingPattern = true;
        userPattern.Clear();
        lineRenderer.positionCount = 0;
    }

    void StopRecordingPattern()
    {
        isRecordingPattern = false;
    }

    void RecordPattern()
    {
        Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(touchPosition, Vector2.zero);

        if (hit.collider != null && hit.collider.CompareTag("Dot"))
        {
            userPattern.Add(hit.collider.transform.position);
            DrawLine();
        }
    }

    void DrawLine()
    {
        lineRenderer.positionCount = userPattern.Count;
        lineRenderer.SetPositions(userPattern.ToArray());
    }

    void ValidatePattern()
    {
        if (ListsAreEqual(userPattern, correctPattern))
        {
            Debug.Log("パターンが正しいです！");
        }
        else
        {
            Debug.Log("パターンが正しくありません！");
        }
    }

    bool ListsAreEqual(List<Vector2> list1, List<Vector2> list2)
    {
        if (list1.Count != list2.Count)
            return false;

        for (int i = 0; i < list1.Count; i++)
        {
            if (list1[i] != list2[i])
                return false;
        }

        return true;
    }
}
