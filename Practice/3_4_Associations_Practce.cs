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
    // class WeaponNotEquippedExcewption : Exception;
    
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
        if (this == other){
            Console.WriteLine("Stop hitting yourself");
        }
        // if (this._weapon == null){
        //     throw WeaponNotEquippedExcewption ("Must have weapon equipped");
        }
        int damage;
        try{
            damage = this._weapon.GetDamage();
        }
        catch (NullReferenceException e){
            damage = 1;
        }
        // if (this.weapon != null){
        //     int damage = this._weapon.GetDamage();
        // }
        other._health -= damage;
    }
}
public class Program {
    public static void Main(string[] args) {
        Character player1 = new Character("Jeff");
        Character enemy = new Character("Goblin");
        
        Weapon sword = new Weapon("Sword", 25);
        
        player1.Equip(sword);
        Console.WriteLine(enemy.GetHealth());
        
        player1.Attack(enemy);
        Console.WriteLine(enemy.GetHealth());
}
