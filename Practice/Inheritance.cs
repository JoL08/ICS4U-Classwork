using System;

class Surface{
    private int _length;
    private int _width;
    private string[] _itemsOnTop;

    public Surface(int length, int width){
        this._length = length;
        this._width = width;
    }
    public string[] ClearSurface(){
        string[] _removedItems = _itemsOnTop;
        _itemsOnTop = new string[0];
        return _removedItems;
    }
    public void PrintItems(){
        foreach (string i in itemsOnTop){
            Console.WriteLine(i);
        }
    }
    public int GetArea(){
        return this._length * this._width;
    }
    public void AddItem(string newItem){
        Array.Resize(ref _itemsOnTop, _itemsOnTop.Length, 1);
        _itemsOnTop[_itemsOnTop.Length - 1] = newItem;
    }
}

class Chair{
    public string Color;

    public Chair(string color){
        this.Color = color;
    }

    public string ToString(){
        return Color;
    }
}

class Table : Surface{
    private Chair[] _chair;
    public Table(int length, int width) : base(_length, _width){
        
    }
}
