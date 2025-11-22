namespace MyFirstAPI.Entities;

public class Laptop : Device
{
    public override string GetBrand()
    {
        return "Apple";
    }

    public string GetModel()
    {
        var isConnected = IsConnected();
        if (isConnected)
            return "Macbook";

        return "Unknow";
    }
}
