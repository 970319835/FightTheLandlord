﻿using UnityEngine;
using strange.extensions.command.impl;

public class NotCallCommand : EventCommand
{
    [Inject]
    public IGameData gameData { get; set; }
    public override void Execute()
    {
        RemoteCMD_Data recData = evt.data as RemoteCMD_Data;
        if (recData.player.Name.Equals(gameData.Player2.Name))
        {
            dispatcher.Dispatch(ViewConst.ShowPlayer2Msg, StringConst.NotCall);
        }
        if (recData.player.Name.Equals(gameData.Player3.Name))
        {
            dispatcher.Dispatch(ViewConst.ShowPlayer3Msg, StringConst.NotCall);
        }
        //if (recData.player.Name.Equals(gameData.PlayerSelf.Name))
        //{
        //    dispatcher.Dispatch(ViewConst.ChangeOptionMenuMode, OptionMenu_Status.HideAll);
        //}
        gameData.CurrentStatus = GameStatus.CallLandlord;
        gameData.ClaimCount--;
        
    }
}