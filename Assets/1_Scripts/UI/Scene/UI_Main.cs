using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Main : UI_Scene
{
    enum Texts
    {
    }

    void Start()
    {
        Init();
    }

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindText(typeof(Texts));

        // Sound
        Managers.Sound.Clear();
        //Managers.Sound.Play("LobbyBgm", Define.Sound.Bgm);

        return true;
    }
}