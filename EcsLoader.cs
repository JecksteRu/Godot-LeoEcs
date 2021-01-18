using Godot;
using System;
using Leopotam.Ecs;

public sealed class EcsLoader : Node
{

    private static EcsLoader instace;
    public EcsWorld _world;
    EcsSystems _system;

    private EcsLoader() => instace = this;
    
    
    public override void _Ready()
    {
        
        _world = new EcsWorld();
        _system = new EcsSystems(_world);
        _system.Add(new GameInitSystem())
            .Add(new PlayerInputSystem())
            .Add(new PlayerMoveSystem())
            .Init();
    }

    public override void _Process(float delta)
    {
        base._Process(delta);
        _system?.Run(delta);
    }


    public override void _ExitTree()
    {
        base._ExitTree();
        _system.Destroy();
        _world.Destroy();
    }

}
