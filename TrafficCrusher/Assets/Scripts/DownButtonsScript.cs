using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DownButtonsScript : MonoBehaviour
{
    public Button[] buttons;
    private int selectedButton;

    public Sprite yellowButton;
    public Sprite greenButton;


    public Vector3 normalPos;
    public Vector3 downPos;


    private void Start()
    {
        selectedButton = 4;
        HandleButtonImage();
    }

    private void Update()
    {
        HandleButtonImage();
    }

    public void HandleButtonImage()
    {
        if(GameEssentials.PLAYER_NEXT_ROTATION == 90f && selectedButton != 2) //r 2
        {
            selectedButton = 2;
            foreach(Button b in buttons)
            {
                b.image.sprite = greenButton;
            }

            buttons[2].image.sprite = yellowButton;
        }
        else if (GameEssentials.PLAYER_NEXT_ROTATION == -90f && selectedButton != 0)//l 0
        {
            selectedButton = 0;
            foreach (Button b in buttons)
            {
                b.image.sprite = greenButton;
            }
            buttons[0].image.sprite = yellowButton;
        }
        else if (GameEssentials.PLAYER_NEXT_ROTATION == 0 && selectedButton != 1) //f 1
        {
            selectedButton = 1;
            foreach (Button b in buttons)
            {
                b.image.sprite = greenButton;
            }
            buttons[1].image.sprite = yellowButton;
        }
    }
}
