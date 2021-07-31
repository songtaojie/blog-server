﻿using Hx.Sdk.Entity.Dependency;
using HxCore.Entity.Entities;
using HxCore.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace HxCore.Model.Admin.Menu
{
    /// <summary>
    /// 菜单按钮
    /// </summary>
    public class MenuDetailModel:IAutoMapper<T_Menu>
    {
        /// <summary>
        /// 菜单的id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 权限的code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 菜单路由
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// 菜单路由组件路径
        /// </summary>
        public string Component { get; set; }
        /// <summary>
        /// /描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int OrderSort { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        ///菜单类型；0：目录，1：菜单，2：按钮
        /// </summary>
        public T_Menu_Enum MenuType { get; set; }
        /// <summary>
        /// 是否是隐藏菜单
        /// </summary>
        public bool IsHide { get; set; }
        /// <summary>
        /// 是否keepAlive
        /// </summary>
        public bool IskeepAlive { get; set; }
        /// <summary>
        /// 菜单图标
        /// </summary>
        public string Icon { get; set; }
    }
}
