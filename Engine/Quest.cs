using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public  class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencepoints { get; set; }
        public int RewardGold { get; set; }
        public Item RewardItem { get; set; }
        public List<QuestCompletionItem> QuestCompletionItem { get; set; }

        public Quest(int id, string name, string description, int rewardExperiencepoints, int rewardGold, Item rewardItem = null)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperiencepoints = rewardExperiencepoints;
            RewardGold = rewardGold;
            RewardItem = rewardItem;
            QuestCompletionItem = new List<QuestCompletionItem>();
        }
    }
}
