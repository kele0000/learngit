Use FlimDB
go
create table [FilmType]--电影类型表
(
FTypeID int  primary key not null,--电影类型ID
FTypeName nvarchar(256) not null,--电影类型名字
)
go
create table [Film]------电影表
(
 FID nvarchar(64) primary key ,--电影编号
 FTitle nvarchar(256) not null,--电影名称
  Director nvarchar(128)not null,--导演
  FTypeID  int references [FilmType](FTypeID),--电影类型
 Actor nvarchar(128) not null,--演员
 PublisherName  nvarchar(128),  ---产地
 PublishDate nvarchar(64) not null,  ---上映时期
 ISBN nvarchar(32) not null,--电影号（图片）
 FPrice money not null,--价格
 FDesc nvarchar(4000) not null,--电影简介
)
go
insert into [Film] values('20170001','王牌特工2：黄金圈','马修·沃恩','001','科林·费尔斯，马克·斯特朗，朱丽安·摩尔...','英国，美国/139分钟','2017-10-20大陆上映',20171019001,100000,'本片讲述了艾格西（塔伦·埃格顿 饰）由前集中的特工“菜鸟”升级为特工老手，他与梅林（马克·斯特朗 饰）将前往美国，与王牌特工组织的美国政治家（哈莉·贝瑞 饰）一起并肩作战。而他们所面对的敌人则是美艳狠毒的大反派波比（朱丽安·摩尔 饰）。')
insert into [FilmType]  values('001','动作')
insert into [Film] values('20170002','羞羞的铁拳','宋阳，张吃鱼','002','艾伦，马丽，沈腾..','中国大陆 / 100分钟','2017-09-30大陆上映',20171019002,90000,'本片讲述了靠打假拳混日子的艾迪生（艾伦 饰），本来和正义感十足的体育记者马小（马丽 饰）是一对冤家，没想到因为一场意外的电击，男女身体互换。性别错乱后，两人互坑互害，引发了拳坛的大地震，也揭开了假拳界的秘密，惹来一堆麻烦，最终两人在“卷莲门”副掌门张茱萸（沈腾 饰）的指点下，向恶势力挥起了羞羞的铁拳。')
insert into [FilmType]  values('002','喜剧')
insert into [Film] values('20170003','全球风暴','迪安·德夫林','003','杰拉德·巴特勒.吉姆·斯特吉斯.','美国 / 100分钟','2017-10-27大陆上映',20171019003,120000,'本片讲述了一系列突如其来的自然灾害威胁地球安危，于是全世界的领导者们通力合作，创造了一个复杂的气象卫星网络来控制天气，保障人民安全。然而这个卫星网络却出了问题——原本应该保护地球的系统开始攻击地球，一场席卷整个世界、摧毁一切的灭世浩劫从天而降……')
insert into [FilmType]  values('003','惊悚')
insert into [Film] values('20170004','雷神3：诸神黄昏','塔伊加·维迪提','004','克里斯·海姆斯沃.汤姆·希德勒斯顿','美国 / 135分钟','2017-11-03大陆上映',20171019004,120000,'在《雷神3》中，雷神托尔被囚禁于宇宙的另一端，竭尽全力想要赶回阿斯加德，阻止诸神黄昏的发生...。在赶回阿斯加德前，托尔必须先在危险的角斗场上存活下来，他的对手竟是曾经的伙伴绿巨人，而且托尔还失去了自己的神锤！')
insert into [FilmType]  values('004','灾难')
insert into [Film] values('20170005','时间去哪儿了','沃尔特·塞勒斯','005','马德哈尔·班达卡','中国 / 111分钟','2017-10-09大陆上映',20171019005,50000,'2017金砖国家电影合作计划“华丽之五”在第二届金砖国家电影节发布会上正式公布细节。该计划邀请来自巴西、俄罗斯、印度、中国、南非五个“金砖国家”的五位电影导演，分别以“时间去哪儿了”为主题拍摄一部电影短片，而五部独立的短片将汇集为一部片名为《时间去哪儿了》的集锦长片！')
insert into [FilmType]  values('005','剧情')
insert into [Film] values('20170006','心理罪之城市之光','徐纪周','006','邓超，刘诗诗','中国大陆','2017大陆上映',20171019006,200,'一起连环凶杀案掀起了城市的狂欢与躁动，数起案件中受害者均遭虐待致死，且充满仪式感，所有线索都与一个人有关——精通犯罪心理学的天才神探方木（邓超 饰）。在与同事米楠（刘诗诗 饰）调查案件时，方木发现曾经是自己高中同学的江亚（阮经天 饰）似乎深藏很多秘密.....')
insert into [FilmType]  values('006','犯罪')
insert into [Film] values('20170007','蝴蝶公墓','马伟豪','007','张俪','中国大陆 / 97分钟','2017大陆上映',20171019007,100,'本片讲述了舞蹈家尚小蝶（张俪 饰），为五年前离开的恋人编排了一支《蝶舞》，大获成功，但随着舞者宋优中毒、田巧坠楼、白露失踪，小蝶自己也受到威胁。一切谜团都指向了蝴蝶公墓……')
insert into [FilmType]  values('007','奇幻')
insert into [Film] values('20170008','你往哪里跑','刘镇伟','005','王迅','中国大陆 / 97分钟','2017大陆上映',20171019008,90,'单亲爸爸天山（王迅 饰）为了救患有先天性心脏病的儿子天佑佑（张峻豪 饰），在做“蜘蛛人”的时候，不小心看到了正在洗澡的大龄剩女七剑（张瑶 饰），又目睹了一起抢劫杀人案。恰巧负责协查这起杀人案的七剑，自然对天山紧追不舍，而后展开一系列曲折离奇的故事。')
insert into [FilmType]  values('007','奇幻')
go
select * from Film
--电影视图
create view vw_Film
as
select f.*,t.FTypeName
from Film f left join FilmType t on f.FTypeID=t.FTypeID
go

select * from vw_Film



create table [Customer]  --用户信息表
(

 ID nvarchar(64) primary key ,--用户编号
 LoginName nvarchar(8) not null,--登录用户名
 [Password] nvarchar(64) not null,-- 用户密码
 [CustomerName] nvarchar(16) ,--用户昵称
 [Email] nvarchar(128) ,--电子邮箱
 [Question] nvarchar(128),-- 密保问题
 [Answer] nvarchar(128),-- 密保答案
 [Phone] nvarchar(32),--联系电话
 [Gender] nvarchar(2),--性别
 )
 go
 --加入测试数据
 insert  into [Customer] (ID,[LoginName],[Password],CustomerName) values('01646','angel','666666','小鸡')
 insert  into [Customer] (ID,LoginName,[Password],CustomerName) values('2017110702','son','777777','小雅')
 insert  into [Customer] (ID,LoginName,[Password],CustomerName) values('2017110703','123456','666666','小狗')
 go
 select * from Customer 




)
go