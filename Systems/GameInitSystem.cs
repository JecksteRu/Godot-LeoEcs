using Godot;
using System;
using Leopotam.Ecs;

public class GameInitSystem :  IEcsSystem, IEcsInitSystem
{
    public EcsWorld _world = null;
    EcsEntity Player;

    public void Init()
    {
        Player = _world.NewEntity();
        //Player.Get<HealthComponent>();
        ref MoveableComponent moveableComponent = ref Player.Get<MoveableComponent>();
        ref PlayerInputComponent inputComponent = ref Player.Get<PlayerInputComponent>();

        PlayerInitData playerInitData = (PlayerInitData)DataInitializer.InicilizePlayerData<PlayerInitData>("res://Data/Player/PlayerInitData.tscn");
        KinematicBody2D PlayerNode = playerInitData.PlayerPack.Instance() as KinematicBody2D;
        
        EcsTreeHandler.AddToTree(PlayerNode);
        moveableComponent.Body = PlayerNode;
        

        moveableComponent.Speed = playerInitData.DefaultSpeed;



    }



}
