using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas; // Masukan canvasnya

    public RectTransform gambarPuzzle; // Masukan gambar puzzlenya
    public GameObject detector; // Masukan detectornya untuk menempatkan puzzle tersebut
    Vector2 posAwal, scaleAwal;
    bool onPos = false;

    private void Awake()
    {
        gambarPuzzle = GetComponent<RectTransform>();
    }

    void Start()
    {
        posAwal = transform.position;
        scaleAwal = transform.localScale;
    }

    // Skrip ketika memulai drag
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Awal Drag");
    }

    // Skrip ketika mouse atau jari disentuh
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Klik Drag");
    }

    // Skrip ketika di drag atau memindahkan objek
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Sedang Drag");
        gambarPuzzle.anchoredPosition += eventData.delta / canvas.scaleFactor;
        transform.localScale = new Vector2(1.65f, 1.65f);
    }

    // Skrip ketika melepaskan mouse atau jari
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Akhir Drag");
        if (onPos)
        {
            transform.position = detector.transform.position;
            transform.localScale = new Vector2(1.65f, 1.65f);
        }
        else
        {
            transform.position = posAwal;
            transform.localScale = scaleAwal;
        }
    }

    // Skrip ketika collider menyentuh
    void OnTriggerStay2D(Collider2D objek)
    {
        if (objek.gameObject == detector)
        {
            onPos = true;
        }
    }

    // Skrip ketika collider tidak menyentuh
    void OnTriggerExit2D(Collider2D objek)
    {
        if (objek.gameObject == detector)
        {
            onPos = false;
        }
    }

}
