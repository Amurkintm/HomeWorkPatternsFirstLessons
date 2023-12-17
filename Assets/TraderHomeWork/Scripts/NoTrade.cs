using UnityEngine;

public class NoTrade : TraderMain
{
    public override void Trade()
    {
        Debug.Log("Торговля невозможна. Низкий уровень навыка торговли! \nВернись позже!");
    }
}
