using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcMusicStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //**********数据库初始化器************
            //使用EF的database类的SetInitializer设置代码优先方法
            //（当实体变化时重新创建数据库并迁移数据，应对项目前期开发时出现的表结构变化）
            //需要传入一个接口对象IDatabaseInitialzer，
            //该接口类的实现类其中之二为：DropCreateDatabaseIfModelChanges 和 DropCreateDatabaseAlways
            //两个实现类对象向上转型为IDatabaseInitialzer对象
            //DropCreateDatabaseIfModelChanges：当实体模型发生变化时重新创建数据库
            //DropCreateDatabaseAlways：总是重新创建数据库

            //Database.SetInitializer(new DropCreateDatabaseAlways<MusicStoreDBContext>());

            //为了每次重新创建数据库时为数据库初始化若干数据（播种数据库）
            //MusicStoreDbInitializer重写了DropCreateDatabaseAlways.Seed()方法
            Database.SetInitializer<MusicStoreDBContext>(new MusicStoreDbInitializer());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
