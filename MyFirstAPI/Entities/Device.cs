namespace MyFirstAPI.Entities;

public abstract class Device
{
    protected bool IsConnected() => false;

    public abstract string GetBrand();
}
