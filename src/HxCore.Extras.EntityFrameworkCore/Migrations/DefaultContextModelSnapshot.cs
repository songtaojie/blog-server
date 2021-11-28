﻿// <auto-generated />
using System;
using HxCore.Extras.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HxCore.Extras.EntityFrameworkCore.Migrations
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

            modelBuilder.Entity("HxCore.Entity.Entities.T_Account", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

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

                    b.HasKey("Id");

                    b.ToTable("T_Account");
                });

            modelBuilder.Entity("HxCore.Entity.Entities.T_AccountRole", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.HasKey("Id");

                    b.ToTable("T_AccountRole");
                });

            modelBuilder.Entity("HxCore.Entity.Entities.T_BannerInfo", b =>
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

                    b.Property<string>("Disabled")
                        .HasColumnType("char(1)");

                    b.Property<string>("ImgUrl")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("LastModifier")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("LastModifierId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Link")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<int?>("OrderIndex")
                        .HasColumnType("int");

                    b.Property<string>("Target")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("T_BannerInfo");
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

                    b.Property<int>("BlogType")
                        .HasColumnType("int");

                    b.Property<string>("CanCmt")
                        .HasColumnType("char(1)");

                    b.Property<string>("CategoryId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<int>("CmtCount")
                        .HasColumnType("int");

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

                    b.Property<int>("FavCount")
                        .HasColumnType("int");

                    b.Property<string>("IsTop")
                        .HasColumnType("char(1)");

                    b.Property<string>("LastModifier")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("LastModifierId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("datetime");

                    b.Property<string>("MarkDown")
                        .HasColumnType("char(1)");

                    b.Property<string>("Publish")
                        .HasColumnType("char(1)");

                    b.Property<DateTime?>("PublishDate")
                        .HasColumnType("datetime");

                    b.Property<string>("PureContent")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<int>("ReadCount")
                        .HasColumnType("int");

                    b.Property<string>("SourceLink")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("T_Blog");
                });

            modelBuilder.Entity("HxCore.Entity.Entities.T_BlogExtend", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<string>("ContentHtml")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("T_BlogExtend");
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

                    b.ToTable("T_Category");
                });

            modelBuilder.Entity("HxCore.Entity.Entities.T_FriendLink", b =>
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

                    b.Property<string>("Link")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Logo")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int?>("OrderIndex")
                        .HasColumnType("int");

                    b.Property<string>("SiteName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("T_FriendLink");
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

                    b.Property<bool>("IsSystem")
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

            modelBuilder.Entity("HxCore.Entity.Entities.T_NoticeInfo", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Content")
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

                    b.Property<string>("LastModifier")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("LastModifierId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Link")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<int?>("OrderIndex")
                        .HasColumnType("int");

                    b.Property<string>("Target")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("T_NoticeInfo");
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
                        .HasColumnType("text");

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

            modelBuilder.Entity("HxCore.Entity.Entities.T_TagInfo", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("BGColor")
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

                    b.ToTable("T_TagInfo");
                });

            modelBuilder.Entity("HxCore.Entity.Entities.T_TimeLine", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Content")
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

                    b.Property<string>("LastModifier")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("LastModifierId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Link")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Target")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("T_TimeLine");
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
