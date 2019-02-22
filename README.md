## 写在前面

>写于2018.9.12

我研究 IdentityServer4 是从.net core 1.1的时候开始的，那时候国内的中文资料比较少，我都是按照官方文档来研究的，整理成了笔记。这个系列文档，一些文章是完全翻译的，一些文章是采用翻译加我自己的经验结合而成的，还有一些根据国内的使用习惯进行了改编，比如第三方登录，官方文档用的google，而我用了国内用得非常多的QQ登录。我当时也没想到有这么多人看，还有就是当时对 IdentityServer4 的理解有限，在对一些专业术语的翻译上有所不足，但是直到现在我也一直在维护，对以前翻译不通顺的地方进行修改，对不足的地方及进行添加。最后谢谢大家的支持。

## 一.介绍

- [特性一览](http://www.cnblogs.com/stulzq/p/7376328.html "IdentityServer4（1）- 特性一览")

- [整体介绍](http://www.cnblogs.com/stulzq/p/7376606.html "IdentityServer4（2）- 整体介绍")

- [术语的解释](http://www.cnblogs.com/stulzq/p/7487734.html "IdentityServer4（3）- 术语的解释")

- [支持的规范](http://www.cnblogs.com/stulzq/p/7493318.html "支持的规范")

- [包和构建说明](http://www.cnblogs.com/stulzq/p/7493498.html "包和构建说明")

## 二.快速入门

- [设置和概述](http://www.cnblogs.com/stulzq/p/7493745.html "设置和概述")

- [#1 使用客户端证书控制API访问（客户端授权模式）](http://www.cnblogs.com/stulzq/p/7495129.html "使用客户端证书控制API访问（客户端授权模式）")

- [#2 使用密码认证方式控制API访问（资源所有者密码授权模式）](http://www.cnblogs.com/stulzq/p/7509648.html "使用密码认证方式控制API访问（资源所有者密码授权模式）")

- [#3 使用OpenId Connect添加用户认证（隐式/简化流程授权模式）](http://www.cnblogs.com/stulzq/p/7797341.html "使用OpenId Connect添加用户认证")

- [#4 添加外部认证支持之QQ登录（第三方登录，授权码模式）](http://www.cnblogs.com/stulzq/p/7879101.html "添加外部认证支持之QQ登录")

- [#5 使用Hybrid Flow（混合流程授权模式）并添加API访问控制](http://www.cnblogs.com/stulzq/p/7833480.html "使用Hybrid Flow并添加API访问控制")

- [#6 使用ASP.NET Core Identity](http://www.cnblogs.com/stulzq/p/8120129.html "使用ASP.NET Core Identity")

- [#7 使用JavaScript客户端](http://www.cnblogs.com/stulzq/p/8120211.html "使用JavaScript客户端")

- [#8 使用Entity Framework 存储配置和操作数据](http://www.cnblogs.com/stulzq/p/8120518.html "使用Entity Framework 存储配置和操作数据")

- [第三方快速入门和示例](http://www.cnblogs.com/stulzq/p/8120570.html "第三方快速入门和示例")

## 三.主题

- [启动说明](http://www.cnblogs.com/stulzq/p/8144056.html "启动说明")

- [定义资源](http://www.cnblogs.com/stulzq/p/8144185.html "定义资源")

- [定义客户端](http://www.cnblogs.com/stulzq/p/8144247.html "定义客户端")

- [登录](http://www.cnblogs.com/stulzq/p/8144344.html "登录")

- [使用第三方登录](http://www.cnblogs.com/stulzq/p/8144855.html "使用第三方登录")

- [使用Windows身份验证](http://www.cnblogs.com/stulzq/p/8145288.html "使用Windows身份验证")

- [注销](http://www.cnblogs.com/stulzq/p/8570695.html "注销")

## 四.扩展阅读（新手必看）

- [OAuth2授权](http://www.cnblogs.com/linianhui/p/oauth2-authorization.html "OAuth2授权")

- [OAuth2授权（续） & JWT(JSON Web Token)](http://www.cnblogs.com/linianhui/p/oauth2-extensions-protocol-and-json-web-token.html "OAuth2授权（续） & JWT(JSON Web Token)")

- [基于OAuth2的认证（译）](http://www.cnblogs.com/linianhui/p/authentication-based-on-oauth2.html "基于OAuth2的认证（译）")

- [OIDC（OpenId Connect）身份认证授权（核心部分）](http://www.cnblogs.com/linianhui/p/openid-connect-core.html "OIDC（OpenId Connect）身份认证授权（核心部分）") *必看

- [OIDC（OpenId Connect）身份认证授权（扩展部分）](http://www.cnblogs.com/linianhui/p/openid-connect-extension.html "OIDC（OpenId Connect）身份认证授权（扩展部分）")

- [OAuth2.0 知多少](http://www.cnblogs.com/sheng-jie/p/6564520.html "Auth2.0 知多少")

## 五.实战经验分享

- [IdentityServer4实战 - 基于角色的权限控制及Claim详解](http://www.cnblogs.com/stulzq/p/8726002.html)

- [IdentityServer4实战 - AccessToken 生命周期分析](http://www.cnblogs.com/stulzq/p/8998274.html)

- [IdentityServer4实战 - 必须使用HTTPS问题解析](https://www.cnblogs.com/stulzq/p/9594623.html)

- 5 Token加密和签名所用证书解析 (集群部署必看) 

- [IdentityServer4实战 - JWT Token Issuer 详解](https://www.cnblogs.com/stulzq/p/10339024.html)

- [IdentityServer4实战 - API与IdentityServer的交互过程解析](https://www.cnblogs.com/stulzq/p/9226059.html)

- [IdentityServer4实战 - 谈谈 JWT Token 的安全策略](https://www.cnblogs.com/stulzq/p/9678501.html)

- [IdentityServer4实战 - 与API单项目整合](https://www.cnblogs.com/stulzq/p/10346095.html)

>不能点击的是还未更新的

## 六.其他园友分享

- [IdentityServer4 知多少](https://www.cnblogs.com/sheng-jie/p/9430920.html) by 圣杰

- [关于 IdentityServer4 中的 Jwt Token 与 Reference Token](https://www.cnblogs.com/Irving/p/9357539.html) by 花儿笑弯了腰
