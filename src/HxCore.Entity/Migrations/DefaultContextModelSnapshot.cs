﻿// <auto-generated />
using System;
using HxCore.Entity.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HxCore.Entity.Migrations
{
    [DbContext(typeof(DefaultContext))]
    partial class DefaultContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("HxCore.Entity.Entities.T_BasicInfo", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime");

                    b.Property<string>("CardId")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Creater")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("CreaterId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("Gender")
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.Property<string>("LastModifier")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("LastModifierId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Mobile")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("QQ")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("RealName")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("School")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Telephone")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("UserId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("WeChat")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.ToTable("T_BasicInfo");
                });

            modelBuilder.Entity("HxCore.Entity.Entities.T_Blog", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("BlogTags")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("BlogTypeId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("CanCmt")
                        .HasColumnType("char(1)");

                    b.Property<string>("Carousel")
                        .HasColumnType("char(1)");

                    b.Property<string>("CategoryId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<long>("CmtCount")
                        .HasColumnType("bigint");

                    b.Property<string>("CoverImgUrl")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Creater")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("CreaterId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Deleted")
                        .HasColumnType("char(1)");

                    b.Property<string>("Disabled")
                        .HasColumnType("char(1)");

                    b.Property<string>("Essence")
                        .HasColumnType("char(1)");

                    b.Property<long>("FavCount")
                        .HasColumnType("bigint");

                    b.Property<string>("Forward")
                        .HasColumnType("char(1)");

                    b.Property<string>("LastModifier")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("LastModifierId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("datetime");

                    b.Property<long>("LikeCount")
                        .HasColumnType("bigint");

                    b.Property<string>("MarkDown")
                        .HasColumnType("char(1)");

                    b.Property<decimal>("OrderFactor")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("PersonTop")
                        .HasColumnType("char(1)");

                    b.Property<string>("Private")
                        .HasColumnType("char(1)");

                    b.Property<string>("Publish")
                        .HasColumnType("char(1)");

                    b.Property<DateTime?>("PublishDate")
                        .HasColumnType("datetime");

                    b.Property<string>("PureContent")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<long>("ReadCount")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Top")
                        .HasColumnType("char(1)");

                    b.HasKey("Id");

                    b.ToTable("T_Blog");
                });

            modelBuilder.Entity("HxCore.Entity.Entities.T_BlogExtend", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("BlogId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<string>("ContentHtml")
                        .HasColumnType("text");

                    b.Property<string>("ForwardUrl")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Location")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("T_BlogExtend");
                });

            modelBuilder.Entity("HxCore.Entity.Entities.T_BlogTag", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Creater")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("CreaterId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Deleted")
                        .HasColumnType("char(1)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Disabled")
                        .HasColumnType("char(1)");

                    b.Property<string>("LastModifier")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("LastModifierId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<int?>("OrderIndex")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("T_BlogTag");
                });

            modelBuilder.Entity("HxCore.Entity.Entities.T_BlogType", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Creater")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("CreaterId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Deleted")
                        .HasColumnType("char(1)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Disabled")
                        .HasColumnType("char(1)");

                    b.Property<string>("LastModifier")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("LastModifierId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<int?>("OrderIndex")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("T_BlogType");
                });

            modelBuilder.Entity("HxCore.Entity.Entities.T_Category", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Creater")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("CreaterId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Deleted")
                        .HasColumnType("char(1)");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Disabled")
                        .HasColumnType("char(1)");

                    b.Property<string>("LastModifier")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("LastModifierId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<int?>("OrderIndex")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("T_Category");
                });

            modelBuilder.Entity("HxCore.Entity.Entities.T_JobInfo", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Creater")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("CreaterId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("GoodAreas")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("Industry")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("LastModifier")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("LastModifierId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Position")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Skills")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UserId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("WorkUnit")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("WorkYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("T_JobInfo");
                });

            modelBuilder.Entity("HxCore.Entity.Entities.T_Menu", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Component")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Creater")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("CreaterId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Deleted")
                        .HasColumnType("char(1)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Disabled")
                        .HasColumnType("char(1)");

                    b.Property<string>("Icon")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("IsHide")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IskeepAlive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastModifier")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("LastModifierId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("datetime");

                    b.Property<int>("MenuType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("OrderSort")
                        .HasColumnType("int");

                    b.Property<string>("ParentId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("T_Menu");
                });

            modelBuilder.Entity("HxCore.Entity.Entities.T_Module", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Action")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Area")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Controller")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Creater")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("CreaterId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Deleted")
                        .HasColumnType("char(1)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Disabled")
                        .HasColumnType("char(1)");

                    b.Property<string>("HttpMethod")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastModifier")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("LastModifierId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("OrderSort")
                        .HasColumnType("int");

                    b.Property<string>("RouteUrl")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("T_Module");
                });

            modelBuilder.Entity("HxCore.Entity.Entities.T_OperateLog", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("ActionName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Agent")
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("ControllerName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<long>("ElapsedTime")
                        .HasColumnType("bigint");

                    b.Property<string>("HttpMethod")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("IPAddress")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Location")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime?>("OperateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Operater")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("OperaterId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Param")
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("Result")
                        .HasColumnType("text");

                    b.Property<bool>("Success")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Url")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.HasKey("Id");

                    b.ToTable("T_OperateLog");
                });

            modelBuilder.Entity("HxCore.Entity.Entities.T_Role", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Creater")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("CreaterId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Deleted")
                        .HasColumnType("char(1)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Disabled")
                        .HasColumnType("char(1)");

                    b.Property<string>("LastModifier")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("LastModifierId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("OrderSort")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("T_Role");
                });

            modelBuilder.Entity("HxCore.Entity.Entities.T_RoleMenu", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("PermissionId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.HasKey("Id");

                    b.ToTable("T_RoleMenu");
                });

            modelBuilder.Entity("HxCore.Entity.Entities.T_User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Activate")
                        .HasColumnType("char(1)");

                    b.Property<string>("AvatarUrl")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Creater")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("CreaterId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Deleted")
                        .HasColumnType("char(1)");

                    b.Property<string>("Disabled")
                        .HasColumnType("char(1)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("LastLoginTime")
                        .HasColumnType("datetime");

                    b.Property<string>("LastModifier")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("LastModifierId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Lock")
                        .HasColumnType("char(1)");

                    b.Property<string>("LoginIp")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NickName")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("OpenId")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime>("RegisterTime")
                        .HasColumnType("datetime");

                    b.Property<string>("SuperAdmin")
                        .HasColumnType("char(1)");

                    b.Property<string>("UseMdEdit")
                        .HasColumnType("char(1)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.HasKey("Id");

                    b.ToTable("T_User");
                });

            modelBuilder.Entity("HxCore.Entity.Entities.T_UserRole", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.HasKey("Id");

                    b.ToTable("T_UserRole");
                });

            modelBuilder.Entity("HxCore.Entity.T_MenuModule", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("ModuleId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("PermissionId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.HasKey("Id");

                    b.ToTable("T_MenuModule");
                });
#pragma warning restore 612, 618
        }
    }
}
