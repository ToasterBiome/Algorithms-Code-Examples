using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCodeExamples
{
    class DataStructures
    {
        

        static void Main(string[] args)
        {
            //HASHTABLE & ARRAYS

            Hashtable weaponDamage;

            //assign the weapon damage values with the key of what weapon they "belong" to. This is a terrible way to actually program weapons, it's just for an example.
            weaponDamage = new Hashtable();
            weaponDamage.Add("copper_sword", 5);
            weaponDamage.Add("iron_sword", 12);
            weaponDamage.Add("epic_staff", 3);
            weaponDamage.Add("weapon_of_doing_a_lot_of_damage", 999);

            //get the damage of an item
            Console.WriteLine("HASHTABLE:");
            Console.WriteLine($"Damage of Copper Sword: {weaponDamage["copper_sword"]}");
            Console.WriteLine($"Damage of Weapon of doing a lot of damage: {weaponDamage["weapon_of_doing_a_lot_of_damage"]}");
            
            //in the case that you need to retrieve specific items then arrays are bad for it, as they encourage id numbers to be tied to things. If you were to implement something like weapon damage with arrays:
            //if you just want to use it as a "collection of things", an array would be easier to manage I think. 
            int[] weaponDamageArray = new int[4];

            weaponDamageArray[0] = 5;
            weaponDamageArray[1] = 12;
            weaponDamageArray[2] = 3;
            weaponDamageArray[3] = 999;
            Console.WriteLine("ARRAY:");
            Console.WriteLine($"Damage of Copper Sword: {weaponDamageArray[0]}");
            Console.WriteLine($"Damage of Weapon of doing a lot of damage: {weaponDamageArray[3]}");

            //You can't really tell what is what. At least with a hashtable you can look things up by the key to make it easier. Also arrays are finite size while a Hashtable can be added/removed from.

            //STACK & QUEUE

            //stacks are last in, first out: the last thing that you put in will be pulled out, like filling your dresser. The socks you put in last have to come out first.
            //a card "stack" is the only thing I can imagine using the Stack for. Maybe something for resolving card order in a card game?

            Stack<string> cardStack = new Stack<string>();

            //we'll add some cards

            cardStack.Push("jack");
            cardStack.Push("king");
            cardStack.Push("jester");

            //you can peek into the stack to see the card that's about to be pulled out

            Console.WriteLine($"The next card will be: {cardStack.Peek()}");

            //lets pull it out. It should be pulled Jester -> King -> Jack
            Console.WriteLine($"Crafting a: {cardStack.Pop()}");
            Console.WriteLine($"Crafting a: {cardStack.Pop()}");
            Console.WriteLine($"Crafting a: {cardStack.Pop()}");

            //success!!

            //queues are first in, first out: they are pulled out in the order that you put them in. I feel queues are a bit more practical in things like crafting queues.

            Console.WriteLine("QUEUE:");
            Queue<string> craftingQueue = new Queue<string>();
            craftingQueue.Enqueue("copper sword");
            craftingQueue.Enqueue("ring");
            craftingQueue.Enqueue("coin purse");

            //you can also peek into the queue to see the item that's about to be pulled out

            Console.WriteLine($"The next item will be: {craftingQueue.Peek()}");

            //and we can dequeue to get it out, should be Copper Sword -> Ring -> coin purse

            Console.WriteLine($"Crafting a: {craftingQueue.Dequeue()}");
            Console.WriteLine($"Crafting a: {craftingQueue.Dequeue()}");
            Console.WriteLine($"Crafting a: {craftingQueue.Dequeue()}");

            //now it should be empty!

            Console.WriteLine($"Things left to craft: {craftingQueue.Count}.");


            Console.ReadLine();

        }
    }
}
