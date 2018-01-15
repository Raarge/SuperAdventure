﻿namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiance { get; set; }
        public int RewardGold { get; set; }
        public Item RewardItem { get; set; }

        public Quest(int id, string name, string description, int rewardExperiancePoints, int rewardGold, Item rewardItem = null)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperiance = rewardExperiancePoints;
            RewardGold = rewardGold;
            RewardItem = rewardItem;
        }
    }
}
