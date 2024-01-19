using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvGen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject invSlot;
    public int slotsX;
    public int slotsY;
    private int totSlots;
    private GameObject[] slots;


    void Start()
    {
        SlotCount();
        totSlots = slotsX * slotsY;

        slots = new GameObject[totSlots];

        for (int i = 0; i < totSlots; i++)
        {
            slots[i] = Instantiate(invSlot, transform);
        }


    }


    void SlotCount()
    {
        float areaWid = GetComponent<RectTransform>().rect.width;
        float areaHeight = GetComponent<RectTransform>().rect.height;
        float slotWid = invSlot.GetComponent<RectTransform>().rect.width;
        float slotHeight = invSlot.GetComponent<RectTransform>().rect.height;

        slotsX = Mathf.RoundToInt(areaWid / slotWid);
        slotsY = Mathf.RoundToInt(areaHeight / slotHeight);
        print("" + areaWid + " by " + slotWid);
    }
    // Update is called once per frame
    void Update()
    {
        SlotCount();
    }
}
