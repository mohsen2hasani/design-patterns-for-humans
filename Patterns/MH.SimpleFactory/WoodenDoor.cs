namespace MH.SimpleFactory;

public class WoodenDoor : IDoor
{
    protected float Width;
    protected float Height;

    public WoodenDoor(float width, float height)
    {
        Width = width;
        Height = height;
    }

    public float GetWidth()
    {
        return Width;
    }

    public float GetHeight()
    {
        return Height;
    }
}