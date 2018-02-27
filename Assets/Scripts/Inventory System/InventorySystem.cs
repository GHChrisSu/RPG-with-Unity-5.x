﻿using System;
using UnityEngine;
using System.Collections.Generic;
[Serializable]
public class InventorySystem
{
    [SerializeField]
    private List<InventoryItem> weapons = new List<InventoryItem>();
    [SerializeField]
    private List<InventoryItem> armour = new List<InventoryItem>();
    [SerializeField]
    private List<InventoryItem> clothing = new List<InventoryItem>();
    [SerializeField]
    private List<InventoryItem> health = new List<InventoryItem>();
    [SerializeField]
    private List<InventoryItem> potion = new List<InventoryItem>(); public List<InventoryItem> WEAPONS
    {
        get { return this.weapons; }
    }
    public List<InventoryItem> ARMOUR
    {
        get { return this.armour; }
    }
    public List<InventoryItem> CLOTHING
    {
        get { return this.clothing; }
    }
    public List<InventoryItem> HEALTH
    {
        get { return this.health; }
    }
    public List<InventoryItem> POTIONS
    {
        get { return this.potion; }
    }
    //[SerializeField]
    private InventoryItem selectedWeapon;
    //[SerializeField]
    private InventoryItem selectedArmour;
    public InventoryItem SELECTED_WEAPON
    {
        get { return this.selectedWeapon; }
        set { this.selectedWeapon = value; }
    }
    public InventoryItem SELECTED_ARMOUR
    {
        get { return this.selectedArmour; }
        set { this.selectedArmour = value; }
    }
    public InventorySystem()
    {
        this.ClearInventory();
    }
    public void ClearInventory()
    {
        this.weapons.Clear();
        this.armour.Clear();
        this.clothing.Clear();
        this.health.Clear();
        this.potion.Clear();
    }
    // this function will add an inventory item
    public void AddItem(InventoryItem item)
    {
        switch (item.CATEGORY)
        {
            case BaseItem.ItemCatrgory.ARMOUR:
                {
                    this.armour.Add(item);
                    break;
                }
            case BaseItem.ItemCatrgory.CLOTHING:
                {
                    this.clothing.Add(item);
                    break;
                }
            case BaseItem.ItemCatrgory.HEALTH:
                {
                    this.health.Add(item);
                    break;
                }
            case BaseItem.ItemCatrgory.POTION:
                {
                    this.potion.Add(item);
                    break;
                }
            case BaseItem.ItemCatrgory.WEAPON:
                {
                    this.weapons.Add(item);
                    break;
                }
        }
    }
    // this function will remove an inventory item
    public void DeleteItem(InventoryItem item)
    {
        switch (item.CATEGORY)
        {
            case BaseItem.ItemCatrgory.ARMOUR:
                {
                    this.armour.Remove(item); break;
                }
            case BaseItem.ItemCatrgory.CLOTHING:
                {
                    this.clothing.Remove(item);
                    break;
                }
            case BaseItem.ItemCatrgory.HEALTH:
                {
                    this.health.Remove(item);
                    break;
                }
            case BaseItem.ItemCatrgory.POTION:
                {
                    this.potion.Remove(item);
                    break;
                }
            case BaseItem.ItemCatrgory.WEAPON:
                {
                    this.weapons.Remove(item);
                    break;
                }
        }
    }
}