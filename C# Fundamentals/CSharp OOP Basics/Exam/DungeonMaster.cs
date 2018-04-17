using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    using Models.Characters;
    using Models.Items;
    using Factories;
    using System.Linq;

    public class DungeonMaster
    {
        private CharacterFactory characterFactory = new CharacterFactory();
        private ItemFactory itemFactory = new ItemFactory();

        private int lastSurvivorRounds = 0;

        private List<Character> players = new List<Character>();
        private List<Item> itemPool = new List<Item>();

        public string JoinParty(string[] args)
        {
            var faction = args[0];
            var characterType = args[1];
            var name = args[2];
            var character = characterFactory.CreateCharacter(faction, characterType, name);

            players.Add(character);
            return $"{name} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            var itemName = args[0];

            var item = itemFactory.CreateItem(itemName);

            itemPool.Add(item);
            return $"{itemName} added to pool.";
        }

        public string PickUpItem(string[] args)
        {
            var characterName = args[0];

            var character = FindCharacter(characterName);

            var item = itemPool.LastOrDefault();

            if (item == null)
            {
                throw new InvalidOperationException("No items left in pool!");
            }

            itemPool.RemoveAt(itemPool.Count - 1);
            character.ReceiveItem(item);

            return $"{characterName} picked up {item.Name}!";
        }

        public string UseItem(string[] args)
        {
            var characterName = args[0];
            var itemName = args[1];

            var character = FindCharacter(characterName);

            var item = character.Bag.GetItem(itemName);

            character.UseItem(item);

            return $"{character.Name} used {itemName}.";
        }

        public string UseItemOn(string[] args)
        {
            var giverName = args[0];
            var receiverName = args[1];
            var itemName = args[2];

            var giver = FindCharacter(giverName);

            var receiver = FindCharacter(receiverName);

            var item = giver.Bag.GetItem(itemName);

            giver.UseItemOn(item, receiver);

            return $"{giverName} used {itemName} on {receiverName}.";
        }

        public string GiveCharacterItem(string[] args)
        {
            var giverName = args[0];
            var receiverName = args[1];
            var itemName = args[2];

            var giver = FindCharacter(giverName);

            var receiver = FindCharacter(receiverName);

            var item = giver.Bag.GetItem(itemName);

            giver.GiveCharacterItem(item, receiver);

            return $"{giverName} gave {receiverName} {itemName}.";

        }

        public string GetStats()
        {
            return string.Join(Environment.NewLine,
                players.OrderByDescending(p => p.IsAlive)
                .ThenByDescending(p => p.Health));
        }

        public string Attack(string[] args)
        {
            var attackerName = args[0];
            var receiverName = args[1];

            var attacker = FindCharacter(attackerName);
            var receiver = FindCharacter(receiverName);

            if (attacker is Cleric)
            {
                throw new ArgumentException($"{attacker.Name} cannot attack!");
            }

            var warrior = (Warrior)attacker;

            warrior.Attack(receiver);

            var builder = new StringBuilder();
            builder.AppendLine($"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points! {receiverName} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!");

            if (!receiver.IsAlive)
            {
                builder.AppendLine($"{receiver.Name} is dead!");
            }

            return builder.ToString().TrimEnd();
        }

        public string Heal(string[] args)
        {
            var healerName = args[0];
            var healingReceiverName = args[1];

            var healer = FindCharacter(healerName);
            var receiver = FindCharacter(healingReceiverName);

            if (healer is Warrior)
            {
                throw new ArgumentException($"{healerName} cannot heal!");
            }

            var cleric = (Cleric)healer;

            cleric.Heal(receiver);

            return $"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!";
        }

        public string EndTurn(string[] args)
        {
            var builder = new StringBuilder();

            foreach (var p in players)
            {
                if (p.IsAlive)
                {
                    var healthBeforeRest = p.Health;
                    p.Rest();
                    builder.AppendLine($"{p.Name} rests ({healthBeforeRest} => {p.Health})");
                }
            }

            var survivorsCount = players.Where(p => p.IsAlive).Count();

            if (survivorsCount <= 1)
            {
                this.lastSurvivorRounds++;
            }

            return builder.ToString().TrimEnd();
        }

        public bool IsGameOver()
        {
            if (lastSurvivorRounds > 1)
            {
                return true;
            }
            return false;
        }

        private Character FindCharacter(string characterName)
        {
            var character = players.FirstOrDefault(p => p.Name == characterName);

            if (character == null)
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }

            return character;
        }
    }
}
