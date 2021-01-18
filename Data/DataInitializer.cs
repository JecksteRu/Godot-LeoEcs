using Godot;
using System;
using System.Reflection;

public sealed class DataInitializer : Node
{
    
    private static DataInitializer instance;

    private DataInitializer() => instance = this;
    

    public static Node InicilizePlayerData<T>(String path)
        where T : Node
    
    {
        
        PackedScene pack = GD.Load<PackedScene>(path);
        Node instance = (T)pack.Instance();
        T data = (T)Activator.CreateInstance(typeof(T));
        Type type = instance.GetType();
        foreach (FieldInfo field in type.GetFields())
        {
            field.SetValue(data, field.GetValue(instance));
        }
        instance.Free();
        return data;
    }

    
}
