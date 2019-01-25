using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Models
{
    public class MusicStoreDbInitializer : DropCreateDatabaseAlways<MusicStoreDBContext>
    {
        /// <summary>
        /// 重写Seed方法
        /// DropCreateDatabaseAlways类中的数据库播种方法
        /// 用于初始化数据库内部的一些数据，便于进行项目开发初期测试
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(MusicStoreDBContext context)
        {
            context.Artists.Add(new Artist { Name = "王军飞" });
            context.Genres.Add(new Genre { Name = "民谣"});
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "John Denver" },
                Genre = new Genre { Name = "乡村音乐" },
                Price = 9.99m,
                Title = "Country Road"
            });
            base.Seed(context);
        }
    }
}