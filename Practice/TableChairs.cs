using System;
using System.Collections.Generic;

class Chair{
    private string _color;
    private bool _isOccupied;

    public Chair(string color){
        this._color = color;
    }

    public void Occupy(){
        this._isOccupied = true;
    }

    public void Unoccupy(){
        this._isOccupied = false;
    }

    public bool IsOccupied(){
        return this._isOccupied;
    }
}

class Table{
    class TableFullException : Exception{
        public TableFullException (string message) : base(message){
        }
    }
    private List<Chair> _chairs;
    private int _maxChair;
    private int _length;
    private int _width;

    public Table(int maxChair, int length, int width){
        this._maxChair = maxChair;
        this._length = length;
        this._width = width;
        this._chairs = new List<Chair>();
    }

    public void AddChair(Chair newChair){
        if (this._chairs.Count == this._maxChair){
            throw new Table.TableFullException("Table is full. Cannot add chair");
        }
        this._chairs.Add(newChair);
    }

    public int GetNumChairs(){
        return this._chairs.Count;
    }

    public int GetNumOccupants(){
        int chairCount = 0;
        for(int i = 0; i < _chairs.Count; i++){
            if(_chairs[i].IsOccupied()){
                chairCount++;
            }
        }
        return chairCount;
    }
}

public class Project{
    public static void Main(string[] args){
        Chair c1 = new Chair("blue");
        Console.WriteLine(c1.IsOccupied());
        c1.Occupy();
        Console.WriteLine(c1.IsOccupied());
        c1.Unoccupy();
        Console.WriteLine(c1.IsOccupied());
        
        Table t1 = new Table(3, 1, 1);
        Console.WriteLine(t1.GetNumChairs());  // 0
        
        t1.AddChair(new Chair("yellow"));
        Console.WriteLine(t1.GetNumChairs());  // 1
        
        t1.AddChair(new Chair("yellow"));
        t1.AddChair(new Chair("yellow"));
        Console.WriteLine(t1.GetNumChairs());  // 3
        
        try{
            t1.AddChair(new Chair("yellow"));
        }
        catch (TableFullException){
            Console.WriteLine("oops, I cant add any more chairs.");
        }
        
        Tabel t2 = new Table(3, 1, 1);
        Chair[] chairs = {
            new Chair("blue");
            new Chair("blue");
            new Chair("blue");
            new Chair("blue");
        }
    }
}
