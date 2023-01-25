using System.Drawing;
public class Shape
{
    Color color = Color.Blue;
    double xCoord = 0;
    double yCoord = 0;

    public Shape(){}

    public virtual void Draw(){
    }

    public virtual void Erase(){
    }

    public Color GetColor(){
        return color;
    }

    public void Move(){
    }

    public void SetColor(Color color){
        this.color = color;
    }

    public virtual void Zoom (double amount){
    }

    

}