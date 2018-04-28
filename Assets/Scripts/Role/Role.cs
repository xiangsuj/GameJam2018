using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RoleType
{
    P1,
    P2
}
public class Role
{

    private RoleType mRoleType { get; set; }
    private int mRopeCount { get; set; }
    private int mMarkPenCount { get; set; }
    private int mLightCount { get; set; }

    public Role(RoleType roleType)
    {
        mRoleType = roleType;
        mRopeCount = 0;
        mMarkPenCount = 0;
        mLightCount = 0;
    }
    //TODO 各个道具数量的增减
}
