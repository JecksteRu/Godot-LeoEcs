using Godot;
using System;
using System.Reflection;

public class PlayerInitData : Node
{
    [Export]
    public PackedScene PlayerPack;
    [Export]
    public float DefaultSpeed = 200f;

}
