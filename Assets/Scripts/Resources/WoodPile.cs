﻿using UnityEngine;
using System.Collections;

public class WoodPile : ResourcePile
{
    public override void useThisBock(Person person)
    {
        collectionRate = 2;
        exchangeResources(ref person.metalCarrying, person.techMultiplier);
    }
}
