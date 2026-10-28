using System;

class Weapon{
    private int _damage;
    private string _name;

    public Weapon(string name, int damage){
        this._name = name;
        this._damage = damage;
    }
    
    public int GetDamage(){
        return this._damage;
    }
}

class Character{
    private int _health;
    private string _name;
    private Weapon _weapon;

    public Character(string name){
        this._name = name;
        this._health = 100;
        this._weapon = null;
    }
    public void Equip(Weapon newWeapon){
        this._weapon = newWeapon;
    }
    public void Attack(Character other){
        int damage = this._weapon.GetDamage();
        other._health -= damage;
    }
}
public class Program {
    public static void Main(string[] args) {
        Character player1 = new Character("Jeff");
        Character enemy = new Character("Goblin");
        
        Weapon sword = new Weapon("Sword", 25);
        
        player1.Equip(sword);
        player1.Attack(enemy);

        Console.WriteLine(player1);
    }
}
