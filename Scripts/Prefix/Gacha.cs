using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Gacha : MonoBehaviour
{
    public GachaFormController gachaFormController;

    public int priceBronze;
    public int priceSilver;
    public int priceGold;
    public int pricePlatinum;
    public int priceDiamond;

    private static Gacha instance;
    public static Gacha Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<Gacha>();
            }
            return instance;
        }
    }


    public void BronzeGacha()
    {
        if(Database.Instance.gold < priceBronze)
        {
            Notice.Instance.ShowNotice("골드가 부족합니다.");
            return;
        }

        if(Slot.Instance.Count >= 50)
        {
            Notice.Instance.ShowNotice("인벤토리가 꽉찼습니다.");
            return;
        }

        Database.Instance.gold -= priceBronze;

        // 유닛설정
        int unitLength = System.Enum.GetValues(typeof(UnitName)).Length;
        UnitName unitName = (UnitName)Random.Range(0, 6);

        // 레어도 설정
        Rarity rarity = Rarity.Normal;
        float rarityRand = Random.value;
        if (rarityRand <= 0.9f)
        {
            rarity = Rarity.Normal;
        }
        else if (rarityRand <= 1.0f)
        {
            rarity = Rarity.Rare;
        }

        // 접두사 랜덤
        Prefix prefix = RandomPrefix();

        var charInfo = RandomCharacterInfoCreator.Instance.CreateRandomStat(unitName, rarity, prefix);
        Slot.Instance.AddItem(charInfo);

        
        gachaFormController.ShowGachaInfo(charInfo);

        //SaveSystem.Instance.Save();

        QuestEventManager.Instance.ReceiveEvent(null, QuestEvent.Gacha, 1);
        QuestEventManager.Instance.ReceiveEvent(null, QuestEvent.BronzeGacha, 1);
    }

    public void SilverGacha()
    {
        if (Database.Instance.gold < priceSilver)
        {
            Notice.Instance.ShowNotice("골드가 부족합니다.");
            return;
        }

        if (Slot.Instance.Count >= 50)
        {
            Notice.Instance.ShowNotice("인벤토리가 꽉찼습니다.");
            return;
        }

        Database.Instance.gold -= priceSilver;

        // 유닛설정
        int unitLength = System.Enum.GetValues(typeof(UnitName)).Length;
        UnitName unitName = (UnitName)Random.Range(0, 6);

        // 레어도 설정
        Rarity rarity = Rarity.Normal;
        float rarityRand = Random.value;
        if (rarityRand <= 0.9f)
        {
            rarity = Rarity.Rare;
        }
        else if(rarityRand <= 1.0f)
        {
            rarity = Rarity.Unique;
        }

        // 접두사 랜덤
        Prefix prefix = RandomPrefix();


        var charInfo = RandomCharacterInfoCreator.Instance.CreateRandomStat(unitName, rarity, prefix);
        Slot.Instance.AddItem(charInfo);

        
        gachaFormController.ShowGachaInfo(charInfo);

        //SaveSystem.Instance.Save();

        QuestEventManager.Instance.ReceiveEvent(null, QuestEvent.Gacha, 1); 
        QuestEventManager.Instance.ReceiveEvent(null, QuestEvent.SilverGacha, 1); 
        }

    public void GoldGacha()
    {
        if (Database.Instance.gold < priceGold)
        {
            Notice.Instance.ShowNotice("골드가 부족합니다.");
            return;
        }

        if (Slot.Instance.Count >= 50)
        {
            Notice.Instance.ShowNotice("인벤토리가 꽉찼습니다.");
            return;
        }

        Database.Instance.gold -= priceGold;

        // 유닛설정
        int unitLength = System.Enum.GetValues(typeof(UnitName)).Length;
        UnitName unitName = (UnitName)Random.Range(0, 6);

        // 레어도 설정
        Rarity rarity = Rarity.Normal;
        float rarityRand = Random.value;
        if (rarityRand <= 0.9f)
        {
            rarity = Rarity.Unique;
        }
        else if (rarityRand <= 1.0f)
        {
            rarity = Rarity.Legend;
        }

        // 접두사 랜덤
        Prefix prefix = RandomPrefix();


        var charInfo = RandomCharacterInfoCreator.Instance.CreateRandomStat(unitName, rarity, prefix);
        Slot.Instance.AddItem(charInfo);

        
        gachaFormController.ShowGachaInfo(charInfo);

        //SaveSystem.Instance.Save();

        QuestEventManager.Instance.ReceiveEvent(null, QuestEvent.Gacha, 1);
        QuestEventManager.Instance.ReceiveEvent(null, QuestEvent.GoldGacha,1);
        }

    public void PlatinumGacha()
    {
        if (Database.Instance.gold < pricePlatinum)
        {
            Notice.Instance.ShowNotice("골드가 부족합니다.");
            return;
        }

        if (Slot.Instance.Count >= 50)
        {
            Notice.Instance.ShowNotice("인벤토리가 꽉찼습니다.");
            return;
        }

        Database.Instance.gold -= pricePlatinum;

        // 유닛설정
        int unitLength = System.Enum.GetValues(typeof(UnitName)).Length;
        UnitName unitName = (UnitName)Random.Range(0, 6);

        // 레어도 설정
        Rarity rarity = Rarity.Normal;
        float rarityRand = Random.value;
        if (rarityRand <= 0.9f)
        {
            rarity = Rarity.Legend;
        }
        else if (rarityRand <= 1.0f)
        {
            rarity = Rarity.Epic;
        }

        // 접두사 랜덤
        Prefix prefix = RandomPrefix();


        var charInfo = RandomCharacterInfoCreator.Instance.CreateRandomStat(unitName, rarity, prefix);
        Slot.Instance.AddItem(charInfo);

        
        gachaFormController.ShowGachaInfo(charInfo);

        //SaveSystem.Instance.Save();

        QuestEventManager.Instance.ReceiveEvent(null, QuestEvent.Gacha, 1); 
        QuestEventManager.Instance.ReceiveEvent(null, QuestEvent.PlatinumGacha, 1);
    }

    public void DiamondGacha()
    {
        if (Database.Instance.gold < priceDiamond)
        {
            Notice.Instance.ShowNotice("골드가 부족합니다.");
            return;
        }

        if (Slot.Instance.Count >= 50)
        {
            Notice.Instance.ShowNotice("인벤토리가 꽉찼습니다.");
            return;
        }

        Database.Instance.gold -= priceDiamond;

        // 유닛설정
        int unitLength = System.Enum.GetValues(typeof(UnitName)).Length;
        UnitName unitName = (UnitName)Random.Range(0, 6);

        // 레어도 설정
        Rarity rarity = Rarity.Normal;
        float rarityRand = Random.value;
        if (rarityRand <= 0.9f)
        {
            rarity = Rarity.Epic;
        }
        else if (rarityRand <= 1.0f)
        {
            rarity = Rarity.Epic;
        }

        // 접두사 랜덤
        Prefix prefix = RandomPrefix();

        var charInfo = RandomCharacterInfoCreator.Instance.CreateRandomStat(unitName, rarity, prefix);
        Slot.Instance.AddItem(charInfo);

        
        gachaFormController.ShowGachaInfo(charInfo);

        //SaveSystem.Instance.Save();

        QuestEventManager.Instance.ReceiveEvent(null, QuestEvent.Gacha, 1); 
        QuestEventManager.Instance.ReceiveEvent(null, QuestEvent.DiamondGacha,1);
    }

    public void CustomGacha()
    {
        Prefix prefix = RandomPrefix();

        var charInfo = RandomCharacterInfoCreator.Instance.CreateRandomStat(UnitName.unit_highbarbarian, Rarity.Epic, prefix);
        Slot.Instance.AddItem(charInfo);

        charInfo = RandomCharacterInfoCreator.Instance.CreateRandomStat(UnitName.unit_highwarrior, Rarity.Epic, prefix);
        Slot.Instance.AddItem(charInfo);

        charInfo = RandomCharacterInfoCreator.Instance.CreateRandomStat(UnitName.unit_higharcher, Rarity.Epic, prefix);
        Slot.Instance.AddItem(charInfo);

        charInfo = RandomCharacterInfoCreator.Instance.CreateRandomStat(UnitName.unit_highhalberdier, Rarity.Epic, prefix);
        Slot.Instance.AddItem(charInfo);

        charInfo = RandomCharacterInfoCreator.Instance.CreateRandomStat(UnitName.unit_highmonk, Rarity.Epic, prefix);
        Slot.Instance.AddItem(charInfo);

        charInfo = RandomCharacterInfoCreator.Instance.CreateRandomStat(UnitName.unit_highswordmaster, Rarity.Epic, prefix);
        Slot.Instance.AddItem(charInfo);


        charInfo = RandomCharacterInfoCreator.Instance.CreateRandomStat(UnitName.unit_ultimatearcher, Rarity.Epic, prefix);
        Slot.Instance.AddItem(charInfo);

        charInfo = RandomCharacterInfoCreator.Instance.CreateRandomStat(UnitName.unit_ultimatebarbarian, Rarity.Epic, prefix);
        Slot.Instance.AddItem(charInfo);

        charInfo = RandomCharacterInfoCreator.Instance.CreateRandomStat(UnitName.unit_ultimatehalberdier, Rarity.Epic, prefix);
        Slot.Instance.AddItem(charInfo);

        charInfo = RandomCharacterInfoCreator.Instance.CreateRandomStat(UnitName.unit_ultimatemonk, Rarity.Epic, prefix);
        Slot.Instance.AddItem(charInfo);

        charInfo = RandomCharacterInfoCreator.Instance.CreateRandomStat(UnitName.unit_ultimateswordmaster, Rarity.Epic, prefix);
        Slot.Instance.AddItem(charInfo);

        charInfo = RandomCharacterInfoCreator.Instance.CreateRandomStat(UnitName.unit_ultimatewarrior, Rarity.Epic, prefix);
        Slot.Instance.AddItem(charInfo);

        //gachaFormController.ShowGachaInfo(charInfo);
    }


    public Prefix RandomPrefix()
    {
        Prefix prefix = Prefix.None;
        float prefixRand = Random.value;
        if (prefixRand < 0.5f)
        {
            prefix = Prefix.None;
        }
        else
        {
            prefix = (Prefix)Random.Range(0, System.Enum.GetValues(typeof(Prefix)).Length - 2);
        }

        return prefix;
    }
}
