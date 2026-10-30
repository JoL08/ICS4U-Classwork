class Vector{
    private int _x;
    private int _y;

    public Vector(int x, int y){
        this._x = x;
        this._y = y;
    }

    public void Add(int x, int y){
        this._x += x;
        this._y += y;
    }
    
    public void Add(Vector added){
        Add(added._x, added._y);
    }

    public int GetX(){
        return this._x;
    }
    public int GetY(){
        return this._y;
    }
}

class Character{
    private Vector _position;
    
    public Character(int x, int y){
        this._position = new Vector(x, y);
    }

    public void Move(int dx, int dy){
        this._position.Add(dx, dy);
    }
    
    public void Move(Vector v){
        this._position.Add(v);
    }

    public int GetCX(){
        return this._position.GetX();
    }

    public int GetCY(){
        return this._position.GetY();
    }
}

public class Project{
    public static void Main(string[] args){
        
    }
}
