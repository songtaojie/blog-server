﻿namespace HxBlog.Core.Service;

public class OrgInput : BaseIdInput
{
    /// <summary>
    /// 名称
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 编码
    /// </summary>
    public string Code { get; set; }
}

[NotTable]
public class AddOrgInput : SysOrg
{
    /// <summary>
    /// 名称
    /// </summary>
    [Required(ErrorMessage = "机构名称不能为空")]
    public override string Name { get; set; }
}

[NotTable]
public class UpdateOrgInput : AddOrgInput
{
}

public class DeleteOrgInput : BaseIdInput
{
}