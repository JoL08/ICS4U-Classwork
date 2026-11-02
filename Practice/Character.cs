using System;

class Vector{
    private int _x;
    private int _y;

    public Vector(int x, int y){
        this._x = x;
        this._y = y;
    }

    public int GetX(){
        return this._x;
    }
    
    public int GetY(){
        return this._y;
    }

    public void Add(int x, int y){
        this._x += x;
        this._y += y;
    }
    
    public void Add(Vector advded){
        Add(v._x, v._y);
    }
}

class Character{
    private Vector _position;
    
    public Character(int x, int y){
        this._position = new Vector(x, y);
    }

    public int GetX(){
        return this._position.GetX();
    }

    public int GetY(){
        return this._position.GetY();
    }

    public void Move(int dx, int dy){
        this._position.Add(dx, dy);
    }
    
    public void Move(Vector v){
        this._position.Add(v);
    }
}

public class Project{
    public static void Main(string[] args){
        Vector v1 = new Vector(15, 5);
        Console.WriteLine($"x = {v1.GetX()}, y = {v1.GetY()}");
        
        v1.Add(3, 5);
        Console.WriteLine($"x = {v1.GetX()}, y = {v1.GetY()}");
        
        v1.Add(new Vector(1, 3));
        Console.WriteLine($"x = {v1.GetX()}, y = {v1.GetY()}");
        
        Character c1 = new Character(1, 3);
        Console.WriteLine($"Character @ ({c1.GetX()}, {c1.GetY()})");
        
        c1.Move(new Vector(1, 3));
        Console.WriteLine($"Character @ ({c1.GetX()}, {c1.GetY()})");
    }
}
