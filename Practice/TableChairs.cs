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
    private List<Chair> _chairs = new List<Chair>();
    private int _maxChair;
    private int _length;
    private int _width;

    public Table(int maxChair, int length, int width){
        this._chairs = new Chair[0];
        this._maxChair = maxChair;
        this._length = length;
        this._width = width;
    }

    public void AddChair(Chair newChair){
        this._chairs.Add(newChair);
    }

    public int GetNumChairs(){
        return this._chairs.Count;
    }

    public int GetNumOccupants(){
        int chairCount = 0;
        for(int i = 0; i < _chairs.Count; i++){
            if(_chairs[i].IsOccupied()){
                chairCount ++;
            }
        }
        return chairCount;
    }
}

public class Project{
    public static void Main(string[] args){
        
    }
}
